using System;
using LY.Thrift.IDL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Thrift.Protocol;
using Thrift.Transport;

namespace LY.Thrift.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TTransport transport = new TSocket("127.0.0.1", 8503);
            TProtocol protocol = new TBinaryProtocol(transport);
            var client = new  TestService.Client(protocol);
            transport.Open();
            var send = new TestRequestModel(){Ee="0987"};
            var result = client.Test(send);
            Console.WriteLine(result);
        }
    }
}
