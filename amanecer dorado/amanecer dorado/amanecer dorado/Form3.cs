/*
 * Created by SharpDevelop.
 * User: CC1_PC12
 * Date: 25/10/2024
 * Time: 08:28 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace amanecer_dorado
{
	/// <summary>
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		public Form3()
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
			string traduccion2="the Virgin of Fátima in the carpets during the Octava Noche in Uriangato can be attributed to several reasons, such as: Personal devotion: The faithful who have a special devotion to the Virgin of Fátima may include her image in the carpets as a way to express their respect and adoration for her. Symbol of purity and spiritual maturity: The Virgin of Fátima is known for her messages of purity, penance, and spirituality. Including her image in the carpets may be a way to honor these virtues and teachings. Integration of festivities: The celebration of the Octava Noche in Uriangato is a religious and cultural event that brings together people from different backgrounds and devotions. Including the image of the Virgin of Fátima in the carpets can be a way to integrate devotion to this figure into the overall celebration.";
			lbltradu.Text=traduccion2;
		}
	
		
		void BtnsiguienteClick(object sender, EventArgs e)
		{
			Form4 pagina4= new Form4();
			pagina4.Show();
		}
	}
}
