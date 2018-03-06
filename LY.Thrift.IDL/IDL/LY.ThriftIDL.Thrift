namespace csharp LY.Thrift.IDL

struct TestRequestModel{
1:bool isTrue,
3:i16 aa,
4:i32 bb,
5:i64 cc,
6:double dd,
7:string ee,
8:list<string> ff
}

struct TestResponseModel{
1:bool isTrue,
3:i16 aa,
4:i32 bb,
5:i64 cc,
6:double dd,
7:string ee,
8:list<string> ff
}

service TestService{
        //测试
        TestResponseModel Test(1:TestRequestModel model),
}