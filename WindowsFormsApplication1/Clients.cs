using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.turDataSet);

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.turDataSet.Клиенты);

        }

        public string insCl(string fio1, string adr1, string tel1)
        {

            if (fio1.Trim() == "")
            {
                MessageBox.Show("ФИО не может быть пустым!");
                return "Ошибка";
            }
            if (adr1.Trim() == "")
            {
                // this.клиентыTableAdapter.Insert(fio1, adr1, tel1);
                MessageBox.Show("Не указан адрес");
                return "Ошибка";
            }
            if (tel1.Trim() == "")
            {
                
                MessageBox.Show("Укажите номер телефона");
                return "Ошибка";
            }
            
            else
            {
                this.клиентыTableAdapter.Insert(fio1, adr1, tel1);
                MessageBox.Show("Клиент добавлен!");
                this.клиентыTableAdapter.Fill(this.turDataSet.Клиенты);
                return "Успешно";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            insCl(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.RemoveCurrent();
            MessageBox.Show("Запись удалена!");
            /*this.клиентыTableAdapter.Delete(int.Parse(this.клиентыDataGridView.CurrentRow.Cells[0].Value.ToString()), this.клиентыDataGridView.CurrentRow.Cells[1].Value.ToString(), this.клиентыDataGridView.CurrentRow.Cells[2].Value.ToString(), this.клиентыDataGridView.CurrentRow.Cells[3].Value.ToString());
            MessageBox.Show("Готово!");
            this.клиентыTableAdapter.Fill(this.turDataSet.Клиенты);
            */
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            клиентыBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(turDataSet);

        }
    }
}