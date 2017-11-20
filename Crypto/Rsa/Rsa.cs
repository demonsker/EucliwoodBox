/*
 * Created by SharpDevelop.
 * User: Eucliwood
 * Date: 15-Oct-17
 * Time: 22:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace Rsa
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class Rsa : UserControl
	{
		public Rsa()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void setprivatekeyval(string val){
			privatekeyval.Text = val;
		}
		void setpublickeyval(string val){
			publickeyval.Text = val;
		}
		void setciphertextval(string val){
			ciphertextval.Text = val;
		}
		void setplaintextval(string val){
			plaintextval.Text = val;
		}
		string getprivatekeyval(){
			return privatekeybox.Text;
		}
		string getpublickeyval(){
			return publickeybox.Text;
		}
		string getplaintext(){
			return plaintextbox.Text;
		}
		string getciphertext(){
			return ciphertextbox.Text;
		}
		
		public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
    	{
        	try
        	{
           	 	byte[] encryptedData;

            	using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            	{
                	RSA.ImportParameters(RSAKeyInfo);
                	encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
            	}
            	return encryptedData;
        	}
        	catch (CryptographicException e)
        	{
            	Console.WriteLine(e.Message);

            	return null;
        	}
    	}
		 public byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
    	{
        	try
        	{
            	byte[] decryptedData;
            
            	using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            	{
                	RSA.ImportParameters(RSAKeyInfo);
                	decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
            	}
             	return decryptedData;
        	}
         	catch (CryptographicException e)
        	{
            	MessageBox.Show(e.ToString());

            	return null;
        	}
    	}
		void GenkeybuttonClick(object sender, EventArgs e)
		{
			 using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            { 
			 	string pk = RSA.ToXmlString(true);
			 	string puk = RSA.ToXmlString(false);
			 	setprivatekeyval(pk);
			 	setpublickeyval(puk);
            }
		}
		void EncryptbuttonClick(object sender, EventArgs e)
		{
			UnicodeEncoding ByteConverter = new UnicodeEncoding();
			string pukstr = getpublickeyval();
			string plaintext = getplaintext();
			byte[] dataToEncrypt = ByteConverter.GetBytes(plaintext);
			byte[] encryptedData;
			using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
			{				
				RSA.FromXmlString(pukstr);
				encryptedData = RSAEncrypt(dataToEncrypt,RSA.ExportParameters(false) , false);
			}
			setciphertextval(Convert.ToBase64String(encryptedData));
		}
		void DecryptbuttonClick(object sender, EventArgs e)
		{
			UnicodeEncoding ByteConverter = new UnicodeEncoding();
			string pk = getprivatekeyval();
			string ciphertext = getciphertext();
			byte[] dataToDecrypt = Convert.FromBase64String(ciphertext);
			byte[] decryptedData;
			using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
			{				
				RSA.FromXmlString(pk);
				decryptedData = RSADecrypt(dataToDecrypt,RSA.ExportParameters(true) , false);
			}
			setplaintextval(ByteConverter.GetString(decryptedData));
		}
		
	}
}