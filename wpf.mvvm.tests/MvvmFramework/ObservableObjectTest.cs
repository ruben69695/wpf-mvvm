using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using wpf_mvvm.MvvmFramework;
using System.ComponentModel;

namespace wpf.mvvm.tests.MvvmFramework
{
    /// <summary>
    /// Descripción resumida de ObservableObjectTest
    /// </summary>
    [TestClass]
    public class ObservableObjectTest : ObservableObject
    {
        private string _myProperty;

        public string MyProperty {
            get { return _myProperty; }
            set {
                _myProperty = value;
                base.RaisePropertyChangedEvent(nameof(MyProperty));
            }

        }

        public ObservableObjectTest()
        {
        }

        [TestMethod]
        public void CanChangeAPropertyValue()
        {
            string temp = "Hello World!";
            MyProperty = temp;
            Assert.AreEqual<string>(temp, MyProperty);
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
