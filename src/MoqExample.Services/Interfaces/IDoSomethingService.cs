using MoqExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqExample.Services.Interfaces
{
    public interface IDoSomethingService
    {
        bool Do(string something);
    }
}
