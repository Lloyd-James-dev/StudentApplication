using System;
using StudentApp_Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentApp_Model;
using System.Data.SqlClient;
using StudentApplication;
using System.Collections.Generic;
using System.Data;

namespace StudentApp_Tests {

    [TestClass]
    public class CRUDTest {


        #region Validation Testing
        [TestMethod]
        public void TestDecimalValidation() {
            //Arrange
            string testDecimal = "12.38";
            //Act
            bool passed = ValidateInput.IsValid(testDecimal, out decimal number);
            //Assert
            Assert.IsTrue(passed);
            //Assert.AreEqual(12.38m, number);
        }
        [TestMethod]
        public void TestDecimalValidationToFail() {
            //Arrange
            string testDecimal = "z12.38";
            //Act
            bool passed = ValidateInput.IsValid(testDecimal, out decimal number);
            //Assert
            Assert.IsFalse(passed);
            //Assert.AreEqual(12.38m, number);
        }
        [TestMethod]
        public void TestDecimalValidationOutput() {
            //Arrange
            string testDecimal = "12.38";
            //Act
            bool passed = ValidateInput.IsValid(testDecimal, out decimal number);
            //Assert
            //Assert.IsTrue(passed);
            Assert.AreEqual(12.38m, number);
        }
        [TestMethod]
        public void TestDecimalValidationOutputOnFailure() {
            //Arrange
            string testDecimal = "z12.38";
            //Act
            bool passed = ValidateInput.IsValid(testDecimal, out decimal number);
            //Assert
            //Assert.IsTrue(passed);
            Assert.AreEqual(0, number);
        }

        [TestMethod]
        public void TestDateTimeComparison() {
            //Arrange
            DateTime before = new DateTime(2001, 3, 4); // 4th March, 2001
            DateTime after = new DateTime(2001, 3, 5); // 5th March, 2001
            //Act
            bool passed = ValidateInput.IsValid(before, after);
            //Assert
            Assert.IsTrue(passed);
            //Assert.AreEqual(12.38m, number);
        }
        [TestMethod]
        public void TestDateTimeComparisonToFail() {
            //Arrange
            DateTime before = new DateTime(2001, 3, 4);
            DateTime after = new DateTime(2001, 3, 5);
            //Act
            bool passed = ValidateInput.IsValid(after, before);
            //Assert
            Assert.IsFalse(passed);
            //Assert.AreEqual(12.38m, number);
        }
        #endregion
        /*
        #region Building Generic DataTables
        class TestClass {
            public string Field_1 { get; set; }
            public string Field_2 { get; set; }
            public string Field_3 { get; set; }
        } 
        [TestMethod]
        public void TestBuildDataTable() {
            //Arrange
            List<TestClass> set = new List<TestClass>() { 
                new TestClass{ Field_1 = "a1", Field_2 = "a2", Field_3 = "a3" },
                new TestClass{ Field_1 = "b1", Field_2 = "b2", Field_3 = "b3" },
                new TestClass{ Field_1 = "c1", Field_2 = "c2", Field_3 = "c3" }
            };
            string expected = set[2].Field_3;
            //Act
            DataTable theTest = cmd.BuildDataTable(set);
            string actual = theTest.Rows[2]["Field_3"].ToString();
            //Assert
            Assert.AreEqual(expected,actual);
        }
        #endregion
        */
        // These tests are for seeded data only
        #region Responses from Database

        string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentAppDB;Integrated Security=True";
        StudentAppContext cntxt = new StudentAppContext();
        IMainDAL cmd = new MainDAL();

        [TestMethod]
        public void TestConnection() {
            // Arrange/Act
            bool doesExist = cntxt.Database.Exists();
            cntxt.Dispose();
            // Assert
            Assert.IsTrue(doesExist);
        }
        [TestMethod]
        public void TestGetCurrentSemesterKey() {
            // Arrange
            // This should fail from 1st Jan to begining of first term of that year and
            // This should fail from 1st July to begining of third term of that year
            // or set semester manually
            // string expectedKey = "20202"; // first 4 digits are the year, last digit is the semester (1 or 2)
            string expectedKey = DateTime.Now.Year.ToString() + (DateTime.Now.Month>6?"2":"1"); 
            cntxt.Database.Connection.ConnectionString = connString;
            // Act
            string actualKey = cmd.GetCurrentSemesterKey();
            cntxt.Dispose();
            // Assert
            Assert.AreEqual(expectedKey, actualKey);
        }
        [TestMethod]
        public void TestGetEarliestSemesterKeyOfCourse() {
            //Assert
            string expectedKey = "20202";
            string course = "ICT50715";
            cntxt.Database.Connection.ConnectionString = connString;
            //Act
            string actualKey = cmd.GetEarliestSemesterKeyOfCourse(course);
            cntxt.Dispose();
            //Assert
            Assert.AreEqual(expectedKey, actualKey);
        }
        [TestMethod]
        public void TestCountUnitsInCourse() {
            //Assert
            int expectedCount = 16;
            string course = "ICT50718";
            int semesterKey = 20212;
            int collegeId = 1;
            cntxt.Database.Connection.ConnectionString = connString;
            //Act
            int actualCount = cmd.CountUnitsInCourse(semesterKey, collegeId, course);
            cntxt.Dispose();
            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }
        #endregion
    }
}
