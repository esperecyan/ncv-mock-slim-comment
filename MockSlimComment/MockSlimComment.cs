using System;
using System.Reflection;
using System.Media;
using Plugin;

namespace Esperecyan.NCV.MockSlimComment
{
	public class MockSlimComment : IPlugin
	{
		public IPluginHost Host { get; set; }

		public bool IsAutoRun => false;

		public string Description => ((AssemblyTitleAttribute)Attribute.GetCustomAttribute(
			Assembly.GetExecutingAssembly(),
			typeof(AssemblyTitleAttribute)
		)).Title;

		public string Version => Assembly.GetExecutingAssembly().GetName().Version.ToString(fieldCount: 3);

		public string Name => ((AssemblyProductAttribute)Attribute.GetCustomAttribute(
			Assembly.GetExecutingAssembly(),
			typeof(AssemblyProductAttribute)
		)).Product;

		private Window window;

		public void AutoRun()
		{
			throw new NotImplementedException();
		}

		public void Run()
		{
			if (this.window != null)
			{
				return;
			}

			this.window = new Window(title: $"{this.Name} {this.Version}")
			{
				Owner = this.Host.MainForm,
				TopMost = true,
			};
			this.window.CommentSending += (sender, e) =>
			{
				try
				{
					this.Host.SendOwnerComment(e.String);
				}
				catch (Exception exception)
				{
					SystemSounds.Hand.Play();
					this.Host.ShowMessageToStatusLabel(this, exception.Message);
				}
			};
			this.window.FormClosed += (sender, e) => this.window = null;
			this.window.Show();
		}
	}
}
