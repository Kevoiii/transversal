/*
 * Created by SharpDevelop.
 * User: CC1_PC12
 * Date: 25/10/2024
 * Time: 08:14 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace amanecer_dorado
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
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
			string traduccion1="The manifestation of the image of Saint Rose of Lima on the rugs on the Eighth Night of Uriangato can be attributed to several reasons. Although Santa Rosa de Lima is not the patron saint of the city of Uriangato, her image may be present on the rugs for several reasons:";
			lblt1.Text=traduccion1;
			string traduccion2="Symbol of purity and virginity: Saint Rose of Lima is known for her purity and virginity, which makes her attractive to those seeking a model of behavior and faith. Including your image on mats can be a way to honor these virtues.";
			lblt2.Text=traduccion2;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form3 pagina3= new Form3();
			pagina3.Show();
		}
	}
}
