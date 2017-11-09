using MoqExample.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoqExample.Models;

namespace MoqExample.Services
{
    public class CreditParserService : ICreditParserService
    {
        private IDoSomethingService _doSomethingService;
        public CreditParserService(IDoSomethingService doSomethingService)
        {
            _doSomethingService = doSomethingService;
        }
        public CreditReport Parse(string xml)
        {
            string[] segments;
            segments = xml.Split(',');

            bool value = _doSomethingService.Do(segments[2]);

            return new CreditReport() { Name =segments[0], SSN = segments[1] , Do = value};
        }
    }
}
