using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.CSharp;

namespace Test
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            List<User> users = userJsonDeserialize(CustomRequest.sendRequest("http://localhost:4000/api/users","GET"));

            foreach (User user in users) {
                Console.WriteLine("{0} {1}", user.name,user.surname);
            }
                      
        }

        private static List<User> userJsonDeserialize(string userJsonArray){

            List<User> users = JsonConvert.DeserializeObject<List<User>>(userJsonArray);

            return users;
        }

    }
}
