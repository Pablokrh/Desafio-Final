
namespace Desafio_Final
{
    partial class QuoteHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_NameStore = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuoteHistory = new System.Windows.Forms.Label();
            this.txtBQuoteHistory = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Direccion.Location = new System.Drawing.Point(213, 13);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(198, 22);
            this.lbl_Direccion.TabIndex = 2;
            this.lbl_Direccion.Text = "Venezuela 3558, CABA";
            // 
            // lbl_NameStore
            // 
            this.lbl_NameStore.AutoSize = true;
            this.lbl_NameStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameStore.Location = new System.Drawing.Point(9, 13);
            this.lbl_NameStore.Name = "lbl_NameStore";
            this.lbl_NameStore.Size = new System.Drawing.Size(180, 25);
            this.lbl_NameStore.TabIndex = 1;
            this.lbl_NameStore.Text = "TodoRopa Tiendas";
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_Direccion);
            this.panel3.Controls.Add(this.lbl_NameStore);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(421, 50);
            this.panel3.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblQuoteHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 53);
            this.panel1.TabIndex = 29;
            // 
            // lblQuoteHistory
            // 
            this.lblQuoteHistory.AutoSize = true;
            this.lblQuoteHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuoteHistory.Location = new System.Drawing.Point(27, 9);
            this.lblQuoteHistory.Name = "lblQuoteHistory";
            this.lblQuoteHistory.Size = new System.Drawing.Size(362, 37);
            this.lblQuoteHistory.TabIndex = 0;
            this.lblQuoteHistory.Text = "Historial de cotizaciones";
            // 
            // txtBQuoteHistory
            // 
            this.txtBQuoteHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBQuoteHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBQuoteHistory.Location = new System.Drawing.Point(13, 119);
            this.txtBQuoteHistory.Multiline = true;
            this.txtBQuoteHistory.Name = "txtBQuoteHistory";
            this.txtBQuoteHistory.ReadOnly = true;
            this.txtBQuoteHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBQuoteHistory.Size = new System.Drawing.Size(399, 334);
            this.txtBQuoteHistory.TabIndex = 0;
            this.txtBQuoteHistory.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkCyan;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(158, 459);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(106, 38);
            this.btnVolver.TabIndex = 31;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // QuoteHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(421, 509);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtBQuoteHistory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "QuoteHistory";
            this.Text = "TodoRopa Tiendas - Cotizador de prendas";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_NameStore;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQuoteHistory;
        private System.Windows.Forms.TextBox txtBQuoteHistory;
        private System.Windows.Forms.Button btnVolver;
    }
}