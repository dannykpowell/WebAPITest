﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebAPITest.Models
{
    public interface ITaskRepository : IRepository<Task>
    {
        Task GetByDate(DateTime queryDate);
    }
}
