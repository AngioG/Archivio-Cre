using System;

using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivio_CRE
{
    public class Login : IDisposable
    {
        #region static fields
        private static List<string> eleNomi = new List<string>();
        #endregion
        #region attributes
        private string nome;
        private string password;
        private bool disposedValue;
        #endregion
        #region properties
        public string Nome
        {
            get { return nome; }
            set
            {
                if (value == nome)
                    return;

                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("Name is empty");
                if (eleNomi.Contains(value))
                    throw new Exception("Name already used");

                string tmp = nome;
                nome = value;
                if (eleNomi.Contains(tmp))
                    eleNomi.Remove(tmp);

                eleNomi.Add(nome);
            }
        }
        public string Password { get { return password; } set {password = value;} }
        public bool CanInsert { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
        #endregion
        #region constructors
        public Login()
        { }
        public Login(string nome, string psw, bool i, bool u, bool d)
        {
            Nome = nome;
            Password = psw;
            CanInsert = i;
            CanUpdate = u;
            CanDelete = d;
        }
        #endregion
        #region methods
        /// <summary>
        /// Funzione copiata da https://www.delftstack.com/it/howto/csharp/encrypt-and-decrypt-a-string-in-csharp/
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string Encrypt(string value)
        {
            try
            {
                string textToEncrypt = value;
                string ToReturn = "";
                string publickey = "Archivio";
                string secretkey = "D3L3ND4C";
                byte[] secretkeyByte = { };
                secretkeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
                byte[] publickeybyte = { };
                publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(textToEncrypt);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    ToReturn = Convert.ToBase64String(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        /// <summary>
        /// Funzione copiata da https://www.delftstack.com/it/howto/csharp/encrypt-and-decrypt-a-string-in-csharp/
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string Decrypt(string value)
        {
            try
            {
                string textToDecrypt = value;
                string ToReturn = "";
                string publickey = "Archivio";
                string secretkey = "D3L3ND4C";
                byte[] privatekeyByte = { };
                privatekeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
                byte[] publickeybyte = { };
                publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateDecryptor(publickeybyte, privatekeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    ToReturn = encoding.GetString(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ae)
            {
                throw new Exception(ae.Message, ae.InnerException);
            }
        }


        public bool PasswordCorrect(string psw)
        {
            if (Decrypt(password) == psw)
                return true;
            return false;
        }

        public void InsertPassword(string nuova)
        {
            if (string.IsNullOrWhiteSpace(Password))
                Password = Encrypt(nuova);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: eliminare lo stato gestito (oggetti gestiti)
                }

                eleNomi.Remove(this.Nome);
                disposedValue = true;
            }
        }

        // TODO: eseguire l'override del finalizzatore solo se 'Dispose(bool disposing)' contiene codice per liberare risorse non gestite
        ~Login()
        {
            // Non modificare questo codice. Inserire il codice di pulizia nel metodo 'Dispose(bool disposing)'
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Non modificare questo codice. Inserire il codice di pulizia nel metodo 'Dispose(bool disposing)'
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
