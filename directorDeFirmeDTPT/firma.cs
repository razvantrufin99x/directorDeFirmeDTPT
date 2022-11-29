using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace directorDeFirmeDTPT
{
    public class firma
    {
        public string denumire;
        public string adresa;
        public string domeniul;
        public string subdomeniul;
        public string telefon;
        public string email;
        public string id;
        public string categoria;

        public firma() { }
        public firma(string d, string a, string _d, string s, string t, string e, string i, string c) {
            denumire = d;
            adresa = a;
            domeniul = _d;
            subdomeniul = s;
            telefon = t;
            email = e;
            id = i;
            categoria = c;

        }
    }
}
