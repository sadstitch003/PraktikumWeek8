using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PraktikumWEek8
{
    public partial class formHasilPertandingan : Form
    {
        private static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        DataTable dtHomeTeam = new DataTable();
        DataTable dtAwayTeam = new DataTable();

        public formHasilPertandingan()
        {
            InitializeComponent();
        }

        private void formHasilPertandingan_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "SELECT team_id, team_name, manager_id, captain_id, home_stadium FROM team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtHomeTeam); 
            sqlAdapter.Fill(dtAwayTeam);

            cbHomeTeam.DisplayMember = "team_name";
            cbHomeTeam.ValueMember = "team_id";
            cbHomeTeam.DataSource = dtHomeTeam;

            cbAwayTeam.DisplayMember = "team_name";
            cbAwayTeam.ValueMember = "team_id";
            cbAwayTeam.DataSource = dtAwayTeam;
        }

        private void cbHomeTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable selectedHomeTeam = new DataTable();
            sqlQuery = $"SELECT team.team_id, team.team_name, manager.manager_name, player.player_name, team.home_stadium, team.city, team.capacity FROM team LEFT JOIN player ON team.captain_id = player.player_id LEFT JOIN manager ON team.manager_id = manager.manager_id WHERE team.team_id = '{cbHomeTeam.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(selectedHomeTeam);

            lblHomeManager.Text = selectedHomeTeam.Rows[0][2].ToString();
            lblHomeCaptain.Text = selectedHomeTeam.Rows[0][3].ToString();
            lblStadiumName.Text = $"{selectedHomeTeam.Rows[0][4].ToString()}, {selectedHomeTeam.Rows[0][5].ToString()}";
            lblStadiumCapacity.Text = selectedHomeTeam.Rows[0][6].ToString();
        }

        private void cbAwayTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable selectedAwayTeam = new DataTable();
            sqlQuery = $"SELECT team.team_id, team.team_name, manager.manager_name, player.player_name FROM team LEFT JOIN player ON team.captain_id = player.player_id LEFT JOIN manager ON team.manager_id = manager.manager_id WHERE team.team_id = '{cbAwayTeam.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(selectedAwayTeam);

            lblAwayManager.Text = selectedAwayTeam.Rows[0][2].ToString();
            lblAwayCaptain.Text = selectedAwayTeam.Rows[0][3].ToString();
        }
    }
}
