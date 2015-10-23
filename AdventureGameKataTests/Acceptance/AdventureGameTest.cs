using System.Diagnostics;
using System.IO;
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
			var game = GameProcess.Start();

			game.Type("Player");
			game.PressEnter();
			game.PressEnter();

			game.WaitForExit();

			Assert.That(game.ReadOutput(), Is.StringContaining("Hi, What is your name?"));
			Assert.That(game.ReadOutput(), Is.StringContaining("Hi " + "Player"));
		}
	}

	class GameProcess
	{
		private readonly Process _process;
		private readonly StringBuilder _output;

		private GameProcess(Process process, StringBuilder output)
		{
			_process = process;
			_output = output;
		}

		private const string FileName = @"..\..\..\AdventureGameKata\bin\Debug\AdventureGameKata.exe";
		public static GameProcess Start()
		{
			var process = new Process
				{
					StartInfo =
						{
							FileName = FileName,
							UseShellExecute = false,
							RedirectStandardOutput = true,
							RedirectStandardInput = true
						}
				};

			var output = new StringBuilder();
			process.OutputDataReceived += (sender, args) => output.Append(args.Data + "\n");
			process.Start();
			process.BeginOutputReadLine();
			return new GameProcess(process, output);
		}

		public StreamWriter Input { get { return _process.StandardInput; } }

		public void Type(string input)
		{
			_process.StandardInput.Write(input);
		}

		public void PressEnter()
		{
			Type("\n");
		}

		public void WaitForExit()
		{
			_process.WaitForExit();
		}

		public string ReadOutput()
		{
			return _output.ToString();
		}
	}
}
