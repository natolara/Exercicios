using System;
using System.Collections.Generic;
using System.Text;

namespace ExrComposicaoEnumeracao.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Emal { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string emal, DateTime birthDate)
        {
            Name = name;
            Emal = emal;
            BirthDate = birthDate;
        }
    }
}
