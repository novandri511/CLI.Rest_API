using System;
using System.Threading.Tasks;
using System.Net.Http;
using McMaster.Extensions.CommandLineUtils;

namespace restapinya
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var app = new CommandLineApplication();

            app.HelpOption();
            var optionSubject = app.Option("-s|--subject <SUBJECT>", "The subject", CommandOptionType.SingleValue);

            app.Async.OnExecute(() =>
            {
                var client = new HttpClient();
                var result = await client.PostAsync("http://localhost:3000/todo", HttpContent content);
                //var subject = optionSubject.HasValue()
                 //   ? optionSubject.Value()
                 //   : "world";
                 
                Console.WriteLine(result);
            
            });

            return app.Execute(args);
        }
    }

}
