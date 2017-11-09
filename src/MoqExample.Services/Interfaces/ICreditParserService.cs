﻿using MoqExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqExample.Services.Interfaces
{
    public interface ICreditParserService
    {
        CreditReport Parse(string xml);
    }
}
