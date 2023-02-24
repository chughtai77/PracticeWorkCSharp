using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escapeSequence
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string s = "My name is Imran Chughtai \" This is my programming \" ";
			//string s = "My name is Imran Chughtai \nThis is my programming ";
			//string s = "My name is Imran Chughtai \t This is my programming ";
			string s = "My name is Imran Chughtai \\ This is my programming ";

			Console.WriteLine(s);
			Console.ReadLine(); 
		}
	}
}
