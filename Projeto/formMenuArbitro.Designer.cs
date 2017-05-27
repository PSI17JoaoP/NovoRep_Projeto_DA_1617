namespace Projeto
{
    partial class formMenuArbitro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenuArbitro));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbStandard = new System.Windows.Forms.GroupBox();
            this.gbTeam = new System.Windows.Forms.GroupBox();
            this.lbxStandardT = new System.Windows.Forms.ListBox();
            this.lbxTeamT = new System.Windows.Forms.ListBox();
            this.gbStandardGames = new System.Windows.Forms.GroupBox();
            this.gbTeamGames = new System.Windows.Forms.GroupBox();
            this.lvStandardJ = new System.Windows.Forms.ListView();
            this.lvTeamJ = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.gbStandard.SuspendLayout();
            this.gbTeam.SuspendLayout();
            this.gbStandardGames.SuspendLayout();
            this.gbTeamGames.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Os meus Jogos";
            // 
            // gbStandard
            // 
            this.gbStandard.Controls.Add(this.gbStandardGames);
            this.gbStandard.Controls.Add(this.lbxStandardT);
            this.gbStandard.Location = new System.Drawing.Point(0, 71);
            this.gbStandard.Name = "gbStandard";
            this.gbStandard.Size = new System.Drawing.Size(751, 255);
            this.gbStandard.TabIndex = 1;
            this.gbStandard.TabStop = false;
            this.gbStandard.Text = "Torneios entre Jogadores";
            // 
            // gbTeam
            // 
            this.gbTeam.Controls.Add(this.gbTeamGames);
            this.gbTeam.Controls.Add(this.lbxTeamT);
            this.gbTeam.Location = new System.Drawing.Point(0, 332);
            this.gbTeam.Name = "gbTeam";
            this.gbTeam.Size = new System.Drawing.Size(751, 255);
            this.gbTeam.TabIndex = 2;
            this.gbTeam.TabStop = false;
            this.gbTeam.Text = "Torneios entre Equipas";
            // 
            // lbxStandardT
            // 
            this.lbxStandardT.FormattingEnabled = true;
            this.lbxStandardT.ItemHeight = 16;
            this.lbxStandardT.Location = new System.Drawing.Point(12, 40);
            this.lbxStandardT.Name = "lbxStandardT";
            this.lbxStandardT.Size = new System.Drawing.Size(197, 180);
            this.lbxStandardT.TabIndex = 0;
            this.lbxStandardT.SelectedIndexChanged += new System.EventHandler(this.lbxStandardT_SelectedIndexChanged);
            // 
            // lbxTeamT
            // 
            this.lbxTeamT.FormattingEnabled = true;
            this.lbxTeamT.ItemHeight = 16;
            this.lbxTeamT.Location = new System.Drawing.Point(12, 44);
            this.lbxTeamT.Name = "lbxTeamT";
            this.lbxTeamT.Size = new System.Drawing.Size(197, 180);
            this.lbxTeamT.TabIndex = 0;
            this.lbxTeamT.SelectedIndexChanged += new System.EventHandler(this.lbxTeamT_SelectedIndexChanged);
            // 
            // gbStandardGames
            // 
            this.gbStandardGames.Controls.Add(this.lvStandardJ);
            this.gbStandardGames.Location = new System.Drawing.Point(247, 40);
            this.gbStandardGames.Name = "gbStandardGames";
            this.gbStandardGames.Size = new System.Drawing.Size(492, 180);
            this.gbStandardGames.TabIndex = 1;
            this.gbStandardGames.TabStop = false;
            this.gbStandardGames.Text = "Jogos";
            // 
            // gbTeamGames
            // 
            this.gbTeamGames.Controls.Add(this.lvTeamJ);
            this.gbTeamGames.Location = new System.Drawing.Point(247, 44);
            this.gbTeamGames.Name = "gbTeamGames";
            this.gbTeamGames.Size = new System.Drawing.Size(492, 180);
            this.gbTeamGames.TabIndex = 1;
            this.gbTeamGames.TabStop = false;
            this.gbTeamGames.Text = "Jogos";
            // 
            // lvStandardJ
            // 
            this.lvStandardJ.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvStandardJ.FullRowSelect = true;
            this.lvStandardJ.Location = new System.Drawing.Point(21, 31);
            this.lvStandardJ.MultiSelect = false;
            this.lvStandardJ.Name = "lvStandardJ";
            this.lvStandardJ.Size = new System.Drawing.Size(465, 129);
            this.lvStandardJ.TabIndex = 0;
            this.toolTip.SetToolTip(this.lvStandardJ, "Duplo clique para editar");
            this.lvStandardJ.UseCompatibleStateImageBehavior = false;
            this.lvStandardJ.View = System.Windows.Forms.View.Details;
            this.lvStandardJ.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvStandardJ_MouseDoubleClick);
            // 
            // lvTeamJ
            // 
            this.lvTeamJ.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvTeamJ.FullRowSelect = true;
            this.lvTeamJ.Location = new System.Drawing.Point(21, 30);
            this.lvTeamJ.MultiSelect = false;
            this.lvTeamJ.Name = "lvTeamJ";
            this.lvTeamJ.Size = new System.Drawing.Size(465, 129);
            this.lvTeamJ.TabIndex = 0;
            this.toolTip.SetToolTip(this.lvTeamJ, "Duplo clique para editar");
            this.lvTeamJ.UseCompatibleStateImageBehavior = false;
            this.lvTeamJ.View = System.Windows.Forms.View.Details;
            this.lvTeamJ.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvTeamJ_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Descrição";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Jogador 1";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Jogador 2";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Descrição";
            this.columnHeader5.Width = 98;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Data";
            this.columnHeader6.Width = 83;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Equipa 1";
            this.columnHeader7.Width = 86;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Equipa 2";
            this.columnHeader8.Width = 85;
            // 
            // formMenuArbitro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 590);
            this.Controls.Add(this.gbTeam);
            this.Controls.Add(this.gbStandard);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMenuArbitro";
            this.Text = "Arcmage- Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formMenuArbitro_FormClosed);
            this.Load += new System.EventHandler(this.formMenuArbitro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbStandard.ResumeLayout(false);
            this.gbTeam.ResumeLayout(false);
            this.gbStandardGames.ResumeLayout(false);
            this.gbTeamGames.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbStandard;
        private System.Windows.Forms.GroupBox gbTeam;
        private System.Windows.Forms.ListBox lbxStandardT;
        private System.Windows.Forms.GroupBox gbStandardGames;
        private System.Windows.Forms.ListView lvStandardJ;
        private System.Windows.Forms.GroupBox gbTeamGames;
        private System.Windows.Forms.ListView lvTeamJ;
        private System.Windows.Forms.ListBox lbxTeamT;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolTip toolTip;
    }
}