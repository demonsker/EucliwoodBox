/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 13-Oct-17
 * Time: 03:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PSEX
{
	partial class PSC : NetworkInterface.menuinterface
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox rtime;
		private System.Windows.Forms.RadioButton rrestart;
		private System.Windows.Forms.RadioButton rshutdown;
		private System.Windows.Forms.TextBox time;
		private System.Windows.Forms.Button R_A_C;
		private System.Windows.Forms.Button S_R_D;
		private System.Windows.Forms.Button Shared;
		private System.Windows.Forms.Button P_ing;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox s_delete;
		private System.Windows.Forms.TextBox sname;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox path;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button a_r_p;
		private System.Windows.Forms.Button shut_down;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox ip;
		private System.Windows.Forms.TextBox user;
		private System.Windows.Forms.TextBox pass;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button ps_exec;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox IM;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox pid;
		private System.Windows.Forms.Button task_kill;
		private System.Windows.Forms.Button task_list;
		private System.Windows.Forms.Button net_use;
		
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
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.rtime = new System.Windows.Forms.CheckBox();
			this.rrestart = new System.Windows.Forms.RadioButton();
			this.rshutdown = new System.Windows.Forms.RadioButton();
			this.time = new System.Windows.Forms.TextBox();
			this.R_A_C = new System.Windows.Forms.Button();
			this.S_R_D = new System.Windows.Forms.Button();
			this.Shared = new System.Windows.Forms.Button();
			this.P_ing = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.s_delete = new System.Windows.Forms.CheckBox();
			this.sname = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.path = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.a_r_p = new System.Windows.Forms.Button();
			this.shut_down = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.ip = new System.Windows.Forms.TextBox();
			this.user = new System.Windows.Forms.TextBox();
			this.pass = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ps_exec = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.IM = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pid = new System.Windows.Forms.TextBox();
			this.task_kill = new System.Windows.Forms.Button();
			this.task_list = new System.Windows.Forms.Button();
			this.net_use = new System.Windows.Forms.Button();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.rtime);
			this.groupBox4.Controls.Add(this.rrestart);
			this.groupBox4.Controls.Add(this.rshutdown);
			this.groupBox4.Controls.Add(this.time);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.groupBox4.ForeColor = System.Drawing.Color.White;
			this.groupBox4.Location = new System.Drawing.Point(193, 177);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(225, 87);
			this.groupBox4.TabIndex = 40;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Shutdown";
			// 
			// rtime
			// 
			this.rtime.Location = new System.Drawing.Point(16, 47);
			this.rtime.Name = "rtime";
			this.rtime.Size = new System.Drawing.Size(66, 21);
			this.rtime.TabIndex = 18;
			this.rtime.Text = "time";
			this.rtime.UseVisualStyleBackColor = true;
			// 
			// rrestart
			// 
			this.rrestart.Location = new System.Drawing.Point(122, 19);
			this.rrestart.Name = "rrestart";
			this.rrestart.Size = new System.Drawing.Size(86, 26);
			this.rrestart.TabIndex = 17;
			this.rrestart.TabStop = true;
			this.rrestart.Text = "restart";
			this.rrestart.UseVisualStyleBackColor = true;
			// 
			// rshutdown
			// 
			this.rshutdown.Location = new System.Drawing.Point(16, 19);
			this.rshutdown.Name = "rshutdown";
			this.rshutdown.Size = new System.Drawing.Size(102, 26);
			this.rshutdown.TabIndex = 16;
			this.rshutdown.TabStop = true;
			this.rshutdown.Text = "shutdown";
			this.rshutdown.UseVisualStyleBackColor = true;
			// 
			// time
			// 
			this.time.Location = new System.Drawing.Point(87, 47);
			this.time.Name = "time";
			this.time.Size = new System.Drawing.Size(98, 26);
			this.time.TabIndex = 14;
			// 
			// R_A_C
			// 
			this.R_A_C.Location = new System.Drawing.Point(323, 375);
			this.R_A_C.Name = "R_A_C";
			this.R_A_C.Size = new System.Drawing.Size(95, 29);
			this.R_A_C.TabIndex = 39;
			this.R_A_C.Text = "Start RAC";
			this.R_A_C.UseVisualStyleBackColor = true;
			this.R_A_C.Click += new System.EventHandler(this.startRAC);
			// 
			// S_R_D
			// 
			this.S_R_D.Location = new System.Drawing.Point(216, 375);
			this.S_R_D.Name = "S_R_D";
			this.S_R_D.Size = new System.Drawing.Size(95, 29);
			this.S_R_D.TabIndex = 38;
			this.S_R_D.Text = "Start RD";
			this.S_R_D.UseVisualStyleBackColor = true;
			this.S_R_D.Click += new System.EventHandler(this.startRD);
			// 
			// Shared
			// 
			this.Shared.BackColor = System.Drawing.Color.Ivory;
			this.Shared.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Shared.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.Shared.Location = new System.Drawing.Point(9, 260);
			this.Shared.Name = "Shared";
			this.Shared.Size = new System.Drawing.Size(89, 30);
			this.Shared.TabIndex = 37;
			this.Shared.Text = "share";
			this.Shared.UseVisualStyleBackColor = false;
			this.Shared.Click += new System.EventHandler(this.share);
			// 
			// P_ing
			// 
			this.P_ing.BackColor = System.Drawing.Color.Ivory;
			this.P_ing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.P_ing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.P_ing.Location = new System.Drawing.Point(9, 296);
			this.P_ing.Name = "P_ing";
			this.P_ing.Size = new System.Drawing.Size(89, 30);
			this.P_ing.TabIndex = 36;
			this.P_ing.Text = "ping";
			this.P_ing.UseVisualStyleBackColor = false;
			this.P_ing.Click += new System.EventHandler(this.ping);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.s_delete);
			this.groupBox3.Controls.Add(this.sname);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.path);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.groupBox3.ForeColor = System.Drawing.Color.White;
			this.groupBox3.Location = new System.Drawing.Point(193, 24);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(225, 141);
			this.groupBox3.TabIndex = 35;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Share";
			// 
			// s_delete
			// 
			this.s_delete.Location = new System.Drawing.Point(15, 104);
			this.s_delete.Name = "s_delete";
			this.s_delete.Size = new System.Drawing.Size(82, 25);
			this.s_delete.TabIndex = 16;
			this.s_delete.Text = "delete";
			this.s_delete.UseVisualStyleBackColor = true;
			// 
			// sname
			// 
			this.sname.Location = new System.Drawing.Point(78, 72);
			this.sname.Name = "sname";
			this.sname.Size = new System.Drawing.Size(130, 26);
			this.sname.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(15, 75);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 23);
			this.label7.TabIndex = 14;
			this.label7.Text = "name";
			// 
			// path
			// 
			this.path.Location = new System.Drawing.Point(78, 25);
			this.path.Name = "path";
			this.path.Size = new System.Drawing.Size(130, 26);
			this.path.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(15, 28);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "Path";
			// 
			// a_r_p
			// 
			this.a_r_p.BackColor = System.Drawing.Color.Ivory;
			this.a_r_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.a_r_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.a_r_p.Location = new System.Drawing.Point(9, 224);
			this.a_r_p.Name = "a_r_p";
			this.a_r_p.Size = new System.Drawing.Size(89, 30);
			this.a_r_p.TabIndex = 34;
			this.a_r_p.Text = "arp";
			this.a_r_p.UseVisualStyleBackColor = false;
			this.a_r_p.Click += new System.EventHandler(this.arp);
			// 
			// shut_down
			// 
			this.shut_down.BackColor = System.Drawing.Color.Ivory;
			this.shut_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.shut_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.shut_down.Location = new System.Drawing.Point(9, 188);
			this.shut_down.Name = "shut_down";
			this.shut_down.Size = new System.Drawing.Size(89, 30);
			this.shut_down.TabIndex = 33;
			this.shut_down.Text = "shutdown";
			this.shut_down.UseVisualStyleBackColor = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.ip);
			this.groupBox2.Controls.Add(this.user);
			this.groupBox2.Controls.Add(this.pass);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(423, 22);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(226, 143);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "General";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(31, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "IP";
			// 
			// ip
			// 
			this.ip.Location = new System.Drawing.Point(81, 28);
			this.ip.Name = "ip";
			this.ip.Size = new System.Drawing.Size(130, 26);
			this.ip.TabIndex = 0;
			// 
			// user
			// 
			this.user.Location = new System.Drawing.Point(81, 64);
			this.user.Name = "user";
			this.user.Size = new System.Drawing.Size(128, 26);
			this.user.TabIndex = 1;
			// 
			// pass
			// 
			this.pass.Location = new System.Drawing.Point(81, 101);
			this.pass.Name = "pass";
			this.pass.PasswordChar = '*';
			this.pass.Size = new System.Drawing.Size(128, 26);
			this.pass.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(17, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "user";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(17, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "pass";
			// 
			// ps_exec
			// 
			this.ps_exec.BackColor = System.Drawing.Color.Ivory;
			this.ps_exec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ps_exec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.ps_exec.Location = new System.Drawing.Point(9, 152);
			this.ps_exec.Name = "ps_exec";
			this.ps_exec.Size = new System.Drawing.Size(89, 30);
			this.ps_exec.TabIndex = 31;
			this.ps_exec.Text = "psexec";
			this.ps_exec.UseVisualStyleBackColor = false;
			this.ps_exec.Click += new System.EventHandler(this.psexec);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.IM);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.pid);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(424, 171);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(225, 147);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Process";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(28, 101);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(123, 34);
			this.checkBox1.TabIndex = 14;
			this.checkBox1.Text = "GUI";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(26, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(28, 23);
			this.label4.TabIndex = 13;
			this.label4.Text = "IM";
			// 
			// IM
			// 
			this.IM.Location = new System.Drawing.Point(64, 67);
			this.IM.Name = "IM";
			this.IM.Size = new System.Drawing.Size(130, 26);
			this.IM.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(20, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 23);
			this.label1.TabIndex = 11;
			this.label1.Text = "PID";
			// 
			// pid
			// 
			this.pid.Location = new System.Drawing.Point(64, 25);
			this.pid.Name = "pid";
			this.pid.Size = new System.Drawing.Size(130, 26);
			this.pid.TabIndex = 1;
			// 
			// task_kill
			// 
			this.task_kill.BackColor = System.Drawing.Color.Ivory;
			this.task_kill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.task_kill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.task_kill.Location = new System.Drawing.Point(9, 116);
			this.task_kill.Name = "task_kill";
			this.task_kill.Size = new System.Drawing.Size(89, 30);
			this.task_kill.TabIndex = 29;
			this.task_kill.Text = "taskkill";
			this.task_kill.UseVisualStyleBackColor = false;
			this.task_kill.Click += new System.EventHandler(this.taskkill);
			// 
			// task_list
			// 
			this.task_list.BackColor = System.Drawing.Color.Ivory;
			this.task_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.task_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.task_list.Location = new System.Drawing.Point(9, 79);
			this.task_list.Name = "task_list";
			this.task_list.Size = new System.Drawing.Size(89, 30);
			this.task_list.TabIndex = 28;
			this.task_list.Text = "tasklist";
			this.task_list.UseVisualStyleBackColor = false;
			this.task_list.Click += new System.EventHandler(this.tasklist);
			// 
			// net_use
			// 
			this.net_use.BackColor = System.Drawing.Color.Ivory;
			this.net_use.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.net_use.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.net_use.Location = new System.Drawing.Point(9, 40);
			this.net_use.Name = "net_use";
			this.net_use.Size = new System.Drawing.Size(89, 30);
			this.net_use.TabIndex = 27;
			this.net_use.Text = "net use";
			this.net_use.UseVisualStyleBackColor = false;
			this.net_use.Click += new System.EventHandler(this.netuse);
			// 
			// PSC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.R_A_C);
			this.Controls.Add(this.S_R_D);
			this.Controls.Add(this.Shared);
			this.Controls.Add(this.P_ing);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.a_r_p);
			this.Controls.Add(this.shut_down);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.ps_exec);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.task_kill);
			this.Controls.Add(this.task_list);
			this.Controls.Add(this.net_use);
			this.Name = "PSC";
			this.Size = new System.Drawing.Size(658, 427);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
