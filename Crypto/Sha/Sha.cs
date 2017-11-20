/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 12-Oct-17
 * Time: 23:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Security.Cryptography;

namespace Sha
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class Sha : UserControl
	{
		public Sha()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void setCipherbox(string cipher){
			cipherbox.Text = cipher;
		}
		string getInput(){
			return inputbox.Text;
		}
		public string getHashSha256(string text)
        {
        	byte[] bytes = Encoding.UTF8.GetBytes(text);
        	SHA256Managed hashstring = new SHA256Managed();
        	byte[] hash = hashstring.ComputeHash(bytes);
        	string hashString = string.Empty;
        	foreach (byte x in hash)
        	{
            	hashString += String.Format("{0:x2}", x);
        	}
        	return hashString;
        }
		public string getHashSha512(string text)
        {
        	byte[] bytes = Encoding.UTF8.GetBytes(text);
        	SHA512Managed hashstring = new SHA512Managed();
        	byte[] hash = hashstring.ComputeHash(bytes);
        	string hashString = string.Empty;
        	foreach (byte x in hash)
        	{
            	hashString += String.Format("{0:x2}", x);
        	}
        	return hashString;
       	 }
		void HashbuttonClick(object sender, EventArgs e)
		{
			string input = getInput();
			string cipher;cipher = getHashSha256(input);
			if(sha256ratio.Checked)
				cipher = getHashSha256(input);
			else
				cipher = getHashSha512(input);
			setCipherbox(cipher);
		}
	}
}