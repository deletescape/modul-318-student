using MaterialSkin.Controls;
using System;
using SwissTransport;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Net;

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

        private void txtAbfahrtsort_TextChanged(object sender, EventArgs e)
        {
            AutocompletionUtils.TextChanged(txtAbfahrtsort, lstAutocompleteAbfahrt);
        }

        private void lstAutocompleteAbfahrt_DoubleClick(object sender, EventArgs e)
        {
            AutocompletionUtils.AutocompletionListDoubleClick(txtAbfahrtsort, lstAutocompleteAbfahrt);
        }

        private void lstAutocompleteAbfahrt_Leave(object sender, EventArgs e)
        {
            AutocompletionUtils.AutocompletionListLeave(lstAutocompleteAbfahrt);
        }

        private void txtAbfahrtsort_Leave(object sender, EventArgs e)
        {
            AutocompletionUtils.TextFieldLeave(lstAutocompleteAbfahrt);
        }

        private void txtZielort_TextChanged(object sender, EventArgs e)
        {
            AutocompletionUtils.TextChanged(txtZielort, lstAutocompleteZiel);
        }

        private void lstAutocompleteZiel_DoubleClick(object sender, EventArgs e)
        {
            AutocompletionUtils.AutocompletionListDoubleClick(txtZielort, lstAutocompleteZiel);
        }

        private void lstAutocompleteZiel_Leave(object sender, EventArgs e)
        {
            AutocompletionUtils.AutocompletionListLeave(lstAutocompleteZiel);
        }

        private void txtZielort_Leave(object sender, EventArgs e)
        {
            AutocompletionUtils.TextFieldLeave(lstAutocompleteZiel);
        }

        private void lstAutocompleteAbfahrt_KeyDown(object sender, KeyEventArgs e)
        {
            AutocompletionUtils.AutocompletionListKeyDown(txtAbfahrtsort, lstAutocompleteAbfahrt, e.KeyCode);
        }

        private void txtAbfahrtsort_KeyDown(object sender, KeyEventArgs e)
        {
            AutocompletionUtils.TextFieldKeyDown(txtAbfahrtsort, lstAutocompleteAbfahrt, e.KeyCode, btnSuchen);
        }

        private void txtZielort_KeyDown(object sender, KeyEventArgs e)
        {
            AutocompletionUtils.TextFieldKeyDown(txtZielort, lstAutocompleteZiel, e.KeyCode, btnSuchen);
        }

        private void lstAutocompleteZiel_KeyDown(object sender, KeyEventArgs e)
        {
            AutocompletionUtils.AutocompletionListKeyDown(txtZielort, lstAutocompleteZiel, e.KeyCode);
        }
    } 
}
