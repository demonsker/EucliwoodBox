/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 15-Oct-17
 * Time: 22:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Rsa
{
	partial class Rsa : CryptoInterface.menuinterface
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl rsatab;
		private System.Windows.Forms.TabPage encrypttab;
		private System.Windows.Forms.TabPage decrypttab;
		private System.Windows.Forms.TabPage genkeytab;
		private System.Windows.Forms.TextBox publickeyval;
		private System.Windows.Forms.TextBox privatekeyval;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button genkeybutton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox ciphertextval;
		private System.Windows.Forms.TextBox plaintextbox;
		private System.Windows.Forms.Button encryptbutton;
		private System.Windows.Forms.TextBox publickeybox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox privatekeybox;
		private System.Windows.Forms.Button decryptbutton;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox plaintextval;
		private System.Windows.Forms.TextBox ciphertextbox;
		
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
			this.rsatab = new System.Windows.Forms.TabControl();
			this.encrypttab = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.publickeybox = new System.Windows.Forms.TextBox();
			this.encryptbutton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ciphertextval = new System.Windows.Forms.TextBox();
			this.plaintextbox = new System.Windows.Forms.TextBox();
			this.decrypttab = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.privatekeybox = new System.Windows.Forms.TextBox();
			this.decryptbutton = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.plaintextval = new System.Windows.Forms.TextBox();
			this.ciphertextbox = new System.Windows.Forms.TextBox();
			this.genkeytab = new System.Windows.Forms.TabPage();
			this.genkeybutton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.publickeyval = new System.Windows.Forms.TextBox();
			this.privatekeyval = new System.Windows.Forms.TextBox();
			this.rsatab.SuspendLayout();
			this.encrypttab.SuspendLayout();
			this.decrypttab.SuspendLayout();
			this.genkeytab.SuspendLayout();
			this.SuspendLayout();
			// 
			// rsatab
			// 
			this.rsatab.Controls.Add(this.encrypttab);
			this.rsatab.Controls.Add(this.decrypttab);
			this.rsatab.Controls.Add(this.genkeytab);
			this.rsatab.Location = new System.Drawing.Point(17, 39);
			this.rsatab.Name = "rsatab";
			this.rsatab.SelectedIndex = 0;
			this.rsatab.Size = new System.Drawing.Size(644, 377);
			this.rsatab.TabIndex = 0;
			// 
			// encrypttab
			// 
			this.encrypttab.Controls.Add(this.label5);
			this.encrypttab.Controls.Add(this.publickeybox);
			this.encrypttab.Controls.Add(this.encryptbutton);
			this.encrypttab.Controls.Add(this.label3);
			this.encrypttab.Controls.Add(this.label4);
			this.encrypttab.Controls.Add(this.ciphertextval);
			this.encrypttab.Controls.Add(this.plaintextbox);
			this.encrypttab.Location = new System.Drawing.Point(4, 22);
			this.encrypttab.Name = "encrypttab";
			this.encrypttab.Padding = new System.Windows.Forms.Padding(3);
			this.encrypttab.Size = new System.Drawing.Size(636, 351);
			this.encrypttab.TabIndex = 0;
			this.encrypttab.Text = "Encrypt";
			this.encrypttab.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label5.Location = new System.Drawing.Point(6, 149);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(122, 49);
			this.label5.TabIndex = 10;
			this.label5.Text = "PublicKey";
			// 
			// publickeybox
			// 
			this.publickeybox.Location = new System.Drawing.Point(134, 123);
			this.publickeybox.Multiline = true;
			this.publickeybox.Name = "publickeybox";
			this.publickeybox.Size = new System.Drawing.Size(477, 89);
			this.publickeybox.TabIndex = 9;
			// 
			// encryptbutton
			// 
			this.encryptbutton.BackColor = System.Drawing.Color.YellowGreen;
			this.encryptbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.encryptbutton.Location = new System.Drawing.Point(545, 312);
			this.encryptbutton.Name = "encryptbutton";
			this.encryptbutton.Size = new System.Drawing.Size(85, 33);
			this.encryptbutton.TabIndex = 8;
			this.encryptbutton.Text = "Encrypt";
			this.encryptbutton.UseVisualStyleBackColor = false;
			this.encryptbutton.Click += new System.EventHandler(this.EncryptbuttonClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label3.Location = new System.Drawing.Point(3, 246);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 49);
			this.label3.TabIndex = 7;
			this.label3.Text = "CipherText";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label4.Location = new System.Drawing.Point(6, 45);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(122, 49);
			this.label4.TabIndex = 6;
			this.label4.Text = "PlainText";
			// 
			// ciphertextval
			// 
			this.ciphertextval.Location = new System.Drawing.Point(134, 235);
			this.ciphertextval.Multiline = true;
			this.ciphertextval.Name = "ciphertextval";
			this.ciphertextval.ReadOnly = true;
			this.ciphertextval.Size = new System.Drawing.Size(477, 60);
			this.ciphertextval.TabIndex = 5;
			// 
			// plaintextbox
			// 
			this.plaintextbox.Location = new System.Drawing.Point(134, 16);
			this.plaintextbox.Multiline = true;
			this.plaintextbox.Name = "plaintextbox";
			this.plaintextbox.Size = new System.Drawing.Size(477, 89);
			this.plaintextbox.TabIndex = 4;
			// 
			// decrypttab
			// 
			this.decrypttab.Controls.Add(this.label6);
			this.decrypttab.Controls.Add(this.privatekeybox);
			this.decrypttab.Controls.Add(this.decryptbutton);
			this.decrypttab.Controls.Add(this.label7);
			this.decrypttab.Controls.Add(this.label8);
			this.decrypttab.Controls.Add(this.plaintextval);
			this.decrypttab.Controls.Add(this.ciphertextbox);
			this.decrypttab.Location = new System.Drawing.Point(4, 22);
			this.decrypttab.Name = "decrypttab";
			this.decrypttab.Padding = new System.Windows.Forms.Padding(3);
			this.decrypttab.Size = new System.Drawing.Size(636, 351);
			this.decrypttab.TabIndex = 1;
			this.decrypttab.Text = "Decrypt";
			this.decrypttab.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label6.Location = new System.Drawing.Point(8, 122);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(122, 49);
			this.label6.TabIndex = 17;
			this.label6.Text = "PrivateKey";
			// 
			// privatekeybox
			// 
			this.privatekeybox.Location = new System.Drawing.Point(136, 86);
			this.privatekeybox.Multiline = true;
			this.privatekeybox.Name = "privatekeybox";
			this.privatekeybox.Size = new System.Drawing.Size(477, 110);
			this.privatekeybox.TabIndex = 16;
			// 
			// decryptbutton
			// 
			this.decryptbutton.BackColor = System.Drawing.Color.LightYellow;
			this.decryptbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.decryptbutton.Location = new System.Drawing.Point(547, 307);
			this.decryptbutton.Name = "decryptbutton";
			this.decryptbutton.Size = new System.Drawing.Size(85, 33);
			this.decryptbutton.TabIndex = 15;
			this.decryptbutton.Text = "Decrypt";
			this.decryptbutton.UseVisualStyleBackColor = false;
			this.decryptbutton.Click += new System.EventHandler(this.DecryptbuttonClick);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label7.Location = new System.Drawing.Point(8, 21);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(122, 49);
			this.label7.TabIndex = 14;
			this.label7.Text = "CipherText";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label8.Location = new System.Drawing.Point(8, 235);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(122, 49);
			this.label8.TabIndex = 13;
			this.label8.Text = "PlainText";
			// 
			// plaintextval
			// 
			this.plaintextval.Location = new System.Drawing.Point(136, 213);
			this.plaintextval.Multiline = true;
			this.plaintextval.Name = "plaintextval";
			this.plaintextval.ReadOnly = true;
			this.plaintextval.Size = new System.Drawing.Size(477, 88);
			this.plaintextval.TabIndex = 12;
			// 
			// ciphertextbox
			// 
			this.ciphertextbox.Location = new System.Drawing.Point(136, 11);
			this.ciphertextbox.Multiline = true;
			this.ciphertextbox.Name = "ciphertextbox";
			this.ciphertextbox.Size = new System.Drawing.Size(477, 59);
			this.ciphertextbox.TabIndex = 11;
			// 
			// genkeytab
			// 
			this.genkeytab.Controls.Add(this.genkeybutton);
			this.genkeytab.Controls.Add(this.label2);
			this.genkeytab.Controls.Add(this.label1);
			this.genkeytab.Controls.Add(this.publickeyval);
			this.genkeytab.Controls.Add(this.privatekeyval);
			this.genkeytab.Location = new System.Drawing.Point(4, 22);
			this.genkeytab.Name = "genkeytab";
			this.genkeytab.Padding = new System.Windows.Forms.Padding(3);
			this.genkeytab.Size = new System.Drawing.Size(636, 351);
			this.genkeytab.TabIndex = 2;
			this.genkeytab.Text = "GenKey";
			this.genkeytab.UseVisualStyleBackColor = true;
			// 
			// genkeybutton
			// 
			this.genkeybutton.BackColor = System.Drawing.Color.Tan;
			this.genkeybutton.Location = new System.Drawing.Point(584, 151);
			this.genkeybutton.Name = "genkeybutton";
			this.genkeybutton.Size = new System.Drawing.Size(46, 38);
			this.genkeybutton.TabIndex = 4;
			this.genkeybutton.Text = "Gen";
			this.genkeybutton.UseVisualStyleBackColor = false;
			this.genkeybutton.Click += new System.EventHandler(this.GenkeybuttonClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label2.Location = new System.Drawing.Point(3, 236);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 49);
			this.label2.TabIndex = 3;
			this.label2.Text = "PublicKey";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.Location = new System.Drawing.Point(3, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 49);
			this.label1.TabIndex = 2;
			this.label1.Text = "PrivateKey";
			// 
			// publickeyval
			// 
			this.publickeyval.Location = new System.Drawing.Point(131, 189);
			this.publickeyval.Multiline = true;
			this.publickeyval.Name = "publickeyval";
			this.publickeyval.ReadOnly = true;
			this.publickeyval.Size = new System.Drawing.Size(438, 135);
			this.publickeyval.TabIndex = 1;
			// 
			// privatekeyval
			// 
			this.privatekeyval.Location = new System.Drawing.Point(131, 19);
			this.privatekeyval.Multiline = true;
			this.privatekeyval.Name = "privatekeyval";
			this.privatekeyval.ReadOnly = true;
			this.privatekeyval.Size = new System.Drawing.Size(438, 135);
			this.privatekeyval.TabIndex = 0;
			// 
			// Rsa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.Controls.Add(this.rsatab);
			this.Name = "Rsa";
			this.Size = new System.Drawing.Size(677, 436);
			this.rsatab.ResumeLayout(false);
			this.encrypttab.ResumeLayout(false);
			this.encrypttab.PerformLayout();
			this.decrypttab.ResumeLayout(false);
			this.decrypttab.PerformLayout();
			this.genkeytab.ResumeLayout(false);
			this.genkeytab.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
