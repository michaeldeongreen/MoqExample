using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using FluentAssertions;
using MoqExample.Services.Interfaces;
using MoqExample.Services;
using MoqExample.Models;

namespace MoqExample.Unit.Tests
{
    [TestFixture]
    public class CreditParserServiceTests
    {
        [Test]
        public void Can_Get_Name_Test()
        {
            //mock DoSomethingService
            var doSomethingServiceMock = new Mock<IDoSomethingService>();
            //using Moq, 1) pass any string to Do Method and 2) always return true, we don't care about this service
            //because we have already Unit Tested this service and we want to focus on the CreditParserService
            doSomethingServiceMock.Setup(d => d.Do(It.IsAny<string>())).Returns(true);

            //given
            string xml = "Michael D. Green, 666-77-8888, do"; //test xml string
            //when
            ICreditParserService creditParserService = new CreditParserService(doSomethingServiceMock.Object); //pass the mocked object
            //then
            CreditReport report = creditParserService.Parse(xml);
            report.Name.Should().Be("Michael D. Green");
        }

        [Test]
        public void Can_Get_SSN_Test()
        {
            //mock DoSomethingService
            var doSomethingServiceMock = new Mock<IDoSomethingService>();
            //using Moq, 1) pass any string to Do Method and 2) always return true, we don't care about this service
            //because we have already Unit Tested this service and we want to focus on the CreditParserService
            doSomethingServiceMock.Setup(d => d.Do(It.IsAny<string>())).Returns(true);

            //given
            string xml = "Michael D. Green,666-77-8888, do"; //test xml string
            //when
            ICreditParserService creditParserService = new CreditParserService(doSomethingServiceMock.Object); //pass the mocked object
            //then
            CreditReport report = creditParserService.Parse(xml);
            report.SSN.Should().Be("666-77-8888");
        }
    }
}
