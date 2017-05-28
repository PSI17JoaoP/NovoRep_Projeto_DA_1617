namespace Projeto
{
    partial class formMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenuAdmin));
            this.tbMenu = new System.Windows.Forms.TabControl();
            this.tpGestao = new System.Windows.Forms.TabPage();
            this.tcGestao = new System.Windows.Forms.TabControl();
            this.tbGestaoJogadores = new System.Windows.Forms.TabPage();
            this.gbGJogadoresForm = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btImagem = new System.Windows.Forms.Button();
            this.txtAvatar = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.btnJogadoresCancelar = new System.Windows.Forms.Button();
            this.btnJogadoresAcao = new System.Windows.Forms.Button();
            this.nudIdadeJogador = new System.Windows.Forms.NumericUpDown();
            this.txtNickJogador = new System.Windows.Forms.TextBox();
            this.txtEmailJogador = new System.Windows.Forms.TextBox();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbGJogadoresDados = new System.Windows.Forms.GroupBox();
            this.btnRemoverJogador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterarJogador = new System.Windows.Forms.Button();
            this.dgvGListaJogadores = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avatarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_DA_ProjetoDataSet_Players = new Projeto.BD_DA_ProjetoDataSet_Players();
            this.btnInserirJogador = new System.Windows.Forms.Button();
            this.txtGJogadoresPesquisa = new System.Windows.Forms.TextBox();
            this.tbGestaoEquipas = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvJogadoresEquipa = new System.Windows.Forms.ListView();
            this.cNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cIdade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuardarJogadorEquipa = new System.Windows.Forms.Button();
            this.btnRetirarJogador = new System.Windows.Forms.Button();
            this.btnAdicionarJogador = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lcListaJogadores = new System.Windows.Forms.ListView();
            this.cNome1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cEmail2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cIdade2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNickname2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbGEquipasDados = new System.Windows.Forms.GroupBox();
            this.btnGerirEquipa = new System.Windows.Forms.Button();
            this.gbGEquipasForm = new System.Windows.Forms.GroupBox();
            this.pictureBoxAvatarEquipa = new System.Windows.Forms.PictureBox();
            this.btnAvatarEquipa = new System.Windows.Forms.Button();
            this.btnEquipaCancelar = new System.Windows.Forms.Button();
            this.btnEquipaAcao = new System.Windows.Forms.Button();
            this.txtGAvatarEquipa = new System.Windows.Forms.TextBox();
            this.txtGNomeEquipa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemoverEquipa = new System.Windows.Forms.Button();
            this.btnAlterarEquipa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInserirEquipa = new System.Windows.Forms.Button();
            this.dgvGListaEquipas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avatarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_DA_ProjetoDataSet_Teams = new Projeto.BD_DA_ProjetoDataSet_Teams();
            this.txtGEquipasPesquisa = new System.Windows.Forms.TextBox();
            this.tbGestaoTorneios = new System.Windows.Forms.TabPage();
            this.gbGJogosDados = new System.Windows.Forms.GroupBox();
            this.btnCancelarJogo = new System.Windows.Forms.Button();
            this.labPesquisarJogos = new System.Windows.Forms.Label();
            this.txtGJogosPesquisa = new System.Windows.Forms.TextBox();
            this.dgvGJogosLista = new System.Windows.Forms.DataGridView();
            this.btnAlterarJogo = new System.Windows.Forms.Button();
            this.btnInserirJogo = new System.Windows.Forms.Button();
            this.btnRemoverJogo = new System.Windows.Forms.Button();
            this.gbGTorneiosDados = new System.Windows.Forms.GroupBox();
            this.btngerirjogos = new System.Windows.Forms.Button();
            this.radioStandardTournaments = new System.Windows.Forms.RadioButton();
            this.radioTeamTournaments = new System.Windows.Forms.RadioButton();
            this.labPesquisarTorneio = new System.Windows.Forms.Label();
            this.txtGTorneiosPesquisa = new System.Windows.Forms.TextBox();
            this.btnAlterarTorneio = new System.Windows.Forms.Button();
            this.btnInserirTorneio = new System.Windows.Forms.Button();
            this.dgvGTorneiosLista = new System.Windows.Forms.DataGridView();
            this.btnRemoverTorneio = new System.Windows.Forms.Button();
            this.gbGTorneiosInfo = new System.Windows.Forms.GroupBox();
            this.gbGJogosForm = new System.Windows.Forms.GroupBox();
            this.cmbarbitrojogos = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbdecks2 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbdecks1 = new System.Windows.Forms.ComboBox();
            this.groupBoxEquipasJogos = new System.Windows.Forms.GroupBox();
            this.cmbequipajogador1 = new System.Windows.Forms.ComboBox();
            this.labVS = new System.Windows.Forms.Label();
            this.cmbequipajogador2 = new System.Windows.Forms.ComboBox();
            this.btnJogoCancelar = new System.Windows.Forms.Button();
            this.btnJogoAcao = new System.Windows.Forms.Button();
            this.nudNJogo = new System.Windows.Forms.NumericUpDown();
            this.labNumJogo = new System.Windows.Forms.Label();
            this.tpDataJogos = new System.Windows.Forms.DateTimePicker();
            this.labData = new System.Windows.Forms.Label();
            this.txtDescricaoJogo = new System.Windows.Forms.TextBox();
            this.labDescricao = new System.Windows.Forms.Label();
            this.gbGTorneiosForm = new System.Windows.Forms.GroupBox();
            this.gbTipoTorneio = new System.Windows.Forms.GroupBox();
            this.radioTipoTorneioTeam = new System.Windows.Forms.RadioButton();
            this.radioTipoTorneioStandard = new System.Windows.Forms.RadioButton();
            this.txtTorneioCancelar = new System.Windows.Forms.Button();
            this.txtTorneioAcao = new System.Windows.Forms.Button();
            this.txtDescricaoTorneio = new System.Windows.Forms.TextBox();
            this.tpDataTorneio = new System.Windows.Forms.DateTimePicker();
            this.txtNomeTorneio = new System.Windows.Forms.TextBox();
            this.labDescricaoJogo = new System.Windows.Forms.Label();
            this.labDataJogo = new System.Windows.Forms.Label();
            this.labNomeJogo = new System.Windows.Forms.Label();
            this.tbGestaoCartas = new System.Windows.Forms.TabPage();
            this.gbGCartasForm = new System.Windows.Forms.GroupBox();
            this.btnCartaCancelar = new System.Windows.Forms.Button();
            this.btnAcaoCarta = new System.Windows.Forms.Button();
            this.nudGDefesaCarta = new System.Windows.Forms.NumericUpDown();
            this.nudGAtaqueCarta = new System.Windows.Forms.NumericUpDown();
            this.txtGRegrasCarta = new System.Windows.Forms.TextBox();
            this.nudGLealdadeCarta = new System.Windows.Forms.NumericUpDown();
            this.txtGCustoCarta = new System.Windows.Forms.TextBox();
            this.cmbGTipoCarta = new System.Windows.Forms.ComboBox();
            this.cmbFacaoCarta = new System.Windows.Forms.ComboBox();
            this.txtGNomeCarta = new System.Windows.Forms.TextBox();
            this.labDefesa = new System.Windows.Forms.Label();
            this.labAtaque = new System.Windows.Forms.Label();
            this.labRegras = new System.Windows.Forms.Label();
            this.labLealdade = new System.Windows.Forms.Label();
            this.labCusto = new System.Windows.Forms.Label();
            this.labTipo = new System.Windows.Forms.Label();
            this.labFacao = new System.Windows.Forms.Label();
            this.labNomeCarta = new System.Windows.Forms.Label();
            this.gbGCartasDados = new System.Windows.Forms.GroupBox();
            this.btnImportarCartas = new System.Windows.Forms.Button();
            this.btnRemoverCarta = new System.Windows.Forms.Button();
            this.btnAlterarCarta = new System.Windows.Forms.Button();
            this.btnInserirCarta = new System.Windows.Forms.Button();
            this.dgvGCartasLista = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loyaltyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruleTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_DA_ProjetoDataSet_Cards = new Projeto.BD_DA_ProjetoDataSet_Cards();
            this.labPesquisarCarta = new System.Windows.Forms.Label();
            this.txtGCartasPesquisa = new System.Windows.Forms.TextBox();
            this.tbGestaoBaralhos = new System.Windows.Forms.TabPage();
            this.panelGestaoBaralho = new System.Windows.Forms.TableLayoutPanel();
            this.gbGCartasBotoes = new System.Windows.Forms.GroupBox();
            this.lblNCartasNoBaralho = new System.Windows.Forms.Label();
            this.btnRemoverCartaBaralho = new System.Windows.Forms.Button();
            this.btnAdicionarCartaBaralho = new System.Windows.Forms.Button();
            this.lblNCartasTotais = new System.Windows.Forms.Label();
            this.btnCancelarAltBaralho = new System.Windows.Forms.Button();
            this.btnGuardarAltBaralho = new System.Windows.Forms.Button();
            this.gbGCartasnoBaralho = new System.Windows.Forms.GroupBox();
            this.lvCartasBaralho = new System.Windows.Forms.ListView();
            this.chCarta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbGListaDeCartas = new System.Windows.Forms.GroupBox();
            this.lvListaCartas = new System.Windows.Forms.ListView();
            this.cCarta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cQtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbGBaralhosDados = new System.Windows.Forms.GroupBox();
            this.gbGBaralhosForm = new System.Windows.Forms.GroupBox();
            this.labNomeBaralho = new System.Windows.Forms.Label();
            this.btnCriarBaralho = new System.Windows.Forms.Button();
            this.btnCancelarNovoBaralho = new System.Windows.Forms.Button();
            this.txtNomeBaralho = new System.Windows.Forms.TextBox();
            this.labPesquisarBaralho = new System.Windows.Forms.Label();
            this.dgvGBaralhosLista = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deckSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_DA_ProjetoDataSet_Decks = new Projeto.BD_DA_ProjetoDataSet_Decks();
            this.btnInserirBaralho = new System.Windows.Forms.Button();
            this.txtGBaralhosPesquisa = new System.Windows.Forms.TextBox();
            this.btnGerirBaralho = new System.Windows.Forms.Button();
            this.btnEliminarBaralho = new System.Windows.Forms.Button();
            this.tbGestaoUtilizadores = new System.Windows.Forms.TabPage();
            this.gbGUtilizadoresDados = new System.Windows.Forms.GroupBox();
            this.radioAdmins = new System.Windows.Forms.RadioButton();
            this.radioArbitros = new System.Windows.Forms.RadioButton();
            this.btnEliminarUtilizador = new System.Windows.Forms.Button();
            this.labPesquisarUtilizador = new System.Windows.Forms.Label();
            this.btnAlterarUtilizador = new System.Windows.Forms.Button();
            this.dgvGUtilizadoresLista = new System.Windows.Forms.DataGridView();
            this.btnInserirUtilizador = new System.Windows.Forms.Button();
            this.txtGUtilizadoresPesquisa = new System.Windows.Forms.TextBox();
            this.gbGAdministradorForm = new System.Windows.Forms.GroupBox();
            this.btnCancelarAdministrador = new System.Windows.Forms.Button();
            this.btnAcaoAdministrador = new System.Windows.Forms.Button();
            this.txtEmailAdministrador = new System.Windows.Forms.TextBox();
            this.txtPasswordAdministrador = new System.Windows.Forms.TextBox();
            this.txtUsernameAdministrador = new System.Windows.Forms.TextBox();
            this.labEmailAdministrador = new System.Windows.Forms.Label();
            this.labPasswordAdministrador = new System.Windows.Forms.Label();
            this.labUsernameAdministrador = new System.Windows.Forms.Label();
            this.gbGArbitroForm = new System.Windows.Forms.GroupBox();
            this.pbAvatarArbitro = new System.Windows.Forms.PictureBox();
            this.labUsernameArbitro = new System.Windows.Forms.Label();
            this.txtUsernameArbitro = new System.Windows.Forms.TextBox();
            this.labPasswordArbitro = new System.Windows.Forms.Label();
            this.txtPasswordArbitro = new System.Windows.Forms.TextBox();
            this.labNomeArbitro = new System.Windows.Forms.Label();
            this.txtNomeArbitro = new System.Windows.Forms.TextBox();
            this.labAvatarArbitro = new System.Windows.Forms.Label();
            this.txtAvatarArbitro = new System.Windows.Forms.TextBox();
            this.btnProcurarAvatar = new System.Windows.Forms.Button();
            this.btnAcaoArbitro = new System.Windows.Forms.Button();
            this.btnCancelarArbitro = new System.Windows.Forms.Button();
            this.tbVer = new System.Windows.Forms.TabPage();
            this.tcVer = new System.Windows.Forms.TabControl();
            this.tbVerJogadores = new System.Windows.Forms.TabPage();
            this.nudIdadeJogador2 = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.txtNicknameJogador2 = new System.Windows.Forms.TextBox();
            this.txtnickname = new System.Windows.Forms.Label();
            this.txtEmailJogador2 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtNomeJogador2 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.dgvGListaJogadoresPesquisa = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicknameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avatarDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbVerEquipas = new System.Windows.Forms.TabPage();
            this.btlimpar = new System.Windows.Forms.Button();
            this.cbnomejogadorpesquisa = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.tbxnomeequipapesquisa = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.dgvGListaEquipasPesquisa = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avatarDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbVerTorneios = new System.Windows.Forms.TabPage();
            this.gbResultadosJogos = new System.Windows.Forms.GroupBox();
            this.dgvResultadosJogos = new System.Windows.Forms.DataGridView();
            this.gbResultadosTorneios = new System.Windows.Forms.GroupBox();
            this.dgvResultadosTorneios = new System.Windows.Forms.DataGridView();
            this.gbPesquisarJogos = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpJogoData = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.nupJogoNumero = new System.Windows.Forms.NumericUpDown();
            this.radioPesquisarJogosStandard = new System.Windows.Forms.RadioButton();
            this.radioPesquisarJogosTeam = new System.Windows.Forms.RadioButton();
            this.btnLimparJogos = new System.Windows.Forms.Button();
            this.txtJogoNome = new System.Windows.Forms.TextBox();
            this.comboJogoArbitro = new System.Windows.Forms.ComboBox();
            this.comboJogoDeck = new System.Windows.Forms.ComboBox();
            this.comboJogoJogadorEquipa = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labJogoJogadorEquipa = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.gbPesquisarTorneios = new System.Windows.Forms.GroupBox();
            this.radioPesquisarTorneiosStandard = new System.Windows.Forms.RadioButton();
            this.radioPesquisarTorneiosTeam = new System.Windows.Forms.RadioButton();
            this.btnLimparTorneios = new System.Windows.Forms.Button();
            this.txtTorneioDescricao = new System.Windows.Forms.TextBox();
            this.txtTorneioNome = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpTorneioData = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.tbVerCartas = new System.Windows.Forms.TabPage();
            this.btnVLimparCartas = new System.Windows.Forms.Button();
            this.nudVDefesaCarta = new System.Windows.Forms.NumericUpDown();
            this.nudVAtaqueCarta = new System.Windows.Forms.NumericUpDown();
            this.nudVLealdadeCarta = new System.Windows.Forms.NumericUpDown();
            this.txtVCustoCarta = new System.Windows.Forms.TextBox();
            this.cmbVTipoCarta = new System.Windows.Forms.ComboBox();
            this.cmbVFacaoCarta = new System.Windows.Forms.ComboBox();
            this.txtVNomeCarta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.dgvVCartasLista = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loyaltyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruleTextDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attackDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defenseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbVerBaralhos = new System.Windows.Forms.TabPage();
            this.dgvVBaralhosLista = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVLimparBaralhos = new System.Windows.Forms.Button();
            this.cmbVCartasnoBaralho = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.txtVNomeBaralho = new System.Windows.Forms.TextBox();
            this.tbVerUtilizadores = new System.Windows.Forms.TabPage();
            this.labPesquisarPor = new System.Windows.Forms.Label();
            this.radioPesquisaAdministrador = new System.Windows.Forms.RadioButton();
            this.radioPesquisaArbitro = new System.Windows.Forms.RadioButton();
            this.labPesquisaUsername = new System.Windows.Forms.Label();
            this.txtPesquisaUsername = new System.Windows.Forms.TextBox();
            this.labPesquisaNomeEmail = new System.Windows.Forms.Label();
            this.txtPesquisaNomeArbitro = new System.Windows.Forms.TextBox();
            this.txtPesquisaEmailAdministrador = new System.Windows.Forms.TextBox();
            this.checkPesquisaArbitroAtivo = new System.Windows.Forms.CheckBox();
            this.btnPesquisarUtilizador = new System.Windows.Forms.Button();
            this.btnResetPesquisa = new System.Windows.Forms.Button();
            this.dgvPesquisaUtilizadores = new System.Windows.Forms.DataGridView();
            this.gameSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_DA_ProjetoDataSet_Games = new Projeto.BD_DA_ProjetoDataSet_Games();
            this.tournamentSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_DA_ProjetoDataSet_Tournaments = new Projeto.BD_DA_ProjetoDataSet_Tournaments();
            this.ofdAvatarArbitro = new System.Windows.Forms.OpenFileDialog();
            this.dataSetAdministradores = new Projeto.BD_DA_ProjetoDataSet_Administradores();
            this.dataSetArbitros = new Projeto.BD_DA_ProjetoDataSet_Arbitros();
            this.bindingSourceAdminstradores = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceArbitros = new System.Windows.Forms.BindingSource(this.components);
            this.userSetTableAdapterAdministradores = new Projeto.BD_DA_ProjetoDataSet_AdministradoresTableAdapters.UserSetTableAdapter();
            this.userSetTableAdapterArbitros = new Projeto.BD_DA_ProjetoDataSet_ArbitrosTableAdapters.UserSetTableAdapter();
            this.cardSetTableAdapter = new Projeto.BD_DA_ProjetoDataSet_CardsTableAdapters.CardSetTableAdapter();
            this.deckSetTableAdapter = new Projeto.BD_DA_ProjetoDataSet_DecksTableAdapters.DeckSetTableAdapter();
            this.teamSetTableAdapter = new Projeto.BD_DA_ProjetoDataSet_TeamsTableAdapters.TeamSetTableAdapter();
            this.playerSetTableAdapter = new Projeto.BD_DA_ProjetoDataSet_PlayersTableAdapters.PlayerSetTableAdapter();
            this.opfProcurarImagem = new System.Windows.Forms.OpenFileDialog();
            this.gameSetTableAdapter = new Projeto.BD_DA_ProjetoDataSet_GamesTableAdapters.GameSetTableAdapter();
            this.tournamentSetTableAdapter = new Projeto.BD_DA_ProjetoDataSet_TournamentsTableAdapters.TournamentSetTableAdapter();
            this.FileDialogImportarCarta = new System.Windows.Forms.OpenFileDialog();
            this.tbMenu.SuspendLayout();
            this.tpGestao.SuspendLayout();
            this.tcGestao.SuspendLayout();
            this.tbGestaoJogadores.SuspendLayout();
            this.gbGJogadoresForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdadeJogador)).BeginInit();
            this.gbGJogadoresDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGListaJogadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DA_ProjetoDataSet_Players)).BeginInit();
            this.tbGestaoEquipas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbGEquipasDados.SuspendLayout();
            this.gbGEquipasForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatarEquipa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGListaEquipas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DA_ProjetoDataSet_Teams)).BeginInit();
            this.tbGestaoTorneios.SuspendLayout();
            this.gbGJogosDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGJogosLista)).BeginInit();
            this.gbGTorneiosDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGTorneiosLista)).BeginInit();
            this.gbGTorneiosInfo.SuspendLayout();
            this.gbGJogosForm.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxEquipasJogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNJogo)).BeginInit();
            this.gbGTorneiosForm.SuspendLayout();
            this.gbTipoTorneio.SuspendLayout();
            this.tbGestaoCartas.SuspendLayout();
            this.gbGCartasForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGDefesaCarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGAtaqueCarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGLealdadeCarta)).BeginInit();
            this.gbGCartasDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGCartasLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DA_ProjetoDataSet_Cards)).BeginInit();
            this.tbGestaoBaralhos.SuspendLayout();
            this.panelGestaoBaralho.SuspendLayout();
            this.gbGCartasBotoes.SuspendLayout();
            this.gbGCartasnoBaralho.SuspendLayout();
            this.gbGListaDeCartas.SuspendLayout();
            this.gbGBaralhosDados.SuspendLayout();
            this.gbGBaralhosForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGBaralhosLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DA_ProjetoDataSet_Decks)).BeginInit();
            this.tbGestaoUtilizadores.SuspendLayout();
            this.gbGUtilizadoresDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGUtilizadoresLista)).BeginInit();
            this.gbGAdministradorForm.SuspendLayout();
            this.gbGArbitroForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarArbitro)).BeginInit();
            this.tbVer.SuspendLayout();
            this.tcVer.SuspendLayout();
            this.tbVerJogadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdadeJogador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGListaJogadoresPesquisa)).BeginInit();
            this.tbVerEquipas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGListaEquipasPesquisa)).BeginInit();
            this.tbVerTorneios.SuspendLayout();
            this.gbResultadosJogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosJogos)).BeginInit();
            this.gbResultadosTorneios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosTorneios)).BeginInit();
            this.gbPesquisarJogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupJogoNumero)).BeginInit();
            this.gbPesquisarTorneios.SuspendLayout();
            this.tbVerCartas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVDefesaCarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVAtaqueCarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVLealdadeCarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVCartasLista)).BeginInit();
            this.tbVerBaralhos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVBaralhosLista)).BeginInit();
            this.tbVerUtilizadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaUtilizadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DA_ProjetoDataSet_Games)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DA_ProjetoDataSet_Tournaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAdministradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetArbitros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAdminstradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArbitros)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Controls.Add(this.tpGestao);
            this.tbMenu.Controls.Add(this.tbVer);
            this.tbMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMenu.Location = new System.Drawing.Point(0, 0);
            this.tbMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 0;
            this.tbMenu.Size = new System.Drawing.Size(1059, 546);
            this.tbMenu.TabIndex = 0;
            // 
            // tpGestao
            // 
            this.tpGestao.Controls.Add(this.tcGestao);
            this.tpGestao.Location = new System.Drawing.Point(4, 25);
            this.tpGestao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpGestao.Name = "tpGestao";
            this.tpGestao.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpGestao.Size = new System.Drawing.Size(1051, 517);
            this.tpGestao.TabIndex = 0;
            this.tpGestao.Text = "Gestão";
            this.tpGestao.UseVisualStyleBackColor = true;
            // 
            // tcGestao
            // 
            this.tcGestao.Controls.Add(this.tbGestaoJogadores);
            this.tcGestao.Controls.Add(this.tbGestaoEquipas);
            this.tcGestao.Controls.Add(this.tbGestaoTorneios);
            this.tcGestao.Controls.Add(this.tbGestaoCartas);
            this.tcGestao.Controls.Add(this.tbGestaoBaralhos);
            this.tcGestao.Controls.Add(this.tbGestaoUtilizadores);
            this.tcGestao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcGestao.Location = new System.Drawing.Point(3, 2);
            this.tcGestao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcGestao.Name = "tcGestao";
            this.tcGestao.SelectedIndex = 0;
            this.tcGestao.Size = new System.Drawing.Size(1045, 513);
            this.tcGestao.TabIndex = 0;
            // 
            // tbGestaoJogadores
            // 
            this.tbGestaoJogadores.Controls.Add(this.gbGJogadoresForm);
            this.tbGestaoJogadores.Controls.Add(this.gbGJogadoresDados);
            this.tbGestaoJogadores.Location = new System.Drawing.Point(4, 25);
            this.tbGestaoJogadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGestaoJogadores.Name = "tbGestaoJogadores";
            this.tbGestaoJogadores.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGestaoJogadores.Size = new System.Drawing.Size(1037, 484);
            this.tbGestaoJogadores.TabIndex = 0;
            this.tbGestaoJogadores.Text = "Jogadores";
            this.tbGestaoJogadores.UseVisualStyleBackColor = true;
            // 
            // gbGJogadoresForm
            // 
            this.gbGJogadoresForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGJogadoresForm.Controls.Add(this.pictureBox1);
            this.gbGJogadoresForm.Controls.Add(this.btImagem);
            this.gbGJogadoresForm.Controls.Add(this.txtAvatar);
            this.gbGJogadoresForm.Controls.Add(this.label36);
            this.gbGJogadoresForm.Controls.Add(this.btnJogadoresCancelar);
            this.gbGJogadoresForm.Controls.Add(this.btnJogadoresAcao);
            this.gbGJogadoresForm.Controls.Add(this.nudIdadeJogador);
            this.gbGJogadoresForm.Controls.Add(this.txtNickJogador);
            this.gbGJogadoresForm.Controls.Add(this.txtEmailJogador);
            this.gbGJogadoresForm.Controls.Add(this.txtNomeJogador);
            this.gbGJogadoresForm.Controls.Add(this.label5);
            this.gbGJogadoresForm.Controls.Add(this.label4);
            this.gbGJogadoresForm.Controls.Add(this.label3);
            this.gbGJogadoresForm.Controls.Add(this.label2);
            this.gbGJogadoresForm.Enabled = false;
            this.gbGJogadoresForm.Location = new System.Drawing.Point(667, 5);
            this.gbGJogadoresForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGJogadoresForm.Name = "gbGJogadoresForm";
            this.gbGJogadoresForm.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGJogadoresForm.Size = new System.Drawing.Size(364, 467);
            this.gbGJogadoresForm.TabIndex = 7;
            this.gbGJogadoresForm.TabStop = false;
            this.gbGJogadoresForm.Text = "Campos";
            this.gbGJogadoresForm.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(95, 230);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btImagem
            // 
            this.btImagem.Location = new System.Drawing.Point(276, 197);
            this.btImagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btImagem.Name = "btImagem";
            this.btImagem.Size = new System.Drawing.Size(47, 28);
            this.btImagem.TabIndex = 12;
            this.btImagem.Text = "Q";
            this.btImagem.UseVisualStyleBackColor = true;
            this.btImagem.Click += new System.EventHandler(this.btImagem_Click);
            // 
            // txtAvatar
            // 
            this.txtAvatar.Location = new System.Drawing.Point(95, 199);
            this.txtAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAvatar.Name = "txtAvatar";
            this.txtAvatar.ReadOnly = true;
            this.txtAvatar.Size = new System.Drawing.Size(168, 22);
            this.txtAvatar.TabIndex = 11;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(23, 203);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(49, 17);
            this.label36.TabIndex = 10;
            this.label36.Text = "Avatar";
            // 
            // btnJogadoresCancelar
            // 
            this.btnJogadoresCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJogadoresCancelar.Location = new System.Drawing.Point(257, 417);
            this.btnJogadoresCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogadoresCancelar.Name = "btnJogadoresCancelar";
            this.btnJogadoresCancelar.Size = new System.Drawing.Size(83, 26);
            this.btnJogadoresCancelar.TabIndex = 9;
            this.btnJogadoresCancelar.Text = "Cancelar";
            this.btnJogadoresCancelar.UseVisualStyleBackColor = true;
            this.btnJogadoresCancelar.Click += new System.EventHandler(this.btnJogadoresCancelar_Click);
            // 
            // btnJogadoresAcao
            // 
            this.btnJogadoresAcao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJogadoresAcao.Location = new System.Drawing.Point(177, 417);
            this.btnJogadoresAcao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogadoresAcao.Name = "btnJogadoresAcao";
            this.btnJogadoresAcao.Size = new System.Drawing.Size(75, 26);
            this.btnJogadoresAcao.TabIndex = 8;
            this.btnJogadoresAcao.Text = "Ação";
            this.btnJogadoresAcao.UseVisualStyleBackColor = true;
            this.btnJogadoresAcao.Click += new System.EventHandler(this.btnJogadoresAcao_Click);
            // 
            // nudIdadeJogador
            // 
            this.nudIdadeJogador.Location = new System.Drawing.Point(97, 160);
            this.nudIdadeJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudIdadeJogador.Name = "nudIdadeJogador";
            this.nudIdadeJogador.Size = new System.Drawing.Size(53, 22);
            this.nudIdadeJogador.TabIndex = 7;
            // 
            // txtNickJogador
            // 
            this.txtNickJogador.Location = new System.Drawing.Point(97, 118);
            this.txtNickJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNickJogador.Name = "txtNickJogador";
            this.txtNickJogador.Size = new System.Drawing.Size(205, 22);
            this.txtNickJogador.TabIndex = 6;
            // 
            // txtEmailJogador
            // 
            this.txtEmailJogador.Location = new System.Drawing.Point(97, 78);
            this.txtEmailJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailJogador.Name = "txtEmailJogador";
            this.txtEmailJogador.Size = new System.Drawing.Size(205, 22);
            this.txtEmailJogador.TabIndex = 5;
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(97, 34);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(205, 22);
            this.txtNomeJogador.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nickname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // gbGJogadoresDados
            // 
            this.gbGJogadoresDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbGJogadoresDados.Controls.Add(this.btnRemoverJogador);
            this.gbGJogadoresDados.Controls.Add(this.label1);
            this.gbGJogadoresDados.Controls.Add(this.btnAlterarJogador);
            this.gbGJogadoresDados.Controls.Add(this.dgvGListaJogadores);
            this.gbGJogadoresDados.Controls.Add(this.btnInserirJogador);
            this.gbGJogadoresDados.Controls.Add(this.txtGJogadoresPesquisa);
            this.gbGJogadoresDados.Location = new System.Drawing.Point(5, -9);
            this.gbGJogadoresDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGJogadoresDados.MaximumSize = new System.Drawing.Size(656, 481);
            this.gbGJogadoresDados.MinimumSize = new System.Drawing.Size(656, 481);
            this.gbGJogadoresDados.Name = "gbGJogadoresDados";
            this.gbGJogadoresDados.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGJogadoresDados.Size = new System.Drawing.Size(656, 481);
            this.gbGJogadoresDados.TabIndex = 6;
            this.gbGJogadoresDados.TabStop = false;
            this.gbGJogadoresDados.Text = "Jogadores";
            // 
            // btnRemoverJogador
            // 
            this.btnRemoverJogador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverJogador.Enabled = false;
            this.btnRemoverJogador.Location = new System.Drawing.Point(543, 448);
            this.btnRemoverJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoverJogador.Name = "btnRemoverJogador";
            this.btnRemoverJogador.Size = new System.Drawing.Size(83, 30);
            this.btnRemoverJogador.TabIndex = 2;
            this.btnRemoverJogador.Text = "Eliminar";
            this.btnRemoverJogador.UseVisualStyleBackColor = true;
            this.btnRemoverJogador.Click += new System.EventHandler(this.btnRemoverJogador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquise:";
            // 
            // btnAlterarJogador
            // 
            this.btnAlterarJogador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterarJogador.Enabled = false;
            this.btnAlterarJogador.Location = new System.Drawing.Point(460, 448);
            this.btnAlterarJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterarJogador.Name = "btnAlterarJogador";
            this.btnAlterarJogador.Size = new System.Drawing.Size(77, 30);
            this.btnAlterarJogador.TabIndex = 1;
            this.btnAlterarJogador.Text = "Alterar";
            this.btnAlterarJogador.UseVisualStyleBackColor = true;
            this.btnAlterarJogador.Click += new System.EventHandler(this.btnAlterarJogador_Click);
            // 
            // dgvGListaJogadores
            // 
            this.dgvGListaJogadores.AllowUserToAddRows = false;
            this.dgvGListaJogadores.AllowUserToDeleteRows = false;
            this.dgvGListaJogadores.AutoGenerateColumns = false;
            this.dgvGListaJogadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGListaJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGListaJogadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn5,
            this.nameDataGridViewTextBoxColumn5,
            this.emailDataGridViewTextBoxColumn,
            this.nicknameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.avatarDataGridViewTextBoxColumn});
            this.dgvGListaJogadores.DataSource = this.playerSetBindingSource;
            this.dgvGListaJogadores.Location = new System.Drawing.Point(25, 94);
            this.dgvGListaJogadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGListaJogadores.Name = "dgvGListaJogadores";
            this.dgvGListaJogadores.ReadOnly = true;
            this.dgvGListaJogadores.RowHeadersVisible = false;
            this.dgvGListaJogadores.RowTemplate.Height = 24;
            this.dgvGListaJogadores.Size = new System.Drawing.Size(600, 313);
            this.dgvGListaJogadores.TabIndex = 0;
            this.dgvGListaJogadores.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGListaJogadores_CellMouseClick);
            // 
            // idDataGridViewTextBoxColumn5
            // 
            this.idDataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn5.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn5.Name = "idDataGridViewTextBoxColumn5";
            this.idDataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn5
            // 
            this.nameDataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn5.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn5.Name = "nameDataGridViewTextBoxColumn5";
            this.nameDataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nicknameDataGridViewTextBoxColumn
            // 
            this.nicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.HeaderText = "Nickname";
            this.nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
            this.nicknameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // avatarDataGridViewTextBoxColumn
            // 
            this.avatarDataGridViewTextBoxColumn.DataPropertyName = "Avatar";
            this.avatarDataGridViewTextBoxColumn.HeaderText = "Avatar";
            this.avatarDataGridViewTextBoxColumn.Name = "avatarDataGridViewTextBoxColumn";
            this.avatarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerSetBindingSource
            // 
            this.playerSetBindingSource.DataMember = "PlayerSet";
            this.playerSetBindingSource.DataSource = this.bD_DA_ProjetoDataSet_Players;
            // 
            // bD_DA_ProjetoDataSet_Players
            // 
            this.bD_DA_ProjetoDataSet_Players.DataSetName = "BD_DA_ProjetoDataSet_Players";
            this.bD_DA_ProjetoDataSet_Players.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnInserirJogador
            // 
            this.btnInserirJogador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInserirJogador.Location = new System.Drawing.Point(371, 448);
            this.btnInserirJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserirJogador.Name = "btnInserirJogador";
            this.btnInserirJogador.Size = new System.Drawing.Size(83, 30);
            this.btnInserirJogador.TabIndex = 0;
            this.btnInserirJogador.Text = "Inserir";
            this.btnInserirJogador.UseVisualStyleBackColor = true;
            this.btnInserirJogador.Click += new System.EventHandler(this.btnInserirJogador_Click);
            // 
            // txtGJogadoresPesquisa
            // 
            this.txtGJogadoresPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGJogadoresPesquisa.Location = new System.Drawing.Point(99, 43);
            this.txtGJogadoresPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGJogadoresPesquisa.Name = "txtGJogadoresPesquisa";
            this.txtGJogadoresPesquisa.Size = new System.Drawing.Size(435, 22);
            this.txtGJogadoresPesquisa.TabIndex = 1;
            this.txtGJogadoresPesquisa.TextChanged += new System.EventHandler(this.txtGJogadoresPesquisa_TextChanged);
            // 
            // tbGestaoEquipas
            // 
            this.tbGestaoEquipas.Controls.Add(this.groupBox1);
            this.tbGestaoEquipas.Controls.Add(this.btnGuardarJogadorEquipa);
            this.tbGestaoEquipas.Controls.Add(this.btnRetirarJogador);
            this.tbGestaoEquipas.Controls.Add(this.btnAdicionarJogador);
            this.tbGestaoEquipas.Controls.Add(this.groupBox2);
            this.tbGestaoEquipas.Controls.Add(this.gbGEquipasDados);
            this.tbGestaoEquipas.Location = new System.Drawing.Point(4, 25);
            this.tbGestaoEquipas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGestaoEquipas.Name = "tbGestaoEquipas";
            this.tbGestaoEquipas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGestaoEquipas.Size = new System.Drawing.Size(1037, 492);
            this.tbGestaoEquipas.TabIndex = 1;
            this.tbGestaoEquipas.Text = "Equipas";
            this.tbGestaoEquipas.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvJogadoresEquipa);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(5, 281);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(380, 198);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jogadores na Equipa";
            // 
            // lvJogadoresEquipa
            // 
            this.lvJogadoresEquipa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cNome,
            this.cEmail,
            this.cIdade,
            this.cNickname});
            this.lvJogadoresEquipa.FullRowSelect = true;
            this.lvJogadoresEquipa.Location = new System.Drawing.Point(5, 18);
            this.lvJogadoresEquipa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvJogadoresEquipa.Name = "lvJogadoresEquipa";
            this.lvJogadoresEquipa.Size = new System.Drawing.Size(368, 174);
            this.lvJogadoresEquipa.TabIndex = 3;
            this.lvJogadoresEquipa.UseCompatibleStateImageBehavior = false;
            this.lvJogadoresEquipa.View = System.Windows.Forms.View.Details;
            // 
            // cNome
            // 
            this.cNome.Text = "Nome";
            // 
            // cEmail
            // 
            this.cEmail.Text = "Email";
            // 
            // cIdade
            // 
            this.cIdade.Text = "Idade";
            // 
            // cNickname
            // 
            this.cNickname.Text = "Nickname";
            // 
            // btnGuardarJogadorEquipa
            // 
            this.btnGuardarJogadorEquipa.Enabled = false;
            this.btnGuardarJogadorEquipa.Location = new System.Drawing.Point(464, 420);
            this.btnGuardarJogadorEquipa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarJogadorEquipa.Name = "btnGuardarJogadorEquipa";
            this.btnGuardarJogadorEquipa.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarJogadorEquipa.TabIndex = 15;
            this.btnGuardarJogadorEquipa.Text = "Guardar";
            this.btnGuardarJogadorEquipa.UseVisualStyleBackColor = true;
            this.btnGuardarJogadorEquipa.Click += new System.EventHandler(this.btnGuardarJogadorEquipa_Click);
            // 
            // btnRetirarJogador
            // 
            this.btnRetirarJogador.Enabled = false;
            this.btnRetirarJogador.Location = new System.Drawing.Point(464, 350);
            this.btnRetirarJogador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRetirarJogador.Name = "btnRetirarJogador";
            this.btnRetirarJogador.Size = new System.Drawing.Size(100, 28);
            this.btnRetirarJogador.TabIndex = 14;
            this.btnRetirarJogador.Text = ">>";
            this.btnRetirarJogador.UseVisualStyleBackColor = true;
            this.btnRetirarJogador.Click += new System.EventHandler(this.btnRetirarJogador_Click);
            // 
            // btnAdicionarJogador
            // 
            this.btnAdicionarJogador.Enabled = false;
            this.btnAdicionarJogador.Location = new System.Drawing.Point(464, 314);
            this.btnAdicionarJogador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionarJogador.Name = "btnAdicionarJogador";
            this.btnAdicionarJogador.Size = new System.Drawing.Size(100, 28);
            this.btnAdicionarJogador.TabIndex = 13;
            this.btnAdicionarJogador.Text = "<<";
            this.btnAdicionarJogador.UseVisualStyleBackColor = true;
            this.btnAdicionarJogador.Click += new System.EventHandler(this.btnAdicionarJogador_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lcListaJogadores);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(645, 281);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(377, 203);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Jogadores";
            // 
            // lcListaJogadores
            // 
            this.lcListaJogadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cNome1,
            this.cEmail2,
            this.cIdade2,
            this.cNickname2});
            this.lcListaJogadores.FullRowSelect = true;
            this.lcListaJogadores.Location = new System.Drawing.Point(5, 21);
            this.lcListaJogadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lcListaJogadores.Name = "lcListaJogadores";
            this.lcListaJogadores.Size = new System.Drawing.Size(365, 176);
            this.lcListaJogadores.TabIndex = 0;
            this.lcListaJogadores.UseCompatibleStateImageBehavior = false;
            this.lcListaJogadores.View = System.Windows.Forms.View.Details;
            // 
            // cNome1
            // 
            this.cNome1.Text = "Nome";
            // 
            // cEmail2
            // 
            this.cEmail2.Text = "Email";
            // 
            // cIdade2
            // 
            this.cIdade2.Text = "Idade";
            // 
            // cNickname2
            // 
            this.cNickname2.Text = "Nickname";
            // 
            // gbGEquipasDados
            // 
            this.gbGEquipasDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGEquipasDados.Controls.Add(this.btnGerirEquipa);
            this.gbGEquipasDados.Controls.Add(this.gbGEquipasForm);
            this.gbGEquipasDados.Controls.Add(this.btnRemoverEquipa);
            this.gbGEquipasDados.Controls.Add(this.btnAlterarEquipa);
            this.gbGEquipasDados.Controls.Add(this.label6);
            this.gbGEquipasDados.Controls.Add(this.btnInserirEquipa);
            this.gbGEquipasDados.Controls.Add(this.dgvGListaEquipas);
            this.gbGEquipasDados.Controls.Add(this.txtGEquipasPesquisa);
            this.gbGEquipasDados.Location = new System.Drawing.Point(5, 5);
            this.gbGEquipasDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGEquipasDados.Name = "gbGEquipasDados";
            this.gbGEquipasDados.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGEquipasDados.Size = new System.Drawing.Size(1024, 267);
            this.gbGEquipasDados.TabIndex = 12;
            this.gbGEquipasDados.TabStop = false;
            this.gbGEquipasDados.Text = "Equipas";
            // 
            // btnGerirEquipa
            // 
            this.btnGerirEquipa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerirEquipa.Enabled = false;
            this.btnGerirEquipa.Location = new System.Drawing.Point(568, 164);
            this.btnGerirEquipa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGerirEquipa.Name = "btnGerirEquipa";
            this.btnGerirEquipa.Size = new System.Drawing.Size(83, 28);
            this.btnGerirEquipa.TabIndex = 7;
            this.btnGerirEquipa.Text = "Gerir";
            this.btnGerirEquipa.UseVisualStyleBackColor = true;
            this.btnGerirEquipa.Click += new System.EventHandler(this.btnGerirEquipa_Click);
            // 
            // gbGEquipasForm
            // 
            this.gbGEquipasForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGEquipasForm.Controls.Add(this.pictureBoxAvatarEquipa);
            this.gbGEquipasForm.Controls.Add(this.btnAvatarEquipa);
            this.gbGEquipasForm.Controls.Add(this.btnEquipaCancelar);
            this.gbGEquipasForm.Controls.Add(this.btnEquipaAcao);
            this.gbGEquipasForm.Controls.Add(this.txtGAvatarEquipa);
            this.gbGEquipasForm.Controls.Add(this.txtGNomeEquipa);
            this.gbGEquipasForm.Controls.Add(this.label8);
            this.gbGEquipasForm.Controls.Add(this.label7);
            this.gbGEquipasForm.Enabled = false;
            this.gbGEquipasForm.Location = new System.Drawing.Point(692, 21);
            this.gbGEquipasForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGEquipasForm.Name = "gbGEquipasForm";
            this.gbGEquipasForm.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGEquipasForm.Size = new System.Drawing.Size(325, 241);
            this.gbGEquipasForm.TabIndex = 6;
            this.gbGEquipasForm.TabStop = false;
            this.gbGEquipasForm.Text = "Campos";
            this.gbGEquipasForm.Visible = false;
            // 
            // pictureBoxAvatarEquipa
            // 
            this.pictureBoxAvatarEquipa.Location = new System.Drawing.Point(75, 90);
            this.pictureBoxAvatarEquipa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxAvatarEquipa.Name = "pictureBoxAvatarEquipa";
            this.pictureBoxAvatarEquipa.Size = new System.Drawing.Size(93, 86);
            this.pictureBoxAvatarEquipa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatarEquipa.TabIndex = 13;
            this.pictureBoxAvatarEquipa.TabStop = false;
            // 
            // btnAvatarEquipa
            // 
            this.btnAvatarEquipa.Location = new System.Drawing.Point(272, 54);
            this.btnAvatarEquipa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAvatarEquipa.Name = "btnAvatarEquipa";
            this.btnAvatarEquipa.Size = new System.Drawing.Size(27, 23);
            this.btnAvatarEquipa.TabIndex = 12;
            this.btnAvatarEquipa.Text = "Q";
            this.btnAvatarEquipa.UseVisualStyleBackColor = true;
            this.btnAvatarEquipa.Click += new System.EventHandler(this.btnAvatarEquipa_Click);
            // 
            // btnEquipaCancelar
            // 
            this.btnEquipaCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEquipaCancelar.Location = new System.Drawing.Point(219, 191);
            this.btnEquipaCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEquipaCancelar.Name = "btnEquipaCancelar";
            this.btnEquipaCancelar.Size = new System.Drawing.Size(83, 26);
            this.btnEquipaCancelar.TabIndex = 11;
            this.btnEquipaCancelar.Text = "Cancelar";
            this.btnEquipaCancelar.UseVisualStyleBackColor = true;
            this.btnEquipaCancelar.Click += new System.EventHandler(this.btnEquipaCancelar_Click);
            // 
            // btnEquipaAcao
            // 
            this.btnEquipaAcao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEquipaAcao.Location = new System.Drawing.Point(139, 191);
            this.btnEquipaAcao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEquipaAcao.Name = "btnEquipaAcao";
            this.btnEquipaAcao.Size = new System.Drawing.Size(75, 26);
            this.btnEquipaAcao.TabIndex = 10;
            this.btnEquipaAcao.Text = "Ação";
            this.btnEquipaAcao.UseVisualStyleBackColor = true;
            this.btnEquipaAcao.Click += new System.EventHandler(this.btnEquipaAcao_Click);
            // 
            // txtGAvatarEquipa
            // 
            this.txtGAvatarEquipa.Enabled = false;
            this.txtGAvatarEquipa.Location = new System.Drawing.Point(75, 53);
            this.txtGAvatarEquipa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGAvatarEquipa.Name = "txtGAvatarEquipa";
            this.txtGAvatarEquipa.ReadOnly = true;
            this.txtGAvatarEquipa.Size = new System.Drawing.Size(191, 22);
            this.txtGAvatarEquipa.TabIndex = 4;
            // 
            // txtGNomeEquipa
            // 
            this.txtGNomeEquipa.Location = new System.Drawing.Point(75, 21);
            this.txtGNomeEquipa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGNomeEquipa.Name = "txtGNomeEquipa";
            this.txtGNomeEquipa.Size = new System.Drawing.Size(196, 22);
            this.txtGNomeEquipa.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Avatar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nome";
            // 
            // btnRemoverEquipa
            // 
            this.btnRemoverEquipa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverEquipa.Enabled = false;
            this.btnRemoverEquipa.Location = new System.Drawing.Point(568, 201);
            this.btnRemoverEquipa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoverEquipa.Name = "btnRemoverEquipa";
            this.btnRemoverEquipa.Size = new System.Drawing.Size(83, 30);
            this.btnRemoverEquipa.TabIndex = 2;
            this.btnRemoverEquipa.Text = "Eliminar";
            this.btnRemoverEquipa.UseVisualStyleBackColor = true;
            this.btnRemoverEquipa.Click += new System.EventHandler(this.btnRemoverEquipa_Click);
            // 
            // btnAlterarEquipa
            // 
            this.btnAlterarEquipa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterarEquipa.Enabled = false;
            this.btnAlterarEquipa.Location = new System.Drawing.Point(568, 129);
            this.btnAlterarEquipa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterarEquipa.Name = "btnAlterarEquipa";
            this.btnAlterarEquipa.Size = new System.Drawing.Size(83, 30);
            this.btnAlterarEquipa.TabIndex = 1;
            this.btnAlterarEquipa.Text = "Alterar";
            this.btnAlterarEquipa.UseVisualStyleBackColor = true;
            this.btnAlterarEquipa.Click += new System.EventHandler(this.btnAlterarEquipa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pesquise:";
            // 
            // btnInserirEquipa
            // 
            this.btnInserirEquipa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInserirEquipa.Location = new System.Drawing.Point(568, 95);
            this.btnInserirEquipa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserirEquipa.Name = "btnInserirEquipa";
            this.btnInserirEquipa.Size = new System.Drawing.Size(83, 30);
            this.btnInserirEquipa.TabIndex = 0;
            this.btnInserirEquipa.Text = "Inserir";
            this.btnInserirEquipa.UseVisualStyleBackColor = true;
            this.btnInserirEquipa.Click += new System.EventHandler(this.btnInserirEquipa_Click);
            // 
            // dgvGListaEquipas
            // 
            this.dgvGListaEquipas.AllowUserToAddRows = false;
            this.dgvGListaEquipas.AllowUserToDeleteRows = false;
            this.dgvGListaEquipas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGListaEquipas.AutoGenerateColumns = false;
            this.dgvGListaEquipas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGListaEquipas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGListaEquipas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn4,
            this.nameDataGridViewTextBoxColumn4,
            this.avatarDataGridViewTextBoxColumn1});
            this.dgvGListaEquipas.DataSource = this.teamSetBindingSource;
            this.dgvGListaEquipas.Location = new System.Drawing.Point(25, 70);
            this.dgvGListaEquipas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGListaEquipas.Name = "dgvGListaEquipas";
            this.dgvGListaEquipas.ReadOnly = true;
            this.dgvGListaEquipas.RowHeadersVisible = false;
            this.dgvGListaEquipas.RowTemplate.Height = 24;
            this.dgvGListaEquipas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGListaEquipas.Size = new System.Drawing.Size(500, 167);
            this.dgvGListaEquipas.TabIndex = 3;
            this.dgvGListaEquipas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGListaEquipas_CellMouseClick);
            // 
            // idDataGridViewTextBoxColumn4
            // 
            this.idDataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn4.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
            this.idDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn4
            // 
            this.nameDataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn4.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn4.Name = "nameDataGridViewTextBoxColumn4";
            this.nameDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // avatarDataGridViewTextBoxColumn1
            // 
            this.avatarDataGridViewTextBoxColumn1.DataPropertyName = "Avatar";
            this.avatarDataGridViewTextBoxColumn1.HeaderText = "Avatar";
            this.avatarDataGridViewTextBoxColumn1.Name = "avatarDataGridViewTextBoxColumn1";
            this.avatarDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // teamSetBindingSource
            // 
            this.teamSetBindingSource.DataMember = "TeamSet";
            this.teamSetBindingSource.DataSource = this.bD_DA_ProjetoDataSet_Teams;
            // 
            // bD_DA_ProjetoDataSet_Teams
            // 
            this.bD_DA_ProjetoDataSet_Teams.DataSetName = "BD_DA_ProjetoDataSet_Teams";
            this.bD_DA_ProjetoDataSet_Teams.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtGEquipasPesquisa
            // 
            this.txtGEquipasPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGEquipasPesquisa.Location = new System.Drawing.Point(97, 27);
            this.txtGEquipasPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGEquipasPesquisa.Name = "txtGEquipasPesquisa";
            this.txtGEquipasPesquisa.Size = new System.Drawing.Size(391, 22);
            this.txtGEquipasPesquisa.TabIndex = 4;
            this.txtGEquipasPesquisa.TextChanged += new System.EventHandler(this.txtGEquipasPesquisa_TextChanged);
            // 
            // tbGestaoTorneios
            // 
            this.tbGestaoTorneios.Controls.Add(this.gbGJogosDados);
            this.tbGestaoTorneios.Controls.Add(this.gbGTorneiosDados);
            this.tbGestaoTorneios.Controls.Add(this.gbGTorneiosInfo);
            this.tbGestaoTorneios.Location = new System.Drawing.Point(4, 25);
            this.tbGestaoTorneios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGestaoTorneios.Name = "tbGestaoTorneios";
            this.tbGestaoTorneios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGestaoTorneios.Size = new System.Drawing.Size(1037, 492);
            this.tbGestaoTorneios.TabIndex = 2;
            this.tbGestaoTorneios.Text = "Torneios";
            this.tbGestaoTorneios.UseVisualStyleBackColor = true;
            // 
            // gbGJogosDados
            // 
            this.gbGJogosDados.Controls.Add(this.btnCancelarJogo);
            this.gbGJogosDados.Controls.Add(this.labPesquisarJogos);
            this.gbGJogosDados.Controls.Add(this.txtGJogosPesquisa);
            this.gbGJogosDados.Controls.Add(this.dgvGJogosLista);
            this.gbGJogosDados.Controls.Add(this.btnAlterarJogo);
            this.gbGJogosDados.Controls.Add(this.btnInserirJogo);
            this.gbGJogosDados.Controls.Add(this.btnRemoverJogo);
            this.gbGJogosDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGJogosDados.Enabled = false;
            this.gbGJogosDados.Location = new System.Drawing.Point(3, 249);
            this.gbGJogosDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGJogosDados.Name = "gbGJogosDados";
            this.gbGJogosDados.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGJogosDados.Size = new System.Drawing.Size(582, 241);
            this.gbGJogosDados.TabIndex = 1;
            this.gbGJogosDados.TabStop = false;
            this.gbGJogosDados.Text = "Jogos";
            // 
            // btnCancelarJogo
            // 
            this.btnCancelarJogo.Location = new System.Drawing.Point(27, 203);
            this.btnCancelarJogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarJogo.Name = "btnCancelarJogo";
            this.btnCancelarJogo.Size = new System.Drawing.Size(91, 28);
            this.btnCancelarJogo.TabIndex = 24;
            this.btnCancelarJogo.Text = "Cancelar";
            this.btnCancelarJogo.UseVisualStyleBackColor = true;
            this.btnCancelarJogo.Click += new System.EventHandler(this.btnCancelarJogo_Click);
            // 
            // labPesquisarJogos
            // 
            this.labPesquisarJogos.AutoSize = true;
            this.labPesquisarJogos.Location = new System.Drawing.Point(23, 33);
            this.labPesquisarJogos.Name = "labPesquisarJogos";
            this.labPesquisarJogos.Size = new System.Drawing.Size(70, 17);
            this.labPesquisarJogos.TabIndex = 9;
            this.labPesquisarJogos.Text = "Pesquise:";
            // 
            // txtGJogosPesquisa
            // 
            this.txtGJogosPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGJogosPesquisa.Location = new System.Drawing.Point(99, 30);
            this.txtGJogosPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGJogosPesquisa.Name = "txtGJogosPesquisa";
            this.txtGJogosPesquisa.Size = new System.Drawing.Size(425, 22);
            this.txtGJogosPesquisa.TabIndex = 8;
            // 
            // dgvGJogosLista
            // 
            this.dgvGJogosLista.AllowUserToAddRows = false;
            this.dgvGJogosLista.AllowUserToDeleteRows = false;
            this.dgvGJogosLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGJogosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGJogosLista.Location = new System.Drawing.Point(25, 70);
            this.dgvGJogosLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGJogosLista.Name = "dgvGJogosLista";
            this.dgvGJogosLista.ReadOnly = true;
            this.dgvGJogosLista.RowHeadersVisible = false;
            this.dgvGJogosLista.RowTemplate.Height = 24;
            this.dgvGJogosLista.Size = new System.Drawing.Size(541, 122);
            this.dgvGJogosLista.TabIndex = 4;
            // 
            // btnAlterarJogo
            // 
            this.btnAlterarJogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterarJogo.Location = new System.Drawing.Point(405, 209);
            this.btnAlterarJogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterarJogo.Name = "btnAlterarJogo";
            this.btnAlterarJogo.Size = new System.Drawing.Size(77, 27);
            this.btnAlterarJogo.TabIndex = 3;
            this.btnAlterarJogo.Text = "Alterar";
            this.btnAlterarJogo.UseVisualStyleBackColor = true;
            this.btnAlterarJogo.Click += new System.EventHandler(this.btnAlterarJogo_Click);
            // 
            // btnInserirJogo
            // 
            this.btnInserirJogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInserirJogo.Location = new System.Drawing.Point(322, 209);
            this.btnInserirJogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserirJogo.Name = "btnInserirJogo";
            this.btnInserirJogo.Size = new System.Drawing.Size(77, 27);
            this.btnInserirJogo.TabIndex = 2;
            this.btnInserirJogo.Text = "Inserir";
            this.btnInserirJogo.UseVisualStyleBackColor = true;
            this.btnInserirJogo.Click += new System.EventHandler(this.btnInserirJogo_Click);
            // 
            // btnRemoverJogo
            // 
            this.btnRemoverJogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverJogo.Location = new System.Drawing.Point(489, 209);
            this.btnRemoverJogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoverJogo.Name = "btnRemoverJogo";
            this.btnRemoverJogo.Size = new System.Drawing.Size(77, 27);
            this.btnRemoverJogo.TabIndex = 1;
            this.btnRemoverJogo.Text = "Eliminar";
            this.btnRemoverJogo.UseVisualStyleBackColor = true;
            this.btnRemoverJogo.Click += new System.EventHandler(this.btnRemoverJogo_Click);
            // 
            // gbGTorneiosDados
            // 
            this.gbGTorneiosDados.Controls.Add(this.btngerirjogos);
            this.gbGTorneiosDados.Controls.Add(this.radioStandardTournaments);
            this.gbGTorneiosDados.Controls.Add(this.radioTeamTournaments);
            this.gbGTorneiosDados.Controls.Add(this.labPesquisarTorneio);
            this.gbGTorneiosDados.Controls.Add(this.txtGTorneiosPesquisa);
            this.gbGTorneiosDados.Controls.Add(this.btnAlterarTorneio);
            this.gbGTorneiosDados.Controls.Add(this.btnInserirTorneio);
            this.gbGTorneiosDados.Controls.Add(this.dgvGTorneiosLista);
            this.gbGTorneiosDados.Controls.Add(this.btnRemoverTorneio);
            this.gbGTorneiosDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbGTorneiosDados.Location = new System.Drawing.Point(3, 2);
            this.gbGTorneiosDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGTorneiosDados.Name = "gbGTorneiosDados";
            this.gbGTorneiosDados.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGTorneiosDados.Size = new System.Drawing.Size(582, 247);
            this.gbGTorneiosDados.TabIndex = 0;
            this.gbGTorneiosDados.TabStop = false;
            this.gbGTorneiosDados.Text = "Torneios";
            // 
            // btngerirjogos
            // 
            this.btngerirjogos.Location = new System.Drawing.Point(487, 207);
            this.btngerirjogos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btngerirjogos.Name = "btngerirjogos";
            this.btngerirjogos.Size = new System.Drawing.Size(69, 27);
            this.btngerirjogos.TabIndex = 10;
            this.btngerirjogos.Text = "Gerir";
            this.btngerirjogos.UseVisualStyleBackColor = true;
            this.btngerirjogos.Click += new System.EventHandler(this.btngerirjogos_Click);
            // 
            // radioStandardTournaments
            // 
            this.radioStandardTournaments.AutoSize = true;
            this.radioStandardTournaments.Location = new System.Drawing.Point(103, 210);
            this.radioStandardTournaments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioStandardTournaments.Name = "radioStandardTournaments";
            this.radioStandardTournaments.Size = new System.Drawing.Size(87, 21);
            this.radioStandardTournaments.TabIndex = 9;
            this.radioStandardTournaments.TabStop = true;
            this.radioStandardTournaments.Text = "Standard";
            this.radioStandardTournaments.UseVisualStyleBackColor = true;
            this.radioStandardTournaments.CheckedChanged += new System.EventHandler(this.RadioFiltrarStandardTournaments);
            // 
            // radioTeamTournaments
            // 
            this.radioTeamTournaments.AutoSize = true;
            this.radioTeamTournaments.Location = new System.Drawing.Point(25, 210);
            this.radioTeamTournaments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioTeamTournaments.Name = "radioTeamTournaments";
            this.radioTeamTournaments.Size = new System.Drawing.Size(65, 21);
            this.radioTeamTournaments.TabIndex = 8;
            this.radioTeamTournaments.TabStop = true;
            this.radioTeamTournaments.Text = "Team";
            this.radioTeamTournaments.UseVisualStyleBackColor = true;
            this.radioTeamTournaments.CheckedChanged += new System.EventHandler(this.RadioFiltrarTeamTournaments);
            // 
            // labPesquisarTorneio
            // 
            this.labPesquisarTorneio.AutoSize = true;
            this.labPesquisarTorneio.Location = new System.Drawing.Point(23, 28);
            this.labPesquisarTorneio.Name = "labPesquisarTorneio";
            this.labPesquisarTorneio.Size = new System.Drawing.Size(70, 17);
            this.labPesquisarTorneio.TabIndex = 7;
            this.labPesquisarTorneio.Text = "Pesquise:";
            // 
            // txtGTorneiosPesquisa
            // 
            this.txtGTorneiosPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGTorneiosPesquisa.Location = new System.Drawing.Point(99, 25);
            this.txtGTorneiosPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGTorneiosPesquisa.Name = "txtGTorneiosPesquisa";
            this.txtGTorneiosPesquisa.Size = new System.Drawing.Size(425, 22);
            this.txtGTorneiosPesquisa.TabIndex = 6;
            this.txtGTorneiosPesquisa.TextChanged += new System.EventHandler(this.PesquisarTorneio);
            // 
            // btnAlterarTorneio
            // 
            this.btnAlterarTorneio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterarTorneio.Location = new System.Drawing.Point(322, 207);
            this.btnAlterarTorneio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterarTorneio.Name = "btnAlterarTorneio";
            this.btnAlterarTorneio.Size = new System.Drawing.Size(77, 27);
            this.btnAlterarTorneio.TabIndex = 3;
            this.btnAlterarTorneio.Text = "Alterar";
            this.btnAlterarTorneio.UseVisualStyleBackColor = true;
            this.btnAlterarTorneio.Click += new System.EventHandler(this.BotaoAlterarTorneio);
            // 
            // btnInserirTorneio
            // 
            this.btnInserirTorneio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInserirTorneio.Location = new System.Drawing.Point(239, 207);
            this.btnInserirTorneio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserirTorneio.Name = "btnInserirTorneio";
            this.btnInserirTorneio.Size = new System.Drawing.Size(77, 27);
            this.btnInserirTorneio.TabIndex = 2;
            this.btnInserirTorneio.Text = "Inserir";
            this.btnInserirTorneio.UseVisualStyleBackColor = true;
            this.btnInserirTorneio.Click += new System.EventHandler(this.BotaoInserirTorneio);
            // 
            // dgvGTorneiosLista
            // 
            this.dgvGTorneiosLista.AllowUserToAddRows = false;
            this.dgvGTorneiosLista.AllowUserToDeleteRows = false;
            this.dgvGTorneiosLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGTorneiosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGTorneiosLista.Location = new System.Drawing.Point(25, 63);
            this.dgvGTorneiosLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGTorneiosLista.Name = "dgvGTorneiosLista";
            this.dgvGTorneiosLista.ReadOnly = true;
            this.dgvGTorneiosLista.RowHeadersVisible = false;
            this.dgvGTorneiosLista.RowTemplate.Height = 24;
            this.dgvGTorneiosLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGTorneiosLista.Size = new System.Drawing.Size(533, 126);
            this.dgvGTorneiosLista.TabIndex = 1;
            // 
            // btnRemoverTorneio
            // 
            this.btnRemoverTorneio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverTorneio.Location = new System.Drawing.Point(406, 207);
            this.btnRemoverTorneio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoverTorneio.Name = "btnRemoverTorneio";
            this.btnRemoverTorneio.Size = new System.Drawing.Size(77, 27);
            this.btnRemoverTorneio.TabIndex = 0;
            this.btnRemoverTorneio.Text = "Eliminar";
            this.btnRemoverTorneio.UseVisualStyleBackColor = true;
            this.btnRemoverTorneio.Click += new System.EventHandler(this.BotaoRemoverTorneio);
            // 
            // gbGTorneiosInfo
            // 
            this.gbGTorneiosInfo.Controls.Add(this.gbGJogosForm);
            this.gbGTorneiosInfo.Controls.Add(this.gbGTorneiosForm);
            this.gbGTorneiosInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbGTorneiosInfo.Location = new System.Drawing.Point(585, 2);
            this.gbGTorneiosInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGTorneiosInfo.Name = "gbGTorneiosInfo";
            this.gbGTorneiosInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGTorneiosInfo.Size = new System.Drawing.Size(449, 488);
            this.gbGTorneiosInfo.TabIndex = 2;
            this.gbGTorneiosInfo.TabStop = false;
            // 
            // gbGJogosForm
            // 
            this.gbGJogosForm.Controls.Add(this.cmbarbitrojogos);
            this.gbGJogosForm.Controls.Add(this.label15);
            this.gbGJogosForm.Controls.Add(this.groupBox4);
            this.gbGJogosForm.Controls.Add(this.groupBoxEquipasJogos);
            this.gbGJogosForm.Controls.Add(this.btnJogoCancelar);
            this.gbGJogosForm.Controls.Add(this.btnJogoAcao);
            this.gbGJogosForm.Controls.Add(this.nudNJogo);
            this.gbGJogosForm.Controls.Add(this.labNumJogo);
            this.gbGJogosForm.Controls.Add(this.tpDataJogos);
            this.gbGJogosForm.Controls.Add(this.labData);
            this.gbGJogosForm.Controls.Add(this.txtDescricaoJogo);
            this.gbGJogosForm.Controls.Add(this.labDescricao);
            this.gbGJogosForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGJogosForm.Location = new System.Drawing.Point(3, 17);
            this.gbGJogosForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGJogosForm.Name = "gbGJogosForm";
            this.gbGJogosForm.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGJogosForm.Size = new System.Drawing.Size(443, 469);
            this.gbGJogosForm.TabIndex = 2;
            this.gbGJogosForm.TabStop = false;
            this.gbGJogosForm.Text = "Campos";
            this.gbGJogosForm.Visible = false;
            // 
            // cmbarbitrojogos
            // 
            this.cmbarbitrojogos.FormattingEnabled = true;
            this.cmbarbitrojogos.Location = new System.Drawing.Point(92, 121);
            this.cmbarbitrojogos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbarbitrojogos.Name = "cmbarbitrojogos";
            this.cmbarbitrojogos.Size = new System.Drawing.Size(157, 24);
            this.cmbarbitrojogos.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "Árbitro:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbdecks2);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.cmbdecks1);
            this.groupBox4.Location = new System.Drawing.Point(21, 215);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(395, 58);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Decks";
            // 
            // cmbdecks2
            // 
            this.cmbdecks2.FormattingEnabled = true;
            this.cmbdecks2.Location = new System.Drawing.Point(284, 18);
            this.cmbdecks2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbdecks2.Name = "cmbdecks2";
            this.cmbdecks2.Size = new System.Drawing.Size(104, 24);
            this.cmbdecks2.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(183, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "VS";
            // 
            // cmbdecks1
            // 
            this.cmbdecks1.FormattingEnabled = true;
            this.cmbdecks1.Location = new System.Drawing.Point(19, 18);
            this.cmbdecks1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbdecks1.Name = "cmbdecks1";
            this.cmbdecks1.Size = new System.Drawing.Size(108, 24);
            this.cmbdecks1.TabIndex = 0;
            // 
            // groupBoxEquipasJogos
            // 
            this.groupBoxEquipasJogos.Controls.Add(this.cmbequipajogador1);
            this.groupBoxEquipasJogos.Controls.Add(this.labVS);
            this.groupBoxEquipasJogos.Controls.Add(this.cmbequipajogador2);
            this.groupBoxEquipasJogos.Location = new System.Drawing.Point(21, 154);
            this.groupBoxEquipasJogos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxEquipasJogos.Name = "groupBoxEquipasJogos";
            this.groupBoxEquipasJogos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxEquipasJogos.Size = new System.Drawing.Size(395, 57);
            this.groupBoxEquipasJogos.TabIndex = 20;
            this.groupBoxEquipasJogos.TabStop = false;
            this.groupBoxEquipasJogos.Text = "Equipas";
            // 
            // cmbequipajogador1
            // 
            this.cmbequipajogador1.FormattingEnabled = true;
            this.cmbequipajogador1.Location = new System.Drawing.Point(19, 22);
            this.cmbequipajogador1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbequipajogador1.Name = "cmbequipajogador1";
            this.cmbequipajogador1.Size = new System.Drawing.Size(108, 24);
            this.cmbequipajogador1.TabIndex = 15;
            this.cmbequipajogador1.SelectedIndexChanged += new System.EventHandler(this.cmbJogador1Jogo_SelectedIndexChanged);
            // 
            // labVS
            // 
            this.labVS.AutoSize = true;
            this.labVS.Location = new System.Drawing.Point(183, 26);
            this.labVS.Name = "labVS";
            this.labVS.Size = new System.Drawing.Size(26, 17);
            this.labVS.TabIndex = 17;
            this.labVS.Text = "VS";
            // 
            // cmbequipajogador2
            // 
            this.cmbequipajogador2.FormattingEnabled = true;
            this.cmbequipajogador2.Location = new System.Drawing.Point(284, 20);
            this.cmbequipajogador2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbequipajogador2.Name = "cmbequipajogador2";
            this.cmbequipajogador2.Size = new System.Drawing.Size(104, 24);
            this.cmbequipajogador2.TabIndex = 16;
            this.cmbequipajogador2.SelectedIndexChanged += new System.EventHandler(this.cmbequipajogador2_SelectedIndexChanged);
            // 
            // btnJogoCancelar
            // 
            this.btnJogoCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJogoCancelar.Location = new System.Drawing.Point(347, 438);
            this.btnJogoCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogoCancelar.Name = "btnJogoCancelar";
            this.btnJogoCancelar.Size = new System.Drawing.Size(83, 26);
            this.btnJogoCancelar.TabIndex = 19;
            this.btnJogoCancelar.Text = "Cancelar";
            this.btnJogoCancelar.UseVisualStyleBackColor = true;
            this.btnJogoCancelar.Click += new System.EventHandler(this.btnJogoCancelar_Click);
            // 
            // btnJogoAcao
            // 
            this.btnJogoAcao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJogoAcao.Location = new System.Drawing.Point(267, 438);
            this.btnJogoAcao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogoAcao.Name = "btnJogoAcao";
            this.btnJogoAcao.Size = new System.Drawing.Size(75, 26);
            this.btnJogoAcao.TabIndex = 18;
            this.btnJogoAcao.Text = "Ação";
            this.btnJogoAcao.UseVisualStyleBackColor = true;
            this.btnJogoAcao.Click += new System.EventHandler(this.btnJogoAcao_Click);
            // 
            // nudNJogo
            // 
            this.nudNJogo.Location = new System.Drawing.Point(92, 81);
            this.nudNJogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudNJogo.Name = "nudNJogo";
            this.nudNJogo.Size = new System.Drawing.Size(51, 22);
            this.nudNJogo.TabIndex = 14;
            // 
            // labNumJogo
            // 
            this.labNumJogo.AutoSize = true;
            this.labNumJogo.Location = new System.Drawing.Point(27, 84);
            this.labNumJogo.Name = "labNumJogo";
            this.labNumJogo.Size = new System.Drawing.Size(58, 17);
            this.labNumJogo.TabIndex = 13;
            this.labNumJogo.Text = "Nº Jogo";
            // 
            // tpDataJogos
            // 
            this.tpDataJogos.Location = new System.Drawing.Point(92, 38);
            this.tpDataJogos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDataJogos.Name = "tpDataJogos";
            this.tpDataJogos.Size = new System.Drawing.Size(291, 22);
            this.tpDataJogos.TabIndex = 12;
            // 
            // labData
            // 
            this.labData.AutoSize = true;
            this.labData.Location = new System.Drawing.Point(25, 39);
            this.labData.Name = "labData";
            this.labData.Size = new System.Drawing.Size(38, 17);
            this.labData.TabIndex = 11;
            this.labData.Text = "Data";
            // 
            // txtDescricaoJogo
            // 
            this.txtDescricaoJogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricaoJogo.Location = new System.Drawing.Point(24, 310);
            this.txtDescricaoJogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricaoJogo.MinimumSize = new System.Drawing.Size(271, 42);
            this.txtDescricaoJogo.Multiline = true;
            this.txtDescricaoJogo.Name = "txtDescricaoJogo";
            this.txtDescricaoJogo.Size = new System.Drawing.Size(390, 111);
            this.txtDescricaoJogo.TabIndex = 10;
            // 
            // labDescricao
            // 
            this.labDescricao.AutoSize = true;
            this.labDescricao.Location = new System.Drawing.Point(27, 287);
            this.labDescricao.Name = "labDescricao";
            this.labDescricao.Size = new System.Drawing.Size(71, 17);
            this.labDescricao.TabIndex = 9;
            this.labDescricao.Text = "Descrição";
            // 
            // gbGTorneiosForm
            // 
            this.gbGTorneiosForm.Controls.Add(this.gbTipoTorneio);
            this.gbGTorneiosForm.Controls.Add(this.txtTorneioCancelar);
            this.gbGTorneiosForm.Controls.Add(this.txtTorneioAcao);
            this.gbGTorneiosForm.Controls.Add(this.txtDescricaoTorneio);
            this.gbGTorneiosForm.Controls.Add(this.tpDataTorneio);
            this.gbGTorneiosForm.Controls.Add(this.txtNomeTorneio);
            this.gbGTorneiosForm.Controls.Add(this.labDescricaoJogo);
            this.gbGTorneiosForm.Controls.Add(this.labDataJogo);
            this.gbGTorneiosForm.Controls.Add(this.labNomeJogo);
            this.gbGTorneiosForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGTorneiosForm.Location = new System.Drawing.Point(3, 17);
            this.gbGTorneiosForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGTorneiosForm.Name = "gbGTorneiosForm";
            this.gbGTorneiosForm.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGTorneiosForm.Size = new System.Drawing.Size(443, 469);
            this.gbGTorneiosForm.TabIndex = 1;
            this.gbGTorneiosForm.TabStop = false;
            this.gbGTorneiosForm.Text = "Campos";
            this.gbGTorneiosForm.Visible = false;
            // 
            // gbTipoTorneio
            // 
            this.gbTipoTorneio.Controls.Add(this.radioTipoTorneioTeam);
            this.gbTipoTorneio.Controls.Add(this.radioTipoTorneioStandard);
            this.gbTipoTorneio.Location = new System.Drawing.Point(27, 268);
            this.gbTipoTorneio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTipoTorneio.Name = "gbTipoTorneio";
            this.gbTipoTorneio.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTipoTorneio.Size = new System.Drawing.Size(148, 86);
            this.gbTipoTorneio.TabIndex = 14;
            this.gbTipoTorneio.TabStop = false;
            this.gbTipoTorneio.Text = "Tipo de Torneio";
            // 
            // radioTipoTorneioTeam
            // 
            this.radioTipoTorneioTeam.AutoSize = true;
            this.radioTipoTorneioTeam.Location = new System.Drawing.Point(15, 26);
            this.radioTipoTorneioTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioTipoTorneioTeam.Name = "radioTipoTorneioTeam";
            this.radioTipoTorneioTeam.Size = new System.Drawing.Size(146, 21);
            this.radioTipoTorneioTeam.TabIndex = 0;
            this.radioTipoTorneioTeam.TabStop = true;
            this.radioTipoTorneioTeam.Text = "Team Tournament";
            this.radioTipoTorneioTeam.UseVisualStyleBackColor = true;
            // 
            // radioTipoTorneioStandard
            // 
            this.radioTipoTorneioStandard.AutoSize = true;
            this.radioTipoTorneioStandard.Location = new System.Drawing.Point(15, 49);
            this.radioTipoTorneioStandard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioTipoTorneioStandard.Name = "radioTipoTorneioStandard";
            this.radioTipoTorneioStandard.Size = new System.Drawing.Size(168, 21);
            this.radioTipoTorneioStandard.TabIndex = 1;
            this.radioTipoTorneioStandard.TabStop = true;
            this.radioTipoTorneioStandard.Text = "Standard Tournament";
            this.radioTipoTorneioStandard.UseVisualStyleBackColor = true;
            // 
            // txtTorneioCancelar
            // 
            this.txtTorneioCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTorneioCancelar.Location = new System.Drawing.Point(347, 333);
            this.txtTorneioCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTorneioCancelar.Name = "txtTorneioCancelar";
            this.txtTorneioCancelar.Size = new System.Drawing.Size(83, 26);
            this.txtTorneioCancelar.TabIndex = 13;
            this.txtTorneioCancelar.Text = "Cancelar";
            this.txtTorneioCancelar.UseVisualStyleBackColor = true;
            this.txtTorneioCancelar.Click += new System.EventHandler(this.BotaoCancelarTorneio);
            // 
            // txtTorneioAcao
            // 
            this.txtTorneioAcao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTorneioAcao.Location = new System.Drawing.Point(267, 333);
            this.txtTorneioAcao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTorneioAcao.Name = "txtTorneioAcao";
            this.txtTorneioAcao.Size = new System.Drawing.Size(75, 26);
            this.txtTorneioAcao.TabIndex = 12;
            this.txtTorneioAcao.Text = "Ação";
            this.txtTorneioAcao.UseVisualStyleBackColor = true;
            this.txtTorneioAcao.Click += new System.EventHandler(this.BotaoAcaoTorneio);
            // 
            // txtDescricaoTorneio
            // 
            this.txtDescricaoTorneio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricaoTorneio.Location = new System.Drawing.Point(29, 162);
            this.txtDescricaoTorneio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricaoTorneio.MaximumSize = new System.Drawing.Size(400, 150);
            this.txtDescricaoTorneio.MinimumSize = new System.Drawing.Size(384, 61);
            this.txtDescricaoTorneio.Multiline = true;
            this.txtDescricaoTorneio.Name = "txtDescricaoTorneio";
            this.txtDescricaoTorneio.Size = new System.Drawing.Size(399, 148);
            this.txtDescricaoTorneio.TabIndex = 8;
            // 
            // tpDataTorneio
            // 
            this.tpDataTorneio.Location = new System.Drawing.Point(123, 81);
            this.tpDataTorneio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDataTorneio.Name = "tpDataTorneio";
            this.tpDataTorneio.Size = new System.Drawing.Size(292, 22);
            this.tpDataTorneio.TabIndex = 7;
            // 
            // txtNomeTorneio
            // 
            this.txtNomeTorneio.Location = new System.Drawing.Point(123, 39);
            this.txtNomeTorneio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeTorneio.Name = "txtNomeTorneio";
            this.txtNomeTorneio.Size = new System.Drawing.Size(292, 22);
            this.txtNomeTorneio.TabIndex = 6;
            // 
            // labDescricaoJogo
            // 
            this.labDescricaoJogo.AutoSize = true;
            this.labDescricaoJogo.Location = new System.Drawing.Point(27, 130);
            this.labDescricaoJogo.Name = "labDescricaoJogo";
            this.labDescricaoJogo.Size = new System.Drawing.Size(71, 17);
            this.labDescricaoJogo.TabIndex = 5;
            this.labDescricaoJogo.Text = "Descrição";
            // 
            // labDataJogo
            // 
            this.labDataJogo.AutoSize = true;
            this.labDataJogo.Location = new System.Drawing.Point(27, 86);
            this.labDataJogo.Name = "labDataJogo";
            this.labDataJogo.Size = new System.Drawing.Size(38, 17);
            this.labDataJogo.TabIndex = 4;
            this.labDataJogo.Text = "Data";
            // 
            // labNomeJogo
            // 
            this.labNomeJogo.AutoSize = true;
            this.labNomeJogo.Location = new System.Drawing.Point(27, 46);
            this.labNomeJogo.Name = "labNomeJogo";
            this.labNomeJogo.Size = new System.Drawing.Size(45, 17);
            this.labNomeJogo.TabIndex = 3;
            this.labNomeJogo.Text = "Nome";
            // 
            // tbGestaoCartas
            // 
            this.tbGestaoCartas.Controls.Add(this.gbGCartasForm);
            this.tbGestaoCartas.Controls.Add(this.gbGCartasDados);
            this.tbGestaoCartas.Location = new System.Drawing.Point(4, 25);
            this.tbGestaoCartas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGestaoCartas.Name = "tbGestaoCartas";
            this.tbGestaoCartas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGestaoCartas.Size = new System.Drawing.Size(1037, 492);
            this.tbGestaoCartas.TabIndex = 3;
            this.tbGestaoCartas.Text = "Cartas";
            this.tbGestaoCartas.UseVisualStyleBackColor = true;
            // 
            // gbGCartasForm
            // 
            this.gbGCartasForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGCartasForm.Controls.Add(this.btnCartaCancelar);
            this.gbGCartasForm.Controls.Add(this.btnAcaoCarta);
            this.gbGCartasForm.Controls.Add(this.nudGDefesaCarta);
            this.gbGCartasForm.Controls.Add(this.nudGAtaqueCarta);
            this.gbGCartasForm.Controls.Add(this.txtGRegrasCarta);
            this.gbGCartasForm.Controls.Add(this.nudGLealdadeCarta);
            this.gbGCartasForm.Controls.Add(this.txtGCustoCarta);
            this.gbGCartasForm.Controls.Add(this.cmbGTipoCarta);
            this.gbGCartasForm.Controls.Add(this.cmbFacaoCarta);
            this.gbGCartasForm.Controls.Add(this.txtGNomeCarta);
            this.gbGCartasForm.Controls.Add(this.labDefesa);
            this.gbGCartasForm.Controls.Add(this.labAtaque);
            this.gbGCartasForm.Controls.Add(this.labRegras);
            this.gbGCartasForm.Controls.Add(this.labLealdade);
            this.gbGCartasForm.Controls.Add(this.labCusto);
            this.gbGCartasForm.Controls.Add(this.labTipo);
            this.gbGCartasForm.Controls.Add(this.labFacao);
            this.gbGCartasForm.Controls.Add(this.labNomeCarta);
            this.gbGCartasForm.Location = new System.Drawing.Point(704, 0);
            this.gbGCartasForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGCartasForm.Name = "gbGCartasForm";
            this.gbGCartasForm.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGCartasForm.Size = new System.Drawing.Size(325, 486);
            this.gbGCartasForm.TabIndex = 1;
            this.gbGCartasForm.TabStop = false;
            this.gbGCartasForm.Text = "Campos";
            this.gbGCartasForm.Visible = false;
            // 
            // btnCartaCancelar
            // 
            this.btnCartaCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCartaCancelar.Location = new System.Drawing.Point(221, 443);
            this.btnCartaCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCartaCancelar.Name = "btnCartaCancelar";
            this.btnCartaCancelar.Size = new System.Drawing.Size(83, 26);
            this.btnCartaCancelar.TabIndex = 17;
            this.btnCartaCancelar.Text = "Cancelar";
            this.btnCartaCancelar.UseVisualStyleBackColor = true;
            this.btnCartaCancelar.Click += new System.EventHandler(this.btnCartaCancelar_Click);
            // 
            // btnAcaoCarta
            // 
            this.btnAcaoCarta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcaoCarta.Location = new System.Drawing.Point(141, 443);
            this.btnAcaoCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAcaoCarta.Name = "btnAcaoCarta";
            this.btnAcaoCarta.Size = new System.Drawing.Size(75, 26);
            this.btnAcaoCarta.TabIndex = 16;
            this.btnAcaoCarta.Text = "Ação";
            this.btnAcaoCarta.UseVisualStyleBackColor = true;
            this.btnAcaoCarta.Click += new System.EventHandler(this.btnAcaoCarta_Click);
            // 
            // nudGDefesaCarta
            // 
            this.nudGDefesaCarta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudGDefesaCarta.Location = new System.Drawing.Point(239, 401);
            this.nudGDefesaCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudGDefesaCarta.Name = "nudGDefesaCarta";
            this.nudGDefesaCarta.Size = new System.Drawing.Size(55, 22);
            this.nudGDefesaCarta.TabIndex = 15;
            // 
            // nudGAtaqueCarta
            // 
            this.nudGAtaqueCarta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudGAtaqueCarta.Location = new System.Drawing.Point(83, 401);
            this.nudGAtaqueCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudGAtaqueCarta.Name = "nudGAtaqueCarta";
            this.nudGAtaqueCarta.Size = new System.Drawing.Size(55, 22);
            this.nudGAtaqueCarta.TabIndex = 14;
            // 
            // txtGRegrasCarta
            // 
            this.txtGRegrasCarta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGRegrasCarta.Location = new System.Drawing.Point(27, 229);
            this.txtGRegrasCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGRegrasCarta.Multiline = true;
            this.txtGRegrasCarta.Name = "txtGRegrasCarta";
            this.txtGRegrasCarta.Size = new System.Drawing.Size(279, 155);
            this.txtGRegrasCarta.TabIndex = 13;
            // 
            // nudGLealdadeCarta
            // 
            this.nudGLealdadeCarta.Location = new System.Drawing.Point(252, 159);
            this.nudGLealdadeCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudGLealdadeCarta.Name = "nudGLealdadeCarta";
            this.nudGLealdadeCarta.Size = new System.Drawing.Size(55, 22);
            this.nudGLealdadeCarta.TabIndex = 12;
            // 
            // txtGCustoCarta
            // 
            this.txtGCustoCarta.Location = new System.Drawing.Point(79, 159);
            this.txtGCustoCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGCustoCarta.Name = "txtGCustoCarta";
            this.txtGCustoCarta.Size = new System.Drawing.Size(69, 22);
            this.txtGCustoCarta.TabIndex = 11;
            // 
            // cmbGTipoCarta
            // 
            this.cmbGTipoCarta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGTipoCarta.FormattingEnabled = true;
            this.cmbGTipoCarta.Items.AddRange(new object[] {
            "Criatura",
            "Evento",
            "Equipamento",
            "Magia",
            "Encantamento",
            "Cidade"});
            this.cmbGTipoCarta.Location = new System.Drawing.Point(95, 114);
            this.cmbGTipoCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGTipoCarta.Name = "cmbGTipoCarta";
            this.cmbGTipoCarta.Size = new System.Drawing.Size(209, 24);
            this.cmbGTipoCarta.TabIndex = 10;
            // 
            // cmbFacaoCarta
            // 
            this.cmbFacaoCarta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFacaoCarta.FormattingEnabled = true;
            this.cmbFacaoCarta.Items.AddRange(new object[] {
            "Gaian Love for Life",
            "Uneasy Alliance"});
            this.cmbFacaoCarta.Location = new System.Drawing.Point(95, 76);
            this.cmbFacaoCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFacaoCarta.Name = "cmbFacaoCarta";
            this.cmbFacaoCarta.Size = new System.Drawing.Size(209, 24);
            this.cmbFacaoCarta.TabIndex = 9;
            // 
            // txtGNomeCarta
            // 
            this.txtGNomeCarta.Location = new System.Drawing.Point(95, 41);
            this.txtGNomeCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGNomeCarta.Name = "txtGNomeCarta";
            this.txtGNomeCarta.Size = new System.Drawing.Size(209, 22);
            this.txtGNomeCarta.TabIndex = 8;
            // 
            // labDefesa
            // 
            this.labDefesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labDefesa.AutoSize = true;
            this.labDefesa.Location = new System.Drawing.Point(179, 404);
            this.labDefesa.Name = "labDefesa";
            this.labDefesa.Size = new System.Drawing.Size(53, 17);
            this.labDefesa.TabIndex = 7;
            this.labDefesa.Text = "Defesa";
            // 
            // labAtaque
            // 
            this.labAtaque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labAtaque.AutoSize = true;
            this.labAtaque.Location = new System.Drawing.Point(23, 404);
            this.labAtaque.Name = "labAtaque";
            this.labAtaque.Size = new System.Drawing.Size(53, 17);
            this.labAtaque.TabIndex = 6;
            this.labAtaque.Text = "Ataque";
            // 
            // labRegras
            // 
            this.labRegras.AutoSize = true;
            this.labRegras.Location = new System.Drawing.Point(24, 199);
            this.labRegras.Name = "labRegras";
            this.labRegras.Size = new System.Drawing.Size(54, 17);
            this.labRegras.TabIndex = 5;
            this.labRegras.Text = "Regras";
            // 
            // labLealdade
            // 
            this.labLealdade.AutoSize = true;
            this.labLealdade.Location = new System.Drawing.Point(179, 161);
            this.labLealdade.Name = "labLealdade";
            this.labLealdade.Size = new System.Drawing.Size(67, 17);
            this.labLealdade.TabIndex = 4;
            this.labLealdade.Text = "Lealdade";
            // 
            // labCusto
            // 
            this.labCusto.AutoSize = true;
            this.labCusto.Location = new System.Drawing.Point(24, 162);
            this.labCusto.Name = "labCusto";
            this.labCusto.Size = new System.Drawing.Size(44, 17);
            this.labCusto.TabIndex = 3;
            this.labCusto.Text = "Custo";
            // 
            // labTipo
            // 
            this.labTipo.AutoSize = true;
            this.labTipo.Location = new System.Drawing.Point(23, 122);
            this.labTipo.Name = "labTipo";
            this.labTipo.Size = new System.Drawing.Size(36, 17);
            this.labTipo.TabIndex = 2;
            this.labTipo.Text = "Tipo";
            // 
            // labFacao
            // 
            this.labFacao.AutoSize = true;
            this.labFacao.Location = new System.Drawing.Point(24, 85);
            this.labFacao.Name = "labFacao";
            this.labFacao.Size = new System.Drawing.Size(47, 17);
            this.labFacao.TabIndex = 1;
            this.labFacao.Text = "Fação";
            // 
            // labNomeCarta
            // 
            this.labNomeCarta.AutoSize = true;
            this.labNomeCarta.Location = new System.Drawing.Point(23, 46);
            this.labNomeCarta.Name = "labNomeCarta";
            this.labNomeCarta.Size = new System.Drawing.Size(45, 17);
            this.labNomeCarta.TabIndex = 0;
            this.labNomeCarta.Text = "Nome";
            // 
            // gbGCartasDados
            // 
            this.gbGCartasDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGCartasDados.Controls.Add(this.btnImportarCartas);
            this.gbGCartasDados.Controls.Add(this.btnRemoverCarta);
            this.gbGCartasDados.Controls.Add(this.btnAlterarCarta);
            this.gbGCartasDados.Controls.Add(this.btnInserirCarta);
            this.gbGCartasDados.Controls.Add(this.dgvGCartasLista);
            this.gbGCartasDados.Controls.Add(this.labPesquisarCarta);
            this.gbGCartasDados.Controls.Add(this.txtGCartasPesquisa);
            this.gbGCartasDados.Location = new System.Drawing.Point(5, 0);
            this.gbGCartasDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGCartasDados.MaximumSize = new System.Drawing.Size(700, 496);
            this.gbGCartasDados.MinimumSize = new System.Drawing.Size(389, 390);
            this.gbGCartasDados.Name = "gbGCartasDados";
            this.gbGCartasDados.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGCartasDados.Size = new System.Drawing.Size(696, 486);
            this.gbGCartasDados.TabIndex = 0;
            this.gbGCartasDados.TabStop = false;
            this.gbGCartasDados.Text = "Cartas";
            // 
            // btnImportarCartas
            // 
            this.btnImportarCartas.Location = new System.Drawing.Point(25, 447);
            this.btnImportarCartas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImportarCartas.Name = "btnImportarCartas";
            this.btnImportarCartas.Size = new System.Drawing.Size(100, 26);
            this.btnImportarCartas.TabIndex = 12;
            this.btnImportarCartas.Text = "Importar ...";
            this.btnImportarCartas.UseVisualStyleBackColor = true;
            this.btnImportarCartas.Click += new System.EventHandler(this.btnImportarCartas_Click);
            // 
            // btnRemoverCarta
            // 
            this.btnRemoverCarta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverCarta.Enabled = false;
            this.btnRemoverCarta.Location = new System.Drawing.Point(581, 443);
            this.btnRemoverCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoverCarta.Name = "btnRemoverCarta";
            this.btnRemoverCarta.Size = new System.Drawing.Size(83, 26);
            this.btnRemoverCarta.TabIndex = 11;
            this.btnRemoverCarta.Text = "Eliminar";
            this.btnRemoverCarta.UseVisualStyleBackColor = true;
            this.btnRemoverCarta.Click += new System.EventHandler(this.btnRemoverCarta_Click);
            // 
            // btnAlterarCarta
            // 
            this.btnAlterarCarta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterarCarta.Enabled = false;
            this.btnAlterarCarta.Location = new System.Drawing.Point(499, 443);
            this.btnAlterarCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterarCarta.Name = "btnAlterarCarta";
            this.btnAlterarCarta.Size = new System.Drawing.Size(77, 26);
            this.btnAlterarCarta.TabIndex = 10;
            this.btnAlterarCarta.Text = "Alterar";
            this.btnAlterarCarta.UseVisualStyleBackColor = true;
            this.btnAlterarCarta.Click += new System.EventHandler(this.btnAlterarCarta_Click);
            // 
            // btnInserirCarta
            // 
            this.btnInserirCarta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInserirCarta.Location = new System.Drawing.Point(411, 443);
            this.btnInserirCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserirCarta.Name = "btnInserirCarta";
            this.btnInserirCarta.Size = new System.Drawing.Size(83, 26);
            this.btnInserirCarta.TabIndex = 9;
            this.btnInserirCarta.Text = "Inserir";
            this.btnInserirCarta.UseVisualStyleBackColor = true;
            this.btnInserirCarta.Click += new System.EventHandler(this.btnInserirCarta_Click);
            // 
            // dgvGCartasLista
            // 
            this.dgvGCartasLista.AllowUserToAddRows = false;
            this.dgvGCartasLista.AllowUserToDeleteRows = false;
            this.dgvGCartasLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGCartasLista.AutoGenerateColumns = false;
            this.dgvGCartasLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGCartasLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGCartasLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.factionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.loyaltyDataGridViewTextBoxColumn,
            this.ruleTextDataGridViewTextBoxColumn,
            this.attackDataGridViewTextBoxColumn,
            this.defenseDataGridViewTextBoxColumn});
            this.dgvGCartasLista.DataSource = this.cardSetBindingSource;
            this.dgvGCartasLista.Location = new System.Drawing.Point(25, 94);
            this.dgvGCartasLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGCartasLista.Name = "dgvGCartasLista";
            this.dgvGCartasLista.ReadOnly = true;
            this.dgvGCartasLista.RowTemplate.Height = 24;
            this.dgvGCartasLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGCartasLista.Size = new System.Drawing.Size(641, 326);
            this.dgvGCartasLista.TabIndex = 8;
            this.dgvGCartasLista.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGCartasLista_CellEnter);
            this.dgvGCartasLista.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGCartasLista_CellLeave);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // factionDataGridViewTextBoxColumn
            // 
            this.factionDataGridViewTextBoxColumn.DataPropertyName = "Faction";
            this.factionDataGridViewTextBoxColumn.HeaderText = "Faction";
            this.factionDataGridViewTextBoxColumn.Name = "factionDataGridViewTextBoxColumn";
            this.factionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loyaltyDataGridViewTextBoxColumn
            // 
            this.loyaltyDataGridViewTextBoxColumn.DataPropertyName = "Loyalty";
            this.loyaltyDataGridViewTextBoxColumn.HeaderText = "Loyalty";
            this.loyaltyDataGridViewTextBoxColumn.Name = "loyaltyDataGridViewTextBoxColumn";
            this.loyaltyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ruleTextDataGridViewTextBoxColumn
            // 
            this.ruleTextDataGridViewTextBoxColumn.DataPropertyName = "RuleText";
            this.ruleTextDataGridViewTextBoxColumn.HeaderText = "RuleText";
            this.ruleTextDataGridViewTextBoxColumn.Name = "ruleTextDataGridViewTextBoxColumn";
            this.ruleTextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attackDataGridViewTextBoxColumn
            // 
            this.attackDataGridViewTextBoxColumn.DataPropertyName = "Attack";
            this.attackDataGridViewTextBoxColumn.HeaderText = "Attack";
            this.attackDataGridViewTextBoxColumn.Name = "attackDataGridViewTextBoxColumn";
            this.attackDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defenseDataGridViewTextBoxColumn
            // 
            this.defenseDataGridViewTextBoxColumn.DataPropertyName = "Defense";
            this.defenseDataGridViewTextBoxColumn.HeaderText = "Defense";
            this.defenseDataGridViewTextBoxColumn.Name = "defenseDataGridViewTextBoxColumn";
            this.defenseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cardSetBindingSource
            // 
            this.cardSetBindingSource.DataMember = "CardSet";
            this.cardSetBindingSource.DataSource = this.bD_DA_ProjetoDataSet_Cards;
            // 
            // bD_DA_ProjetoDataSet_Cards
            // 
            this.bD_DA_ProjetoDataSet_Cards.DataSetName = "BD_DA_ProjetoDataSet_Cards";
            this.bD_DA_ProjetoDataSet_Cards.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labPesquisarCarta
            // 
            this.labPesquisarCarta.AutoSize = true;
            this.labPesquisarCarta.Location = new System.Drawing.Point(23, 49);
            this.labPesquisarCarta.Name = "labPesquisarCarta";
            this.labPesquisarCarta.Size = new System.Drawing.Size(70, 17);
            this.labPesquisarCarta.TabIndex = 7;
            this.labPesquisarCarta.Text = "Pesquise:";
            // 
            // txtGCartasPesquisa
            // 
            this.txtGCartasPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGCartasPesquisa.Location = new System.Drawing.Point(99, 46);
            this.txtGCartasPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGCartasPesquisa.Name = "txtGCartasPesquisa";
            this.txtGCartasPesquisa.Size = new System.Drawing.Size(567, 22);
            this.txtGCartasPesquisa.TabIndex = 6;
            this.txtGCartasPesquisa.TextChanged += new System.EventHandler(this.txtGCartasPesquisa_TextChanged);
            // 
            // tbGestaoBaralhos
            // 
            this.tbGestaoBaralhos.Controls.Add(this.panelGestaoBaralho);
            this.tbGestaoBaralhos.Controls.Add(this.gbGBaralhosDados);
            this.tbGestaoBaralhos.Location = new System.Drawing.Point(4, 25);
            this.tbGestaoBaralhos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGestaoBaralhos.Name = "tbGestaoBaralhos";
            this.tbGestaoBaralhos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGestaoBaralhos.Size = new System.Drawing.Size(1037, 492);
            this.tbGestaoBaralhos.TabIndex = 4;
            this.tbGestaoBaralhos.Text = "Baralhos";
            this.tbGestaoBaralhos.UseVisualStyleBackColor = true;
            // 
            // panelGestaoBaralho
            // 
            this.panelGestaoBaralho.ColumnCount = 3;
            this.panelGestaoBaralho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelGestaoBaralho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.panelGestaoBaralho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelGestaoBaralho.Controls.Add(this.gbGCartasBotoes, 1, 0);
            this.panelGestaoBaralho.Controls.Add(this.gbGCartasnoBaralho, 0, 0);
            this.panelGestaoBaralho.Controls.Add(this.gbGListaDeCartas, 2, 0);
            this.panelGestaoBaralho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGestaoBaralho.Enabled = false;
            this.panelGestaoBaralho.Location = new System.Drawing.Point(3, 242);
            this.panelGestaoBaralho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelGestaoBaralho.Name = "panelGestaoBaralho";
            this.panelGestaoBaralho.RowCount = 1;
            this.panelGestaoBaralho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelGestaoBaralho.Size = new System.Drawing.Size(1031, 248);
            this.panelGestaoBaralho.TabIndex = 1;
            // 
            // gbGCartasBotoes
            // 
            this.gbGCartasBotoes.Controls.Add(this.lblNCartasNoBaralho);
            this.gbGCartasBotoes.Controls.Add(this.btnRemoverCartaBaralho);
            this.gbGCartasBotoes.Controls.Add(this.btnAdicionarCartaBaralho);
            this.gbGCartasBotoes.Controls.Add(this.lblNCartasTotais);
            this.gbGCartasBotoes.Controls.Add(this.btnCancelarAltBaralho);
            this.gbGCartasBotoes.Controls.Add(this.btnGuardarAltBaralho);
            this.gbGCartasBotoes.Location = new System.Drawing.Point(452, 2);
            this.gbGCartasBotoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGCartasBotoes.Name = "gbGCartasBotoes";
            this.gbGCartasBotoes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGCartasBotoes.Size = new System.Drawing.Size(127, 235);
            this.gbGCartasBotoes.TabIndex = 15;
            this.gbGCartasBotoes.TabStop = false;
            // 
            // lblNCartasNoBaralho
            // 
            this.lblNCartasNoBaralho.Location = new System.Drawing.Point(27, 44);
            this.lblNCartasNoBaralho.Name = "lblNCartasNoBaralho";
            this.lblNCartasNoBaralho.Size = new System.Drawing.Size(36, 17);
            this.lblNCartasNoBaralho.TabIndex = 5;
            this.lblNCartasNoBaralho.Text = "0";
            this.lblNCartasNoBaralho.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnRemoverCartaBaralho
            // 
            this.btnRemoverCartaBaralho.Location = new System.Drawing.Point(36, 110);
            this.btnRemoverCartaBaralho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoverCartaBaralho.Name = "btnRemoverCartaBaralho";
            this.btnRemoverCartaBaralho.Size = new System.Drawing.Size(55, 30);
            this.btnRemoverCartaBaralho.TabIndex = 13;
            this.btnRemoverCartaBaralho.Text = ">>";
            this.btnRemoverCartaBaralho.UseVisualStyleBackColor = true;
            this.btnRemoverCartaBaralho.Click += new System.EventHandler(this.btnRemoverCartaBaralho_Click);
            // 
            // btnAdicionarCartaBaralho
            // 
            this.btnAdicionarCartaBaralho.Location = new System.Drawing.Point(36, 75);
            this.btnAdicionarCartaBaralho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionarCartaBaralho.Name = "btnAdicionarCartaBaralho";
            this.btnAdicionarCartaBaralho.Size = new System.Drawing.Size(55, 30);
            this.btnAdicionarCartaBaralho.TabIndex = 14;
            this.btnAdicionarCartaBaralho.Text = "<<";
            this.btnAdicionarCartaBaralho.UseVisualStyleBackColor = true;
            this.btnAdicionarCartaBaralho.Click += new System.EventHandler(this.btnAdicionarCartaBaralho_Click);
            // 
            // lblNCartasTotais
            // 
            this.lblNCartasTotais.AutoSize = true;
            this.lblNCartasTotais.Location = new System.Drawing.Point(59, 44);
            this.lblNCartasTotais.Name = "lblNCartasTotais";
            this.lblNCartasTotais.Size = new System.Drawing.Size(28, 17);
            this.lblNCartasTotais.TabIndex = 4;
            this.lblNCartasTotais.Text = "/45";
            // 
            // btnCancelarAltBaralho
            // 
            this.btnCancelarAltBaralho.Location = new System.Drawing.Point(23, 188);
            this.btnCancelarAltBaralho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarAltBaralho.Name = "btnCancelarAltBaralho";
            this.btnCancelarAltBaralho.Size = new System.Drawing.Size(85, 28);
            this.btnCancelarAltBaralho.TabIndex = 11;
            this.btnCancelarAltBaralho.Text = "Cancelar";
            this.btnCancelarAltBaralho.UseVisualStyleBackColor = true;
            this.btnCancelarAltBaralho.Click += new System.EventHandler(this.btnCancelarAltBaralho_Click);
            // 
            // btnGuardarAltBaralho
            // 
            this.btnGuardarAltBaralho.Location = new System.Drawing.Point(23, 155);
            this.btnGuardarAltBaralho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarAltBaralho.Name = "btnGuardarAltBaralho";
            this.btnGuardarAltBaralho.Size = new System.Drawing.Size(85, 28);
            this.btnGuardarAltBaralho.TabIndex = 12;
            this.btnGuardarAltBaralho.Text = "Guardar";
            this.btnGuardarAltBaralho.UseVisualStyleBackColor = true;
            this.btnGuardarAltBaralho.Click += new System.EventHandler(this.btnGuardarAltBaralho_Click);
            // 
            // gbGCartasnoBaralho
            // 
            this.gbGCartasnoBaralho.Controls.Add(this.lvCartasBaralho);
            this.gbGCartasnoBaralho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGCartasnoBaralho.Location = new System.Drawing.Point(3, 2);
            this.gbGCartasnoBaralho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGCartasnoBaralho.Name = "gbGCartasnoBaralho";
            this.gbGCartasnoBaralho.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGCartasnoBaralho.Size = new System.Drawing.Size(443, 244);
            this.gbGCartasnoBaralho.TabIndex = 2;
            this.gbGCartasnoBaralho.TabStop = false;
            this.gbGCartasnoBaralho.Text = "Cartas do Baralho";
            // 
            // lvCartasBaralho
            // 
            this.lvCartasBaralho.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCarta,
            this.chTipo,
            this.chQtd});
            this.lvCartasBaralho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCartasBaralho.FullRowSelect = true;
            this.lvCartasBaralho.Location = new System.Drawing.Point(3, 17);
            this.lvCartasBaralho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvCartasBaralho.MultiSelect = false;
            this.lvCartasBaralho.Name = "lvCartasBaralho";
            this.lvCartasBaralho.Size = new System.Drawing.Size(437, 225);
            this.lvCartasBaralho.TabIndex = 1;
            this.lvCartasBaralho.UseCompatibleStateImageBehavior = false;
            this.lvCartasBaralho.View = System.Windows.Forms.View.Details;
            this.lvCartasBaralho.SelectedIndexChanged += new System.EventHandler(this.lvCartasBaralho_SelectedIndexChanged);
            // 
            // chCarta
            // 
            this.chCarta.Text = "Carta";
            this.chCarta.Width = 83;
            // 
            // chTipo
            // 
            this.chTipo.Text = "Tipo";
            this.chTipo.Width = 70;
            // 
            // chQtd
            // 
            this.chQtd.Text = "Qtd";
            this.chQtd.Width = 37;
            // 
            // gbGListaDeCartas
            // 
            this.gbGListaDeCartas.Controls.Add(this.lvListaCartas);
            this.gbGListaDeCartas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGListaDeCartas.Location = new System.Drawing.Point(585, 2);
            this.gbGListaDeCartas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGListaDeCartas.Name = "gbGListaDeCartas";
            this.gbGListaDeCartas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGListaDeCartas.Size = new System.Drawing.Size(443, 244);
            this.gbGListaDeCartas.TabIndex = 1;
            this.gbGListaDeCartas.TabStop = false;
            this.gbGListaDeCartas.Text = "Lista de Cartas";
            // 
            // lvListaCartas
            // 
            this.lvListaCartas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cCarta,
            this.CTipo,
            this.cQtd});
            this.lvListaCartas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvListaCartas.FullRowSelect = true;
            this.lvListaCartas.Location = new System.Drawing.Point(3, 17);
            this.lvListaCartas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvListaCartas.MultiSelect = false;
            this.lvListaCartas.Name = "lvListaCartas";
            this.lvListaCartas.Size = new System.Drawing.Size(437, 225);
            this.lvListaCartas.TabIndex = 1;
            this.lvListaCartas.UseCompatibleStateImageBehavior = false;
            this.lvListaCartas.View = System.Windows.Forms.View.Details;
            this.lvListaCartas.SelectedIndexChanged += new System.EventHandler(this.lvListaCartas_SelectedIndexChanged);
            // 
            // cCarta
            // 
            this.cCarta.Text = "Carta";
            this.cCarta.Width = 106;
            // 
            // CTipo
            // 
            this.CTipo.Text = "Tipo";
            this.CTipo.Width = 67;
            // 
            // cQtd
            // 
            this.cQtd.Text = "Qtd";
            this.cQtd.Width = 40;
            // 
            // gbGBaralhosDados
            // 
            this.gbGBaralhosDados.Controls.Add(this.gbGBaralhosForm);
            this.gbGBaralhosDados.Controls.Add(this.labPesquisarBaralho);
            this.gbGBaralhosDados.Controls.Add(this.dgvGBaralhosLista);
            this.gbGBaralhosDados.Controls.Add(this.btnInserirBaralho);
            this.gbGBaralhosDados.Controls.Add(this.txtGBaralhosPesquisa);
            this.gbGBaralhosDados.Controls.Add(this.btnGerirBaralho);
            this.gbGBaralhosDados.Controls.Add(this.btnEliminarBaralho);
            this.gbGBaralhosDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbGBaralhosDados.Location = new System.Drawing.Point(3, 2);
            this.gbGBaralhosDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGBaralhosDados.Name = "gbGBaralhosDados";
            this.gbGBaralhosDados.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGBaralhosDados.Size = new System.Drawing.Size(1031, 240);
            this.gbGBaralhosDados.TabIndex = 0;
            this.gbGBaralhosDados.TabStop = false;
            this.gbGBaralhosDados.Text = "Baralhos";
            // 
            // gbGBaralhosForm
            // 
            this.gbGBaralhosForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGBaralhosForm.Controls.Add(this.labNomeBaralho);
            this.gbGBaralhosForm.Controls.Add(this.btnCriarBaralho);
            this.gbGBaralhosForm.Controls.Add(this.btnCancelarNovoBaralho);
            this.gbGBaralhosForm.Controls.Add(this.txtNomeBaralho);
            this.gbGBaralhosForm.Location = new System.Drawing.Point(749, 89);
            this.gbGBaralhosForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGBaralhosForm.Name = "gbGBaralhosForm";
            this.gbGBaralhosForm.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGBaralhosForm.Size = new System.Drawing.Size(276, 135);
            this.gbGBaralhosForm.TabIndex = 18;
            this.gbGBaralhosForm.TabStop = false;
            this.gbGBaralhosForm.Text = "Campo";
            this.gbGBaralhosForm.Visible = false;
            // 
            // labNomeBaralho
            // 
            this.labNomeBaralho.AutoSize = true;
            this.labNomeBaralho.Location = new System.Drawing.Point(23, 39);
            this.labNomeBaralho.Name = "labNomeBaralho";
            this.labNomeBaralho.Size = new System.Drawing.Size(45, 17);
            this.labNomeBaralho.TabIndex = 14;
            this.labNomeBaralho.Text = "Nome";
            // 
            // btnCriarBaralho
            // 
            this.btnCriarBaralho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriarBaralho.Location = new System.Drawing.Point(75, 97);
            this.btnCriarBaralho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCriarBaralho.Name = "btnCriarBaralho";
            this.btnCriarBaralho.Size = new System.Drawing.Size(85, 28);
            this.btnCriarBaralho.TabIndex = 17;
            this.btnCriarBaralho.Text = "Criar";
            this.btnCriarBaralho.UseVisualStyleBackColor = true;
            this.btnCriarBaralho.Click += new System.EventHandler(this.btnCriarBaralho_Click);
            // 
            // btnCancelarNovoBaralho
            // 
            this.btnCancelarNovoBaralho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarNovoBaralho.Location = new System.Drawing.Point(165, 97);
            this.btnCancelarNovoBaralho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarNovoBaralho.Name = "btnCancelarNovoBaralho";
            this.btnCancelarNovoBaralho.Size = new System.Drawing.Size(85, 28);
            this.btnCancelarNovoBaralho.TabIndex = 16;
            this.btnCancelarNovoBaralho.Text = "Cancelar";
            this.btnCancelarNovoBaralho.UseVisualStyleBackColor = true;
            this.btnCancelarNovoBaralho.Click += new System.EventHandler(this.btnCancelarNovoBaralho_Click);
            // 
            // txtNomeBaralho
            // 
            this.txtNomeBaralho.Location = new System.Drawing.Point(75, 36);
            this.txtNomeBaralho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeBaralho.Name = "txtNomeBaralho";
            this.txtNomeBaralho.Size = new System.Drawing.Size(175, 22);
            this.txtNomeBaralho.TabIndex = 15;
            // 
            // labPesquisarBaralho
            // 
            this.labPesquisarBaralho.AutoSize = true;
            this.labPesquisarBaralho.Location = new System.Drawing.Point(25, 27);
            this.labPesquisarBaralho.Name = "labPesquisarBaralho";
            this.labPesquisarBaralho.Size = new System.Drawing.Size(70, 17);
            this.labPesquisarBaralho.TabIndex = 13;
            this.labPesquisarBaralho.Text = "Pesquise:";
            // 
            // dgvGBaralhosLista
            // 
            this.dgvGBaralhosLista.AllowUserToAddRows = false;
            this.dgvGBaralhosLista.AllowUserToDeleteRows = false;
            this.dgvGBaralhosLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGBaralhosLista.AutoGenerateColumns = false;
            this.dgvGBaralhosLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGBaralhosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGBaralhosLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1});
            this.dgvGBaralhosLista.DataSource = this.deckSetBindingSource;
            this.dgvGBaralhosLista.Location = new System.Drawing.Point(29, 66);
            this.dgvGBaralhosLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGBaralhosLista.Name = "dgvGBaralhosLista";
            this.dgvGBaralhosLista.ReadOnly = true;
            this.dgvGBaralhosLista.RowTemplate.Height = 24;
            this.dgvGBaralhosLista.Size = new System.Drawing.Size(610, 158);
            this.dgvGBaralhosLista.TabIndex = 9;
            this.dgvGBaralhosLista.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGBaralhosLista_CellEnter);
            this.dgvGBaralhosLista.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGBaralhosLista_CellLeave);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // deckSetBindingSource
            // 
            this.deckSetBindingSource.DataMember = "DeckSet";
            this.deckSetBindingSource.DataSource = this.bD_DA_ProjetoDataSet_Decks;
            // 
            // bD_DA_ProjetoDataSet_Decks
            // 
            this.bD_DA_ProjetoDataSet_Decks.DataSetName = "BD_DA_ProjetoDataSet_Decks";
            this.bD_DA_ProjetoDataSet_Decks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnInserirBaralho
            // 
            this.btnInserirBaralho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInserirBaralho.Location = new System.Drawing.Point(653, 102);
            this.btnInserirBaralho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserirBaralho.Name = "btnInserirBaralho";
            this.btnInserirBaralho.Size = new System.Drawing.Size(77, 28);
            this.btnInserirBaralho.TabIndex = 10;
            this.btnInserirBaralho.Text = "Inserir";
            this.btnInserirBaralho.UseVisualStyleBackColor = true;
            this.btnInserirBaralho.Click += new System.EventHandler(this.btnInserirBaralho_Click);
            // 
            // txtGBaralhosPesquisa
            // 
            this.txtGBaralhosPesquisa.Location = new System.Drawing.Point(101, 23);
            this.txtGBaralhosPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGBaralhosPesquisa.Name = "txtGBaralhosPesquisa";
            this.txtGBaralhosPesquisa.Size = new System.Drawing.Size(260, 22);
            this.txtGBaralhosPesquisa.TabIndex = 12;
            this.txtGBaralhosPesquisa.TextChanged += new System.EventHandler(this.txtGBaralhosPesquisa_TextChanged);
            // 
            // btnGerirBaralho
            // 
            this.btnGerirBaralho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerirBaralho.Enabled = false;
            this.btnGerirBaralho.Location = new System.Drawing.Point(653, 148);
            this.btnGerirBaralho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerirBaralho.Name = "btnGerirBaralho";
            this.btnGerirBaralho.Size = new System.Drawing.Size(77, 28);
            this.btnGerirBaralho.TabIndex = 11;
            this.btnGerirBaralho.Text = "Gerir";
            this.btnGerirBaralho.UseVisualStyleBackColor = true;
            this.btnGerirBaralho.Click += new System.EventHandler(this.btnGerirBaralho_Click);
            // 
            // btnEliminarBaralho
            // 
            this.btnEliminarBaralho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarBaralho.Enabled = false;
            this.btnEliminarBaralho.Location = new System.Drawing.Point(653, 196);
            this.btnEliminarBaralho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarBaralho.Name = "btnEliminarBaralho";
            this.btnEliminarBaralho.Size = new System.Drawing.Size(77, 28);
            this.btnEliminarBaralho.TabIndex = 8;
            this.btnEliminarBaralho.Text = "Eliminar";
            this.btnEliminarBaralho.UseVisualStyleBackColor = true;
            this.btnEliminarBaralho.Click += new System.EventHandler(this.btnEliminarBaralho_Click);
            // 
            // tbGestaoUtilizadores
            // 
            this.tbGestaoUtilizadores.Controls.Add(this.gbGUtilizadoresDados);
            this.tbGestaoUtilizadores.Controls.Add(this.gbGAdministradorForm);
            this.tbGestaoUtilizadores.Controls.Add(this.gbGArbitroForm);
            this.tbGestaoUtilizadores.Location = new System.Drawing.Point(4, 25);
            this.tbGestaoUtilizadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGestaoUtilizadores.Name = "tbGestaoUtilizadores";
            this.tbGestaoUtilizadores.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGestaoUtilizadores.Size = new System.Drawing.Size(1037, 492);
            this.tbGestaoUtilizadores.TabIndex = 5;
            this.tbGestaoUtilizadores.Text = "Utilizadores";
            this.tbGestaoUtilizadores.UseVisualStyleBackColor = true;
            // 
            // gbGUtilizadoresDados
            // 
            this.gbGUtilizadoresDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGUtilizadoresDados.Controls.Add(this.radioAdmins);
            this.gbGUtilizadoresDados.Controls.Add(this.radioArbitros);
            this.gbGUtilizadoresDados.Controls.Add(this.btnEliminarUtilizador);
            this.gbGUtilizadoresDados.Controls.Add(this.labPesquisarUtilizador);
            this.gbGUtilizadoresDados.Controls.Add(this.btnAlterarUtilizador);
            this.gbGUtilizadoresDados.Controls.Add(this.dgvGUtilizadoresLista);
            this.gbGUtilizadoresDados.Controls.Add(this.btnInserirUtilizador);
            this.gbGUtilizadoresDados.Controls.Add(this.txtGUtilizadoresPesquisa);
            this.gbGUtilizadoresDados.Location = new System.Drawing.Point(5, 0);
            this.gbGUtilizadoresDados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGUtilizadoresDados.MaximumSize = new System.Drawing.Size(700, 500);
            this.gbGUtilizadoresDados.MinimumSize = new System.Drawing.Size(389, 390);
            this.gbGUtilizadoresDados.Name = "gbGUtilizadoresDados";
            this.gbGUtilizadoresDados.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGUtilizadoresDados.Size = new System.Drawing.Size(696, 489);
            this.gbGUtilizadoresDados.TabIndex = 0;
            this.gbGUtilizadoresDados.TabStop = false;
            this.gbGUtilizadoresDados.Text = "Utilizadores";
            // 
            // radioAdmins
            // 
            this.radioAdmins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioAdmins.AutoSize = true;
            this.radioAdmins.Location = new System.Drawing.Point(19, 458);
            this.radioAdmins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioAdmins.Name = "radioAdmins";
            this.radioAdmins.Size = new System.Drawing.Size(131, 21);
            this.radioAdmins.TabIndex = 10;
            this.radioAdmins.TabStop = true;
            this.radioAdmins.Text = "Administradores";
            this.radioAdmins.UseVisualStyleBackColor = true;
            this.radioAdmins.CheckedChanged += new System.EventHandler(this.RadioFiltrarAdministradores);
            // 
            // radioArbitros
            // 
            this.radioArbitros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioArbitros.AutoSize = true;
            this.radioArbitros.Location = new System.Drawing.Point(161, 458);
            this.radioArbitros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioArbitros.Name = "radioArbitros";
            this.radioArbitros.Size = new System.Drawing.Size(78, 21);
            this.radioArbitros.TabIndex = 9;
            this.radioArbitros.TabStop = true;
            this.radioArbitros.Text = "Arbitros";
            this.radioArbitros.UseVisualStyleBackColor = true;
            this.radioArbitros.CheckedChanged += new System.EventHandler(this.RadioFiltrarArbitros);
            // 
            // btnEliminarUtilizador
            // 
            this.btnEliminarUtilizador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarUtilizador.Location = new System.Drawing.Point(595, 447);
            this.btnEliminarUtilizador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarUtilizador.Name = "btnEliminarUtilizador";
            this.btnEliminarUtilizador.Size = new System.Drawing.Size(83, 30);
            this.btnEliminarUtilizador.TabIndex = 7;
            this.btnEliminarUtilizador.Text = "Eliminar";
            this.btnEliminarUtilizador.UseVisualStyleBackColor = true;
            this.btnEliminarUtilizador.Click += new System.EventHandler(this.BotaoEliminarUtilizador);
            // 
            // labPesquisarUtilizador
            // 
            this.labPesquisarUtilizador.AutoSize = true;
            this.labPesquisarUtilizador.Location = new System.Drawing.Point(11, 44);
            this.labPesquisarUtilizador.Name = "labPesquisarUtilizador";
            this.labPesquisarUtilizador.Size = new System.Drawing.Size(70, 17);
            this.labPesquisarUtilizador.TabIndex = 8;
            this.labPesquisarUtilizador.Text = "Pesquise:";
            // 
            // btnAlterarUtilizador
            // 
            this.btnAlterarUtilizador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterarUtilizador.Location = new System.Drawing.Point(512, 447);
            this.btnAlterarUtilizador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterarUtilizador.Name = "btnAlterarUtilizador";
            this.btnAlterarUtilizador.Size = new System.Drawing.Size(77, 30);
            this.btnAlterarUtilizador.TabIndex = 5;
            this.btnAlterarUtilizador.Text = "Alterar";
            this.btnAlterarUtilizador.UseVisualStyleBackColor = true;
            this.btnAlterarUtilizador.Click += new System.EventHandler(this.BotaoAlterarUtilizador);
            // 
            // dgvGUtilizadoresLista
            // 
            this.dgvGUtilizadoresLista.AllowUserToAddRows = false;
            this.dgvGUtilizadoresLista.AllowUserToDeleteRows = false;
            this.dgvGUtilizadoresLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGUtilizadoresLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGUtilizadoresLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGUtilizadoresLista.Location = new System.Drawing.Point(19, 84);
            this.dgvGUtilizadoresLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGUtilizadoresLista.Name = "dgvGUtilizadoresLista";
            this.dgvGUtilizadoresLista.ReadOnly = true;
            this.dgvGUtilizadoresLista.RowTemplate.Height = 24;
            this.dgvGUtilizadoresLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGUtilizadoresLista.Size = new System.Drawing.Size(659, 347);
            this.dgvGUtilizadoresLista.TabIndex = 3;
            // 
            // btnInserirUtilizador
            // 
            this.btnInserirUtilizador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInserirUtilizador.Location = new System.Drawing.Point(424, 447);
            this.btnInserirUtilizador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserirUtilizador.Name = "btnInserirUtilizador";
            this.btnInserirUtilizador.Size = new System.Drawing.Size(83, 30);
            this.btnInserirUtilizador.TabIndex = 4;
            this.btnInserirUtilizador.Text = "Inserir";
            this.btnInserirUtilizador.UseVisualStyleBackColor = true;
            this.btnInserirUtilizador.Click += new System.EventHandler(this.BotaoInserirUtilizador);
            // 
            // txtGUtilizadoresPesquisa
            // 
            this.txtGUtilizadoresPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGUtilizadoresPesquisa.Location = new System.Drawing.Point(87, 42);
            this.txtGUtilizadoresPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGUtilizadoresPesquisa.Name = "txtGUtilizadoresPesquisa";
            this.txtGUtilizadoresPesquisa.Size = new System.Drawing.Size(588, 22);
            this.txtGUtilizadoresPesquisa.TabIndex = 6;
            this.txtGUtilizadoresPesquisa.TextChanged += new System.EventHandler(this.PesquisarUtilizador);
            // 
            // gbGAdministradorForm
            // 
            this.gbGAdministradorForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGAdministradorForm.Controls.Add(this.btnCancelarAdministrador);
            this.gbGAdministradorForm.Controls.Add(this.btnAcaoAdministrador);
            this.gbGAdministradorForm.Controls.Add(this.txtEmailAdministrador);
            this.gbGAdministradorForm.Controls.Add(this.txtPasswordAdministrador);
            this.gbGAdministradorForm.Controls.Add(this.txtUsernameAdministrador);
            this.gbGAdministradorForm.Controls.Add(this.labEmailAdministrador);
            this.gbGAdministradorForm.Controls.Add(this.labPasswordAdministrador);
            this.gbGAdministradorForm.Controls.Add(this.labUsernameAdministrador);
            this.gbGAdministradorForm.Location = new System.Drawing.Point(704, 0);
            this.gbGAdministradorForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGAdministradorForm.Name = "gbGAdministradorForm";
            this.gbGAdministradorForm.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGAdministradorForm.Size = new System.Drawing.Size(325, 489);
            this.gbGAdministradorForm.TabIndex = 1;
            this.gbGAdministradorForm.TabStop = false;
            this.gbGAdministradorForm.Text = "Campos";
            this.gbGAdministradorForm.Visible = false;
            // 
            // btnCancelarAdministrador
            // 
            this.btnCancelarAdministrador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarAdministrador.Location = new System.Drawing.Point(215, 446);
            this.btnCancelarAdministrador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarAdministrador.Name = "btnCancelarAdministrador";
            this.btnCancelarAdministrador.Size = new System.Drawing.Size(83, 31);
            this.btnCancelarAdministrador.TabIndex = 15;
            this.btnCancelarAdministrador.Text = "Cancelar";
            this.btnCancelarAdministrador.UseVisualStyleBackColor = true;
            this.btnCancelarAdministrador.Click += new System.EventHandler(this.BotaoCancelarAdministrador);
            // 
            // btnAcaoAdministrador
            // 
            this.btnAcaoAdministrador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcaoAdministrador.Location = new System.Drawing.Point(129, 446);
            this.btnAcaoAdministrador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAcaoAdministrador.Name = "btnAcaoAdministrador";
            this.btnAcaoAdministrador.Size = new System.Drawing.Size(80, 31);
            this.btnAcaoAdministrador.TabIndex = 14;
            this.btnAcaoAdministrador.Text = "Ação";
            this.btnAcaoAdministrador.UseVisualStyleBackColor = true;
            this.btnAcaoAdministrador.Click += new System.EventHandler(this.BotaoAcaoAdministrador);
            // 
            // txtEmailAdministrador
            // 
            this.txtEmailAdministrador.Location = new System.Drawing.Point(68, 118);
            this.txtEmailAdministrador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailAdministrador.Name = "txtEmailAdministrador";
            this.txtEmailAdministrador.Size = new System.Drawing.Size(228, 22);
            this.txtEmailAdministrador.TabIndex = 13;
            // 
            // txtPasswordAdministrador
            // 
            this.txtPasswordAdministrador.Location = new System.Drawing.Point(96, 80);
            this.txtPasswordAdministrador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordAdministrador.Name = "txtPasswordAdministrador";
            this.txtPasswordAdministrador.Size = new System.Drawing.Size(200, 22);
            this.txtPasswordAdministrador.TabIndex = 8;
            this.txtPasswordAdministrador.UseSystemPasswordChar = true;
            // 
            // txtUsernameAdministrador
            // 
            this.txtUsernameAdministrador.Location = new System.Drawing.Point(99, 47);
            this.txtUsernameAdministrador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsernameAdministrador.Name = "txtUsernameAdministrador";
            this.txtUsernameAdministrador.Size = new System.Drawing.Size(197, 22);
            this.txtUsernameAdministrador.TabIndex = 7;
            // 
            // labEmailAdministrador
            // 
            this.labEmailAdministrador.AutoSize = true;
            this.labEmailAdministrador.Location = new System.Drawing.Point(20, 122);
            this.labEmailAdministrador.Name = "labEmailAdministrador";
            this.labEmailAdministrador.Size = new System.Drawing.Size(42, 17);
            this.labEmailAdministrador.TabIndex = 6;
            this.labEmailAdministrador.Text = "Email";
            // 
            // labPasswordAdministrador
            // 
            this.labPasswordAdministrador.AutoSize = true;
            this.labPasswordAdministrador.Location = new System.Drawing.Point(20, 84);
            this.labPasswordAdministrador.Name = "labPasswordAdministrador";
            this.labPasswordAdministrador.Size = new System.Drawing.Size(69, 17);
            this.labPasswordAdministrador.TabIndex = 2;
            this.labPasswordAdministrador.Text = "Password";
            // 
            // labUsernameAdministrador
            // 
            this.labUsernameAdministrador.AutoSize = true;
            this.labUsernameAdministrador.Location = new System.Drawing.Point(20, 50);
            this.labUsernameAdministrador.Name = "labUsernameAdministrador";
            this.labUsernameAdministrador.Size = new System.Drawing.Size(73, 17);
            this.labUsernameAdministrador.TabIndex = 1;
            this.labUsernameAdministrador.Text = "Username";
            // 
            // gbGArbitroForm
            // 
            this.gbGArbitroForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGArbitroForm.Controls.Add(this.pbAvatarArbitro);
            this.gbGArbitroForm.Controls.Add(this.labUsernameArbitro);
            this.gbGArbitroForm.Controls.Add(this.txtUsernameArbitro);
            this.gbGArbitroForm.Controls.Add(this.labPasswordArbitro);
            this.gbGArbitroForm.Controls.Add(this.txtPasswordArbitro);
            this.gbGArbitroForm.Controls.Add(this.labNomeArbitro);
            this.gbGArbitroForm.Controls.Add(this.txtNomeArbitro);
            this.gbGArbitroForm.Controls.Add(this.labAvatarArbitro);
            this.gbGArbitroForm.Controls.Add(this.txtAvatarArbitro);
            this.gbGArbitroForm.Controls.Add(this.btnProcurarAvatar);
            this.gbGArbitroForm.Controls.Add(this.btnAcaoArbitro);
            this.gbGArbitroForm.Controls.Add(this.btnCancelarArbitro);
            this.gbGArbitroForm.Location = new System.Drawing.Point(704, 0);
            this.gbGArbitroForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGArbitroForm.Name = "gbGArbitroForm";
            this.gbGArbitroForm.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGArbitroForm.Size = new System.Drawing.Size(325, 489);
            this.gbGArbitroForm.TabIndex = 16;
            this.gbGArbitroForm.TabStop = false;
            this.gbGArbitroForm.Text = "Campos";
            this.gbGArbitroForm.Visible = false;
            // 
            // pbAvatarArbitro
            // 
            this.pbAvatarArbitro.Location = new System.Drawing.Point(75, 185);
            this.pbAvatarArbitro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbAvatarArbitro.Name = "pbAvatarArbitro";
            this.pbAvatarArbitro.Size = new System.Drawing.Size(120, 111);
            this.pbAvatarArbitro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatarArbitro.TabIndex = 16;
            this.pbAvatarArbitro.TabStop = false;
            // 
            // labUsernameArbitro
            // 
            this.labUsernameArbitro.AutoSize = true;
            this.labUsernameArbitro.Location = new System.Drawing.Point(20, 50);
            this.labUsernameArbitro.Name = "labUsernameArbitro";
            this.labUsernameArbitro.Size = new System.Drawing.Size(73, 17);
            this.labUsernameArbitro.TabIndex = 1;
            this.labUsernameArbitro.Text = "Username";
            // 
            // txtUsernameArbitro
            // 
            this.txtUsernameArbitro.Location = new System.Drawing.Point(99, 47);
            this.txtUsernameArbitro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsernameArbitro.Name = "txtUsernameArbitro";
            this.txtUsernameArbitro.Size = new System.Drawing.Size(197, 22);
            this.txtUsernameArbitro.TabIndex = 7;
            // 
            // labPasswordArbitro
            // 
            this.labPasswordArbitro.AutoSize = true;
            this.labPasswordArbitro.Location = new System.Drawing.Point(20, 84);
            this.labPasswordArbitro.Name = "labPasswordArbitro";
            this.labPasswordArbitro.Size = new System.Drawing.Size(69, 17);
            this.labPasswordArbitro.TabIndex = 2;
            this.labPasswordArbitro.Text = "Password";
            // 
            // txtPasswordArbitro
            // 
            this.txtPasswordArbitro.Location = new System.Drawing.Point(96, 80);
            this.txtPasswordArbitro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordArbitro.Name = "txtPasswordArbitro";
            this.txtPasswordArbitro.Size = new System.Drawing.Size(200, 22);
            this.txtPasswordArbitro.TabIndex = 8;
            this.txtPasswordArbitro.UseSystemPasswordChar = true;
            // 
            // labNomeArbitro
            // 
            this.labNomeArbitro.AutoSize = true;
            this.labNomeArbitro.Location = new System.Drawing.Point(20, 121);
            this.labNomeArbitro.Name = "labNomeArbitro";
            this.labNomeArbitro.Size = new System.Drawing.Size(45, 17);
            this.labNomeArbitro.TabIndex = 3;
            this.labNomeArbitro.Text = "Nome";
            // 
            // txtNomeArbitro
            // 
            this.txtNomeArbitro.Location = new System.Drawing.Point(72, 117);
            this.txtNomeArbitro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeArbitro.Name = "txtNomeArbitro";
            this.txtNomeArbitro.Size = new System.Drawing.Size(224, 22);
            this.txtNomeArbitro.TabIndex = 10;
            // 
            // labAvatarArbitro
            // 
            this.labAvatarArbitro.AutoSize = true;
            this.labAvatarArbitro.Location = new System.Drawing.Point(20, 158);
            this.labAvatarArbitro.Name = "labAvatarArbitro";
            this.labAvatarArbitro.Size = new System.Drawing.Size(49, 17);
            this.labAvatarArbitro.TabIndex = 5;
            this.labAvatarArbitro.Text = "Avatar";
            // 
            // txtAvatarArbitro
            // 
            this.txtAvatarArbitro.Location = new System.Drawing.Point(75, 154);
            this.txtAvatarArbitro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAvatarArbitro.Name = "txtAvatarArbitro";
            this.txtAvatarArbitro.Size = new System.Drawing.Size(132, 22);
            this.txtAvatarArbitro.TabIndex = 11;
            // 
            // btnProcurarAvatar
            // 
            this.btnProcurarAvatar.Location = new System.Drawing.Point(215, 154);
            this.btnProcurarAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProcurarAvatar.Name = "btnProcurarAvatar";
            this.btnProcurarAvatar.Size = new System.Drawing.Size(83, 25);
            this.btnProcurarAvatar.TabIndex = 12;
            this.btnProcurarAvatar.Text = "Procurar";
            this.btnProcurarAvatar.UseVisualStyleBackColor = true;
            this.btnProcurarAvatar.Click += new System.EventHandler(this.BotaoProcurarAvatar);
            // 
            // btnAcaoArbitro
            // 
            this.btnAcaoArbitro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcaoArbitro.Location = new System.Drawing.Point(129, 446);
            this.btnAcaoArbitro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAcaoArbitro.Name = "btnAcaoArbitro";
            this.btnAcaoArbitro.Size = new System.Drawing.Size(80, 31);
            this.btnAcaoArbitro.TabIndex = 14;
            this.btnAcaoArbitro.Text = "Ação";
            this.btnAcaoArbitro.UseVisualStyleBackColor = true;
            this.btnAcaoArbitro.Click += new System.EventHandler(this.BotaoAcaoArbitro);
            // 
            // btnCancelarArbitro
            // 
            this.btnCancelarArbitro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarArbitro.Location = new System.Drawing.Point(215, 446);
            this.btnCancelarArbitro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarArbitro.Name = "btnCancelarArbitro";
            this.btnCancelarArbitro.Size = new System.Drawing.Size(83, 31);
            this.btnCancelarArbitro.TabIndex = 15;
            this.btnCancelarArbitro.Text = "Cancelar";
            this.btnCancelarArbitro.UseVisualStyleBackColor = true;
            this.btnCancelarArbitro.Click += new System.EventHandler(this.BotaoCancelarArbitro);
            // 
            // tbVer
            // 
            this.tbVer.Controls.Add(this.tcVer);
            this.tbVer.Location = new System.Drawing.Point(4, 25);
            this.tbVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVer.Name = "tbVer";
            this.tbVer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVer.Size = new System.Drawing.Size(1051, 517);
            this.tbVer.TabIndex = 1;
            this.tbVer.Text = "Ver";
            this.tbVer.UseVisualStyleBackColor = true;
            // 
            // tcVer
            // 
            this.tcVer.Controls.Add(this.tbVerJogadores);
            this.tcVer.Controls.Add(this.tbVerEquipas);
            this.tcVer.Controls.Add(this.tbVerTorneios);
            this.tcVer.Controls.Add(this.tbVerCartas);
            this.tcVer.Controls.Add(this.tbVerBaralhos);
            this.tcVer.Controls.Add(this.tbVerUtilizadores);
            this.tcVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcVer.Location = new System.Drawing.Point(3, 2);
            this.tcVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcVer.Name = "tcVer";
            this.tcVer.SelectedIndex = 0;
            this.tcVer.Size = new System.Drawing.Size(1045, 513);
            this.tcVer.TabIndex = 0;
            this.tcVer.Enter += new System.EventHandler(this.TabPesquisaUtilizadores);
            // 
            // tbVerJogadores
            // 
            this.tbVerJogadores.Controls.Add(this.nudIdadeJogador2);
            this.tbVerJogadores.Controls.Add(this.label39);
            this.tbVerJogadores.Controls.Add(this.txtNicknameJogador2);
            this.tbVerJogadores.Controls.Add(this.txtnickname);
            this.tbVerJogadores.Controls.Add(this.txtEmailJogador2);
            this.tbVerJogadores.Controls.Add(this.label38);
            this.tbVerJogadores.Controls.Add(this.txtNomeJogador2);
            this.tbVerJogadores.Controls.Add(this.label37);
            this.tbVerJogadores.Controls.Add(this.dgvGListaJogadoresPesquisa);
            this.tbVerJogadores.Location = new System.Drawing.Point(4, 25);
            this.tbVerJogadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVerJogadores.Name = "tbVerJogadores";
            this.tbVerJogadores.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVerJogadores.Size = new System.Drawing.Size(1037, 484);
            this.tbVerJogadores.TabIndex = 0;
            this.tbVerJogadores.Text = "Jogadores";
            this.tbVerJogadores.UseVisualStyleBackColor = true;
            // 
            // nudIdadeJogador2
            // 
            this.nudIdadeJogador2.Location = new System.Drawing.Point(631, 98);
            this.nudIdadeJogador2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudIdadeJogador2.Name = "nudIdadeJogador2";
            this.nudIdadeJogador2.Size = new System.Drawing.Size(84, 22);
            this.nudIdadeJogador2.TabIndex = 23;
            this.nudIdadeJogador2.ValueChanged += new System.EventHandler(this.pesquisarJogadores);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(561, 101);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(47, 17);
            this.label39.TabIndex = 22;
            this.label39.Text = "Idade:";
            // 
            // txtNicknameJogador2
            // 
            this.txtNicknameJogador2.Location = new System.Drawing.Point(124, 94);
            this.txtNicknameJogador2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNicknameJogador2.Name = "txtNicknameJogador2";
            this.txtNicknameJogador2.Size = new System.Drawing.Size(372, 22);
            this.txtNicknameJogador2.TabIndex = 21;
            this.txtNicknameJogador2.TextChanged += new System.EventHandler(this.pesquisarJogadores);
            // 
            // txtnickname
            // 
            this.txtnickname.AutoSize = true;
            this.txtnickname.Location = new System.Drawing.Point(45, 97);
            this.txtnickname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtnickname.Name = "txtnickname";
            this.txtnickname.Size = new System.Drawing.Size(74, 17);
            this.txtnickname.TabIndex = 20;
            this.txtnickname.Text = "Nickname:";
            // 
            // txtEmailJogador2
            // 
            this.txtEmailJogador2.Location = new System.Drawing.Point(631, 33);
            this.txtEmailJogador2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailJogador2.Name = "txtEmailJogador2";
            this.txtEmailJogador2.Size = new System.Drawing.Size(339, 22);
            this.txtEmailJogador2.TabIndex = 19;
            this.txtEmailJogador2.TextChanged += new System.EventHandler(this.pesquisarJogadores);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(561, 37);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(46, 17);
            this.label38.TabIndex = 18;
            this.label38.Text = "Email:";
            // 
            // txtNomeJogador2
            // 
            this.txtNomeJogador2.Location = new System.Drawing.Point(124, 33);
            this.txtNomeJogador2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeJogador2.Name = "txtNomeJogador2";
            this.txtNomeJogador2.Size = new System.Drawing.Size(372, 22);
            this.txtNomeJogador2.TabIndex = 17;
            this.txtNomeJogador2.TextChanged += new System.EventHandler(this.pesquisarJogadores);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(45, 37);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(49, 17);
            this.label37.TabIndex = 16;
            this.label37.Text = "Nome:";
            // 
            // dgvGListaJogadoresPesquisa
            // 
            this.dgvGListaJogadoresPesquisa.AllowUserToAddRows = false;
            this.dgvGListaJogadoresPesquisa.AllowUserToDeleteRows = false;
            this.dgvGListaJogadoresPesquisa.AutoGenerateColumns = false;
            this.dgvGListaJogadoresPesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGListaJogadoresPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGListaJogadoresPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn6,
            this.nameDataGridViewTextBoxColumn6,
            this.emailDataGridViewTextBoxColumn1,
            this.nicknameDataGridViewTextBoxColumn1,
            this.ageDataGridViewTextBoxColumn1,
            this.avatarDataGridViewTextBoxColumn2});
            this.dgvGListaJogadoresPesquisa.DataSource = this.playerSetBindingSource;
            this.dgvGListaJogadoresPesquisa.Location = new System.Drawing.Point(31, 142);
            this.dgvGListaJogadoresPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGListaJogadoresPesquisa.Name = "dgvGListaJogadoresPesquisa";
            this.dgvGListaJogadoresPesquisa.ReadOnly = true;
            this.dgvGListaJogadoresPesquisa.RowHeadersVisible = false;
            this.dgvGListaJogadoresPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGListaJogadoresPesquisa.Size = new System.Drawing.Size(971, 320);
            this.dgvGListaJogadoresPesquisa.TabIndex = 14;
            // 
            // idDataGridViewTextBoxColumn6
            // 
            this.idDataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn6.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn6.Name = "idDataGridViewTextBoxColumn6";
            this.idDataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn6
            // 
            this.nameDataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn6.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn6.Name = "nameDataGridViewTextBoxColumn6";
            this.nameDataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nicknameDataGridViewTextBoxColumn1
            // 
            this.nicknameDataGridViewTextBoxColumn1.DataPropertyName = "Nickname";
            this.nicknameDataGridViewTextBoxColumn1.HeaderText = "Nickname";
            this.nicknameDataGridViewTextBoxColumn1.Name = "nicknameDataGridViewTextBoxColumn1";
            this.nicknameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn1
            // 
            this.ageDataGridViewTextBoxColumn1.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn1.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn1.Name = "ageDataGridViewTextBoxColumn1";
            this.ageDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // avatarDataGridViewTextBoxColumn2
            // 
            this.avatarDataGridViewTextBoxColumn2.DataPropertyName = "Avatar";
            this.avatarDataGridViewTextBoxColumn2.HeaderText = "Avatar";
            this.avatarDataGridViewTextBoxColumn2.Name = "avatarDataGridViewTextBoxColumn2";
            this.avatarDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tbVerEquipas
            // 
            this.tbVerEquipas.Controls.Add(this.btlimpar);
            this.tbVerEquipas.Controls.Add(this.cbnomejogadorpesquisa);
            this.tbVerEquipas.Controls.Add(this.label41);
            this.tbVerEquipas.Controls.Add(this.tbxnomeequipapesquisa);
            this.tbVerEquipas.Controls.Add(this.label40);
            this.tbVerEquipas.Controls.Add(this.dgvGListaEquipasPesquisa);
            this.tbVerEquipas.Location = new System.Drawing.Point(4, 25);
            this.tbVerEquipas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVerEquipas.Name = "tbVerEquipas";
            this.tbVerEquipas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVerEquipas.Size = new System.Drawing.Size(1037, 492);
            this.tbVerEquipas.TabIndex = 1;
            this.tbVerEquipas.Text = "Equipas";
            this.tbVerEquipas.UseVisualStyleBackColor = true;
            // 
            // btlimpar
            // 
            this.btlimpar.Location = new System.Drawing.Point(795, 42);
            this.btlimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(100, 28);
            this.btlimpar.TabIndex = 11;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // cbnomejogadorpesquisa
            // 
            this.cbnomejogadorpesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnomejogadorpesquisa.FormattingEnabled = true;
            this.cbnomejogadorpesquisa.Location = new System.Drawing.Point(585, 44);
            this.cbnomejogadorpesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbnomejogadorpesquisa.Name = "cbnomejogadorpesquisa";
            this.cbnomejogadorpesquisa.Size = new System.Drawing.Size(173, 24);
            this.cbnomejogadorpesquisa.TabIndex = 10;
            this.cbnomejogadorpesquisa.SelectedIndexChanged += new System.EventHandler(this.pesquisarEquipas);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(453, 48);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(124, 17);
            this.label41.TabIndex = 9;
            this.label41.Text = "Contém o jogador:";
            // 
            // tbxnomeequipapesquisa
            // 
            this.tbxnomeequipapesquisa.Location = new System.Drawing.Point(123, 44);
            this.tbxnomeequipapesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxnomeequipapesquisa.Name = "tbxnomeequipapesquisa";
            this.tbxnomeequipapesquisa.Size = new System.Drawing.Size(281, 22);
            this.tbxnomeequipapesquisa.TabIndex = 8;
            this.tbxnomeequipapesquisa.Click += new System.EventHandler(this.pesquisarEquipas);
            this.tbxnomeequipapesquisa.TextChanged += new System.EventHandler(this.pesquisarEquipas);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(64, 48);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(49, 17);
            this.label40.TabIndex = 7;
            this.label40.Text = "Nome:";
            // 
            // dgvGListaEquipasPesquisa
            // 
            this.dgvGListaEquipasPesquisa.AllowUserToAddRows = false;
            this.dgvGListaEquipasPesquisa.AllowUserToDeleteRows = false;
            this.dgvGListaEquipasPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGListaEquipasPesquisa.AutoGenerateColumns = false;
            this.dgvGListaEquipasPesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGListaEquipasPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGListaEquipasPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn7,
            this.nameDataGridViewTextBoxColumn7,
            this.avatarDataGridViewTextBoxColumn3});
            this.dgvGListaEquipasPesquisa.DataSource = this.teamSetBindingSource;
            this.dgvGListaEquipasPesquisa.Location = new System.Drawing.Point(44, 116);
            this.dgvGListaEquipasPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGListaEquipasPesquisa.Name = "dgvGListaEquipasPesquisa";
            this.dgvGListaEquipasPesquisa.ReadOnly = true;
            this.dgvGListaEquipasPesquisa.RowHeadersVisible = false;
            this.dgvGListaEquipasPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGListaEquipasPesquisa.Size = new System.Drawing.Size(971, 375);
            this.dgvGListaEquipasPesquisa.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn7
            // 
            this.idDataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn7.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn7.Name = "idDataGridViewTextBoxColumn7";
            this.idDataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn7
            // 
            this.nameDataGridViewTextBoxColumn7.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn7.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn7.Name = "nameDataGridViewTextBoxColumn7";
            this.nameDataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // avatarDataGridViewTextBoxColumn3
            // 
            this.avatarDataGridViewTextBoxColumn3.DataPropertyName = "Avatar";
            this.avatarDataGridViewTextBoxColumn3.HeaderText = "Avatar";
            this.avatarDataGridViewTextBoxColumn3.Name = "avatarDataGridViewTextBoxColumn3";
            this.avatarDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tbVerTorneios
            // 
            this.tbVerTorneios.Controls.Add(this.gbResultadosJogos);
            this.tbVerTorneios.Controls.Add(this.gbResultadosTorneios);
            this.tbVerTorneios.Controls.Add(this.gbPesquisarJogos);
            this.tbVerTorneios.Controls.Add(this.gbPesquisarTorneios);
            this.tbVerTorneios.Location = new System.Drawing.Point(4, 25);
            this.tbVerTorneios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVerTorneios.Name = "tbVerTorneios";
            this.tbVerTorneios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVerTorneios.Size = new System.Drawing.Size(1037, 484);
            this.tbVerTorneios.TabIndex = 2;
            this.tbVerTorneios.Text = "Torneios";
            this.tbVerTorneios.UseVisualStyleBackColor = true;
            this.tbVerTorneios.Enter += new System.EventHandler(this.TabVerTorneios);
            // 
            // gbResultadosJogos
            // 
            this.gbResultadosJogos.Controls.Add(this.dgvResultadosJogos);
            this.gbResultadosJogos.Location = new System.Drawing.Point(567, 272);
            this.gbResultadosJogos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbResultadosJogos.Name = "gbResultadosJogos";
            this.gbResultadosJogos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbResultadosJogos.Size = new System.Drawing.Size(461, 210);
            this.gbResultadosJogos.TabIndex = 3;
            this.gbResultadosJogos.TabStop = false;
            this.gbResultadosJogos.Text = "Resultados";
            // 
            // dgvResultadosJogos
            // 
            this.dgvResultadosJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadosJogos.Location = new System.Drawing.Point(8, 23);
            this.dgvResultadosJogos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvResultadosJogos.Name = "dgvResultadosJogos";
            this.dgvResultadosJogos.Size = new System.Drawing.Size(445, 180);
            this.dgvResultadosJogos.TabIndex = 0;
            // 
            // gbResultadosTorneios
            // 
            this.gbResultadosTorneios.Controls.Add(this.dgvResultadosTorneios);
            this.gbResultadosTorneios.Location = new System.Drawing.Point(567, 6);
            this.gbResultadosTorneios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbResultadosTorneios.Name = "gbResultadosTorneios";
            this.gbResultadosTorneios.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbResultadosTorneios.Size = new System.Drawing.Size(461, 258);
            this.gbResultadosTorneios.TabIndex = 2;
            this.gbResultadosTorneios.TabStop = false;
            this.gbResultadosTorneios.Text = "Resultados";
            // 
            // dgvResultadosTorneios
            // 
            this.dgvResultadosTorneios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadosTorneios.Location = new System.Drawing.Point(8, 23);
            this.dgvResultadosTorneios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvResultadosTorneios.Name = "dgvResultadosTorneios";
            this.dgvResultadosTorneios.Size = new System.Drawing.Size(445, 228);
            this.dgvResultadosTorneios.TabIndex = 0;
            // 
            // gbPesquisarJogos
            // 
            this.gbPesquisarJogos.Controls.Add(this.label23);
            this.gbPesquisarJogos.Controls.Add(this.dtpJogoData);
            this.gbPesquisarJogos.Controls.Add(this.label20);
            this.gbPesquisarJogos.Controls.Add(this.nupJogoNumero);
            this.gbPesquisarJogos.Controls.Add(this.radioPesquisarJogosStandard);
            this.gbPesquisarJogos.Controls.Add(this.radioPesquisarJogosTeam);
            this.gbPesquisarJogos.Controls.Add(this.btnLimparJogos);
            this.gbPesquisarJogos.Controls.Add(this.txtJogoNome);
            this.gbPesquisarJogos.Controls.Add(this.comboJogoArbitro);
            this.gbPesquisarJogos.Controls.Add(this.comboJogoDeck);
            this.gbPesquisarJogos.Controls.Add(this.comboJogoJogadorEquipa);
            this.gbPesquisarJogos.Controls.Add(this.label22);
            this.gbPesquisarJogos.Controls.Add(this.label21);
            this.gbPesquisarJogos.Controls.Add(this.labJogoJogadorEquipa);
            this.gbPesquisarJogos.Controls.Add(this.label19);
            this.gbPesquisarJogos.Location = new System.Drawing.Point(7, 272);
            this.gbPesquisarJogos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPesquisarJogos.Name = "gbPesquisarJogos";
            this.gbPesquisarJogos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPesquisarJogos.Size = new System.Drawing.Size(552, 210);
            this.gbPesquisarJogos.TabIndex = 1;
            this.gbPesquisarJogos.TabStop = false;
            this.gbPesquisarJogos.Text = "Jogos";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(344, 74);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 17);
            this.label23.TabIndex = 13;
            this.label23.Text = "Data";
            // 
            // dtpJogoData
            // 
            this.dtpJogoData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJogoData.Location = new System.Drawing.Point(392, 70);
            this.dtpJogoData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpJogoData.Name = "dtpJogoData";
            this.dtpJogoData.Size = new System.Drawing.Size(128, 22);
            this.dtpJogoData.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(344, 39);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 17);
            this.label20.TabIndex = 11;
            this.label20.Text = "Nº";
            // 
            // nupJogoNumero
            // 
            this.nupJogoNumero.Location = new System.Drawing.Point(392, 36);
            this.nupJogoNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nupJogoNumero.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nupJogoNumero.Name = "nupJogoNumero";
            this.nupJogoNumero.Size = new System.Drawing.Size(44, 22);
            this.nupJogoNumero.TabIndex = 10;
            this.nupJogoNumero.ValueChanged += new System.EventHandler(this.PesquisarJogos);
            // 
            // radioPesquisarJogosStandard
            // 
            this.radioPesquisarJogosStandard.AutoSize = true;
            this.radioPesquisarJogosStandard.Location = new System.Drawing.Point(81, 182);
            this.radioPesquisarJogosStandard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPesquisarJogosStandard.Name = "radioPesquisarJogosStandard";
            this.radioPesquisarJogosStandard.Size = new System.Drawing.Size(87, 21);
            this.radioPesquisarJogosStandard.TabIndex = 9;
            this.radioPesquisarJogosStandard.TabStop = true;
            this.radioPesquisarJogosStandard.Text = "Standard";
            this.radioPesquisarJogosStandard.UseVisualStyleBackColor = true;
            this.radioPesquisarJogosStandard.CheckedChanged += new System.EventHandler(this.RadioPesquisarJogosStandard);
            // 
            // radioPesquisarJogosTeam
            // 
            this.radioPesquisarJogosTeam.AutoSize = true;
            this.radioPesquisarJogosTeam.Location = new System.Drawing.Point(8, 182);
            this.radioPesquisarJogosTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPesquisarJogosTeam.Name = "radioPesquisarJogosTeam";
            this.radioPesquisarJogosTeam.Size = new System.Drawing.Size(65, 21);
            this.radioPesquisarJogosTeam.TabIndex = 8;
            this.radioPesquisarJogosTeam.TabStop = true;
            this.radioPesquisarJogosTeam.Text = "Team";
            this.radioPesquisarJogosTeam.UseVisualStyleBackColor = true;
            this.radioPesquisarJogosTeam.CheckedChanged += new System.EventHandler(this.RadioPesquisarJogosTeam);
            // 
            // btnLimparJogos
            // 
            this.btnLimparJogos.Location = new System.Drawing.Point(421, 164);
            this.btnLimparJogos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimparJogos.Name = "btnLimparJogos";
            this.btnLimparJogos.Size = new System.Drawing.Size(100, 28);
            this.btnLimparJogos.TabIndex = 7;
            this.btnLimparJogos.Text = "Limpar";
            this.btnLimparJogos.UseVisualStyleBackColor = true;
            this.btnLimparJogos.Click += new System.EventHandler(this.BotaoLimparJogos);
            // 
            // txtJogoNome
            // 
            this.txtJogoNome.Location = new System.Drawing.Point(108, 36);
            this.txtJogoNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJogoNome.Name = "txtJogoNome";
            this.txtJogoNome.Size = new System.Drawing.Size(211, 22);
            this.txtJogoNome.TabIndex = 7;
            this.txtJogoNome.TextChanged += new System.EventHandler(this.PesquisarJogos);
            // 
            // comboJogoArbitro
            // 
            this.comboJogoArbitro.FormattingEnabled = true;
            this.comboJogoArbitro.Location = new System.Drawing.Point(140, 138);
            this.comboJogoArbitro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboJogoArbitro.Name = "comboJogoArbitro";
            this.comboJogoArbitro.Size = new System.Drawing.Size(160, 24);
            this.comboJogoArbitro.TabIndex = 6;
            this.comboJogoArbitro.SelectedIndexChanged += new System.EventHandler(this.PesquisarJogos);
            // 
            // comboJogoDeck
            // 
            this.comboJogoDeck.FormattingEnabled = true;
            this.comboJogoDeck.Location = new System.Drawing.Point(143, 103);
            this.comboJogoDeck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboJogoDeck.Name = "comboJogoDeck";
            this.comboJogoDeck.Size = new System.Drawing.Size(160, 24);
            this.comboJogoDeck.TabIndex = 5;
            this.comboJogoDeck.SelectedIndexChanged += new System.EventHandler(this.PesquisarJogos);
            // 
            // comboJogoJogadorEquipa
            // 
            this.comboJogoJogadorEquipa.FormattingEnabled = true;
            this.comboJogoJogadorEquipa.Location = new System.Drawing.Point(159, 70);
            this.comboJogoJogadorEquipa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboJogoJogadorEquipa.Name = "comboJogoJogadorEquipa";
            this.comboJogoJogadorEquipa.Size = new System.Drawing.Size(160, 24);
            this.comboJogoJogadorEquipa.TabIndex = 4;
            this.comboJogoJogadorEquipa.SelectedIndexChanged += new System.EventHandler(this.PesquisarJogos);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(27, 142);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(114, 17);
            this.label22.TabIndex = 3;
            this.label22.Text = "Contem o Arbitro";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(27, 107);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 17);
            this.label21.TabIndex = 2;
            this.label21.Text = "Contem o Deck";
            // 
            // labJogoJogadorEquipa
            // 
            this.labJogoJogadorEquipa.AutoSize = true;
            this.labJogoJogadorEquipa.Location = new System.Drawing.Point(27, 74);
            this.labJogoJogadorEquipa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labJogoJogadorEquipa.Name = "labJogoJogadorEquipa";
            this.labJogoJogadorEquipa.Size = new System.Drawing.Size(124, 17);
            this.labJogoJogadorEquipa.TabIndex = 1;
            this.labJogoJogadorEquipa.Text = "Contem o Jogador";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(27, 39);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "Descrição";
            // 
            // gbPesquisarTorneios
            // 
            this.gbPesquisarTorneios.Controls.Add(this.radioPesquisarTorneiosStandard);
            this.gbPesquisarTorneios.Controls.Add(this.radioPesquisarTorneiosTeam);
            this.gbPesquisarTorneios.Controls.Add(this.btnLimparTorneios);
            this.gbPesquisarTorneios.Controls.Add(this.txtTorneioDescricao);
            this.gbPesquisarTorneios.Controls.Add(this.txtTorneioNome);
            this.gbPesquisarTorneios.Controls.Add(this.label18);
            this.gbPesquisarTorneios.Controls.Add(this.label17);
            this.gbPesquisarTorneios.Controls.Add(this.dtpTorneioData);
            this.gbPesquisarTorneios.Controls.Add(this.label16);
            this.gbPesquisarTorneios.Location = new System.Drawing.Point(7, 6);
            this.gbPesquisarTorneios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPesquisarTorneios.Name = "gbPesquisarTorneios";
            this.gbPesquisarTorneios.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPesquisarTorneios.Size = new System.Drawing.Size(552, 258);
            this.gbPesquisarTorneios.TabIndex = 0;
            this.gbPesquisarTorneios.TabStop = false;
            this.gbPesquisarTorneios.Text = "Torneios";
            // 
            // radioPesquisarTorneiosStandard
            // 
            this.radioPesquisarTorneiosStandard.AutoSize = true;
            this.radioPesquisarTorneiosStandard.Location = new System.Drawing.Point(81, 230);
            this.radioPesquisarTorneiosStandard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPesquisarTorneiosStandard.Name = "radioPesquisarTorneiosStandard";
            this.radioPesquisarTorneiosStandard.Size = new System.Drawing.Size(87, 21);
            this.radioPesquisarTorneiosStandard.TabIndex = 10;
            this.radioPesquisarTorneiosStandard.TabStop = true;
            this.radioPesquisarTorneiosStandard.Text = "Standard";
            this.radioPesquisarTorneiosStandard.UseVisualStyleBackColor = true;
            this.radioPesquisarTorneiosStandard.CheckedChanged += new System.EventHandler(this.RadioPesquisarTorneiosStandard);
            // 
            // radioPesquisarTorneiosTeam
            // 
            this.radioPesquisarTorneiosTeam.AutoSize = true;
            this.radioPesquisarTorneiosTeam.Location = new System.Drawing.Point(8, 230);
            this.radioPesquisarTorneiosTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPesquisarTorneiosTeam.Name = "radioPesquisarTorneiosTeam";
            this.radioPesquisarTorneiosTeam.Size = new System.Drawing.Size(65, 21);
            this.radioPesquisarTorneiosTeam.TabIndex = 9;
            this.radioPesquisarTorneiosTeam.TabStop = true;
            this.radioPesquisarTorneiosTeam.Text = "Team";
            this.radioPesquisarTorneiosTeam.UseVisualStyleBackColor = true;
            this.radioPesquisarTorneiosTeam.CheckedChanged += new System.EventHandler(this.RadioPesquisarTorneiosTeam);
            // 
            // btnLimparTorneios
            // 
            this.btnLimparTorneios.Location = new System.Drawing.Point(421, 209);
            this.btnLimparTorneios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimparTorneios.Name = "btnLimparTorneios";
            this.btnLimparTorneios.Size = new System.Drawing.Size(100, 28);
            this.btnLimparTorneios.TabIndex = 6;
            this.btnLimparTorneios.Text = "Limpar";
            this.btnLimparTorneios.UseVisualStyleBackColor = true;
            this.btnLimparTorneios.Click += new System.EventHandler(this.BotaoLimparTorneios);
            // 
            // txtTorneioDescricao
            // 
            this.txtTorneioDescricao.Location = new System.Drawing.Point(108, 86);
            this.txtTorneioDescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTorneioDescricao.Multiline = true;
            this.txtTorneioDescricao.Name = "txtTorneioDescricao";
            this.txtTorneioDescricao.Size = new System.Drawing.Size(315, 102);
            this.txtTorneioDescricao.TabIndex = 5;
            this.txtTorneioDescricao.TextChanged += new System.EventHandler(this.PesquisarTorneios);
            // 
            // txtTorneioNome
            // 
            this.txtTorneioNome.Location = new System.Drawing.Point(81, 30);
            this.txtTorneioNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTorneioNome.Name = "txtTorneioNome";
            this.txtTorneioNome.Size = new System.Drawing.Size(159, 22);
            this.txtTorneioNome.TabIndex = 4;
            this.txtTorneioNome.TextChanged += new System.EventHandler(this.PesquisarTorneios);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(261, 33);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 17);
            this.label18.TabIndex = 3;
            this.label18.Text = "Data";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 90);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 17);
            this.label17.TabIndex = 2;
            this.label17.Text = "Descrição";
            // 
            // dtpTorneioData
            // 
            this.dtpTorneioData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTorneioData.Location = new System.Drawing.Point(309, 30);
            this.dtpTorneioData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpTorneioData.Name = "dtpTorneioData";
            this.dtpTorneioData.Size = new System.Drawing.Size(128, 22);
            this.dtpTorneioData.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 33);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Nome";
            // 
            // tbVerCartas
            // 
            this.tbVerCartas.Controls.Add(this.btnVLimparCartas);
            this.tbVerCartas.Controls.Add(this.nudVDefesaCarta);
            this.tbVerCartas.Controls.Add(this.nudVAtaqueCarta);
            this.tbVerCartas.Controls.Add(this.nudVLealdadeCarta);
            this.tbVerCartas.Controls.Add(this.txtVCustoCarta);
            this.tbVerCartas.Controls.Add(this.cmbVTipoCarta);
            this.tbVerCartas.Controls.Add(this.cmbVFacaoCarta);
            this.tbVerCartas.Controls.Add(this.txtVNomeCarta);
            this.tbVerCartas.Controls.Add(this.label9);
            this.tbVerCartas.Controls.Add(this.label10);
            this.tbVerCartas.Controls.Add(this.label11);
            this.tbVerCartas.Controls.Add(this.label12);
            this.tbVerCartas.Controls.Add(this.label13);
            this.tbVerCartas.Controls.Add(this.label42);
            this.tbVerCartas.Controls.Add(this.label43);
            this.tbVerCartas.Controls.Add(this.dgvVCartasLista);
            this.tbVerCartas.Location = new System.Drawing.Point(4, 25);
            this.tbVerCartas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVerCartas.Name = "tbVerCartas";
            this.tbVerCartas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVerCartas.Size = new System.Drawing.Size(1037, 492);
            this.tbVerCartas.TabIndex = 3;
            this.tbVerCartas.Text = "Cartas";
            this.tbVerCartas.UseVisualStyleBackColor = true;
            // 
            // btnVLimparCartas
            // 
            this.btnVLimparCartas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVLimparCartas.Location = new System.Drawing.Point(840, 105);
            this.btnVLimparCartas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVLimparCartas.Name = "btnVLimparCartas";
            this.btnVLimparCartas.Size = new System.Drawing.Size(99, 33);
            this.btnVLimparCartas.TabIndex = 46;
            this.btnVLimparCartas.Text = "Limpar";
            this.btnVLimparCartas.UseVisualStyleBackColor = true;
            this.btnVLimparCartas.Click += new System.EventHandler(this.btnVLimparCartas_Click);
            // 
            // nudVDefesaCarta
            // 
            this.nudVDefesaCarta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudVDefesaCarta.Location = new System.Drawing.Point(669, 107);
            this.nudVDefesaCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudVDefesaCarta.Name = "nudVDefesaCarta";
            this.nudVDefesaCarta.Size = new System.Drawing.Size(55, 22);
            this.nudVDefesaCarta.TabIndex = 45;
            this.nudVDefesaCarta.ValueChanged += new System.EventHandler(this.pesquisaCartas);
            // 
            // nudVAtaqueCarta
            // 
            this.nudVAtaqueCarta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudVAtaqueCarta.Location = new System.Drawing.Point(525, 105);
            this.nudVAtaqueCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudVAtaqueCarta.Name = "nudVAtaqueCarta";
            this.nudVAtaqueCarta.Size = new System.Drawing.Size(55, 22);
            this.nudVAtaqueCarta.TabIndex = 44;
            this.nudVAtaqueCarta.ValueChanged += new System.EventHandler(this.pesquisaCartas);
            // 
            // nudVLealdadeCarta
            // 
            this.nudVLealdadeCarta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudVLealdadeCarta.Location = new System.Drawing.Point(381, 107);
            this.nudVLealdadeCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudVLealdadeCarta.Name = "nudVLealdadeCarta";
            this.nudVLealdadeCarta.Size = new System.Drawing.Size(55, 22);
            this.nudVLealdadeCarta.TabIndex = 43;
            this.nudVLealdadeCarta.ValueChanged += new System.EventHandler(this.pesquisaCartas);
            // 
            // txtVCustoCarta
            // 
            this.txtVCustoCarta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVCustoCarta.Location = new System.Drawing.Point(201, 103);
            this.txtVCustoCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVCustoCarta.Name = "txtVCustoCarta";
            this.txtVCustoCarta.Size = new System.Drawing.Size(69, 22);
            this.txtVCustoCarta.TabIndex = 42;
            this.txtVCustoCarta.TextChanged += new System.EventHandler(this.pesquisaCartas);
            // 
            // cmbVTipoCarta
            // 
            this.cmbVTipoCarta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbVTipoCarta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVTipoCarta.FormattingEnabled = true;
            this.cmbVTipoCarta.Items.AddRange(new object[] {
            "Criatura",
            "Evento",
            "Equipamento",
            "Magia",
            "Encantamento",
            "Cidade"});
            this.cmbVTipoCarta.Location = new System.Drawing.Point(817, 53);
            this.cmbVTipoCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVTipoCarta.Name = "cmbVTipoCarta";
            this.cmbVTipoCarta.Size = new System.Drawing.Size(180, 24);
            this.cmbVTipoCarta.TabIndex = 41;
            this.cmbVTipoCarta.SelectedIndexChanged += new System.EventHandler(this.pesquisaCartas);
            // 
            // cmbVFacaoCarta
            // 
            this.cmbVFacaoCarta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbVFacaoCarta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVFacaoCarta.FormattingEnabled = true;
            this.cmbVFacaoCarta.Items.AddRange(new object[] {
            "Gaian Love for Life",
            "Uneasy Alliance"});
            this.cmbVFacaoCarta.Location = new System.Drawing.Point(503, 50);
            this.cmbVFacaoCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVFacaoCarta.Name = "cmbVFacaoCarta";
            this.cmbVFacaoCarta.Size = new System.Drawing.Size(196, 24);
            this.cmbVFacaoCarta.TabIndex = 40;
            this.cmbVFacaoCarta.SelectedIndexChanged += new System.EventHandler(this.pesquisaCartas);
            // 
            // txtVNomeCarta
            // 
            this.txtVNomeCarta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVNomeCarta.Location = new System.Drawing.Point(129, 50);
            this.txtVNomeCarta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVNomeCarta.Name = "txtVNomeCarta";
            this.txtVNomeCarta.Size = new System.Drawing.Size(261, 22);
            this.txtVNomeCarta.TabIndex = 39;
            this.txtVNomeCarta.TextChanged += new System.EventHandler(this.pesquisaCartas);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(609, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Defesa";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(465, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Ataque";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(308, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Lealdade";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(151, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "Custo";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(763, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Tipo";
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(448, 54);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(47, 17);
            this.label42.TabIndex = 33;
            this.label42.Text = "Fação";
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(27, 54);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(95, 17);
            this.label43.TabIndex = 32;
            this.label43.Text = "Nome contém";
            // 
            // dgvVCartasLista
            // 
            this.dgvVCartasLista.AllowUserToAddRows = false;
            this.dgvVCartasLista.AllowUserToDeleteRows = false;
            this.dgvVCartasLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVCartasLista.AutoGenerateColumns = false;
            this.dgvVCartasLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVCartasLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.factionDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn1,
            this.costDataGridViewTextBoxColumn1,
            this.loyaltyDataGridViewTextBoxColumn1,
            this.ruleTextDataGridViewTextBoxColumn1,
            this.attackDataGridViewTextBoxColumn1,
            this.defenseDataGridViewTextBoxColumn1});
            this.dgvVCartasLista.DataSource = this.cardSetBindingSource;
            this.dgvVCartasLista.Location = new System.Drawing.Point(31, 180);
            this.dgvVCartasLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVCartasLista.Name = "dgvVCartasLista";
            this.dgvVCartasLista.ReadOnly = true;
            this.dgvVCartasLista.RowTemplate.Height = 24;
            this.dgvVCartasLista.Size = new System.Drawing.Size(987, 324);
            this.dgvVCartasLista.TabIndex = 31;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // factionDataGridViewTextBoxColumn1
            // 
            this.factionDataGridViewTextBoxColumn1.DataPropertyName = "Faction";
            this.factionDataGridViewTextBoxColumn1.HeaderText = "Faction";
            this.factionDataGridViewTextBoxColumn1.Name = "factionDataGridViewTextBoxColumn1";
            this.factionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            this.typeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn1
            // 
            this.costDataGridViewTextBoxColumn1.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn1.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn1.Name = "costDataGridViewTextBoxColumn1";
            this.costDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // loyaltyDataGridViewTextBoxColumn1
            // 
            this.loyaltyDataGridViewTextBoxColumn1.DataPropertyName = "Loyalty";
            this.loyaltyDataGridViewTextBoxColumn1.HeaderText = "Loyalty";
            this.loyaltyDataGridViewTextBoxColumn1.Name = "loyaltyDataGridViewTextBoxColumn1";
            this.loyaltyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ruleTextDataGridViewTextBoxColumn1
            // 
            this.ruleTextDataGridViewTextBoxColumn1.DataPropertyName = "RuleText";
            this.ruleTextDataGridViewTextBoxColumn1.HeaderText = "RuleText";
            this.ruleTextDataGridViewTextBoxColumn1.Name = "ruleTextDataGridViewTextBoxColumn1";
            this.ruleTextDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // attackDataGridViewTextBoxColumn1
            // 
            this.attackDataGridViewTextBoxColumn1.DataPropertyName = "Attack";
            this.attackDataGridViewTextBoxColumn1.HeaderText = "Attack";
            this.attackDataGridViewTextBoxColumn1.Name = "attackDataGridViewTextBoxColumn1";
            this.attackDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // defenseDataGridViewTextBoxColumn1
            // 
            this.defenseDataGridViewTextBoxColumn1.DataPropertyName = "Defense";
            this.defenseDataGridViewTextBoxColumn1.HeaderText = "Defense";
            this.defenseDataGridViewTextBoxColumn1.Name = "defenseDataGridViewTextBoxColumn1";
            this.defenseDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tbVerBaralhos
            // 
            this.tbVerBaralhos.Controls.Add(this.dgvVBaralhosLista);
            this.tbVerBaralhos.Controls.Add(this.btnVLimparBaralhos);
            this.tbVerBaralhos.Controls.Add(this.cmbVCartasnoBaralho);
            this.tbVerBaralhos.Controls.Add(this.label45);
            this.tbVerBaralhos.Controls.Add(this.label44);
            this.tbVerBaralhos.Controls.Add(this.txtVNomeBaralho);
            this.tbVerBaralhos.Location = new System.Drawing.Point(4, 25);
            this.tbVerBaralhos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVerBaralhos.Name = "tbVerBaralhos";
            this.tbVerBaralhos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVerBaralhos.Size = new System.Drawing.Size(1037, 492);
            this.tbVerBaralhos.TabIndex = 4;
            this.tbVerBaralhos.Text = "Baralhos";
            this.tbVerBaralhos.UseVisualStyleBackColor = true;
            this.tbVerBaralhos.Enter += new System.EventHandler(this.tbVerBaralhos_Enter);
            // 
            // dgvVBaralhosLista
            // 
            this.dgvVBaralhosLista.AllowUserToAddRows = false;
            this.dgvVBaralhosLista.AllowUserToDeleteRows = false;
            this.dgvVBaralhosLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVBaralhosLista.AutoGenerateColumns = false;
            this.dgvVBaralhosLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVBaralhosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVBaralhosLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn3});
            this.dgvVBaralhosLista.DataSource = this.deckSetBindingSource;
            this.dgvVBaralhosLista.Location = new System.Drawing.Point(35, 130);
            this.dgvVBaralhosLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvVBaralhosLista.Name = "dgvVBaralhosLista";
            this.dgvVBaralhosLista.ReadOnly = true;
            this.dgvVBaralhosLista.RowTemplate.Height = 24;
            this.dgvVBaralhosLista.Size = new System.Drawing.Size(963, 324);
            this.dgvVBaralhosLista.TabIndex = 38;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            this.nameDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // btnVLimparBaralhos
            // 
            this.btnVLimparBaralhos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVLimparBaralhos.Location = new System.Drawing.Point(864, 66);
            this.btnVLimparBaralhos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVLimparBaralhos.Name = "btnVLimparBaralhos";
            this.btnVLimparBaralhos.Size = new System.Drawing.Size(75, 33);
            this.btnVLimparBaralhos.TabIndex = 37;
            this.btnVLimparBaralhos.Text = "Limpar";
            this.btnVLimparBaralhos.UseVisualStyleBackColor = true;
            this.btnVLimparBaralhos.Click += new System.EventHandler(this.btnVLimparBaralhos_Click);
            // 
            // cmbVCartasnoBaralho
            // 
            this.cmbVCartasnoBaralho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbVCartasnoBaralho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVCartasnoBaralho.FormattingEnabled = true;
            this.cmbVCartasnoBaralho.Location = new System.Drawing.Point(577, 70);
            this.cmbVCartasnoBaralho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVCartasnoBaralho.Name = "cmbVCartasnoBaralho";
            this.cmbVCartasnoBaralho.Size = new System.Drawing.Size(243, 24);
            this.cmbVCartasnoBaralho.TabIndex = 36;
            this.cmbVCartasnoBaralho.SelectedIndexChanged += new System.EventHandler(this.pesquisaCartas);
            // 
            // label45
            // 
            this.label45.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(467, 74);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(104, 17);
            this.label45.TabIndex = 35;
            this.label45.Text = "Contém a carta";
            // 
            // label44
            // 
            this.label44.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(89, 74);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(95, 17);
            this.label44.TabIndex = 33;
            this.label44.Text = "Nome contém";
            // 
            // txtVNomeBaralho
            // 
            this.txtVNomeBaralho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVNomeBaralho.Location = new System.Drawing.Point(191, 71);
            this.txtVNomeBaralho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVNomeBaralho.Name = "txtVNomeBaralho";
            this.txtVNomeBaralho.Size = new System.Drawing.Size(251, 22);
            this.txtVNomeBaralho.TabIndex = 34;
            this.txtVNomeBaralho.TextChanged += new System.EventHandler(this.pesquisaBaralhos);
            // 
            // tbVerUtilizadores
            // 
            this.tbVerUtilizadores.Controls.Add(this.labPesquisarPor);
            this.tbVerUtilizadores.Controls.Add(this.radioPesquisaAdministrador);
            this.tbVerUtilizadores.Controls.Add(this.radioPesquisaArbitro);
            this.tbVerUtilizadores.Controls.Add(this.labPesquisaUsername);
            this.tbVerUtilizadores.Controls.Add(this.txtPesquisaUsername);
            this.tbVerUtilizadores.Controls.Add(this.labPesquisaNomeEmail);
            this.tbVerUtilizadores.Controls.Add(this.txtPesquisaNomeArbitro);
            this.tbVerUtilizadores.Controls.Add(this.txtPesquisaEmailAdministrador);
            this.tbVerUtilizadores.Controls.Add(this.checkPesquisaArbitroAtivo);
            this.tbVerUtilizadores.Controls.Add(this.btnPesquisarUtilizador);
            this.tbVerUtilizadores.Controls.Add(this.btnResetPesquisa);
            this.tbVerUtilizadores.Controls.Add(this.dgvPesquisaUtilizadores);
            this.tbVerUtilizadores.Location = new System.Drawing.Point(4, 25);
            this.tbVerUtilizadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVerUtilizadores.Name = "tbVerUtilizadores";
            this.tbVerUtilizadores.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVerUtilizadores.Size = new System.Drawing.Size(1037, 492);
            this.tbVerUtilizadores.TabIndex = 5;
            this.tbVerUtilizadores.Text = "Utilizadores";
            this.tbVerUtilizadores.UseVisualStyleBackColor = true;
            // 
            // labPesquisarPor
            // 
            this.labPesquisarPor.AutoSize = true;
            this.labPesquisarPor.Location = new System.Drawing.Point(40, 39);
            this.labPesquisarPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPesquisarPor.Name = "labPesquisarPor";
            this.labPesquisarPor.Size = new System.Drawing.Size(100, 17);
            this.labPesquisarPor.TabIndex = 0;
            this.labPesquisarPor.Text = "Pesquisar por:";
            // 
            // radioPesquisaAdministrador
            // 
            this.radioPesquisaAdministrador.AutoSize = true;
            this.radioPesquisaAdministrador.Checked = true;
            this.radioPesquisaAdministrador.Location = new System.Drawing.Point(147, 37);
            this.radioPesquisaAdministrador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPesquisaAdministrador.Name = "radioPesquisaAdministrador";
            this.radioPesquisaAdministrador.Size = new System.Drawing.Size(116, 21);
            this.radioPesquisaAdministrador.TabIndex = 2;
            this.radioPesquisaAdministrador.TabStop = true;
            this.radioPesquisaAdministrador.Text = "Administrador";
            this.radioPesquisaAdministrador.UseVisualStyleBackColor = true;
            this.radioPesquisaAdministrador.CheckedChanged += new System.EventHandler(this.RadioPesquisarAdministrador);
            // 
            // radioPesquisaArbitro
            // 
            this.radioPesquisaArbitro.AutoSize = true;
            this.radioPesquisaArbitro.Location = new System.Drawing.Point(272, 37);
            this.radioPesquisaArbitro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPesquisaArbitro.Name = "radioPesquisaArbitro";
            this.radioPesquisaArbitro.Size = new System.Drawing.Size(71, 21);
            this.radioPesquisaArbitro.TabIndex = 3;
            this.radioPesquisaArbitro.Text = "Arbitro";
            this.radioPesquisaArbitro.UseVisualStyleBackColor = true;
            this.radioPesquisaArbitro.CheckedChanged += new System.EventHandler(this.RadioPesquisarArbitro);
            // 
            // labPesquisaUsername
            // 
            this.labPesquisaUsername.AutoSize = true;
            this.labPesquisaUsername.Location = new System.Drawing.Point(131, 96);
            this.labPesquisaUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPesquisaUsername.Name = "labPesquisaUsername";
            this.labPesquisaUsername.Size = new System.Drawing.Size(77, 17);
            this.labPesquisaUsername.TabIndex = 1;
            this.labPesquisaUsername.Text = "Username:";
            // 
            // txtPesquisaUsername
            // 
            this.txtPesquisaUsername.Location = new System.Drawing.Point(212, 92);
            this.txtPesquisaUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisaUsername.Name = "txtPesquisaUsername";
            this.txtPesquisaUsername.Size = new System.Drawing.Size(132, 22);
            this.txtPesquisaUsername.TabIndex = 6;
            // 
            // labPesquisaNomeEmail
            // 
            this.labPesquisaNomeEmail.AutoSize = true;
            this.labPesquisaNomeEmail.Location = new System.Drawing.Point(367, 96);
            this.labPesquisaNomeEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPesquisaNomeEmail.Name = "labPesquisaNomeEmail";
            this.labPesquisaNomeEmail.Size = new System.Drawing.Size(49, 17);
            this.labPesquisaNomeEmail.TabIndex = 5;
            this.labPesquisaNomeEmail.Text = "Nome:";
            // 
            // txtPesquisaNomeArbitro
            // 
            this.txtPesquisaNomeArbitro.Location = new System.Drawing.Point(425, 92);
            this.txtPesquisaNomeArbitro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisaNomeArbitro.Name = "txtPesquisaNomeArbitro";
            this.txtPesquisaNomeArbitro.Size = new System.Drawing.Size(180, 22);
            this.txtPesquisaNomeArbitro.TabIndex = 8;
            // 
            // txtPesquisaEmailAdministrador
            // 
            this.txtPesquisaEmailAdministrador.Location = new System.Drawing.Point(425, 92);
            this.txtPesquisaEmailAdministrador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisaEmailAdministrador.Name = "txtPesquisaEmailAdministrador";
            this.txtPesquisaEmailAdministrador.Size = new System.Drawing.Size(207, 22);
            this.txtPesquisaEmailAdministrador.TabIndex = 7;
            // 
            // checkPesquisaArbitroAtivo
            // 
            this.checkPesquisaArbitroAtivo.AutoSize = true;
            this.checkPesquisaArbitroAtivo.Location = new System.Drawing.Point(661, 95);
            this.checkPesquisaArbitroAtivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkPesquisaArbitroAtivo.Name = "checkPesquisaArbitroAtivo";
            this.checkPesquisaArbitroAtivo.Size = new System.Drawing.Size(61, 21);
            this.checkPesquisaArbitroAtivo.TabIndex = 11;
            this.checkPesquisaArbitroAtivo.Text = "Ativo";
            this.checkPesquisaArbitroAtivo.UseVisualStyleBackColor = true;
            this.checkPesquisaArbitroAtivo.CheckedChanged += new System.EventHandler(this.CheckArbitroAtivo);
            // 
            // btnPesquisarUtilizador
            // 
            this.btnPesquisarUtilizador.Location = new System.Drawing.Point(752, 90);
            this.btnPesquisarUtilizador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisarUtilizador.Name = "btnPesquisarUtilizador";
            this.btnPesquisarUtilizador.Size = new System.Drawing.Size(100, 28);
            this.btnPesquisarUtilizador.TabIndex = 10;
            this.btnPesquisarUtilizador.Text = "Pesquisar";
            this.btnPesquisarUtilizador.UseVisualStyleBackColor = true;
            this.btnPesquisarUtilizador.Click += new System.EventHandler(this.PesquisaAvancadaUtilizador);
            // 
            // btnResetPesquisa
            // 
            this.btnResetPesquisa.Location = new System.Drawing.Point(872, 90);
            this.btnResetPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetPesquisa.Name = "btnResetPesquisa";
            this.btnResetPesquisa.Size = new System.Drawing.Size(100, 28);
            this.btnResetPesquisa.TabIndex = 12;
            this.btnResetPesquisa.Text = "Reset";
            this.btnResetPesquisa.UseVisualStyleBackColor = true;
            this.btnResetPesquisa.Click += new System.EventHandler(this.BotaoResetPesquisa);
            // 
            // dgvPesquisaUtilizadores
            // 
            this.dgvPesquisaUtilizadores.AllowUserToAddRows = false;
            this.dgvPesquisaUtilizadores.AllowUserToDeleteRows = false;
            this.dgvPesquisaUtilizadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPesquisaUtilizadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisaUtilizadores.Location = new System.Drawing.Point(25, 146);
            this.dgvPesquisaUtilizadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPesquisaUtilizadores.Name = "dgvPesquisaUtilizadores";
            this.dgvPesquisaUtilizadores.ReadOnly = true;
            this.dgvPesquisaUtilizadores.Size = new System.Drawing.Size(987, 322);
            this.dgvPesquisaUtilizadores.TabIndex = 9;
            // 
            // gameSetBindingSource
            // 
            this.gameSetBindingSource.DataMember = "GameSet";
            this.gameSetBindingSource.DataSource = this.bD_DA_ProjetoDataSet_Games;
            // 
            // bD_DA_ProjetoDataSet_Games
            // 
            this.bD_DA_ProjetoDataSet_Games.DataSetName = "BD_DA_ProjetoDataSet_Games";
            this.bD_DA_ProjetoDataSet_Games.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tournamentSetBindingSource
            // 
            this.tournamentSetBindingSource.DataMember = "TournamentSet";
            this.tournamentSetBindingSource.DataSource = this.bD_DA_ProjetoDataSet_Tournaments;
            // 
            // bD_DA_ProjetoDataSet_Tournaments
            // 
            this.bD_DA_ProjetoDataSet_Tournaments.DataSetName = "BD_DA_ProjetoDataSet_Tournaments";
            this.bD_DA_ProjetoDataSet_Tournaments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetAdministradores
            // 
            this.dataSetAdministradores.DataSetName = "BD_DA_ProjetoDataSet_Administradores";
            this.dataSetAdministradores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetArbitros
            // 
            this.dataSetArbitros.DataSetName = "BD_DA_ProjetoDataSet_Arbitros";
            this.dataSetArbitros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceAdminstradores
            // 
            this.bindingSourceAdminstradores.DataMember = "UserSet";
            this.bindingSourceAdminstradores.DataSource = this.dataSetAdministradores;
            // 
            // bindingSourceArbitros
            // 
            this.bindingSourceArbitros.DataMember = "UserSet";
            this.bindingSourceArbitros.DataSource = this.dataSetArbitros;
            // 
            // userSetTableAdapterAdministradores
            // 
            this.userSetTableAdapterAdministradores.ClearBeforeFill = true;
            // 
            // userSetTableAdapterArbitros
            // 
            this.userSetTableAdapterArbitros.ClearBeforeFill = true;
            // 
            // cardSetTableAdapter
            // 
            this.cardSetTableAdapter.ClearBeforeFill = true;
            // 
            // deckSetTableAdapter
            // 
            this.deckSetTableAdapter.ClearBeforeFill = true;
            // 
            // teamSetTableAdapter
            // 
            this.teamSetTableAdapter.ClearBeforeFill = true;
            // 
            // playerSetTableAdapter
            // 
            this.playerSetTableAdapter.ClearBeforeFill = true;
            // 
            // gameSetTableAdapter
            // 
            this.gameSetTableAdapter.ClearBeforeFill = true;
            // 
            // tournamentSetTableAdapter
            // 
            this.tournamentSetTableAdapter.ClearBeforeFill = true;
            // 
            // formMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 546);
            this.Controls.Add(this.tbMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1077, 593);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1077, 593);
            this.Name = "formMenuAdmin";
            this.Text = "Arcmage - Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formMenuAdmin_FormClosed);
            this.Load += new System.EventHandler(this.formMenuAdmin_Load);
            this.tbMenu.ResumeLayout(false);
            this.tpGestao.ResumeLayout(false);
            this.tcGestao.ResumeLayout(false);
            this.tbGestaoJogadores.ResumeLayout(false);
            this.gbGJogadoresForm.ResumeLayout(false);
            this.gbGJogadoresForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdadeJogador)).EndInit();
            this.gbGJogadoresDados.ResumeLayout(false);
            this.gbGJogadoresDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGListaJogadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DA_ProjetoDataSet_Players)).EndInit();
            this.tbGestaoEquipas.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbGEquipasDados.ResumeLayout(false);
            this.gbGEquipasDados.PerformLayout();
            this.gbGEquipasForm.ResumeLayout(false);
            this.gbGEquipasForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatarEquipa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGListaEquipas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DA_ProjetoDataSet_Teams)).EndInit();
            this.tbGestaoTorneios.ResumeLayout(false);
            this.gbGJogosDados.ResumeLayout(false);
            this.gbGJogosDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGJogosLista)).EndInit();
            this.gbGTorneiosDados.ResumeLayout(false);
            this.gbGTorneiosDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGTorneiosLista)).EndInit();
            this.gbGTorneiosInfo.ResumeLayout(false);
            this.gbGJogosForm.ResumeLayout(false);
            this.gbGJogosForm.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBoxEquipasJogos.ResumeLayout(false);
            this.groupBoxEquipasJogos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNJogo)).EndInit();
            this.gbGTorneiosForm.ResumeLayout(false);
            this.gbGTorneiosForm.PerformLayout();
            this.gbTipoTorneio.ResumeLayout(false);
            this.gbTipoTorneio.PerformLayout();
            this.tbGestaoCartas.ResumeLayout(false);
            this.gbGCartasForm.ResumeLayout(false);
            this.gbGCartasForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGDefesaCarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGAtaqueCarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGLealdadeCarta)).EndInit();
            this.gbGCartasDados.ResumeLayout(false);
            this.gbGCartasDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGCartasLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DA_ProjetoDataSet_Cards)).EndInit();
            this.tbGestaoBaralhos.ResumeLayout(false);
            this.panelGestaoBaralho.ResumeLayout(false);
            this.gbGCartasBotoes.ResumeLayout(false);
            this.gbGCartasBotoes.PerformLayout();
            this.gbGCartasnoBaralho.ResumeLayout(false);
            this.gbGListaDeCartas.ResumeLayout(false);
            this.gbGBaralhosDados.ResumeLayout(false);
            this.gbGBaralhosDados.PerformLayout();
            this.gbGBaralhosForm.ResumeLayout(false);
            this.gbGBaralhosForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGBaralhosLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DA_ProjetoDataSet_Decks)).EndInit();
            this.tbGestaoUtilizadores.ResumeLayout(false);
            this.gbGUtilizadoresDados.ResumeLayout(false);
            this.gbGUtilizadoresDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGUtilizadoresLista)).EndInit();
            this.gbGAdministradorForm.ResumeLayout(false);
            this.gbGAdministradorForm.PerformLayout();
            this.gbGArbitroForm.ResumeLayout(false);
            this.gbGArbitroForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarArbitro)).EndInit();
            this.tbVer.ResumeLayout(false);
            this.tcVer.ResumeLayout(false);
            this.tbVerJogadores.ResumeLayout(false);
            this.tbVerJogadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdadeJogador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGListaJogadoresPesquisa)).EndInit();
            this.tbVerEquipas.ResumeLayout(false);
            this.tbVerEquipas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGListaEquipasPesquisa)).EndInit();
            this.tbVerTorneios.ResumeLayout(false);
            this.gbResultadosJogos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosJogos)).EndInit();
            this.gbResultadosTorneios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosTorneios)).EndInit();
            this.gbPesquisarJogos.ResumeLayout(false);
            this.gbPesquisarJogos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupJogoNumero)).EndInit();
            this.gbPesquisarTorneios.ResumeLayout(false);
            this.gbPesquisarTorneios.PerformLayout();
            this.tbVerCartas.ResumeLayout(false);
            this.tbVerCartas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVDefesaCarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVAtaqueCarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVLealdadeCarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVCartasLista)).EndInit();
            this.tbVerBaralhos.ResumeLayout(false);
            this.tbVerBaralhos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVBaralhosLista)).EndInit();
            this.tbVerUtilizadores.ResumeLayout(false);
            this.tbVerUtilizadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisaUtilizadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DA_ProjetoDataSet_Games)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_DA_ProjetoDataSet_Tournaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAdministradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetArbitros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAdminstradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArbitros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbMenu;
        private System.Windows.Forms.TabPage tpGestao;
        private System.Windows.Forms.TabControl tcGestao;
        private System.Windows.Forms.TabPage tbGestaoJogadores;
        private System.Windows.Forms.TabPage tbGestaoEquipas;
        private System.Windows.Forms.TabPage tbGestaoTorneios;
        private System.Windows.Forms.TabPage tbGestaoCartas;
        private System.Windows.Forms.TabPage tbGestaoBaralhos;
        private System.Windows.Forms.TabPage tbGestaoUtilizadores;
        private System.Windows.Forms.TabPage tbVer;
        private System.Windows.Forms.TabControl tcVer;
        private System.Windows.Forms.TabPage tbVerJogadores;
        private System.Windows.Forms.TabPage tbVerEquipas;
        private System.Windows.Forms.TabPage tbVerTorneios;
        private System.Windows.Forms.TabPage tbVerCartas;
        private System.Windows.Forms.TabPage tbVerBaralhos;
        private System.Windows.Forms.TabPage tbVerUtilizadores;
        private System.Windows.Forms.GroupBox gbGJogosDados;
        private System.Windows.Forms.GroupBox gbGTorneiosDados;
        private System.Windows.Forms.GroupBox gbGTorneiosInfo;
        private System.Windows.Forms.GroupBox gbGJogosForm;
        private System.Windows.Forms.GroupBox gbGTorneiosForm;
        private System.Windows.Forms.Label labNomeJogo;
        private System.Windows.Forms.Button btnRemoverJogo;
        private System.Windows.Forms.Button btnRemoverTorneio;
        private System.Windows.Forms.Button txtTorneioCancelar;
        private System.Windows.Forms.Button txtTorneioAcao;
        private System.Windows.Forms.TextBox txtDescricaoTorneio;
        private System.Windows.Forms.DateTimePicker tpDataTorneio;
        private System.Windows.Forms.TextBox txtNomeTorneio;
        private System.Windows.Forms.Label labDescricaoJogo;
        private System.Windows.Forms.Label labDataJogo;
        private System.Windows.Forms.Button btnJogoCancelar;
        private System.Windows.Forms.Button btnJogoAcao;
        private System.Windows.Forms.Label labVS;
        private System.Windows.Forms.ComboBox cmbequipajogador2;
        private System.Windows.Forms.ComboBox cmbequipajogador1;
        private System.Windows.Forms.NumericUpDown nudNJogo;
        private System.Windows.Forms.Label labNumJogo;
        private System.Windows.Forms.DateTimePicker tpDataJogos;
        private System.Windows.Forms.Label labData;
        private System.Windows.Forms.TextBox txtDescricaoJogo;
        private System.Windows.Forms.Label labDescricao;
        private System.Windows.Forms.Label labPesquisarJogos;
        private System.Windows.Forms.TextBox txtGJogosPesquisa;
        private System.Windows.Forms.DataGridView dgvGJogosLista;
        private System.Windows.Forms.Button btnAlterarJogo;
        private System.Windows.Forms.Button btnInserirJogo;
        private System.Windows.Forms.Label labPesquisarTorneio;
        private System.Windows.Forms.TextBox txtGTorneiosPesquisa;
        private System.Windows.Forms.Button btnAlterarTorneio;
        private System.Windows.Forms.Button btnInserirTorneio;
        private System.Windows.Forms.DataGridView dgvGTorneiosLista;
        private System.Windows.Forms.GroupBox gbGCartasDados;
        private System.Windows.Forms.GroupBox gbGCartasForm;
        private System.Windows.Forms.DataGridView dgvGCartasLista;
        private System.Windows.Forms.Label labPesquisarCarta;
        private System.Windows.Forms.TextBox txtGCartasPesquisa;
        private System.Windows.Forms.Button btnRemoverCarta;
        private System.Windows.Forms.Button btnAlterarCarta;
        private System.Windows.Forms.Button btnInserirCarta;
        private System.Windows.Forms.Button btnCartaCancelar;
        private System.Windows.Forms.Button btnAcaoCarta;
        private System.Windows.Forms.NumericUpDown nudGDefesaCarta;
        private System.Windows.Forms.NumericUpDown nudGAtaqueCarta;
        private System.Windows.Forms.TextBox txtGRegrasCarta;
        private System.Windows.Forms.NumericUpDown nudGLealdadeCarta;
        private System.Windows.Forms.TextBox txtGCustoCarta;
        private System.Windows.Forms.ComboBox cmbGTipoCarta;
        private System.Windows.Forms.ComboBox cmbFacaoCarta;
        private System.Windows.Forms.TextBox txtGNomeCarta;
        private System.Windows.Forms.Label labDefesa;
        private System.Windows.Forms.Label labAtaque;
        private System.Windows.Forms.Label labRegras;
        private System.Windows.Forms.Label labLealdade;
        private System.Windows.Forms.Label labCusto;
        private System.Windows.Forms.Label labTipo;
        private System.Windows.Forms.Label labFacao;
        private System.Windows.Forms.Label labNomeCarta;
        private System.Windows.Forms.GroupBox gbGBaralhosDados;
        private System.Windows.Forms.Label labPesquisarBaralho;
        private System.Windows.Forms.DataGridView dgvGBaralhosLista;
        private System.Windows.Forms.Button btnInserirBaralho;
        private System.Windows.Forms.TextBox txtGBaralhosPesquisa;
        private System.Windows.Forms.Button btnGerirBaralho;
        private System.Windows.Forms.Button btnEliminarBaralho;
        private System.Windows.Forms.Button btnRemoverCartaBaralho;
        private System.Windows.Forms.Button btnGuardarAltBaralho;
        private System.Windows.Forms.Button btnCancelarAltBaralho;
        private System.Windows.Forms.Button btnAdicionarCartaBaralho;
        private System.Windows.Forms.GroupBox gbGCartasnoBaralho;
        private System.Windows.Forms.GroupBox gbGListaDeCartas;
        private System.Windows.Forms.GroupBox gbGBaralhosForm;
        private System.Windows.Forms.Label labNomeBaralho;
        private System.Windows.Forms.Button btnCriarBaralho;
        private System.Windows.Forms.Button btnCancelarNovoBaralho;
        private System.Windows.Forms.TextBox txtNomeBaralho;
        private System.Windows.Forms.GroupBox gbGUtilizadoresDados;
        private System.Windows.Forms.GroupBox gbGAdministradorForm;
        private System.Windows.Forms.TextBox txtPasswordAdministrador;
        private System.Windows.Forms.TextBox txtUsernameAdministrador;
        private System.Windows.Forms.Label labEmailAdministrador;
        private System.Windows.Forms.Label labPasswordAdministrador;
        private System.Windows.Forms.Label labUsernameAdministrador;
        private System.Windows.Forms.Button btnEliminarUtilizador;
        private System.Windows.Forms.Label labPesquisarUtilizador;
        private System.Windows.Forms.Button btnAlterarUtilizador;
        private System.Windows.Forms.DataGridView dgvGUtilizadoresLista;
        private System.Windows.Forms.Button btnInserirUtilizador;
        private System.Windows.Forms.TextBox txtGUtilizadoresPesquisa;
        private System.Windows.Forms.TextBox txtEmailAdministrador;
        private System.Windows.Forms.Button btnCancelarAdministrador;
        private System.Windows.Forms.Button btnAcaoAdministrador;
        private System.Windows.Forms.RadioButton radioAdmins;
        private System.Windows.Forms.RadioButton radioArbitros;
        private System.Windows.Forms.GroupBox gbGArbitroForm;
        private System.Windows.Forms.Button btnCancelarArbitro;
        private System.Windows.Forms.Button btnAcaoArbitro;
        private System.Windows.Forms.Button btnProcurarAvatar;
        private System.Windows.Forms.TextBox txtPasswordArbitro;
        private System.Windows.Forms.TextBox txtAvatarArbitro;
        private System.Windows.Forms.TextBox txtNomeArbitro;
        private System.Windows.Forms.TextBox txtUsernameArbitro;
        private System.Windows.Forms.Label labPasswordArbitro;
        private System.Windows.Forms.Label labUsernameArbitro;
        private System.Windows.Forms.Label labAvatarArbitro;
        private System.Windows.Forms.Label labNomeArbitro;
        private System.Windows.Forms.OpenFileDialog ofdAvatarArbitro;
        private System.Windows.Forms.PictureBox pbAvatarArbitro;
        private BD_DA_ProjetoDataSet_Administradores dataSetAdministradores;
        private BD_DA_ProjetoDataSet_Arbitros dataSetArbitros;
        private System.Windows.Forms.BindingSource bindingSourceAdminstradores;
        private System.Windows.Forms.BindingSource bindingSourceArbitros;
        private BD_DA_ProjetoDataSet_AdministradoresTableAdapters.UserSetTableAdapter userSetTableAdapterAdministradores;
        private BD_DA_ProjetoDataSet_ArbitrosTableAdapters.UserSetTableAdapter userSetTableAdapterArbitros;
        private System.Windows.Forms.Label labPesquisaUsername;
        private System.Windows.Forms.Label labPesquisarPor;
        private System.Windows.Forms.RadioButton radioPesquisaArbitro;
        private System.Windows.Forms.RadioButton radioPesquisaAdministrador;
        private System.Windows.Forms.TextBox txtPesquisaNomeArbitro;
        private System.Windows.Forms.TextBox txtPesquisaEmailAdministrador;
        private System.Windows.Forms.TextBox txtPesquisaUsername;
        private System.Windows.Forms.Label labPesquisaNomeEmail;
        private System.Windows.Forms.DataGridView dgvPesquisaUtilizadores;
        private System.Windows.Forms.Button btnPesquisarUtilizador;
        private System.Windows.Forms.CheckBox checkPesquisaArbitroAtivo;
        private System.Windows.Forms.Button btnResetPesquisa;
        private BD_DA_ProjetoDataSet_Cards bD_DA_ProjetoDataSet_Cards;
        private System.Windows.Forms.BindingSource cardSetBindingSource;
        private BD_DA_ProjetoDataSet_CardsTableAdapters.CardSetTableAdapter cardSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loyaltyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruleTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defenseDataGridViewTextBoxColumn;
        private BD_DA_ProjetoDataSet_Decks bD_DA_ProjetoDataSet_Decks;
        private System.Windows.Forms.BindingSource deckSetBindingSource;
        private BD_DA_ProjetoDataSet_DecksTableAdapters.DeckSetTableAdapter deckSetTableAdapter;
        private System.Windows.Forms.TableLayoutPanel panelGestaoBaralho;
        private System.Windows.Forms.GroupBox gbGCartasBotoes;
        private System.Windows.Forms.Label lblNCartasNoBaralho;
        private System.Windows.Forms.Label lblNCartasTotais;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox gbGJogadoresForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btImagem;
        private System.Windows.Forms.TextBox txtAvatar;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btnJogadoresCancelar;
        private System.Windows.Forms.Button btnJogadoresAcao;
        private System.Windows.Forms.NumericUpDown nudIdadeJogador;
        private System.Windows.Forms.TextBox txtNickJogador;
        private System.Windows.Forms.TextBox txtEmailJogador;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbGJogadoresDados;
        private System.Windows.Forms.Button btnRemoverJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterarJogador;
        private System.Windows.Forms.DataGridView dgvGListaJogadores;
        private System.Windows.Forms.Button btnInserirJogador;
        private System.Windows.Forms.TextBox txtGJogadoresPesquisa;
        private System.Windows.Forms.Button btnGuardarJogadorEquipa;
        private System.Windows.Forms.Button btnRetirarJogador;
        private System.Windows.Forms.Button btnAdicionarJogador;
        private System.Windows.Forms.GroupBox gbGEquipasDados;
        private System.Windows.Forms.Button btnGerirEquipa;
        private System.Windows.Forms.GroupBox gbGEquipasForm;
        private System.Windows.Forms.PictureBox pictureBoxAvatarEquipa;
        private System.Windows.Forms.Button btnAvatarEquipa;
        private System.Windows.Forms.Button btnEquipaCancelar;
        private System.Windows.Forms.Button btnEquipaAcao;
        private System.Windows.Forms.TextBox txtGAvatarEquipa;
        private System.Windows.Forms.TextBox txtGNomeEquipa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRemoverEquipa;
        private System.Windows.Forms.Button btnAlterarEquipa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInserirEquipa;
        private System.Windows.Forms.DataGridView dgvGListaEquipas;
        private System.Windows.Forms.TextBox txtGEquipasPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvJogadoresEquipa;
        private System.Windows.Forms.ColumnHeader cNome;
        private System.Windows.Forms.ColumnHeader cEmail;
        private System.Windows.Forms.ColumnHeader cIdade;
        private System.Windows.Forms.ColumnHeader cNickname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lcListaJogadores;
        private System.Windows.Forms.ColumnHeader cNome1;
        private System.Windows.Forms.ColumnHeader cEmail2;
        private System.Windows.Forms.ColumnHeader cIdade2;
        private System.Windows.Forms.ColumnHeader cNickname2;
        private System.Windows.Forms.NumericUpDown nudIdadeJogador2;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtNicknameJogador2;
        private System.Windows.Forms.Label txtnickname;
        private System.Windows.Forms.TextBox txtEmailJogador2;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtNomeJogador2;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.DataGridView dgvGListaJogadoresPesquisa;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.ComboBox cbnomejogadorpesquisa;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox tbxnomeequipapesquisa;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.DataGridView dgvGListaEquipasPesquisa;
        private System.Windows.Forms.Button btnVLimparCartas;
        private System.Windows.Forms.NumericUpDown nudVDefesaCarta;
        private System.Windows.Forms.NumericUpDown nudVAtaqueCarta;
        private System.Windows.Forms.NumericUpDown nudVLealdadeCarta;
        private System.Windows.Forms.TextBox txtVCustoCarta;
        private System.Windows.Forms.ComboBox cmbVTipoCarta;
        private System.Windows.Forms.ComboBox cmbVFacaoCarta;
        private System.Windows.Forms.TextBox txtVNomeCarta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.DataGridView dgvVCartasLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn factionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loyaltyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruleTextDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn attackDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn defenseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgvVBaralhosLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnVLimparBaralhos;
        private System.Windows.Forms.ComboBox cmbVCartasnoBaralho;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtVNomeBaralho;
        private System.Windows.Forms.ListView lvCartasBaralho;
        private System.Windows.Forms.ColumnHeader chCarta;
        private System.Windows.Forms.ColumnHeader chTipo;
        private System.Windows.Forms.ColumnHeader chQtd;
        private System.Windows.Forms.ListView lvListaCartas;
        private System.Windows.Forms.ColumnHeader cCarta;
        private System.Windows.Forms.ColumnHeader CTipo;
        private System.Windows.Forms.ColumnHeader cQtd;
        private BD_DA_ProjetoDataSet_Teams bD_DA_ProjetoDataSet_Teams;
        private System.Windows.Forms.BindingSource teamSetBindingSource;
        private BD_DA_ProjetoDataSet_TeamsTableAdapters.TeamSetTableAdapter teamSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatarDataGridViewTextBoxColumn1;
        private BD_DA_ProjetoDataSet_Players bD_DA_ProjetoDataSet_Players;
        private System.Windows.Forms.BindingSource playerSetBindingSource;
        private BD_DA_ProjetoDataSet_PlayersTableAdapters.PlayerSetTableAdapter playerSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatarDataGridViewTextBoxColumn;
        private System.Windows.Forms.OpenFileDialog opfProcurarImagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatarDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatarDataGridViewTextBoxColumn3;
        private BD_DA_ProjetoDataSet_Games bD_DA_ProjetoDataSet_Games;
        private System.Windows.Forms.BindingSource gameSetBindingSource;
        private BD_DA_ProjetoDataSet_GamesTableAdapters.GameSetTableAdapter gameSetTableAdapter;
        private System.Windows.Forms.RadioButton radioStandardTournaments;
        private System.Windows.Forms.RadioButton radioTeamTournaments;
        private BD_DA_ProjetoDataSet_Tournaments bD_DA_ProjetoDataSet_Tournaments;
        private System.Windows.Forms.BindingSource tournamentSetBindingSource;
        private BD_DA_ProjetoDataSet_TournamentsTableAdapters.TournamentSetTableAdapter tournamentSetTableAdapter;
        private System.Windows.Forms.GroupBox gbTipoTorneio;
        private System.Windows.Forms.RadioButton radioTipoTorneioTeam;
        private System.Windows.Forms.RadioButton radioTipoTorneioStandard;
        private System.Windows.Forms.ComboBox cmbarbitrojogos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbdecks2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbdecks1;
        private System.Windows.Forms.GroupBox groupBoxEquipasJogos;
        private System.Windows.Forms.Button btngerirjogos;
        private System.Windows.Forms.Button btnCancelarJogo;
        private System.Windows.Forms.OpenFileDialog FileDialogImportarCarta;
        private System.Windows.Forms.Button btnImportarCartas;
        private System.Windows.Forms.GroupBox gbPesquisarJogos;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox gbPesquisarTorneios;
        private System.Windows.Forms.TextBox txtTorneioDescricao;
        private System.Windows.Forms.TextBox txtTorneioNome;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpTorneioData;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtJogoNome;
        private System.Windows.Forms.ComboBox comboJogoArbitro;
        private System.Windows.Forms.ComboBox comboJogoDeck;
        private System.Windows.Forms.ComboBox comboJogoJogadorEquipa;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labJogoJogadorEquipa;
        private System.Windows.Forms.GroupBox gbResultadosJogos;
        private System.Windows.Forms.DataGridView dgvResultadosJogos;
        private System.Windows.Forms.GroupBox gbResultadosTorneios;
        private System.Windows.Forms.DataGridView dgvResultadosTorneios;
        private System.Windows.Forms.Button btnLimparJogos;
        private System.Windows.Forms.Button btnLimparTorneios;
        private System.Windows.Forms.RadioButton radioPesquisarJogosStandard;
        private System.Windows.Forms.RadioButton radioPesquisarJogosTeam;
        private System.Windows.Forms.RadioButton radioPesquisarTorneiosStandard;
        private System.Windows.Forms.RadioButton radioPesquisarTorneiosTeam;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown nupJogoNumero;
        private System.Windows.Forms.DateTimePicker dtpJogoData;
        private System.Windows.Forms.Label label23;
    }
}