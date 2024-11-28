/*
 * Created by SharpDevelop.
 * User: CC1_PC12
 * Date: 25/10/2024
 * Time: 08:14 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace amanecer_dorado
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.btntraducir = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblt1 = new System.Windows.Forms.Label();
			this.lblt2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btntraducir
			// 
			this.btntraducir.Location = new System.Drawing.Point(29, 280);
			this.btntraducir.Name = "btntraducir";
			this.btntraducir.Size = new System.Drawing.Size(75, 23);
			this.btntraducir.TabIndex = 6;
			this.btntraducir.Text = "Traducir";
			this.btntraducir.UseVisualStyleBackColor = true;
			this.btntraducir.Click += new System.EventHandler(this.BtntraducirClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(105, 38);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(197, 142);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(267, 280);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = ">";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
			this.label1.Location = new System.Drawing.Point(105, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 34);
			this.label1.TabIndex = 9;
			this.label1.Text = "SANTA ROSA DE LIMA";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblt1
			// 
			this.lblt1.ForeColor = System.Drawing.SystemColors.Control;
			this.lblt1.Location = new System.Drawing.Point(6, 219);
			this.lblt1.Name = "lblt1";
			this.lblt1.Size = new System.Drawing.Size(368, 58);
			this.lblt1.TabIndex = 10;
			this.lblt1.Text = resources.GetString("lblt1.Text");
			this.lblt1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblt2
			// 
			this.lblt2.ForeColor = System.Drawing.SystemColors.Control;
			this.lblt2.Location = new System.Drawing.Point(-3, 162);
			this.lblt2.Name = "lblt2";
			this.lblt2.Size = new System.Drawing.Size(377, 57);
			this.lblt2.TabIndex = 11;
			this.lblt2.Text = resources.GetString("lblt2.Text");
			this.lblt2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(371, 339);
			this.Controls.Add(this.lblt2);
			this.Controls.Add(this.lblt1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btntraducir);
			this.Name = "Form2";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblt2;
		private System.Windows.Forms.Label lblt1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btntraducir;
	}
}
