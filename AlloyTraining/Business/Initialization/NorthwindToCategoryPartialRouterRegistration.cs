using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System.Web.Routing;
using EPiServer.Web.Routing;
using AlloyTraining.Business.PartialRouters;

namespace AlloyTraining.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class NorthwindToCategoryPartialRouterRegistration : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            RouteTable.Routes.RegisterPartialRouter(
                new NorthwindToCategoryPartialRouter());
        }
        public void Preload(string[] parameters) { }
        public void Uninitialize(InitializationEngine context) { }
    }
}