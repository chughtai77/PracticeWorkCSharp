using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrientedProgram
{
	 class Players
	{
		public string Name = "Imran";
		public string Description = "Fighter";
		private int health = 33;

		public int gethealth() 
		{ 
			return health;
		}

		public void sethealth(int h) 
		{
			health= h;
		}
	}
}
