/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 12-Oct-17
 * Time: 00:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Crypto
{
	partial class Crypto : Interface.menuinterface
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button shabutton;
		private Sha.Sha sha1;
		
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
			this.shabutton = new System.Windows.Forms.Button();
			this.sha1 = new Sha.Sha();
			this.Md5button = new System.Windows.Forms.Button();
			this.md51 = new Md5.Md5();
			this.rsa1 = new Rsa.Rsa();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// shabutton
			// 
			this.shabutton.BackColor = System.Drawing.Color.Gold;
			this.shabutton.Location = new System.Drawing.Point(103, 21);
			this.shabutton.Name = "shabutton";
			this.shabutton.Size = new System.Drawing.Size(75, 23);
			this.shabutton.TabIndex = 1;
			this.shabutton.Text = "SHA";
			this.shabutton.UseVisualStyleBackColor = false;
			this.shabutton.Click += new System.EventHandler(this.ShabuttonClick);
			// 
			// sha1
			// 
			this.sha1.BackColor = System.Drawing.Color.LightGreen;
			this.sha1.Location = new System.Drawing.Point(60, 62);
			this.sha1.Name = "sha1";
			this.sha1.Size = new System.Drawing.Size(554, 309);
			this.sha1.TabIndex = 2;
			// 
			// Md5button
			// 
			this.Md5button.BackColor = System.Drawing.Color.SeaShell;
			this.Md5button.Location = new System.Drawing.Point(12, 21);
			this.Md5button.Name = "Md5button";
			this.Md5button.Size = new System.Drawing.Size(75, 23);
			this.Md5button.TabIndex = 3;
			this.Md5button.Text = "MD5";
			this.Md5button.UseVisualStyleBackColor = false;
			this.Md5button.Click += new System.EventHandler(this.Md5buttonClick);
			// 
			// md51
			// 
			this.md51.BackColor = System.Drawing.Color.LightBlue;
			this.md51.Location = new System.Drawing.Point(76, 62);
			this.md51.Name = "md51";
			this.md51.Size = new System.Drawing.Size(526, 320);
			this.md51.TabIndex = 4;
			// 
			// rsa1
			// 
			this.rsa1.BackColor = System.Drawing.Color.IndianRed;
			this.rsa1.Location = new System.Drawing.Point(40, 62);
			this.rsa1.Name = "rsa1";
			this.rsa1.Size = new System.Drawing.Size(677, 436);
			this.rsa1.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(198, 21);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "RSA";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Crypto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSalmon;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.rsa1);
			this.Controls.Add(this.md51);
			this.Controls.Add(this.Md5button);
			this.Controls.Add(this.sha1);
			this.Controls.Add(this.shabutton);
			this.Name = "Crypto";
			this.Size = new System.Drawing.Size(759, 518);
			this.ResumeLayout(false);

		}

        private System.Windows.Forms.Button Md5button;
        private Md5.Md5 md51;
        private Rsa.Rsa rsa1;
        private System.Windows.Forms.Button button1;
    }
}
