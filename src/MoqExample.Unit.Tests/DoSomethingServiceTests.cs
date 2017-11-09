using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using MoqExample.Services;

namespace MoqExample.Unit.Tests
{
    [TestFixture]
    public class DoSomethingServiceTests
    {
        [Test]
        public void Do_Is_True_Test()
        {
            //given
            string value = "do";
            //when
            DoSomethingService service = new DoSomethingService();
            bool result = service.Do(value);
            //then
            result.Should().BeTrue();
        }

        [Test]
        public void Do_Is_False_Test()
        {
            //given
            string value = "dont";
            //when
            DoSomethingService service = new DoSomethingService();
            bool result = service.Do(value);
            //then
            result.Should().BeFalse();
        }
    }
}
