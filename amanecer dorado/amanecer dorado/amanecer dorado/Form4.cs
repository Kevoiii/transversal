/*
 * Created by SharpDevelop.
 * User: CC1-PC21
 * Date: 25/10/2024
 * Time: 01:09 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace amanecer_dorado
{
	/// <summary>
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		public Form4()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtntraducirClick(object sender, EventArgs e)
		{
		 string traduccion3="The representation of the Virgin of Socorro in the carpets during the Octava Noche in Uriangato can be attributed to several reasons, such as: Personal devotion: The faithful who have a special devotion to the Virgin of Socorro may include her image in the carpets as a way to express their respect and adoration for her. Local patronage: The Virgin of Socorro is the patroness of the city of Uriangato, so her presence in the carpets can be a way to demonstrate loyalty and devotion to the local sanctuary and the celebration. Symbol of protection and assistance: The Virgin of Socorro is known for her intercession and protection in times of difficulty. Including her image in the carpets may be a way to seek her help and protection for the community and its members.";
		 lbltradu2.Text=traduccion3; 
		}
		
		void BtnsiguienteClick(object sender, EventArgs e)
		{
			Form5 pagina5=new Form5();
			pagina5.Show();
		}
	}
		
		
}

