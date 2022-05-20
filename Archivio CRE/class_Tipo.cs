using System;
using System.Collections.Generic;
using System.Linq;

namespace Archivio_CRE
{
    public class Tipo : IDisposable
    {
        #region static fields
        private static int nToday;
        private List<string> eleNomi = new List<string>();
        private List<string> codes = new List<string>();
        #endregion

        #region attributes
        private string code;
        private string nome;
        private string des;
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
                if (String.IsNullOrEmpty(value)) throw new Exception("Il nome del tipo di attività non può essere vuoto");
                if (eleNomi.Contains(nome)) eleNomi.Remove(nome);
                if (eleNomi.Contains(value)) throw new Exception("Hai già inserito questo tipo di attività");
                eleNomi.Add(value);
                nome = value;
            }
        }
        public string Descrizione
        {
            get => des;
            set
            {
                des = value;
            }
        }
        #endregion

        #region constructors
        public Tipo()
        {

        }

        public Tipo(string n, string d)
        {

            do
            {
                if (codes.Contains($"TIP{DateTime.Today.ToString("ddMMMyy").ToUpper()}{nToday.ToString("000")}"))
                    nToday += 1;
                else
                    Code = $"TIP{DateTime.Today.ToString("ddMMMyy").ToUpper()}{nToday.ToString("000")}";
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

            Descrizione = d;
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
        ~Tipo()
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
