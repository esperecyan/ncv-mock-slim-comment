using System;
using System.Drawing;
using System.Windows.Forms;
using Esperecyan.NCV.MockSlimComment.Properties;

namespace Esperecyan.NCV.MockSlimComment
{
	public partial class Window : Form
	{
		public event EventHandler<StringEventArgs> CommentSending;

		private Point mouseLocation;

		public Window(string title)
		{
			this.InitializeComponent();

			this.titleBar.Text = title;

			if (Settings.Default.FontSize != default)
			{
				this.ChangeFontSize(Settings.Default.FontSize);
				this.fontSize.Value = Settings.Default.FontSize;
			}
			if (Settings.Default.WindowLeft != default || Settings.Default.WindowTop != default)
			{
				this.StartPosition = FormStartPosition.Manual;
				this.Left = Settings.Default.WindowLeft;
				this.Top = Settings.Default.WindowTop;
			}
			if (Settings.Default.WindowWidth != default)
			{
				this.Width = Settings.Default.WindowWidth;
				this.Height = Settings.Default.WindowHeight;
			}
		}

		private void ChangeFontSize(float size)
		{
			var font = this.comment.Font;
			this.comment.Font = new Font(font.Name, size, font.Style, font.Unit);
		}

		private void titleBar_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
			{
				return;
			}

			this.mouseLocation = e.Location;
		}

		private void titleBar_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left || this.mouseLocation == default)
			{
				return;
			}

			this.Left += e.Location.X - this.mouseLocation.X;
			this.Top += e.Location.Y - this.mouseLocation.Y;
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void fontSize_ValueChanged(object sender, EventArgs e)
		{
			this.ChangeFontSize((float)this.fontSize.Value);
		}

		private void comment_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter || e.Control)
			{
				return;
			}

			e.SuppressKeyPress = true;

			if (this.comment.Text.Trim() == "")
			{
				return;
			}

			CommentSending?.Invoke(this, new StringEventArgs(this.comment.Text));
			this.comment.Text = "";
		}

		private void Window_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.FontSize = (int)this.fontSize.Value;
			Settings.Default.WindowWidth = this.Width;
			Settings.Default.WindowHeight = this.Height;
			Settings.Default.Save();
		}
	}
}
