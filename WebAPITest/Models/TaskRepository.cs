using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPITest.Models
{
    public class TaskRepository : ITaskRepository
    {
        private List<Task> _tasks = new List<Task>();
        private int _nextId = 1;

        public TaskRepository()
        {
            this.Add(new Task() {TaskDate = DateTime.Now.Date, Primary = "Bob", Secondary="Barry"});
            this.Add(new Task() { TaskDate = DateTime.Now.Date.AddDays(1), Primary = "Mike", Secondary = "Barry" });
            this.Add(new Task() { TaskDate = DateTime.Now.Date.AddDays(2), Primary = "Andy", Secondary = "Barry" });
            this.Add(new Task() { TaskDate = DateTime.Now.Date.AddDays(3), Primary = "Chris", Secondary = "Barry" });
            this.Add(new Task() { TaskDate = DateTime.Now.Date.AddDays(4), Primary = "Sean", Secondary = "Danny" });
            this.Add(new Task() { TaskDate = DateTime.Now.Date.AddDays(5), Primary = "Fred", Secondary = "Danny" });
            this.Add(new Task() { TaskDate = DateTime.Now.Date.AddDays(6), Primary = "Wes", Secondary = "Danny" });
            this.Add(new Task() { TaskDate = DateTime.Now.Date.AddDays(7), Primary = "Andy", Secondary = "Danny" });
        }

        public IEnumerable<Task> List()
        {
            throw new NotImplementedException();
        }

        public Task Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Add(Task task)
        {
            task.TaskId = _nextId++;
            _tasks.Add(task);
            return task;
        }

        public Task Update(Task entity)
        {
            throw new NotImplementedException();
        }

        public Task GetByDate(DateTime queryDate)
        {
            return _tasks.Find(c => c.TaskDate.ToShortDateString() == queryDate.ToShortDateString() );
        }

        //private readonly IDocumentStore _store = null;

        //public TaskRepository(IDocumentStore store)
        //{
        //    _store = store;
        //}

        //public IEnumerable<Task> List()
        //{

        //    IEnumerable<Task> rettask;

        //    using (IDocumentSession session = _store.OpenSession())
        //    {
        //        var tasks = from mytask in session.Query<Task>()
        //                    select mytask;

        //        rettask = tasks.ToList();
        //    }
        //    return rettask;
        //}

        //public Task Get(int id)
        //{
        //    Task rettask;

        //    using (IDocumentSession session = _store.OpenSession())
        //    {
        //        var tasks = from mytask in session.Query<Task>()
        //                    where mytask.TaskId == id
        //                    select mytask;

        //        rettask = tasks.SingleOrDefault();
        //    }
        //    return rettask;
        //}

        //public void Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task Add(Task entity)
        //{
        //    using (IDocumentSession session = _store.OpenSession())
        //    {
        //        session.Store(entity);
        //        session.SaveChanges();
        //    }
        //    return entity;
        //}

        //public Task Update(Task entity)
        //{
        //    //using (IDocumentSession session = _store.OpenSession())
        //    //{
        //    //    var wawel = session.Load<Task>("locations/1");
        //    //    wawel.Description = "changed description";
        //    //    session.SaveChanges();
        //    //}
        //    throw new NotImplementedException();
        //}

        //public Task GetByDate(DateTime queryDate)
        //{
        //    Task rettask;

        //    using (IDocumentSession session = _store.OpenSession())
        //    {
        //        var tasks = from mytask in session.Query<Task>()
        //                    where mytask.TaskDate == queryDate
        //                    select mytask;

        //        rettask = tasks.SingleOrDefault();
        //    }
        //    return rettask;
        //}
    }
}