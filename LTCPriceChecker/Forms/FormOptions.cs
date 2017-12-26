using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoPriceChecker.GUI_Description;

namespace CryptoPriceChecker
{
    public partial class FormOptions : Form
    {
        private bool allwaysOnTopState;

        public bool GetallwaysOnTopState { get { return allwaysOnTopState; } }
        
        public void SetallwaysOnTopState(bool _allwaysOnTopState)
        {
            allwaysOnTopState = _allwaysOnTopState;
            checkBoxAllwaysOnTop.Checked = allwaysOnTopState;
        }

        public FormOptions()
        {
            InitializeComponent();
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
            checkBoxAllwaysOnTop.Text = GuiDesc.chackBoxAllwaysOnTopText;
            buttonAcceptOptions.Text = GuiDesc.buttonAcceptOptionsText;
        }

        private void checkBoxAllwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAllwaysOnTop.Checked == true) allwaysOnTopState = true;
            else allwaysOnTopState = false;
        }

        private void buttonAcceptOptions_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
