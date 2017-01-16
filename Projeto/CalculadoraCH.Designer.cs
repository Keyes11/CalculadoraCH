namespace CalculadoraCH
{
    partial class CalculadoraCH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraCH));
            this.lblCH = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtCH = new System.Windows.Forms.TextBox();
            this.txtCirurgiao = new System.Windows.Forms.TextBox();
            this.lblAuxiliar_1 = new System.Windows.Forms.Label();
            this.lblAuxiliar_2 = new System.Windows.Forms.Label();
            this.txtAuxiliar_1 = new System.Windows.Forms.TextBox();
            this.txtAuxiliar_2 = new System.Windows.Forms.TextBox();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.rdoAMB92 = new System.Windows.Forms.RadioButton();
            this.rdoTUSS = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblCH
            // 
            this.lblCH.AutoSize = true;
            this.lblCH.Location = new System.Drawing.Point(16, 16);
            this.lblCH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCH.Name = "lblCH";
            this.lblCH.Size = new System.Drawing.Size(27, 16);
            this.lblCH.TabIndex = 0;
            this.lblCH.Text = "CH";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(190, 15);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(62, 16);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Cirurgião";
            // 
            // txtCH
            // 
            this.txtCH.Location = new System.Drawing.Point(20, 37);
            this.txtCH.Margin = new System.Windows.Forms.Padding(4);
            this.txtCH.MaxLength = 8;
            this.txtCH.Name = "txtCH";
            this.txtCH.Size = new System.Drawing.Size(81, 22);
            this.txtCH.TabIndex = 2;
            this.txtCH.TextChanged += new System.EventHandler(this.txtCH_TextChanged);
            // 
            // txtCirurgiao
            // 
            this.txtCirurgiao.BackColor = System.Drawing.SystemColors.Window;
            this.txtCirurgiao.Location = new System.Drawing.Point(194, 35);
            this.txtCirurgiao.Margin = new System.Windows.Forms.Padding(4);
            this.txtCirurgiao.Name = "txtCirurgiao";
            this.txtCirurgiao.ReadOnly = true;
            this.txtCirurgiao.Size = new System.Drawing.Size(86, 22);
            this.txtCirurgiao.TabIndex = 3;
            // 
            // lblAuxiliar_1
            // 
            this.lblAuxiliar_1.AutoSize = true;
            this.lblAuxiliar_1.Location = new System.Drawing.Point(190, 78);
            this.lblAuxiliar_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuxiliar_1.Name = "lblAuxiliar_1";
            this.lblAuxiliar_1.Size = new System.Drawing.Size(66, 16);
            this.lblAuxiliar_1.TabIndex = 4;
            this.lblAuxiliar_1.Text = "1º Auxiliar";
            // 
            // lblAuxiliar_2
            // 
            this.lblAuxiliar_2.AutoSize = true;
            this.lblAuxiliar_2.Location = new System.Drawing.Point(190, 142);
            this.lblAuxiliar_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuxiliar_2.Name = "lblAuxiliar_2";
            this.lblAuxiliar_2.Size = new System.Drawing.Size(66, 16);
            this.lblAuxiliar_2.TabIndex = 5;
            this.lblAuxiliar_2.Text = "2º Auxiliar";
            // 
            // txtAuxiliar_1
            // 
            this.txtAuxiliar_1.BackColor = System.Drawing.SystemColors.Window;
            this.txtAuxiliar_1.Location = new System.Drawing.Point(194, 97);
            this.txtAuxiliar_1.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuxiliar_1.Name = "txtAuxiliar_1";
            this.txtAuxiliar_1.ReadOnly = true;
            this.txtAuxiliar_1.Size = new System.Drawing.Size(86, 22);
            this.txtAuxiliar_1.TabIndex = 6;
            // 
            // txtAuxiliar_2
            // 
            this.txtAuxiliar_2.BackColor = System.Drawing.SystemColors.Window;
            this.txtAuxiliar_2.Location = new System.Drawing.Point(194, 163);
            this.txtAuxiliar_2.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuxiliar_2.Name = "txtAuxiliar_2";
            this.txtAuxiliar_2.ReadOnly = true;
            this.txtAuxiliar_2.Size = new System.Drawing.Size(86, 22);
            this.txtAuxiliar_2.TabIndex = 7;
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.Location = new System.Drawing.Point(130, 204);
            this.lblCreditos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(153, 16);
            this.lblCreditos.TabIndex = 8;
            this.lblCreditos.Text = "Everton B. Martins - 2017";
            // 
            // rdoAMB92
            // 
            this.rdoAMB92.AutoSize = true;
            this.rdoAMB92.Checked = true;
            this.rdoAMB92.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoAMB92.Location = new System.Drawing.Point(20, 109);
            this.rdoAMB92.Margin = new System.Windows.Forms.Padding(4);
            this.rdoAMB92.Name = "rdoAMB92";
            this.rdoAMB92.Size = new System.Drawing.Size(69, 20);
            this.rdoAMB92.TabIndex = 9;
            this.rdoAMB92.TabStop = true;
            this.rdoAMB92.Text = "AMB92";
            this.rdoAMB92.UseVisualStyleBackColor = true;
            this.rdoAMB92.Click += new System.EventHandler(this.rdoAMB92_Click);
            // 
            // rdoTUSS
            // 
            this.rdoTUSS.AutoSize = true;
            this.rdoTUSS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoTUSS.Location = new System.Drawing.Point(20, 138);
            this.rdoTUSS.Margin = new System.Windows.Forms.Padding(4);
            this.rdoTUSS.Name = "rdoTUSS";
            this.rdoTUSS.Size = new System.Drawing.Size(119, 20);
            this.rdoTUSS.TabIndex = 10;
            this.rdoTUSS.Text = "TUSS (TESTE)";
            this.rdoTUSS.UseVisualStyleBackColor = true;
            this.rdoTUSS.Click += new System.EventHandler(this.rdoTUSS_Click);
            // 
            // MainActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 229);
            this.Controls.Add(this.rdoTUSS);
            this.Controls.Add(this.rdoAMB92);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.txtAuxiliar_2);
            this.Controls.Add(this.txtAuxiliar_1);
            this.Controls.Add(this.lblAuxiliar_2);
            this.Controls.Add(this.lblAuxiliar_1);
            this.Controls.Add(this.txtCirurgiao);
            this.Controls.Add(this.txtCH);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCH);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(415, 287);
            this.Name = "MainActivity";
            this.Text = "Calculadora CH";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCH;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtCH;
        private System.Windows.Forms.TextBox txtCirurgiao;
        private System.Windows.Forms.Label lblAuxiliar_1;
        private System.Windows.Forms.Label lblAuxiliar_2;
        private System.Windows.Forms.TextBox txtAuxiliar_1;
        private System.Windows.Forms.TextBox txtAuxiliar_2;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.RadioButton rdoAMB92;
        private System.Windows.Forms.RadioButton rdoTUSS;
    }
}

