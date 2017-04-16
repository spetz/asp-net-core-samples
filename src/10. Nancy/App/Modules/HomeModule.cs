using Nancy;

namespace App.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("", args => "Nancy says hello!");
        }
    }
}