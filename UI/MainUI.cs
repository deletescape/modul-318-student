using MaterialSkin.Controls;
using System;
using SwissTransport;
using System.Windows.Forms;

namespace UI
{
    public partial class MainUI : MaterialForm
    {
        Transport transport;
        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            transport = new Transport();
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
            foreach(Connection conn in transport.GetConnections(txtAbfahrtsort.Text, txtZielort.Text).ConnectionList)
            {
                DateTime departure = DateTime.Parse(conn.From.Departure);
                DateTime arrival = DateTime.Parse(conn.To.Arrival);
                String[] item = {  conn.From.Platform, departure.ToString(), arrival.ToString(), conn.Duration };
                ListViewItem lvi = new ListViewItem(item);
                lstResult.Items.Add(lvi);
            }
        }
    }
}
