using System.Data;
using PizzaClassLibrary;
using PizzaClassLibrary.Models;
using PizzaClassLibrary.Services;



namespace xUnitTestDemo
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(PizzaService.GetAll().Count, 3);

        }
        [Fact]
        public void TestAddPizza()
        {
            Pizza p = new Pizza { Name = "Mexican Blast", Size = PizzaSize.Medium, IsGlutenFree = true };
            PizzaService.Add(p);
            Pizza verify = PizzaService.Get(3);



            Assert.Equal(3, PizzaService.GetAll().Count);
            Assert.Equal(p.Id, verify.Id);
        }
        [Fact]
        public void TestDelete()
        {
            PizzaService.Delete(3);
            Assert.Equal(2, PizzaService.GetAll().Count);
        }
        [Fact]
        public void TestUpdate()
        {
            Pizza p = new Pizza { Id = 2, Name = "Italian Magic", Size = PizzaSize.Medium, IsGlutenFree = true };
            PizzaService.Update(p);
            Pizza verify = PizzaService.Get(2);
            Assert.Equal(verify.Name, "Italian Magic");
        }
    }
}



