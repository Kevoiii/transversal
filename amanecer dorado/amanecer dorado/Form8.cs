/*
 * Created by SharpDevelop.
 * User: CC1_PC03
 * Date: 31/10/2024
 * Time: 10:49 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace amanecer_dorado
{
	/// <summary>
	/// Description of Form8.
	/// </summary>
	public partial class Form8 : Form
	{
		public Form8()
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
			Form9 pagina= new Form9();
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
