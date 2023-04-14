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
    public partial class Form1 : Form, Presenter.IView
    {
        private string var1 = "";
        private string var2 = "";
        private string var3 = "";
        private string msg1 = "";
        private string msg2 = "";
        private string msg3 = "";
        private string msg4 = "";
        private int quantity;
        private QuoteHistory quoteHistory;
        private List<string> MessageQuoteHistory;


       Presenter.Presenter presenter;

        public Form1()
        {
            InitializeComponent();

            presenter = new Presenter.Presenter(this);
            MessageQuoteHistory = new List<string>();
        }

        #region Checked/Unchecked

        private void Rb_Camisa_CheckedChanged(object sender, EventArgs e)
        {
            C_SShort.Enabled = true;
            C_SLong.Enabled = true;
            C_CMao.Enabled = true;
            C_CNormal.Enabled = true;
            C_PNormal.Enabled = false;
            C_PSkinny.Enabled = false;
            C_PNormal.Checked = false;
            C_PSkinny.Checked = false;
        }

        private void Rb_Pantalon_CheckedChanged(object sender, EventArgs e)
        {
            C_PNormal.Enabled = true;
            C_PSkinny.Enabled = true;
            C_SShort.Enabled = false;
            C_SLong.Enabled = false;
            C_CMao.Enabled = false;
            C_CNormal.Enabled = false;
            C_SShort.Checked = false;
            C_SLong.Checked = false;
            C_CMao.Checked = false;
            C_CNormal.Checked = false;
        }

        private void C_MLong_CheckedChanged(object sender, EventArgs e)
        {
            if (C_SLong.Checked) C_SShort.Checked = false;           
            Lbl_ShowQuote.Text = "$_____";lblUnits.Text = "";
            Tb_Units.Text = "";
        }

        private void C_MShort_CheckedChanged(object sender, EventArgs e)
        {
            if (C_SShort.Checked) C_SLong.Checked = false;
            Lbl_ShowQuote.Text = "$_____";
            Tb_Units.Text = "";
        }

        private void C_CNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (C_CNormal.Checked) C_CMao.Checked = false;
            Lbl_ShowQuote.Text = "$_____";
            Tb_Units.Text = "";
        }

        private void C_CMao_CheckedChanged(object sender, EventArgs e)
        {
            if (C_CMao.Checked) C_CNormal.Checked = false;
            Lbl_ShowQuote.Text = "$_____";
            Tb_Units.Text = "";
        }

        private void C_Normal_CheckedChanged(object sender, EventArgs e)
        {
            if (C_PNormal.Checked) C_PSkinny.Checked = false;            
            Lbl_ShowQuote.Text = "$_____";
            Tb_Units.Text = "";
        }

        private void C_Skinny_CheckedChanged(object sender, EventArgs e)
        {
            if (C_PSkinny.Checked) C_PNormal.Checked = false;
            Lbl_ShowQuote.Text = "$_____";
            Tb_Units.Text = "";
        }

        private void C_Standard_CheckedChanged(object sender, EventArgs e)
        {
            if (C_Standard.Checked) C_Premium.Checked = false;
            Lbl_ShowQuote.Text = "$_____";
            Tb_Units.Text = "";
        }

        private void C_Premium_CheckedChanged(object sender, EventArgs e)
        {
            if (C_Premium.Checked) C_Standard.Checked = false;
            Lbl_ShowQuote.Text = "$_____";
            Tb_Units.Text = "";
        }

        #endregion

        private void Btn_Quote_Click(object sender, EventArgs e)
        {
            var1 = "";
            var2 = "";
            var3 = "";
            msg1 = "";
            msg2 = "";
            msg3 = "";
            msg4 = "";


            if (Rb_Shirt.Checked)
            {
                if (C_SLong.Checked)
                {
                    var1 = "Long";
                }
                else if (C_SShort.Checked)
                {
                    var1 = "Short";
                }
                else msg1=("Selecciona el tipo de manga de la camisa\n");
                
                if (C_CNormal.Checked)
                {
                    var2 = "Normal";
                }
                else if (C_CMao.Checked)
                {
                    var2 = "Mao";
                }
                else msg2=("Selecciona tipo de cuello de la camisa\n");

                if (C_Standard.Checked) var3 = "Standard";
                else if (C_Premium.Checked) var3 = "Premium";
                else msg3 = "Selecciona la calidad de la camisa\n";
            }
            else if (Rb_Pants.Checked)
            {
                if (C_PNormal.Checked)
                {                    
                     var1=("Normal");
                }
                else if (C_PSkinny.Checked)
                {
                    var1 = ("Skinny");
                }
                else msg1=("Selecciona el calce del pantalón\n");


                if (C_Standard.Checked) var2=("Standard");
                else if (C_Premium.Checked) var2=("Premium");
                else msg2 = ("Selecciona la calidad del pantalón\n");

            }

            bool aux=ValidateQuantity();


            if (Rb_Shirt.Checked)
            {
                if ( var1 != "" && var2 != "" && var3 != "" && aux==true)
                {
                    presenter.Quote(quantity, var1, var2, var3);
                }
                else ShowMessageAlert(msg1+msg2+msg3+msg4);             
            }
            else
            {
                if (var1 != "" && var2 != "" && aux == true)
                {
                    presenter.Quote(quantity, var1, var2, var3);
                }               
                else ShowMessageAlert(msg1+msg2+msg4);
            }

        }
       
        private bool ValidateQuantity()
        {
            quantity=0;
            bool isNumber = true;
            msg4 = "";
            try
            {
                quantity = int.Parse(Tb_Units.Text);
            }

            catch (Exception)
            {             
                msg4 = "Selecciona un valor numérico en 'Cantidad'";
                isNumber = false;
            }

            if (quantity < 1 && isNumber == true)
            {
                msg4 = "Introduce un número válido";
                return false;
            }
            else if (quantity > 0 && isNumber == true) return true;
            else return false;
        }

        private void ShowUnits(object sender, EventArgs e)
        {

            var1 = "";
            var2 = "";
            var3 = "";


            if (C_SLong.Checked && C_CNormal.Checked && C_Standard.Checked)
            {
                var1 = "Long";
                var2 = "Normal";
                var3 = "Standard";
            }

            else if (C_SLong.Checked && C_CNormal.Checked && C_Premium.Checked)
            {
                var1 = "Long";
                var2 = "Normal";
                var3 = "Premium";
            }
            else if (C_SLong.Checked && C_CMao.Checked && C_Premium.Checked)
            {
                var1 = "Long";
                var2 = "Mao";
                var3 = "Premium";
            }

            else if (C_SLong.Checked && C_CMao.Checked && C_Standard.Checked)
            {
                var1 = "Long";
                var2 = "Mao";
                var3 = "Standard";
            }
            else if (C_SShort.Checked && C_CNormal.Checked && C_Standard.Checked)
            {
                var1 = "Short";
                var2 = "Normal";
                var3 = "Standard";
            }

            else if (C_SShort.Checked && C_CNormal.Checked && C_Premium.Checked)
            {
                var1 = "Short";
                var2 = "Normal";
                var3 = "Premium";
            }
            else if (C_SShort.Checked && C_CMao.Checked && C_Premium.Checked)
            {
                var1 = "Short";
                var2 = "Mao";
                var3 = "Premium";
            }

            else if (C_SShort.Checked && C_CMao.Checked && C_Standard.Checked)
            {
                var1 = "Short";
                var2 = "Mao";
                var3 = "Standard";
            }
            else if (C_PNormal.Checked && C_Standard.Checked)
            {
                var1 = "Normal";
                var2 = "Standard";
            }
            else if (C_PNormal.Checked && C_Premium.Checked)
            {
                var1 = "Normal";
                var2 = "Premium";
            }
            else if (C_PSkinny.Checked && C_Standard.Checked)
            {
                var1 = "Skinny";
                var2 = "Standard";
            }

            else if (C_PSkinny.Checked && C_Premium.Checked)
            {
                var1 = "Skinny";
                var2 = "Premium";
            }
            else
            {
                lblUnits.Text = "";
                lblUnitPrice.Text = "";
            }

           presenter.ShowUnitsAndPrice(var1, var2, var3);         

        }


        private void lbl_Historial_Click(object sender, EventArgs e)
        {
            quoteHistory = new QuoteHistory(MessageQuoteHistory, this);
            quoteHistory.Show();
            this.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            presenter.ShowNameAndId();
        }

        #region métodos que implementan IView

        public void ShowMessageAlert(string message)
        {
            if (message!="") MessageBox.Show(message);
        }

        public void ShowUnits(int intToShow)
        {
            if (intToShow != 0)lblUnits.Text = Convert.ToString(intToShow);            
            else lblUnits.Text = "";
        }

        public void ShowPrice (float unitPrice)        {

            if (unitPrice != 0) lblUnitPrice.Text = Convert.ToString(unitPrice);
            else lblUnitPrice.Text = "";
        }

        public void ShowNameAndId(string sellerName,string sellerSurName, string code)
        {
            lbl_SellerName.Text = sellerName+ " "+ sellerSurName;
            lbl_NumberCode.Text = code;
        }

        public void ShowQuote(float showQuote)
        { 
            if (showQuote != 0) Lbl_ShowQuote.Text = "$"+Convert.ToString(showQuote);
            else Lbl_ShowQuote.Text = "$_____";
        }

        
        public void ShowQuoteHistory (string clothingQuote, int id, int idSeller, DateTime hourAndDate, int units, float finalPrice)
        {         
            MessageQuoteHistory.Add(" - Id cotización: "+ id + ". Id Vendedor: " + idSeller + ". Prenda: "+  clothingQuote + ". Cantidad: "+ units  +". Total cotización: $"
                 + finalPrice + ". Día y hora: "+ hourAndDate);
        }


        #endregion

        
    }


}
