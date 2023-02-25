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
    public partial class Prodazhi : Form
    {
        public Prodazhi()
        {
            InitializeComponent();
        }

        private void продажиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.продажиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.turDataSet);

        }

        private void Prodazhi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.turDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turDataSet.Туры". При необходимости она может быть перемещена или удалена.
            this.турыTableAdapter.Fill(this.turDataSet.Туры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turDataSet.Продажи". При необходимости она может быть перемещена или удалена.
            this.продажиTableAdapter.Fill(this.turDataSet.Продажи);

        }

        public string Selling(string nametur, string clname, string date)
        {

            if (nametur.Trim() != "")
            {
                this.клиентыTableAdapter.Insert(nametur, clname, date);
                MessageBox.Show("Готово!");
                this.клиентыTableAdapter.Fill(this.turDataSet.Клиенты);
                return "Готово!";
            }
            else
            {
                MessageBox.Show("Не выбран тур");
                return "Не выбран тур";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.RemoveCurrent();
            MessageBox.Show("Запись удалена!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(turDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Selling(this.comboBox1.SelectedText, this.comboBox2.SelectedText, this.dateTimePicker1.Value.ToString("MM/dd/yyyy"));
        }
    }
}
