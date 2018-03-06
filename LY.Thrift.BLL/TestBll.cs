using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LY.Thrift.IDL;

namespace LY.Thrift.BLL
{
    public class TestBll: TestService.Iface
    {
        public TestResponseModel Test( TestRequestModel model)
        {
            return new TestResponseModel() { Ee= model.Ee+"123456" };
        }
    }
}
