using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 int i = 33;            4 bytes 
			 float i = 22.22;       4 bytes
			  long i = 22           8 bytes
			double i =              8 bytes 
		    string n = "Imaran"     2 byte per charachter
			  char n = 'A';		    2 byte
			  bool i = true;        1 bit 
			 */

			// string n = Console.ReadLine();
			// Console.WriteLine(n);
			//Console.Read();

			int a = 32;
			//float b = 32.2;
			float b = 32.2F;
			double c = 32.2;
			double c1 = 32.2D;
			bool d = false;
			char c2 = 'A';
			string s1 = "This is string";


			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(c);
			Console.WriteLine(d);
			Console.WriteLine(c1);
			Console.WriteLine(c2);
			Console.WriteLine(s1);
			Console.Read();
		}
	}
}
