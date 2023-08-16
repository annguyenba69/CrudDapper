using Microsoft.Extensions.Configuration;
using MvcMovie.Controllers;
using MvcMovie.Repository;
using MvcMovie.Service;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace MvcMovie
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IProductRepository, ProductService>();
            container.RegisterType<IPostRepository, PostService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}