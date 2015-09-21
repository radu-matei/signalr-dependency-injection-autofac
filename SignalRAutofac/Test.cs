using Microsoft.AspNet.SignalR.Infrastructure;

namespace SignalRAutofac
{
    public class Test : ITest
    {
        public IConnectionManager ConnectionManager{ get; set; }
        public void DoStuff()
        {
            var context = ConnectionManager.GetHubContext<TestHub>();
            context.Clients.All.hello("Hello!:)");
            
        }
    }
}