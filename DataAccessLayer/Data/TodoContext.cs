using System.Data.Entity;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext() : base("name = TodosContextDB")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TodoContext>());
        }

        public DbSet<Todo> Todos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
