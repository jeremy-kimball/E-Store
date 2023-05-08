using E_Store;

namespace E_StoreTesting
{
    public class InventoryTesting
    {

        [Fact]
        public void Inventory_Constructor_CreatesInventoryObject()
        {
            Inventory eStore = new Inventory();

            Assert.Equal(new List<Guitar>(), eStore.Guitars);
            Assert.Equal(new List<Bass>(), eStore.Basses);
        }
    }
}