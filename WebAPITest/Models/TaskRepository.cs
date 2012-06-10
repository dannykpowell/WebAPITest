using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Raven.Client;

namespace WebAPITest.Models
{
    public class TaskRepository : ITaskRepository
    {
        private readonly IDocumentStore _store = null;

        public TaskRepository(IDocumentStore store)
        {
            _store = store;
        }

        public IEnumerable<Task> List()
        {

            IEnumerable<Task> rettask;

            using (IDocumentSession session = _store.OpenSession())
            {
                var tasks = from mytask in session.Query<Task>()
                            select mytask;

                rettask = tasks.ToList();
            }
            return rettask;
        }

        public Task Get(int id)
        {
            Task rettask;

            using (IDocumentSession session = _store.OpenSession())
            {
                var tasks = from mytask in session.Query<Task>()
                            where mytask.TaskId == id
                            select mytask;

                rettask = tasks.SingleOrDefault();
            }
            return rettask;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Add(Task entity)
        {
            using (IDocumentSession session = _store.OpenSession())
            {
                session.Store(entity);
                session.SaveChanges();
            }
            return entity;
        }

        public Task Update(Task entity)
        {
            //using (IDocumentSession session = _store.OpenSession())
            //{
            //    var wawel = session.Load<Task>("locations/1");
            //    wawel.Description = "changed description";
            //    session.SaveChanges();
            //}
            throw new NotImplementedException();
        }

        public Task GetByDate(DateTime queryDate)
        {
            Task rettask;

            using (IDocumentSession session = _store.OpenSession())
            {
                var tasks = from mytask in session.Query<Task>()
                            where mytask.TaskDate.Date == queryDate.Date
                            select mytask;

                rettask = tasks.SingleOrDefault();
            }
            return rettask;
        }

        public IEnumerable<Task> GetAllTasks()
        {
            IEnumerable<Task> rettask;

            using (IDocumentSession session = _store.OpenSession())
            {
                var tasks = from mytask in session.Query<Task>()
                            select mytask;

                rettask = tasks.ToList();
            }
            return rettask;
        }
    }
}