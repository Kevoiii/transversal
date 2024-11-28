/*
 * Created by SharpDevelop.
 * User: CC1_PC03
 * Date: 31/10/2024
 * Time: 10:23 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace amanecer_dorado
{
	/// <summary>
	/// Description of Form7.
	/// </summary>
	public partial class Form7 : Form
	{
		public Form7()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void BtnsiguienteClick(object sender, EventArgs e)
		{
			
			 Form8 pagina= new Form8();
		 this.Hide();
			pagina.ShowDialog();
			this.Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
	 Form66 pagina= new Form66();
		 this.Hide();
			pagina.ShowDialog();
			this.Close();
		}
	}
}
