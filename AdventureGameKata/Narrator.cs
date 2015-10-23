using System;

namespace AdventureGameKata
{
	public class Narrator
	{


		public string GetNextLine()
		{
			return "Hi, What is your name?";
		}

		public void Greet()
		{
			Console.WriteLine(GetNextLine());
		}
	}
}