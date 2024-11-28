/*
 * Created by SharpDevelop.
 * User: CC1_PC03
 * Date: 31/10/2024
 * Time: 10:23 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace amanecer_dorado
{
	partial class Form7
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbtraduccion5 = new System.Windows.Forms.Label();
			this.btntraducir = new System.Windows.Forms.Button();
			this.btnsiguiente = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
			this.label1.Location = new System.Drawing.Point(62, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(307, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "FIGURA HACIA SAN MIGUEL DE ARCANGEL ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(124, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(155, 173);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// lbtraduccion5
			// 
			this.lbtraduccion5.ForeColor = System.Drawing.Color.White;
			this.lbtraduccion5.Location = new System.Drawing.Point(23, 206);
			this.lbtraduccion5.Name = "lbtraduccion5";
			this.lbtraduccion5.Size = new System.Drawing.Size(410, 170);
			this.lbtraduccion5.TabIndex = 5;
			this.lbtraduccion5.Text = resources.GetString("lbtraduccion5.Text");
			// 
			// btntraducir
			// 
			this.btntraducir.Location = new System.Drawing.Point(23, 391);
			this.btntraducir.Name = "btntraducir";
			this.btntraducir.Size = new System.Drawing.Size(75, 23);
			this.btntraducir.TabIndex = 6;
			this.btntraducir.Text = "Traducir";
			this.btntraducir.UseVisualStyleBackColor = true;
			this.btntraducir.Click += new System.EventHandler(this.BtntraducirClick);
			// 
			// btnsiguiente
			// 
			this.btnsiguiente.Location = new System.Drawing.Point(358, 391);
			this.btnsiguiente.Name = "btnsiguiente";
			this.btnsiguiente.Size = new System.Drawing.Size(75, 23);
			this.btnsiguiente.TabIndex = 7;
			this.btnsiguiente.Text = ">";
			this.btnsiguiente.UseVisualStyleBackColor = true;
			this.btnsiguiente.Click += new System.EventHandler(this.BtnsiguienteClick);
			// 
			// Form7
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(459, 464);
			this.Controls.Add(this.btnsiguiente);
			this.Controls.Add(this.btntraducir);
			this.Controls.Add(this.lbtraduccion5);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form7";
			this.Text = "Form7";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnsiguiente;
		private System.Windows.Forms.Button btntraducir;
		private System.Windows.Forms.Label lbtraduccion5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}
