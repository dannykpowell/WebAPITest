using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPITest.Models
{
    public class Task : IEntity
    {
        /// <summary>
        /// Gets or sets the task id.
        /// </summary>
        /// <value>
        /// The task id.
        /// </value>
        public int TaskId { get; set; }

        /// <summary>
        /// Gets or sets the primary.
        /// </summary>
        /// <value>
        /// The primary.
        /// </value>
        public string Primary { get; set; }

        /// <summary>
        /// Gets or sets the secondary.
        /// </summary>
        /// <value>
        /// The secondary.
        /// </value>
        public string Secondary { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public DateTime TaskDate { get; set; }
    }
}