using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applic
{
    public partial class FormSprTkan : Form
    {

        int tempart;
        public FormSprTkan()
        {
            InitializeComponent();
        }

        private void FormSprTkan_Load(object sender, EventArgs e)
        {

            using (Model1 db = new Model1())
            {
                int D = 0;
                dataGridView1.DataSource = db.Tkans.ToList();
                
            }


            dataGridView1.Columns[0].HeaderCell.Value = "Артикул";
            dataGridView1.Columns[1].HeaderCell.Value = "Наименование ткани";
            dataGridView1.Columns[2].HeaderCell.Value = "Цвет ткани";
            dataGridView1.Columns[3].HeaderCell.Value = "Узор на ткани";
            dataGridView1.Columns[4].HeaderCell.Value = "Графическое изображение ткани";
            dataGridView1.Columns[5].HeaderCell.Value = "Состав ткани";
            dataGridView1.Columns[6].HeaderCell.Value = "Ширина в рулоне, м";
            dataGridView1.Columns[7].HeaderCell.Value = "Базовая длина рулона, м";
            dataGridView1.Columns[8].HeaderCell.Value = "Стоимость единицы, руб";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            { MessageBox.Show("Наименование ткани не введено!"); }
            else
            {
                if (textBox7.Text == "")
                { MessageBox.Show("Базовая ширина рулона не введено!"); }
                else
                {
                    if (textBox8.Text == "")
                    { MessageBox.Show("Базовая длина рулона не введено!"); }
                    else
                    {
                        if (textBox9.Text == "")
                        { MessageBox.Show("Стоимость рулона не введено!"); }
                        else
                        {

                            using (Model1 db = new Model1())
                            {
                                Tkan us = new Tkan()
                                {
                                    Name = textBox2.Text,
                                    Color = textBox3.Text,
                                    Uzor = textBox4.Text,
                                    Picture = textBox5.Text,
                                    Sostav = textBox6.Text,
                                    Shirina = Convert.ToDecimal(textBox7.Text),
                                    Dlina = Convert.ToDecimal(textBox8.Text),
                                    Cena = Convert.ToDecimal(textBox9.Text)

                                };
                                db.Tkans.Add(us);
                                db.SaveChanges();
                                dataGridView1.DataSource = db.Tkans.ToList();
                                dataGridView1.Columns[0].HeaderCell.Value = "Артикул";
                                dataGridView1.Columns[1].HeaderCell.Value = "Наименование ткани";
                                dataGridView1.Columns[2].HeaderCell.Value = "Цвет ткани";
                                dataGridView1.Columns[3].HeaderCell.Value = "Узор на ткани";
                                dataGridView1.Columns[4].HeaderCell.Value = "Графическое изображение ткани";
                                dataGridView1.Columns[5].HeaderCell.Value = "Состав ткани";
                                dataGridView1.Columns[6].HeaderCell.Value = "Ширина в рулоне, м";
                                dataGridView1.Columns[7].HeaderCell.Value = "Базовая длина рулона, м";
                                dataGridView1.Columns[8].HeaderCell.Value = "Стоимость единицы, руб";
                                textBox2.Text = "";
                                textBox4.Text = "";
                                textBox3.Text = "";
                                textBox5.Text = "";
                                textBox6.Text = "";
                                textBox7.Text = "";
                                textBox8.Text = "";
                                textBox9.Text = "";
                            }



                        }

                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox16.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox13.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox15.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox14.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            tempart= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                Tkan us = db.Tkans.Where(o => o.Articul == tempart).FirstOrDefault();

                db.Tkans.Remove(us);
                db.SaveChanges();
                dataGridView1.DataSource = db.Tkans.ToList();
                dataGridView1.Columns[0].HeaderCell.Value = "Артикул";
                dataGridView1.Columns[1].HeaderCell.Value = "Наименование ткани";
                dataGridView1.Columns[2].HeaderCell.Value = "Цвет ткани";
                dataGridView1.Columns[3].HeaderCell.Value = "Узор на ткани";
                dataGridView1.Columns[4].HeaderCell.Value = "Графическое изображение ткани";
                dataGridView1.Columns[5].HeaderCell.Value = "Состав ткани";
                dataGridView1.Columns[6].HeaderCell.Value = "Ширина в рулоне, м";
                dataGridView1.Columns[7].HeaderCell.Value = "Базовая длина рулона, м";
                dataGridView1.Columns[8].HeaderCell.Value = "Стоимость единицы, руб";
                textBox16.Text = "";
                textBox13.Text = "";
                textBox15.Text = "";
                textBox12.Text = "";
                textBox11.Text = "";
                textBox14.Text = "";
                textBox10.Text = "";
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                Tkan us = db.Tkans.Where(o => o.Articul == tempart).FirstOrDefault();

                us.Name = textBox16.Text;
                us.Color = textBox13.Text;
                us.Uzor = textBox15.Text;
                us.Picture = textBox12.Text;
                us.Sostav = textBox11.Text;
                us.Shirina = Convert.ToDecimal(textBox14.Text);
                us.Dlina = Convert.ToDecimal(textBox10.Text);
                us.Cena= Convert.ToDecimal(textBox1.Text);
                db.SaveChanges();
                dataGridView1.DataSource = db.Tkans.ToList();
                dataGridView1.Columns[0].HeaderCell.Value = "Артикул";
                dataGridView1.Columns[1].HeaderCell.Value = "Наименование ткани";
                dataGridView1.Columns[2].HeaderCell.Value = "Цвет ткани";
                dataGridView1.Columns[3].HeaderCell.Value = "Узор на ткани";
                dataGridView1.Columns[4].HeaderCell.Value = "Графическое изображение ткани";
                dataGridView1.Columns[5].HeaderCell.Value = "Состав ткани";
                dataGridView1.Columns[6].HeaderCell.Value = "Ширина в рулоне, м";
                dataGridView1.Columns[7].HeaderCell.Value = "Базовая длина рулона, м";
                dataGridView1.Columns[8].HeaderCell.Value = "Стоимость единицы, руб";

            }
        }
    }
}
