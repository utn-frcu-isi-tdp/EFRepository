using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EFRepository.Controllers;

namespace EFRepository.Test
{
    [TestClass]
    public class CRUDPersonaFacadeTests
    {
        [TestMethod]
        public void TestCreate()
        {
            CRUDPersonaFacade mFacade = new CRUDPersonaFacade();

            mFacade.Create(new Persona
            {
                Nombre = "Juan",
                Apellido = "Gonzales"
            });

            Assert.IsTrue(true);
        }
    }
}
