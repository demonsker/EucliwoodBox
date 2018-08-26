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
using System.Text.RegularExpressions;

namespace stringoperation
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class Stringoperator : UserControl
	{
        #region Constructor

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

        #endregion

        #region Property

        void setString(string message) { stringbox.Text = message; }

		void setIndex(int index) { indexval.Text = index.ToString(); }

		string getString(){ return stringbox.Text; }
		
		string getOriginal()
		{						
			if(newlineoriginalcheck.Checked)
				return System.Environment.NewLine;
			return originalbox.Text;
		}

		string getNewText()
		{ 
			if(newlinenewtextcheck.Checked)
				return System.Environment.NewLine;
			return newtextbox.Text;
		}

		string getAfterText()
		{
			if(newlineoriginalcheck.Checked)
				return System.Environment.NewLine;
			return aftertextbox.Text;
		}

		string getInsertText()
		{ 
			if(newlinenewtextcheck.Checked)
				return System.Environment.NewLine;	
			return insertbox.Text;
		}

		string getSearchText(){ return searchbox.Text; }
		
		int getNumberCharNewLine(){ return Int32.Parse(numberofcharacternewline.Text);}

        #endregion

        #region Event Functions

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

		void GetnumberbuttonClick(object sender, EventArgs e)
		{
			String message = getString();
			Regex r = new Regex("(-)?[0-9]+(\\.[0-9]+)?");
			MatchCollection mc = r.Matches(message);
			message = "";
			
			for(int i = 0; i< mc.Count ; i++)
			{
				message += mc[i]+" ";
			}
			setString(message);
		}

		void AddnewlinebuttonClick(object sender, EventArgs e)
		{
			String message = getString();
			int num = getNumberCharNewLine();
			
            if(num <= 0)
            {
                return;
            }

			for(int i = num; i < message.Length; i+=(num+2))
				message = message.Insert(i, System.Environment.NewLine);
			
			setString(message);
		}

		void AddspacebuttonClick(object sender, EventArgs e)
		{
			String message = getString();
			int num = getNumberCharNewLine();

            if (num <= 0)
            {
                return;
            }

            for (int i = num; i < message.Length; i+=(num+1))
				message = message.Insert(i, " ");
			
			setString(message);
		}

        #endregion
    }
}