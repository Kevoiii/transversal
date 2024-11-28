/*
 * Created by SharpDevelop.
 * User: CC1_PC14
 * Date: 28/10/2024
 * Time: 01:35 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace amanecer_dorado
{
	/// <summary>
	/// Description of Form5.
	/// </summary>
	public partial class Form5 : Form
	{
		public Form5()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Form66 form6 = new Form66();
			this.Hide();
			form6.ShowDialog();
			this.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			Form4 form4 = new Form4();
			this.Hide();
			form4.ShowDialog();
			this.Close();
			
		}
		
	}
}
