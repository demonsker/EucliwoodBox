/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 04-Mar-18
 * Time: 00:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace stringoperation
{
	partial class Stringoperator: CalculateInterface.menuinterface
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox stringbox;
		private System.Windows.Forms.Button delspacebutton;
		private System.Windows.Forms.Button insteadbutton;
		private System.Windows.Forms.TextBox originalbox;
		private System.Windows.Forms.TextBox newtextbox;
		private System.Windows.Forms.TextBox insertbox;
		private System.Windows.Forms.TextBox aftertextbox;
		private System.Windows.Forms.Button insertbutton;
		private System.Windows.Forms.TextBox indexval;
		private System.Windows.Forms.TextBox searchbox;
		private System.Windows.Forms.Button getindexbutton;
		private System.Windows.Forms.Button addnumberbutton;
		private System.Windows.Forms.Button delnewlinebutton;
		
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
			this.delspacebutton = new System.Windows.Forms.Button();
			this.insteadbutton = new System.Windows.Forms.Button();
			this.originalbox = new System.Windows.Forms.TextBox();
			this.newtextbox = new System.Windows.Forms.TextBox();
			this.insertbox = new System.Windows.Forms.TextBox();
			this.aftertextbox = new System.Windows.Forms.TextBox();
			this.insertbutton = new System.Windows.Forms.Button();
			this.indexval = new System.Windows.Forms.TextBox();
			this.searchbox = new System.Windows.Forms.TextBox();
			this.getindexbutton = new System.Windows.Forms.Button();
			this.addnumberbutton = new System.Windows.Forms.Button();
			this.delnewlinebutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// stringbox
			// 
			this.stringbox.Location = new System.Drawing.Point(18, 21);
			this.stringbox.Multiline = true;
			this.stringbox.Name = "stringbox";
			this.stringbox.Size = new System.Drawing.Size(532, 196);
			this.stringbox.TabIndex = 1;
			// 
			// delspacebutton
			// 
			this.delspacebutton.BackColor = System.Drawing.Color.LightYellow;
			this.delspacebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.delspacebutton.Location = new System.Drawing.Point(595, 21);
			this.delspacebutton.Name = "delspacebutton";
			this.delspacebutton.Size = new System.Drawing.Size(75, 23);
			this.delspacebutton.TabIndex = 2;
			this.delspacebutton.Text = "DelSpace";
			this.delspacebutton.UseVisualStyleBackColor = false;
			this.delspacebutton.Click += new System.EventHandler(this.DelspacebuttonClick);
			// 
			// insteadbutton
			// 
			this.insteadbutton.BackColor = System.Drawing.Color.Lavender;
			this.insteadbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.insteadbutton.Location = new System.Drawing.Point(126, 315);
			this.insteadbutton.Name = "insteadbutton";
			this.insteadbutton.Size = new System.Drawing.Size(75, 23);
			this.insteadbutton.TabIndex = 3;
			this.insteadbutton.Text = "Instead";
			this.insteadbutton.UseVisualStyleBackColor = false;
			this.insteadbutton.Click += new System.EventHandler(this.InsteadbuttonClick);
			// 
			// originalbox
			// 
			this.originalbox.Location = new System.Drawing.Point(126, 236);
			this.originalbox.Name = "originalbox";
			this.originalbox.Size = new System.Drawing.Size(78, 20);
			this.originalbox.TabIndex = 4;
			this.originalbox.Text = "original";
			// 
			// newtextbox
			// 
			this.newtextbox.Location = new System.Drawing.Point(126, 274);
			this.newtextbox.Name = "newtextbox";
			this.newtextbox.Size = new System.Drawing.Size(78, 20);
			this.newtextbox.TabIndex = 5;
			this.newtextbox.Text = "new text";
			// 
			// insertbox
			// 
			this.insertbox.Location = new System.Drawing.Point(230, 274);
			this.insertbox.Name = "insertbox";
			this.insertbox.Size = new System.Drawing.Size(78, 20);
			this.insertbox.TabIndex = 8;
			this.insertbox.Text = "new text";
			// 
			// aftertextbox
			// 
			this.aftertextbox.Location = new System.Drawing.Point(230, 236);
			this.aftertextbox.Name = "aftertextbox";
			this.aftertextbox.Size = new System.Drawing.Size(78, 20);
			this.aftertextbox.TabIndex = 7;
			this.aftertextbox.Text = "after text";
			// 
			// insertbutton
			// 
			this.insertbutton.BackColor = System.Drawing.Color.LightSkyBlue;
			this.insertbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.insertbutton.Location = new System.Drawing.Point(230, 315);
			this.insertbutton.Name = "insertbutton";
			this.insertbutton.Size = new System.Drawing.Size(75, 23);
			this.insertbutton.TabIndex = 6;
			this.insertbutton.Text = "insert";
			this.insertbutton.UseVisualStyleBackColor = false;
			this.insertbutton.Click += new System.EventHandler(this.InsertbuttonClick);
			// 
			// indexval
			// 
			this.indexval.Location = new System.Drawing.Point(18, 274);
			this.indexval.Name = "indexval";
			this.indexval.ReadOnly = true;
			this.indexval.Size = new System.Drawing.Size(78, 20);
			this.indexval.TabIndex = 10;
			this.indexval.Text = "index";
			// 
			// searchbox
			// 
			this.searchbox.Location = new System.Drawing.Point(18, 236);
			this.searchbox.Name = "searchbox";
			this.searchbox.Size = new System.Drawing.Size(78, 20);
			this.searchbox.TabIndex = 9;
			this.searchbox.Text = "search";
			// 
			// getindexbutton
			// 
			this.getindexbutton.BackColor = System.Drawing.Color.Plum;
			this.getindexbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.getindexbutton.Location = new System.Drawing.Point(18, 315);
			this.getindexbutton.Name = "getindexbutton";
			this.getindexbutton.Size = new System.Drawing.Size(75, 23);
			this.getindexbutton.TabIndex = 11;
			this.getindexbutton.Text = "GetIndex";
			this.getindexbutton.UseVisualStyleBackColor = false;
			this.getindexbutton.Click += new System.EventHandler(this.GetindexbuttonClick);
			// 
			// addnumberbutton
			// 
			this.addnumberbutton.BackColor = System.Drawing.Color.Khaki;
			this.addnumberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addnumberbutton.Location = new System.Drawing.Point(595, 101);
			this.addnumberbutton.Name = "addnumberbutton";
			this.addnumberbutton.Size = new System.Drawing.Size(75, 23);
			this.addnumberbutton.TabIndex = 12;
			this.addnumberbutton.Text = "AddNumber";
			this.addnumberbutton.UseVisualStyleBackColor = false;
			this.addnumberbutton.Click += new System.EventHandler(this.AddnumberbuttonClick);
			// 
			// delnewlinebutton
			// 
			this.delnewlinebutton.BackColor = System.Drawing.Color.Plum;
			this.delnewlinebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.delnewlinebutton.Location = new System.Drawing.Point(595, 61);
			this.delnewlinebutton.Name = "delnewlinebutton";
			this.delnewlinebutton.Size = new System.Drawing.Size(75, 23);
			this.delnewlinebutton.TabIndex = 13;
			this.delnewlinebutton.Text = "DelNewLine";
			this.delnewlinebutton.UseVisualStyleBackColor = false;
			this.delnewlinebutton.Click += new System.EventHandler(this.DelnewlinebuttonClick);
			// 
			// Stringoperator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.Controls.Add(this.delnewlinebutton);
			this.Controls.Add(this.addnumberbutton);
			this.Controls.Add(this.getindexbutton);
			this.Controls.Add(this.indexval);
			this.Controls.Add(this.searchbox);
			this.Controls.Add(this.insertbox);
			this.Controls.Add(this.aftertextbox);
			this.Controls.Add(this.insertbutton);
			this.Controls.Add(this.newtextbox);
			this.Controls.Add(this.originalbox);
			this.Controls.Add(this.insteadbutton);
			this.Controls.Add(this.delspacebutton);
			this.Controls.Add(this.stringbox);
			this.Name = "Stringoperator";
			this.Size = new System.Drawing.Size(729, 427);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
