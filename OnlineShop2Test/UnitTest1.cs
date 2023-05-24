using NUnit.Framework;
using OnlineStore2.Controllers;
using OnlineStore2.Data.Repositories;
using OnlineStore2.Models;
namespace OnlineShop2Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var db = new NavEcommerceDBfirstEntities_Model2OnlineStore2();
            var MotorcycleRepository = new MotorcycleRepository(db);
            var one = MotorcycleRepository.GetMotorcycles();
            var two = MotorcycleRepository.GetMotorcyclesIncludeBrandsCategories();
            CollectionAssert.AreEquivalent((System.Collections.ICollection)one, (System.Collections.ICollection)two);
        }
    }
}