// <copyright file="ClientsTest.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1.Tests
{
    /// <summary>Этот класс содержит параметризованные модульные тесты для Clients</summary>
    [PexClass(typeof(Clients))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ClientsTest
    {
        /// <summary>Тестовая заглушка для insCl(String, String, String)</summary>
        [PexMethod]
        public void insClTest(
            [PexAssumeUnderTest]Clients target,
            string fio1,
            string adr1,
            string tel1
        )
        {
            target.insCl(fio1, adr1, tel1);
            // TODO: добавление проверочных утверждений в метод ClientsTest.insClTest(Clients, String, String, String)
        }
    }
}
