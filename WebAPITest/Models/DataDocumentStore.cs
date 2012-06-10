using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Raven.Client;
using Raven.Client.Document;

namespace WebAPITest.Models
{
    public class DataDocumentStore //: IDataDocumentStore
    {
        private static DocumentStore _instance;

        public static DocumentStore Instance
        {
            get
            {
                if (_instance == null)
                    throw new InvalidOperationException(
                      "IDocumentStore has not been initialized.");
                return _instance;
            }
        }

        public static DocumentStore Initialize()
        {
            _instance = new DocumentStore { Url = ConfigurationManager.ConnectionStrings["RavenDb"].ConnectionString };
            _instance.Initialize();
            return _instance;
        }
    }
}