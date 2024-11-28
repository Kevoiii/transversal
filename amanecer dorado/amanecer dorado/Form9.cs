/*
 * Created by SharpDevelop.
 * User: CC1_PC03
 * Date: 31/10/2024
 * Time: 11:06 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace amanecer_dorado
{
	/// <summary>
	/// Description of Form9.
	/// </summary>
	public partial class Form9 : Form
	{
		public Form9()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
	  

		}
		
		void Btnsiguiente9Click(object sender, EventArgs e)
		{
	 
		}
		void Button1Click(object sender, EventArgs e)
		{
		 Form8 pagina= new Form8();
		 this.Hide();
			pagina.ShowDialog();
			this.Close(); 
		}
			
		}
	}

