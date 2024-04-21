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
        public void Podrozdelenie_ConstructWithNullOrganizaciya_ShouldFail()
        {
            // Arrange
            string nazvanie = "Отдел разработки";
            string rukovoditel = "Иванов Иван Иванович";
            Organizaciya organizaciya = null;

            // Act & Assert
            Assert.Throws<System.ArgumentNullException>(() => new Podrozdelenie(nazvanie, rukovoditel, organizaciya));
        }
    }
}
