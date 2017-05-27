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
    public partial class FormArbitro_DetalhesJogoT : Form
    {
        /// <summary>
        /// Variável usada para interagir com a base de dados
        /// </summary>
        private DiagramaArcmageContainer container;

        TeamGame jogo;

        public FormArbitro_DetalhesJogoT(TeamGame infoJogo)
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

            //Equipas
            foreach (Team item in container.TeamSet)
            {
                cmbParticipante1.Items.Add(item.Name);
                cmbParticipante2.Items.Add(item.Name);
            }


            //Preencher Campos
            txtDescricao.Text = jogo.Description;
            nudNumero.Value = jogo.Number;
            dtpData.Value = jogo.Date;
            cmbParticipante1.SelectedItem = jogo.Team1.Name;
            cmbParticipante2.SelectedItem = jogo.Team2.Name;
            cmbDeck1.SelectedItem = jogo.Deck1.Name;
            cmbDeck2.SelectedItem = jogo.Deck2.Name;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string t1 = cmbParticipante1.SelectedItem.ToString();
            string t2 = cmbParticipante2.SelectedItem.ToString();

            if (t1 == t2)
            {
                MessageBox.Show("Uma equipa não pode jogar contra ela mesmo", "Atenção");
            }
            else
            {
                string d1 = cmbDeck1.SelectedItem.ToString();
                string d2 = cmbDeck2.SelectedItem.ToString();

                Team equipa1 = container.TeamSet.Where(j => j.Name.Equals(t1)).First();
                Team equipa2 = container.TeamSet.Where(j => j.Name.Equals(t2)).First();
                Deck deck1 = container.DeckSet.Where(d => d.Name.Equals(d1)).First();
                Deck deck2 = container.DeckSet.Where(d => d.Name.Equals(d2)).First();


                jogo.Description = txtDescricao.Text;
                jogo.Number = (int)nudNumero.Value;
                jogo.Date = dtpData.Value;
                jogo.Team1 = equipa1;
                jogo.TeamId1 = equipa1.Id;
                jogo.Team2 = equipa2;
                jogo.TeamId2 = equipa2.Id;
                jogo.Deck1 = deck1;
                jogo.DeckId1 = deck1.Id;
                jogo.Deck2 = deck2;
                jogo.DeckId2 = deck2.Id;

                container.SaveChanges();

                MessageBox.Show("Alterações guardadas com sucesso!", "Sucesso");
            }
        }
    }
}
