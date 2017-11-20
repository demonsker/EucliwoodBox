/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 11-Oct-17
 * Time: 18:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace stringcal
{
	partial class Stringcal: CalculateInterface.menuinterface
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox stringbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox sumvalue;
		private System.Windows.Forms.Button calbutton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label amoutval;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label stringlengthval;
		
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
			this.stringbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.calbutton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.amoutval = new System.Windows.Forms.Label();
			this.sumvalue = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.stringlengthval = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// stringbox
			// 
			this.stringbox.Location = new System.Drawing.Point(43, 14);
			this.stringbox.Multiline = true;
			this.stringbox.Name = "stringbox";
			this.stringbox.Size = new System.Drawing.Size(532, 196);
			this.stringbox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.Location = new System.Drawing.Point(120, 269);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 34);
			this.label1.TabIndex = 1;
			this.label1.Text = "Sum";
			// 
			// calbutton
			// 
			this.calbutton.BackColor = System.Drawing.Color.Lavender;
			this.calbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.calbutton.Location = new System.Drawing.Point(431, 268);
			this.calbutton.Name = "calbutton";
			this.calbutton.Size = new System.Drawing.Size(46, 35);
			this.calbutton.TabIndex = 3;
			this.calbutton.Text = "Cal";
			this.calbutton.UseVisualStyleBackColor = false;
			this.calbutton.Click += new System.EventHandler(this.CalbuttonClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label2.Location = new System.Drawing.Point(461, 225);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 34);
			this.label2.TabIndex = 4;
			this.label2.Text = "amount";
			// 
			// amoutval
			// 
			this.amoutval.BackColor = System.Drawing.Color.Orange;
			this.amoutval.Location = new System.Drawing.Point(526, 225);
			this.amoutval.Name = "amoutval";
			this.amoutval.Size = new System.Drawing.Size(49, 20);
			this.amoutval.TabIndex = 5;
			this.amoutval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sumvalue
			// 
			this.sumvalue.BackColor = System.Drawing.Color.Bisque;
			this.sumvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.sumvalue.Location = new System.Drawing.Point(208, 268);
			this.sumvalue.Name = "sumvalue";
			this.sumvalue.ReadOnly = true;
			this.sumvalue.Size = new System.Drawing.Size(185, 35);
			this.sumvalue.TabIndex = 6;
			this.sumvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label3.Location = new System.Drawing.Point(15, 224);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 34);
			this.label3.TabIndex = 7;
			this.label3.Text = "Length";
			// 
			// stringlengthval
			// 
			this.stringlengthval.BackColor = System.Drawing.Color.PaleVioletRed;
			this.stringlengthval.Location = new System.Drawing.Point(81, 225);
			this.stringlengthval.Name = "stringlengthval";
			this.stringlengthval.Size = new System.Drawing.Size(49, 20);
			this.stringlengthval.TabIndex = 8;
			this.stringlengthval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Stringcal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.Controls.Add(this.stringlengthval);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.sumvalue);
			this.Controls.Add(this.amoutval);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.calbutton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.stringbox);
			this.Name = "Stringcal";
			this.Size = new System.Drawing.Size(626, 328);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
