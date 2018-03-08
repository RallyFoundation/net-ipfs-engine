﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipfs.Engine.UnixFileSystem
{
    [TestClass]
    public class FileSystemNodeTest
    {
        [TestMethod]
        public void ToLink()
        {
            var node = new FileSystemNode
            {
                Id = "Qmf412jQZiuVUtdgnB36FXFX7xg5V6KEbSJ4dpQuhkLyfD",
                IsDirectory = true,
                Size = 10
            };
            var link = node.ToLink("foo");
            Assert.AreEqual(node.Id, link.Id);
            Assert.AreEqual(node.IsDirectory, link.IsDirectory);
            Assert.AreEqual(node.Size, link.Size);
            Assert.AreEqual("foo", link.Name);
        }
    }
}