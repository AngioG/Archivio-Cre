using System;
using System.Collections.Generic;


namespace Archivio_CRE
{
    public class Luogo : IDisposable
    {
        #region static fields
        private static int nToday;
        private static List<string> eleNomi = new List<string>();
        private static List<string> codes = new List<string>();
        #endregion

        #region attributes
        private string code;
        private string nome;
        private bool aperto;
        private DateTime ultima;
        private bool disposedValue;
        #endregion

        #region properties
        public string Code
        {
            get => code;
            set
            {
                if (value == code)
                    return;

                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("Code is empty");
                if (codes.Contains(value))
                    throw new Exception("Code already used");

                string tmp = code;
                code = value;
                if (codes.Contains(tmp))
                    codes.Remove(tmp);

                codes.Add(code);
            }
        }
        public string Nome
        {
            get => nome;
            set
            {
                if (String.IsNullOrEmpty(value)) throw new Exception("Il nome del luogo non può essere vuoto");
                if (eleNomi.Contains(nome)) eleNomi.Remove(Nome);
                if (eleNomi.Contains(value)) throw new Exception("Hai già inserito questo luogo");
                eleNomi.Add(value);
                UltimaModifica = DateTime.Today;
                nome = value;
            }
        }
        public string Aperto
        {
            get => aperto ? "Aperto" : "Chiuso";
            set
            {
                switch (value)
                {
                    case "Aperto":
                    case "aperto":
                        {
                            aperto = true;
                            break;
                        }
                    case "Chiuso":
                    case "chiuso":
                        {
                            aperto = false;
                            break;
                        }
                    default:
                        {
                            throw new Exception("La tipologia del luogo deve essere o aperto o chiuso");
                        }
                }
                UltimaModifica = DateTime.Today;
            }
        }

        public DateTime UltimaModifica
        {
            get => ultima;
            private set
            {
                ultima = value;
            }
        }
        #endregion

        #region constructors
        public Luogo() : base()
        {

        }

        public Luogo(string n, string a)
        {

            do
            {
                if (codes.Contains($"LUO{DateTime.Today.ToString("ddMMMyy").ToUpper()}{nToday.ToString("000")}"))
                    nToday += 1;
                else
                    Code = $"LUO{DateTime.Today.ToString("ddMMMyy").ToUpper()}{nToday.ToString("000")}";
            } while (code == null);

            try
            {
                Nome = n;
            }
            catch(Exception ex)
            {
                codes.Remove(this.Code);
                throw ex;
            }
                Aperto = a;

        }
        #endregion

        public override string ToString()
        {
            return Nome;
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
                codes.Remove(this.Code);
                disposedValue = true;
            }
        }

        // TODO: eseguire l'override del finalizzatore solo se 'Dispose(bool disposing)' contiene codice per liberare risorse non gestite
        ~Luogo()
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
    }
}
