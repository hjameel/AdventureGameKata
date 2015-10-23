using System.Diagnostics;
using System.Text;
using NUnit.Framework;

namespace AdventureGameKataTests.Acceptance
{
	[TestFixture]
	class AdventureGameTest
	{
		[Test]
		public void it_greets_the_new_player()
		{
			var process = new Process
				{
					StartInfo =
						{
							FileName = @"..\..\..\AdventureGameKata\bin\Debug\AdventureGameKata.exe",
							UseShellExecute = false,
							RedirectStandardOutput = true
						}
				};

			var output = new StringBuilder();
			process.OutputDataReceived += (sender, args) => output.Append(args.Data);

			process.Start();
			process.BeginOutputReadLine();
			process.WaitForExit();

			Assert.That(output.ToString(), Is.StringContaining("Hi"));
		}
	}
}
