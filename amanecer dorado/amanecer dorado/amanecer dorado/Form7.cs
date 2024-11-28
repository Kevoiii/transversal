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
		
		void BtntraducirClick(object sender, EventArgs e)
		{
			string traduccion5= "Local patronage: San Miguel Arcángel is the patron saint of the city of  Uriangato, and his figure is represented on the Eighth Night as a way of showing loyalty and devotion to his protector.  Celebration of the holiday: The Eighth Night is a religious celebration that commemorates the birth of Jesus, and Saint Michael the Archangel is one of the archangels believed to have participated in this event. Therefore, your performance on the Eighth Night is a way to commemorate this event and give thanks for the presence of Jesus in the lives of the faithful.  Symbol of protection and strength: Saint Michael the Archangel is known for his role in the fight against evil and his ability to protect the faithful. Its representation on the Eighth Night is a way of asking for its protection and strength for the community and its members.";
			lbtraduccion5.Text = traduccion5;
		}
		
		void BtnsiguienteClick(object sender, EventArgs e)
		{
			Form8 pagina8 = new Form8();
			pagina8.Show();
		}
	}
}
