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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string l = textBox1.Text;
            string p = textBox2.Text;
            using (Model1 db = new Model1())
            {
                
                var query = (from user in db.Users.AsEnumerable()
                             where user.Log==l
                             select new { user.Passw, user.Role});
                if (query.Count() == 0) { MessageBox.Show("Пользователь с таким именем не существует"); }
                else
                {

                    foreach (var temp in query)
                    {
                        if (temp.Passw == p)
                        {
                            if (temp.Role == "Заказчик")
                            {
                                this.Hide();
                                FormZak f = new FormZak();
                                f.Show();
                            }
                            if (temp.Role == "Руководитель")
                            {
                                this.Hide();
                                FormRuk f = new FormRuk();
                                f.Show();
                            }
                            if (temp.Role == "Менеджер")
                            {
                                this.Hide();
                                FormMan f = new FormMan();
                                f.Show();
                            }
                            if (temp.Role == "Кладовщик")
                            {
                                this.Hide();
                                FormKlad f = new FormKlad();
                                f.Show();
                            }


                        }
                        else { MessageBox.Show("Пароль введен неверно"); }


                    }
                }



               
            }
        }
    }
}
