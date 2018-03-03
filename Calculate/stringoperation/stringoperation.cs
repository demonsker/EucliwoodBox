/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 04-Mar-18
 * Time: 00:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace stringoperation
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class Stringoperator : UserControl
	{
		public Stringoperator()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void setString(string message) { stringbox.Text = message; }
		void setIndex(int index) { indexval.Text = index.ToString(); }
		string getString(){ return stringbox.Text; }
		string getOriginal(){ return originalbox.Text; }
		string getNewText(){ return newtextbox.Text; }
		string getAfterText(){ return aftertextbox.Text; }
		string getInsertText(){ return insertbox.Text; }
		string getSearchText(){ return searchbox.Text; }
		
		void DelspacebuttonClick(object sender, EventArgs e)
		{
			string message = getString();

			for(int i = 0; i < message.Length; i++)
			{
				if(message[i] == ' ')
				{
					message = message.Remove(i--,1);
				}
			}
				
			setString(message);
		}
		void InsteadbuttonClick(object sender, EventArgs e)
		{
			String message = getString();
			String original = getOriginal();
			String newText = getNewText();

			message = message.Replace(original, newText);
			
			setString(message);
		}
		void InsertbuttonClick(object sender, EventArgs e)
		{
			String message = getString();
			String afterText = getAfterText();
			String insertText = getInsertText();
			
			int index = message.IndexOf(afterText) + 1;
			
			message = message.Replace(afterText, afterText+insertText);
			
			setString(message);			
		}
		void GetindexbuttonClick(object sender, EventArgs e)
		{
			String message = getString();
			String searchText = getSearchText();
			
			int index = message.IndexOf(searchText);
			setIndex(index);
		}
		void AddnumberbuttonClick(object sender, EventArgs e)
		{
			String message = getString();
			int head = 1;
			
			for(int i = 0; i < message.Length; i++)
			{
				if(message[i] == '\r' && message[i+1] == '\n')
				{
					i += 2;
					message = message.Insert(i, head+".");
					head++;
					i += 2;
				}				
				else if(i == 0)
				{		
					message = message.Insert(i, head+".");
					head++;
					i += 2;
				}
				else if( message[i] == '\n' || message[i] == '\r')
				{
					i++;
					message = message.Insert(i, head+".");
					head++;
					i += 2;
				}
			}
			
			setString(message);	
		}
		void DelnewlinebuttonClick(object sender, EventArgs e)
		{
			String message = getString();
			message = message.Replace('\r', ' ');
			message = message.Replace('\n', ' ');
			setString(message);
		}
		
	}
}