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
    public partial class FormPolz : Form
    {
        public FormPolz()
        {
            InitializeComponent();
        }

        private void FormPolz_Load(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                dataGridView1.DataSource = db.Users.ToList();
                dataGridView1.Columns[0].HeaderCell.Value = "Имя пользователя";
                dataGridView1.Columns[1].HeaderCell.Value = "Пароль";
                dataGridView1.Columns[2].HeaderCell.Value = "Роль";
                dataGridView1.Columns[3].HeaderCell.Value = "Ответсвенный сотрудник";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { MessageBox.Show("Имя пользователя не введено!"); }
            else
            {
                bool flag;
                using (Model1 db = new Model1())
                {
                    var query = (from user in db.Users.AsEnumerable()
                                 where user.Log == textBox1.Text
                                 select new { user.Passw, user.Role });
                    if (query.Count() != 0) { flag = true; } else { flag = false; }
                }
                if (flag == true)
                { MessageBox.Show("Поьзователь с таким именем уже существует!"); }
                else
                {
                    if (textBox2.Text == "")
                    { MessageBox.Show("Пароль не введен!"); }


                    else
                    {
                        if (comboBox1.Text == "")
                        { MessageBox.Show("Роль пользователя не выбрана!"); }

                        else
                        {
                            using (Model1 db = new Model1())
                            {
                                User us = new User()
                                {
                                    Log = textBox1.Text,
                                    Passw = textBox2.Text,
                                    Role = comboBox1.Text,
                                    Naimen = textBox4.Text
                                };
                                db.Users.Add(us);
                                db.SaveChanges();
                                dataGridView1.DataSource = db.Users.ToList();
                                dataGridView1.Columns[0].HeaderCell.Value = "Имя пользователя";
                                dataGridView1.Columns[1].HeaderCell.Value = "Пароль";
                                dataGridView1.Columns[2].HeaderCell.Value = "Роль";
                                dataGridView1.Columns[3].HeaderCell.Value = "Ответсвенный сотрудник";
                                textBox1.Text = "";
                                textBox2.Text = "";
                                textBox4.Text = "";
                                comboBox1.Text = "";
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

            
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                User us = db.Users.Where(o => o.Log == textBox6.Text).FirstOrDefault();

                db.Users.Remove(us);
                db.SaveChanges();
                dataGridView1.DataSource = db.Users.ToList();
                dataGridView1.Columns[0].HeaderCell.Value = "Имя пользователя";
                dataGridView1.Columns[1].HeaderCell.Value = "Пароль";
                dataGridView1.Columns[2].HeaderCell.Value = "Роль";
                dataGridView1.Columns[3].HeaderCell.Value = "Ответсвенный сотрудник";
                textBox6.Text = "";
                textBox5.Text = "";
                textBox3.Text = "";
                comboBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                User us = db.Users.Where(o => o.Log == textBox6.Text).FirstOrDefault();

                us.Passw = textBox5.Text;
                us.Role = comboBox2.Text;
                us.Naimen = textBox3.Text;
                db.SaveChanges();
                dataGridView1.DataSource = db.Users.ToList();
                dataGridView1.Columns[0].HeaderCell.Value = "Имя пользователя";
                dataGridView1.Columns[1].HeaderCell.Value = "Пароль";
                dataGridView1.Columns[2].HeaderCell.Value = "Роль";
                dataGridView1.Columns[3].HeaderCell.Value = "Ответсвенный сотрудник";
                
            }
        }
    }
}
