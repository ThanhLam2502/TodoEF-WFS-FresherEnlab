using BusinessLogicLayer;
using DataAccessLayer;
using DataAccessLayer.Entity;
using System;
using System.Windows.Forms;

namespace ToDoEF
{
    public partial class FormAdd : Form
    {
        private readonly ITodoService _todoService;
        private readonly Validate _validate;
        public FormAdd(ITodoService todoSercive)
        {
            InitializeComponent();
            _todoService = todoSercive;
            _validate = new Validate();

            dateCreate.Value = DateTime.Now;
            dateFinish.Value = DateTime.Now;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Todo task = GetTaskFromUI();
            if (_validate.IsValidTask(task))
            {
                _todoService.AddTodo(task);
                Close();
            }
            else
            {
                MessageBox.Show("DATA IS INVALID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Todo GetTaskFromUI()
        {
            return new Todo()
            {
                Title = txtTile.Text,
                Description = txtDescripton.Text,
                CreatedDate = dateCreate.Value,
                FinishDate = dateFinish.Value,
                Status = Status.BackLog,
            };
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
