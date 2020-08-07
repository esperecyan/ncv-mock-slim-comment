using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin;

namespace MockSlimComment
{
	public class MockSlimComment : IPlugin
	{
		public IPluginHost Host { get; set; }

		public bool IsAutoRun => false;

		public string Description => "";

		public string Version => "1.0.0";

		public string Name => "スリムコメントもどき";

		public void AutoRun()
		{
			throw new NotImplementedException();
		}

		public void Run()
		{
		}
	}
}
