﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Produto abstrato (Abstract Product)
    public abstract class DBconnection
    {
        public abstract void Open();
    }
}
