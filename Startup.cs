using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Line2.Startup))]

namespace Line2
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // アプリケーションの設定方法の詳細については、http://go.microsoft.com/fwlink/?LinkID=316888 を参照してください
            app.MapSignalR();
        }
    }
}
