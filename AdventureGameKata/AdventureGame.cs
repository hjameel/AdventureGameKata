﻿using System;

namespace AdventureGameKata
{
	class AdventureGame
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hi, What is your name?");

			var name = Console.ReadLine();

			Console.WriteLine("Hi {0}", name);
			Console.WriteLine("You are standing by a small white house.");

			

			Console.ReadLine();
		}
	}
}
