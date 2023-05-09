using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSimplesT5
{
    internal class contato
    {

        private string primeiroNome;
        private string sobrenome;
        private string telefone;

        // PROPRIEDADE da classe contato
     
        public string PrimeiroNome
        {
            get { return primeiroNome; }
            set { primeiroNome = value; }
        }
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set 
            {
                if (value.Length == 11)
                {
                    telefone = value;
                   
                }
                else
                {
                    telefone = "00-00000-0000";
                }
            }
        }
        //contrutor da classe
        public contato()
        {
            PrimeiroNome = "João";
            Sobrenome = "Da Silva";
            Telefone = "11-99998-8776";
        }
        // Sobrecarga de método

        public contato(string primeiroNome, string sobrenome, string telefone)
        {

            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Telefone = telefone;

        }
        //sobreescrita do método ToString
        public override string ToString()
        {
            // melhor utilizar uma string.empty invés de "".
            string saida = String.Empty;
            saida += String.Format("{0}, {1}", PrimeiroNome, Sobrenome);
            saida += String.Format("{0}-{1}-{2}", 
                telefone.Substring(0,2), 
                telefone.Substring(2, 5), 
                telefone.Substring(7, 4));
            return saida;

        }
    }
    
}
