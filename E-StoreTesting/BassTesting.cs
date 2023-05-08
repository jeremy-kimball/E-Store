using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Store;
namespace E_StoreTesting
{
    public class BassTesting
    {
        [Fact]
        public void Bass_Constructor_CreatesBassObject()
        {
            Bass Bass1 = new Bass("Fender", 5, "EMG");

            Assert.Equal("Fender", Bass1.Brand);
            Assert.Equal(5, Bass1.NumStrings);
            Assert.Equal("EMG", Bass1.PickupType);
        }
    }
}
