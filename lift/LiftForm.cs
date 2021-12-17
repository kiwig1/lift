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
    
    public partial class LiftForm : Form
    {
        
        public LiftForm()
        {
            InitializeComponent();
            personon1.Hide();
            personon2.Hide();
            personon3.Hide();
            personon4.Hide();
            personon5.Hide();
            opendoor.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        Point lastpoint;
        private void LiftForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void LiftForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
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

        private void LiftForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        bool inmoove = false;
        bool moovingup = false;
        bool moovingdown = false;
        bool stoplift = false;
        int floorcounter = 0;
                   
        private async void movement(int personfloor, int finishposition)
        { 
            if (inmoove == false)
            {
                inmoove = true;
                if (lift.Location.Y > personfloor)//к человеку
                {
                    moovingup = true;
                    while (lift.Location.Y != personfloor)
                    {
                        if (stoplift == true)
                        {
                            break;//!!!!!!!
                        }
                        await Task.Delay(1);
                        lift.Location = new Point(lift.Location.X, lift.Location.Y - 2);
                        floorcounter += 2;

                    }
                    moovingup = false;
                    closedoor.Hide();
                    opendoor.Show();
                    await Task.Delay(1000);
                    closedoor.Show();
                    opendoor.Hide();

                }
                else if (lift.Location.Y < personfloor)
                {
                    moovingdown = true;
                    while (lift.Location.Y != personfloor)
                    {
                        if (stoplift == true)
                        {
                            break;//!!!!!!!
                        }
                        await Task.Delay(1);
                        lift.Location = new Point(lift.Location.X, lift.Location.Y + 2);
                        floorcounter += 2;
                    }
                    moovingdown = false;
                    closedoor.Hide();
                    opendoor.Show();
                    await Task.Delay(1000);
                    closedoor.Show();
                    opendoor.Hide();
                }
                if(personfloor==24) personon5.Hide();
                if (personfloor == 134) personon4.Hide();
                if (personfloor == 244) personon3.Hide();
                if (personfloor == 354) personon2.Hide();
                if (personfloor == 464) personon1.Hide();
                if (personfloor > finishposition)// отвезти человека
                {
                    moovingup = true;
                    while (lift.Location.Y != finishposition)
                    {
                        if (stoplift == true)
                        {
                            break;//!!!!!!!
                        }
                        await Task.Delay(1);
                        lift.Location = new Point(lift.Location.X, lift.Location.Y - 2);
                        floorcounter += 2;
                    }
                    moovingup = false;
                    closedoor.Hide();
                    opendoor.Show();
                    await Task.Delay(1000);
                    closedoor.Show();
                    opendoor.Hide();
                }
                else
                {
                    moovingdown = true;
                    while (lift.Location.Y != finishposition)
                    {
                        if (stoplift == true)
                        {
                            break;//!!!!!!!
                        }
                        await Task.Delay(1);
                        lift.Location = new Point(lift.Location.X, lift.Location.Y + 2);
                        floorcounter += 2;
                    }
                    moovingdown = false;
                    closedoor.Hide();
                    opendoor.Show();
                    await Task.Delay(1000);
                    closedoor.Show();
                    opendoor.Hide();
                }
                inmoove = false;
            }
        
        

         }
           
        private void buttonfrom5to1_Click(object sender, EventArgs e)
        {
            personon5.Show();
            movement(24, 464);
        }

        private void buttonfrom5to2_Click(object sender, EventArgs e)
        {
            personon5.Show();
            movement(24, 354);
        }

        private void buttonfrom5to3_Click(object sender, EventArgs e)
        {
            personon5.Show();
            movement(24, 244);
        }

        private void buttonfrom5to4_Click(object sender, EventArgs e)
        {
            personon5.Show();
            movement(24, 134);
        }

        private void buttonfrom4to1_Click(object sender, EventArgs e)
        {
            personon4.Show();
            movement(134, 464);
        }

        private void buttonfrom4to2_Click(object sender, EventArgs e)

        {
            personon4.Show();
            movement(134, 354);
        }

        private void buttonfrom4tp3_Click(object sender, EventArgs e)
        {
            personon4.Show();
            movement(134, 244);
        }

        private void buttonfrom4to5_Click(object sender, EventArgs e)
        {
            personon4.Show();
            movement(134, 24);
        }

        private void buttonfrom3to1_Click(object sender, EventArgs e)
        {
            personon3.Show();
            movement(244, 464);
        }

        private void buttonfrom3to2_Click(object sender, EventArgs e)
        {
            personon3.Show();
            movement(244, 354);
        }

        private void buttonfrom3to4_Click(object sender, EventArgs e)
        {
            personon3.Show();
            movement(244, 134);
        }

        private void buttonfrom3to5_Click(object sender, EventArgs e)
        {
            personon3.Show();
            movement(244, 24);
        }

        private void buttonfrom2to1_Click(object sender, EventArgs e)
        {
            personon2.Show();
            movement(354,464 );
        }

        private void buttonfrom2to3_Click(object sender, EventArgs e)
        {
            personon2.Show();
            movement(354, 244);
        }

        private void buttonfrom2to4_Click(object sender, EventArgs e)
        {
            personon2.Show();
            movement(354,134);
        }

        private void buttonfrom2to5_Click(object sender, EventArgs e)
        {
            personon2.Show();
            movement(354, 24);
        }

        private void buttonfrom1to2_Click(object sender, EventArgs e)
        {
            personon1.Show();
            movement(464, 354);
        }

        private void buttonfrom1to3_Click(object sender, EventArgs e)
        {
            personon1.Show();
            movement(464, 244);
        }

        private void buttonfrom1to4_Click(object sender, EventArgs e)
        {
            personon1.Show();
            movement(464, 134);
        }

        private void buttonfrom1to5_Click(object sender, EventArgs e)
        {
            personon1.Show();
            movement(464, 24);
        }
        private async Task stopfloor(int upperfloor,int underfloor)
        {
            if (inmoove == true)
            {
                stoplift = true;
                if (moovingup == true)
                {
                    while (lift.Location.Y != upperfloor)
                    {
                        await Task.Delay(1);
                        lift.Location = new Point(lift.Location.X, lift.Location.Y - 2);
                        floorcounter += 2;
                    }
                }
                else if (moovingdown == true)
                {
                    while (lift.Location.Y != underfloor)
                    {
                        await Task.Delay(1);
                        lift.Location = new Point(lift.Location.X, lift.Location.Y + 2);
                        floorcounter += 2;
                    }
                }
            }
            inmoove = false;
        }
        private async void emergencystopbutton_Click(object sender, EventArgs e)
        {
            personon1.Hide();
            personon2.Hide();
            personon3.Hide();
            personon4.Hide();
            personon5.Hide();
            if (lift.Location.Y > 354) 
               await  stopfloor(354, 464);
            if (lift.Location.Y > 244 && lift.Location.Y < 354)
               await stopfloor(244, 354);
            if (lift.Location.Y < 244 && lift.Location.Y > 134)
               await stopfloor(134, 244);
            if (lift.Location.Y < 134)
               await stopfloor(24, 134);
            floorcounter = floorcounter / 110;
            string text=floorcounter.ToString();
            MessageBox.Show("Лифт проехал этажей:"+ text, "Экстренная остановка");
            stoplift = false;
            floorcounter = 0;
        }
    }
}
