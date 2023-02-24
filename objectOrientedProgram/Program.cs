using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrientedProgram
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//OOP - Classes and Objects

			Players player = new Players();
			Console.WriteLine(player.gethealth());
			player.sethealth(99);
			Console.WriteLine(player.gethealth());

			Console.Read();
		}
	}
}
