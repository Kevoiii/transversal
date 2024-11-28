/*
 * Created by SharpDevelop.
 * User: CC1_PC03
 * Date: 31/10/2024
 * Time: 11:06 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace amanecer_dorado
{
	partial class Form9
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbltraducir9 = new System.Windows.Forms.Label();
			this.btntraducir9 = new System.Windows.Forms.Button();
			this.btnsiguiente9 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
			this.label1.Location = new System.Drawing.Point(50, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(355, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "TAPETE GIGANTE DEL TEMPLO DE URIANGATO";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(77, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(306, 150);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// lbltraducir9
			// 
			this.lbltraducir9.ForeColor = System.Drawing.Color.White;
			this.lbltraducir9.Location = new System.Drawing.Point(25, 183);
			this.lbltraducir9.Name = "lbltraducir9";
			this.lbltraducir9.Size = new System.Drawing.Size(425, 211);
			this.lbltraducir9.TabIndex = 5;
			this.lbltraducir9.Text = resources.GetString("lbltraducir9.Text");
			// 
			// btntraducir9
			// 
			this.btntraducir9.Location = new System.Drawing.Point(50, 402);
			this.btntraducir9.Name = "btntraducir9";
			this.btntraducir9.Size = new System.Drawing.Size(75, 23);
			this.btntraducir9.TabIndex = 6;
			this.btntraducir9.Text = "Traducir";
			this.btntraducir9.UseVisualStyleBackColor = true;
			this.btntraducir9.Click += new System.EventHandler(this.Btntraducir9Click);
			// 
			// btnsiguiente9
			// 
			this.btnsiguiente9.Location = new System.Drawing.Point(335, 398);
			this.btnsiguiente9.Name = "btnsiguiente9";
			this.btnsiguiente9.Size = new System.Drawing.Size(75, 23);
			this.btnsiguiente9.TabIndex = 7;
			this.btnsiguiente9.Text = ">";
			this.btnsiguiente9.UseVisualStyleBackColor = true;
			this.btnsiguiente9.Click += new System.EventHandler(this.Btnsiguiente9Click);
			// 
			// Form9
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(471, 437);
			this.Controls.Add(this.btnsiguiente9);
			this.Controls.Add(this.btntraducir9);
			this.Controls.Add(this.lbltraducir9);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form9";
			this.Text = "Form9";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnsiguiente9;
		private System.Windows.Forms.Button btntraducir9;
		private System.Windows.Forms.Label lbltraducir9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
