﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Library.Security
{
    public interface IManager
    {
        Boolean Authorize(String Actor, String Context, String Action);
    }
}