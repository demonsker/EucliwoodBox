/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 13-Oct-17
 * Time: 01:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Portcheck
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class Portcheck : UserControl
	{
		public Portcheck()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		string getIP(){
			return ipbox.Text;
		}
		string getPort(){
			return portbox.Text;
		}
		void setStatus(string status){
			statusval.Text = status;
		}
		void connect(String ip,int port)
		{
			TcpClient tcpClient = new TcpClient();
			setStatus("Please Wait...");
			try 
			{
        		tcpClient.Connect(ip,port);
        		setStatus("Port Opened!");
   			} 
			catch (Exception) 
			{
				setStatus("Port Closed!");
    		}
		}
		void CheckbuttonClick(object sender, EventArgs e)
		{
			string ip = getIP();
			int port = Int32.Parse(getPort());
			connect(ip,port);
		}
	}
}