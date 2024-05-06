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
            string nazvanie = "����� ����������";
            string rukovoditel = "������ ���� ��������";
            Organizaciya organizaciya = new Organizaciya("��������", "����������� �����", "����������� �����");
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
            Organizaciya organizaciya = new Organizaciya("�����������", "����������� �����", "����������� �����");
            // Act & Assert
            try
            {
                Podrozdelenie podrozdelenie = new Podrozdelenie(null, "������������", organizaciya);
                Assert.Fail("ArgumentNullException was not thrown");
            }
            catch (ArgumentNullException)
            {
                // ��������� ���������
            }
            try
            {
                Podrozdelenie podrozdelenie = new Podrozdelenie("�������������", null, organizaciya);
                Assert.Fail("ArgumentNullException was not thrown");
            }
            catch (ArgumentNullException)
            {
                // ��������� ���������
            }
            try
            {
                Podrozdelenie podrozdelenie = new Podrozdelenie("�������������", "������������", null);
                Assert.Fail("ArgumentNullException was not thrown");
            }
            catch (ArgumentNullException)
            {
                // ��������� ���������
            }
        }
    }
}