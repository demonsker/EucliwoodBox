/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 13-Oct-17
 * Time: 00:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Network
{
	partial class Network : Interface.menuinterface
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button portcheckbutton;
		private Portcheck.Portcheck portcheck1;
		private System.Windows.Forms.Button PSCbutton;
		private PSEX.PSC psc1;
		
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
			this.portcheckbutton = new System.Windows.Forms.Button();
			this.portcheck1 = new Portcheck.Portcheck();
			this.PSCbutton = new System.Windows.Forms.Button();
			this.psc1 = new PSEX.PSC();
			this.SuspendLayout();
			// 
			// portcheckbutton
			// 
			this.portcheckbutton.BackColor = System.Drawing.Color.Peru;
			this.portcheckbutton.Location = new System.Drawing.Point(17, 21);
			this.portcheckbutton.Name = "portcheckbutton";
			this.portcheckbutton.Size = new System.Drawing.Size(81, 30);
			this.portcheckbutton.TabIndex = 0;
			this.portcheckbutton.Text = "Portcheck";
			this.portcheckbutton.UseVisualStyleBackColor = false;
			this.portcheckbutton.Click += new System.EventHandler(this.PortcheckbuttonClick);
			// 
			// portcheck1
			// 
			this.portcheck1.BackColor = System.Drawing.Color.PeachPuff;
			this.portcheck1.Location = new System.Drawing.Point(122, 123);
			this.portcheck1.Name = "portcheck1";
			this.portcheck1.Size = new System.Drawing.Size(417, 294);
			this.portcheck1.TabIndex = 1;
			// 
			// PSCbutton
			// 
			this.PSCbutton.BackColor = System.Drawing.Color.Orange;
			this.PSCbutton.Location = new System.Drawing.Point(122, 21);
			this.PSCbutton.Name = "PSCbutton";
			this.PSCbutton.Size = new System.Drawing.Size(81, 30);
			this.PSCbutton.TabIndex = 2;
			this.PSCbutton.Text = "PSC";
			this.PSCbutton.UseVisualStyleBackColor = false;
			this.PSCbutton.Click += new System.EventHandler(this.PSCbuttonClick);
			// 
			// psc1
			// 
			this.psc1.BackColor = System.Drawing.Color.DimGray;
			this.psc1.Location = new System.Drawing.Point(17, 73);
			this.psc1.Name = "psc1";
			this.psc1.Size = new System.Drawing.Size(658, 427);
			this.psc1.TabIndex = 3;
			// 
			// Network
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.Controls.Add(this.psc1);
			this.Controls.Add(this.PSCbutton);
			this.Controls.Add(this.portcheck1);
			this.Controls.Add(this.portcheckbutton);
			this.Name = "Network";
			this.Size = new System.Drawing.Size(691, 503);
			this.ResumeLayout(false);

		}
	}
}
