using System;

namespace AdventureGameKata
{
	class AdventureGame
	{
		static void Main(string[] args)
		{
			var narrator = new Narrator();
			narrator.Greet();

			var name = Console.ReadLine();

			Console.WriteLine("Hi {0}", name);
			Console.WriteLine("You are standing by a small white house.");

			

			Console.ReadLine();
		}
	}
}
