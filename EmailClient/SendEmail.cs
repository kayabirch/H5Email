using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Globalization;

namespace EmailClient
{
    public partial class SendEmail : Form
    {
        string val;

        public SendEmail(string choosenLang)
        {
            val = choosenLang;
            InitializeComponent();
            
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                //create the email thats going to be sent
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                //when you use Networkcredintials, the mail.from is the one you provide in credentials.
                mail.From = new MailAddress("tmcmercantec@gmail.com");
                mail.To.Add(txRec.Text);
                mail.Subject = txCat.Text;
                mail.Body = txMessage.Text;

                using (Rijndael rijndaelCreater = Rijndael.Create())
                {
                    // encrypt the body message to a byte 
                    byte[] encrypted = EncryptStringToBytes(txMessage.Text, rijndaelCreater.Key, rijndaelCreater.IV);
                    byte[] dataToEncrypt = encrypted;
                    byte[] encryptedData;
                    byte[] decryptedData;

                    using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                    {
                        encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);
                        decryptedData = RSADecrypt(encryptedData, RSA.ExportParameters(true), false);
                    }
                    // Decrypt the byte message to a string after it has been encrypted and decrypted by RSA
                    string DecryptedFromRSAToSymme = DecryptStringFromBytes(decryptedData, rijndaelCreater.Key, rijndaelCreater.IV);


                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("tmcmercantec@gmail.com", "Merc2012");
                    SmtpServer.EnableSsl = true;

                    //send email
                    SmtpServer.Send(mail);
                    //Messagebox to show if its being sent
                    MessageBox.Show("The email is sent !");

                    SendEmail.ActiveForm.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            // Check if arguments are null
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");
            byte[] encrypted;
 
            using (Rijndael rijAlg = Rijndael.Create())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for encryption. 
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write data to stream
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return encrypted;
        }

        static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");

            string plaintext = null;

            using (Rijndael rijAlg = Rijndael.Create())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for decryption. 
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the stream, and put them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }

        static public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    //include public key information in rsa key information
                    RSA.ImportParameters(RSAKeyInfo);

                    //Encrypt the byte array, and specify OAEP (optical asymmetric encryption padding).    
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        static public byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //include private key information to the rsa key information
                    RSA.ImportParameters(RSAKeyInfo);  
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        private void SendEmail_Load(object sender, EventArgs e)
        {
            if (val == "Danish")
            {
                ChangeLanguage("da");
            }
            else
                ChangeLanguage("en");  
        }

        private void ChangeLanguage(string language)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(SendEmail));
                resources.ApplyResources(c, c.Name, new CultureInfo(language));
            }
        }
    }
}
