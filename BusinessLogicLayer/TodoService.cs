using DataAccessLayer;
using DataAccessLayer.Data;
using DataAccessLayer.Entity;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public class TodoService : ITodoService
    {
        private readonly UnitOfWork _unitOfWork;
        public TodoService()
        {
            _unitOfWork = new UnitOfWork(new TodoContext());
        }

        public void AddTask(Todo task)
        {
            _unitOfWork.TodoRepository.AddTask(task);
        }

        public List<Todo> GetTaskByStatus(Status status)
        {
            return _unitOfWork.TodoRepository.GetTaskByStatus(status);
        }

        public void SetStatusByLstName(Todo task, string name)
        {
            if (name.Equals("lstBackLog"))
                task.Status = Status.BackLog;

            if (name.Equals("lstResolved"))
                task.Status = Status.Resolved;

            if (name.Equals("lstClosed"))
                task.Status = Status.Closed;

            _unitOfWork.TodoRepository.UpdateStatusByID(task);
        }
    }
}
