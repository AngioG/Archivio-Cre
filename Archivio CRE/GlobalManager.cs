using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Archivio_CRE
{
    class GlobalConfiguration : IDisposable
    {
        #region attributes
        private List<Luogo> luoghi;
        private List<Tipo> tipi;
        private List<Attività> attività;
        private List<Login> logins;
        private bool open;

        private Login login;
        private bool disposedValue;
        #endregion
        #region properties

        public List<Luogo> EleLuogo { get => luoghi; private set { luoghi = value; } }

        public List<Tipo> EleTipo { get => tipi; private set { tipi = value; } }

        public List<Attività> EleAttivit { get => attività; private set { attività = value; } }

        public List<Login> EleLogin { get => logins; private set { logins = value; } }

        public bool Open { get => open; set { open = value; } }

        [Newtonsoft.Json.JsonIgnore]
        public Login ActiveLogin { get => login; set { login = value; } }
        [Newtonsoft.Json.JsonIgnore]
        public bool CanInsert { get => ActiveLogin.CanInsert; }
        [Newtonsoft.Json.JsonIgnore]
        public bool CanDelete { get => ActiveLogin.CanDelete; }
        [Newtonsoft.Json.JsonIgnore]
        public bool CanUpdate { get => ActiveLogin.CanUpdate; }
        #endregion
        #region contructor
        public GlobalConfiguration()
        {
            if(EleLuogo == null)
                EleLuogo = new List<Luogo>();
            if (EleTipo == null)
                EleTipo = new List<Tipo>();
            if(EleAttivit == null)
                EleAttivit = new List<Attività>();
            if (EleLogin == null)
                EleLogin = new List<Login>();
            //Open = false;
        }
        #endregion
        #region methods
        public bool WriteToFile(string path = "GlobalConfiguration.json")
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
                File.WriteAllText(path, jsonString);

                DateTime date = DateTime.Today.AddDays(-10);
                var dir = Directory.GetParent(path);
                var backups = /*new List<string>*/(Directory.GetFiles(dir.FullName, "*.bak"));

                for (int i = 0; i < backups.Count(); i++)
                {

                    string filename = backups[i].Replace(dir.FullName + "\\", "");
                    filename = filename.Split('_').Last();
                    filename = filename.Replace(".txt", "").Replace(".bak", "");
                    string datetime = date.ToString("yyyyMMdd");
                    if (String.Compare(filename, datetime) < 0)
                    {
                        if (File.Exists(backups[i]))
                        {
                            File.Delete(backups[i]);
                        }
                    }

                }


                return true;
            }
            catch
            {
                return false;
            }

        }

        public static GlobalConfiguration ReadJson(string path = "GlobalConfiguration.json")
        {
            GlobalConfiguration res = null;

            if (!File.Exists(path))
            {
                res = new GlobalConfiguration();
                res.WriteToFile();
            }
            else
            {
                string jsonString = File.ReadAllText(path);
                res = JsonConvert.DeserializeObject<GlobalConfiguration>(jsonString, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
                File.WriteAllText(Directory.GetParent(path).FullName + $"\\backup_{DateTime.Now.ToString("yyyyMMddhhmmss")}.bak", jsonString);
            }
            //Logs.WriteSingleLog("File json letto");
            return res;
        }

        public void Blocca(string path = "GlobalConfiguration.json")
        {
            Open = true;
            string jsonString = JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            File.WriteAllText(path, jsonString);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: eliminare lo stato gestito (oggetti gestiti)
                }

                foreach (var a in EleAttivit)
                    a.Dispose();
                foreach (var t in EleTipo)
                    t.Dispose();
                foreach (var l in EleLuogo)
                    l.Dispose();
                foreach (var l in EleLogin)
                    l.Dispose();
                disposedValue = true;
            }
        }

        ~GlobalConfiguration()
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
