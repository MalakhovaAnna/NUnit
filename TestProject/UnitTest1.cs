using NUnit.Framework;
using System;
using System.Security.Cryptography.X509Certificates;

namespace TestProject
{
    public class Tests0
    {
        [Test]
        public void Test0and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 0;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test0and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 0;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 0;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 0;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 0;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 0;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 0;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 0;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 0;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 0;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 0;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            var x = 0;
            var y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            var x = 0;
            var y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            var x = 0;
            var y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            var x = 0;
            var y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 0;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 0;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 0;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 0;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 0;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test0and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 0;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests1
    {
        [Test]
        public void Test1and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 1;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test1and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 1;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 1;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 1;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 1;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 1;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 1;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 1;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 1;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 1;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 1;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            var x = 1;
            var y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            var x = 1;
            var y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            var x = 1;
            var y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            var x = 1;
            var y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 1;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 1;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 1;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 1;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 1;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test1and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 1;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests2
    {
        [Test]
        public void Test2and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test2and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test2and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 2;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests3
    {
        [Test]
        public void Test3and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test3and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test3and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 3;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests4
    {
        [Test]
        public void Test4and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test4and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test4and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 4;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests5
    {
        [Test]
        public void Test5and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test5and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test5and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 5;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests6
    {
        [Test]
        public void Test6and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test6and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test6and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 6;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests7
    {
        [Test]
        public void Test7and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test7and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test7and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 7;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests8
    {
        [Test]
        public void Test8and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test8and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test8and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 8;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests9
    {
        [Test]
        public void Test9and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test9and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test9and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 9;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests10
    {
        [Test]
        public void Test10and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test10and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test10and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 10;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests11
    {
        [Test]
        public void Test11and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test11and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test11and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 11;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests12
    {
        [Test]
        public void Test12and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test12and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test12and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 12;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests13
    {
        [Test]
        public void Test13and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test13and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test13and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 13;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests14
    {
        [Test]
        public void Test14and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test14and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test14and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 14;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests15
    {
        [Test]
        public void Test15and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test15and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test15and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 15;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests16
    {
        [Test]
        public void Test16and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test16and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test16and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 16;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests17
    {
        [Test]
        public void Test17and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test17and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test17and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 17;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests18
    {
        [Test]
        public void Test18and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test18and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test18and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 18;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests19
    {
        [Test]
        public void Test19and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test19and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test19and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 19;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
    public class Tests20
    {
        [Test]
        public void Test20and0()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 0;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
        }
        [Test]
        public void Test20and1()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 1;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and2()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 2;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and3()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 3;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and4()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 4;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and5()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 5;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and6()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 6;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and7()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 7;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and8()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 8;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and9()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 9;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and10()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 10;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and11()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 11;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and12()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 12;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and13()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 13;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and14()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 14;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and15()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 15;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and16()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 16;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and17()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 17;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and18()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 18;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and19()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 19;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
        [Test]
        public void Test20and20()
        {
            Calculator.Methods a = new Calculator.Methods();
            double x = 20;
            double y = 20;
            double result1 = a.addition(x, y);
            double result2 = a.difference(x, y);
            double result3 = a.multiplication(x, y);
            double result4 = a.division(x, y);
            Assert.IsTrue(x + y == result1, "При сложении x = {0}, y = {1}, получили result = {2}", x, y, result1);
            Assert.IsTrue(x - y == result2, "При вычитании x = {0}, y = {1}, получили result = {2}", x, y, result2);
            Assert.IsTrue(x * y == result3, "При умножении x = {0}, y = {1}, получили result = {2}", x, y, result3);
            Assert.IsTrue(x / y == result4, "При делении x = {0}, y = {1}, получили result = {2}", x, y, result4);
        }
    }
}







