using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DE_Pro.Tests
{
    [TestClass]
    public class GhostTest
    {
        [TestMethod]
        public void GhostValue()
        {
            //arrange
            int coutghost = 0;
            int result = 92;
            //act
            Ghost dt = new Ghost();
            dt.table.Columns.Add("1", typeof(String));
            for(int i = 0; i<=213; i++)
            {
                dt.table.Rows.Add("1");
            }
            for (int i = 1; i <= 14; i++)
            {
                dt.table.Rows.Remove(dt.table.Rows[0]);
            }
            for (int index = 0; index < dt.table.Rows.Count; ++index)
                ++coutghost;
            coutghost -= 16;
            coutghost /= 2;

            int actual = coutghost;

            //assert
            Assert.AreEqual(result, actual);
        }
    }
}
