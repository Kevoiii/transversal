/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 31/10/2024
 * Time: 08:13 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace amanecer_dorado
{
	/// <summary>
	/// Description of Form6.
	/// </summary>
	public partial class Pagina6 : Form
	{
		public Pagina6()
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
			string traduccion4 = "The rest to San Miguel Arcángel on the Eighth Night of Uriangato is a religious and cultural tradition that has various purposes and meanings: Adoration and devotion: The celebration of the repose of San Miguel de Arcángel is an opportunity for the faithful to express their devotion and adoration to the saint patron of the city of Uriangato. This practice helps the faithful connect spiritually with the figure of Saint Michael and to express his gratitude for his protection and intercession. Gratitude and request for protection: During the Eighth Night, the faithful ask the protection and intercession of Saint Michael for them and their loved ones, especially in times of difficulty or danger. The rest at San Miguel is a way to express this gratitude and ask for their help and blessing. Celebration and community: The celebration of the repose of San Miguel de Arcángel It is an event that brings together the Uriangato community and local families. This practice helps strengthen ties of friendship and solidarity between members of the community, while celebrating the cultural and religious richness of the city";
			lbtraduccion4.Text = traduccion4;
		}
		
		void BtnsiguienteClick(object sender, EventArgs e)
		{
			Form7 pagina7 = new Form7();
				pagina7.Show();
		}
	}
}
