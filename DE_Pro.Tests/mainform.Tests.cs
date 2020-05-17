using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DE_Pro.Tests
{
    [TestClass]
    public class MainformTests
    {
        [TestMethod]
        public void CoutValue()
        {
            //arrange
            int index = 0;
            int cout = 0;
            int result = 92;
            //act
            Mainformm dg = new Mainformm();
            dg.dataGridView1.Columns.Add("1", "");
            dg.dataGridView1.Rows.Add(200);
            for (index = 0; index < dg.dataGridView1.Rows.Count; ++index)
                ++Mainformm.cout;

            Mainformm.cout -= 16;
            Mainformm.cout /= 2;

            int actual = Mainformm.cout;

            //assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void ImportExcelValue()
        {
            //arrange
            string value = "в в в в 8 12 4,5 7,5 в 12 4,5 7,5 в 12 4,5 7,5 в 12 4,5 7,5 в 12 4,5 7,5 в 12 4,5 7,5 в 12 4,5";
            string result = "0x444423102410241024102410241024F0";

            //act
            Mainformm st = new Mainformm();
            st.stroka = value;
            st.stroka = st.stroka.Replace(" ", "").Replace("4,5", "0").Replace("7,5", "1").Replace("12", "2").Replace("8", "3").Replace("в", "4").Replace("от", "5");
            char[] charArray = st.stroka.ToCharArray();
            st.stroka = Convert.ToString(charArray[1].ToString() + (object)charArray[0] + (object)charArray[3] + (object)charArray[2] + (object)charArray[5] + (object)charArray[4]) + (object)charArray[7] + (object)charArray[6] + (object)charArray[9] + (object)charArray[8] + (object)charArray[11] + (object)charArray[10] + (object)charArray[13] + (object)charArray[12] + (object)charArray[15] + (object)charArray[14] + (object)charArray[17] + (object)charArray[16] + (object)charArray[19] + (object)charArray[18] + (object)charArray[21] + (object)charArray[20] + (object)charArray[23] + (object)charArray[22] + (object)charArray[25] + (object)charArray[24] + (object)charArray[27] + (object)charArray[26] + (object)charArray[29] + (object)charArray[28] + "F" + (object)charArray[30];
            st.stroka = "0x" + st.stroka;
            string actual = st.stroka;

            //assert
             Assert.AreEqual(result, actual);
        }
    }
}
