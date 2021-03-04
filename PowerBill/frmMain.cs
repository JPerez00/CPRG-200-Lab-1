using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * CPRG 200 Part 1: Lab Assignment 1
 * Create a C# application that calculates a customer bill for the city power company. Calculation will be
done for one customer at a time.
The rates vary depending on the customer type: residential, commercial, or industrial:
• Residential: $6.00 plus $0.052 for each kWh used ($6.00 is charged even when kWh usage is
zero)
• Commercial: Flat rate of $60.00 for the first 1000 kWh used (or part of, even when zero), and
$0.045 for each additional kWh
• Industrial: Rate depends on whether usage occurred during peak hours or off-peak hours:
o Peak hours: Flat rate of $76.00 for the first 1000 kWh used (or part of, even when zero),
and $0.065 for each additional kWh
o Off-peak hours: Flat rate of $40.00 for the first 1000 kWh used (or part of, even when
zero), and $0.028 for each additional kWh

 * Developer: Jorge Perez 
 * Date: Dec 17, 2020
 */

namespace PowerBill
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // user select Residential
        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {
            HideSecondInput();
        }

        // user selects Commercial
        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            HideSecondInput();
        }

        // user selects Industrial
        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            ShowSecondInput();
        }

        // hide second input prompt and txt box; 
        // adjust prompt for first input: generic kWh
        private void HideSecondInput()
        {
            lblkWh1Prompt.Text = "Used kWh:";
            lblkWh2Prompt.Visible = false;
            txtkWh2.Visible = false;
            txtkWh1.Focus(); // focus on first input box
        }

        // hide second input prompt and txt box; 
        // adjust prompt for first input: peak kWh
        private void ShowSecondInput()
        {
            lblkWh1Prompt.Text = "Peak kWh:";     
            lblkWh2Prompt.Visible = true;
            txtkWh2.Visible = true;
            txtkWh1.Focus(); // focus on first input box
        }
        

        // calculate customer charge
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int kWh = 0, peakKWh= 0, offPeaKWh = 0;
            decimal charge = 0; 
            if (radResidential.Checked)
            {
                if(Validator.IsPresent(txtkWh1, "kWh") &&
                   Validator.IsNonNegativeInteger(txtkWh1, "kWh"))
                {
                    kWh = Convert.ToInt32(txtkWh1.Text);
                    charge = ResidentialCharge(kWh);
                }
            }
            else if (radCommercial.Checked)
            {
                if (Validator.IsPresent(txtkWh1, "Used kWh") &&
                   Validator.IsNonNegativeInteger(txtkWh1, "kWh"))
                {
                    kWh = Convert.ToInt32(txtkWh1.Text);
                    charge = CommercialCharge(kWh);
                }
            }
            else // must be industrial
            {
                if (Validator.IsPresent(txtkWh1, "Peak kWh") &&
                    Validator.IsNonNegativeInteger(txtkWh1, "Peak kWh") &&
                    Validator.IsPresent(txtkWh2, "Off-peak kWh") &&
                    Validator.IsNonNegativeInteger(txtkWh2, "Off-peak kWh"))
                {
                    peakKWh = Convert.ToInt32(txtkWh1.Text);
                    offPeaKWh = Convert.ToInt32(txtkWh2.Text);
                    charge = IndustrialCharge(peakKWh, offPeaKWh);
                }
            }
            // display charge
            lblCharge.Text = charge.ToString("c");
        }

        // calculate charge for residential customer
        private decimal ResidentialCharge(int kWh)
        {
            const decimal BASE_CHARGE = 6;
            const decimal CHARGE_PER_kWh = 0.052m;
            decimal charge = BASE_CHARGE + kWh * CHARGE_PER_kWh;
            return charge;
        }

        // calculate charge for commercial customer
        private decimal CommercialCharge(int kWh)
        {
            const decimal BASE_CHARGE = 60;
            const int THRESHOLD = 1000;
            const decimal CHARGE_PER_kWh = 0.045m;
            decimal charge = BASE_CHARGE;
            if (kWh > THRESHOLD)
                charge += (kWh - THRESHOLD) * CHARGE_PER_kWh;
            return charge;
        }

        // calculate charge for industrial customer
        private decimal IndustrialCharge(int peakKWh, int offPeakKWh)
        {
            const decimal PEAK_BASE_CHARGE = 76;
            const decimal OFF_PEAK_BASE_CHARGE = 40;
            const int THRESHOLD = 1000;
            const decimal PEAK_CHARGE_PER_kWh = 0.065m;
            const decimal OFF_PEAK_CHARGE_PER_kWh = 0.028m;
            decimal charge, peakCharge, offPeakCharge;
            // calculate charge for peak kWh
            peakCharge = PEAK_BASE_CHARGE;
            if (peakKWh > THRESHOLD)
                peakCharge += (peakKWh - THRESHOLD) * PEAK_CHARGE_PER_kWh;
            // calculate charge for off-peak kWh
            offPeakCharge = OFF_PEAK_BASE_CHARGE;
            if (offPeakKWh > THRESHOLD)
                offPeakCharge += (offPeakKWh - THRESHOLD) * OFF_PEAK_CHARGE_PER_kWh;
            // add the two charges
            charge = peakCharge + offPeakCharge;
            return charge;
        }
      

        // clear controls and make Residential selected
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtkWh1.Text = "";
            txtkWh1.Text = "";
            lblCharge.Text = "";
            radResidential.Checked = true;
            txtkWh1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Close(); // this is fine, too
        }
    }
}
