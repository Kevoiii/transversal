/*
 * Created by SharpDevelop.
 * User: CC2_PC40
 * Date: 31/10/2024
 * Time: 08:13 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace amanecer_dorado
{
	partial class Pagina6
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagina6));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbtraduccion4 = new System.Windows.Forms.Label();
			this.btntraducir = new System.Windows.Forms.Button();
			this.btnsiguiente = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
			this.label1.Location = new System.Drawing.Point(102, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(266, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "DESCANSO A SAN MIGUEL ARCANGEL";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(122, 35);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(202, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// lbtraduccion4
			// 
			this.lbtraduccion4.ForeColor = System.Drawing.Color.White;
			this.lbtraduccion4.Location = new System.Drawing.Point(40, 199);
			this.lbtraduccion4.Name = "lbtraduccion4";
			this.lbtraduccion4.Size = new System.Drawing.Size(410, 219);
			this.lbtraduccion4.TabIndex = 3;
			this.lbtraduccion4.Text = resources.GetString("lbtraduccion4.Text");
			// 
			// btntraducir
			// 
			this.btntraducir.Location = new System.Drawing.Point(40, 431);
			this.btntraducir.Name = "btntraducir";
			this.btntraducir.Size = new System.Drawing.Size(75, 23);
			this.btntraducir.TabIndex = 4;
			this.btntraducir.Text = "Traducir";
			this.btntraducir.UseVisualStyleBackColor = true;
			this.btntraducir.Click += new System.EventHandler(this.BtntraducirClick);
			// 
			// btnsiguiente
			// 
			this.btnsiguiente.Location = new System.Drawing.Point(375, 431);
			this.btnsiguiente.Name = "btnsiguiente";
			this.btnsiguiente.Size = new System.Drawing.Size(75, 23);
			this.btnsiguiente.TabIndex = 5;
			this.btnsiguiente.Text = ">";
			this.btnsiguiente.UseVisualStyleBackColor = true;
			this.btnsiguiente.Click += new System.EventHandler(this.BtnsiguienteClick);
			// 
			// Pagina6
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(476, 490);
			this.Controls.Add(this.btnsiguiente);
			this.Controls.Add(this.btntraducir);
			this.Controls.Add(this.lbtraduccion4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Name = "Pagina6";
			this.Text = "Form6";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnsiguiente;
		private System.Windows.Forms.Button btntraducir;
		private System.Windows.Forms.Label lbtraduccion4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}
