/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 13-Oct-17
 * Time: 01:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Portcheck
{
	partial class Portcheck : NetworkInterface.menuinterface
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ipbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox portbox;
		private System.Windows.Forms.Button checkbutton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label statusval;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.ipbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.portbox = new System.Windows.Forms.TextBox();
			this.checkbutton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.statusval = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.Location = new System.Drawing.Point(43, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "IP";
			// 
			// ipbox
			// 
			this.ipbox.Location = new System.Drawing.Point(111, 55);
			this.ipbox.Name = "ipbox";
			this.ipbox.Size = new System.Drawing.Size(148, 20);
			this.ipbox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label2.Location = new System.Drawing.Point(30, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "PORT";
			// 
			// portbox
			// 
			this.portbox.Location = new System.Drawing.Point(111, 108);
			this.portbox.Name = "portbox";
			this.portbox.Size = new System.Drawing.Size(148, 20);
			this.portbox.TabIndex = 3;
			// 
			// checkbutton
			// 
			this.checkbutton.BackColor = System.Drawing.Color.LemonChiffon;
			this.checkbutton.Location = new System.Drawing.Point(144, 163);
			this.checkbutton.Name = "checkbutton";
			this.checkbutton.Size = new System.Drawing.Size(76, 35);
			this.checkbutton.TabIndex = 4;
			this.checkbutton.Text = "Check";
			this.checkbutton.UseVisualStyleBackColor = false;
			this.checkbutton.Click += new System.EventHandler(this.CheckbuttonClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label3.Location = new System.Drawing.Point(30, 236);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "STATUS";
			// 
			// statusval
			// 
			this.statusval.BackColor = System.Drawing.Color.LawnGreen;
			this.statusval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.statusval.Location = new System.Drawing.Point(144, 236);
			this.statusval.Name = "statusval";
			this.statusval.Size = new System.Drawing.Size(189, 23);
			this.statusval.TabIndex = 6;
			this.statusval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Portcheck
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.Controls.Add(this.statusval);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.checkbutton);
			this.Controls.Add(this.portbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ipbox);
			this.Controls.Add(this.label1);
			this.Name = "Portcheck";
			this.Size = new System.Drawing.Size(439, 294);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
