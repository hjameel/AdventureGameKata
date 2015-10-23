using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureGameKata;
using NUnit.Framework;

namespace AdventureGameKataTests.Unit
{
	[TestFixture]
	public class NarratorTests
	{
		[Test]
		public void Should_say_hello()
		{
			var narrator = new Narrator();

			Assert.That(narrator.GetNextLine(), Is.StringContaining("Hi, What is your name?"));
		}
	}
}
