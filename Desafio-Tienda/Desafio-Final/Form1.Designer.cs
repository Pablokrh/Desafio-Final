
namespace Desafio_Final
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblUnits = new System.Windows.Forms.Label();
            this.Lbl_ShowQuote = new System.Windows.Forms.Label();
            this.panelQuote = new System.Windows.Forms.Panel();
            this.Btn_Quote = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Tb_Units = new System.Windows.Forms.TextBox();
            this.Lbl_precioU = new System.Windows.Forms.Label();
            this.Lbl_UnitAndUnitPrice = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelUnitPrice = new System.Windows.Forms.Panel();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblStockUnits = new System.Windows.Forms.Label();
            this.C_Premium = new System.Windows.Forms.CheckBox();
            this.C_Standard = new System.Windows.Forms.CheckBox();
            this.C_PNormal = new System.Windows.Forms.CheckBox();
            this.C_PSkinny = new System.Windows.Forms.CheckBox();
            this.C_CNormal = new System.Windows.Forms.CheckBox();
            this.C_CMao = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_MainTitle = new System.Windows.Forms.Label();
            this.lbl_Adress = new System.Windows.Forms.Label();
            this.lbl_NombreTienda = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.C_SShort = new System.Windows.Forms.CheckBox();
            this.C_SLong = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Rb_Pants = new System.Windows.Forms.RadioButton();
            this.Rb_Shirt = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_QuoteHistory = new System.Windows.Forms.Label();
            this.lbl_Seller = new System.Windows.Forms.Label();
            this.lbl_SellerName = new System.Windows.Forms.Label();
            this.lbl_NumberCode = new System.Windows.Forms.Label();
            this.lbl_StringCode = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5.SuspendLayout();
            this.panelQuote.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelUnitPrice.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblUnits);
            this.panel5.Location = new System.Drawing.Point(133, 345);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(91, 43);
            this.panel5.TabIndex = 22;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.Location = new System.Drawing.Point(10, 6);
            this.lblUnits.MinimumSize = new System.Drawing.Size(70, 15);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(70, 29);
            this.lblUnits.TabIndex = 8;
            this.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_ShowQuote
            // 
            this.Lbl_ShowQuote.AllowDrop = true;
            this.Lbl_ShowQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ShowQuote.Location = new System.Drawing.Point(-1, 14);
            this.Lbl_ShowQuote.Name = "Lbl_ShowQuote";
            this.Lbl_ShowQuote.Size = new System.Drawing.Size(145, 42);
            this.Lbl_ShowQuote.TabIndex = 18;
            this.Lbl_ShowQuote.Text = "$_____";
            this.Lbl_ShowQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_ShowQuote.UseCompatibleTextRendering = true;
            // 
            // panelQuote
            // 
            this.panelQuote.AutoSize = true;
            this.panelQuote.BackColor = System.Drawing.Color.White;
            this.panelQuote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuote.Controls.Add(this.Btn_Quote);
            this.panelQuote.Controls.Add(this.panel7);
            this.panelQuote.Location = new System.Drawing.Point(249, 345);
            this.panelQuote.Name = "panelQuote";
            this.panelQuote.Size = new System.Drawing.Size(145, 130);
            this.panelQuote.TabIndex = 25;
            // 
            // Btn_Quote
            // 
            this.Btn_Quote.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_Quote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Quote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Quote.ForeColor = System.Drawing.Color.White;
            this.Btn_Quote.Location = new System.Drawing.Point(9, 85);
            this.Btn_Quote.Name = "Btn_Quote";
            this.Btn_Quote.Size = new System.Drawing.Size(128, 40);
            this.Btn_Quote.TabIndex = 16;
            this.Btn_Quote.Text = "Cotizar";
            this.Btn_Quote.UseVisualStyleBackColor = false;
            this.Btn_Quote.Click += new System.EventHandler(this.Btn_Quote_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Lbl_ShowQuote);
            this.panel7.Location = new System.Drawing.Point(0, 25);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(143, 66);
            this.panel7.TabIndex = 19;
            // 
            // Tb_Units
            // 
            this.Tb_Units.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tb_Units.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Units.Location = new System.Drawing.Point(121, 26);
            this.Tb_Units.MaxLength = 4;
            this.Tb_Units.Name = "Tb_Units";
            this.Tb_Units.Size = new System.Drawing.Size(67, 36);
            this.Tb_Units.TabIndex = 17;
            this.Tb_Units.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_precioU
            // 
            this.Lbl_precioU.AutoSize = true;
            this.Lbl_precioU.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_precioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_precioU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_precioU.Location = new System.Drawing.Point(1, 30);
            this.Lbl_precioU.Name = "Lbl_precioU";
            this.Lbl_precioU.Size = new System.Drawing.Size(24, 26);
            this.Lbl_precioU.TabIndex = 16;
            this.Lbl_precioU.Text = "$";
            // 
            // Lbl_UnitAndUnitPrice
            // 
            this.Lbl_UnitAndUnitPrice.AutoSize = true;
            this.Lbl_UnitAndUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UnitAndUnitPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_UnitAndUnitPrice.Location = new System.Drawing.Point(6, 2);
            this.Lbl_UnitAndUnitPrice.Name = "Lbl_UnitAndUnitPrice";
            this.Lbl_UnitAndUnitPrice.Size = new System.Drawing.Size(185, 20);
            this.Lbl_UnitAndUnitPrice.TabIndex = 16;
            this.Lbl_UnitAndUnitPrice.Text = "Precio unitario   Cantidad";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkCyan;
            this.panel6.Controls.Add(this.Tb_Units);
            this.panel6.Controls.Add(this.Lbl_precioU);
            this.panel6.Controls.Add(this.panelUnitPrice);
            this.panel6.Controls.Add(this.Lbl_UnitAndUnitPrice);
            this.panel6.Location = new System.Drawing.Point(29, 403);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(195, 70);
            this.panel6.TabIndex = 24;
            // 
            // panelUnitPrice
            // 
            this.panelUnitPrice.BackColor = System.Drawing.Color.White;
            this.panelUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUnitPrice.Controls.Add(this.lblUnitPrice);
            this.panelUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelUnitPrice.Location = new System.Drawing.Point(24, 26);
            this.panelUnitPrice.Name = "panelUnitPrice";
            this.panelUnitPrice.Size = new System.Drawing.Size(85, 35);
            this.panelUnitPrice.TabIndex = 16;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(2, 1);
            this.lblUnitPrice.MinimumSize = new System.Drawing.Size(80, 15);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(80, 29);
            this.lblUnitPrice.TabIndex = 9;
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStockUnits
            // 
            this.lblStockUnits.AutoSize = true;
            this.lblStockUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockUnits.Location = new System.Drawing.Point(35, 345);
            this.lblStockUnits.Name = "lblStockUnits";
            this.lblStockUnits.Size = new System.Drawing.Size(77, 40);
            this.lblStockUnits.TabIndex = 23;
            this.lblStockUnits.Text = "Unidades\r\nen Stock:";
            // 
            // C_Premium
            // 
            this.C_Premium.AutoSize = true;
            this.C_Premium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Premium.Location = new System.Drawing.Point(199, 134);
            this.C_Premium.Name = "C_Premium";
            this.C_Premium.Size = new System.Drawing.Size(90, 24);
            this.C_Premium.TabIndex = 13;
            this.C_Premium.Text = "Premium";
            this.C_Premium.UseVisualStyleBackColor = true;
            this.C_Premium.CheckedChanged += new System.EventHandler(this.C_Premium_CheckedChanged);
            // 
            // C_Standard
            // 
            this.C_Standard.AutoSize = true;
            this.C_Standard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Standard.Location = new System.Drawing.Point(94, 134);
            this.C_Standard.Name = "C_Standard";
            this.C_Standard.Size = new System.Drawing.Size(94, 24);
            this.C_Standard.TabIndex = 12;
            this.C_Standard.Text = "Standard";
            this.C_Standard.UseVisualStyleBackColor = true;
            this.C_Standard.CheckedChanged += new System.EventHandler(this.C_Standard_CheckedChanged);
            // 
            // C_PNormal
            // 
            this.C_PNormal.AutoSize = true;
            this.C_PNormal.Enabled = false;
            this.C_PNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_PNormal.Location = new System.Drawing.Point(124, 83);
            this.C_PNormal.Name = "C_PNormal";
            this.C_PNormal.Size = new System.Drawing.Size(76, 22);
            this.C_PNormal.TabIndex = 11;
            this.C_PNormal.Text = "Normal";
            this.C_PNormal.UseVisualStyleBackColor = true;
            this.C_PNormal.CheckedChanged += new System.EventHandler(this.C_Normal_CheckedChanged);
            // 
            // C_PSkinny
            // 
            this.C_PSkinny.AutoSize = true;
            this.C_PSkinny.Enabled = false;
            this.C_PSkinny.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_PSkinny.Location = new System.Drawing.Point(232, 81);
            this.C_PSkinny.Name = "C_PSkinny";
            this.C_PSkinny.Size = new System.Drawing.Size(73, 22);
            this.C_PSkinny.TabIndex = 10;
            this.C_PSkinny.Text = "Chupín";
            this.C_PSkinny.UseVisualStyleBackColor = true;
            this.C_PSkinny.CheckedChanged += new System.EventHandler(this.C_Skinny_CheckedChanged);
            // 
            // C_CNormal
            // 
            this.C_CNormal.AutoSize = true;
            this.C_CNormal.Enabled = false;
            this.C_CNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_CNormal.Location = new System.Drawing.Point(99, 35);
            this.C_CNormal.Name = "C_CNormal";
            this.C_CNormal.Size = new System.Drawing.Size(113, 21);
            this.C_CNormal.TabIndex = 9;
            this.C_CNormal.Text = "Cuello normal";
            this.C_CNormal.UseVisualStyleBackColor = true;
            this.C_CNormal.CheckedChanged += new System.EventHandler(this.C_CNormal_CheckedChanged);
            // 
            // C_CMao
            // 
            this.C_CMao.AutoSize = true;
            this.C_CMao.Enabled = false;
            this.C_CMao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_CMao.Location = new System.Drawing.Point(219, 35);
            this.C_CMao.Name = "C_CMao";
            this.C_CMao.Size = new System.Drawing.Size(97, 21);
            this.C_CMao.TabIndex = 8;
            this.C_CMao.Text = "Cuello Mao";
            this.C_CMao.UseVisualStyleBackColor = true;
            this.C_CMao.CheckedChanged += new System.EventHandler(this.C_CMao_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_MainTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 65);
            this.panel1.TabIndex = 18;
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.AutoSize = true;
            this.lbl_MainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MainTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_MainTitle.Location = new System.Drawing.Point(23, 6);
            this.lbl_MainTitle.Name = "lbl_MainTitle";
            this.lbl_MainTitle.Size = new System.Drawing.Size(353, 47);
            this.lbl_MainTitle.TabIndex = 0;
            this.lbl_MainTitle.Text = "Cotizador de prendas";
            this.lbl_MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_MainTitle.UseCompatibleTextRendering = true;
            // 
            // lbl_Adress
            // 
            this.lbl_Adress.AutoSize = true;
            this.lbl_Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adress.Location = new System.Drawing.Point(213, 13);
            this.lbl_Adress.Name = "lbl_Adress";
            this.lbl_Adress.Size = new System.Drawing.Size(198, 22);
            this.lbl_Adress.TabIndex = 2;
            this.lbl_Adress.Text = "Venezuela 3558, CABA";
            // 
            // lbl_NombreTienda
            // 
            this.lbl_NombreTienda.AutoSize = true;
            this.lbl_NombreTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreTienda.Location = new System.Drawing.Point(9, 13);
            this.lbl_NombreTienda.Name = "lbl_NombreTienda";
            this.lbl_NombreTienda.Size = new System.Drawing.Size(180, 25);
            this.lbl_NombreTienda.TabIndex = 1;
            this.lbl_NombreTienda.Text = "TodoRopa Tiendas";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.C_Premium);
            this.panel4.Controls.Add(this.C_Standard);
            this.panel4.Controls.Add(this.C_PNormal);
            this.panel4.Controls.Add(this.C_PSkinny);
            this.panel4.Controls.Add(this.C_CNormal);
            this.panel4.Controls.Add(this.C_CMao);
            this.panel4.Controls.Add(this.C_SShort);
            this.panel4.Controls.Add(this.C_SLong);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.Rb_Pants);
            this.panel4.Controls.Add(this.Rb_Shirt);
            this.panel4.Location = new System.Drawing.Point(29, 166);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 167);
            this.panel4.TabIndex = 21;
            // 
            // C_SShort
            // 
            this.C_SShort.AutoSize = true;
            this.C_SShort.Enabled = false;
            this.C_SShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_SShort.Location = new System.Drawing.Point(219, 8);
            this.C_SShort.Name = "C_SShort";
            this.C_SShort.Size = new System.Drawing.Size(106, 21);
            this.C_SShort.TabIndex = 7;
            this.C_SShort.Text = "Manga corta";
            this.C_SShort.UseVisualStyleBackColor = true;
            this.C_SShort.CheckedChanged += new System.EventHandler(this.C_MShort_CheckedChanged);
            // 
            // C_SLong
            // 
            this.C_SLong.AutoSize = true;
            this.C_SLong.Enabled = false;
            this.C_SLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_SLong.Location = new System.Drawing.Point(99, 8);
            this.C_SLong.Name = "C_SLong";
            this.C_SLong.Size = new System.Drawing.Size(106, 21);
            this.C_SLong.TabIndex = 6;
            this.C_SLong.Text = "Manga larga";
            this.C_SLong.UseVisualStyleBackColor = true;
            this.C_SLong.CheckedChanged += new System.EventHandler(this.C_MLong_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "________________________________________________";
            // 
            // Rb_Pants
            // 
            this.Rb_Pants.AutoSize = true;
            this.Rb_Pants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_Pants.Location = new System.Drawing.Point(12, 81);
            this.Rb_Pants.Name = "Rb_Pants";
            this.Rb_Pants.Size = new System.Drawing.Size(90, 24);
            this.Rb_Pants.TabIndex = 4;
            this.Rb_Pants.TabStop = true;
            this.Rb_Pants.Text = "Pantalón";
            this.Rb_Pants.UseVisualStyleBackColor = true;
            this.Rb_Pants.CheckedChanged += new System.EventHandler(this.Rb_Pantalon_CheckedChanged);
            // 
            // Rb_Shirt
            // 
            this.Rb_Shirt.AutoSize = true;
            this.Rb_Shirt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_Shirt.Location = new System.Drawing.Point(13, 21);
            this.Rb_Shirt.Name = "Rb_Shirt";
            this.Rb_Shirt.Size = new System.Drawing.Size(80, 24);
            this.Rb_Shirt.TabIndex = 3;
            this.Rb_Shirt.TabStop = true;
            this.Rb_Shirt.Text = "Camisa";
            this.Rb_Shirt.UseVisualStyleBackColor = true;
            this.Rb_Shirt.CheckedChanged += new System.EventHandler(this.Rb_Camisa_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_QuoteHistory);
            this.panel2.Controls.Add(this.lbl_Seller);
            this.panel2.Controls.Add(this.lbl_SellerName);
            this.panel2.Controls.Add(this.lbl_NumberCode);
            this.panel2.Controls.Add(this.lbl_StringCode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 42);
            this.panel2.TabIndex = 19;
            // 
            // lbl_QuoteHistory
            // 
            this.lbl_QuoteHistory.AutoSize = true;
            this.lbl_QuoteHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_QuoteHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuoteHistory.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_QuoteHistory.Location = new System.Drawing.Point(254, 12);
            this.lbl_QuoteHistory.Name = "lbl_QuoteHistory";
            this.lbl_QuoteHistory.Size = new System.Drawing.Size(161, 17);
            this.lbl_QuoteHistory.TabIndex = 7;
            this.lbl_QuoteHistory.Text = "Historial de cotizaciones";
            this.lbl_QuoteHistory.Click += new System.EventHandler(this.lbl_Historial_Click);
            // 
            // lbl_Seller
            // 
            this.lbl_Seller.AutoSize = true;
            this.lbl_Seller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Seller.Location = new System.Drawing.Point(7, 12);
            this.lbl_Seller.Name = "lbl_Seller";
            this.lbl_Seller.Size = new System.Drawing.Size(74, 17);
            this.lbl_Seller.TabIndex = 4;
            this.lbl_Seller.Text = "Vendedor:";
            // 
            // lbl_SellerName
            // 
            this.lbl_SellerName.AutoSize = true;
            this.lbl_SellerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SellerName.Location = new System.Drawing.Point(77, 12);
            this.lbl_SellerName.Name = "lbl_SellerName";
            this.lbl_SellerName.Size = new System.Drawing.Size(63, 17);
            this.lbl_SellerName.TabIndex = 3;
            this.lbl_SellerName.Text = "-----------";
            // 
            // lbl_NumberCode
            // 
            this.lbl_NumberCode.AutoSize = true;
            this.lbl_NumberCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumberCode.Location = new System.Drawing.Point(209, 13);
            this.lbl_NumberCode.Name = "lbl_NumberCode";
            this.lbl_NumberCode.Size = new System.Drawing.Size(23, 17);
            this.lbl_NumberCode.TabIndex = 6;
            this.lbl_NumberCode.Text = "---";
            // 
            // lbl_StringCode
            // 
            this.lbl_StringCode.AutoSize = true;
            this.lbl_StringCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StringCode.Location = new System.Drawing.Point(157, 12);
            this.lbl_StringCode.Name = "lbl_StringCode";
            this.lbl_StringCode.Size = new System.Drawing.Size(56, 17);
            this.lbl_StringCode.TabIndex = 5;
            this.lbl_StringCode.Text = "Código:";
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_Adress);
            this.panel3.Controls.Add(this.lbl_NombreTienda);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 50);
            this.panel3.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.ShowUnits);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(423, 496);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelQuote);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblStockUnits);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "TodoRopa Tiendas - Cotizador de prendas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelQuote.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelUnitPrice.ResumeLayout(false);
            this.panelUnitPrice.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Lbl_ShowQuote;
        private System.Windows.Forms.Panel panelQuote;
        private System.Windows.Forms.Button Btn_Quote;
        private System.Windows.Forms.TextBox Tb_Units;
        private System.Windows.Forms.Label Lbl_precioU;
        private System.Windows.Forms.Label Lbl_UnitAndUnitPrice;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblStockUnits;
        private System.Windows.Forms.CheckBox C_Premium;
        private System.Windows.Forms.CheckBox C_Standard;
        private System.Windows.Forms.CheckBox C_PNormal;
        private System.Windows.Forms.CheckBox C_PSkinny;
        private System.Windows.Forms.CheckBox C_CNormal;
        private System.Windows.Forms.CheckBox C_CMao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_MainTitle;
        private System.Windows.Forms.Label lbl_Adress;
        private System.Windows.Forms.Label lbl_NombreTienda;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox C_SShort;
        private System.Windows.Forms.CheckBox C_SLong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Rb_Pants;
        private System.Windows.Forms.RadioButton Rb_Shirt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_QuoteHistory;
        private System.Windows.Forms.Label lbl_StringCode;
        private System.Windows.Forms.Label lbl_NumberCode;
        private System.Windows.Forms.Label lbl_SellerName;
        private System.Windows.Forms.Label lbl_Seller;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Panel panel7;
    }
}

