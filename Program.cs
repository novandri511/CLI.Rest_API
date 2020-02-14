using System;
using System.Threading.Tasks;
using System.Net.Http;
using McMaster.Extensions.CommandLineUtils;

namespace restapinya
{

    [Subcommand(
        typeof(GetUser)
        )]
    public class Program
    {
        [Command(Description = "Get Users", Name = "getuser")]
        public static int Main(string[] args) => CommandLineApplication.ExecuteAsync<Program>(args);

        class GetUser
        {
            public async Task OnExecuteAsync()
            {
               // var client = new HttpClient();
                //var result = await client.GetStringAsync("http://localhost:3000/users");
               // Console.WriteLine(result);

            }
        }



    }
    

    
}
