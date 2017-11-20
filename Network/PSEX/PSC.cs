/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 13-Oct-17
 * Time: 03:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PSEX
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class PSC : UserControl
	{
		Cmd command = new Cmd();
		public PSC()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		bool box(string message,string title){
			DialogResult dialogResult = MessageBox.Show(message,title, MessageBoxButtons.YesNo);
	        if(dialogResult == DialogResult.Yes)
	        	return true;
			else
			    return false;	
		}
		void netuse(object sender, EventArgs e)
		{  if(ip.Text=="") { MessageBox.Show("ip must not null"); return; }
		   if(user.Text!="") command.netuse(ip.Text,user.Text);
		   else command.netuse(ip.Text);
		}
		void tasklist(object sender, EventArgs e)
		{   if(ip.Text!="" && user.Text!="" && pass.Text!=null) command.tasklist(ip.Text,user.Text,pass.Text);
			else if(ip.Text!="" && user.Text!="" ) command.tasklist(ip.Text,user.Text);
			else if(ip.Text!="") command.tasklist(ip.Text);
			else command.tasklist();
		}
		void taskkill(object sender, EventArgs e)
		{   if(pid.Text=="" && IM.Text=="") { MessageBox.Show("pid or IM  must not null"); return; }
			if(ip.Text!="" && user.Text!="" && pass.Text!=null && pid.Text!="") 
				  command.taskkillp(ip.Text,user.Text,pass.Text,pid.Text);
			else if(ip.Text!="" && user.Text!="" && pass.Text!=null && IM.Text!="") 
				  command.taskkilln(ip.Text,user.Text,pass.Text,IM.Text);
			else if(ip.Text!="" && user.Text!="" && pid.Text!="") 
				  command.taskkillp(ip.Text,user.Text,pid.Text);
			else if(ip.Text!="" && user.Text!="" && IM.Text!="") 
				  command.taskkilln(ip.Text,user.Text,IM.Text);
			else if(ip.Text!="" && pid.Text!="") 
				  command.taskkillp(ip.Text,pid.Text);
			else if(ip.Text!="" && IM.Text!="") 
				  command.taskkilln(ip.Text,IM.Text);
			else if(pid.Text!="") 
				  command.taskkillp(pid.Text);
			else command.taskkilln(IM.Text);
		}
		void psexec(object sender, EventArgs e)
		{  	string ps = IM.Text;
			if(ps=="") { MessageBox.Show("IM  must not null"); return; }
			if(checkBox1.Checked) ps = " -s -d  -i cmd /c start "+ps;
			if(ip.Text!="" && user.Text!="" && pass.Text!="") 
				command.psexec(ip.Text,user.Text,pass.Text,ps);
			else if(ip.Text!="" && user.Text!="")
				command.psexec(ip.Text,user.Text,ps);
			else if(ip.Text!="") 
				command.psexec(ip.Text,ps);
			else command.psexec(ps);
		}
		void arp(object sender, EventArgs e)
		{  command.arp();
		}
		void ping(object sender, EventArgs e)
		{  if(ip.Text=="") { MessageBox.Show("ip  must not null"); return; }
			command.ping(ip.Text);
		}
		void share(object sender, EventArgs e)
		{   if(s_delete.Checked && sname.Text=="") { MessageBox.Show("name  must not null");  }
			else if(s_delete.Checked && ip.Text!="") command.dshare(ip.Text,sname.Text);
			else if(s_delete.Checked) command.dshare(sname.Text);
			else if(sname.Text=="" || path.Text=="") { MessageBox.Show("name and path  must not null");  }
			else if(ip.Text!="") command.share(ip.Text,sname.Text,path.Text);
			else command.share(sname.Text,path.Text);
		}
		void startRD(object sender, EventArgs e)
		{   if(ip.Text!="") command.sRD(ip.Text);
			else command.sRD();
		}
		void startRAC(object sender, EventArgs e)
		{  if(ip.Text!="") command.sRAC(ip.Text);
			else command.sRAC();
		}
		void shutdown(object sender, EventArgs e)
		{  if(!rshutdown.Checked && !rrestart.Checked) { MessageBox.Show("Please choose shutdown type"); return;}
			if(!box("Are you sure?","Shutdown"))  return;
		   if(rtime.Checked)
			{ if(ip.Text!="")
				{  if(rshutdown.Checked)  command.shutdownt(ip.Text,"s",time.Text);
				   else command.shutdownt(ip.Text,"r",time.Text);
				}
			 else
			    {  if(rshutdown.Checked)  command.shutdownt("s",time.Text);
				   else command.shutdownt("r",time.Text);	
				}
			}
		   else
		    { if(ip.Text!="")
				{  if(rshutdown.Checked)  command.shutdown(ip.Text,"s");
				   else command.shutdown(ip.Text,"r");
				}
			 else
			    {  if(rshutdown.Checked)  command.shutdown("s");
				   else command.shutdown("r");	
				}
		    }
		}
	}
}