/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 13-Oct-17
 * Time: 15:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Calculate
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class Calculate : UserControl
	{
		System.Collections.ArrayList list = new System.Collections.ArrayList();
		public Calculate()
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
			list.Add(stringcal1);
			list.Add(stringoperator1);
		}
		void menuselect(object obj){
			hideallmenu();
			CalculateInterface.menuinterface sc;
			int myindex = list.IndexOf(obj);
			sc = (CalculateInterface.menuinterface)list[myindex];
			sc.Show();
		}
		void hideallmenu(){
			CalculateInterface.menuinterface sc;
			for(int i = 0; i< list.Count; i++)
			{  sc = (CalculateInterface.menuinterface)list[i];
			   sc.Hide();
			}
		}
		void StringcalbuttonClick(object sender, EventArgs e)
		{
			menuselect(stringcal1);
		}
		void StringoperatorbuttonClick(object sender, EventArgs e)
		{
			menuselect(stringoperator1);
		}
	}
}