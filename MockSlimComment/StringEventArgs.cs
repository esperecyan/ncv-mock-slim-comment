using System;

namespace Esperecyan.NCV.MockSlimComment
{
	public class StringEventArgs : EventArgs
	{
		public string String { get; private set; }

		public StringEventArgs(string str)
		{
			this.String = str;
		}
	}
}
