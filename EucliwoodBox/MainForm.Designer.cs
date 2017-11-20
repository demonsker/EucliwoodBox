/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 11-Oct-17
 * Time: 18:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EucliwoodBox
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button calculatemenu;
		private System.Windows.Forms.Button cryptomenu;
		private System.Windows.Forms.Button networkmenu;
		private Network.Network network1;
		private Calculate.Calculate calculate1;
		private Crypto.Crypto crypto1;
		
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
			this.calculatemenu = new System.Windows.Forms.Button();
			this.cryptomenu = new System.Windows.Forms.Button();
			this.networkmenu = new System.Windows.Forms.Button();
			this.network1 = new Network.Network();
			this.calculate1 = new Calculate.Calculate();
			this.crypto1 = new Crypto.Crypto();
			this.SuspendLayout();
			// 
			// calculatemenu
			// 
			this.calculatemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.calculatemenu.Location = new System.Drawing.Point(15, 16);
			this.calculatemenu.Name = "calculatemenu";
			this.calculatemenu.Size = new System.Drawing.Size(87, 38);
			this.calculatemenu.TabIndex = 0;
			this.calculatemenu.Text = "Calculate";
			this.calculatemenu.UseVisualStyleBackColor = false;
			this.calculatemenu.Click += new System.EventHandler(this.CalculatemenuClick);
			// 
			// cryptomenu
			// 
			this.cryptomenu.BackColor = System.Drawing.Color.MintCream;
			this.cryptomenu.Location = new System.Drawing.Point(124, 16);
			this.cryptomenu.Name = "cryptomenu";
			this.cryptomenu.Size = new System.Drawing.Size(87, 38);
			this.cryptomenu.TabIndex = 2;
			this.cryptomenu.Text = "Crypto";
			this.cryptomenu.UseVisualStyleBackColor = false;
			this.cryptomenu.Click += new System.EventHandler(this.CryptomenuClick);
			// 
			// networkmenu
			// 
			this.networkmenu.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.networkmenu.Location = new System.Drawing.Point(231, 16);
			this.networkmenu.Name = "networkmenu";
			this.networkmenu.Size = new System.Drawing.Size(87, 38);
			this.networkmenu.TabIndex = 5;
			this.networkmenu.Text = "Network";
			this.networkmenu.UseVisualStyleBackColor = false;
			this.networkmenu.Click += new System.EventHandler(this.NetworkmenuClick);
			// 
			// network1
			// 
			this.network1.BackColor = System.Drawing.Color.CadetBlue;
			this.network1.Location = new System.Drawing.Point(26, 90);
			this.network1.Name = "network1";
			this.network1.Size = new System.Drawing.Size(813, 570);
			this.network1.TabIndex = 7;
			// 
			// calculate1
			// 
			this.calculate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.calculate1.Location = new System.Drawing.Point(26, 90);
			this.calculate1.Name = "calculate1";
			this.calculate1.Size = new System.Drawing.Size(813, 570);
			this.calculate1.TabIndex = 8;
			// 
			// crypto1
			// 
			this.crypto1.BackColor = System.Drawing.Color.LightSalmon;
			this.crypto1.Location = new System.Drawing.Point(26, 90);
			this.crypto1.Name = "crypto1";
			this.crypto1.Size = new System.Drawing.Size(813, 570);
			this.crypto1.TabIndex = 9;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Bisque;
			this.ClientSize = new System.Drawing.Size(867, 682);
			this.Controls.Add(this.crypto1);
			this.Controls.Add(this.calculate1);
			this.Controls.Add(this.network1);
			this.Controls.Add(this.networkmenu);
			this.Controls.Add(this.cryptomenu);
			this.Controls.Add(this.calculatemenu);
			this.Name = "MainForm";
			this.Text = "EucliwoodBox";
			this.ResumeLayout(false);

		}
    }
}
