using MoqExample.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using MoqExample.Models;

namespace MoqExample.Services
{

    public class DoSomethingService : IDoSomethingService
    {
        public bool Do(string something)
        {
            if (something == "do")
                return true;
            else
                return false;
         }
    }
}
