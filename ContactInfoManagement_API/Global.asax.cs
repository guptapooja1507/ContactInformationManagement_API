using ContactInfoManagement_API.BusinessLayer.Implementation;
using ContactInfoManagement_API.BusinessLayer.Interface;
using ContactInfoManagement_API.DataAccessLayer.Implementation;
using ContactInfoManagement_API.DataAccessLayer.Interface;
using ContactInfoManagement_API.Resolver;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
//using ContactInfoManagement_API.App_Start;
//using ContactInfoManagement_API.BusinessLayer;
//using ContactInfoManagement_API.DataAccessLayer;

namespace ContactInfoManagement_API
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var container = new Container();
            container.Register<IContactRepository, ContactRepository>();
            container.Register<IContactManager, ContactManager>();
            
            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorDependencyResolver(container);
        }
    }
}