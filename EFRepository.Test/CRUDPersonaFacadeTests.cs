using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EFRepository.Controllers;

namespace EFRepository.Test
{
    /// <summary>
    /// Clase de prueba de la clase fachada. Este tipo de prueba no sigue lo estandar ni lo suguerido para las pruebas unitarias generalmente aceptadas, pero se lo codifica 
    /// para verificar el funcionamiento de la fachada con EF.
    /// Para que funcionen los test se debe dar lo siguiente:
    /// - Se debe comenzar con sin una BBDD creada o que la misma esté vacía.
    /// - Ejecutar secuencialmente los test numerados, sin repetir ni saltearse pasos.
    /// 
    /// Ir verificando el resultado de cada test en la BBDD
    /// </summary>
    [TestClass]
    public class CRUDPersonaFacadeTests
    {
        [TestMethod]
        public void Test_1_Create()
        {
            CRUDPersonaFacade mFacade = new CRUDPersonaFacade();

            mFacade.Create(new Persona
            {
                Nombre = "Juan",
                Apellido = "Gonzales"
            });

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Test_2_GetAll()
        {
            CRUDPersonaFacade mFacade = new CRUDPersonaFacade();

            var mPersons = mFacade.GetAll();

            Assert.AreEqual(1, mPersons.Count);
        }

        [TestMethod]
        public void Test_3_GetById()
        {
            CRUDPersonaFacade mFacade = new CRUDPersonaFacade();

            var mPerson1 = mFacade.GetById(1);

            Assert.IsNotNull(mPerson1);
        }

        [TestMethod]
        public void Test_4_Update()
        {
            CRUDPersonaFacade mFacade = new CRUDPersonaFacade();

            mFacade.Update(new Persona
            {
                PersonaId = 1, 
                Nombre = "Juan",
                Apellido = "Gonzalez" // se cambia el apellido.
            });

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Test_5_Delete()
        {
            CRUDPersonaFacade mFacade = new CRUDPersonaFacade();

            mFacade.Delete(new Persona
            {
                PersonaId = 1
            });

            Assert.IsTrue(true);
        }


    }
}
