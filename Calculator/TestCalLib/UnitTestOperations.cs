using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalLib;
namespace TestCalLib
{
    // Cho hệ thống biêt là lớp này được dùng để chạy test
    [TestClass]

    public class UnitTestOperations
    {
        // Cho hệ thống biết là phương thức này được dùng đẻ chạy test
        [TestMethod]
        public void SummationTest()
        {
            // Chuẩn bị các bộ dữ liệu
            var testDatas = new TestData[]
            {
                new TestData(1.1,1.2,2.3),
                new TestData(2,3,5),
                new TestData(2.4,3.9,6.3),
                new TestData(10,100,110)
            };
            Operations openrations = new Operations();
            // Phương thức test 
            foreach(var item in testDatas)
            {
                // Gọi phương thức tính phép cộng
                var res = openrations.Summation(item.a,item.b);
                //Kiểm tra kết quả
                Assert.AreEqual(item.result,res);
            }

        }

        [TestMethod]
        public void Subtraction()
        {
            // CHuẩn bị các dữ liệu
            var testDatas = new TestData[]
            {
                new TestData(4,2,2),
                new TestData(10,5.5,4.5),
                new TestData(100000,1000,99000)
            };
            Operations operations=new Operations();

            // Phương thức test
            foreach(var item in testDatas)
            {
                // GỌi phương thức tính phép trừ
                var res= operations.Subtraction(item.a, item.b);
                //Kiểm tra kết quả
                Assert.AreEqual(item.result, res);
            }
        }
        [TestMethod]
        public void Multiplication()
        {
            // CHuẩn bị các dữ liệu
            var testDatas = new TestData[]
            {
                new TestData(4,2,8),
                new TestData(10,5.5,55),
                new TestData(100000,1000,100000000)
            };
            Operations operations = new Operations();

            // Phương thức test
            foreach (var item in testDatas)
            {
                // GỌi phương thức tính phép trừ
                var res = operations.Multiplication(item.a, item.b);
                //Kiểm tra kết quả
                Assert.AreEqual(item.result, res);
            }
        }

        [TestMethod]
        public void Division()
        {
            // CHuẩn bị các dữ liệu
            var testDatas = new TestData[]
            {
                new TestData(4,2,2),
                new TestData(100,2,50),
            };
            Operations operations = new Operations();

            // Phương thức test
            foreach (var item in testDatas)
            {
                // GỌi phương thức tính phép trừ
                var res = operations.Division(item.a, item.b);
                //Kiểm tra kết quả
                Assert.AreEqual(item.result, res);
            }
        }
    }
}
