using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MAIN_LIBRARY;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void Podrozdelenie_ConstructWithValidParameters_ShouldSucceed()
        {
            // Arrange
            string nazvanie = "Отдел разработки";
            string rukovoditel = "Иванов Иван Иванович";
            Organizaciya organizaciya = new Organizaciya("Название", "Юридический адрес", "Фактический адрес");
            // Act
            Podrozdelenie podrozdelenie = new Podrozdelenie(nazvanie, rukovoditel, organizaciya);
            // Assert
            Assert.IsNotNull(podrozdelenie);
            Assert.AreEqual(nazvanie, podrozdelenie.Nazvanie);
            Assert.AreEqual(rukovoditel, podrozdelenie.Rukovoditel);
            Assert.AreEqual(organizaciya, podrozdelenie.Organizaciya);
        }

        [TestMethod]
        public void Podrozdelenie_Initialization_Failure_NullArguments()
        {
            // Arrange
            Organizaciya organizaciya = new Organizaciya("Организация", "Юридический адрес", "Фактический адрес");
            // Act & Assert
            try
            {
                Podrozdelenie podrozdelenie = new Podrozdelenie(null, "Руководитель", organizaciya);
                Assert.Fail("ArgumentNullException was not thrown");
            }
            catch (ArgumentNullException)
            {
                // Ожидаемый результат
            }
            try
            {
                Podrozdelenie podrozdelenie = new Podrozdelenie("Подразделение", null, organizaciya);
                Assert.Fail("ArgumentNullException was not thrown");
            }
            catch (ArgumentNullException)
            {
                // Ожидаемый результат
            }
            try
            {
                Podrozdelenie podrozdelenie = new Podrozdelenie("Подразделение", "Руководитель", null);
                Assert.Fail("ArgumentNullException was not thrown");
            }
            catch (ArgumentNullException)
            {
                // Ожидаемый результат
            }
        }
    }
}