using System;
using System.Collections.Generic;
using System.Text;

namespace rumahsakit
{
    class user
    {
        public string nama;
        public string nomorID;
        private string nomorHP;
        protected string riwayatPasien;
        internal string bangsal;
                
        // abstactr
        public string getNumber()
        {
            return nomorHP;
        }
        public string setNumber()
        {
            nomorHP = nomorhp;
            return nomorHP;
        }
        // property
        public string nomorhp
        {
            get { return nomorHP; }
            set { nomorHP = value; }
        }

    }
}