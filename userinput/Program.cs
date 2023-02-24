using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userinput
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter User Name");
			String s = Console.ReadLine();
			Console.WriteLine("User Name :" + s);
			
			
			Console .WriteLine("Enter your marks ");
			string n = Console.ReadLine();
			//Console.WriteLine("your marks will add 10 bonus marks:" + n + 1);
			//Console.WriteLine("your marks will add 10 bonus marks:" + Convert.ToInt32(n) + 1);
			Console.WriteLine("your marks will add 10 bonus marks:" + (Convert.ToInt32(n) + 1));

			Console.ReadLine();


		}
	}
}
