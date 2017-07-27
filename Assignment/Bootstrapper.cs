using System.Web.Mvc;
using Assignment.InfraStructure.Repository;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using Assignment.InfraStructure.Service;
using Assignment.InfraStructure.Business;

namespace Assignment
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IUserBusiness, UserBusiness>();
           
            return container;
        }
    }
}