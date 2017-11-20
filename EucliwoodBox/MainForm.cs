/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 11-Oct-17
 * Time: 18:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EucliwoodBox
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		System.Collections.ArrayList list = new System.Collections.ArrayList();
		public MainForm()
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
			list.Add(calculate1);
			list.Add(crypto1);
			list.Add(network1);
		}
		void menuselect(object obj){
			hideallmenu();
			Interface.menuinterface sc;
			int myindex = list.IndexOf(obj);
			sc = (Interface.menuinterface)list[myindex];
			sc.Show();
		}
		void hideallmenu(){
			Interface.menuinterface sc;
			for(int i = 0; i< list.Count; i++)
			{  sc = (Interface.menuinterface)list[i];
			   sc.Hide();
			}
		}
		void CalculatemenuClick(object sender, EventArgs e)
		{
			menuselect(calculate1);
		}
		void CryptomenuClick(object sender, EventArgs e)
		{
			menuselect(crypto1);
		}
		void NetworkmenuClick(object sender, EventArgs e)
		{
			menuselect(network1);
		}
		
		
	}
}
