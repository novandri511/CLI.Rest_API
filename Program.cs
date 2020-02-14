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

            app.OnExecuteAsync(() =>
            {
                var client = new HttpClient();
                var content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                var result = await client.GetAsync("http://localhost:3000/todo",content);
                
                //var subject = optionSubject.HasValue()
                //   ? optionSubject.Value()
                //   : "world";

                Console.WriteLine(result);
            
            });

            return app.Execute(args);
        }
    }

}
