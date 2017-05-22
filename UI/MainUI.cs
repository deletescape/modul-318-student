using MaterialSkin.Controls;
using System;
using SwissTransport;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Net;
using MaterialSkin;

namespace UI
{
    public partial class MainUI : MaterialForm
    {
        Transport transport;
        public MainUI()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Pink700, Accent.Pink400, TextShade.WHITE);
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            transport = new Transport();
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
            if (txtAbfahrtsort.Text != "" && txtZielort.Text != "")
            {
                try
                {
                    foreach (Connection conn in transport.GetConnections(txtAbfahrtsort.Text, txtZielort.Text).ConnectionList)
                    {
                        DateTime departure = DateTime.Parse(conn.From.Departure);
                        DateTime arrival = DateTime.Parse(conn.To.Arrival);
                        String[] item = { conn.From.Platform, departure.ToString(), arrival.ToString(), conn.Duration };
                        ListViewItem lvi = new ListViewItem(item);
                        lstResult.Items.Add(lvi);
                    }
                }
                catch (WebException ex)
                {
                    MessageBox.Show($"Zu viele Anfragen an den Server\nBitte kurz warten befor sie fortfahren\n\n{ex}");
                }
            }
        }

        private void btnSuchen2_Click(object sender, EventArgs e)
        {
            lstResult2.Items.Clear();
            if (txtStation.Text != "")
            {
                try
                {
                    StationBoardRoot sbr = transport.GetStationBoard(txtStation.Text);
                    foreach (StationBoard sb in sbr.Entries)
                    {
                        String[] item = { sb.Name, sb.To, sb.Stop.Departure.ToString(), sb.Operator };
                        ListViewItem lvi = new ListViewItem(item);
                        lstResult2.Items.Add(lvi);
                    }
                }
                catch (WebException ex)
                {
                    MessageBox.Show($"Zu viele Anfragen an den Server\nBitte kurz warten befor sie fortfahren\n\n{ex}");
                }
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

        private void txtStation_KeyDown(object sender, KeyEventArgs e)
        {
            AutocompletionUtils.TextFieldKeyDown(txtStation, lstAutocompleteStation, e.KeyCode, btnSuchen2);
        }

        private void lstAutocompleteStation_KeyDown(object sender, KeyEventArgs e)
        {
            AutocompletionUtils.AutocompletionListKeyDown(txtStation, lstAutocompleteStation, e.KeyCode);
        }

        private void lstAutocompleteStation_DoubleClick(object sender, EventArgs e)
        {
            AutocompletionUtils.AutocompletionListDoubleClick(txtStation, lstAutocompleteStation);
        }

        private void txtStation_Leave(object sender, EventArgs e)
        {
            AutocompletionUtils.TextFieldLeave(lstAutocompleteStation);
        }

        private void lstAutocompleteStation_Leave(object sender, EventArgs e)
        {
            AutocompletionUtils.AutocompletionListLeave(lstAutocompleteStation);
        }

        private void txtStation_TextChanged(object sender, EventArgs e)
        {
            AutocompletionUtils.TextChanged(txtStation, lstAutocompleteStation);
        }
    } 
}
