using Newtonsoft.Json;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class Account
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime DOB { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account
            {
                Name = "John Doe",
                Email = "john@nuget.org",
                DOB = new DateTime(1980, 2, 20, 0, 0, 0, DateTimeKind.Utc),
            };
            string json = JsonConvert.SerializeObject(account, Formatting.Indented);
            Console.WriteLine(json);

            /*//deserialize JSON
            string dj = @"{
'Name':'Good Boys',
'Genres': [
'Action','Comedy']
}";
            Account m = JsonConvert.DeserializeObject<Account>(dj);
            string name = m.Name;
            Console.WriteLine(name);*/

        }
    }
}
