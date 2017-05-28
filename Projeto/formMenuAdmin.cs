using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class formMenuAdmin : Form
    {
        public DiagramaArcmageContainer containerDados;

        /// <summary>
        /// Variavel privada que guarda o id do árbitro selecionado.
        /// </summary>
        private int idArbitro;

        /// <summary>
        /// Variavel privada que guarda o id do administrador selecionado.
        /// </summary>
        private int idAdministrador;

        /// <summary>
        /// Variável usada para guardar o id da carta selecionada.
        /// </summary>
        private int idCarta;
        /// <summary>
        /// Variável usada para guardar o id do baralho selecionado.
        /// </summary>
        private int idBaralho;

        /// <summary>
        /// Variavel privada que guarda o id do torneio selecionado.
        /// </summary>
        private int idTorneio;

        /// <summary>
        /// Variavel privada que guarda o id do jogador selecionado.
        /// </summary>
        private int idJogador;

        /// <summary>
        /// Variavel privada que guarda o id da equipa selecionada.
        /// </summary>
        private int idEquipa;

        /// <summary>
        /// Variavel privada que guarda o id do jogo selecionado.
        /// </summary>
        private int idJogo;

        public formMenuAdmin()
        {
            InitializeComponent();

            containerDados = new DiagramaArcmageContainer();
        }

        private void formMenuAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogin Login = new formLogin();
            Login.Show();
        }

        private void formMenuAdmin_Load(object sender, EventArgs e)
        {
            this.tournamentSetTableAdapter.Fill(this.bD_DA_ProjetoDataSet_Tournaments.TournamentSet);
            this.playerSetTableAdapter.Fill(this.bD_DA_ProjetoDataSet_Players.PlayerSet);
            this.teamSetTableAdapter.Fill(this.bD_DA_ProjetoDataSet_Teams.TeamSet);
            this.deckSetTableAdapter.Fill(this.bD_DA_ProjetoDataSet_Decks.DeckSet);
            this.cardSetTableAdapter.Fill(this.bD_DA_ProjetoDataSet_Cards.CardSet);
            this.userSetTableAdapterArbitros.Fill(this.dataSetArbitros.UserSet);
            this.userSetTableAdapterAdministradores.Fill(this.dataSetAdministradores.UserSet);

            radioAdmins.Checked = true;
            radioPesquisaAdministrador.Checked = true;
            radioTeamTournaments.Checked = true;
        }

        #region Gestão de Utiilizadores

        /// <summary>
        /// Evento do botão "Inserir" da tab de Utilizadores.
        /// Verifica qual é o tipo de uilizador selecionado e faz reset ao formulário.
        /// </summary>
        private void BotaoInserirUtilizador(object sender, EventArgs e)
        {
            if(radioAdmins.Checked == true)
            {
                ResetFormAdministrador();
                btnAcaoAdministrador.Text = "Adicionar";
                gbGAdministradorForm.Visible = true;
                gbGArbitroForm.Visible = false;
            }

            else
            {
                ResetFormArbitro();
                btnAcaoArbitro.Text = "Adicionar";
                gbGAdministradorForm.Visible = false;
                gbGArbitroForm.Visible = true;
            }
        }

        /// <summary>
        /// Evento do botão "Alterar" da tab de Utilizadores.
        /// Verifica qual é o tipo de utilizador selecionado, prepara e mostra o formulário com os dados do utilizador selecionado.
        /// </summary>
        private void BotaoAlterarUtilizador(object sender, EventArgs e)
        {
            if (dgvGUtilizadoresLista.SelectedRows.Count > 0)
            {
                if (VerificarTipoAdministrator(dgvGUtilizadoresLista.CurrentRow))
                {
                    idAdministrador = (int)dgvGUtilizadoresLista.CurrentRow.Cells[0].Value;

                    Administrator admin = (Administrator)containerDados.UserSet.Find(idAdministrador);

                    txtUsernameAdministrador.Text = admin.Username;
                    txtEmailAdministrador.Text = admin.Email;

                    btnAcaoAdministrador.Text = "Aplicar";
                    gbGAdministradorForm.Visible = true;
                    gbGArbitroForm.Visible = false;
                    gbGUtilizadoresDados.Enabled = false;
                }

                else if (VerificarTipoReferee(dgvGUtilizadoresLista.CurrentRow))
                {
                    idArbitro = (int)dgvGUtilizadoresLista.CurrentRow.Cells[0].Value;

                    Referee arbitro = (Referee)containerDados.UserSet.Find(idArbitro);

                    txtUsernameArbitro.Text = arbitro.Username;
                    txtNomeArbitro.Text = arbitro.Name;
                    txtAvatarArbitro.Text = arbitro.Avatar;

                    if (File.Exists(arbitro.Avatar))
                    {
                        using (Bitmap imagemAvatar = new Bitmap(arbitro.Avatar))
                        {
                            Image avatarArbitro = new Bitmap(imagemAvatar);
                            pbAvatarArbitro.Image = avatarArbitro;
                        }
                    }

                    btnAcaoArbitro.Text = "Aplicar";
                    txtAvatarArbitro.Enabled = true;
                    gbGAdministradorForm.Visible = false;
                    gbGArbitroForm.Visible = true;
                    gbGUtilizadoresDados.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Evento do botão "Eliminar" da tab de Utilizadores.
        /// Mostra uma mensagem de confirmação a perguntar se deseja remover o utilizador. Se sim, verifica qual o tipo de utilizador selecionado e remove-o.
        /// </summary>
        private void BotaoEliminarUtilizador(object sender, EventArgs e)
        {
            if (dgvGUtilizadoresLista.SelectedRows.Count > 0)
            {
                DialogResult confirmacaoEliminar = MessageBox.Show("Tem a certeza que quer eliminar o utilizador '" + dgvGUtilizadoresLista.CurrentRow.Cells[1].Value.ToString() + "'?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacaoEliminar == DialogResult.Yes)
                {
                    if (VerificarTipoAdministrator(dgvGUtilizadoresLista.CurrentRow))
                    {
                        if (containerDados.UserSet.OfType<Administrator>().Count() > 1)
                        {
                            idAdministrador = (int)dgvGUtilizadoresLista.CurrentRow.Cells[0].Value;

                            RemoverAdministrador();
                        }

                        else
                        {
                            MessageBox.Show("Tem de existir, no mínimo, uma administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else if (VerificarTipoReferee(dgvGUtilizadoresLista.CurrentRow))
                    {
                        idArbitro = (int)dgvGUtilizadoresLista.CurrentRow.Cells[0].Value;

                        RemoverArbitro();
                    }
                }
            }
        }

        /// <summary>
        /// Evento do botão no formulário de preenchimento do Administrador, que realiza as funções de "Adicionar" ou "Aplicar".
        /// </summary>
        private void BotaoAcaoAdministrador(object sender, EventArgs e)
        {
            string usernameForm = txtUsernameAdministrador.Text.Trim();
            string emailForm = txtEmailAdministrador.Text.Trim();

            if (btnAcaoAdministrador.Text == "Aplicar")
            {
                DialogResult confirmacaoAlterar = MessageBox.Show("Tem a certeza que quer alterar o administrador '" + dgvGUtilizadoresLista.CurrentRow.Cells[1].Value.ToString() + "'?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacaoAlterar == DialogResult.Yes)
                {
                    if (usernameForm.Length > 0 && txtPasswordAdministrador.Text.Length > 0 && emailForm.Length > 0)
                    {
                        if (containerDados.UserSet.Count() > 0)
                        {
                            if (VerificarAlteracoesAdministrador(usernameForm, emailForm))
                            {
                                AlterarAdministrador(usernameForm, txtPasswordAdministrador.Text, emailForm);
                                ResetFormAdministrador();
                                gbGAdministradorForm.Visible = false;
                            }

                            else
                            {
                                MessageBox.Show("O administrador editado já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    else if (usernameForm.Length > 0 && txtPasswordAdministrador.Text.Length == 0 && emailForm.Length > 0)
                    {
                        if (containerDados.UserSet.Count() > 0)
                        {
                            if (VerificarAlteracoesAdministrador(usernameForm, emailForm))
                            {
                                AlterarAdministrador(usernameForm, emailForm);
                                ResetFormAdministrador();
                                gbGAdministradorForm.Visible = false;
                            }

                            else
                            {
                                MessageBox.Show("O administrador editado já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Tem de preencher os campos necessários para efetuar as alterações.\nSe pretender manter a password atual, deixe o campo da password em branco.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else if (btnAcaoAdministrador.Text == "Adicionar")
            {
                DialogResult confirmacaoAdicionar = MessageBox.Show("Tem a certeza que quer adicionar o administrador '" + usernameForm + "'?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacaoAdicionar == DialogResult.Yes)
                {
                    if (usernameForm.Length > 0 && txtPasswordAdministrador.Text.Length > 0 && emailForm.Length > 0)
                    {
                        if (containerDados.UserSet.Count() > 0)
                        {
                            if (VerificarDadosAdmnistrador(usernameForm, emailForm))
                            {
                                AdicionarAdministrador(usernameForm, txtPasswordAdministrador.Text, emailForm);
                                ResetFormAdministrador();
                                gbGAdministradorForm.Visible = false;
                            }

                            else
                            {
                                MessageBox.Show("O administrador inserido já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            AdicionarAdministrador(usernameForm, txtPasswordAdministrador.Text, emailForm);
                            ResetFormAdministrador();
                            gbGAdministradorForm.Visible = false;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Tem de preencher todos os campos para adicionar o Admin.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Evento do botão no formulário de preenchimento do Arbitro, que realiza as funções de "Adicionar" ou "Aplicar".
        /// Executa as validações de dados e do ficheiro de imagem. Se passar as validações, executa os métodos da funcionalidade desejada.
        /// </summary>
        private void BotaoAcaoArbitro(object sender, EventArgs e)
        {
            string usernameForm = txtUsernameArbitro.Text.Trim();
            string nomeForm = txtNomeArbitro.Text.Trim();
            string avatarPathAbsoluto = txtAvatarArbitro.Text.Trim();
            string avatarPathRelative = GetPathRelativeImagem(avatarPathAbsoluto, usernameForm, "/arbitros/avatars");

            if (btnAcaoArbitro.Text == "Aplicar")
            {
                DialogResult confirmacaoAlterar = MessageBox.Show("Tem a certeza que quer alterar o arbitro '" + dgvGUtilizadoresLista.CurrentRow.Cells[1].Value.ToString() + "'?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacaoAlterar == DialogResult.Yes)
                {
                    if (usernameForm.Length > 0 && txtPasswordArbitro.Text.Length > 0 && nomeForm.Length > 0 && avatarPathAbsoluto.Length > 0)
                    {
                        if (File.Exists(avatarPathAbsoluto))
                        {
                            if (containerDados.UserSet.Count() > 0)
                            {
                                if (VerificarAlteracoesArbitro(usernameForm, nomeForm, avatarPathRelative))
                                {
                                    if (pbAvatarArbitro.Image.Width <= 128 && pbAvatarArbitro.Image.Height <= 128)
                                    {
                                        AlterarArbitro(usernameForm, txtPasswordArbitro.Text, nomeForm, avatarPathRelative, avatarPathAbsoluto);
                                        ResetFormArbitro();
                                        gbGArbitroForm.Visible = false;
                                    }
                                }


                                else
                                {
                                    MessageBox.Show("O arbitro editado já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }

                    else if (usernameForm.Length > 0 && txtPasswordArbitro.Text.Length == 0 && nomeForm.Length > 0 && avatarPathAbsoluto.Length > 0 && pbAvatarArbitro.Image.Height <= 128 && pbAvatarArbitro.Image.Width <= 128)
                    {
                        if (File.Exists(avatarPathAbsoluto))
                        {
                            if (containerDados.UserSet.Count() > 0)
                            {
                                if (VerificarAlteracoesArbitro(usernameForm, nomeForm, avatarPathRelative))
                                {
                                    if (pbAvatarArbitro.Image.Width <= 128 && pbAvatarArbitro.Image.Height <= 128)
                                    {
                                        AlterarArbitro(usernameForm, nomeForm, avatarPathRelative, avatarPathAbsoluto);
                                        ResetFormArbitro();
                                        gbGArbitroForm.Visible = false;
                                    }
                                }


                                else
                                {
                                    MessageBox.Show("O arbitro editado já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Tem de preencher os campos necessários para efetuar as alterações.\nSe pretender manter a password atual, deixe o campo da password em branco.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else if (btnAcaoArbitro.Text == "Adicionar")
            {
                DialogResult confirmacaoAdicionar = MessageBox.Show("Tem a certeza que quer adicionar o arbitro '" + usernameForm + "'?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacaoAdicionar == DialogResult.Yes)
                {
                    if (usernameForm.Length > 0 && txtPasswordArbitro.Text.Length > 0 && nomeForm.Length > 0 && avatarPathAbsoluto.Length > 0 && pbAvatarArbitro.Image.Height <= 128 && pbAvatarArbitro.Image.Width <= 128)
                    {
                        if (File.Exists(avatarPathAbsoluto))
                        {
                            if (containerDados.UserSet.Count() > 0)
                            {
                                if (VerificarDadosArbitro(usernameForm, nomeForm, avatarPathRelative))
                                {
                                    if (pbAvatarArbitro.Image.Width <= 128 && pbAvatarArbitro.Image.Height <= 128)
                                    {
                                        AdicionarArbitro(usernameForm, txtPasswordArbitro.Text, nomeForm, avatarPathRelative, avatarPathAbsoluto);
                                        ResetFormArbitro();
                                        gbGArbitroForm.Visible = false;
                                    }
                                }


                                else
                                {
                                    MessageBox.Show("O arbitro inserido já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                            else
                            {
                                if (pbAvatarArbitro.Image.Width <= 128 && pbAvatarArbitro.Image.Height <= 128)
                                {
                                    AdicionarArbitro(usernameForm, txtPasswordArbitro.Text, nomeForm, avatarPathRelative, avatarPathAbsoluto);
                                    ResetFormArbitro();
                                    gbGArbitroForm.Visible = false;
                                }
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Tem de preencher todos os campos para adicionar o Arbitro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Evento do botão "Cancelar" no formulário de preenchimento do Arbitro.
        /// Faz reset ao formulário.
        /// </summary>
        private void BotaoCancelarArbitro(object sender, EventArgs e)
        {
            ResetFormArbitro();
            gbGArbitroForm.Visible = false;
        }

        /// <summary>
        /// Evento do botão "Cancelar" no formulário de preenchimento do Administrador.
        /// Faz reset ao formulário.
        /// </summary>
        private void BotaoCancelarAdministrador(object sender, EventArgs e)
        {
            ResetFormAdministrador();
            gbGAdministradorForm.Visible = false;
        }

        /// <summary>
        /// Evento do radio button "Administradores".
        /// Invoca o método RefreshTabelaUtilizadores para fazer refresh à tabela.
        /// </summary>
        private void RadioFiltrarAdministradores(object sender, EventArgs e)
        {
            if(radioAdmins.Checked == true)
            {
                txtGUtilizadoresPesquisa.Clear();
                RefreshTabelaUtilizadores();
            }
        }

        /// <summary>
        /// Evento do radio button "Arbitros".
        /// Invoca o método RefreshTabelaUtilizadores para fazer refresh à tabela.
        /// </summary>
        private void RadioFiltrarArbitros(object sender, EventArgs e)
        {
            if (radioArbitros.Checked == true)
            {
                txtGUtilizadoresPesquisa.Clear();
                RefreshTabelaUtilizadores();
            }
        }

        /// <summary>
        /// Evento de pesquisar utilizadores, quando o utilizador insere dados na Textbox de pesquisar.
        /// Executa uma query Linq em que o nome do utilizador contem o que for inserido na Textbox e põe os resultados na Data Grid View correspondente.
        /// </summary>
        private void PesquisarUtilizador(object sender, EventArgs e)
        {
            if (txtGUtilizadoresPesquisa.Text.Length > 0)
            {
                if (radioAdmins.Checked == true)
                {
                    IEnumerable<BD_DA_ProjetoDataSet_Administradores.UserSetRow> queryLinq = from admins in dataSetAdministradores.UserSet
                                                                                             where admins.Field<string>("Username").Contains(txtGUtilizadoresPesquisa.Text)
                                                                                             select admins;
                    if (queryLinq.Any() == true)
                    {
                        DataTable queryTable = queryLinq.CopyToDataTable();

                        bindingSourceAdminstradores.DataSource = queryTable;

                        dgvGUtilizadoresLista.DataSource = bindingSourceAdminstradores;
                    }

                    else
                    {
                        dgvGUtilizadoresLista.DataSource = null;
                    }
                }

                else if (radioArbitros.Checked == true)
                {
                    IEnumerable<BD_DA_ProjetoDataSet_Arbitros.UserSetRow> queryLinq = from arbitros in dataSetArbitros.UserSet
                                                                                      where arbitros.Field<string>("Username").Contains(txtGUtilizadoresPesquisa.Text)
                                                                                      select arbitros;
                    if (queryLinq.Any() == true)
                    {
                        DataTable queryTable = queryLinq.CopyToDataTable();

                        bindingSourceArbitros.DataSource = queryTable;

                        dgvGUtilizadoresLista.DataSource = bindingSourceArbitros;
                    }

                    else
                    {
                        dgvGUtilizadoresLista.DataSource = null;
                    }
                }
            }

            else
            {
                txtGUtilizadoresPesquisa.Clear();
                RefreshTabelaUtilizadores();
            }
        }

        /// <summary>
        /// Método de inserção de um arbitro.
        /// Cria uma instancia da classe Referee com os dados enviados por parêmetro e insere a instância no DataSet "UserSet".
        /// No final, faz refresh da tabela através do método RefreshTabelaUtilizadores.
        /// </summary>
        /// <param name="usernameArbitro">Username do Arbitro</param>
        /// <param name="passArbitro">Password do Arbitro</param>
        /// <param name="nomeArbitro">Nome do Arbitro</param>
        /// <param name="avatarPathArbitro">Avatar do Arbitro</param>
        private void AdicionarArbitro(string usernameArbitro, string passArbitro, string nomeArbitro, string avatarPathArbitro, string avatarPathAbsoluto)
        {
            try
            {
                Referee novoArbitro = new Referee
                {
                    Username = usernameArbitro,
                    Password = HashPassword(passArbitro),
                    Name = nomeArbitro,
                    Avatar = avatarPathArbitro
                };

                GuardarImagem(avatarPathArbitro, avatarPathAbsoluto);

                containerDados.UserSet.Add(novoArbitro);
                containerDados.SaveChanges();
                RefreshTabelaUtilizadores();
            }

            catch (Exception excecaoErro)
            {
                MessageBox.Show("Ocorreu um erro na inserção do arbitro." + excecaoErro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método de inserção de um administrador.
        /// Cria uma instancia da classe Administrator com os dados enviados por parêmetro e insere a instância no DataSet "UserSet".
        /// No final, faz refresh da tabela através do método RefreshTabelaUtilizadores.
        /// </summary>
        /// <param name="usernameAdministrador">Username do Administrador</param>
        /// <param name="passAdministrador">Password do Administrador</param>
        /// <param name="emailAdministrador">Email do Administrador</param>
        private void AdicionarAdministrador(string usernameAdministrador, string passAdministrador, string emailAdministrador)
        {
            try
            {
                Administrator novoAdministrador = new Administrator
                {
                    Username = usernameAdministrador,
                    Password = HashPassword(passAdministrador),
                    Email = emailAdministrador
                };

                containerDados.UserSet.Add(novoAdministrador);
                containerDados.SaveChanges();
                RefreshTabelaUtilizadores();
            }

            catch (Exception excecaoErro)
            {
                MessageBox.Show("Ocorreu um erro na inserção do administrador." + excecaoErro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método de encriptação da password de um utilizador.
        /// Encripta a password em hash de SHA1 e devolve a hash da password.
        /// </summary>
        /// <param name="password">Password do utilizador</param>
        /// <returns></returns>
        private string HashPassword(string password)
        {
            string passwordHash;

            using (SHA1 sha1Algorithm = new SHA1CryptoServiceProvider())
            {
                byte[] dadosBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha1Algorithm.ComputeHash(dadosBytes);

                passwordHash = BitConverter.ToString(hashBytes);
            }

            return passwordHash;
        }

        /// <summary>
        /// Método da alteração de um árbitro.
        /// Pesquisa pelo árbitro com o id idArbitro, e guarda os novos dados no mesmo.
        /// No final, guarda as alterações na base de dados e faz refresh da tabela através do método RefreshTabelaUtilizadores.
        /// </summary>
        /// <param name="usernameArbitro">Username do Arbitro</param>
        /// <param name="passArbitro">Password do Arbitro</param>
        /// <param name="nomeArbitro">Nome do Arbitro</param>
        /// <param name="avatarPathArbitro">Avatar do Arbitro</param>
        private void AlterarArbitro(string usernameArbitro, string passArbitro, string nomeArbitro, string avatarPathArbitro, string avatarPathAbsoluto)
        {
            try
            {
                Referee arbitro = (Referee)containerDados.UserSet.Find(idArbitro);

                arbitro.Username = usernameArbitro;
                arbitro.Password = HashPassword(passArbitro);
                arbitro.Name = nomeArbitro;
                arbitro.Avatar = avatarPathArbitro;

                GuardarImagem(avatarPathArbitro, avatarPathAbsoluto);

                containerDados.Entry(arbitro).State = EntityState.Modified;

                containerDados.SaveChanges();
                RefreshTabelaUtilizadores();
            }

            catch (Exception excecaoErro)
            {
                MessageBox.Show("Ocorreu um erro na edição do arbitro." + excecaoErro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Overload no método AlterarArbitro, sem a password para o caso do utilizador querer manter a password existente.
        /// </summary>
        /// <param name="usernameArbitro">Username do Arbitro</param>
        /// <param name="nomeArbitro">Nome do Arbitro</param>
        /// <param name="avatarPathArbitro">Avatar do Arbitro</param>
        private void AlterarArbitro(string usernameArbitro, string nomeArbitro, string avatarPathArbitro, string avatarPathAbsoluto)
        {
            try
            {
                Referee arbitro = (Referee)containerDados.UserSet.Find(idArbitro);

                arbitro.Username = usernameArbitro;
                arbitro.Name = nomeArbitro;
                arbitro.Avatar = avatarPathArbitro;

                GuardarImagem(avatarPathArbitro, avatarPathAbsoluto);

                containerDados.Entry(arbitro).State = EntityState.Modified;

                containerDados.SaveChanges();
                RefreshTabelaUtilizadores();
            }

            catch (Exception excecaoErro)
            {
                MessageBox.Show("Ocorreu um erro na edição do arbitro." + excecaoErro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método da alteração de um administrador.
        /// Pesquisa pelo árbitro com o id idAdmininstrador, e guarda os novos dados no mesmo.
        /// No final, guarda as alterações na base de dados e faz refresh da tabela através do método RefreshTabelaUtilizadores.
        /// </summary>
        /// <param name="usernameAdministrador">Username do Admnistrador</param>
        /// <param name="passAdministrador">Password do Administrador</param>
        /// <param name="emailAdministrador">Email do Administrador</param>
        private void AlterarAdministrador(string usernameAdministrador, string passAdministrador, string emailAdministrador)
        {
            try
            {
                Administrator admin = (Administrator)containerDados.UserSet.Find(idAdministrador);

                admin.Username = usernameAdministrador;
                admin.Password = HashPassword(passAdministrador);
                admin.Email = emailAdministrador;

                containerDados.Entry(admin).State = EntityState.Modified;

                containerDados.SaveChanges();
                RefreshTabelaUtilizadores();
            }

            catch (Exception excecaoErro)
            {
                MessageBox.Show("Ocorreu um erro na edição do administrador." + excecaoErro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Overload no método AlterarAdministrador, sem a password para o caso do utilizador querer manter a password existente.
        /// </summary>
        /// <param name="usernameAdministrador">Username do Admnistrador</param>
        /// <param name="emailAdministrador">Email do Administrador</param>
        private void AlterarAdministrador(string usernameAdministrador, string emailAdministrador)
        {
            try
            {
                Administrator admin = (Administrator)containerDados.UserSet.Find(idAdministrador);

                admin.Username = usernameAdministrador;
                admin.Email = emailAdministrador;

                containerDados.Entry(admin).State = EntityState.Modified;

                containerDados.SaveChanges();
                RefreshTabelaUtilizadores();
            }

            catch (Exception excecaoErro)
            {
                MessageBox.Show("Ocorreu um erro na edição do administrador." + excecaoErro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método de remoção de um administrador.
        /// Remove um administrador do Data Set "UserSet".
        /// De seguida, guarda as modificações do UserSet na base de dados e faz refresh à tabela.
        /// </summary>
        private void RemoverAdministrador()
        {
            try
            {
                Administrator admin = (Administrator)containerDados.UserSet.Find(idAdministrador);

                containerDados.UserSet.Remove(admin);

                containerDados.SaveChanges();
                RefreshTabelaUtilizadores();
            }

            catch (Exception excecaoErro)
            {
                MessageBox.Show("Ocorreu um erro na remoção do administrador." + excecaoErro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método de remoção de um arbitro.
        /// Remove um arbitro do Data Set "UserSet".
        /// De seguida, guarda as modificações do UserSet na base de dados e faz refresh à tabela.
        /// </summary>
        private void RemoverArbitro()
        {
            try
            {
                Referee arbitro = (Referee)containerDados.UserSet.Find(idArbitro);

                if (File.Exists(arbitro.Avatar))
                {
                    File.Delete(arbitro.Avatar);
                }

                containerDados.UserSet.Remove(arbitro);

                containerDados.SaveChanges();
                RefreshTabelaUtilizadores();
            }

            catch (Exception excecaoErro)
            {
                MessageBox.Show("Ocorreu um erro na remoção do arbitro." + excecaoErro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento do botão de Procurar o avatar do Arbitro.
        /// Abre um OpenFileDialog a perguntar ao utilizador qual a imagem a guardar como avatar.
        /// Coloca no formulário a imagem e o caminho absoluto da imagem selecionada.
        /// </summary>
        private void BotaoProcurarAvatar(object sender, EventArgs e)
        {
            ofdAvatarArbitro.Title = "Selecione uma imagem";
            ofdAvatarArbitro.Filter = "Image Files (JPG, JPEG,PNG)|*.JPG;*.JPEG;*.PNG";
            ofdAvatarArbitro.FileName = null;

            if (ofdAvatarArbitro.ShowDialog() == DialogResult.OK)
            {
                string avatarPath = ofdAvatarArbitro.FileName;

                using (Bitmap imagemAvatar = new Bitmap(avatarPath))
                {
                    if (imagemAvatar.Width <= 128 && imagemAvatar.Height <= 128)
                    {
                        Image avatarArbitro = new Bitmap(imagemAvatar);
                        pbAvatarArbitro.Image = avatarArbitro;
                        txtAvatarArbitro.Text = avatarPath;
                    }

                    else
                    {
                        MessageBox.Show("Tem de escolher um avatar de dimensão igual ou inferior a 128x128.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Método para contruir o caminho relativo (onde a imagem irá ser guardado), através do caminho absoluto (onde a imagem se encontra).
        /// </summary>
        /// <param name="avatarPathAbsoluto">Caminho absoluto do avatar</param>
        /// <param name="usernameArbitro">Username do Arbitro</param>
        /// <returns></returns>
        private string GetPathRelativeImagem(string avatarPathAbsoluto, string nomeImagem, string pathPasta)
        {
            DirectoryInfo avatarPath = Directory.CreateDirectory(Environment.CurrentDirectory + "/ArcmageADM" + pathPasta);

            string avatarPathRelative = avatarPath.FullName + "\\" + nomeImagem + ".png";

            return avatarPathRelative;
        }

        /// <summary>
        /// Método para guardar a imagem.
        /// Encontra a imagem através do caminho absoluto (a pasta onde se encontra) e, se for diferente do caminho relativo (onde irá ser guardada),
        /// isto é, se a imagem escolhida é diferente do que a atual, elimina e faz uma nova cópia para o caminho relativo.
        /// </summary>
        /// <param name="avatarPathRelative">Caminho relativo do avatar</param>
        /// <param name="avatarPathAbsoluto">Caminho absoluto do avatar</param>
        private void GuardarImagem(string avatarPathRelative, string avatarPathAbsoluto)
        {
            if (File.Exists(avatarPathRelative))
            {
                if(avatarPathAbsoluto != avatarPathRelative)
                {
                    File.Delete(avatarPathRelative);

                    using (Bitmap imagemAvatar = new Bitmap(avatarPathAbsoluto))
                    {
                        if (imagemAvatar.Width <= 128 && imagemAvatar.Height <= 128)
                        {
                            Image avatarImagem = new Bitmap(imagemAvatar);
                            avatarImagem.Save(avatarPathRelative, System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                }
            }

            else
            {
                using (Bitmap imagemAvatar = new Bitmap(avatarPathAbsoluto))
                {
                    if (imagemAvatar.Width <= 128 && imagemAvatar.Height <= 128)
                    {
                        Image avatarImagem = new Bitmap(imagemAvatar);
                        avatarImagem.Save(avatarPathRelative, System.Drawing.Imaging.ImageFormat.Png);
                    }
                }
            }
        }

        /// <summary>
        /// Método para fazer refresh à DataGridView (Tabela) na tab dos Utilizadores.
        /// Muda a Data Source da Data Grid View para o tipo do utilizador correspondente.
        /// </summary>
        private void RefreshTabelaUtilizadores()
        {
            if(radioAdmins.Checked == true)
            {
                bindingSourceAdminstradores.DataSource = dataSetAdministradores.UserSet;
                userSetTableAdapterAdministradores.Fill(dataSetAdministradores.UserSet);
                dgvGUtilizadoresLista.DataSource = bindingSourceAdminstradores;
            }

            else if (radioArbitros.Checked == true)
            {
                bindingSourceArbitros.DataSource = dataSetArbitros.UserSet;
                userSetTableAdapterArbitros.Fill(dataSetArbitros.UserSet);
                dgvGUtilizadoresLista.DataSource = bindingSourceArbitros;
            }
        }

        /// <summary>
        /// Método para fazer reset ao formulário de preenchimento do Arbitro.
        /// Limpa os dados presentes do formulário.
        /// </summary>
        private void ResetFormAdministrador()
        {
            txtUsernameAdministrador.Clear();
            txtPasswordAdministrador.Clear();
            txtEmailAdministrador.Clear();
            gbGUtilizadoresDados.Enabled = true;
        }

        /// <summary>
        /// Método para fazer reset ao formulário de preenchimento do Administrador.
        /// Limpa os dados presentes do formulário.
        /// </summary>
        private void ResetFormArbitro()
        {
            txtUsernameArbitro.Clear();
            txtPasswordArbitro.Clear();
            txtNomeArbitro.Clear();
            txtAvatarArbitro.Clear();
            pbAvatarArbitro.Image = null;
            gbGUtilizadoresDados.Enabled = true;
        }

        /// <summary>
        /// Método para verificar se o utilizador inseriu dados já existentes na base de dados, sende estes o username e o email do administrador.
        /// Verifica se o username inserido é igual ao username de cada utilizador.
        /// De seguida, verifica se o email inserido é igual ao email de cada administrador.
        /// Se for igual para qualquer dos casos, a variável boolean "naoExisteDados" é igual a false.
        /// No final, retorna a variavel anterior.
        /// </summary>
        /// <param name="usernameAdministrador">Username do Administrador</param>
        /// <param name="emailAdministrador">Email do Administrador</param>
        /// <returns>Variavel Boolean "naoExisteDados"</returns>
        private bool VerificarDadosAdmnistrador(string usernameAdministrador, string emailAdministrador)
        {
            bool naoExisteDados = true;

            foreach (User utilizador in containerDados.UserSet)
            {
                if (utilizador.Username == usernameAdministrador)
                {
                    naoExisteDados = false;
                }

                else
                {
                    foreach (Administrator admin in containerDados.UserSet.OfType<Administrator>())
                    {
                        if (admin.Email == emailAdministrador)
                        {
                            naoExisteDados = false;
                        }
                    }
                }
            }

            return naoExisteDados;
        }

        /// <summary>
        /// Método para verificar se o utilizador inseriu dados já existentes na base de dados, sende estes o username, o nome e avtar do arbitro.
        /// Verifica se o username inserido é igual ao username de cada utilizador.
        /// De seguida, verifica se o nome inserido é igual ao nome de cada arbitro.
        /// Se for igual para qualquer dos casos, a variável boolean "naoExisteDados" é igual a false.
        /// No final, retorna a variavel anterior.
        /// </summary>
        /// <param name="usernameArbitro">Username do Arbitro</param>
        /// <param name="nomeArbitro">Nome do Arbitro</param>
        /// <param name="avatarPathArbitro">Avatar do Arbitro</param>
        /// <returns>Variavel Boolean "naoExisteDados"</returns>
        private bool VerificarDadosArbitro(string usernameArbitro, string nomeArbitro, string avatarPathArbitro)
        {
            bool naoExisteDados = true;

            foreach (User utilizador in containerDados.UserSet)
            {
                if (utilizador.Username == usernameArbitro)
                {
                    naoExisteDados = false;
                }

                else
                {
                    foreach (Referee arbitro in containerDados.UserSet.OfType<Referee>())
                    {
                        if (arbitro.Name == nomeArbitro)
                        {
                            naoExisteDados = false;
                        }
                    }
                }
            }

            return naoExisteDados;
        }

        /// <summary>
        /// Método para verificar se a linha da tabela na tab dos Utilizadores é do tipo Administrator.
        /// Verifica se o id da linha selecionada é igual ao id de um administrador.
        /// Se for igual, a variavel Boolean "isTipoAdministrator" é igual a true.
        /// No final, retorna a variavel anterior.
        /// </summary>
        /// <param name="rowUtilizador">Linha da Tabela do utilizador selecionado</param>
        /// <returns>Variavel Boolean "isTipoAdministrator"</returns>
        private bool VerificarTipoAdministrator(DataGridViewRow rowUtilizador)
        {
            bool isTipoAdministrator = false;

            foreach(Administrator admin in containerDados.UserSet.OfType<Administrator>())
            {
                if(admin.Id == (int)rowUtilizador.Cells[0].Value)
                {
                    isTipoAdministrator = true;
                }
            }

            return isTipoAdministrator;
        }

        /// <summary>
        /// Método para verificar se a linha da tabela na tab dos Utilizadores é do tipo Referee.
        /// Verifica se o id da linha selecionada é igual ao id de um arbitro.
        /// Se for igual, a variavel Boolean "isTipoArbitro" é igual a true.
        /// No final, retorna a variavel anterior.
        /// </summary>
        /// <param name="rowUtilizador">Linha da Tabela do utilizador selecionado</param>
        /// <returns>Variavel Boolean "isTipoArbitro"</returns>
        private bool VerificarTipoReferee(DataGridViewRow rowUtilizador)
        {
            bool isTipoArbitro = false;

            foreach (Referee arbitro in containerDados.UserSet.OfType<Referee>())
            {
                if (arbitro.Id == (int)rowUtilizador.Cells[0].Value)
                {
                    isTipoArbitro = true;
                }
            }

            return isTipoArbitro;
        }

        /// <summary>
        /// Método para verificar se os dados alterados já existem na base de dados.
        /// Verifica se o username alterado é igual ao username de cada administrador, exceto o administrador a ser alterado.
        /// De seguida, verifica se o email é igual ao email de cada adminstrador, excetp o administrador a ser alterado.
        /// Se for igual para qualquer dos casos, a variavel Boolean "aplicaAlteracoes" é igual a false.
        /// No final, retorna a variavel anterior.
        /// </summary>
        /// <param name="usernameAdministrador">Username do Administrador</param>
        /// <param name="emailAdministrador">Email do Administrador</param>
        /// <returns>Variavel Boolean "aplicaAlteracoes"</returns>
        private bool VerificarAlteracoesAdministrador(string usernameAdministrador, string emailAdministrador)
        {
            bool aplicaAlteracoes = true;

            foreach (User utilizador in containerDados.UserSet)
            {
                if(utilizador.Username == usernameAdministrador && utilizador.Id != idAdministrador)
                {
                    aplicaAlteracoes = false;
                }

                else
                {
                    foreach (Administrator admin in containerDados.UserSet.OfType<Administrator>())
                    {
                        if(admin.Email == emailAdministrador && admin.Id != idAdministrador)
                        {
                            aplicaAlteracoes = false;
                        }
                    }
                }
            }

            return aplicaAlteracoes;
        }

        /// <summary>
        /// Método para verificar se os dados alterados já existem na base de dados.
        /// Verifica se o username alterado é igual ao username de cada arbitro, exceto o arbitro a ser alterado.
        /// De seguida, verifica se o nome é igual ao nome de cada arbitro, exceto o arbitro a ser alterado.
        /// Se for igual para qualquer dos casos, a variavel Boolean "aplicaAlteracoes" é igual a false.
        /// No final, retorna a variavel anterior.
        /// </summary>
        /// <param name="usernameArbitro">Username do Arbitro</param>
        /// <param name="nomeArbitro">Nome do Arbitro</param>
        /// <param name="avatarPathArbitro">Avatar do Arbitro</param>
        /// <returns>Variavel Boolean "aplicaAlteracoes"</returns>
        private bool VerificarAlteracoesArbitro(string usernameArbitro, string nomeArbitro, string avatarPathArbitro)
        {
            bool aplicaAlteracoes = true;

            foreach (User utilizador in containerDados.UserSet)
            {
                if (utilizador.Username == usernameArbitro && utilizador.Id != idArbitro)
                {
                    aplicaAlteracoes = false;
                }

                else
                {
                    foreach (Referee arbitro in containerDados.UserSet.OfType<Referee>())
                    {
                        if (arbitro.Name == nomeArbitro && arbitro.Id != idArbitro)
                        {
                            aplicaAlteracoes = false;
                        }
                    }
                }
            }

            return aplicaAlteracoes;
        }

        #endregion

        #region Pesquisa de Utilizadores

        /// <summary>
        /// Evento do radio button "Administrador", na tab de Pesquisa de Utilizadores.
        /// Apenas invoca os métodos ResetPesquisaUtilizadoresForm e RefreshTabelaPesquisaUtilizadores para limpar o form e fazer refresh à tabela.
        /// </summary>
        private void RadioPesquisarAdministrador(object sender, EventArgs e)
        {
            ResetPesquisaUtilizadoresForm();
            RefreshTabelaPesquisaUtilizadores();
        }

        /// <summary>
        /// Evento do radio button "Arbitro", na tab de Pesquisa de Utilizadores.
        /// Apenas invoca os métodos ResetPesquisaUtilizadoresForm e RefreshTabelaPesquisaUtilizadores para limpar o form e fazer refresh à tabela.
        /// </summary>
        private void RadioPesquisarArbitro(object sender, EventArgs e)
        {
            ResetPesquisaUtilizadoresForm();
            RefreshTabelaPesquisaUtilizadores();
        }

        /// <summary>
        /// Evento da checkbox "Ativo", na tab de Pesquisa de Utilizadores.
        /// Indica se o utilizador deseja pesquisar arbitros ativos, isto é, tenham jogos futuros associados.
        /// Invoca os métodos de pesquisa de Arbitros, dependendo se a checkbox seja ativada.
        /// </summary>
        private void CheckArbitroAtivo(object sender, EventArgs e)
        {
            if (checkPesquisaArbitroAtivo.Checked == true)
            {
                PesquisarArbitrosAtivos(txtPesquisaUsername.Text.Trim(), txtPesquisaNomeArbitro.Text.Trim());
            }

            else
            {
                PesquisarArbitros(txtPesquisaUsername.Text.Trim(), txtPesquisaNomeArbitro.Text.Trim());
            }
        }

        /// <summary>
        /// Evento do botão "Pesquisar", na tab de Pesquisa de Utilizadores.
        /// Invoca os métodos de Pesquisa de Utilizadores, dependendo do tipo de utilizador selecionado
        /// </summary>
        private void PesquisaAvancadaUtilizador(object sender, EventArgs e)
        {
            if (radioPesquisaAdministrador.Checked == true)
            {
                PesquisarAdminstrador(txtPesquisaUsername.Text.Trim(), txtPesquisaEmailAdministrador.Text.Trim());
            }

            else if (radioPesquisaArbitro.Checked == true)
            {
                if(checkPesquisaArbitroAtivo.Checked == true)
                {
                    PesquisarArbitrosAtivos(txtPesquisaUsername.Text.Trim(), txtPesquisaNomeArbitro.Text.Trim());
                }

                else
                {
                    PesquisarArbitros(txtPesquisaUsername.Text.Trim(), txtPesquisaNomeArbitro.Text.Trim());
                }
            }
        }

        /// <summary>
        /// Evento do botão "Reset", na tab de Pesquisa de Utilizadores
        /// Apenas invoca os métodos ResetPesquisaUtilizadoresForm e RefreshTabelaPesquisaUtilizadores para limpar o form e fazer refresh à tabela.
        /// </summary>
        private void BotaoResetPesquisa(object sender, EventArgs e)
        {
            ResetPesquisaUtilizadoresForm();
            RefreshTabelaPesquisaUtilizadores();
        }

        /// <summary>
        /// Método para pesquisar administradores, segundo os dados inseridos no form de pesquisa.
        /// Segundo o username e email inseridos, executa uma query LINQ e apresenta os dados.
        /// As pesquisa são feitas nos DataSets e, não no container, devido à existência de dados não desejados para mostrar.
        /// </summary>
        /// <param name="username">Username do Admin</param>
        /// <param name="email">Email do Admin</param>
        private void PesquisarAdminstrador(string username, string email)
        {
            IEnumerable<BD_DA_ProjetoDataSet_Administradores.UserSetRow> queryLinq;

            if (username.Length > 0 && email.Length > 0)
            {
                queryLinq = from admins in dataSetAdministradores.UserSet
                            where admins.Field<string>("Username").Contains(username)
                            && admins.Field<string>("Email").Contains(email)
                            select admins;
            }

            else if(username.Length > 0)
            {
                queryLinq = from admins in dataSetAdministradores.UserSet
                            where admins.Field<string>("Username").Contains(username)
                            select admins;
            }

            else if(email.Length > 0)
            {
                queryLinq = from admins in dataSetAdministradores.UserSet
                            where admins.Field<string>("Email").Contains(email)
                            select admins;
            }

            else
            {
                queryLinq = from admins in dataSetAdministradores.UserSet
                            select admins;
            }

            if (queryLinq.Any() == true)
            {
                DataTable queryTable = queryLinq.CopyToDataTable();

                bindingSourceAdminstradores.DataSource = queryTable;

                dgvPesquisaUtilizadores.DataSource = bindingSourceAdminstradores;
            }

            else
            {
                dgvPesquisaUtilizadores.DataSource = null;
            }
        }

        /// <summary>
        /// Método para pesquisar arbitros, segundo os dados inseridos no form de pesquisa.
        /// Segundo o username e nome inseridos, executa uma query LINQ e apresenta os dados.
        /// As pesquisa são feitas nos DataSets e, não no container, devido à existência de dados não desejados para mostrar.
        /// </summary>
        /// <param name="username">Username do arbitro</param>
        /// <param name="name">Nome do arbitro</param>
        private void PesquisarArbitros(string username, string name)
        {
            IEnumerable<BD_DA_ProjetoDataSet_Arbitros.UserSetRow> queryLinq;

            if (username.Length > 0 && name.Length > 0)
            {
                queryLinq = from arbitros in dataSetArbitros.UserSet
                            where arbitros.Field<string>("Username").Contains(username)
                            && arbitros.Field<string>("Name").Contains(name)
                            select arbitros;
            }

            else if (username.Length > 0)
            {
                queryLinq = from arbitros in dataSetArbitros.UserSet
                            where arbitros.Field<string>("Username").Contains(username)
                            select arbitros;
            }

            else if (name.Length > 0)
            {
                queryLinq = from arbitros in dataSetArbitros.UserSet
                            where arbitros.Field<string>("Name").Contains(name)
                            select arbitros;
            }

            else
            {
                queryLinq = from arbitros in dataSetArbitros.UserSet
                            select arbitros;
            }

            if (queryLinq.Any() == true)
            {
                DataTable queryTable = queryLinq.CopyToDataTable();

                bindingSourceArbitros.DataSource = queryTable;

                dgvPesquisaUtilizadores.DataSource = bindingSourceArbitros;
            }

            else
            {
                dgvPesquisaUtilizadores.DataSource = null;
            }
        }

        /// <summary>
        /// Método para pesquisar arbitros ativos, isto é, arbitros com jogos pendentes, segundo os dados inseridos no form de pesquisa.
        /// Segundo o username e nome inseridos, executa uma query LINQ e apresenta os dados.
        /// As pesquisa são feitas nos DataSets e, não no container, devido à existência de dados não desejados para mostrar.
        /// </summary>
        /// <param name="username">Username do arbitro</param>
        /// <param name="name">Nome do arbitro</param>
        private void PesquisarArbitrosAtivos(string username, string name)
        {
            IEnumerable<BD_DA_ProjetoDataSet_Arbitros.UserSetRow> queryLinq;

            if (txtPesquisaUsername.Text.Length > 0 && txtPesquisaNomeArbitro.Text.Length > 0)
            {
                queryLinq = from arbitros in dataSetArbitros.UserSet
                            join jogo in containerDados.GameSet
                            on arbitros.Id equals jogo.RefereeId
                            where arbitros.Field<string>("Username").Contains(username)
                            && arbitros.Field<string>("Name").Contains(name)
                            select arbitros;
            }

            else if (txtPesquisaUsername.Text.Length > 0)
            {
                queryLinq = from arbitros in dataSetArbitros.UserSet
                            join jogo in containerDados.GameSet
                            on arbitros.Id equals jogo.RefereeId
                            where arbitros.Field<string>("Username").Contains(username)
                            select arbitros;
            }

            else if (txtPesquisaNomeArbitro.Text.Length > 0)
            {
                queryLinq = from arbitros in dataSetArbitros.UserSet
                            join jogo in containerDados.GameSet
                            on arbitros.Id equals jogo.RefereeId
                            where arbitros.Field<string>("Name").Contains(name)
                            select arbitros;
            }

            else
            {
                queryLinq = from arbitros in dataSetArbitros.UserSet
                            join jogo in containerDados.GameSet
                            on arbitros.Id equals jogo.RefereeId
                            select arbitros;
            }

            if (queryLinq.Any() == true)
            {
                DataTable queryTable = queryLinq.CopyToDataTable();

                bindingSourceArbitros.DataSource = queryTable;

                dgvPesquisaUtilizadores.DataSource = bindingSourceArbitros;
            }

            else
            {
                dgvPesquisaUtilizadores.DataSource = null;
            }
        }

        /// <summary>
        /// Método para fazer refresh à DataGridView (Tabela) na tab de Pesquisa de Utilizadores.
        /// Muda a Data Source da Data Grid View para o tipo do utilizador correspondente.
        /// </summary>
        private void RefreshTabelaPesquisaUtilizadores()
        {
            if (radioPesquisaAdministrador.Checked == true)
            {
                bindingSourceAdminstradores.DataSource = dataSetAdministradores.UserSet;
                userSetTableAdapterAdministradores.Fill(dataSetAdministradores.UserSet);
                dgvPesquisaUtilizadores.DataSource = bindingSourceAdminstradores;
            }

            else
            {
                bindingSourceArbitros.DataSource = dataSetArbitros.UserSet;
                userSetTableAdapterArbitros.Fill(dataSetArbitros.UserSet);
                dgvPesquisaUtilizadores.DataSource = bindingSourceArbitros;
            }
        }

        /// <summary>
        /// Método para fazer reset ao form de pesquisa de Utilizadores.
        /// Limpa o form relativamente ao tipo de utilizador.
        /// </summary>
        private void ResetPesquisaUtilizadoresForm()
        {
            if (radioPesquisaAdministrador.Checked == true)
            {
                labPesquisaNomeEmail.Text = "Email:";
                txtPesquisaUsername.Clear();
                txtPesquisaEmailAdministrador.Clear();
                txtPesquisaEmailAdministrador.Visible = true;
                txtPesquisaNomeArbitro.Clear();
                txtPesquisaNomeArbitro.Visible = false;
                checkPesquisaArbitroAtivo.Visible = false;
            }

            else if (radioPesquisaArbitro.Checked == true)
            {
                labPesquisaNomeEmail.Text = "Nome:";
                txtPesquisaUsername.Clear();
                txtPesquisaEmailAdministrador.Clear();
                txtPesquisaEmailAdministrador.Visible = false;
                txtPesquisaNomeArbitro.Clear();
                txtPesquisaNomeArbitro.Visible = true;
                checkPesquisaArbitroAtivo.Checked = false;
                checkPesquisaArbitroAtivo.Visible = true;
            }
        }

        /// <summary>
        /// Evento da tab de Pesquisa de Utilizadores.
        /// Invoca o método RefreshTabelaPesquisaUtilizadores para carregar os dados para a Data Grid View.
        /// </summary>
        private void TabPesquisaUtilizadores(object sender, EventArgs e)
        {
            RefreshTabelaPesquisaUtilizadores();
        }

        #endregion

        #region Gestao de Cartas

        /// <summary>
        /// Ativa o formulário para preencher os dados da nova carta.
        /// Ajusta o texto do botão de ações.
        /// </summary>
        private void btnInserirCarta_Click(object sender, EventArgs e)
        {
            gbGCartasForm.Enabled = true;
            gbGCartasForm.Visible = true;
            btnAcaoCarta.Text = "Criar";
        }

        /// <summary>
        /// Ativa o formulário e carrega os valores da carta selecionada para
        /// os respetivos campos.
        /// Ajusta o texto do botão de ações
        /// </summary>
        private void btnAlterarCarta_Click(object sender, EventArgs e)
        {
            gbGCartasForm.Visible = true;
            gbGCartasForm.Enabled = true;
            btnAcaoCarta.Text = "Guardar";

            idCarta = (int)dgvGCartasLista.CurrentRow.Cells[0].Value;

            txtGNomeCarta.Text = dgvGCartasLista.CurrentRow.Cells[1].Value.ToString();
            cmbFacaoCarta.SelectedItem = dgvGCartasLista.CurrentRow.Cells[2].Value.ToString();
            cmbGTipoCarta.SelectedItem = dgvGCartasLista.CurrentRow.Cells[3].Value.ToString();
            txtGCustoCarta.Text = dgvGCartasLista.CurrentRow.Cells[4].Value.ToString();
            nudGLealdadeCarta.Value = (int)dgvGCartasLista.CurrentRow.Cells[5].Value;
            txtGRegrasCarta.Text = dgvGCartasLista.CurrentRow.Cells[6].Value.ToString();
            nudGAtaqueCarta.Value = (int)dgvGCartasLista.CurrentRow.Cells[7].Value;
            nudGDefesaCarta.Value = (int)dgvGCartasLista.CurrentRow.Cells[8].Value;
        }

        /// <summary>
        /// Confirma a intenção do utilizador de eliminar a carta selecionada
        /// Caso confirme, obtém o id da carta e chama a função para remover a carta
        /// Informa o utilizador do resultado da operação
        /// </summary>
        private void btnRemoverCarta_Click(object sender, EventArgs e)
        {
            string nomeCarta = dgvGCartasLista.CurrentRow.Cells[1].Value.ToString();

            DialogResult confirm =
                MessageBox.Show("Tem a certeza que quer eliminar a carta '" + nomeCarta + "'?",
                "Atenção", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                idCarta = (int)dgvGCartasLista.CurrentRow.Cells[0].Value;

                if (RemoverCarta())
                {
                    MessageBox.Show("Carta eliminada com sucesso!", "Informação");
                }
                else
                {
                    MessageBox.Show("Erro ao eliminar a carta", "Informação");
                }

                RefreshTabelaCartas();
            }

        }

        /// <summary>
        /// Desbloqueia os botões para alterar e remover se estiver um registo selecionado
        /// </summary
        private void dgvGCartasLista_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGCartasLista.SelectedCells.Count > 0)
            {
                btnAlterarCarta.Enabled = true;
                btnRemoverCarta.Enabled = true;
            }
        }

        /// <summary>
        /// Bloqueia os botões para alterar e remover cartas se nenhum registo estiver selecionado
        /// </summary>
        private void dgvGCartasLista_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGCartasLista.SelectedCells.Count == 0)
            {
                btnAlterarCarta.Enabled = false;
                btnRemoverCarta.Enabled = false;
            }
        }

        /// <summary>
        /// Verifica se os dados obrigatórios do formulário estão preenchidos
        /// Verifica se a carta já existe
        /// Verifica se o utilizador tenta criar ou alterar uma carta
        /// Chama a função para realizar a operação adequada
        /// Atualiza a tabela com os dados e limpa o formulário
        /// </summary>
        private void btnAcaoCarta_Click(object sender, EventArgs e)
        {
            if (txtGNomeCarta.Text.Length == 0 || cmbFacaoCarta.SelectedIndex == -1 ||
                cmbGTipoCarta.SelectedIndex == -1 || txtGCustoCarta.Text.Length == 0 ||
                txtGRegrasCarta.Text.Length == 0)
            {
                MessageBox.Show("Tem de preencher todos os campos", "Informação");
            }
            else
            {
                // Guarda os dados da carta em variáveis para facilitar o uso
                string name = txtGNomeCarta.Text;
                string faction = cmbFacaoCarta.SelectedItem.ToString();
                string type = cmbGTipoCarta.SelectedItem.ToString();
                string cost = txtGCustoCarta.Text;
                int loyalty = (int)nudGLealdadeCarta.Value;
                string rules = txtGRegrasCarta.Text;
                int attack = (int)nudGAtaqueCarta.Value;
                int defense = (int)nudGDefesaCarta.Value;
                //-------------------------------------------


                // Verifica se o utilizador está a criar ou a alterar uma carta
                //Executa a função respetiva
                if (btnAcaoCarta.Text == "Criar")
                {
                    //Verifica se a carta já existe
                    if (VerificarCartaExiste(name))
                    {
                        MessageBox.Show("A carta '" + name + "' já existe", "Informação");
                    }
                    else
                    {

                        if (InserirCarta(name, faction, type, cost, loyalty, rules, attack, defense))
                        {
                            MessageBox.Show("Carta criada com sucesso!", "Informação");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao criar a carta", "Informação");
                        }
                    }
                }
                else if (btnAcaoCarta.Text == "Guardar")
                {
                    if (AlterarCarta(name, faction, type, cost, loyalty, rules, attack, defense))
                    {
                        MessageBox.Show("Carta alterada com sucesso!", "Informação");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar a carta", "Informação");
                    }

                }

                RefreshTabelaCartas();

                ResetFormCartas();

            }
        }

        /// <summary>
        /// Chama a função que prepara o formulário para novo uso
        /// </summary>
        private void btnCartaCancelar_Click(object sender, EventArgs e)
        {
            ResetFormCartas();
        }

        /// <summary>
        /// Limpa os dados do formulário das cartas para novo uso
        /// Volta a bloquá-lo
        /// </summary>
        private void ResetFormCartas()
        {
            txtGNomeCarta.ResetText();
            cmbFacaoCarta.SelectedIndex = -1;
            cmbGTipoCarta.SelectedIndex = -1;
            txtGCustoCarta.ResetText();
            nudGLealdadeCarta.Value = 0;
            txtGRegrasCarta.ResetText();
            nudGAtaqueCarta.Value = 0;
            nudGDefesaCarta.Value = 0;

            btnAcaoCarta.Text = "Ação";

            gbGCartasForm.Enabled = false;
            gbGCartasForm.Visible = false;
        }

        /// <summary>
        /// Atualiza a fonte de dados 
        /// Atribui a fonte de dados á DataGridView dgvGCartasLista
        /// Desloca a posição atual na DataGridViw para o último registo
        /// </summary>
        private void RefreshTabelaCartas()
        {
            this.cardSetTableAdapter.Fill(this.bD_DA_ProjetoDataSet_Cards.CardSet);
            dgvGCartasLista.DataSource = cardSetBindingSource;

            int lastrow = dgvGCartasLista.Rows.GetLastRow(DataGridViewElementStates.Visible);
            dgvGCartasLista.CurrentCell = dgvGCartasLista[0, lastrow];

        }

        /// <summary>
        /// Recebe como parâmetro o nome de uma carta
        /// Verifica se existe na base de dados
        /// Retorna o resultado da operação
        /// </summary>
        private Boolean VerificarCartaExiste(string nome)
        {
            Boolean result = false;

            int countResult = containerDados.CardSet.Where(card => card.Name.Equals(nome)).Count();

            if (countResult == 1)
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Recebe como parâmetros os dados de uma carta
        /// Cria um objeto para guardar os dados da nova carta
        /// Tenta adicionar a nova carta à base de dados
        /// Retorna o resultado da operação
        /// </summary>
        private Boolean InserirCarta(string name, string faction, string type, string cost,
            int loyalty, string rules, int attack, int defense)
        {
            Boolean result;

            try
            {
                Card novaCarta = new Card
                {
                    Name = name,
                    Faction = faction,
                    Type = type,
                    Cost = cost,
                    Loyalty = loyalty,
                    RuleText = rules,
                    Attack = attack,
                    Defense = defense
                };

                containerDados.CardSet.Add(novaCarta);
                containerDados.SaveChanges();

                result = true;
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Recebe como parametros os novos dados da carta
        /// Procura a carta na base de dados
        /// Atualiza os dados da carta
        /// Modifica e guarda alterações
        /// Retorna o resultado da operação
        /// </summary>
        private Boolean AlterarCarta(string name, string faction, string type, string cost,
            int loyalty, string rules, int attack, int defense)
        {
            Boolean result;

            try
            {
                Card carta;

                carta = containerDados.CardSet.Find(idCarta);

                carta.Name = name;
                carta.Faction = faction;
                carta.Type = type;
                carta.Cost = cost;
                carta.Loyalty = loyalty;
                carta.RuleText = rules;
                carta.Attack = attack;
                carta.Defense = defense;

                containerDados.Entry(carta).State = System.Data.Entity.EntityState.Modified;
                containerDados.SaveChanges();

                result = true;
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Procura na base de dados a carta com o mesmo id da carta selecionada
        /// Tenta remover a carta da base de dados
        /// Retorna o resultado da operação
        /// </summary>
        private Boolean RemoverCarta()
        {
            Boolean result;

            try
            {
                Card carta = containerDados.CardSet.Where(c => c.Id.Equals(idCarta)).Single();

                containerDados.CardSet.Remove(carta);

                containerDados.SaveChanges();
                result = true;
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                MessageBox.Show("Não pode eliminar uma carta que está a ser usada num baralho." + Environment.NewLine + ex.Message, "Erro");
                result = false;
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Se a caixa de texto tiver algo
        ///     Cria uma query e seleciona as cartas cujo nome contenha o texto obtido
        /// Senão
        ///     Recarrega a tabela
        /// </summary>
        private void txtGCartasPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtGCartasPesquisa.Text.Length > 0)
            {

                var query = from cards in containerDados.CardSet
                            where cards.Name.Contains(txtGCartasPesquisa.Text)
                            select cards;

                dgvGCartasLista.DataSource = query.ToList();
            }
            else
            {
                RefreshTabelaCartas();
            }
        }

        private void btnImportarCartas_Click(object sender, EventArgs e)
        {
            if (FileDialogImportarCarta.ShowDialog() == DialogResult.OK)
            {
                string path = FileDialogImportarCarta.FileName;

                string linha = "";
                int nCartasTotais = 0;
                int nCartasImportadas = 0;

                using (StreamReader ficheiro = new StreamReader(path))
                {
                    Card carta;

                    linha = ficheiro.ReadLine();

                    nCartasTotais = Convert.ToInt32(linha.Substring(2));

                    while (ficheiro.EndOfStream == false)
                    {
                        carta = new Card();

                        ficheiro.ReadLine();

                        carta.Name = ficheiro.ReadLine();

                        carta.Faction = ficheiro.ReadLine();

                        carta.Type = ficheiro.ReadLine();

                        carta.Cost = ficheiro.ReadLine();

                        carta.Loyalty = Convert.ToInt32(ficheiro.ReadLine());

                        carta.RuleText = ficheiro.ReadLine();

                        carta.Attack = Convert.ToInt32(ficheiro.ReadLine());

                        carta.Defense = Convert.ToInt32(ficheiro.ReadLine());

                        containerDados.CardSet.Add(carta);
                        nCartasImportadas++;
                    }
                }

                containerDados.SaveChanges();

                MessageBox.Show("Importadas " + nCartasImportadas + " de " + nCartasTotais + " cartas do ficheiro");

                RefreshTabelaCartas();
            }
        }

        #endregion

        #region Gestao de Baralhos

        /// <summary>
        /// Ativa os botões de Gerir e Eliminar baralhos
        ///     se estiver um baralho selecionado
        /// </summary>
        private void dgvGBaralhosLista_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGBaralhosLista.SelectedCells.Count > 0)
            {
                btnGerirBaralho.Enabled = true;
                btnEliminarBaralho.Enabled = true;
            }
        }

        /// <summary>
        /// Desativa os botões de Gerir e Eliminar baralhos
        ///     se não estiver um baralho selecionado
        /// </summary>
        private void dgvGBaralhosLista_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGBaralhosLista.SelectedCells.Count == 0)
            {
                btnGerirBaralho.Enabled = false;
                btnEliminarBaralho.Enabled = false;
            }
        }

        /// <summary>
        /// Mostra a Groupbox com os capos para a criação de um baralho
        /// </summary>
        private void btnInserirBaralho_Click(object sender, EventArgs e)
        {
            gbGBaralhosForm.Visible = true;
        }

        /// <summary>
        /// Obtém o ID do baralho atual
        /// Limpa os dados as listviews
        /// Percorre todas as cartas existentes
        ///     Percorre os registos de cartas no baralho atual
        ///         Se o registo corresponder á carta, guarda-a na listview respetiva
        ///     Guarda a carta na listview respetiva
        /// Atualiza a label com o número de cartas no baralho
        /// </summary>
        private void btnGerirBaralho_Click(object sender, EventArgs e)
        {
            idBaralho = (int)dgvGBaralhosLista.CurrentRow.Cells[0].Value;
            int ncartas = 0;
            int qtdCartas;

            ListViewItem linhaCartasBaralho;
            ListViewItem linhaListaCartas;

            //---------------------------------
            //Limpar listviews
            lvListaCartas.Items.Clear();
            lvCartasBaralho.Items.Clear();

            //Percorrer todas as cartas
            foreach (Card carta in containerDados.CardSet)
            {
                //Recomeçar contador
                qtdCartas = 0;

                //Percorrer registos de cartas no baralho escolhido
                foreach (DeckCards registo in containerDados.DeckCardsSet.Where(dc => dc.DeckId.Equals(idBaralho)))
                {
                    //Se a carta estiver associada ao baralho, adiciona-a na respetiva listview

                    if (registo.CardId == carta.Id)
                    {
                        qtdCartas = registo.Qtd;
                        ncartas += qtdCartas;

                        //----------------------------------------
                        linhaCartasBaralho = new ListViewItem(carta.Name);
                        linhaCartasBaralho.SubItems.Add(carta.Type);
                        linhaCartasBaralho.SubItems.Add(qtdCartas.ToString());
                        lvCartasBaralho.Items.Add(linhaCartasBaralho);
                    }
                }

                //Adiciona a carta á respetiva listview
                //----------------------------------------
                linhaListaCartas = new ListViewItem(carta.Name);
                linhaListaCartas.SubItems.Add(carta.Type);
                linhaListaCartas.SubItems.Add((3 - qtdCartas).ToString());
                lvListaCartas.Items.Add(linhaListaCartas);

            }

            //Atualiza a label com o nº de cartas no baralho
            //----------------------------------

            lblNCartasNoBaralho.Text = Convert.ToString(ncartas);
            panelGestaoBaralho.Enabled = true;

        }

        /// <summary>
        /// Confirma a intenção do utilizador de eliminar o baralho selecionado
        /// Caso confirme, obtém o id do baralho e chama a função para remover o baralho
        /// Informa o utilizador do resultado da operação
        /// </summary>
        private void btnEliminarBaralho_Click(object sender, EventArgs e)
        {
            string nomeBaralho = dgvGBaralhosLista.CurrentRow.Cells[1].Value.ToString();

            DialogResult confirm =
                MessageBox.Show("Tem a certeza que quer eliminar o baralho '" + nomeBaralho + "'?",
                "Atenção", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                idBaralho = (int)dgvGBaralhosLista.CurrentRow.Cells[0].Value;

                if (RemoverBaralho())
                {
                    MessageBox.Show("Baralho eliminado com sucesso!", "Informação");
                }
                else
                {
                    MessageBox.Show("Erro ao eliminar o baralho", "Informação");
                }

                RefreshTabelaBaralhos();
            }
        }

        /// <summary>
        /// Atualiza a fonte de dados da tabela 
        /// Atribui a fonta de dados à DataGridView dgvGBaralhosLista
        /// Desloca a posição atual na DataGridView para a última linha
        /// </summary>
        private void RefreshTabelaBaralhos()
        {
            this.deckSetTableAdapter.Fill(this.bD_DA_ProjetoDataSet_Decks.DeckSet);
            dgvGBaralhosLista.DataSource = deckSetBindingSource;

            if (dgvGBaralhosLista.Rows.Count > 0)
            {
                int lastrow = dgvGBaralhosLista.Rows.GetLastRow(DataGridViewElementStates.Visible);
                dgvGBaralhosLista.CurrentCell = dgvGBaralhosLista[0, lastrow];
            }
        }

        /// <summary>
        /// Limpa o formulário de criação de baralho para novo uso
        /// </summary>
        private void ResetFormBaralhos()
        {
            txtNomeBaralho.ResetText();
            gbGBaralhosForm.Visible = false;
        }

        /// <summary>
        /// Verifica se o nome do baralho está preenchido
        /// Verifica se o baralho já existe
        /// Insere o baralho na base de dados
        /// Recarrega a tabela e limpa o formulário
        /// </summary>
        private void btnCriarBaralho_Click(object sender, EventArgs e)
        {
            if (txtNomeBaralho.Text.Length == 0)
            {
                MessageBox.Show("Tem de preencher o nome do baralho", "Informação");
            }
            else
            {
                string name = txtNomeBaralho.Text;

                if (VerificarBaralhoExiste(name))
                {
                    MessageBox.Show("O baralho '" + name + "' já existe", "Informação");
                }
                else
                {
                    if (InserirBaralho(name))
                    {
                        MessageBox.Show("Baralho criado com sucesso", "Informação");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao criar o baralho", "Informação");
                    }

                    RefreshTabelaBaralhos();

                    ResetFormBaralhos();
                }
            }

        }

        /// <summary>
        /// Chama a função que prepara o formulário para novo uso
        /// </summary>
        private void btnCancelarNovoBaralho_Click(object sender, EventArgs e)
        {
            ResetFormBaralhos();
        }

        /// <summary>
        /// Recebe o nome do baralho como parâmetro
        /// Verifica se existe um baralho com o mesmo nome
        /// Retorna o resultado
        /// </summary>
        private Boolean VerificarBaralhoExiste(string nome)
        {
            Boolean result = false;

            int countRegisto = containerDados.DeckSet.Where(deck => deck.Name.Equals(nome)).Count();

            if (countRegisto == 1)
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Recebe o nome do baralho como parâmetro
        /// Tenta criar um novo baralho na base de dados
        /// Retorna o resultado
        /// </summary>
        private Boolean InserirBaralho(string nome)
        {
            Boolean result;

            try
            {
                Deck novoDeck = new Deck
                {
                    Name = nome
                };

                containerDados.DeckSet.Add(novoDeck);
                containerDados.SaveChanges();

                result = true;
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Remove a associação de quaisquer cartas ao baralho
        /// Procura na base de dados o baralho com o mesmo id do baralho selecionado
        /// Tenta remover o baralho da base de dados
        /// Retorna o resultado da operação
        /// </summary>
        private Boolean RemoverBaralho()
        {
            Boolean result;

            try
            {
                //Remover cartas associadas ao baralho 
                //(Registos de associação que tenham o id do baralho selecionado)

                List<DeckCards> cartasBaralho = containerDados.DeckCardsSet
                        .Where(dc => dc.DeckId.Equals(idBaralho)).ToList<DeckCards>();

                containerDados.DeckCardsSet.RemoveRange(cartasBaralho);

                //Remover baralho

                Deck baralho = containerDados.DeckSet.Where(d => d.Id.Equals(idBaralho)).Single();

                containerDados.DeckSet.Remove(baralho);

                containerDados.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Se a caixa de texto tiver algo
        ///     Cria uma query (Linq) e seleciona os baralhos cujo nome contenha o texto obtido
        ///     Atribui a lista de resultados á DataGridView
        /// Senão
        ///     Recarrega a tabela
        /// </summary>
        private void txtGBaralhosPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtGBaralhosPesquisa.Text.Length > 0) if (txtGBaralhosPesquisa.Text.Length > 0)
            {

                    var query = from decks in containerDados.DeckSet
                                where decks.Name.Contains(txtGBaralhosPesquisa.Text)
                                select decks;

                    dgvGBaralhosLista.DataSource = query.ToList();
            }

            else
            {
                RefreshTabelaBaralhos();
            }
        }

        /// <summary>
        /// Se o utilizador tiver selecionado uma carta na Lista de cartas (e o baralho tiver espaço)
        ///     Ativa o botão para adicionar a carta ao baralho
        /// Senão
        ///     Desativa-o
        /// </summary>
        private void lvListaCartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvListaCartas.SelectedItems.Count > 0 && Convert.ToInt32(lblNCartasNoBaralho.Text) < 45)
            {
                btnAdicionarCartaBaralho.Enabled = true;
            }
            else
            {
                btnAdicionarCartaBaralho.Enabled = false;
            }
        }

        /// <summary>
        /// Se o utilizador tiver seleciona uma carta na lista de cartas no baralho
        ///     Ativa o botão para remover a carta do baralho
        /// Senão
        ///     Desativa-o
        /// </summary>
        private void lvCartasBaralho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCartasBaralho.SelectedItems.Count > 0)
            {
                btnRemoverCartaBaralho.Enabled = true;
            }
            else
            {
                btnRemoverCartaBaralho.Enabled = false;
            }
        }

        /// <summary>
        /// Obtem os dados da carta selecionada
        /// Verifica se a carta selecionada já existe na Lista de cartas no baralho
        ///     Se sim, incrementa a quantidade
        ///     Se não, adiciona
        /// Decrementa a quantidade da carta na lista de cartas
        /// Remove carta selecionada da listview se a quantidade for zero
        /// </summary>
        private void btnAdicionarCartaBaralho_Click(object sender, EventArgs e)
        {
            ListViewItem cartaAdicionar = lvListaCartas.SelectedItems[0];
            int qtdCarta = Convert.ToInt32(cartaAdicionar.SubItems[2].Text);
            int numCartas = Convert.ToInt32(lblNCartasNoBaralho.Text);
            Boolean cartanova = true;

            lvListaCartas.SelectedItems[0].SubItems[2].Text = Convert.ToString(--qtdCarta);

            //---------------------------------------------------

            foreach (ListViewItem item in lvCartasBaralho.Items)
            {
                if (item.Text.Equals(cartaAdicionar.Text))
                {
                    item.SubItems[2].Text = Convert.ToString(3 - qtdCarta);
                    cartanova = false;
                }
            }

            if (cartanova)
            {
                ListViewItem novacarta = new ListViewItem(cartaAdicionar.Text);
                novacarta.SubItems.Add(cartaAdicionar.SubItems[1].Text);
                novacarta.SubItems.Add("1");

                lvCartasBaralho.Items.Add(novacarta);
            }

            //---------------------------------------------------

            if (qtdCarta == 0)
            {
                lvListaCartas.Items.Remove(cartaAdicionar);
            }

            //--------------------------------------------------

            lblNCartasNoBaralho.Text = Convert.ToString(++numCartas);

            if (numCartas == 45)
            {
                btnAdicionarCartaBaralho.Enabled = false;
            }

        }

        /// <summary>
        /// Obtem os dados da carta selecionada
        /// Verifica se a carta selecionada já existe na Lista de cartas
        ///     Se sim, incrementa a quantidade
        ///     Se não, adiciona
        /// Decrementa a quantidade da carta na lista de cartas no baralho
        /// Remove carta selecionada da listview se a quantidade for zero
        /// </summary>
        private void btnRemoverCartaBaralho_Click(object sender, EventArgs e)
        {
            ListViewItem cartaRemover = lvCartasBaralho.SelectedItems[0];
            int qtdCarta = Convert.ToInt32(cartaRemover.SubItems[2].Text);
            int numCartas = Convert.ToInt32(lblNCartasNoBaralho.Text);
            Boolean cartanova = true;

            lvCartasBaralho.SelectedItems[0].SubItems[2].Text = Convert.ToString(--qtdCarta);

            //---------------------------------------------------

            foreach (ListViewItem item in lvListaCartas.Items)
            {
                if (item.Text.Equals(cartaRemover.Text))
                {
                    item.SubItems[2].Text = Convert.ToString(3 - qtdCarta);
                    cartanova = false;
                }
            }

            if (cartanova)
            {
                ListViewItem novacarta = new ListViewItem(cartaRemover.Text);
                novacarta.SubItems.Add(cartaRemover.SubItems[1].Text);
                novacarta.SubItems.Add("1");

                lvListaCartas.Items.Add(novacarta);
            }

            //---------------------------------------------------

            if (qtdCarta == 0)
            {
                lvCartasBaralho.Items.Remove(cartaRemover);
            }

            //--------------------------------------------------

            lblNCartasNoBaralho.Text = Convert.ToString(--numCartas);
        }

        /// <summary>
        /// Chama a função que limpa os dados da gestão de baralhos
        /// </summary>
        private void btnCancelarAltBaralho_Click(object sender, EventArgs e)
        {
            RefreshGestaoBaralho();
        }

        /// <summary>
        /// Remova as cartas associadas ao baralho em gestão
        /// Adiciona a nova lista de cartas ao baralho em gestão
        /// </summary>
        private void btnGuardarAltBaralho_Click(object sender, EventArgs e)
        {
            Card carta;
            DeckCards cartaBaralho;
            int qtdcarta;

            //Limpar cartas antigas

            var idCartasAntigas =
                from bc in containerDados.DeckCardsSet
                where bc.DeckId == idBaralho
                select bc;

            containerDados.DeckCardsSet.RemoveRange(idCartasAntigas.ToList<DeckCards>());
            //--------------------------------

            foreach (ListViewItem item in lvCartasBaralho.Items)
            {
                qtdcarta = Convert.ToInt32(item.SubItems[2].Text);

                var search = containerDados.CardSet.Where(f => f.Name.Equals(item.Text));
                carta = search.ToList<Card>().First<Card>();

                cartaBaralho = new DeckCards();
                cartaBaralho.DeckId = idBaralho;
                cartaBaralho.CardId = carta.Id;
                cartaBaralho.Qtd = qtdcarta;

                containerDados.DeckCardsSet.Add(cartaBaralho);
            }

            containerDados.SaveChanges();

            RefreshGestaoBaralho();
        }

        /// <summary>
        /// Limpa todos os campos e prepara a área de gestão de cartas
        /// para novo uso
        /// </summary>
        private void RefreshGestaoBaralho()
        {
            lvCartasBaralho.Items.Clear();
            lvListaCartas.Items.Clear();
            lblNCartasNoBaralho.Text = "0";
            btnAdicionarCartaBaralho.Enabled = false;
            btnRemoverCartaBaralho.Enabled = false;
            panelGestaoBaralho.Enabled = false;
        }


        #endregion

        #region Pesquisa de Cartas

        /// <summary>
        /// Guarda os valores dos campos de pesquisa em variáveis
        /// Cria uma query (Linq) que seleciona as cartas com base nos campos de pesquisa
        /// Atribui a lista de resultados á DataGridView dgvVCartasLista
        /// </summary>
        private void pesquisaCartas(object sender, EventArgs e)
        {
            string nome = txtVNomeCarta.Text.Trim();

            string facao = "";
            if (cmbVFacaoCarta.SelectedIndex != -1)
            {
                facao = cmbVFacaoCarta.SelectedItem.ToString();
            }

            string tipo = "";
            if (cmbVTipoCarta.SelectedIndex != -1)
            {
                tipo = cmbVTipoCarta.SelectedItem.ToString();
            }

            string custo = txtVCustoCarta.Text.Trim();

            int lealdade = (int)nudVLealdadeCarta.Value;
            int ataque = (int)nudVAtaqueCarta.Value;
            int defesa = (int)nudVDefesaCarta.Value;

            //----------------------------------------

            IQueryable<Card> query = containerDados.CardSet;

            if (nome.Length > 0)
            {
                query = query.Where(card => card.Name.Contains(nome));
            }

            if (facao.Length > 0)
            {
                query = query.Where(card => card.Faction.Equals(facao));
            }

            if (tipo.Length > 0)
            {
                query = query.Where(card => card.Type.Equals(tipo));
            }

            if (custo.Length > 0)
            {
                query = query.Where(card => card.Cost.Equals(custo));
            }

            query = query.Where(card => card.Loyalty >= lealdade);
            query = query.Where(card => card.Attack >= ataque);
            query = query.Where(card => card.Defense >= defesa);

            dgvVCartasLista.DataSource = query.ToList();
        }

        /// <summary>
        /// Atribui á DataGridView dgvVCartasLista a lista de cartas original
        /// Limpa os valores dos campos de pesquisa
        /// </summary>
        private void btnVLimparCartas_Click(object sender, EventArgs e)
        {
            dgvVCartasLista.DataSource = cardSetBindingSource;

            txtVNomeCarta.ResetText();
            cmbVFacaoCarta.SelectedIndex = -1;
            cmbVTipoCarta.SelectedIndex = -1;
            txtVCustoCarta.ResetText();
            nudVLealdadeCarta.Value = 0;
            nudVAtaqueCarta.Value = 0;
            nudVDefesaCarta.Value = 0;
        }

        #endregion

        #region Pesquisa de Baralhos

        /// <summary>
        /// Obtém os dados necessários dos campos de pesquisa e guarda-os em variáveis
        /// Cria uma query (Linq) que
        ///     relaciona as chaves primárias das entidades CardSet, DeckSet e DeckCardsSet
        ///     seleciona os baralho no DeckSet que correspondam aos filtros existentes
        /// Atribui a lista de resultados á DataGridView dgvVBaralhosLista
        /// </summary>
        private void pesquisaBaralhos(object sender, EventArgs e)
        {
            string nome = txtVNomeBaralho.Text.Trim();

            string cartaNome = "";

            if (cmbVCartasnoBaralho.SelectedIndex != -1)
            {
                cartaNome = cmbVCartasnoBaralho.SelectedItem.ToString();
            }

            //------------------------------------------------------

            IQueryable<Deck> query =
                from baralho in containerDados.DeckSet
                join cartabaralho in containerDados.DeckCardsSet on baralho.Id equals cartabaralho.DeckId
                join carta in containerDados.CardSet on cartabaralho.CardId equals carta.Id
                where carta.Name.Contains(cartaNome) && baralho.Name.Contains(nome)
                select baralho;

            dgvVBaralhosLista.DataSource = query.Distinct().ToList();

        }

        /// <summary>
        /// Limpa os dados da combobox com a lista de cartas
        /// Adiciona as cartas á combobox para uso futuro
        /// </summary>
        private void tbVerBaralhos_Enter(object sender, EventArgs e)
        {
            cmbVCartasnoBaralho.Items.Clear();

            foreach (Card carta in containerDados.CardSet)
            {
                cmbVCartasnoBaralho.Items.Add(carta.Name);
            }

        }

        /// <summary>
        /// Atribui á DataGridView dgvVBaralhosLista a lista de baralhos original 
        /// Limpa os campos do formulário para novo uso
        /// </summary>
        private void btnVLimparBaralhos_Click(object sender, EventArgs e)
        {
            dgvVBaralhosLista.DataSource = deckSetBindingSource;

            txtVNomeBaralho.ResetText();
            cmbVCartasnoBaralho.SelectedIndex = -1;
        }

        #endregion

        #region Gestão de Jogadores

        private void btnInserirJogador_Click(object sender, EventArgs e)
        {
            //Ativa o group box dos jogadores.
            gbGJogadoresForm.Enabled = true;
            gbGJogadoresForm.Visible = true;
            //muda o nome do botão para criar.
            btnJogadoresAcao.Text = "Criar";
        }

        private void btnAlterarJogador_Click(object sender, EventArgs e)
        {
            carregarCancelarJogadores();
            gbGJogadoresForm.Visible = true;
            btnJogadoresAcao.Text = "Guardar";

            if (dgvGListaJogadores.SelectedCells.Count > 0)
            {
                gbGJogadoresForm.Enabled = true;
                idJogador = (int)dgvGListaJogadores.CurrentRow.Cells[0].Value;

                foreach (Player player in containerDados.PlayerSet.OfType<Player>())
                {
                    if (player.Id == idJogador)
                    {
                        txtNomeJogador.Text = player.Name;
                        txtEmailJogador.Text = player.Email;
                        txtNickJogador.Text = player.Nickname;
                        nudIdadeJogador.Value = (int)player.Age;
                        txtAvatar.Text = player.Avatar;

                        if (File.Exists(player.Avatar))
                        {
                            using (Bitmap imagemAvatar = new Bitmap(player.Avatar))
                            {
                                Image avatarJogador = new Bitmap(imagemAvatar);
                                pictureBox1.Image = avatarJogador;
                            }
                        }
                    }
                }
            }
        }

        private void btnRemoverJogador_Click(object sender, EventArgs e)
        {
            if (dgvGListaJogadores.SelectedCells.Count > 0)
            {
                idJogador = (int)dgvGListaJogadores.CurrentRow.Cells[0].Value;
                string nome = dgvGListaJogadores.CurrentRow.Cells[1].Value.ToString();

                DialogResult confirmar = MessageBox.Show("Deseja eliminar o jogador com o nome " + nome + "?", "Eliminar dados", MessageBoxButtons.YesNo);

                if (confirmar == DialogResult.Yes)
                {
                    removerJogador();
                    atualizarTabelaJogadores();
                }
            }
        }

        private void btnJogadoresAcao_Click(object sender, EventArgs e)
        {
            //recolher os dados referentes aos jogadores
            string nome = txtNomeJogador.Text.Trim();
            string email = txtEmailJogador.Text.Trim();
            string nickname = txtNickJogador.Text.Trim();
            int idade = (int)nudIdadeJogador.Value;
            string caminhoAbsoluto = txtAvatar.Text.Trim();
            string caminhoRelative = GetPathRelativeImagem(caminhoAbsoluto, nome, "/jogadores/avatars");

            //validar se estão preenchidos
            if (nome.Length == 0 || email.Length == 0 || nickname.Length == 0 || idade == 0 || caminhoAbsoluto.Length == 0)
            {
                if (nome.Length == 0 && email.Length == 0 && nickname.Length == 0 && idade == 0 && caminhoAbsoluto.Length == 0)
                {
                    MessageBox.Show("Preencha todos os dados", "Preenchimento de dados");
                }
                else
                {
                    MessageBox.Show("Preencha os campos em branco", "Preenchimento de dados");
                }
            }
            else
            {
                //significa que todos os dados estão preenchidos e válidos.


                if (btnJogadoresAcao.Text == "Criar")
                {
                    //cria um novo.
                    //verificar se o jogador com esse nome já existe.
                    if (verificarNomeNickname(nome, email, nickname) == false)
                    {
                        inserirNovoJogador(nome, email, nickname, idade, caminhoAbsoluto, caminhoRelative);
                        atualizarTabelaJogadores();
                    }
                }
                else if (btnJogadoresAcao.Text == "Guardar")
                {
                    //alterar o jogador
                    //verificar se o jogador com esse nome já existe.

                    if (verificarNomeNickname(nome, email, nickname) == false)
                    {
                        alterarJogadorExistente(nome, email, nickname, idade, caminhoAbsoluto, caminhoRelative);
                        atualizarTabelaJogadores();
                    }
                }

                gbGJogadoresForm.Enabled = false;
                gbGJogadoresForm.Visible = false;
            }
        }

        private void btnJogadoresCancelar_Click(object sender, EventArgs e)
        {
            carregarCancelarJogadores();
        }

        private void btImagem_Click(object sender, EventArgs e)
        {
            //filtra e só deixa selecionar imagens
            opfProcurarImagem.Title = "Selecione uma imagem";
            opfProcurarImagem.Filter = "Image Files (JPG, JPEG,PNG)|*.JPG;*.JPEG;*.PNG";
            opfProcurarImagem.FileName = null;

            if (opfProcurarImagem.ShowDialog() == DialogResult.OK)
            {
                //caminho da imagem para guardar no ado.
                string caminho = opfProcurarImagem.FileName;

                using (Bitmap imagemAvatar = new Bitmap(caminho))
                {
                    if (imagemAvatar.Width <= 128 && imagemAvatar.Height <= 128)
                    {
                        Image avatar = new Bitmap(imagemAvatar);
                        //coloca a imagem na picture box.
                        pictureBox1.Image = avatar;
                        txtAvatar.Text = caminho;
                    }

                    else
                    {
                        MessageBox.Show("Tem de escolher um avatar de dimensão igual ou inferior a 128x128.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtGJogadoresPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvGListaJogadores_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvGListaJogadores.RowCount > 0 && dgvGListaJogadores.SelectedCells.Count > 0)
            {
                btnAlterarJogador.Enabled = true;
                btnRemoverJogador.Enabled = true;
            }
        }

        private void inserirNovoJogador(string nome, string email, string nickname, int idade, string caminhoAbsoluto, string caminhoRelativo)
        {
            try
            {
                Player jogador = new Player
                {
                    Name = nome,
                    Email = email,
                    Nickname = nickname,
                    Age = idade,
                    Avatar = caminhoRelativo
                };

                GuardarImagem(caminhoRelativo, caminhoAbsoluto);

                containerDados.PlayerSet.Add(jogador);
                containerDados.SaveChanges();
            }

            catch (Exception)
            {
                MessageBox.Show("O jogador não foi inserido.", "Registo de Jogadores");
            }
        }

        private void alterarJogadorExistente(string nome, string email, string nickname, int idade, string caminhoAbsoluto, string caminhoRelativo)
        {
            try
            {
                Player jogador = containerDados.PlayerSet.Find(idJogador);

                jogador.Name = nome;
                jogador.Email = email;
                jogador.Nickname = nickname;
                jogador.Age = idade;
                jogador.Avatar = caminhoRelativo;

                GuardarImagem(caminhoRelativo, caminhoAbsoluto);

                containerDados.Entry(jogador).State = EntityState.Modified;
                containerDados.SaveChanges();
            }

            catch (Exception)
            {
                MessageBox.Show("O jogador não foi alterado.", "Registo de Jogadores");
            }
        }

        private void removerJogador()
        {
            try
            {
                Player jogador = containerDados.PlayerSet.Find(idJogador);

                if (File.Exists(jogador.Avatar))
                {
                    File.Delete(jogador.Avatar);
                }

                containerDados.PlayerSet.Remove(jogador);
                containerDados.SaveChanges();
            }

            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                MessageBox.Show("Não é possível eliminar um jogador que está associado a uma equipa. Erro:" + ex.Message, "Eliminar dados");
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao eliminar o jogador.", "Eliminar dados");
            }
        }

        private void carregarCancelarJogadores()
        {
            txtNomeJogador.ResetText();
            txtEmailJogador.ResetText();
            txtNickJogador.ResetText();
            nudIdadeJogador.Value = 0;
            txtAvatar.ResetText();
            pictureBox1.Image = null;

            btnJogadoresAcao.Text = "Acção";

            gbGJogadoresForm.Enabled = false;
            gbGJogadoresForm.Visible = false;

            btnAlterarJogador.Enabled = false;
            btnRemoverJogador.Enabled = false;
        }

        private void atualizarTabelaJogadores()
        {
            dgvGListaJogadores.DataSource = null;
            this.playerSetTableAdapter.Fill(this.bD_DA_ProjetoDataSet_Players.PlayerSet);
            dgvGListaJogadores.DataSource = this.playerSetBindingSource;

            int i = dgvGListaJogadores.Rows.Count;

            dgvGListaJogadores.CurrentCell = dgvGListaJogadores.Rows[i - 1].Cells[0];
        }

        private Boolean verificarNomeNickname(string nome, string email, string nickname)
        {
            Boolean existe = false;
            foreach (Player player in containerDados.PlayerSet.OfType<Player>())
            {

                if (btnJogadoresAcao.Text.Equals("Criar"))
                {
                    if (nome.Equals(player.Name) || email.Equals(player.Email) || nickname.Equals(player.Nickname))
                    {
                        existe = true;
                        enviarMensagemRepeticaoDados(player, nome, email, nickname);
                    }
                }

                if (btnJogadoresAcao.Text.Equals("Guardar"))
                {
                    if (player.Id != idJogador)
                    {
                        if (nome.Equals(player.Name) || nickname.Equals(player.Nickname))
                        {
                            existe = true;
                            enviarMensagemRepeticaoDados(player, nome, email, nickname);
                        }
                    }
                }

            }
            return existe;
        }

        private void enviarMensagemRepeticaoDados(Player player, string nome, string email, string nickname)
        {
            if (nome.Equals(player.Name))
            {
                MessageBox.Show("O nome tem de ser único.");
            }
            else if (email.Equals(player.Email))
            {
                MessageBox.Show("O email tem de ser único.");
            }
            else if (nickname.Equals(player.Nickname))
            {
                MessageBox.Show("O nickname tem de ser único.");
            }
        }

        #endregion

        #region Pesquisa de Jogadores

        private void pesquisarJogadores(object sender, EventArgs e)
        {
            string nome = txtNomeJogador2.Text;
            string email = txtEmailJogador2.Text;
            string nickname = txtNicknameJogador2.Text;
            int idade = (int)nudIdadeJogador2.Value;

            IQueryable<Player> query = containerDados.PlayerSet;

            if (nome.Length > 0)
            {
                query = query.Where(player => player.Name.Contains(nome));
            }

            if (email.Length > 0)
            {
                query = query.Where(player => player.Email.Contains(email));
            }

            if (nickname.Length > 0)
            {
                query = query.Where(player => player.Nickname.Contains(nickname));
            }
            if (idade != 0)
            {
                query = query.Where(player => player.Age == idade);
            }

            dgvGListaJogadoresPesquisa.DataSource = query.ToList();
        }

        private void atualizarTabelaJogadoresPesquisa()
        {
            dgvGListaJogadoresPesquisa.DataSource = null;
            this.playerSetTableAdapter.Fill(this.bD_DA_ProjetoDataSet_Players.PlayerSet);
            dgvGListaJogadoresPesquisa.DataSource = this.playerSetBindingSource;

            int i = dgvGListaJogadoresPesquisa.Rows.Count;

            dgvGListaJogadoresPesquisa.CurrentCell = dgvGListaJogadoresPesquisa.Rows[i - 1].Cells[0];
        }

        #endregion

        #region Gestão de Equipas

        private void btnInserirEquipa_Click(object sender, EventArgs e)
        {
            gbGEquipasForm.Enabled = true;
            gbGEquipasForm.Visible = true;
            btnEquipaAcao.Text = "Criar";
        }

        private void btnAlterarEquipa_Click(object sender, EventArgs e)
        {
            carregarCancelarEquipas();
            gbGEquipasForm.Visible = true;
            btnEquipaAcao.Text = "Guardar";

            if (dgvGListaEquipas.SelectedCells.Count > 0)
            {
                gbGEquipasForm.Enabled = true;
                idEquipa = (int)dgvGListaEquipas.CurrentRow.Cells[0].Value;

                foreach (Team team in containerDados.TeamSet.OfType<Team>())
                {
                    if (team.Id == idEquipa)
                    {
                        txtGNomeEquipa.Text = team.Name;
                        txtGAvatarEquipa.Text = team.Avatar;

                        if (File.Exists(team.Avatar))
                        {
                            using (Bitmap imagemAvatar = new Bitmap(team.Avatar))
                            {
                                Image avatarEquipa = new Bitmap(imagemAvatar);
                                pictureBoxAvatarEquipa.Image = avatarEquipa;
                            }
                        }
                    }
                }
            }
        }

        private void btnRemoverEquipa_Click(object sender, EventArgs e)
        {
            if (dgvGListaEquipas.SelectedCells.Count > 0)
            {
                idEquipa = (int)dgvGListaEquipas.CurrentRow.Cells[0].Value;
                string nome = dgvGListaEquipas.CurrentRow.Cells[1].Value.ToString();

                DialogResult confirmar = MessageBox.Show("Deseja eliminar a equipa com o nome " + nome + "?", "Eliminar dados", MessageBoxButtons.YesNo);

                if (confirmar == DialogResult.Yes)
                {
                    removerEquipa();
                    atualizarTabelaEquipas();
                }
            }
        }

        private void btnEquipaAcao_Click(object sender, EventArgs e)
        {
            string nome = txtGNomeEquipa.Text.Trim();
            string caminhoAbsoluto = txtGAvatarEquipa.Text.Trim();
            string caminhoRelative = GetPathRelativeImagem(caminhoAbsoluto, nome, "/equipas/avatars");

            if (nome.Equals("") || caminhoAbsoluto.Equals(""))
            {
                MessageBox.Show("Preencha os dados.", "Preenchimento de dados");
            }
            else
            {
                if (verificarNomeEquipa(nome) == false)
                {
                    if (btnEquipaAcao.Text.Equals("Criar"))
                    {
                        inserirNovaEquipa(nome, caminhoAbsoluto, caminhoRelative);
                        atualizarTabelaEquipas();
                    }

                    else if (btnEquipaAcao.Text == "Guardar")
                    {
                        alterarEquipaExistente(nome, caminhoAbsoluto, caminhoRelative);
                        atualizarTabelaEquipas();
                    }
                }

                gbGEquipasForm.Enabled = false;
                gbGEquipasForm.Visible = false;
            }
        }

        private void btnEquipaCancelar_Click(object sender, EventArgs e)
        {
            carregarCancelarEquipas();
        }

        private void btnAvatarEquipa_Click(object sender, EventArgs e)
        {
            //filtra e só deixa selecionar imagens
            opfProcurarImagem.Title = "Selecione uma imagem";
            opfProcurarImagem.Filter = "Image Files (JPG, JPEG,PNG)|*.JPG;*.JPEG;*.PNG";
            opfProcurarImagem.FileName = null;

            if (opfProcurarImagem.ShowDialog() == DialogResult.OK)
            {
                //caminho da imagem para guardar no ado.
                string caminho = opfProcurarImagem.FileName;

                using (Bitmap imagemAvatar = new Bitmap(caminho))
                {
                    if (imagemAvatar.Width <= 128 && imagemAvatar.Height <= 128)
                    {
                        Image avatar = new Bitmap(imagemAvatar);
                        //coloca a imagem na picture box.
                        pictureBoxAvatarEquipa.Image = avatar;
                        txtGAvatarEquipa.Text = caminho;
                    }

                    else
                    {
                        MessageBox.Show("Tem de escolher um avatar de dimensão igual ou inferior a 128x128.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvGListaEquipas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvGListaEquipas.RowCount > 0 && dgvGListaEquipas.SelectedCells.Count > 0)
            {
                btnGerirEquipa.Enabled = true;
                btnAlterarEquipa.Enabled = true;
                btnRemoverEquipa.Enabled = true;
            }
        }

        private void txtGEquipasPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtGEquipasPesquisa.Text.Length > 0)
            {
                var query = from team in containerDados.TeamSet
                            where team.Name.Contains(txtGEquipasPesquisa.Text)
                            select team;

                dgvGListaEquipas.DataSource = query.ToList();
            }

            else
            {
                atualizarTabelaEquipas();
            }
        }

        private void inserirNovaEquipa(string nome, string caminhoAbsoluto, string caminhoRelative)
        {
            try
            {
                Team equipa = new Team
                {
                    Name = nome,
                    Avatar = caminhoRelative
                };

                GuardarImagem(caminhoRelative, caminhoAbsoluto);

                containerDados.TeamSet.Add(equipa);
                containerDados.SaveChanges();
            }

            catch (Exception)
            {
                MessageBox.Show("A equipa não foi inserida.", "Registo de Equipas");
            }
        }

        private void alterarEquipaExistente(string nome, string caminhoAbsoluto, string caminhoRelative)
        {
            Team equipa;

            equipa = containerDados.TeamSet.Find(idEquipa);

            equipa.Name = nome;
            equipa.Avatar = caminhoRelative;

            GuardarImagem(caminhoRelative, caminhoAbsoluto);

            containerDados.Entry(equipa).State = EntityState.Modified;
            containerDados.SaveChanges();
        }

        private void removerEquipa()
        {
            try
            {
                foreach (Team equipa in containerDados.TeamSet)
                {
                    if (equipa.Id == idEquipa)
                    {
                        if (File.Exists(equipa.Avatar))
                        {
                            File.Delete(equipa.Avatar);
                        }

                        containerDados.TeamSet.Remove(equipa);
                    }
                }
                containerDados.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao eliminar a equipa.", "Eliminar dados");
            }
        }

        private void atualizarTabelaEquipas()
        {
            dgvGListaEquipas.DataSource = null;
            this.teamSetTableAdapter.Fill(this.bD_DA_ProjetoDataSet_Teams.TeamSet);
            dgvGListaEquipas.DataSource = this.teamSetBindingSource;

            int i = dgvGListaEquipas.Rows.Count;

            dgvGListaEquipas.CurrentCell = dgvGListaEquipas.Rows[i - 1].Cells[0];
        }

        private void carregarCancelarEquipas()
        {
            txtGNomeEquipa.ResetText();
            txtGAvatarEquipa.ResetText();
            pictureBoxAvatarEquipa.Image = null;

            btnEquipaAcao.Text = "Acção";

            gbGEquipasForm.Enabled = false;
            gbGEquipasForm.Visible = false;

            btnAlterarEquipa.Enabled = false;
            btnRemoverEquipa.Enabled = false;
        }

        private Boolean verificarNomeEquipa(string nome)
        {
            Boolean existe = false;
            foreach (Team team in containerDados.TeamSet.OfType<Team>())
            {
                if (btnEquipaAcao.Text.Equals("Criar"))
                {
                    if (nome.Equals(team.Name))
                    {
                        existe = true;
                        MessageBox.Show("O nome tem de ser único.");
                    }
                }

                if (btnEquipaAcao.Text.Equals("Guardar"))
                {
                    if (team.Id != idEquipa)
                    {
                        if (nome.Equals(team.Name))
                        {
                            existe = true;
                            MessageBox.Show("O nome tem de ser único.");
                        }
                    }
                }

            }
            return existe;
        }

        #endregion

        #region Associamento de Jogadores a Equipas

        private void btnGerirEquipa_Click(object sender, EventArgs e)
        {
            idEquipa = (int)dgvGListaEquipas.CurrentRow.Cells[0].Value;

            ListViewItem linhaJogadoresEquipa;
            ListViewItem linhaListaJogadores;

            lcListaJogadores.Items.Clear();
            lvJogadoresEquipa.Items.Clear();

            foreach (Player jogador in containerDados.PlayerSet)
            {
                foreach (TeamPlayers equipasjogadores in containerDados.TeamPlayersSet.Where(tp => tp.TeamId.Equals(idEquipa)))
                {
                    if (equipasjogadores.PlayerId == jogador.Id)
                    {
                        linhaJogadoresEquipa = new ListViewItem(jogador.Name);
                        linhaJogadoresEquipa.SubItems.Add(jogador.Email);
                        linhaJogadoresEquipa.SubItems.Add(jogador.Age.ToString());
                        linhaJogadoresEquipa.SubItems.Add(jogador.Nickname);

                        lvJogadoresEquipa.Items.Add(linhaJogadoresEquipa);

                    }
                }
            }

            foreach (Player jogador in containerDados.PlayerSet)
            {
                Boolean temEquipa = false;

                foreach (TeamPlayers equipasjogadores in containerDados.TeamPlayersSet)
                {
                    if (equipasjogadores.PlayerId == jogador.Id)
                    {
                        temEquipa = true;
                    }
                }

                if (temEquipa == false)
                {
                    linhaListaJogadores = new ListViewItem(jogador.Name);
                    linhaListaJogadores.SubItems.Add(jogador.Email);
                    linhaListaJogadores.SubItems.Add(jogador.Age.ToString());
                    linhaListaJogadores.SubItems.Add(jogador.Nickname);
                    lcListaJogadores.Items.Add(linhaListaJogadores);
                }
            }

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            btnAdicionarJogador.Enabled = true;
            btnRetirarJogador.Enabled = true;
            btnGuardarJogadorEquipa.Enabled = true;
        }

        private void btnAdicionarJogador_Click(object sender, EventArgs e)
        {
            if (lcListaJogadores.SelectedItems.Count > 0)
            {
                ListViewItem jogador = lcListaJogadores.SelectedItems[0];
                lcListaJogadores.Items.Remove(jogador);
                lvJogadoresEquipa.Items.Add(jogador);
            }
            int nrjogadores = lvJogadoresEquipa.Items.Count;

            if (nrjogadores < 2)
            {
                btnAdicionarJogador.Enabled = true;
                btnRetirarJogador.Enabled = true;
                btnGuardarJogadorEquipa.Enabled = false;

            }
            else
            {
                btnAdicionarJogador.Enabled = false;
                btnRetirarJogador.Enabled = true;
                btnGuardarJogadorEquipa.Enabled = true;
            }
        }

        private void btnGuardarJogadorEquipa_Click(object sender, EventArgs e)
        {
            Player jogador;
            TeamPlayers equipajogadores;

            containerDados.TeamPlayersSet.Where(tp => tp.TeamId == idEquipa)
                .ToList().ForEach(tp => containerDados.TeamPlayersSet.Remove(tp));
            containerDados.SaveChanges();

            foreach (ListViewItem item in lvJogadoresEquipa.Items)
            {
                var pesquisa = containerDados.PlayerSet.Where(p => p.Name.Equals(item.Text));
                jogador = pesquisa.ToList().First<Player>();

                equipajogadores = new TeamPlayers();
                equipajogadores.TeamId = idEquipa;
                equipajogadores.PlayerId = jogador.Id;

                containerDados.TeamPlayersSet.Add(equipajogadores);
            }

            containerDados.SaveChanges();
            ResetListViewsEquipas();
        }

        private void btnRetirarJogador_Click(object sender, EventArgs e)
        {
            if (lvJogadoresEquipa.SelectedItems.Count > 0)
            {
                ListViewItem jogador = lvJogadoresEquipa.SelectedItems[0];
                lvJogadoresEquipa.Items.Remove(jogador);
                lcListaJogadores.Items.Add(jogador);
            }

            int nrjogadoresequipa = lvJogadoresEquipa.Items.Count;

            if (nrjogadoresequipa == 0)
            {
                btnRetirarJogador.Enabled = false;
            }
            else
            {
                btnRetirarJogador.Enabled = true;

                if (nrjogadoresequipa < 2)
                {
                    btnGuardarJogadorEquipa.Enabled = false;
                    btnAdicionarJogador.Enabled = true;
                }
            }
        }

        private void ResetListViewsEquipas()
        {
            lcListaJogadores.Items.Clear();
            lvJogadoresEquipa.Items.Clear();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            btnAdicionarJogador.Enabled = false;
            btnRetirarJogador.Enabled = false;
            btnGuardarJogadorEquipa.Enabled = false;
        }

        #endregion

        #region Pesquisa de Equipas

        private void tbVerEquipas_Enter(object sender, EventArgs e)
        {
            cbnomejogadorpesquisa.Items.Clear();


            foreach (Player jogador in containerDados.PlayerSet)
            {
                cbnomejogadorpesquisa.Items.Add(jogador.Name);
            }
        }

        private void pesquisarEquipas(object sender, EventArgs e)
        {
            string nomeequipa = tbxnomeequipapesquisa.Text;

            string nomejogador = "";

            if (cbnomejogadorpesquisa.SelectedIndex != -1)
            {
                nomejogador = cbnomejogadorpesquisa.SelectedItem.ToString();
            }


            if (!nomeequipa.Equals("") && cbnomejogadorpesquisa.SelectedIndex != -1)
            {
                var query =
                    from equipa in containerDados.TeamSet
                    join equipajogadores in containerDados.TeamPlayersSet on equipa.Id equals equipajogadores.TeamId
                    join jogador in containerDados.PlayerSet on equipajogadores.PlayerId equals jogador.Id
                    where jogador.Name.Equals(nomejogador) && equipa.Name.Contains(nomeequipa)
                    select equipa;

                dgvGListaEquipasPesquisa.DataSource = query.ToList();
            }
            else
            {
                if (!nomeequipa.Equals(""))
                {
                    var query =
                        from equipa in containerDados.TeamSet
                        where equipa.Name.Contains(nomeequipa)
                        select equipa;

                    dgvGListaEquipasPesquisa.DataSource = query.ToList();
                }
                if (cbnomejogadorpesquisa.SelectedIndex != -1)
                {
                    var query =
                    from equipa in containerDados.TeamSet
                    join equipajogadores in containerDados.TeamPlayersSet on equipa.Id equals equipajogadores.TeamId
                    join jogador in containerDados.PlayerSet on equipajogadores.PlayerId equals jogador.Id
                    where jogador.Name.Equals(nomejogador)
                    select equipa;

                    dgvGListaEquipasPesquisa.DataSource = query.ToList();
                }
            }

        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            tbxnomeequipapesquisa.ResetText();
            cbnomejogadorpesquisa.SelectedIndex = -1;
            dgvGListaEquipasPesquisa.DataSource = teamSetBindingSource;
        }

        private void limparTabelaPesquisas()
        {
            dgvGListaEquipasPesquisa.DataSource = teamSetBindingSource;

            tbxnomeequipapesquisa.ResetText();
            cbnomejogadorpesquisa.SelectedIndex = -1;
        }

        #endregion

        #region Gestão de Jogos

        private void btngerirjogos_Click(object sender, EventArgs e)
        {
            gbGJogosDados.Enabled = true;
            carregarArbitrosJogos();
            carregarDecks();
            if (dgvGTorneiosLista.SelectedRows.Count > 0)
            {
                idTorneio = (int)dgvGTorneiosLista.CurrentRow.Cells[0].Value;

                if (radioStandardTournaments.Checked == true)
                {
                    carregarJogadoresJogos();
                    groupBoxEquipasJogos.Text = "Jogadores";

                }

                else if (radioTeamTournaments.Checked == true)
                {
                    carregarEquipasJogos();
                    groupBoxEquipasJogos.Text = "Equipas";
                }

                gbGTorneiosDados.Enabled = false;

                refreshTabelaJogos();
            }
        }

        private void btnCancelarJogo_Click(object sender, EventArgs e)
        {
            cancelarJogo();
            dgvGJogosLista.DataSource = null;
            gbGJogosForm.Visible = false;
            gbGJogosForm.Enabled = false;
            gbGJogosDados.Enabled = false;
            gbGTorneiosDados.Enabled = true;
        }

        private void btnInserirJogo_Click(object sender, EventArgs e)
        {
            gbGJogosForm.Visible = true;
            gbGTorneiosForm.Visible = false;
            btnJogoAcao.Text = "Criar";
            gbGJogosForm.Enabled = true;

            if (radioTeamTournaments.Checked == true)
            {
                //carregar dados das equipas
                carregarEquipas();
            }
            else if (radioStandardTournaments.Checked == true)
            {
                //carregar dados dos jogadores
                carregarJogadoresJogos();
            }
        }

        private void btnAlterarJogo_Click(object sender, EventArgs e)
        {
            gbGJogosForm.Enabled = true;
            gbGJogosForm.Visible = true;
            btnJogoAcao.Text = "Guardar";

            if (dgvGJogosLista.SelectedCells.Count > 0)
            {
                idJogo = (int)dgvGJogosLista.CurrentRow.Cells[0].Value;

                if (radioTeamTournaments.Checked == true)
                {
                    foreach (TeamGame jogoequipa in containerDados.GameSet.OfType<TeamGame>())
                    {
                        if (jogoequipa.Id == idJogo)
                        {
                            tpDataJogos.Value = jogoequipa.Date;
                            nudNJogo.Value = jogoequipa.Number;
                            int nrarbitro = (int)jogoequipa.RefereeId;

                            string usernamearbitro = getUsernameArbitro(nrarbitro);
                            cmbarbitrojogos.SelectedItem = usernamearbitro;
                            int nrequipa1 = (int)jogoequipa.TeamId1;

                            string nomeequipa1 = getNomeEquipa(nrequipa1);
                            cmbequipajogador1.SelectedItem = nomeequipa1;
                            int nrequipa2 = (int)jogoequipa.TeamId2;

                            string nomeequipa2 = getNomeEquipa(nrequipa2);
                            cmbequipajogador2.SelectedItem = nomeequipa2;
                            int nrdeck1 = (int)jogoequipa.DeckId1;

                            string nomedeck1 = getNomeDeck(nrdeck1);
                            cmbdecks1.SelectedItem = nomedeck1;
                            int nrdeck2 = (int)jogoequipa.DeckId2;

                            string nomedeck2 = getNomeDeck(nrdeck2);
                            cmbdecks2.SelectedItem = nomedeck2;
                            txtDescricaoJogo.Text = jogoequipa.Description;
                        }
                    }
                }
                else if (radioStandardTournaments.Checked == true)
                {
                    foreach (StandardGame jogo in containerDados.GameSet.OfType<StandardGame>())
                    {
                        if (jogo.Id == idJogo)
                        {
                            tpDataJogos.Value = jogo.Date;
                            nudNJogo.Value = jogo.Number;
                            int nrarbitro = (int)jogo.RefereeId;

                            string usernamearbitro = getUsernameArbitro(nrarbitro);
                            cmbarbitrojogos.SelectedItem = usernamearbitro;
                            int nrjogador1 = (int)jogo.PlayerId1;

                            string nomejogador1 = getNomeJogador(nrjogador1);
                            cmbequipajogador1.SelectedItem = nomejogador1;
                            int nrjogador2 = (int)jogo.PlayerId2;

                            string nomejogador2 = getNomeJogador(nrjogador2);
                            cmbequipajogador2.SelectedItem = nomejogador2;
                            int nrdeck1 = (int)jogo.DeckId1;

                            string nomedeck1 = getNomeDeck(nrdeck1);
                            cmbdecks1.SelectedItem = nomedeck1;
                            int nrdeck2 = (int)jogo.DeckId2;

                            string nomedeck2 = getNomeDeck(nrdeck2);
                            cmbdecks2.SelectedItem = nomedeck2;
                            txtDescricaoJogo.Text = jogo.Description;
                        }
                    }
                }
            }
        }

        private void btnRemoverJogo_Click(object sender, EventArgs e)
        {
            gbGTorneiosForm.Visible = false;
            gbGJogosForm.Visible = true;

            if (dgvGJogosLista.SelectedCells.Count > 0)
            {
                idJogo = (int)dgvGJogosLista.CurrentRow.Cells[0].Value;

                DialogResult confirmar = MessageBox.Show("Deseja eliminar o jogador selecionado.", "Eliminação de dados", MessageBoxButtons.YesNo);

                if (confirmar == DialogResult.Yes)
                {
                    removerJogo();
                    refreshTabelaJogos();
                }
            }
            cancelarJogo();
            gbGJogosForm.Enabled = false;
        }

        private void btnJogoAcao_Click(object sender, EventArgs e)
        {
            if ((int)nudNJogo.Value == 0 || cmbarbitrojogos.SelectedIndex == -1 || cmbequipajogador1.SelectedIndex == -1 || cmbequipajogador2.SelectedIndex == -1 || cmbdecks1.SelectedIndex == -1 || cmbdecks2.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha os campos corretamente.", "Preenchimento de dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime data = tpDataJogos.Value;
                int nrjogo = (int)nudNJogo.Value;
                string usernamearbitro = cmbarbitrojogos.SelectedItem.ToString();
                string nomejogador1 = cmbequipajogador1.SelectedItem.ToString();
                string nomejogador2 = cmbequipajogador2.SelectedItem.ToString();
                string deck1 = cmbdecks1.SelectedItem.ToString();
                string deck2 = cmbdecks2.SelectedItem.ToString();
                string descricao = txtDescricaoJogo.Text;

                if (btnJogoAcao.Text.Equals("Criar"))
                {

                    if (radioStandardTournaments.Checked == true)
                    {
                        guardarStandardGame(data, nrjogo, usernamearbitro, nomejogador1, nomejogador2, deck1, deck2, descricao);
                    }
                    else if (radioTeamTournaments.Checked == true)
                    {
                        guardarTeamGame(data, nrjogo, usernamearbitro, nomejogador1, nomejogador2, deck1, deck2, descricao);
                    }
                }
                else if (btnJogoAcao.Text.Equals("Guardar"))
                {
                    if (radioStandardTournaments.Checked == true)
                    {
                        alterarStandardGame(data, nrjogo, usernamearbitro, nomejogador1, nomejogador2, deck1, deck2, descricao);
                    }
                    else if (radioTeamTournaments.Checked == true)
                    {
                        alterarTeamGame(data, nrjogo, usernamearbitro, nomejogador1, nomejogador2, deck1, deck2, descricao);
                    }
                }
                cancelarJogo();
                gbGJogosForm.Enabled = false;
            }
        }

        private void btnJogoCancelar_Click(object sender, EventArgs e)
        {
            cancelarJogo();
            gbGJogosForm.Visible = false;
            gbGJogosForm.Enabled = false;
        }

        private void guardarTeamGame(DateTime data, int nrjogo, string usernamearbitro, string nomeequipa1, string nomeequipa2, string deck1, string deck2, string descricao)
        {
            int idarbitro = getIdArbitro(usernamearbitro);
            int idequipa1 = getIdEquipa(nomeequipa1);
            int idequipa2 = getIdEquipa(nomeequipa2);
            int iddeck1 = getIdDeck(deck1);
            int iddeck2 = getIdDeck(deck2);

            try
            {
                TeamGame jogoequipa = new TeamGame
                {
                    Date = data,
                    Number = nrjogo,
                    RefereeId = idarbitro,
                    TeamId1 = idequipa1,
                    TeamId2 = idequipa2,
                    DeckId1 = iddeck1,
                    DeckId2 = iddeck2,
                    Description = descricao,
                    TeamTournamentId = idTorneio
                };
                containerDados.GameSet.Add(jogoequipa);
                containerDados.SaveChanges();
                refreshTabelaJogos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na inserção do jogo de jogadores." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardarStandardGame(DateTime data, int nrjogo, string usernamearbitro, string nomejogador1, string nomejogador2, string deck1, string deck2, string descricao)
        {

            int idarbitro = getIdArbitro(usernamearbitro);
            int idjogador1 = getIdJogador(nomejogador1);
            int idjogador2 = getIdJogador(nomejogador2);
            int iddeck1 = getIdDeck(deck1);
            int iddeck2 = getIdDeck(deck2);

            try
            {
                StandardGame jogo = new StandardGame
                {
                    Date = data,
                    Number = nrjogo,
                    RefereeId = idarbitro,
                    PlayerId1 = idjogador1,
                    PlayerId2 = idjogador2,
                    DeckId1 = iddeck1,
                    DeckId2 = iddeck2,
                    Description = descricao,
                    StandardTournamentId = idTorneio


                };
                containerDados.GameSet.Add(jogo);
                containerDados.SaveChanges();
                refreshTabelaJogos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na inserção do jogo de equipa." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alterarTeamGame(DateTime data, int nrjogo, string usernamearbitro, string nomeequipa1, string nomeequipa2, string deck1, string deck2, string descricao)
        {
            int idarbitro = getIdArbitro(usernamearbitro);
            int idequipa1 = getIdEquipa(nomeequipa1);
            int idequipa2 = getIdEquipa(nomeequipa2);
            int iddeck1 = getIdDeck(deck1);
            int iddeck2 = getIdDeck(deck2);

            idJogo = (int)dgvGJogosLista.CurrentRow.Cells[0].Value;

            TeamGame jogoequipa = (TeamGame)containerDados.GameSet.Find(idJogo);

            jogoequipa.Date = data;
            jogoequipa.Number = nrjogo;
            jogoequipa.RefereeId = idarbitro;
            jogoequipa.TeamId1 = idequipa1;
            jogoequipa.TeamId2 = idequipa2;
            jogoequipa.DeckId1 = iddeck1;
            jogoequipa.DeckId2 = iddeck2;
            jogoequipa.Description = descricao;

            containerDados.Entry(jogoequipa).State = EntityState.Modified;
            containerDados.SaveChanges();
            refreshTabelaJogos();
        }

        private void alterarStandardGame(DateTime data, int nrjogo, string usernamearbitro, string nomejogador1, string nomejogador2, string deck1, string deck2, string descricao)
        {
            int idarbitro = getIdArbitro(usernamearbitro);
            int idjogador1 = getIdJogador(nomejogador1);
            int idjogador2 = getIdJogador(nomejogador2);
            int iddeck1 = getIdDeck(deck1);
            int iddeck2 = getIdDeck(deck2);

            idJogo = (int)dgvGJogosLista.CurrentRow.Cells[0].Value;

            StandardGame jogo = (StandardGame)containerDados.GameSet.Find(idJogo);

            jogo.Date = data;
            jogo.Number = nrjogo;
            jogo.RefereeId = idarbitro;
            jogo.PlayerId1 = idjogador1;
            jogo.PlayerId2 = idjogador2;
            jogo.DeckId1 = iddeck1;
            jogo.DeckId2 = iddeck2;
            jogo.Description = descricao;

            containerDados.Entry(jogo).State = EntityState.Modified;
            containerDados.SaveChanges();
            refreshTabelaJogos();
        }

        private void removerJogo()
        {
            try
            {
                foreach (Game jogo in containerDados.GameSet)
                {
                    if (jogo.Id == idJogo)
                    {
                        containerDados.GameSet.Remove(jogo);
                    }
                }
                containerDados.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao eliminar o jogo.", "Eliminar dados");
            }
        }

        private void carregarEquipas()
        {
            cmbequipajogador1.Items.Clear();
            cmbequipajogador2.Items.Clear();

            foreach (Team equipa in containerDados.TeamSet)
            {
                cmbequipajogador1.Items.Add(equipa.Name);
                cmbequipajogador2.Items.Add(equipa.Name);
            }
        }

        private void carregarDecks()
        {
            cmbdecks1.Items.Clear();
            cmbdecks2.Items.Clear();

            foreach (Deck deck in containerDados.DeckSet)
            {
                cmbdecks1.Items.Add(deck.Name);
                cmbdecks2.Items.Add(deck.Name);
            }
        }

        private void carregarArbitrosJogos()
        {
            cmbarbitrojogos.Items.Clear();

            foreach (Referee arbitro in containerDados.UserSet.OfType<Referee>())
            {
                cmbarbitrojogos.Items.Add(arbitro.Username);
            }
        }

        private void carregarJogadoresJogos()
        {
            cmbequipajogador1.Items.Clear();
            cmbequipajogador2.Items.Clear();

            foreach (Player jogador in containerDados.PlayerSet)
            {

                cmbequipajogador1.Items.Add(jogador.Name);
                cmbequipajogador2.Items.Add(jogador.Name);
            }
        }

        private void carregarEquipasJogos()
        {
            cmbequipajogador1.Items.Clear();

            foreach (Team equipa in containerDados.TeamSet)
            {
                cmbequipajogador1.Items.Add(equipa.Name);
                cmbequipajogador2.Items.Add(equipa.Name);
            }
        }

        private int getIdDeck(string nomedeck)
        {
            int iddeck = 0;
            foreach (Deck baralho in containerDados.DeckSet)
            {
                if (baralho.Name.Equals(nomedeck))
                {
                    iddeck = baralho.Id;
                }
            }
            return iddeck;
        }

        private int getIdJogador(string nomejogador)
        {
            int idjogador = 0;
            foreach (Player jogador in containerDados.PlayerSet)
            {
                if (jogador.Name.Equals(nomejogador))
                {
                    idjogador = jogador.Id;
                }
            }
            return idjogador;
        }

        private int getIdArbitro(string usernamearbitro)
        {
            int idarbitro = 0;
            foreach (Referee arbitro in containerDados.UserSet.OfType<Referee>())
            {
                if (arbitro.Username.Equals(usernamearbitro))
                {
                    idarbitro = arbitro.Id;
                }
            }
            return idarbitro;
        }

        private int getIdEquipa(string nomeequipa)
        {
            int idequipa = 0;
            foreach (Team equipa in containerDados.TeamSet)
            {
                if (equipa.Name.Equals(nomeequipa))
                {
                    idequipa = equipa.Id;
                }
            }
            return idequipa;
        }

        private string getNomeJogador(int nrjogador)
        {
            string nomejogador = "";
            foreach (Player jogador in containerDados.PlayerSet)
            {
                if (jogador.Id == nrjogador)
                {
                    nomejogador = jogador.Name;
                }
            }
            return nomejogador;
        }

        private string getNomeDeck(int nrdeck)
        {
            string nomedeck = "";
            foreach (Deck baralho in containerDados.DeckSet)
            {
                if (baralho.Id == nrdeck)
                {
                    nomedeck = baralho.Name;
                }
            }
            return nomedeck;
        }

        private string getNomeEquipa(int nrequipa)
        {
            string nomeequipa = "";
            foreach (Team equipa in containerDados.TeamSet)
            {
                if (equipa.Id == nrequipa)
                {
                    nomeequipa = equipa.Name;
                }
            }
            return nomeequipa;
        }

        private string getUsernameArbitro(int idarbitro)
        {
            string usernamearbitro = "";
            foreach (Referee arbitro in containerDados.UserSet.OfType<Referee>())
            {
                if (arbitro.Id == idarbitro)
                {
                    usernamearbitro = arbitro.Username;
                }
            }
            return usernamearbitro;
        }

        private void cancelarJogo()
        {
            tpDataJogos.Value = DateTime.Now;
            nudNJogo.Value = 0;
            cmbarbitrojogos.SelectedIndex = -1;
            cmbequipajogador1.SelectedIndex = -1;
            cmbequipajogador2.SelectedIndex = -1;
            cmbdecks1.SelectedIndex = -1;
            cmbdecks2.SelectedIndex = -1;
            txtDescricaoJogo.ResetText();
        }

        private void refreshTabelaJogos()
        {
            if (radioTeamTournaments.Checked == true)
            {
                dgvGJogosLista.DataSource = (from games in containerDados.GameSet.OfType<TeamGame>().Where(game => game.TeamTournamentId.Value.Equals(idTorneio))
                                             select new { games.Id, games.Description, games.Number, games.Date, Team1 = games.Team1.Name, Team2 = games.Team2.Name, Deck1 = games.Deck1.Name, Deck2 = games.Deck2.Name }).ToList();
            }

            else if (radioStandardTournaments.Checked == true)
            {
                dgvGJogosLista.DataSource = (from games in containerDados.GameSet.OfType<StandardGame>().Where(game => game.StandardTournamentId.Value.Equals(idTorneio))
                                             select new { games.Id, games.Description, games.Number, games.Date, Player1 = games.Player1.Nickname, Player2 = games.Player2.Nickname, Deck1 = games.Deck1.Name, Deck2 = games.Deck2.Name }).ToList();
            }

            if (dgvGJogosLista.Rows.Count > 0)
            {
                dgvGJogosLista.CurrentCell = dgvGJogosLista.Rows[dgvGJogosLista.Rows.Count - 1].Cells[0];
            }
        }

        #endregion

        #region Gestão de Torneios

        /// <summary>
        /// Evento do radio button "Team".
        /// Invoca o método RefreshTabelaTorneios para fazer refresh à tabela.
        /// </summary>
        private void RadioFiltrarTeamTournaments(object sender, EventArgs e)
        {
            if(radioTeamTournaments.Checked == true)
            {
                txtGTorneiosPesquisa.Clear();
                RefreshTabelaTorneios();
            }
        }

        /// <summary>
        /// Evento do radio button "Standard".
        /// Invoca o método RefreshTabelaTorneios para fazer refresh à tabela.
        /// </summary>
        private void RadioFiltrarStandardTournaments(object sender, EventArgs e)
        {
            if(radioStandardTournaments.Checked == true)
            {
                txtGTorneiosPesquisa.Clear();
                RefreshTabelaTorneios();
            }
        }

        /// <summary>
        /// Evento do botão "Inserir" da tab de Torneios.
        /// Faz reset ao formulário e mostra o mesmo.
        /// </summary>
        private void BotaoInserirTorneio(object sender, EventArgs e)
        {
            ResetFormTorneios();
            txtTorneioAcao.Text = "Adicionar";
            gbGTorneiosForm.Visible = true;
            gbGJogosForm.Visible = false;
        }

        /// <summary>
        /// Evento do botão "Alterar" da tab de Torneios.
        /// Prepara e mostra o formulário com os dados do torneio selecionado.
        /// </summary>
        private void BotaoAlterarTorneio(object sender, EventArgs e)
        {
            if (dgvGTorneiosLista.SelectedRows.Count > 0)
            {
                idTorneio = (int)dgvGTorneiosLista.CurrentRow.Cells[0].Value;

                if (VerificarTipoTeamTournament())
                {
                    TeamTournament torneio = (TeamTournament)containerDados.TournamentSet.Find(idTorneio);

                    txtNomeTorneio.Text = torneio.Name;
                    txtDescricaoTorneio.Text = torneio.Description;
                    tpDataTorneio.Value = torneio.Date;

                    txtTorneioAcao.Text = "Aplicar";
                    gbGTorneiosForm.Visible = true;
                    gbTipoTorneio.Visible = false;
                    gbGJogosForm.Visible = false;
                }

                else if (VerificarTipoStandardTournament())
                {
                    StandardTournament torneio = (StandardTournament)containerDados.TournamentSet.Find(idTorneio);

                    txtNomeTorneio.Text = torneio.Name;
                    txtDescricaoTorneio.Text = torneio.Description;
                    tpDataTorneio.Value = torneio.Date;

                    txtTorneioAcao.Text = "Aplicar";
                    gbGTorneiosForm.Visible = true;
                    gbTipoTorneio.Visible = false;
                    gbGJogosForm.Visible = false;
                }
            }
        }

        /// <summary>
        /// Evento do botão "Eliminar" da tab de Torneios.
        /// Mostra uma mensagem de confirmação a perguntar se deseja remover o torneio. Se sim, remove-o.
        /// </summary>
        private void BotaoRemoverTorneio(object sender, EventArgs e)
        {
            if (dgvGTorneiosLista.SelectedRows.Count > 0)
            {
                DialogResult confirmacaoEliminar = MessageBox.Show("Tem a certeza que quer eliminar o torneio '" + dgvGTorneiosLista.CurrentRow.Cells[1].Value.ToString() + "'?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacaoEliminar == DialogResult.Yes)
                {
                    idTorneio = (int)dgvGTorneiosLista.CurrentRow.Cells[0].Value;

                    if(VerificarTipoTeamTournament())
                    {
                        RemoverTeamTournament();
                    }

                    else if (VerificarTipoStandardTournament())
                    {
                        RemoverStandardTournament();
                    }
                }
            }
        }

        /// <summary>
        /// Evento do botão no formulário de preenchimento do Torneio, que realiza as funções de "Adicionar" ou "Aplicar".
        /// Executa as validações de dados. Se passar as validações, executa os métodos da funcionalidade desejada.
        /// </summary>
        private void BotaoAcaoTorneio(object sender, EventArgs e)
        {
            string nameForm = txtNomeTorneio.Text.Trim();
            string descriptionForm = txtDescricaoTorneio.Text.Trim();
            DateTime dataForm = tpDataTorneio.Value;

            if (txtTorneioAcao.Text == "Aplicar")
            {
                DialogResult confirmacaoAlterar = MessageBox.Show("Tem a certeza que quer alterar o torneio '" + dgvGTorneiosLista.CurrentRow.Cells[1].Value.ToString() + "'?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(confirmacaoAlterar == DialogResult.Yes)
                {
                    if (nameForm.Length > 0 && descriptionForm.Length > 0)
                    {
                        if (containerDados.TournamentSet.Count() > 0)
                        {
                            idTorneio = (int)dgvGTorneiosLista.CurrentRow.Cells[0].Value;

                            if (VerificarAlteracoesTournament(nameForm))
                            {
                                if (VerificarTipoTeamTournament())
                                {
                                    AlterarTeamTournament(nameForm, descriptionForm, dataForm);
                                }

                                else if (VerificarTipoStandardTournament())
                                {
                                    AlterarStandardTournament(nameForm, descriptionForm, dataForm);
                                }

                                ResetFormTorneios();
                                gbGTorneiosForm.Visible = false;
                            }

                            else
                            {
                                MessageBox.Show("O torneio editado já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Tem de preencher os campos necessários para efetuar as alterações.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else if (txtTorneioAcao.Text == "Adicionar")
            {
                DialogResult confirmacaoAdicionar = MessageBox.Show("Tem a certeza que quer adicionar o torneio '" + nameForm + "'?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(confirmacaoAdicionar == DialogResult.Yes)
                {
                    if (nameForm.Length > 0 && descriptionForm.Length > 0)
                    {
                        if (containerDados.UserSet.Count() > 0)
                        {
                            if (VerificarDadosTournament(nameForm, descriptionForm))
                            {
                                if (radioTipoTorneioTeam.Checked == true)
                                {
                                    AdicionarTeamTournament(nameForm, descriptionForm, dataForm);
                                }
                                
                                else if (radioTipoTorneioStandard.Checked == true)
                                {
                                    AdicionarStandardTournament(nameForm, descriptionForm, dataForm);
                                }

                                ResetFormTorneios();
                                gbGTorneiosForm.Visible = false;
                            }

                            else
                            {
                                MessageBox.Show("O torneio inserido já existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            if (radioTipoTorneioTeam.Checked == true)
                            {
                                AdicionarTeamTournament(nameForm, descriptionForm, dataForm);
                                ResetFormTorneios();
                                gbGTorneiosForm.Visible = false;
                            }

                            else if (radioTipoTorneioStandard.Checked == true)
                            {
                                AdicionarStandardTournament(nameForm, descriptionForm, dataForm);
                                ResetFormTorneios();
                                gbGTorneiosForm.Visible = false;
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Tem de preencher todos os campos para adicionar o torneio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Evento do botão "Cancelar" no formulário de preenchimento do Torneio.
        /// Faz reset ao formulário.
        /// </summary>
        private void BotaoCancelarTorneio(object sender, EventArgs e)
        {
            ResetFormTorneios();
            gbGTorneiosForm.Visible = false;
        }

        /// <summary>
        /// Evento de pesquisar torneios, quando o utilizador insere dados na Textbox de pesquisar.
        /// Executa uma query Linq em que o nome do torneio contem o que for inserido na Textbox e põe os resultados na Data Grid View correspondente.
        /// </summary>
        private void PesquisarTorneio(object sender, EventArgs e)
        {
            string nomeTorneio = txtGTorneiosPesquisa.Text.Trim();

            if (nomeTorneio.Length > 0)
            {
                if (radioTeamTournaments.Checked == true)
                {
                    var query = from torneios in containerDados.TournamentSet.OfType<TeamTournament>()
                                where torneios.Name.Contains(nomeTorneio)
                                select new { torneios.Id, torneios.Name, torneios.Date, torneios.Description };

                    dgvGTorneiosLista.DataSource = query.ToList();
                }

                else if (radioStandardTournaments.Checked == true)
                {
                    var query = from torneios in containerDados.TournamentSet.OfType<StandardTournament>()
                                where torneios.Name.Contains(nomeTorneio)
                                select new { torneios.Id, torneios.Name, torneios.Date, torneios.Description };

                    dgvGTorneiosLista.DataSource = query.ToList();
                }
            }

            else
            {
                RefreshTabelaTorneios();
            }
        }

        /// <summary>
        /// Método de inserção de um torneio Team.
        /// Cria uma instancia da classe TeamTournament com os dados enviados por parêmetro e insere a instância no DataSet "UserSet".
        /// No final, faz refresh da tabela através do método RefreshTabelaTorneios.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="date"></param>
        private void AdicionarTeamTournament(string name, string description, DateTime date)
        {
            try
            {
                TeamTournament novoTournament = new TeamTournament
                {
                    Name = name,
                    Description = description,
                    Date = date
                };

                containerDados.TournamentSet.Add(novoTournament);
                containerDados.SaveChanges();
                RefreshTabelaTorneios();
            }

            catch (Exception excecaoErro)
            {
                MessageBox.Show("Ocorreu um erro na inserção do torneio." + excecaoErro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método de inserção de um torneio Standard.
        /// Cria uma instancia da classe StandardTournament com os dados enviados por parêmetro e insere a instância no DataSet "UserSet".
        /// No final, faz refresh da tabela através do método RefreshTabelaTorneios.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="date"></param>
        private void AdicionarStandardTournament(string name, string description, DateTime date)
        {
            try
            {
                StandardTournament novoTournament = new StandardTournament
                {
                    Name = name,
                    Description = description,
                    Date = date
                };

                containerDados.TournamentSet.Add(novoTournament);
                containerDados.SaveChanges();
                RefreshTabelaTorneios();
            }

            catch (Exception excecaoErro)
            {
                MessageBox.Show("Ocorreu um erro na inserção do torneio." + excecaoErro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método da alteração de um torneio Team.
        /// Pesquisa pelo torneio com o id idTorneio, e guarda os novos dados no mesmo.
        /// No final, guarda as alterações na base de dados e faz refresh da tabela através do método RefreshTabelaTorneios.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="date"></param>
        private void AlterarTeamTournament(string name, string description, DateTime date)
        {
            try
            {
                TeamTournament torneio = (TeamTournament) containerDados.TournamentSet.Find(idTorneio);

                torneio.Name = name;
                torneio.Description = description;
                torneio.Date = date;

                containerDados.Entry(torneio).State = EntityState.Modified;
                containerDados.SaveChanges();
                RefreshTabelaTorneios();
            }

            catch (Exception excecaoErro)
            {
                MessageBox.Show("Ocorreu um erro na edição do torneio." + excecaoErro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método da alteração de um torneio Standard.
        /// Pesquisa pelo torneio com o id idTorneio, e guarda os novos dados no mesmo.
        /// No final, guarda as alterações na base de dados e faz refresh da tabela através do método RefreshTabelaTorneios.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="date"></param>
        private void AlterarStandardTournament(string name, string description, DateTime date)
        {
            try
            {
                StandardTournament torneio = (StandardTournament) containerDados.TournamentSet.Find(idTorneio);

                torneio.Name = name;
                torneio.Description = description;
                torneio.Date = date;

                containerDados.Entry(torneio).State = EntityState.Modified;
                containerDados.SaveChanges();
                RefreshTabelaTorneios();
            }

            catch (Exception excecaoErro)
            {
                MessageBox.Show("Ocorreu um erro na edição do torneio." + excecaoErro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método de remoção de um torneio Team.
        /// Remove um torneio Team do Data Set "TournamentSet".
        /// De seguida, guarda as modificações do TournamentSet na base de dados e faz refresh à tabela.
        /// </summary>
        private void RemoverTeamTournament()
        {
            try
            {
                TeamTournament torneio = (TeamTournament) containerDados.TournamentSet.Find(idTorneio);

                containerDados.TournamentSet.Remove(torneio);
                containerDados.SaveChanges();
                RefreshTabelaTorneios();
            }

            catch (Exception excecaoErro)
            {
                MessageBox.Show("Ocorreu um erro na remoção do torneio." + excecaoErro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método de remoção de um torneio Standard.
        /// Remove um torneio Standard do Data Set "TournamentSet".
        /// De seguida, guarda as modificações do TournamentSet na base de dados e faz refresh à tabela.
        /// </summary>
        private void RemoverStandardTournament()
        {
            try
            {
                StandardTournament torneio = (StandardTournament) containerDados.TournamentSet.Find(idTorneio);

                containerDados.TournamentSet.Remove(torneio);
                containerDados.SaveChanges();
                RefreshTabelaTorneios();
            }

            catch (Exception excecaoErro)
            {
                MessageBox.Show("Ocorreu um erro na remoção do torneio." + excecaoErro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para fazer refresh à DataGridView (Tabela) na tab dos Torneios.
        /// Muda a Data Source da Data Grid View para o tipo do torneio correspondente.
        /// </summary>
        private void RefreshTabelaTorneios()
        {
            if(radioTeamTournaments.Checked == true)
            {
                dgvGTorneiosLista.DataSource = (from torneiosTeam in containerDados.TournamentSet.OfType<TeamTournament>()
                                                select new { torneiosTeam.Id, torneiosTeam.Name, torneiosTeam.Date, torneiosTeam.Description} ).ToList();
            }

            else if (radioStandardTournaments.Checked == true)
            {
                dgvGTorneiosLista.DataSource = (from torneiosStandard in containerDados.TournamentSet.OfType<StandardTournament>()
                                                select new { torneiosStandard.Id, torneiosStandard.Name, torneiosStandard.Date, torneiosStandard.Description }).ToList();
            }
        }

        /// <summary>
        /// Método para fazer reset ao formulário de preenchimento do Torneio.
        /// Limpa os dados presentes do formulário.
        /// </summary>
        private void ResetFormTorneios()
        {
            txtNomeTorneio.Clear();
            txtDescricaoTorneio.Clear();
            tpDataTorneio.ResetText();
            gbGTorneiosDados.Enabled = true;
            gbTipoTorneio.Enabled = true;
            gbTipoTorneio.Visible = true;
        }

        private bool VerificarDadosTournament(string nameTorneio, string descriptionTorneio)
        {
            bool naoExisteDados = true;

            foreach (Tournament torneio in containerDados.TournamentSet)
            {
                if (torneio.Name == nameTorneio && torneio.Description == descriptionTorneio)
                {
                    naoExisteDados = false;
                }
            }

            return naoExisteDados;
        }

        private bool VerificarAlteracoesTournament(string nameTorneio)
        {
            bool aplicaAlteracoes = true;

            foreach (Tournament torneio in containerDados.TournamentSet)
            {
                if (torneio.Name == nameTorneio && torneio.Id != idTorneio)
                {
                    aplicaAlteracoes = false;
                }
            }

            return aplicaAlteracoes;
        }
		
        private bool VerificarTipoTeamTournament()
        {
            bool isTipoTeamTournament = false;

            foreach (TeamTournament torneioTeam in containerDados.TournamentSet.OfType<TeamTournament>())
            {
                if (torneioTeam.Id == idTorneio)
                {
                    isTipoTeamTournament = true;
                }
            }

            return isTipoTeamTournament;
        }

        private bool VerificarTipoStandardTournament()
        {
            bool isTipoStandardTournament = false;

            foreach (StandardTournament torneioStandard in containerDados.TournamentSet.OfType<StandardTournament>())
            {
                if (torneioStandard.Id == idTorneio)
                {
                    isTipoStandardTournament = true;
                }
            }

            return isTipoStandardTournament;
        }

        #endregion

        #region Pesquisa de Torneios e Jogos

        private void TabVerTorneios(object sender, EventArgs e)
        {
            radioPesquisarTorneiosTeam.Checked = true;
            radioPesquisarJogosTeam.Checked = true;

            CarregarComboDeck();
            CarregarComboArbitro();
        }

        #region Torneios

        /// <summary>
        /// Evento do radio button "Team", na zona de pesquisa de Torneios.
        /// Apenas invoca o método RefreshTabelaResultadosPesquisaTorneios para fazer refresh à tabela.
        /// </summary>
        private void RadioPesquisarTorneiosTeam(object sender, EventArgs e)
        {
            if(radioPesquisarTorneiosTeam.Checked == true)
            {
                RefreshTabelaResultadosPesquisaTorneios();
            }
        }

        /// <summary>
        /// Evento do radio button "Standard", na zona de pesquisa de Torneios.
        /// Apenas invoca o método RefreshTabelaResultadosPesquisaTorneios para fazer refresh à tabela.
        /// </summary>
        private void RadioPesquisarTorneiosStandard(object sender, EventArgs e)
        {
            if (radioPesquisarTorneiosStandard.Checked == true)
            {
                RefreshTabelaResultadosPesquisaTorneios();
            }
        }

        /// <summary>
        /// Evento do botão "Limpar", na zona de pesquisa de Torneios.
        /// Apenas invoca o método ResetFormPesquisaTorneios e RefreshTabelaResultadosPesquisaTorneios para limpar o form e fazer refresh à tabela.
        /// </summary>
        private void BotaoLimparTorneios(object sender, EventArgs e)
        {
            ResetFormPesquisaTorneios();
            RefreshTabelaResultadosPesquisaTorneios();
        }

        private void PesquisarTorneios(object sender, EventArgs e)
        {
            string nomeTorneio = txtTorneioNome.Text.Trim();
            string descricaoTorneio = txtTorneioDescricao.Text.Trim();
            //DateTime dataTorneio = dtpTorneioData.Value.Date;

            try
            {
                if (radioPesquisarTorneiosTeam.Checked == true)
                {
                    IQueryable<TeamTournament> query = containerDados.TournamentSet.OfType<TeamTournament>();

                    if (nomeTorneio.Length > 0)
                    {
                        query.Where(torneio => torneio.Name.Contains(nomeTorneio));
                    }

                    else if (descricaoTorneio.Length > 0)
                    {
                        query.Where(torneio => torneio.Description.Contains(descricaoTorneio));
                    }

                    //query = query.Where(torneio => torneio.Date.Equals(dataTorneio));

                    dgvResultadosTorneios.DataSource = (query.Select(torneio => new { torneio.Id, torneio.Name, torneio.Date, torneio.Description })).ToList();
                }

                else if (radioPesquisarTorneiosStandard.Checked == true)
                {
                    IQueryable<StandardTournament> query = containerDados.TournamentSet.OfType<StandardTournament>();

                    if (nomeTorneio.Length > 0)
                    {
                        query.Where(torneio => torneio.Name.Contains(nomeTorneio));
                    }

                    else if (descricaoTorneio.Length > 0)
                    {
                        query.Where(torneio => torneio.Description.Contains(descricaoTorneio));
                    }

                    //query = query.Where(torneio => torneio.Date.Equals(dataTorneio));

                    dgvResultadosTorneios.DataSource = (query.Select(torneio => new { torneio.Id, torneio.Name, torneio.Date, torneio.Description })).ToList();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na pesquisa de torneios\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para fazer reset ao form de pesquisa de Torneios.
        /// Apenas limpa o form.
        /// </summary>
        private void ResetFormPesquisaTorneios()
        {
            txtTorneioNome.Clear();
            dtpTorneioData.ResetText();
            txtTorneioDescricao.Clear();
        }

        /// <summary>
        /// Método para fazer refresh à DataGridView (Tabela) na zona de pesquisa de Torneios.
        /// Muda a Data Source da Data Grid View para o tipo do torneio correspondente.
        /// </summary>
        private void RefreshTabelaResultadosPesquisaTorneios()
        {
            try
            {
                if (radioPesquisarTorneiosTeam.Checked == true)
                {
                    dgvResultadosTorneios.DataSource = (from torneio in containerDados.TournamentSet.OfType<TeamTournament>()
                                                        select new { torneio.Id, torneio.Name, torneio.Date, torneio.Description }).ToList();
                }

                else if (radioPesquisarTorneiosStandard.Checked == true)
                {
                    dgvResultadosTorneios.DataSource = (from torneio in containerDados.TournamentSet.OfType<StandardTournament>()
                                                        select new { torneio.Id, torneio.Name, torneio.Date, torneio.Description }).ToList();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no carregamento dos torneios.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Jogos

        /// <summary>
        /// Evento do radio button "Team", na zona de Pesquisa de Jogos.
        /// Invoca o método RefreshTabelaResultadosPesquisaJogos para fazer refresh à tabela e,
        /// o método CarregarComboJogadorEquipa para carregar a combo box de Jogadores/Equipas com o tipo especifico ao tipo do jogo.
        /// </summary>
        private void RadioPesquisarJogosTeam(object sender, EventArgs e)
        {
            if (radioPesquisarJogosTeam.Checked == true)
            {
                RefreshTabelaResultadosPesquisaJogos();
                CarregarComboJogadorEquipa();
            }
        }

        /// <summary>
        /// Evento do radio button "Standard", na zona de Pesquisa de Jogos.
        /// Invoca o método RefreshTabelaResultadosPesquisaJogos para fazer refresh à tabela e,
        /// o método CarregarComboJogadorEquipa para carregar a combo box de Jogadores/Equipas com o tipo especifico ao tipo do jogo.
        /// </summary>
        private void RadioPesquisarJogosStandard(object sender, EventArgs e)
        {
            if (radioPesquisarJogosStandard.Checked == true)
            {
                RefreshTabelaResultadosPesquisaJogos();
                CarregarComboJogadorEquipa();
            }
        }

        /// <summary>
        /// Evento do botão "Limpar", na zona de pesquisa de Jogos.
        /// Apenas invoca o método ResetFormPesquisaJogos e RefreshTabelaResultadosPesquisaJogos para limpar o form e fazer refresh à tabela.
        /// </summary>
        private void BotaoLimparJogos(object sender, EventArgs e)
        {
            ResetFormPesquisaJogos();
            RefreshTabelaResultadosPesquisaJogos();
        }

        private void PesquisarJogos(object sender, EventArgs e)
        {
            string descricaoJogo = txtJogoNome.Text.Trim();
            int numeroJogo = (int) nupJogoNumero.Value;
            //DateTime dataJogo = dtpJogoData.Value.Date;
            string jogadorEquipaJogo = "";
            string deckJogo = "";
            string arbitroJogo = "";

            if (comboJogoJogadorEquipa.SelectedIndex != -1)
            {
                jogadorEquipaJogo = comboJogoJogadorEquipa.Text.Trim();
            }

            else if (comboJogoDeck.SelectedIndex != -1)
            {
                deckJogo = comboJogoDeck.Text.Trim();
            }

            else if (comboJogoArbitro.SelectedIndex != -1)
            {
                arbitroJogo = comboJogoArbitro.Text.Trim();
            }

            try
            {
                if (radioPesquisarJogosTeam.Checked == true)
                {
                    IQueryable<TeamGame> query = containerDados.GameSet.OfType<TeamGame>();

                    if (descricaoJogo.Length > 0)
                    {
                        query.Where(jogo => jogo.Description.Contains(descricaoJogo));
                    }

                    else if (jogadorEquipaJogo != "")
                    {
                        query.Where(jogo => (jogo.Team1.Name.Contains(jogadorEquipaJogo) || jogo.Team2.Name.Contains(jogadorEquipaJogo)));
                    }

                    else if (deckJogo != "")
                    {
                        query.Where(jogo => (jogo.Deck1.Name.Contains(deckJogo) || jogo.Deck1.Name.Contains(deckJogo)));
                    }

                    else if (arbitroJogo != "")
                    {
                        query.Where(jogo => jogo.Referee.Username.Contains(arbitroJogo));
                    }

                    query.Where(jogo => jogo.Number >= numeroJogo);

                    //query.Where(jogo => jogo.Date.Equals(dataJogo));

                    dgvResultadosJogos.DataSource = (query.Select(jogo => new { jogo.Id, jogo.Description, jogo.Date, jogo.Number, jogo.Tournament.Name, Referee = jogo.Referee.Username, Player1 = jogo.Team1.Name, Player2 = jogo.Team2.Name })).ToList();
                }

                else if (radioPesquisarJogosStandard.Checked == true)
                {
                    IQueryable<StandardGame> query = containerDados.GameSet.OfType<StandardGame>();

                    if (descricaoJogo.Length > 0)
                    {
                        query.Where(jogo => jogo.Description.Contains(descricaoJogo));
                    }

                    else if (jogadorEquipaJogo != "")
                    {
                        query.Where(jogo => (jogo.Player1.Nickname.Contains(jogadorEquipaJogo) || jogo.Player2.Nickname.Contains(jogadorEquipaJogo)));
                    }

                    else if (deckJogo != "")
                    {
                        query.Where(jogo => (jogo.Deck1.Name.Contains(deckJogo) || jogo.Deck1.Name.Contains(deckJogo)));
                    }

                    else if (arbitroJogo != "")
                    {
                        query.Where(jogo => jogo.Referee.Username.Contains(arbitroJogo));
                    }

                    query.Where(jogo => jogo.Number >= numeroJogo);

                    //query.Where(jogo => jogo.Date.Equals(dataJogo));

                    dgvResultadosJogos.DataSource = (query.Select(jogo => new { jogo.Id, jogo.Description, jogo.Date, jogo.Number, jogo.Tournament.Name, Referee = jogo.Referee.Username, Player1 = jogo.Player1.Nickname, Player2 = jogo.Player2.Nickname })).ToList();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na pesquisa de jogos.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para fazer reset ao form de pesquisa de Jogos.
        /// Apenas limpa o form.
        /// </summary>
        private void ResetFormPesquisaJogos()
        {
            txtJogoNome.Clear();
            comboJogoJogadorEquipa.SelectedIndex = -1;
            comboJogoDeck.SelectedIndex = -1;
            comboJogoArbitro.SelectedIndex = -1;
            nupJogoNumero.ResetText();
        }

        /// <summary>
        /// Método para fazer refresh à DataGridView (Tabela) na zona de pesquisa de Jogos.
        /// Muda a Data Source da Data Grid View para o tipo do jogo correspondente.
        /// </summary>
        private void RefreshTabelaResultadosPesquisaJogos()
        {
            try
            {
                if (radioPesquisarJogosTeam.Checked == true)
                {
                    dgvResultadosJogos.DataSource = (from jogo in containerDados.GameSet.OfType<TeamGame>()
                                                     select new { jogo.Id, jogo.Description, jogo.Date, jogo.Number, jogo.Tournament.Name, Referee = jogo.Referee.Username, Player1 = jogo.Team1.Name, Player2 = jogo.Team2.Name }).ToList();
                }

                else if (radioPesquisarJogosStandard.Checked == true)
                {
                    dgvResultadosJogos.DataSource = (from jogo in containerDados.GameSet.OfType<StandardGame>()
                                                     select new { jogo.Id, jogo.Description, jogo.Date, jogo.Number, jogo.Tournament.Name, Referee = jogo.Referee.Username, Player1 = jogo.Player1.Nickname, Player2 = jogo.Player2.Nickname }).ToList();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no carregamento dos jogos.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método para carregar Equipas ou Jogadores na combo box correspondente, consoante o tipo de Jogo selecionado.
        /// </summary>
        private void CarregarComboJogadorEquipa()
        {
            if (radioPesquisarJogosTeam.Checked == true)
            {
                labJogoJogadorEquipa.Text = "Contem a Equipa";
                comboJogoJogadorEquipa.Items.Clear();

                foreach (Team equipa in containerDados.TeamSet.OfType<Team>())
                {
                    comboJogoJogadorEquipa.Items.Add(equipa.Name);
                }
            }

            else if (radioPesquisarJogosStandard.Checked == true)
            {
                labJogoJogadorEquipa.Text = "Contem o Jogador";
                comboJogoJogadorEquipa.Items.Clear();

                foreach (Player jogador in containerDados.GameSet.OfType<Player>())
                {
                    comboJogoJogadorEquipa.Items.Add(jogador.Nickname);
                }
            }
        }

        /// <summary>
        /// Método para carregar Baralhos na combo box correspondente.
        /// </summary>
        private void CarregarComboDeck()
        {
            comboJogoDeck.Items.Clear();

            foreach(Deck deck in containerDados.DeckSet)
            {
                comboJogoDeck.Items.Add(deck.Name);
            }
        }

        /// <summary>
        /// Método para carregar Arbitros na combo box correspondente.
        /// </summary>
        private void CarregarComboArbitro()
        {
            comboJogoArbitro.Items.Clear();

            foreach (Referee arbitro in containerDados.UserSet.OfType<Referee>())
            {
                comboJogoArbitro.Items.Add(arbitro.Username);
            }
        }

        #endregion

        #endregion

        #region WIP

        private void tbGestaoTorneios_Enter(object sender, EventArgs e)
        {
            /*cmbJogador1Jogo.Items.Clear();

            Player jogador1;
            if(cmbJogador1Jogo.SelectedIndex != -1)
            {
                jogador1 = (Player)cmbJogador1Jogo.SelectedItem;


            }

                foreach(Player jogador in containerDados.PlayerSet)
                {
                    cmbJogador1Jogo.Items.Add(jogador.Name);
                    cmbJogador2Jogo.Items.Add(jogador.Name);
                }
                */


            /*carregarJogadoresJogos();

            carregarArbitrosJogos();
            carregarDecks();
            */
            //MessageBox.Show("Olá");
        }

        private void cmbJogador1Jogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (radioTeamTournaments.Checked == true)
            {
                if(cmbequipajogador1.SelectedIndex != -1)
                {
                    string nomeequipa1 = cmbequipajogador1.SelectedItem.ToString();
                    cmbequipajogador2.Items.Clear();
                    foreach (Team equipa in containerDados.TeamSet)
                    {
                        if (!equipa.Name.Equals(nomeequipa1))
                        {
                            cmbequipajogador2.Items.Add(equipa.Name);
                        }
                    }
                }
            }
            else if (radioStandardTournaments.Checked == true)
            {
                string nomejogador1 = cmbequipajogador1.SelectedItem.ToString();
                cmbequipajogador2.Items.Clear();
                foreach (Player jogador in containerDados.PlayerSet)
                {
                    if (!jogador.Name.Equals(nomejogador1))
                    {
                        cmbequipajogador2.Items.Add(jogador.Name);
                    }
                }

            }*/



            /*if (i != -1)
            {
                cmbequipajogador2.SelectedIndex = i;
            }*/
        }

        private void cmbequipajogador2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (radioTeamTournaments.Checked == true)
            {
                string nomeequipa2 = cmbequipajogador2.SelectedItem.ToString();
                cmbequipajogador1.Items.Clear();
                foreach (Team equipa in containerDados.TeamSet)
                {
                    if (!equipa.Name.Equals(nomeequipa2))
                    {
                        cmbequipajogador1.Items.Add(equipa.Name);
                    }
                }
            }
            else if (radioStandardTournaments.Checked == true)
            {
                string nomejogador2 = cmbequipajogador2.SelectedItem.ToString();
                cmbequipajogador1.Items.Clear();
                foreach (Player jogador in containerDados.PlayerSet)
                {
                    if (!jogador.Name.Equals(nomejogador2))
                    {
                        cmbequipajogador1.Items.Add(jogador.Name);
                    }
                }
            }*/
        }

        #endregion
    }
}


