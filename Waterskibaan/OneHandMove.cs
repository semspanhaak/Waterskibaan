﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class OneHandMove : IMoves
    {
        public int Move()
        {
            var R = new Random();
            int succeed = R.Next(1, 3);

            // If succeed
            if (succeed == 1)
                return 7;
            //failed
            return 0;
        }
    }
}