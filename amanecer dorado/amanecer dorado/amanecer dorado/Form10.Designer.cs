/*
 * Created by SharpDevelop.
 * User: CC1_PC03
 * Date: 31/10/2024
 * Time: 11:33 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace amanecer_dorado
{
	partial class Form10
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbltraductor10 = new System.Windows.Forms.Label();
			this.btntraduccion10 = new System.Windows.Forms.Button();
			this.btnsiguiente10 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(104, 37);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(233, 224);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
			this.label1.Location = new System.Drawing.Point(104, 9);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(336, 18);
			this.label1.TabIndex = 4;
			this.label1.Text = "TAPETE DE JESUCRISTO";
			// 
			// lbltraductor10
			// 
			this.lbltraductor10.ForeColor = System.Drawing.Color.White;
			this.lbltraductor10.Location = new System.Drawing.Point(40, 273);
			this.lbltraductor10.Name = "lbltraductor10";
			this.lbltraductor10.Size = new System.Drawing.Size(388, 94);
			this.lbltraductor10.TabIndex = 5;
			this.lbltraductor10.Text = resources.GetString("lbltraductor10.Text");
			// 
			// btntraduccion10
			// 
			this.btntraduccion10.Location = new System.Drawing.Point(40, 370);
			this.btntraduccion10.Name = "btntraduccion10";
			this.btntraduccion10.Size = new System.Drawing.Size(75, 23);
			this.btntraduccion10.TabIndex = 6;
			this.btntraduccion10.Text = "TRADUCIR";
			this.btntraduccion10.UseVisualStyleBackColor = true;
			this.btntraduccion10.Click += new System.EventHandler(this.Btntraduccion10Click);
			// 
			// btnsiguiente10
			// 
			this.btnsiguiente10.Location = new System.Drawing.Point(325, 370);
			this.btnsiguiente10.Name = "btnsiguiente10";
			this.btnsiguiente10.Size = new System.Drawing.Size(75, 23);
			this.btnsiguiente10.TabIndex = 7;
			this.btnsiguiente10.Text = ">";
			this.btnsiguiente10.UseVisualStyleBackColor = true;
			// 
			// Form10
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(453, 420);
			this.Controls.Add(this.btnsiguiente10);
			this.Controls.Add(this.btntraduccion10);
			this.Controls.Add(this.lbltraductor10);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form10";
			this.Text = "Form10";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnsiguiente10;
		private System.Windows.Forms.Button btntraduccion10;
		private System.Windows.Forms.Label lbltraductor10;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
