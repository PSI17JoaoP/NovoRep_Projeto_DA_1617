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
        private DiagramaArcmageContainer container;

        /// <summary>
        /// Variável que guarda o ID do árbitro que iniciou sessão
        /// </summary>
        private int idArbitro;

        private void formMenuArbitro_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogin Login = new formLogin();
            Login.Show();
        }

        private void formMenuArbitro_Load(object sender, EventArgs e)
        {
            IQueryable<Game> query = container.GameSet.Where(game => game.RefereeId == idArbitro);

            dgvTabelaJogos.DataSource = query.ToList();
        }
    }
}
