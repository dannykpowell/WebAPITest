using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPITest.Models;

namespace WebAPITest.Controllers
{
    public class TaskController : ApiController
    {
        static ITaskRepository _repository;
        public TaskController(ITaskRepository repository)
    {
        if (repository == null)
        {
            throw new ArgumentNullException("repository");
        }
        _repository = repository;
    }

        public Task GetTask(DateTime taskdate)
        {
            Task task = _repository.GetByDate(taskdate);
            if (task == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized));
            }
            return task;
        }
    }
}
