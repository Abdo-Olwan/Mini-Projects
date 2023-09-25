using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class MainMenue : Form
    {
        public MainMenue()
        {
            InitializeComponent();

        }

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
                
            }
          else if (rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }
           else
           {
                return Convert.ToSingle(rbLarge.Tag);
            }
          
     
           
        }

        float GetSelectedCrustPrice()
        {
            if (rbThickCrust.Checked)
            {
                return Convert.ToSingle(rbThickCrust.Tag);
            }
            else
            {
                return Convert.ToSingle(rbThinCrust.Tag);
            }
        }

        float CalculateToppingsPrice()
        {
            float ToppingPrice = 0;
            if(chkExtraChees.Checked)
            {
                ToppingPrice += Convert.ToSingle(chkExtraChees.Tag);
            }
            if (chkOnion.Checked)
            {
                ToppingPrice += Convert.ToSingle(chkOnion.Tag);
            }
            if (chkMushrooms.Checked)
            {
                ToppingPrice += Convert.ToSingle(chkMushrooms.Tag);
            }
            if (chkOlives.Checked)
            {
                ToppingPrice += Convert.ToSingle(chkOlives.Tag);
            }
            if (chkTommatos.Checked)
            {
                ToppingPrice += Convert.ToSingle(chkTommatos.Tag);
            }
            if (chkGreenPeppers.Checked)
            {
                ToppingPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            return ToppingPrice;
        }


        float CalculateTotalPrice()
        {
            return GetSelectedCrustPrice() + GetSelectedSizePrice() + CalculateToppingsPrice();
        }


        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();
            if(rbSmall.Checked)
            {
                lblSize.Text = "Small.";
            }else if (rbLarge.Checked)
            {
                lblSize.Text = "Large.";
            }else { lblSize.Text = "Medium.";
            }
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();
            if(rbThickCrust.Checked)
            {
                lblCrustType.Text = "Thick Crust.";
            }
            else
            {
                lblCrustType.Text = "Thin Crust.";
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();
            string Toppings = "";
            string Spc = " ";
            if(chkExtraChees.Checked)
            {
                Toppings += chkExtraChees.Text;
            }

            if (chkOnion.Checked)
            {
                Toppings += Spc + chkOnion.Text;
            }

            if (chkMushrooms.Checked) 
            {
                Toppings += Spc + chkMushrooms.Text;
            }

            if (chkOlives.Checked)
            {
                Toppings += Spc + chkOlives.Text;
            }

            if (chkTommatos.Checked)
            {
                Toppings += Spc + chkTommatos.Text;
            }

            if (chkGreenPeppers.Checked)
            {
                Toppings += Spc + chkGreenPeppers.Text;
            }

            if (Toppings == "")
            {
                Toppings = "No Toppings";
            }

           // lblToppings.Text = Toppings;
            txtToppings.Text = Toppings;

        }

        void UpdateWhereToEat()
        {
            if(rbEatIn.Checked)
            {
                lblWhereToEat.Text = rbEatIn.Text;
                return;
            }
            if (rbTakeOut.Checked)
            {
                lblWhereToEat.Text = rbTakeOut.Text;
                return;
            }
        }

        void ResetForm()
        {
            // Reset Size 
            gpxSize.Enabled = true;
            rbSmall.Checked = true;

            // Reset Crust
            gpCrust.Enabled = true;
            rbThinCrust.Checked = true;

            //Reset Toppings
            gpToppings.Enabled = true;
            chkExtraChees.Checked = false;
            chkMushrooms.Checked = false;   
            chkOlives.Checked = false;
            chkTommatos.Checked = false;
            chkGreenPeppers.Checked = false;
            chkOnion.Checked = false;


            gpWhereToEat.Enabled = true;
            btnOrderPizza.Enabled = true;
        }

        private void MainMenue_Load(object sender, EventArgs e)
        {
            rbSmall.Checked = true;
            rbThickCrust.Checked = true;    
            rbTakeOut.Checked = true;
        }

 

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                MessageBox.Show("Orderd Placed Successfully", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
          
            gpxSize.Enabled = false;
            gpCrust.Enabled = false;
            gpToppings.Enabled = false;
            gpWhereToEat.Enabled = false;
            btnOrderPizza.Enabled = false;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
          

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTommatos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings(); ;
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }


    }
}
