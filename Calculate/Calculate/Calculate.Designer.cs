﻿/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 13-Oct-17
 * Time: 15:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculate
{
	partial class Calculate : Interface.menuinterface
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private stringcal.Stringcal stringcal1;
		private System.Windows.Forms.Button stringcalbutton;
		
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
			this.stringcal1 = new stringcal.Stringcal();
			this.stringcalbutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// stringcal1
			// 
			this.stringcal1.BackColor = System.Drawing.Color.LightGreen;
			this.stringcal1.Location = new System.Drawing.Point(15, 66);
			this.stringcal1.Name = "stringcal1";
			this.stringcal1.Size = new System.Drawing.Size(626, 328);
			this.stringcal1.TabIndex = 0;
			// 
			// stringcalbutton
			// 
			this.stringcalbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.stringcalbutton.Location = new System.Drawing.Point(15, 17);
			this.stringcalbutton.Name = "stringcalbutton";
			this.stringcalbutton.Size = new System.Drawing.Size(67, 28);
			this.stringcalbutton.TabIndex = 1;
			this.stringcalbutton.Text = "StringCal";
			this.stringcalbutton.UseVisualStyleBackColor = false;
			this.stringcalbutton.Click += new System.EventHandler(this.StringcalbuttonClick);
			// 
			// Calculate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.Controls.Add(this.stringcalbutton);
			this.Controls.Add(this.stringcal1);
			this.Name = "Calculate";
			this.Size = new System.Drawing.Size(660, 410);
			this.ResumeLayout(false);

		}
	}
}
