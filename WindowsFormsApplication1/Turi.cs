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
    public partial class Turi : Form
    {
        public Turi()
        {
            InitializeComponent();
        }

        private void турыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.турыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.turDataSet);

        }

        private void Turi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turDataSet.Продажи". При необходимости она может быть перемещена или удалена.
            this.продажиTableAdapter.Fill(this.turDataSet.Продажи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turDataSet.Гостиницы". При необходимости она может быть перемещена или удалена.
            this.гостиницыTableAdapter.Fill(this.turDataSet.Гостиницы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turDataSet.Туры". При необходимости она может быть перемещена или удалена.
            this.турыTableAdapter.Fill(this.turDataSet.Туры);

        }

        public string insTr(string name1, int ot, int day, int night, decimal price)
        {

            if (name1.Trim() != "")
            {
                this.турыTableAdapter.Insert(name1, ot, day, night, price);
                MessageBox.Show("Тур успешно добавлен в базу");
                this.турыTableAdapter.Fill(this.turDataSet.Туры);
                return "Данные добавлены";
            }
            else
            {
                MessageBox.Show("Введите название тура!");
                return "Ошибка";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            турыBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            турыBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            турыBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(turDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            турыBindingSource.RemoveCurrent();
            MessageBox.Show("Тур удалён!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            insTr(this.textBox1.Text, Convert.ToInt32(this.textBox2.Text), Convert.ToInt32(this.textBox3.Text), Convert.ToInt32(this.textBox4.Text), Convert.ToDecimal(this.textBox5.Text));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
