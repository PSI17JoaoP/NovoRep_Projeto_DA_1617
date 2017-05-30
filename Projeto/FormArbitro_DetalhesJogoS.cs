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
    public partial class FormArbitro_DetalhesJogoS : Form
    {
        /// <summary>
        /// Variável usada para interagir com a base de dados
        /// </summary>
        private DiagramaArcmageContainer container;

        StandardGame jogo;

        public FormArbitro_DetalhesJogoS(StandardGame infoJogo)
        {
            InitializeComponent();

            container = new DiagramaArcmageContainer();
            jogo = infoJogo;

            //Carregar comboboxes

            //Baralhos
            foreach (Deck item in container.DeckSet)
            {
                cmbDeck1.Items.Add(item.Name);
                cmbDeck2.Items.Add(item.Name);
            }

            //Jogadores
            foreach (Player item in container.PlayerSet)
            {
                cmbParticipante1.Items.Add(item.Nickname);
                cmbParticipante2.Items.Add(item.Nickname);
            }


            //Preencher Campos
            txtDescricao.Text = jogo.Description;
            nudNumero.Value = jogo.Number;
            dtpData.Value = jogo.Date;
            cmbParticipante1.SelectedItem = jogo.Player1.Nickname;
            cmbParticipante2.SelectedItem = jogo.Player2.Nickname;
            cmbDeck1.SelectedItem = jogo.Deck1.Name;
            cmbDeck2.SelectedItem = jogo.Deck2.Name;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string j1 = cmbParticipante1.SelectedItem.ToString();
            string j2 = cmbParticipante2.SelectedItem.ToString();

            if (j1 == j2)
            {
                MessageBox.Show("Um jogador não pode jogar contra ele mesmo", "Atenção");
            }else
            {
                string d1 = cmbDeck1.SelectedItem.ToString();
                string d2 = cmbDeck2.SelectedItem.ToString();

                Player jogador1 = container.PlayerSet.Where(j => j.Nickname.Equals(j1)).First();
                Player jogador2 = container.PlayerSet.Where(j => j.Nickname.Equals(j2)).First();
                Deck deck1 = container.DeckSet.Where(d => d.Name.Equals(d1)).First();
                Deck deck2 = container.DeckSet.Where(d => d.Name.Equals(d2)).First();


                jogo.Description = txtDescricao.Text;
                jogo.Number = (int)nudNumero.Value;
                jogo.Date = dtpData.Value;
                jogo.Player1 = jogador1;
                jogo.PlayerId1 = jogador1.Id;
                jogo.Player2 = jogador2;
                jogo.PlayerId2 = jogador2.Id;
                jogo.Deck1 = deck1;
                jogo.DeckId1 = deck1.Id;
                jogo.Deck2 = deck2;
                jogo.DeckId2 = deck2.Id;

                container.SaveChanges();

                MessageBox.Show("Alterações guardadas com sucesso!", "Sucesso");

                Close();
            }
        }
    }
}
