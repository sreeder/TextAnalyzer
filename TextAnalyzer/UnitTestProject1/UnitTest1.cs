using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using TextAnalyzer;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Create_Empty_Alpha()
        {
            //Arrange
            Dictionary<char, int> actual = new Dictionary<char, int>()
            {
                {'a', 0}, {'b', 0}, {'c', 0}, {'d', 0}, {'e', 0},
                {'f', 0}, {'g', 0}, {'h', 0}, {'i', 0}, {'j', 0},
                {'k', 0}, {'l', 0}, {'m', 0}, {'n', 0}, {'o', 0},
                {'p', 0}, {'q', 0}, {'r', 0}, {'s', 0}, {'t', 0},
                {'u', 0}, {'v', 0}, {'w', 0}, {'x', 0}, {'y', 0},
                {'z', 0}

            };

            //Act
            var newdict = WorkerBee.getAlphaDict();

            //Assert
            Assert.IsTrue(actual.SequenceEqual(newdict));

        }

        [TestMethod]
        public void Can_Count_Letters()
        {
            //Arrange
            Dictionary<string, Dictionary<char, int>> textlist = new Dictionary<string, Dictionary<char, int>>();
            var val = WorkerBee.getAlphaDict();
            val['a'] = 1;
            val['c'] = 1;
            val['t'] = 1;
            textlist.Add("cat", val);

            foreach (KeyValuePair<string, Dictionary<char, int>> pair in textlist)
            {
                //Act
                Dictionary<char, int> result = WorkerBee.AnalyzeText(pair.Key);

                //Assert
                Assert.IsTrue(pair.Value.SequenceEqual(result));
            }
        }

        [TestMethod]
        public void Can_Skip_Others()
        {
            Dictionary<string, Dictionary<char, int>> textlist = new Dictionary<string, Dictionary<char, int>>();
            var val = WorkerBee.getAlphaDict();
            textlist.Add(" !@#$%^&*(){}:><?", val);
            foreach (KeyValuePair<string, Dictionary<char, int>> pair in textlist)
            {
                //Act
                Dictionary<char, int> result = WorkerBee.AnalyzeText(pair.Key);

                //Assert
                Assert.IsTrue(pair.Value.SequenceEqual(result));
            }
        }
    }
}