using Autofac;
using Autofac.Integration.SignalR;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Infrastructure;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRAutofac.Startup))]

namespace SignalRAutofac
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            var container = new AutofacContainer().Container;

            var resolver = new AutofacDependencyResolver(container);
            

            app.UseAutofacMiddleware(container);

            app.MapSignalR(new HubConfiguration
            {
                Resolver = resolver
            });
 
            AddSignalRInjection(container, resolver);
        }

        private void AddSignalRInjection(IContainer container,IDependencyResolver resolver)
        {
            var updater = new ContainerBuilder();

            updater.RegisterInstance(resolver.Resolve<IConnectionManager>());
            updater.Update(container);
        }

    }
}
