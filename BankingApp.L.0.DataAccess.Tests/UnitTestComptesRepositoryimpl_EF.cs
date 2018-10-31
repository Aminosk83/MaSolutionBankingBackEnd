using System;
using System.Collections.Generic;
using BankingApp.L._0.DataAccess.Domain;
using BankingApp.L._0.DataAccess.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.L._0.DataAccess.Tests
{
    [TestClass]
    public class UnitTestComptesRepositoryimpl_EF
    {
        [TestMethod]
        public void TestCreate()
        {
            //Arrange
            var nouveau = new Compte {Numero = "C4000", Propiertaire="Test", Solde=4000M };
            var underTest = new ComptesRepositoryImpl_EF();
            //ACT
            underTest.Create(nouveau);
            //ASSERT
        }
        [TestMethod]
        public void TestFindAll()
        {
            //Arrange
            
            var underTest = new ComptesRepositoryImpl_EF();
            //ACT
            var actual = ((List < Compte >) underTest.FindAll());
            //ASSERT
            Assert.AreEqual(actual.Count, 4);
        }
    }
}
