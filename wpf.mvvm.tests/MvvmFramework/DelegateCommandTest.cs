using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using wpf_mvvm.MvvmFramework;
using System.Diagnostics;

namespace wpf.mvvm.tests.MvvmFramework
{
    /// <summary>
    /// Descripción resumida de DelegateCommandTest
    /// </summary>
    [TestClass]
    public class DelegateCommandTest
    {
        private DelegateCommand _command;

        public DelegateCommandTest()
        {
            _command = new DelegateCommand(ActionTestToExecute);
        }

        [TestMethod]
        public void CanExecuteCommandAction()
        {
            Assert.AreEqual<bool>(true, _command.CanExecute(null));
        }

        [TestMethod]
        public void NullConstructorThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                _command = new DelegateCommand(null);
            });
        }

        private void ActionTestToExecute()
        {
            Debug.WriteLine("Okay dude, executed");
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
    }
}
