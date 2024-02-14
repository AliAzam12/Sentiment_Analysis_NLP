using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sentiment_AnalysisML.Model;
using System.Windows.Forms;

namespace Sentiment_Analysis
{
    public partial class Form1 : Form
    {
        public static string Data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Predict_Button_Click(object sender, EventArgs e)
        {

            // ADD INPUT DATA

            var Data = new ModelInput();
            Data.Col0 = Review_TextBox.Text;

            // OUTPUT OF  DATA
            ModelOutput result = ConsumeModel.Predict(Data);
            if (result.Prediction == "1")
            {
                Get_Review.Text = "Positive";
                Get_Review.ForeColor = Color.Green;
            }
            else
            {
                Get_Review.Text = "Negative";
                Get_Review.ForeColor = Color.Red;
            }
          
        }

        // MOUSE ENTER AND LEAVE EVENTS FOR PREDICT BUTTON
        private void Predict_Button_MouseEnter(object sender, EventArgs e)
        {
            Predict_Button.BackColor = Color.Black;
            Predict_Button.ForeColor = Color.White;
        }

        private void Predict_Button_MouseLeave(object sender, EventArgs e)
        {
            Predict_Button.BackColor = Color.White;
            Predict_Button.ForeColor = Color.Black;
        }
    }
}
