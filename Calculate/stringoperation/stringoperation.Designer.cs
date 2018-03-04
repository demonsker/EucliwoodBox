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
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button getnumberbutton;
		private System.Windows.Forms.CheckBox newlinenewtextcheck;
		private System.Windows.Forms.CheckBox newlineoriginalcheck;
		private System.Windows.Forms.Button addnewlinebutton;
		private System.Windows.Forms.TextBox numberofcharacternewline;
		private System.Windows.Forms.Button addspacebutton;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.numberofcharacternewline = new System.Windows.Forms.TextBox();
			this.addnewlinebutton = new System.Windows.Forms.Button();
			this.newlineoriginalcheck = new System.Windows.Forms.CheckBox();
			this.newlinenewtextcheck = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.getnumberbutton = new System.Windows.Forms.Button();
			this.addspacebutton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// stringbox
			// 
			this.stringbox.Location = new System.Drawing.Point(18, 21);
			this.stringbox.Multiline = true;
			this.stringbox.Name = "stringbox";
			this.stringbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.stringbox.Size = new System.Drawing.Size(532, 196);
			this.stringbox.TabIndex = 1;
			// 
			// delspacebutton
			// 
			this.delspacebutton.BackColor = System.Drawing.Color.LightYellow;
			this.delspacebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.delspacebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.delspacebutton.ForeColor = System.Drawing.Color.Black;
			this.delspacebutton.Location = new System.Drawing.Point(6, 35);
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
			this.insteadbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.insteadbutton.ForeColor = System.Drawing.Color.Black;
			this.insteadbutton.Location = new System.Drawing.Point(196, 124);
			this.insteadbutton.Name = "insteadbutton";
			this.insteadbutton.Size = new System.Drawing.Size(75, 23);
			this.insteadbutton.TabIndex = 3;
			this.insteadbutton.Text = "Instead";
			this.insteadbutton.UseVisualStyleBackColor = false;
			this.insteadbutton.Click += new System.EventHandler(this.InsteadbuttonClick);
			// 
			// originalbox
			// 
			this.originalbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.originalbox.ForeColor = System.Drawing.Color.Black;
			this.originalbox.Location = new System.Drawing.Point(6, 127);
			this.originalbox.Name = "originalbox";
			this.originalbox.Size = new System.Drawing.Size(78, 20);
			this.originalbox.TabIndex = 4;
			this.originalbox.Text = "original";
			// 
			// newtextbox
			// 
			this.newtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.newtextbox.ForeColor = System.Drawing.Color.Black;
			this.newtextbox.Location = new System.Drawing.Point(90, 127);
			this.newtextbox.Name = "newtextbox";
			this.newtextbox.Size = new System.Drawing.Size(78, 20);
			this.newtextbox.TabIndex = 5;
			this.newtextbox.Text = "new text";
			// 
			// insertbox
			// 
			this.insertbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.insertbox.Location = new System.Drawing.Point(90, 89);
			this.insertbox.Name = "insertbox";
			this.insertbox.Size = new System.Drawing.Size(78, 20);
			this.insertbox.TabIndex = 8;
			this.insertbox.Text = "new text";
			// 
			// aftertextbox
			// 
			this.aftertextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.aftertextbox.Location = new System.Drawing.Point(6, 89);
			this.aftertextbox.Name = "aftertextbox";
			this.aftertextbox.Size = new System.Drawing.Size(78, 20);
			this.aftertextbox.TabIndex = 7;
			this.aftertextbox.Text = "after text";
			// 
			// insertbutton
			// 
			this.insertbutton.BackColor = System.Drawing.Color.LightSkyBlue;
			this.insertbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.insertbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.insertbutton.ForeColor = System.Drawing.Color.Black;
			this.insertbutton.Location = new System.Drawing.Point(196, 86);
			this.insertbutton.Name = "insertbutton";
			this.insertbutton.Size = new System.Drawing.Size(75, 23);
			this.insertbutton.TabIndex = 6;
			this.insertbutton.Text = "insert";
			this.insertbutton.UseVisualStyleBackColor = false;
			this.insertbutton.Click += new System.EventHandler(this.InsertbuttonClick);
			// 
			// indexval
			// 
			this.indexval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.indexval.ForeColor = System.Drawing.Color.Black;
			this.indexval.Location = new System.Drawing.Point(102, 72);
			this.indexval.Name = "indexval";
			this.indexval.ReadOnly = true;
			this.indexval.Size = new System.Drawing.Size(78, 20);
			this.indexval.TabIndex = 10;
			this.indexval.Text = "index";
			// 
			// searchbox
			// 
			this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.searchbox.ForeColor = System.Drawing.Color.Black;
			this.searchbox.Location = new System.Drawing.Point(6, 72);
			this.searchbox.Name = "searchbox";
			this.searchbox.Size = new System.Drawing.Size(78, 20);
			this.searchbox.TabIndex = 9;
			this.searchbox.Text = "search";
			// 
			// getindexbutton
			// 
			this.getindexbutton.BackColor = System.Drawing.Color.Plum;
			this.getindexbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.getindexbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.getindexbutton.ForeColor = System.Drawing.Color.Black;
			this.getindexbutton.Location = new System.Drawing.Point(207, 70);
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
			this.addnumberbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.addnumberbutton.ForeColor = System.Drawing.Color.Black;
			this.addnumberbutton.Location = new System.Drawing.Point(6, 28);
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
			this.delnewlinebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.delnewlinebutton.ForeColor = System.Drawing.Color.Black;
			this.delnewlinebutton.Location = new System.Drawing.Point(101, 35);
			this.delnewlinebutton.Name = "delnewlinebutton";
			this.delnewlinebutton.Size = new System.Drawing.Size(75, 23);
			this.delnewlinebutton.TabIndex = 13;
			this.delnewlinebutton.Text = "DelNewLine";
			this.delnewlinebutton.UseVisualStyleBackColor = false;
			this.delnewlinebutton.Click += new System.EventHandler(this.DelnewlinebuttonClick);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
			this.groupBox1.Controls.Add(this.delspacebutton);
			this.groupBox1.Controls.Add(this.delnewlinebutton);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(556, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(190, 165);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Deletion";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.DarkCyan;
			this.groupBox2.Controls.Add(this.addspacebutton);
			this.groupBox2.Controls.Add(this.numberofcharacternewline);
			this.groupBox2.Controls.Add(this.addnewlinebutton);
			this.groupBox2.Controls.Add(this.newlineoriginalcheck);
			this.groupBox2.Controls.Add(this.newlinenewtextcheck);
			this.groupBox2.Controls.Add(this.addnumberbutton);
			this.groupBox2.Controls.Add(this.aftertextbox);
			this.groupBox2.Controls.Add(this.insertbutton);
			this.groupBox2.Controls.Add(this.insertbox);
			this.groupBox2.Controls.Add(this.originalbox);
			this.groupBox2.Controls.Add(this.newtextbox);
			this.groupBox2.Controls.Add(this.insteadbutton);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(325, 234);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(328, 257);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Adding";
			// 
			// numberofcharacternewline
			// 
			this.numberofcharacternewline.Location = new System.Drawing.Point(262, 25);
			this.numberofcharacternewline.Name = "numberofcharacternewline";
			this.numberofcharacternewline.Size = new System.Drawing.Size(39, 26);
			this.numberofcharacternewline.TabIndex = 16;
			this.numberofcharacternewline.Text = "1";
			// 
			// addnewlinebutton
			// 
			this.addnewlinebutton.BackColor = System.Drawing.Color.Moccasin;
			this.addnewlinebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addnewlinebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.addnewlinebutton.ForeColor = System.Drawing.Color.Black;
			this.addnewlinebutton.Location = new System.Drawing.Point(162, 27);
			this.addnewlinebutton.Name = "addnewlinebutton";
			this.addnewlinebutton.Size = new System.Drawing.Size(82, 23);
			this.addnewlinebutton.TabIndex = 15;
			this.addnewlinebutton.Text = "AddNewLine";
			this.addnewlinebutton.UseVisualStyleBackColor = false;
			this.addnewlinebutton.Click += new System.EventHandler(this.AddnewlinebuttonClick);
			// 
			// newlineoriginalcheck
			// 
			this.newlineoriginalcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.newlineoriginalcheck.Location = new System.Drawing.Point(9, 56);
			this.newlineoriginalcheck.Name = "newlineoriginalcheck";
			this.newlineoriginalcheck.Size = new System.Drawing.Size(75, 24);
			this.newlineoriginalcheck.TabIndex = 14;
			this.newlineoriginalcheck.Text = "NewLine";
			this.newlineoriginalcheck.UseVisualStyleBackColor = true;
			// 
			// newlinenewtextcheck
			// 
			this.newlinenewtextcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.newlinenewtextcheck.Location = new System.Drawing.Point(93, 56);
			this.newlinenewtextcheck.Name = "newlinenewtextcheck";
			this.newlinenewtextcheck.Size = new System.Drawing.Size(75, 24);
			this.newlinenewtextcheck.TabIndex = 13;
			this.newlinenewtextcheck.Text = "NewLine";
			this.newlinenewtextcheck.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.MediumPurple;
			this.groupBox3.Controls.Add(this.getnumberbutton);
			this.groupBox3.Controls.Add(this.searchbox);
			this.groupBox3.Controls.Add(this.indexval);
			this.groupBox3.Controls.Add(this.getindexbutton);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.groupBox3.ForeColor = System.Drawing.Color.White;
			this.groupBox3.Location = new System.Drawing.Point(18, 234);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(288, 204);
			this.groupBox3.TabIndex = 16;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Getting";
			// 
			// getnumberbutton
			// 
			this.getnumberbutton.BackColor = System.Drawing.Color.Khaki;
			this.getnumberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.getnumberbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.getnumberbutton.ForeColor = System.Drawing.Color.Black;
			this.getnumberbutton.Location = new System.Drawing.Point(6, 25);
			this.getnumberbutton.Name = "getnumberbutton";
			this.getnumberbutton.Size = new System.Drawing.Size(75, 23);
			this.getnumberbutton.TabIndex = 17;
			this.getnumberbutton.Text = "GetNumber";
			this.getnumberbutton.UseVisualStyleBackColor = false;
			this.getnumberbutton.Click += new System.EventHandler(this.GetnumberbuttonClick);
			// 
			// addspacebutton
			// 
			this.addspacebutton.BackColor = System.Drawing.Color.YellowGreen;
			this.addspacebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addspacebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.addspacebutton.ForeColor = System.Drawing.Color.Black;
			this.addspacebutton.Location = new System.Drawing.Point(85, 27);
			this.addspacebutton.Name = "addspacebutton";
			this.addspacebutton.Size = new System.Drawing.Size(71, 23);
			this.addspacebutton.TabIndex = 17;
			this.addspacebutton.Text = "AddSpace";
			this.addspacebutton.UseVisualStyleBackColor = false;
			this.addspacebutton.Click += new System.EventHandler(this.AddspacebuttonClick);
			// 
			// Stringoperator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.stringbox);
			this.Name = "Stringoperator";
			this.Size = new System.Drawing.Size(763, 730);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
