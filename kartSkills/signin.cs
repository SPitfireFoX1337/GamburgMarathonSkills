using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kartSkills
{
    public partial class signin : Template
    {
        public signin()
        {
            InitializeComponent();
        }

        private void signin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new main().Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((tb_email.Text == "admin") && (tb_password.Text == "1448"))
                    {
                MessageBox.Show("Вы авторизировались");
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
                    

            
        }
    }
}
