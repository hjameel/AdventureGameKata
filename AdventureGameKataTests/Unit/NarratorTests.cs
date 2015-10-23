using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AdventureGameKataTests.Unit
{
	public class NarratorTests
	{
		[Test]
		public void Should_say_hello()
		{
			var narrator = new Narrator();

			narrator.GetNextLine()
		}
	}

	public class Narrator
	{
	}
}
