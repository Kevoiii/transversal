/*
 * Created by SharpDevelop.
 * User: CC1_PC18
 * Date: 07/10/2024
 * Time: 01:02 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace amanecer_dorado
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			INTRODUCCION intro = new INTRODUCCION();
		
			intro.Show();
			this.Hide();
		}
		
		
	}
}
