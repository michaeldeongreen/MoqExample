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
            //pass any string and always return true, we don't care about this service
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
            //pass any string and always return true, we don't care about this service
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
