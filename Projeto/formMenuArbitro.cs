using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class formMenuArbitro : Form
    {
        public formMenuArbitro(int iduser)
        {
            InitializeComponent();

            idArbitro = iduser;

            //Iniciar o contentor
            container = new DiagramaArcmageContainer();
        }

        /// <summary>
        /// Variável usada para interagir com a base de dados
        /// </summary>
        public DiagramaArcmageContainer container;

        /// <summary>
        /// Variável que guarda o ID do árbitro que iniciou sessão
        /// </summary>
        private int idArbitro;

        private void formMenuArbitro_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogin Login = new formLogin();
            Login.Show();
        }

        /// <summary>
        /// Preenche as Listboxes com os torneios existentes
        /// </summary>
        private void formMenuArbitro_Load(object sender, EventArgs e)
        {
            //Standard Tournament

            List<StandardTournament> listaST = container.TournamentSet.OfType<StandardTournament>().ToList();

            foreach (StandardTournament torneio in listaST)
            {
                lbxStandardT.Items.Add(torneio);
            }

            //-------------------

            //Team Tournament

            List<TeamTournament> listaTT = container.TournamentSet.OfType<TeamTournament>().ToList();

            foreach (TeamTournament torneio in listaTT)
            {
                lbxTeamT.Items.Add(torneio);
            }
        }

        #region Standard

        /// <summary>
        /// Ao selecionar 1 torneio, carrega os jogos
        /// associados ao árbitro atual para a tabela lvStandardJ
        /// </summary>
        private void lbxStandardT_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvStandardJ.Items.Clear();

            if (lbxStandardT.SelectedItems.Count > 0)
            {
                //Obter torneio selecionado
                StandardTournament torneioSelecionado = (StandardTournament)lbxStandardT.SelectedItem;

                //Percorrer todos os jogos desse torneio
                foreach (StandardGame jogo in torneioSelecionado.Games)
                {
                    if (jogo.RefereeId == idArbitro) //Verificar se o jogo está associado ao árbitro
                    {
                        ListViewItem item = new ListViewItem(jogo.Description);
                        item.SubItems.Add(jogo.Date.ToShortDateString());
                        item.SubItems.Add(jogo.Player1.Nickname);
                        item.SubItems.Add(jogo.Player2.Nickname);

                        lvStandardJ.Items.Add(item);
                    }
                }
            }
        }

        /// <summary>
        /// Abrir o formulário de edição da informação do jogo selecionado
        /// </summary>
        private void lvStandardJ_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvStandardJ.SelectedItems.Count > 0)
            {
                string descricao = lvStandardJ.SelectedItems[0].Text;

                StandardGame jogo = container.GameSet.OfType<StandardGame>()
                        .Where(g => g.Description.Equals(descricao)).First();

                FormArbitro_DetalhesJogoS detalhes = new FormArbitro_DetalhesJogoS(jogo, this);
                detalhes.ShowDialog();

                lvStandardJ.Items.Clear();
                lbxStandardT.SelectedIndex = -1;
            }
        }


        #endregion

        #region Team

        /// <summary>
        /// Ao selecionar 1 torneio, carrega os jogos
        /// associados ao árbitro atual para a tabela lvTeamJ
        /// </summary>
        private void lbxTeamT_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvTeamJ.Items.Clear();

            if (lbxTeamT.SelectedItems.Count > 0)
            {
                //Obter torneio selecionado
                TeamTournament torneioSelecionado = (TeamTournament)lbxTeamT.SelectedItem;

                //Percorrer todos os jogos desse torneio
                foreach (TeamGame jogo in torneioSelecionado.Games)
                {
                    if (jogo.RefereeId == idArbitro) //Verificar se o jogo está associado ao árbitro
                    {
                        ListViewItem item = new ListViewItem(jogo.Description);
                        item.SubItems.Add(jogo.Date.ToShortDateString());
                        item.SubItems.Add(jogo.Team1.Name);
                        item.SubItems.Add(jogo.Team2.Name);

                        lvTeamJ.Items.Add(item);
                    }
                }
            }
        }

        /// <summary>
        /// Abrir o formulário de edição da informação do jogo selecionado
        /// </summary>
        private void lvTeamJ_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string descricao = lvTeamJ.SelectedItems[0].Text;

            TeamGame jogo = container.GameSet.OfType<TeamGame>()
                    .Where(g => g.Description.Equals(descricao)).First();

            FormArbitro_DetalhesJogoT detalhes = new FormArbitro_DetalhesJogoT(jogo, this);
            detalhes.ShowDialog();

            lvTeamJ.Items.Clear();
            lbxTeamT.SelectedIndex = -1;
        }
        #endregion


    }
}
