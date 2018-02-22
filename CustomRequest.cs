using System;
using System.IO;
using System.Net;

namespace Test
{
    public class CustomRequest
    {
        private string requestUrl;
        private string requestMethod;

        public CustomRequest()
        {
        }

        public string sendRequest(string requestUrl, string requestMethod){
            if(requestUrl == null && requestMethod == null){
                this.requestUrl = "http://localhost:4000/api/users";
                this.requestMethod = "GET";
            }else{
                this.requestUrl = requestUrl;
                this.requestMethod = requestMethod;
            }
                
            HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
            request.Method = requestMethod;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string userJsonArray = reader.ReadToEnd();
            if (userJsonArray != null)
                return userJsonArray;
            else
                return "empty";
        }
    }
}
