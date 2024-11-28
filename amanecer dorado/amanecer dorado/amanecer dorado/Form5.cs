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
			Pagina6 Form6 = new Pagina6();
			Form6.Show();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string traduccion3 = "The manifestation of the image of Jesus of Nazareth on the mats during the Eighth Night of Uriangato can be attributed to several reasons, such as: Personal devotion: The faithful who have a special devotion to Jesus of Nazareth can include your image on the mats as a way to show your respect and adoration of the Messiah. Symbolism of the Passion: The image of Jesus of Nazareth can be included in the mats to represent the way of the Cross and the Passion of Jesus, which is a central theme in the Catholic religion and in the celebration of the Eighth Night. Integration of festivities: The celebration of the Eighth Night in Uriangato is a religious and cultural event that brings together people of different origins and devotions. The inclusion of the image of Jesus of Nazareth in the rugs can be a way to integrate devotion to this figure into the general celebration.";
			lbtraduccion3.Text = traduccion3;
		}
	}
}
