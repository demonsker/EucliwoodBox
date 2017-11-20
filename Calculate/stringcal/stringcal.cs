/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 11-Oct-17
 * Time: 18:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace stringcal
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class Stringcal : UserControl
	{
		public Stringcal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void setSum(double sum){ sumvalue.Text = sum.ToString(); }
		void setAmount(int amount){ amoutval.Text = amount.ToString(); }
		void setStringlength(int length) { stringlengthval.Text = length.ToString(); }
		string getString(){ return stringbox.Text; }
		
		public double calculate (string str) {
			double sum = 0;
			Regex r = new Regex("(-)?[0-9]+(\\.[0-9]+)?");
			MatchCollection mc = r.Matches(str);
			double[] floatval = new double[mc.Count];
			for(int i = 0; i< mc.Count ; i++)
			{
				floatval[i] =  Double.Parse(mc[i].ToString());
				sum += floatval[i];
			}
			setAmount(mc.Count);
			return sum;
			
		}
		public void CalbuttonClick(object sender, EventArgs e)
		{
			string str = getString();
			double sum = calculate(str);
			setSum(sum);
			setStringlength(str.Length);
		}
	}
}