using Microsoft.VisualStudio.TestTools.UnitTesting;
using addressListApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressListApp.Tests
{
    [TestClass()]
    public class Form1Tests
    {

        [TestMethod()]
        public void btnInsert_ClickTest()
        {
            // Arrange
            var form1 = new Form1();

            // Act
            form1.btnInsert_Click(null, EventArgs.Empty);

            // Assert
            // listItem의 상태를 검증합니다. 예: Assert.IsTrue(form1.listItem.Count == 0);
            // 또는 Mocking을 사용한 InsertForm의 호출 검증
            Assert.IsTrue(form1.listItem.Count == 0);
        }

        [TestMethod()]
        public void btnInsertSubmit_Click()
        {
            var form1 = new Form1();

            var insertForm = new InsertForm(form1);
            //insertForm.
        }

    }
}