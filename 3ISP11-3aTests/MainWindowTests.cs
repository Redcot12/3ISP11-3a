using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3ISP11_3a;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ISP11_3a.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnsTrue()
        {
            //Arange.
            string password = "aSqw12$$";
            bool expected = true;

            // Act.
            bool actual = PasswordCheck.PasswordValidate(password);



            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Check_4Symbols_ReturnsFalse()
        {
            //Arange.
            string password = "aq1$";
            // bool expected = false;

            // Act.
            bool actual = PasswordCheck.PasswordValidate(password);



            Assert.IsFalse(actual);
        }


        [TestMethod()]
        public void Check_30Symbols_ReturnsFalse()
        {
            //Arange.
            string password = "ASDqwe123$ASDqwe123$ASDqwe123$";
            bool expected = false;

            // Act.
            bool actual = PasswordCheck.PasswordValidate(password);



            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Check_PasswordWithDigits_ReturnsTrue()
        {
            //Arange.
            string password = "ASDqwe1$";
            bool expected = true;

            // Act.
            bool actual = PasswordCheck.PasswordValidate(password);



            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutDigits_ReturnsFalse()
        {
            //Arange.
            string password = "ASDqweASD$";
            bool expected = false;

            // Act.
            bool actual = PasswordCheck.PasswordValidate(password);



            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordSpecSymbols_ReturnsTrue()
        {
            //Arange.
            string password = "Aqwe123$";
            bool expected = true;

            // Act.
            bool actual = PasswordCheck.PasswordValidate(password);



            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutSpecSymbols_ReturnsFalse()
        {
            //Arange.
            string password = "ASDqwe123";
            bool expected = false;

            // Act.
            bool actual = PasswordCheck.PasswordValidate(password);



            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithCapsSymbols_ReturnsTrue()
        {
            //Arange.
            string password = "Aqwe123$";
            bool expected = true;

            // Act.
            bool actual = PasswordCheck.PasswordValidate(password);



            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]


        public void Check_PasswordWithoutCapsSymbols_ReturnsFalse()
        {
            //Arange.
            string password = "asdqwe123$";
            bool expected = false;

            // Act.
            bool actual = PasswordCheck.PasswordValidate(password);



            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithLowersSymbols_ReturnsTrue()
        {
            //Arange.
            string password = "ASDq123$";
            bool expected = true;

            // Act.
            bool actual = PasswordCheck.PasswordValidate(password);



            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutLowersSymbols_ReturnsTrue()
        {
            //Arange.
            string password = "ASDQWE123$";
            bool expected = false;

            // Act.
            bool actual = PasswordCheck.PasswordValidate(password);



            Assert.AreEqual(expected, actual);
        }
    }
}