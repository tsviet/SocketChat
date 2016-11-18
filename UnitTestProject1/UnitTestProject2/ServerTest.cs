using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocketChat;

namespace UnitTestProject2
{
    [TestClass]
    public class ServerTest
    {
        [TestMethod]
        public void MethodGetPortReturnsPortExpect8023()
        {
            Server server = new Server();

            Assert.AreEqual(8023, server.GetPort());

        }
    }
}
