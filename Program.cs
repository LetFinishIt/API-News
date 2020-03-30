 using System;

namespace CallApi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter search content");
            string x = Console.ReadLine();
            ShowArticle(x);
        }

        private static void ShowArticle(string content)
        {
            var response = GuardianNews.GetArticle(content);

            Console.WriteLine($"status : {response.response.status}");
            Console.WriteLine($"page: {response.response.page}");
            Console.WriteLine($"total: {response.response.total}");
            Console.WriteLine();

            Console.WriteLine($"{"ID",-40} {"Section Name",-50}" );

            for (int i = 0; i < response.response.Results.Length; i++)
            {
                Console.WriteLine(response.response.Results[i].sectionId + response.response.Results[i].sectionName
                    +response.response.Results[i].ID) ;
            }
            Console.ReadLine();
        }
    }
}