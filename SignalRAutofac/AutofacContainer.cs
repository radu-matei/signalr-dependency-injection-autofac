using Autofac;
using Autofac.Integration.SignalR;
using System.Reflection;

namespace SignalRAutofac
{
    public class AutofacContainer
    {
        public IContainer Container { get; set; }
        public AutofacContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterHubs(Assembly.GetExecutingAssembly())
                .PropertiesAutowired();
            builder.RegisterType<Test>()
                .As<ITest>()
                .PropertiesAutowired();

            Container = builder.Build();
        }
    }
}