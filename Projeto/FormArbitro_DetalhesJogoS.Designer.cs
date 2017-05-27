namespace Projeto
{
    partial class FormArbitro_DetalhesJogoS
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbParticipante1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbParticipante1 = new System.Windows.Forms.GroupBox();
            this.cmbDeck1 = new System.Windows.Forms.ComboBox();
            this.gbParticipante2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDeck2 = new System.Windows.Forms.ComboBox();
            this.cmbParticipante2 = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.gbParticipante1.SuspendLayout();
            this.gbParticipante2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(29, 48);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(489, 57);
            this.txtDescricao.TabIndex = 1;
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(101, 119);
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(47, 22);
            this.nudNumero.TabIndex = 2;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(318, 119);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 22);
            this.dtpData.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número";
            // 
            // cmbParticipante1
            // 
            this.cmbParticipante1.FormattingEnabled = true;
            this.cmbParticipante1.Location = new System.Drawing.Point(6, 41);
            this.cmbParticipante1.Name = "cmbParticipante1";
            this.cmbParticipante1.Size = new System.Drawing.Size(195, 24);
            this.cmbParticipante1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Baralho";
            // 
            // gbParticipante1
            // 
            this.gbParticipante1.Controls.Add(this.label4);
            this.gbParticipante1.Controls.Add(this.cmbDeck1);
            this.gbParticipante1.Controls.Add(this.cmbParticipante1);
            this.gbParticipante1.Location = new System.Drawing.Point(29, 188);
            this.gbParticipante1.Name = "gbParticipante1";
            this.gbParticipante1.Size = new System.Drawing.Size(222, 172);
            this.gbParticipante1.TabIndex = 5;
            this.gbParticipante1.TabStop = false;
            this.gbParticipante1.Text = "Jogador 1";
            // 
            // cmbDeck1
            // 
            this.cmbDeck1.FormattingEnabled = true;
            this.cmbDeck1.Location = new System.Drawing.Point(73, 116);
            this.cmbDeck1.Name = "cmbDeck1";
            this.cmbDeck1.Size = new System.Drawing.Size(128, 24);
            this.cmbDeck1.TabIndex = 3;
            // 
            // gbParticipante2
            // 
            this.gbParticipante2.Controls.Add(this.label5);
            this.gbParticipante2.Controls.Add(this.cmbDeck2);
            this.gbParticipante2.Controls.Add(this.cmbParticipante2);
            this.gbParticipante2.Location = new System.Drawing.Point(296, 188);
            this.gbParticipante2.Name = "gbParticipante2";
            this.gbParticipante2.Size = new System.Drawing.Size(222, 172);
            this.gbParticipante2.TabIndex = 5;
            this.gbParticipante2.TabStop = false;
            this.gbParticipante2.Text = "Jogador 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Baralho";
            // 
            // cmbDeck2
            // 
            this.cmbDeck2.FormattingEnabled = true;
            this.cmbDeck2.Location = new System.Drawing.Point(73, 116);
            this.cmbDeck2.Name = "cmbDeck2";
            this.cmbDeck2.Size = new System.Drawing.Size(128, 24);
            this.cmbDeck2.TabIndex = 3;
            // 
            // cmbParticipante2
            // 
            this.cmbParticipante2.FormattingEnabled = true;
            this.cmbParticipante2.Location = new System.Drawing.Point(6, 41);
            this.cmbParticipante2.Name = "cmbParticipante2";
            this.cmbParticipante2.Size = new System.Drawing.Size(195, 24);
            this.cmbParticipante2.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(442, 386);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 34);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(257, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vs.";
            // 
            // FormArbitro_DetalhesJogoS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 432);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbParticipante2);
            this.Controls.Add(this.gbParticipante1);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.nudNumero);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormArbitro_DetalhesJogoS";
            this.Text = "Detalhes";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.gbParticipante1.ResumeLayout(false);
            this.gbParticipante1.PerformLayout();
            this.gbParticipante2.ResumeLayout(false);
            this.gbParticipante2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbParticipante1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbParticipante1;
        private System.Windows.Forms.ComboBox cmbDeck1;
        private System.Windows.Forms.GroupBox gbParticipante2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDeck2;
        private System.Windows.Forms.ComboBox cmbParticipante2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label6;
    }
}