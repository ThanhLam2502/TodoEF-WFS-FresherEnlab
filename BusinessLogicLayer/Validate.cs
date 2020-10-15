using DataAccessLayer.Entity;

namespace BusinessLogicLayer
{
    public class Validate
    {
        public bool IsValidTask(Todo task)
        {
            return !string.IsNullOrEmpty(task.Title)
                && !string.IsNullOrEmpty(task.Description)
                && task.FinishDate >= task.CreatedDate;
        }
    }
}
