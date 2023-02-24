using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string h = "This is string value";
			Console.WriteLine(h.Length);
			Console.WriteLine(h.ToUpper());
			Console.WriteLine(h.ToLower());
			Console.WriteLine(h+ " and very strong variable data type");
			Console.WriteLine(string.Concat(h , " this is concate"));

			//string intercollation
			Console.Write("Enter Student name ");
			string name  = Console.ReadLine();
			Console.Write("Enter Student grade ");
			string grade = Console.ReadLine();
			Console.Write("Enter Student marks ");
			string marks = Console.ReadLine();
			Console.WriteLine($"Student Name = {name} Grade = {grade} and Marks = {marks} ");

			string hello = "This is New String for index";
			Console.WriteLine("First index is " + hello[0]);
			Console.WriteLine("Find specific word is " + hello.IndexOf("for"));

			Console.WriteLine("Enter string value");
			string s = Console.ReadLine();
			Console.WriteLine(s.IndexOf("This"));
			Console.WriteLine(s.Substring(8));

			Console.ReadLine();
		}
	}
}
