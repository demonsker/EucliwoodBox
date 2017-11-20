/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 12-Oct-17
 * Time: 23:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Sha
{
	partial class Sha : CryptoInterface.menuinterface
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RadioButton sha256ratio;
		private System.Windows.Forms.RadioButton sha512ratio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inputbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox cipherbox;
		private System.Windows.Forms.Button hashbutton;
		
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
			this.sha256ratio = new System.Windows.Forms.RadioButton();
			this.sha512ratio = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.inputbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cipherbox = new System.Windows.Forms.TextBox();
			this.hashbutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// sha256ratio
			// 
			this.sha256ratio.Checked = true;
			this.sha256ratio.Location = new System.Drawing.Point(17, 22);
			this.sha256ratio.Name = "sha256ratio";
			this.sha256ratio.Size = new System.Drawing.Size(104, 24);
			this.sha256ratio.TabIndex = 0;
			this.sha256ratio.TabStop = true;
			this.sha256ratio.Text = "SHA256";
			this.sha256ratio.UseVisualStyleBackColor = true;
			// 
			// sha512ratio
			// 
			this.sha512ratio.Location = new System.Drawing.Point(98, 22);
			this.sha512ratio.Name = "sha512ratio";
			this.sha512ratio.Size = new System.Drawing.Size(104, 24);
			this.sha512ratio.TabIndex = 1;
			this.sha512ratio.Text = "SHA512";
			this.sha512ratio.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.Location = new System.Drawing.Point(21, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Input";
			// 
			// inputbox
			// 
			this.inputbox.Location = new System.Drawing.Point(98, 62);
			this.inputbox.Multiline = true;
			this.inputbox.Name = "inputbox";
			this.inputbox.Size = new System.Drawing.Size(380, 92);
			this.inputbox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label2.Location = new System.Drawing.Point(3, 219);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "CipherText";
			// 
			// cipherbox
			// 
			this.cipherbox.Location = new System.Drawing.Point(98, 189);
			this.cipherbox.Multiline = true;
			this.cipherbox.Name = "cipherbox";
			this.cipherbox.ReadOnly = true;
			this.cipherbox.Size = new System.Drawing.Size(380, 92);
			this.cipherbox.TabIndex = 5;
			// 
			// hashbutton
			// 
			this.hashbutton.BackColor = System.Drawing.Color.PaleTurquoise;
			this.hashbutton.Location = new System.Drawing.Point(495, 142);
			this.hashbutton.Name = "hashbutton";
			this.hashbutton.Size = new System.Drawing.Size(56, 57);
			this.hashbutton.TabIndex = 6;
			this.hashbutton.Text = "Hash";
			this.hashbutton.UseVisualStyleBackColor = false;
			this.hashbutton.Click += new System.EventHandler(this.HashbuttonClick);
			// 
			// Sha
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.Controls.Add(this.hashbutton);
			this.Controls.Add(this.cipherbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.inputbox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.sha512ratio);
			this.Controls.Add(this.sha256ratio);
			this.Name = "Sha";
			this.Size = new System.Drawing.Size(554, 309);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
