/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 13-Oct-17
 * Time: 00:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Network
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class Network : UserControl
	{
		System.Collections.ArrayList list = new System.Collections.ArrayList();
		public Network()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			collectobj();
			hideallmenu();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void collectobj(){
			list.Add(portcheck1);
			list.Add(psc1);
		}
		void menuselect(object obj){
			hideallmenu();
			NetworkInterface.menuinterface sc;
			int myindex = list.IndexOf(obj);
			sc = (NetworkInterface.menuinterface)list[myindex];
			sc.Show();
		}
		void hideallmenu(){
			NetworkInterface.menuinterface sc;
			for(int i = 0; i< list.Count; i++)
			{  sc = (NetworkInterface.menuinterface)list[i];
			   sc.Hide();
			}
		}
		void PortcheckbuttonClick(object sender, EventArgs e)
		{
			menuselect(portcheck1);
		}
		void PSCbuttonClick(object sender, EventArgs e)
		{
			menuselect(psc1);
		}
	}
}