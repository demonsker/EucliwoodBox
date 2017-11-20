/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 12-Oct-17
 * Time: 00:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Crypto
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class Crypto : UserControl
	{
		System.Collections.ArrayList list = new System.Collections.ArrayList();
		public Crypto()
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
			list.Add(sha1);
			list.Add(md51);
			list.Add(rsa1);
		}
		void menuselect(object obj){
			hideallmenu();
			CryptoInterface.menuinterface sc;
			int myindex = list.IndexOf(obj);
			sc = (CryptoInterface.menuinterface)list[myindex];
			sc.Show();
		}
		void hideallmenu(){
			CryptoInterface.menuinterface sc;
			for(int i = 0; i< list.Count; i++)
			{  sc = (CryptoInterface.menuinterface)list[i];
			   sc.Hide();
			}
		}
		void ShabuttonClick(object sender, EventArgs e)
		{
			menuselect(sha1);
		}
		void Md5buttonClick(object sender, EventArgs e)
		{
			menuselect(md51);
		}
		void Button1Click(object sender, EventArgs e)
		{
			menuselect(rsa1);
		}
	}
}