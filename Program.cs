using System;
using System.Net;
using Newtonsoft.Json;
using System.Threading.Tasks;
using NewsApiTest.Models;
using System.Net.Http;

namespace NewsApiTest
{
    class Program
    {
          private const string AppKey = "c8c7588108404830ba72ecc1fb7aa12b";
        static void Main(string[] args)
        {
            var client = new HttpClient();    
            var response = client.GetAsync(new Uri($"http://newsapi.org/v2/top-headlines?country=ru&apiKey={AppKey}")).GetAwaiter().GetResult();
            string json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            var news = JsonConvert.DeserializeObject<ArticleRoot>(json);
            Console.WriteLine("Пять новых новостей в России");
            for(var i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Новость {i}: "+ news.Article[i].Title);
                Console.WriteLine("Дата публикации: " + news.Article[i].PublishedAt);
            }
                

        }
    }
}
