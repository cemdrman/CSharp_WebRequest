using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Test
{


    /* Singleton DataBase Class
     * 
     * 
     */
    public class MySqlDatabase
    {

        private static MySqlConnection connection;
        private static MySqlDatabase mySqlDB;
        private static bool isConnected = false;

        private MySqlDatabase()
        {
        }

        /*returns MySql-Database connection
         */
        public static MySqlDatabase mySqlDBConnection(string connectionUrl, string dbUser, string dbUserPass){
            if(mySqlDB == null){
                mySqlDB = new MySqlDatabase();
                connection = new MySqlConnection();
                return mySqlDB;
            }
            return mySqlDB;
        }

        public void connect(){
            try {
                connection.Open();
                if (connection.State != ConnectionState.Closed){
                    Console.WriteLine("Connection has been created successfully");
                    isConnected = true;
                }else{
                    Console.WriteLine("Connection Failed...!");
                }
            }
            catch (Exception err) {
                Console.WriteLine("Hata! " + err.Message, "Hata Oluştu");
            }
        }

        public void insert(){
            
            string insertQuery = "";
            if(isConnected){
                Console.WriteLine("DB is ready to insert");
                MySqlCommand command = new MySqlCommand(insertQuery,connection);
            }else{
                
            }

        }

        public void delete(){
            
        }

        public User[] getAllUser(){
            
            return new User[6];
        }

        /*
         *returns true: if method find user in db
         */
        public bool findUser(int id){
            return true;
        }

    }
}
