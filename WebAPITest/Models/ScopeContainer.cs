using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Microsoft.Practices.Unity;

namespace WebAPITest.Models
{
    public class ScopeContainer : IDependencyScope
    {
        protected IUnityContainer Container;

        public ScopeContainer(IUnityContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }
            this.Container = container;
        }

        public object GetService(Type serviceType)
        {
            if (Container.IsRegistered(serviceType))
            {
                return Container.Resolve(serviceType);
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            if (Container.IsRegistered(serviceType))
            {
                return Container.ResolveAll(serviceType);
            }
            else
            {
                return new List<object>();
            }
        }

        public void Dispose()
        {
            Container.Dispose();
        }
    }
}