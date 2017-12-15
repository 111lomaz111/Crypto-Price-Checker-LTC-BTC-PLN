using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Text.RegularExpressions;
using System.Globalization;

namespace LTCPriceChecker
{
    public partial class Form1 : Form
    {

        private String html;
        private float LTCValuePLN, userLTCAmount, userLTCValuePLN;
        private WebClient webClient;
        private Thread retakeValue;

        public Form1()
        {
            InitializeComponent();
            labelPutYourLTCAmount.Text = "Put Your LTC Amount:";
            userLTCAmount = 0;
            LTCValuePLN = 0;
            userLTCValuePLN =0;
            TopMost = true; //allways on top of screen
        }

        private void textBoxuserLTCAmount_TextChanged(object sender, EventArgs e)
        {
            userLTCAmount = Single.Parse(textBoxuserLTCAmount.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainFunction();
            convertValueToPLN();
            //something
        }

        //creating and connecting web client, then is  adding values 
        private void mainFunction()
        {
            webClient = new WebClient();

            using (webClient)
            {
                //test
                try
                {
                    html = webClient.DownloadString("https://bitmarket24.pl/api/LTC_PLN/transactions.json");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            MatchCollection m1 = Regex.Matches(html, @"\d+((.|,)\d)+", RegexOptions.Singleline);

            int i = 0;
            foreach (Match m in m1)
            {
                float.TryParse(m.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out LTCValuePLN);
                i++;
                if (i == 1) break;
            }
        }

        //recalculating user value from ltc value to value in pln
        private void convertValueToPLN()
        {
            retakeValue = new Thread(
                new ThreadStart(() =>
                {
                    for (; ; )
                    {
                        mainFunction();
                        userLTCAmount = Single.Parse(textBoxuserLTCAmount.Text);
                        userLTCValuePLN = LTCValuePLN * userLTCAmount;

                        Thread.Sleep(1000);

                        Invoke(new Action(() =>
                        {
                            richTextBox1.Text = "LTC Price in PLN = " + LTCValuePLN + " PLN";
                            richTextBox1.Text += "\n" + "Your LTC value in PLN = " + userLTCValuePLN.ToString();
                        }));
                    }
                }
                ));
            retakeValue.Start();
        }
    }
}
