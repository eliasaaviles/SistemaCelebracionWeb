using System;
using BLL;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CelebracionSistemaWeb2._0.Tests
{
   
    [TestClass]
    public class CantoTest
    {
        Repositorio<Canto> canto = new Repositorio<Canto>();

        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Canto cliente = new Canto();
            cliente.CantoId = 0;
            cliente.Nombre = "Beethoven";



            paso = canto.Guardar(cliente);
            Assert.AreEqual(paso, true);
        }
    }
}
