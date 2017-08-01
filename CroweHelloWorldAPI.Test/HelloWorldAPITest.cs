using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CroweHelloWorldAPI;

namespace CroweHelloWorldAPI.Test
{
    [TestClass]
    public class HelloWorldAPITest
    {
        private const string HELLO_WORLD_TEST_MESSAGE = "Hello World";
        [TestMethod]
        public void IsConsoleModeProperlySetWhenCalled()
        {
            HelloWorldApp app = new HelloWorldApp();
            app.SetMode(new ConsoleMode());
            Assert.IsInstanceOfType(app.GetMode(), typeof(ConsoleMode));
        }
        [TestMethod]
        public void IsDatabaseModeProperlySetWhenCalled()
        {
            HelloWorldApp app = new HelloWorldApp();
            app.SetMode(new DatabaseMode());
            Assert.IsInstanceOfType(app.GetMode(), typeof(DatabaseMode));
        }
        [TestMethod]
        public void IsTheConsoleMessageBeingProperlySet()
        {
            HelloWorldApp app = new HelloWorldApp();
            app.SetMode(new ConsoleMode());
            app.SetMessage(HELLO_WORLD_TEST_MESSAGE);
            Assert.AreEqual(HELLO_WORLD_TEST_MESSAGE, app.ReturnMessage());
        }
        [TestMethod]
        public void IsTheDatabaseMessageBeingProperlySet()
        {
            HelloWorldApp app = new HelloWorldApp();
            app.SetMode(new DatabaseMode());
            app.SetMessage(HELLO_WORLD_TEST_MESSAGE);
            Assert.AreEqual(HELLO_WORLD_TEST_MESSAGE, app.ReturnMessage());
        }
    }
}
