using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joe_Automotive
{
    public partial class frmJoeAutomotive : Form
    {
        private const double PARTS_TAX = 0.06;
        private const double OIL_CHANGE = 26.00;
        private const double LUBE_JOB = 18.00;
        private const double RADIATOR_FLUSH = 30.00;
        private const double TRANSMISSION_FLUSH = 80.00;
        private const double INSPECTION = 15.00;
        private const double REPLACE_MUFFLER = 100.00;
        private const double TIRE_ROTATION = 20.00;
        private double partsTax = 0.0;
        private double parts = 0.0;
        private double labor = 0.0;

        public frmJoeAutomotive()
        {
            InitializeComponent();
        }

        private double OilLubeCharges()
        {
            double oilLubeCharges = 0.0;

            if(cboxOilChange.Checked)
            {
                oilLubeCharges += OIL_CHANGE;
            }

            if(cboxLubeJob.Checked)
            {
                oilLubeCharges += LUBE_JOB;
            }

            return oilLubeCharges;
        }

        private double FlushCharges()
        {
            double flushCharges = 0.0;

            if(cboxRadiatorFlush.Checked)
            {
                flushCharges += RADIATOR_FLUSH;
            }

            if(cboxTransmissionFlush.Checked)
            {
                flushCharges += TRANSMISSION_FLUSH;
            }

            return flushCharges;
        }

        private double MiscCharges()
        {
            double miscCharges = 0.0;

            if(cboxInspection.Checked)
            {
                miscCharges += INSPECTION;
            }

            if(cboxReplaceMuffler.Checked)
            {
                miscCharges += REPLACE_MUFFLER;
            }

            if(cboxTireRotation.Checked)
            {
                miscCharges += TIRE_ROTATION;
            }

            return miscCharges;
        }

        private double OtherCharges()
        {
            
            double otherCharges = 0.0;

            if(double.TryParse(tboxParts.Text, out parts))
            {
                otherCharges += parts;
                partsTax = TaxCharges(parts);

                lblOutTax.Text = partsTax.ToString("c");
            }
            else
            {
                MessageBox.Show("Enter parts amount.");
            }

            if(double.TryParse(tboxLabor.Text, out labor))
            {
                otherCharges += labor;
            }
            else
            {
                MessageBox.Show("Enter labor amount.");
            }

            return otherCharges;
        }

        private double TaxCharges(double parts)
        {
            return parts * PARTS_TAX;
        }
        
        private double TotalCharges(double oilLubeCharges, double flushCharges,
            double miscCharges, double otherCharges, double partsTax)
        {
            return oilLubeCharges + flushCharges + miscCharges + otherCharges + partsTax;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            double oilLubeCharges = OilLubeCharges();
            double flushCharges = FlushCharges();
            double miscCharges = MiscCharges();
            double otherCharges = OtherCharges();

            double serviceAndLabor = oilLubeCharges + flushCharges + miscCharges + labor;

            lblOutServiceLabor.Text = serviceAndLabor.ToString("c");

            lblOutParts.Text = parts.ToString("c");

            lblOutTax.Text = partsTax.ToString("c");

            double totalCharges = TotalCharges(oilLubeCharges, flushCharges, miscCharges, otherCharges, partsTax);


            lblOutTotalFees.Text = totalCharges.ToString("c");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboxOilChange.Checked = false;
            cboxLubeJob.Checked = false;

            cboxRadiatorFlush.Checked = false;
            cboxTransmissionFlush.Checked = false;

            cboxInspection.Checked = false;
            cboxReplaceMuffler.Checked = false;
            cboxTireRotation.Checked = false;

            tboxParts.Text = "";
            tboxLabor.Text = "";

            lblOutServiceLabor.Text = "";
            lblOutParts.Text = "";
            lblOutTax.Text = "";
            lblOutTotalFees.Text = "";

            cboxOilChange.Focus();
        }
    }
}
