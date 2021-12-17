using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lift
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
            this.textpassword.Size = new Size(this.textpassword.Width, this.textlogin.Height);
            this.textpassword.AutoSize = false;
            textlogin.Text = "введите логин";
            textlogin.ForeColor = Color.Gray;
            textpassword.Text = "введите пароль";
            textpassword.ForeColor = Color.Gray;
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closebutton_MouseEnter(object sender, EventArgs e)
        {
            closebutton.ForeColor = Color.Black;
                
        }

        private void closebutton_MouseLeave(object sender, EventArgs e)
        {
            closebutton.ForeColor = Color.Red;
        }
        Point lastpoint;
        private void loginform_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void loginform_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
        Point lastpoint1;

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint1.X;
                this.Top += e.Y - lastpoint1.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint1 = new Point(e.X, e.Y);
        }


        private void enterbutton_Click(object sender, EventArgs e)
        {
            string loginuser = textlogin.Text;
            string passworduser = textpassword.Text;

            DB db=new DB();

            DataTable table=new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ul AND `pass` = @up", db.getconnection());
            command.Parameters.Add("@ul",MySqlDbType.VarChar).Value=loginuser;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = passworduser;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("вы авторизированы");
                this.Hide();
                LiftForm liftForm = new LiftForm();
                liftForm.Show();
            }
            
            else
                MessageBox.Show("логин или пароль не верный");

           
            
        }

        private void textlogin_Enter(object sender, EventArgs e)
        {
            if (textlogin.Text == "введите логин")
            {
                textlogin.ForeColor = Color.Black;
                textlogin.Text = "";
            }
        }

        private void textpassword_Enter(object sender, EventArgs e)
        {
            if (textpassword.Text == "введите пароль")
            {
                textpassword.ForeColor = Color.Black;
                textpassword.Text = "";
            }
        }

        private void textlogin_Leave(object sender, EventArgs e)
        {
            if (textlogin.Text == "")
            {
                textlogin.Text = "введите логин";
                textlogin.ForeColor = Color.Gray;
            }
        }

        private void textpassword_Leave(object sender, EventArgs e)
            {
            if (textpassword.Text == "")
            {
                textpassword.Text = "введите пароль";
                textpassword.ForeColor = Color.Gray;
            }
            }
    }
}
