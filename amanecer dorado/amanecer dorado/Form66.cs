/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 01/11/2024
 * Time: 05:04 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace amanecer_dorado
{
	/// <summary>
	/// Description of Form66.
	/// </summary>
	public partial class Form66 : Form
	{
		public Form66()
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
			 Form5 pagina= new Form5();
		 this.Hide();
			pagina.ShowDialog();
			this.Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
	
			 Form7 pagina= new Form7();
		 this.Hide();
			pagina.ShowDialog();
			this.Close();
		}
		
	}
}
