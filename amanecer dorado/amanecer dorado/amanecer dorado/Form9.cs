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
		
		void Btntraducir9Click(object sender, EventArgs e)
		{
			string traduccion9= "The temple of Uriangato is represented on a giant mat during the Octave. Night as a way to celebrate and give thanks for the presence of the image of the Virgin of Socorro in the city. Here are some additional reasons why that this is done: Devotion and worship: The representation of the temple on the giant mat is a way to show the devotion and adoration of the faithful to the Virgin of Socorro, the patron saint of the city of Uriangato. Celebration of the holiday: The Eighth Night is a religious celebration that commemorates the birth of Jesus, and the representation of the temple on the mat giant is a way to commemorate this event and give thanks for the presence of the Virgin of Socorro in the lives of the faithful.";
			lbltraducir9.Text = traduccion9;
		}
		
		
		void Btnsiguiente9Click(object sender, EventArgs e)
		{
			Form10 lolo = new Form10();
		lolo.Show();			
		}
		} 
	} 

