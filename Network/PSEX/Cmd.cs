/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 11/2/2560
 * Time: 19:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;

namespace PSEX
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Cmd
	{   public void run(string command){
			command = "start /k "+command;
			System.Diagnostics.Process.Start("CMD.exe",command);
		}
		public void sRD(){
			string command = "start /k "+@"reg add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server"" /v fDenyTSConnections /t REG_DWORD /d 0 /f";
			System.Diagnostics.Process.Start("CMD.exe",command);
		}
		public void sRD(string ip){
			psexec(ip,"cmd start /k "+@"reg add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server"" /v fDenyTSConnections /t REG_DWORD /d 0 /f");
		}
		public void sRAC(){
			string command = "start /k "+@"reg add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server"" /v fAllowToGetHelp /t REG_DWORD /d 1 /f";
			System.Diagnostics.Process.Start("CMD.exe",command);
		}
		public void sRAC(string ip){
			psexec(ip,"cmd start /k "+@"reg add ""HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server"" /v fAllowToGetHelp /t REG_DWORD /d 1 /f");
		}
		public void netuse(string ip){
			string command = "start /k net use \\\\"+ip;
			System.Diagnostics.Process.Start("CMD.exe",command);
		}
		public void netuse(string ip,string user){
			string command = "start /k net use \\\\"+ip+" /user:"+user;
			System.Diagnostics.Process.Start("CMD.exe",command);
		}
		public void tasklist(){
			string command = "start /k tasklist | sort";
			System.Diagnostics.Process.Start("CMD.exe",command);
		}
		public void tasklist(string ip){
			string command = "start /k tasklist /s "+ip+" | sort ";
			System.Diagnostics.Process.Start("CMD.exe",command);
		}
		public void tasklist(string ip,string user){
			string command = "start /k tasklist /s "+ip+" /u "+user+" | sort ";
			System.Diagnostics.Process.Start("CMD.exe",command);
		}
		public void tasklist(string ip,string user,string pass){
			string command = "start /k tasklist /s "+ip+" /u "+user+" /p "+pass+" | sort ";
			System.Diagnostics.Process.Start("CMD.exe",command);
		}
		public void taskkillp(string pid){
			string command = "start /k taskkill /F /pid "+pid;
			System.Diagnostics.Process.Start("CMD.exe",command);
		}
		public void taskkilln(string psname){
			string command = "start /k taskkill /F /IM "+psname;
			System.Diagnostics.Process.Start("CMD.exe",command);
		}
		public void taskkillp(string ip,string pid){
			string command = "start /k taskkill /F /s "+ip+" /pid "+pid;
			System.Diagnostics.Process.Start("CMD.exe",command);
		}
		public void taskkilln(string ip,string psname){
			string command = "start /k taskkill /F /s "+ip+" /IM "+psname;
			System.Diagnostics.Process.Start("CMD.exe",command);
		}
		public void taskkillp(string ip,string user,string pid){
			string command = "start /k taskkill /F /s "+ip+" /u "+user+" /pid "+pid;
			System.Diagnostics.Process.Start("CMD.exe",command);
		}
		public void taskkilln(string ip,string user,string psname){
			string command = "start /k taskkill /F /s "+ip+" /u "+user+" /IM "+psname;
			System.Diagnostics.Process.Start("CMD.exe",command);
		}
		public void taskkillp(string ip,string user,string pass,string pid){
			string command = "start /k taskkill /F /s "+ip+" /u "+user+" /p "+pass+" /pid "+pid;
			System.Diagnostics.Process.Start("CMD.exe",command);
		}
		public void taskkilln(string ip,string user,string pass,string psname){
			string command = "start /k taskkill /F /s "+ip+" /u "+user+" /p "+pass+" /IM "+psname;
			System.Diagnostics.Process.Start("CMD.exe",command);
		}
		public void psexec(string psname){
			string command = psname;
			System.Diagnostics.Process.Start(@"PS\psexec.exe",command);
		}
		public void psexec(string ip,string psname){
			string command = "\\\\"+ip+" "+psname;
			System.Diagnostics.Process.Start(@"PS\psexec.exe",command);
		}
		public void psexec(string ip,string user,string psname){
			string command = "\\\\"+ip+" /u "+user+" "+psname;
			System.Diagnostics.Process.Start(@"PS\psexec.exe",command);
		}
		public void psexec(string ip,string user,string pass,string psname){
			string command = "\\\\"+ip+" /u "+user+" /p "+pass+" "+psname;
			System.Diagnostics.Process.Start(@"PS\psexec.exe",command);
		}
		public void arp(){
			string command = "start /k arp -a";
			System.Diagnostics.Process.Start("cmd.exe",command);
		}
		public void ping(string ip){
			string command = "start /k ping -a "+ip+" -4 ";
			System.Diagnostics.Process.Start("cmd.exe",command);
		}
		public void share(string name,string path){
			string command = "start /k net share "+name+"="+path+" /grant:everyone,full";
			System.Diagnostics.Process.Start("cmd.exe",command);
		}
		public void share(string ip,string name,string path){
			string command = "cmd start /k net share "+name+"="+path+" /grant:everyone,full";
			psexec(ip,command);
		}
		public void dshare(string name){
			string command = "start /k net share "+name+" /delete";
			System.Diagnostics.Process.Start("cmd.exe",command);
		}
		public void dshare(string ip,string name){
			string command = "cmd start /k net share "+name+" /delete";
			psexec(ip,command);
		}
		public void shutdown(string para){
			string command = "start /k shutdown /f "+" -"+para;
			System.Diagnostics.Process.Start("cmd.exe",command);
		}
		public void shutdown(string ip,string para){
			string command = "start /k shutdown /f /m "+ip+" -"+para;
			System.Diagnostics.Process.Start("cmd.exe",command);
		}
		public void shutdownt(string para,string time){
			string command = "start /k shutdown /f /t "+time+" -"+para;
			System.Diagnostics.Process.Start("cmd.exe",command);
		}
		public void shutdownt(string ip,string para,string time){
			string command = "start /k shutdown /f /t "+time+" /m "+ip+" -"+para;
			System.Diagnostics.Process.Start("cmd.exe",command);
		}
	}
}
