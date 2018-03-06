using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using log4net;
using LY.Thrift.BLL;
using Thrift.Server;
using Thrift.Transport;

namespace LY.Thrift.HostService
{
    partial class TestService : ServiceBase
    {
        /// <summary>
        /// 日志记录器
        /// </summary>
        public static ILog _log = LogManager.GetLogger(typeof(TestService));
        public TestService()
        {
            InitializeComponent();
        }
        public void OnStart()
        {
            OnStart(null);
        }
        protected override void OnStart(string[] args)
        {
            //启动Thrift
            OnStartThrift();
        }

        protected override void OnStop()
        {
            // TODO: 在此处添加代码以执行停止服务所需的关闭操作。
        }
        /// <summary>
        /// 启动Thrift
        /// </summary>
        private void OnStartThrift()
        {
            Task.Run(() =>
            {
                try
                {
                    _log.Info("【Thrift】服务开始启动！！！");
                    var thriftServerPort = 8503;

                    // 初始化Thrift服务端
                    var processor = new LY.Thrift.IDL.TestService.Processor(new TestBll());
                    TServerTransport serverTransport = new TServerSocket(thriftServerPort);
                    TServer rpcServer = new TThreadPoolServer(processor, serverTransport);

                    // 开始监听
                    _log.Info($"【Thrift】服务启动完成, 开始监听端口：{thriftServerPort}的请求！！！");
                    rpcServer.Serve();
                }
                catch (Exception ex)
                {
                    _log.Error($"【Thrift】服务启动异常：", ex);
                }
            });
        }
    }
}
