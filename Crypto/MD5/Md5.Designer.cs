/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 14-Oct-17
 * Time: 00:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Md5
{
	partial class Md5 : CryptoInterface.menuinterface
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ciphertextbox;
		private System.Windows.Forms.TextBox inputbox;
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ciphertextbox = new System.Windows.Forms.TextBox();
			this.inputbox = new System.Windows.Forms.TextBox();
			this.hashbutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label2.Location = new System.Drawing.Point(20, 231);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 20);
			this.label2.TabIndex = 9;
			this.label2.Text = "CipherText";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.Location = new System.Drawing.Point(43, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "input";
			// 
			// ciphertextbox
			// 
			this.ciphertextbox.Location = new System.Drawing.Point(131, 180);
			this.ciphertextbox.Multiline = true;
			this.ciphertextbox.Name = "ciphertextbox";
			this.ciphertextbox.ReadOnly = true;
			this.ciphertextbox.Size = new System.Drawing.Size(274, 120);
			this.ciphertextbox.TabIndex = 7;
			// 
			// inputbox
			// 
			this.inputbox.Location = new System.Drawing.Point(131, 25);
			this.inputbox.Multiline = true;
			this.inputbox.Name = "inputbox";
			this.inputbox.Size = new System.Drawing.Size(274, 120);
			this.inputbox.TabIndex = 6;
			// 
			// hashbutton
			// 
			this.hashbutton.BackColor = System.Drawing.Color.Thistle;
			this.hashbutton.Location = new System.Drawing.Point(433, 134);
			this.hashbutton.Name = "hashbutton";
			this.hashbutton.Size = new System.Drawing.Size(68, 57);
			this.hashbutton.TabIndex = 5;
			this.hashbutton.Text = "Hash";
			this.hashbutton.UseVisualStyleBackColor = false;
			this.hashbutton.Click += new System.EventHandler(this.HashbuttonClick);
			// 
			// Md5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ciphertextbox);
			this.Controls.Add(this.inputbox);
			this.Controls.Add(this.hashbutton);
			this.Name = "Md5";
			this.Size = new System.Drawing.Size(526, 330);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
