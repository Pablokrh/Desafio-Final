using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Final
{
    public partial class QuoteHistory : Form
    {
        private readonly Form1 form1;

        public QuoteHistory(List <string> messageQuoteHistory, Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            ShowQuoteHistory(messageQuoteHistory);

        }

        public void ShowQuoteHistory(List<string> messageQuoteHistory)
        {
            txtBQuoteHistory.Text="";
            
            for (int i = 0; i < messageQuoteHistory.Count; i++)
            {
                txtBQuoteHistory.Text = txtBQuoteHistory.Text + messageQuoteHistory[i] + Environment.NewLine + Environment.NewLine;
            }



        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            form1.Show();
            Close();
           
        }
    }
}
