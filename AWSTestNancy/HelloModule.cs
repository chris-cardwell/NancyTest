using Nancy;

namespace AWSTestNancy
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get["/"] = parameters => "Hello World2";
        }
    }
}