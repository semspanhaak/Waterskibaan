﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class LijnenVoorraad
    {
        private Queue<Lijn> _lijnen;

        public LijnenVoorraad()
        {
            _lijnen = new Queue<Lijn>();
        }

        public void LijnToevoegenAanRij(Lijn lijn)
        {
            _lijnen.Enqueue(lijn);
        }

        public Lijn VerwijderEersteLijn()
        {
            if (_lijnen.Count == 0)
            {
                return null;
            }
            else
            {
                return _lijnen.Dequeue();
            }
        }

        public int GetAantalLijnen()
        {
            return _lijnen.Count;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Lijn item in _lijnen)
            {
                result += "item | ";
            }
            return result;
        }
    }
}
