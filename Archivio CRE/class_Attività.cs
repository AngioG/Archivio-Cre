using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Archivio_CRE
{
    public class Attività : IDisposable
    {
        #region static fields
        private static int nToday;
        private static List<string> codes = new List<string>();
        #endregion
        #region attributes
        private string code;
        private string nome;
        private string des;
        private List<string> età = new List<string>();
        private Luogo luogo;
        private Tipo tipo;
        private List<(int, string)> materiale = new List<(int, string)>();
        private bool disposedValue;
        #endregion
        #region properties

        [DefaultValue("Codice")]
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
        public List<string> Età
        {
            get => età;
            set
            {
                foreach (var s in value)
                    if (s != "Prima Elementare" && s != "Seconda Elementare" && s != "Terza Elementare" && s != "Quarta Elementare" && s != "Quinta Elementare" && s != "Prima Media" && s != "Seconda Media" && s != "Terza Media")
                        throw new Exception("Un'età non è corretta");

                età.Clear();
                età.AddRange(value);
            }
        }
        public Luogo Luogo
        {
            get => luogo;
            set
            {
                if (value == null) throw new Exception("Luogo nullo");
                luogo = value;
            }
        }
        public Tipo Tipo
        {
            get => tipo;
            set
            {
                if (value == null) throw new Exception("Tipo di attività nullo");
                tipo = value;
            }
        }
        public List<(int, string)> Materiale
        {
            get => materiale;
            set
            {
                foreach (var o in value)
                {
                    if (o.Item1 < 1) throw new Exception("Un materiale ha quantità minore o uguale a 0");
                    if (string.IsNullOrEmpty(o.Item2)) throw new Exception("Un materiale ha nome vuoto");

                    materiale.Clear();
                    materiale.AddRange(value);
                }
            }
        }
        #endregion
        #region constructors
        public Attività()
        {
                
        }

        public Attività(string n, string d, List<string> e, Luogo l, Tipo t, List<(int, string)> m)
        {

            do
            {
                if (codes.Contains($"ATT{DateTime.Today.ToString("ddMMMyy").ToUpper()}{nToday.ToString("000")}"))
                    nToday += 1;
                else
                    this.Code = $"ATT{DateTime.Today.ToString("ddMMMyy").ToUpper()}{nToday.ToString("000")}";
            } while (code == null);


            Nome = n;
            Descrizione = d;
            Età = e;
            Luogo = l;
            Tipo = t;
            Materiale = m;

        }
        #endregion
        #region Methods
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

                codes.Remove(this.Code);
                disposedValue = true;
            }
        }

        // TODO: eseguire l'override del finalizzatore solo se 'Dispose(bool disposing)' contiene codice per liberare risorse non gestite
        ~Attività()
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
