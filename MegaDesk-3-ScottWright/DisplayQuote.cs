﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_ScottWright
{
	public partial class DisplayQuote : Form
	{
		public DisplayQuote()
		{
			InitializeComponent();
		}

		private void DisplayQuoteCancel_Click(object sender, EventArgs e)
		{
			var mainMenu = (MainMenu)Tag;
			mainMenu.Show();
			Close();
		}

		private void DisplayQuote_FormClosing(object sender, FormClosingEventArgs e)
		{
			var mainMenu = (MainMenu)Tag;
			mainMenu.Show();
		}
	}
}
