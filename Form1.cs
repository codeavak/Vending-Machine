using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drink
{
    public partial class VendingMachine : Form
    {

        Beverage Cola;
        Beverage CreamSoda;
        Beverage GrapeSoda;
        Beverage LemonLime;
        Beverage RootBeer;
        double total = 0;
        public void UpdateTotal()
        {
            TxtTotal.Text = $"{total:C}";
        }
        public void UpdateCounts()
        {
            txtAmtCola.Text = $"{Cola.NumberRemaining}";
            txtAmtCreamSoda.Text = $"{CreamSoda.NumberRemaining}";
            txtAmtGrapeSoda.Text = $"{GrapeSoda.NumberRemaining}";
            txtAmtLemonLime.Text = $"{LemonLime.NumberRemaining}";
            txtAmtRootBeer.Text = $"{RootBeer.NumberRemaining}";
        }

        public VendingMachine()
        {
            InitializeComponent();
            Cola = new Beverage("Cola", Convert.ToDouble(txtAmtCola.Tag));
            CreamSoda = new Beverage("Cream Soda", Convert.ToDouble(txtAmtCreamSoda.Tag));
            GrapeSoda = new Beverage("Grape Soda", Convert.ToDouble(txtAmtGrapeSoda.Tag));
            LemonLime = new Beverage("Lemon Lime", Convert.ToDouble(txtAmtLemonLime.Tag));
            RootBeer = new Beverage("Root Beer", Convert.ToDouble(txtAmtRootBeer.Tag));


            UpdateCounts();

            pictureBox1.Click += MyButtonClick;
            pictureBox2.Click += MyButtonClick;
            pictureBox3.Click += MyButtonClick;
            pictureBox4.Click += MyButtonClick;
            pictureBox5.Click += MyButtonClick;
        }

        struct Beverage
        {
            public string Name
            {
                get;
                set;
            }
            public double Cost
            {
                get;
                set;
            }
            public int NumberRemaining
            {
                get;
                set;
            }
            public Beverage(string name, double cost)
            {
                this.Name = name;
                this.Cost = cost;
                this.NumberRemaining = 20;
            }
            public bool Dispense()
            {
                if (NumberRemaining > 0)
                {
                    NumberRemaining--;
                    return true;
                }
                else
                {
                    MessageBox.Show("No more cans of this beverage are left in the machine. Please try again later!");
                    return false;
                }

            }
        }
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            total = 0;
            UpdateTotal();

        }
        void MyButtonClick(object sender, EventArgs e)
        {

            PictureBox clickedPictureBox = sender as PictureBox;

            switch (clickedPictureBox.Name)
            {
                case "pictureBox1":
                    {
                        if (Cola.Dispense()) total += Cola.Cost; UpdateTotal(); UpdateCounts();
                    }
                    break;
                case "pictureBox2":
                    {
                        if (CreamSoda.Dispense()) total += CreamSoda.Cost; UpdateTotal(); UpdateCounts();
                    }
                    break;
                case "pictureBox3":
                    {
                        if (GrapeSoda.Dispense()) total += GrapeSoda.Cost; UpdateTotal(); UpdateCounts();
                    }
                    break;
                case "pictureBox4":
                    {
                        if (LemonLime.Dispense()) total += LemonLime.Cost; UpdateTotal(); UpdateCounts();
                    }
                    break;
                case "pictureBox5":
                    {
                        if (RootBeer.Dispense()) total += RootBeer.Cost; UpdateTotal(); UpdateCounts();
                    }
                    break;
            }
            //here you can check which button was clicked by the sender
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}