using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Store;

namespace E_StoreTesting
{
    public class GuitarTesting
    {
         [Fact]
        public void Guitar_Constructor_CreatesGuitarObject()
        {
            var Guitar1 = new Guitar("Schecter", 6, "Humbucker");

            Assert.Equal("Schecter", Guitar1.Brand);
            Assert.Equal(6, Guitar1.NumStrings);
            Assert.Equal("Humbucker", Guitar1.PickupType);
        }
    }
}
