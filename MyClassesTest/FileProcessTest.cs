using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using System;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExists()
        {
            FileProcess fileProcess = new FileProcess();
            bool fromCall;

            fromCall = fileProcess.FileExists(@"c:\Windows\Regedit.exe");

            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        public void FileNameDoesNotExists()
        {
            FileProcess fileProcess = new FileProcess();
            bool fromCall;

            fromCall = fileProcess.FileExists(@"c:Regedit.exe");

            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException()
        {
            FileProcess fileProcess = new FileProcess();

            fileProcess.FileExists("");
        }
    }
}
