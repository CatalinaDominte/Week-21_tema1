﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    interface IScalarRepo
    {
        void Scalar(string command);
    }
}