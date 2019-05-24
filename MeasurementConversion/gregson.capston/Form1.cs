using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gregson.Capston
{
    public partial class frmMeasurementConverter : Form
    {
        ImperialToMetric imperialConversion = new ImperialToMetric();
        MetricToImperial metricConversion = new MetricToImperial();

        public frmMeasurementConverter()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optImpToMet_CheckedChanged(object sender, EventArgs e)
        {
            grpImperial.Enabled = true;
            if (optMetToImp.Checked == true)
            {
                grpMetric.Enabled = true;
                grpImperial.Enabled = false;
            }
        }

        private void optMetToImp_CheckedChanged(object sender, EventArgs e)
        {
            grpMetric.Enabled = true;
            if (optImpToMet.Checked == true)
            {
                grpMetric.Enabled = false;
                grpImperial.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCentimeters.Clear();
            txtFeet.Clear();
            txtInches.Clear();
            txtKilometers.Clear();
            txtMeters.Clear();
            txtMiles.Clear();
            txtYards.Clear();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(imperialConversion.imperialToMetric(txtFeet.Text,txtInches.Text,txtMiles.Text,txtYards.Text) == true)
            {
                txtKilometers.Text = imperialConversion.getKilometers();
                txtMeters.Text = imperialConversion.getMeters();
                txtCentimeters.Text = imperialConversion.getCentimeters();
            }

            else if(metricConversion.metricToImperial(txtCentimeters.Text,txtMeters.Text,txtKilometers.Text) == true)
            {
                txtInches.Text = metricConversion.getInches();
                txtFeet.Text = metricConversion.getFeet();
                txtYards.Text = metricConversion.getYards();
                txtMiles.Text = metricConversion.getMiles();
            }
           

        }
    }
}
