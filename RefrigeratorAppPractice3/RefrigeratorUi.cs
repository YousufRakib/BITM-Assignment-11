using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        public RefrigeratorUi()
        {
            InitializeComponent();
        }
        WeightCalculate _weightCalculate = new WeightCalculate();
        double maxWeight;
        int numItem;
        double unitWeight;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(maxWeightTakeTextBox.Text))
                {
                    MessageBox.Show("Please Enter vehicle refrigerator capacity");
                    return;
                }
                maxWeight = Convert.ToDouble(maxWeightTakeTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter value");
            }
            
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(maxWeightTakeTextBox.Text))
                {
                    MessageBox.Show("Please Enter vehicle refrigerator capacity");
                    return;
                }
                if (maxWeight == 0)
                {
                    MessageBox.Show("Please save max weight");
                    return;
                }
                
                if (String.IsNullOrEmpty(itemTextBox.Text))
                {
                    MessageBox.Show("Please Enter number of items");
                    return;
                }
                numItem = Convert.ToInt32(itemTextBox.Text);
                if (String.IsNullOrEmpty(weightTextBox.Text))
                {
                    MessageBox.Show("Please Enter per item weight");
                    return;
                }
                unitWeight = Convert.ToDouble(weightTextBox.Text);

                double currentWeight= Convert.ToDouble(_weightCalculate.currentWeight(numItem, unitWeight));
                double remainWeight = Convert.ToDouble(_weightCalculate.remainWeight(maxWeight, numItem, unitWeight));
                if (currentWeight > maxWeight)
                {
                    MessageBox.Show("Your current weight is more than maxweight");
                    return;
                }
                else
                {
                    currentWeightTextBox.Text = Convert.ToString(currentWeight);
                    remainingWeightTextBox.Text = Convert.ToString(remainWeight);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter value");
            }
            
        }
    }
}
