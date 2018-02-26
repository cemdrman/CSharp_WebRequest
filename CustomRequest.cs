using System;
using System.IO;
using System.Net;

namespace Test
{
    public class CustomRequest
    {
       

        private CustomRequest()
        {
        }

        public static string sendRequest(string requestUrl, string requestMethod){
            
            if(requestUrl == null && requestMethod == null){
                return "empty";
            }else{
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                request.Method = requestMethod;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string userJsonArray = reader.ReadToEnd();
                if (userJsonArray != null){
                    return userJsonArray;
                }else{
                    return "empty";
                }
            }
        }
    }
}
