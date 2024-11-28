/*
 * Created by SharpDevelop.
 * User: CC1_PC03
 * Date: 31/10/2024
 * Time: 11:33 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace amanecer_dorado
{
	/// <summary>
	/// Description of Form10.
	/// </summary>
	public partial class Form10 : Form
	{
		public Form10()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//

		}
		
		void Btntraduccion10Click(object sender, EventArgs e)
		{
			string traduccion10= "A mat representing Jesus Christ with a species. Crown made with some type of golden material, the mat is very well made since it does not have any irregularity in the theme of color and detail, this rug I liked it a lot personally.";
			lbltraductor10.Text = traduccion10;
		}
	}
}