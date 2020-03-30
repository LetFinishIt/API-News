using System;
namespace CallApi
{
    public  static class GuardianNews
    {
        const string url = "https://content.guardianapis.com/search";
        //const string apiKey = "b539faac-99b3-4bbc-a552-bf890c8bf734";
        //const string content = "COVID19";
        
        public static  Article GetArticle(string content)
        {
            string urlParameters = $"search?q={content}&api-key=b539faac-99b3-4bbc-a552-bf890c8bf734";
            var response = APICall.RunAsync<Article>(url,urlParameters).GetAwaiter().GetResult();
            return response;
        }
    }
}

   