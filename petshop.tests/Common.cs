using NUnit.Framework;
using petshop;
namespace Tests
{
    public class Tests
    {
      
        [Test]
        public void Test_Calculator()
        {
            
            petshop.Common.Calculator calc = new petshop.Common.Calculator();
            var result = calc.Sum(4, 5, 6);
            Assert.AreEqual(15,result);
        }
    }
}
