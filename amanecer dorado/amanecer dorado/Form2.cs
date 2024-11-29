/*
 * Created by SharpDevelop.
 * User: CC1_PC12
 * Date: 25/10/2024
 * Time: 08:14 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace amanecer_dorado
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		private void abrirForm3()
		{
			Application.Run(new Form3());
		}
		public Form2()
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
			Form3 form3 = new Form3();
			this.Hide();
			form3.ShowDialog();
			this.Close();
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			INTRODUCCION formi = new INTRODUCCION();
			this.Hide();
			formi.ShowDialog();
			this.Close();
		}
	}
}
