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
		
		void BtntraducirClick(object sender, EventArgs e)
		{
			string traduccion6 ="The Cantoya balloons are a tradition that takes place on the Eighth Night of Uriangato and has several purposes and meanings: Artistic and creative expression: The making of the Cantoya balloons is an opportunity for local artists and worshipers to express their creativity and skills through creating works of art and decorations. Balloons are a popular art form that allows people to show off their talent and skills in making figures and designs.  Celebrating the holiday: The Eighth Night is a religious celebration that commemorates the birth of Jesus, and Cantoya balloons are a way to commemorate this event and give thanks for the presence of Jesus in the lives of the faithful.  Gratitude and request for blessing: During the Eighth Night, the faithful ask for God's blessing for themselves and their loved ones, and Cantoya balloons are a way to express this gratitude and ask for divine protection and blessing.";
			lblglobitos.Text=traduccion6;
		}
		
		void BtnsiguienteClick(object sender, EventArgs e)
		{
			Form9 pagina9 = new Form9();
			pagina9.Show();
		}
	}
}
