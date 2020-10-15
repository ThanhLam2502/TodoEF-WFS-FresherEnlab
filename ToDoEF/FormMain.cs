using BusinessLogicLayer;
using DataAccessLayer;
using DataAccessLayer.Entity;
using System.Windows.Forms;

namespace ToDoEF
{
    public partial class FormMain : Form
    {
        private readonly ITodoService _service;
        public FormMain()
        {
            InitializeComponent();

            _service = new TodoService();
            DisplayTasks();
        }
        internal void DisplayTasks()
        {
            DisplayTaskByStatus(Status.BackLog, lstBackLog);
            DisplayTaskByStatus(Status.Resolved, lstResolved);
            DisplayTaskByStatus(Status.Closed, lstClosed);
        }
        private void DisplayTaskByStatus(Status status, ListBox listBox)
        {
            listBox.DisplayMember = "Title";
            listBox.DataSource = _service.GetTaskByStatus(status);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            FormAdd frmAdd = new FormAdd(_service);
            frmAdd.ShowDialog();
            DisplayTasks();
        }
        private void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            var listBox = (ListBox)sender;

            int index = listBox.IndexFromPoint(e.X, e.Y);
            if (index == -1)
                return;

            var task = (Todo)listBox.Items[listBox.SelectedIndex];
            listBox.DoDragDrop(task, DragDropEffects.All);
        }

        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            var listBox = (ListBox)sender;

            if (e.Data.GetDataPresent(typeof(Todo)))
            {
                var task = (Todo)e.Data.GetData(typeof(Todo));
                _service.SetStatusByLstName(task, listBox.Name);

                DisplayTasks();
            }
        }
        private void listBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}
