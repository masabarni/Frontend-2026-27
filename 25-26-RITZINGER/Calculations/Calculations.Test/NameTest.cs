using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Test
{
    public class NameTest
    {
        [Fact]
        public void AddGivenland2Returns3()
        {
            //Arange
            var names = new Names();
            //Act
            names.MakeFullName("Kiss", "Pista");
            //Assert
            Assert.Equal("K+P", names.NickName);
        }

        [Fact]
        public void MakeFullName()
        {
            var names = new Names();
            var fullName = names.MakeFullName("Kiss", "Pista");
            Assert.Equal("Kiss Pista", fullName);
        }
    }
}
