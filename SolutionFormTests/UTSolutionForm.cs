using Microsoft.VisualStudio.TestTools.UnitTesting;
using pract02_3;

namespace SolutionFormTests
{
    [TestClass]
    public class UTSolutionForm
    {
        [TestMethod]
        public void FuncExp_returned()
        {
            // Arrange
            SolutionForm form = new SolutionForm();
            double x = 1;
            double y = 2;
            double z = 3;
            double expected = 6;
            // Actual
            double actual = form.SumExp(x, y, z);

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FuncCos_returned()
        {
            // Arrange
            double x = 1;
            double y = 2;
            double z = 3;
            double expected = 11;
            // Actual
            SolutionForm form = new SolutionForm();
            double actual = form.SumCos(x, y, z);
            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FuncCos_error_returned()
        {
            // Arrange
            double x = 1;
            double y = 2;
            double z = 3;
            double expected = 12;
            // Actual
            SolutionForm form = new SolutionForm();
            double actual = form.SumCos(x, y, z);
            // Assert
            Assert.AreEqual(expected, actual);

        }

        // Error test
        [TestMethod]
        public void CheckFunc_error_returned()
        {
            // Arrange
            double x = 1;
            double y = 2;
            double z = 3;
            double expected = 10;
            // Actual

            SolutionForm form = new SolutionForm();
            double actual = form.CheckFunc(x, y, z);

            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
