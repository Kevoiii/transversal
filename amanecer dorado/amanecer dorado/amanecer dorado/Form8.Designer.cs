/*
 * Created by SharpDevelop.
 * User: CC1_PC03
 * Date: 31/10/2024
 * Time: 10:49 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace amanecer_dorado
{
	partial class Form8
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblglobitos = new System.Windows.Forms.Label();
			this.btntraducir = new System.Windows.Forms.Button();
			this.btnsiguiente = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
			this.label1.Location = new System.Drawing.Point(92, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(266, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "DESCANSO A SAN MIGUEL ARCANGEL";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(118, 35);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(220, 215);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// lblglobitos
			// 
			this.lblglobitos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblglobitos.ForeColor = System.Drawing.Color.White;
			this.lblglobitos.Location = new System.Drawing.Point(32, 253);
			this.lblglobitos.Name = "lblglobitos";
			this.lblglobitos.Size = new System.Drawing.Size(385, 207);
			this.lblglobitos.TabIndex = 4;
			this.lblglobitos.Text = resources.GetString("lblglobitos.Text");
			// 
			// btntraducir
			// 
			this.btntraducir.Location = new System.Drawing.Point(32, 471);
			this.btntraducir.Name = "btntraducir";
			this.btntraducir.Size = new System.Drawing.Size(75, 23);
			this.btntraducir.TabIndex = 5;
			this.btntraducir.Text = "Traducir";
			this.btntraducir.UseVisualStyleBackColor = true;
			this.btntraducir.Click += new System.EventHandler(this.BtntraducirClick);
			// 
			// btnsiguiente
			// 
			this.btnsiguiente.Location = new System.Drawing.Point(342, 471);
			this.btnsiguiente.Name = "btnsiguiente";
			this.btnsiguiente.Size = new System.Drawing.Size(75, 23);
			this.btnsiguiente.TabIndex = 6;
			this.btnsiguiente.Text = ">";
			this.btnsiguiente.UseVisualStyleBackColor = true;
			this.btnsiguiente.Click += new System.EventHandler(this.BtnsiguienteClick);
			// 
			// Form8
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(445, 506);
			this.Controls.Add(this.btnsiguiente);
			this.Controls.Add(this.btntraducir);
			this.Controls.Add(this.lblglobitos);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Name = "Form8";
			this.Text = "Form8";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnsiguiente;
		private System.Windows.Forms.Button btntraducir;
		private System.Windows.Forms.Label lblglobitos;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}
