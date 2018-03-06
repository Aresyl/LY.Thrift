using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LY.Thrift.HostService;

namespace LY.Thrift
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            using (TestService service = new TestService())
            {
                service.OnStart();//服务启动
                Console.Read();//阻塞线程
                service.Stop();//停止服务
            }
#else

#endif
        }
    }
}
