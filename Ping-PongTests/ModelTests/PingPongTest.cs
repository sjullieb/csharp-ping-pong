using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;

namespace Game.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void Convert_NumberIsNotDivisibleBy3AndBy5_Input()
    {
      PingPong pingPongTest = new PingPong();
      Assert.AreEqual("2", pingPongTest.Convert(2));
    }
  }
}
