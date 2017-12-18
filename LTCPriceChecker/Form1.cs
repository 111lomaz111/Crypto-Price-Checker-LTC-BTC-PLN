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

        private String ltcWEB, btcWEB;
        private float LTCValuePLN, userLTCAmount, userLTCValuePLN, BTCValuePLN, userBTCAmount, userBTCValuePLN;
        private WebClient LTCwebClient, BTCwebClient;
        private Thread retakeValue;

        public Form1()
        {
            InitializeComponent();

            labelPutYourLTCAmount.Text = "Put your LTC amount:";
            labelPutYourBTCAmount.Text = "Put your BTC amount:";

            userLTCAmount = 0;
            LTCValuePLN = 0;
            userLTCValuePLN =0;

            userBTCAmount = 0;
            BTCValuePLN = 0;
            userBTCValuePLN = 0;

            TopMost = true; //allways on top of screen
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getValuesOfCrypto();
            convertUserCryptoToPLN();
            //something
        }

        //creating and connecting web client, then adding values 
        private void getValuesOfCrypto()
        {
            LTCwebClient = new WebClient();
            BTCwebClient = new WebClient();

            using (LTCwebClient)
            {
                try
                {
                    ltcWEB = LTCwebClient.DownloadString("https://bitmarket24.pl/api/LTC_PLN/transactions.json");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            using (BTCwebClient)
            {                
                try
                {
                    btcWEB = BTCwebClient.DownloadString("https://bitmarket24.pl/api/BTC_PLN/transactions.json");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }



            MatchCollection ltc1 = Regex.Matches(ltcWEB, @"\d+((.|,)\d)+", RegexOptions.Singleline);

            int l = 0;
            foreach (Match ltc in ltc1)
            {
                float.TryParse(ltc.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out LTCValuePLN);
                l++;
                if (l == 1) break; //i = 1 is the newest price same in BTC \/
            }

            MatchCollection btc1 = Regex.Matches(btcWEB, @"\d+((.|,)\d)+", RegexOptions.Singleline);
            int b = 0;
            foreach (Match btc in btc1)
            {
                float.TryParse(btc.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out BTCValuePLN);
                b++;
                if (b == 1) break;
            }
        }

        //recalculating user LTC and BTC from value in pln
        private void convertUserCryptoToPLN()
        {
            retakeValue = new Thread(
                new ThreadStart(() =>
                {
                    for (; ; )
                    {
                        Thread.Sleep(1000);

                        getValuesOfCrypto();

                        try
                        {
                            userLTCAmount = Single.Parse(textBoxuserLTCAmount.Text);
                            userBTCAmount = Single.Parse(textBoxuserBTCAmount.Text);
                        }
                        catch (Exception exception)
                        {
                           // MessageBox.Show("Type your value in correct format: \"12,34\"");
                        }

                        userLTCValuePLN = LTCValuePLN * userLTCAmount;
                        userBTCValuePLN = BTCValuePLN * userBTCAmount;

                        Invoke(new Action(() =>
                        {
                            richTextBox1.Text = "LTC Price in PLN = " + LTCValuePLN;
                            richTextBox1.Text += "\nBTC Price in PLN = " + BTCValuePLN;
                            richTextBox1.Text += "\nYour LTC value in PLN = " + userLTCValuePLN.ToString();
                            richTextBox1.Text += "\nYour BTC value in PLN = " + userBTCValuePLN.ToString();
                        }));
                    }
                }
                ));
            retakeValue.Start();
        }
    }
}
