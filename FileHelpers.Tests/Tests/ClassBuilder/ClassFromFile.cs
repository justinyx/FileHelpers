﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using FileHelpers.Dynamic;
using NUnit.Framework;

namespace FileHelpers.Tests
{
    [TestFixture]
    public class ClassFromFile
    {
        [Test]
        public void ReadFile()
        {
            Type t = ClassBuilder.ClassFromSourceFile(TestCommon.GetPath("Classes", "ClassFromFile.cs"));

            var engine = new FileHelperEngine(t);

            DataTable dt = engine.ReadStringAsDT("");
            Assert.AreEqual(0, dt.Rows.Count);

        }
    }
}
