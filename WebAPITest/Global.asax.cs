﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Practices.Unity;
using Raven.Client;
using Raven.Client.Document;
using WebAPITest.Controllers;
using WebAPITest.Models;

namespace WebAPITest
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RegisterDependencies();

            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void RegisterDependencies()
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<TaskController>();

            container.RegisterType<IDocumentStore, DocumentStore>(
                new HierarchicalLifetimeManager());

            container.RegisterInstance<DocumentStore>(DataDocumentStore.Initialize());

            container.RegisterType<ITaskRepository, TaskRepository>(
                new InjectionConstructor(container.Resolve<IDocumentStore>()));

            //container.RegisterType<ITaskRepository, TaskRepository>(
            //    new HierarchicalLifetimeManager());

            GlobalConfiguration.Configuration.DependencyResolver = new IoCContainer(container);

        }
    }
}