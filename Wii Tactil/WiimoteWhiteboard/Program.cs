using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WiimoteWhiteboard
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new WiimoteMainForm());
            }
            catch(Exception x)
            {
                MessageBox.Show("Exception: " + x.Message);
            }
		}
	}
}