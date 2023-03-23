using C_Sharp_Selenium.Main.Genric;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_Sharp_Selenium.Tests
{
    [TestClass]
    [Ignore]
    public class pro
    {
        [TestMethod]
        public void progrsmee()
        {
           CShapUtilities cShap=new CShapUtilities();
            var f=cShap.GetUniqueString(5);
            var a = cShap.GetUniqueString(5);


            Console.WriteLine(f.ToUpper()+a);

        }

        [TestMethod]
        public void getLength()
        {
            string s = "stringlenth";
            
            int lenght = 0;
            while(true)
            {
                try
                { 

                   var l=s[lenght];
                    lenght++;
                    
                }
                catch(Exception e)
                {
                    
                    Console.WriteLine(lenght);
                    break;
                }
            }


        }
        [TestMethod]
        public void ReverseTheWords()
        {
            string s = "myy name is yusuf bagwan";
             string []s1= s.Split(' ');
            for(int i=0;i<s1.Length;i++)
            {
                for(int j = s1[i].Length-1; j >=0 ;j--)
                {
                    Console.Write(s1[i][j]);
                }
                Console.Write(" ");
            }
        }

        [TestMethod]
        public void list()
        {
            var names =new List<string>();
            names.Add("yusuf");
            names.Add("rm");
            names.Add("gahat");
            var names2 = new List<string>(names);
            names2.Add("yusuf");
            names2.Add("kumr");
         
            Console.WriteLine(names2.Contains("yusuf"));
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

        }
        [TestMethod]
        public void hasset()
        {
            var names = new HashSet<string>();
            names.Add("yusuf");
            names.Add("varun");
            names.Add("yusuf");
            names.Add("varun");
            names.Add("yusuf");
            names.Add("varun");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

        }

        [TestMethod]
        public void sortedset()
        {
            var names = new SortedSet<string>();
            names.Add("yusuf1");
            names.Add("varun2");
            names.Add("yusuf3");
            names.Add("varun4");
            names.Add("yusuf5");
            names.Add("varun6");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }

        [TestMethod]
        public void stack()
        {
            var names = new Stack<string>();
            names.Push("yusuf1");
            names.Push("varun2");
            names.Push("yusuf3");
            names.Push("varun4");
            names.Push("yusuf5");
            names.Push("varun6");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }

        [TestMethod]
        public void linkedlist()
        {
            var names = new LinkedList<string>();
            names.AddLast("Sonoo Jaiswal");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");
            names.AddFirst("John");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
        [TestMethod]
        public void dictionary()
        {
           var names =new Dictionary<int, string>();
            names.Add(2, "bhum");
            names.Add(3, "soom");
            names.Add(4, "jooom");
            names.Add(1, "mohamjadaru");
           

            foreach(KeyValuePair<int, string> name in names)

            {
                Console.WriteLine(name.Key+" "+name.Value);
            }

        }
        [TestMethod]
        public void sortedlist()
        {
            var names = new SortedList<int, string>();
            names.Add(2, "bhum");
            names.Add(3, "soom");
            names.Add(4, "jooom");
            names.Add(1, "mohamjadaru");
            


            foreach (KeyValuePair<int, string> name in names)

            {
                Console.WriteLine(name.Key + " " + name.Value);
            }

        }
        
        public static void Main()
        {
            for(int i = 10; i >=0; i--)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }

            

        }
        [TestMethod]
        public void sumInteger()
        {
            string s = "asd45l8ee61kl89";
            int sum = 0;
            int tsum=0;
            for(int i =0; i < s.Length; i++)
            { 
                char c = s[i];
                if(c>='0'&&c<='9')
                {
                    sum =sum*10+(c-48); 
                }
                else
                {
                    tsum =tsum+ sum;
                    sum = 0;
                }
            }
            Console.WriteLine(tsum+sum);

        }
        [TestMethod]
        public void revertheNumber()
        {
            int num = 12345;
            Console.WriteLine(rever(num));

        }

        public  int rever(int num)
        {
            int rev = 0;

            do 
            {  
                int d = num % 10;
                rev =rev*10+d;
                num=num/10;

            }while (num!=0);

            return rev;
        }
        [TestMethod]
        public void Database()
        {
            string connectionString = "Server=localhost:1433;Database=Projects;Uid=root;Pwd=root;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Project", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[1].ToString());
            }
        }
      
       
    }
}
