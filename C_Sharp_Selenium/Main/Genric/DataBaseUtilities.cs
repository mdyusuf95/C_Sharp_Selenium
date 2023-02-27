using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace C_Sharp_Selenium.Main.Genric
{
    
    public class DataBaseUtilities
    {
        

        /// <summary>
        /// this method is get the all data present in perticular coloumn by using name of coloumn
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="TableName"></param>
        /// <param name="ColoumnName"></param>
        /// <returns></returns>
        public IList<String> GetAllDataFromPerticularColoumn(OdbcConnection connection, String TableName, String ColoumnName)
        {


            string query = "select " + ColoumnName + " from " + TableName + "";
            OdbcCommand command = new OdbcCommand(query, connection);
            var result = command.ExecuteReader();
            IList<string> data = new List<string>();

            while (result.Read())
            {
                data.Add(result.GetString(0));
            }

            return data;
        }

        /// <summary>
        /// this methos is use to get the the all data present in perticular coloumn by using index of coloumn
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="TableName"></param>
        /// <param name="IndexOfColoumn"></param>
        /// <returns></returns>
        public IList<String> GetAllDataFromPerticularColoumn(OdbcConnection connection, String TableName, int IndexOfColoumn)
        {

            string query = "select *  from " + TableName + "";
            OdbcCommand command = new OdbcCommand(query, connection);
            var result = command.ExecuteReader();
            IList<string> data = new List<string>();

            while (result.Read())
            {
                data.Add(result.GetString(IndexOfColoumn));
            }

            return data;

        }

        /// <summary>
        /// this method is use to varify data is present in perticular coloumn of table
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="TableName"></param>
        /// <param name="ColoumnName"></param>
        /// <param name="expectedData"></param>
        /// <returns></returns>
        public bool PerticularDataIsPresent(OdbcConnection connection, String TableName, String ColoumnName, String expectedData)
        {

            string query = "select " + ColoumnName + " from " + TableName + " Where " + ColoumnName + " = " + "'" + expectedData + "'";

            OdbcCommand command = new OdbcCommand(query, connection);
            var result = command.ExecuteReader();
            while (result.Read())
            {
                String data = result.GetString(0).Trim();
                if (data.Equals(expectedData))

                    return true;
            }

            return false;
        }

        public void PrintConnectionDetails(OdbcConnection connection)
        {
            Console.WriteLine(connection.ConnectionString);
            Console.WriteLine(connection.ConnectionTimeout);
            Console.WriteLine(connection.Database);
            Console.WriteLine(connection.Driver);
            Console.WriteLine(connection.ServerVersion);
        }

    }
}
