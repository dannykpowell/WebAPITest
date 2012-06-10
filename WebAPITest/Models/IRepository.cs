using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebAPITest.Models
{
    public interface IRepository<T> where T :IEntity
    {
        /// <summary>
        /// Lists this instance.
        /// </summary>
        /// <returns>A List of T.</returns>
        IEnumerable<T> List();

        /// <summary>
        /// Gets the specified id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>A T.</returns>
        T Get(int id);

        /// <summary>
        /// Deletes the specified id.
        /// </summary>
        /// <param name="id">The id.</param>
        void Delete(int id);

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>A T.</returns>
        T Add(T entity);

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>A T.</returns>
        T Update(T entity);
    }
}
