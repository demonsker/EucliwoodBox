/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 14-Oct-17
 * Time: 00:49
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

namespace Md5
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class Md5 : UserControl
	{
		public Md5()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		  void setCipherbox(string cipher)
        {
            ciphertextbox.Text = cipher;
        }
        string getInput()
        {
            return inputbox.Text;
        }
        public string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
		void HashbuttonClick(object sender, EventArgs e)
		{
			 string input = getInput();
            string cipher;
            using (MD5 md5Hash = MD5.Create())
            {
                cipher = GetMd5Hash(md5Hash, input);
            }
            setCipherbox(cipher);
		}
	}
}