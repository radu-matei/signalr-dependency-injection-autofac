using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace SignalRAutofac
{
    public class TestHub : Hub
    {
        public ITest Test { get; set; }
        public void Hello()
        {
            Test.DoStuff();
        }

        public override Task OnConnected()
        {
            Clients.Caller.hello("Welcome!");
            return base.OnConnected();
        }
    }
}