using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Assignment_2.Models;
using Xunit;

namespace Assignment_2
{
    public class testclass{

        [Fact]
        public void PassingAddTest()
        {
            Assert.Equal(4, Pages.DeliveryPerson.DetailsModel.Add(3,2));
        }
    }
}
