using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebAPITest.Models
{
    public interface ITaskRepository : IRepository<Task>
    {
        IEnumerable<Task> GetAllTasks();
        
        Task GetByDate(DateTime queryDate);
    }
}
