using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Tests
{
    [TestClass()]
    public class UnitTests
    {
        [TestMethod()]
        //Добавление тура без названия
        public void insTr_null_Amara_5_4_600_notok()
        {
            Turi n = new Turi();
            string rez = n.insTr("", 2, 5, 4, 600);
            string exp = "Ошибка";
            Assert.AreEqual(rez, exp);
        }
        //Добавление тура с корректным названием
        [TestMethod()]
        public void insTr_Море_Amara_5_4_600_ok()
        {
            Turi n = new Turi();
            string rez = n.insTr("На Море", 2, 5, 4, 600);
            string exp = "Данные добавлены";
            Assert.AreEqual(rez, exp);

        }
        //Добавление клиента в базу
        [TestMethod()]
        public void insCl_FIO_adr_tel_ok()
        {
            Clients n = new Clients();
            string rez = n.insCl("Федотов Дмитрий Иванович", "Советская 15а-9", "500-300-30");
            string exp = "Успешно";
            Assert.AreEqual(rez, exp);

        }
        //Добавление клиента в базу без фамилии
        [TestMethod()]
        public void insCl_insCl_null_adr_tel_notok()
        {
            Clients n = new Clients();
            string rez = n.insCl("", "Советская 15а-9", "500-300-30");
            string exp = "Ошибка";
            Assert.AreEqual(rez, exp);

        }
        //Добавление клиента в базу без адреса
        [TestMethod()]
        public void insCl_insCl_FIO_null_tel_notok()
        {
            Clients n = new Clients();
            string rez = n.insCl("Федотов Дмитрий Иванович", "", "500-300-30");
            string exp = "Ошибка";
            Assert.AreEqual(rez, exp);

        }
        //Добавление клиента в базу без номера телефона
        [TestMethod()]
        public void insCl_insCl_FIO_adr_null_notok()
        {
            Clients n = new Clients();
            string rez = n.insCl("Федотов Дмитрий Иванович", "Советская 15а-9", "");
            string exp = "Ошибка";
            Assert.AreEqual(rez, exp);

        }
        //Добавление заказа с корректным заполнением полей 
        [TestMethod()]
        public void Selling_nametur_clname_date_ok()
        {
            Prodazhi n = new Prodazhi();
            string rez = n.Selling("Море","Федотов Дмитрий Иванович", "15-08-2018");
            string exp = "Готово!";
            Assert.AreEqual(rez, exp);

        }
        //Добавление заказа без выбора тура 
        [TestMethod()]
        public void Selling__clname_null_date_ok()
        {
            Prodazhi n = new Prodazhi();
            string rez = n.Selling("", "Федотов Дмитрий Иванович", "15-08-2018");
            string exp = "Не выбран тур";
            Assert.AreEqual(rez, exp);

        }

    }
}