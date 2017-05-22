using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using System.Windows.Forms;
using SwissTransport;
using System.Net;
using System.Diagnostics;

namespace UI
{
    class AutocompletionUtils
    {
        static ITransport transport = new Transport();

        internal static void TextChanged(MaterialSingleLineTextField textField, ListBox autocompleteList)
        {
            if (textField.Text.Length >= 3)
            {
                autocompleteList.Visible = true;
                List<Station> stationList;
                try
                {
                    stationList = transport.GetStations(textField.Text).StationList;
                }
                catch (WebException ex)
                {
                    return;
                }
                autocompleteList.Items.Clear();
                foreach (Station station in stationList.GetRange(0, Math.Min(stationList.Count, 4)))
                {
                    autocompleteList.Items.Add(station.Name);
                }

            }
            else if (autocompleteList.Visible)
            {
                autocompleteList.Visible = false;
            }
        }

        internal static void AutocompletionListDoubleClick(MaterialSingleLineTextField textField, ListBox autocompleteList)
        {
            if (autocompleteList.SelectedItem != null)
            {
                textField.Text = autocompleteList.SelectedItem.ToString();
                autocompleteList.Visible = false;
            }
        }

        internal static void AutocompletionListLeave(ListBox autocompleteList)
        {
            autocompleteList.Visible = false;
        }

        internal static void TextFieldLeave(ListBox autocompleteList)
        {
            if (!autocompleteList.Focused)
            {
                autocompleteList.Visible = false;
            }
        }

        internal static void AutocompletionListKeyDown(MaterialSingleLineTextField textField, ListBox autocompleteList, Keys keyCode)
        {
            if(keyCode == Keys.Enter)
            {
                if (autocompleteList.SelectedItem != null)
                {
                    textField.Text = autocompleteList.SelectedItem.ToString();
                    autocompleteList.Visible = false;
                }
                textField.Focus();
            } else if(keyCode == Keys.Up && autocompleteList.SelectedIndex == 0)
            {
                textField.Focus();
            }
        }

        internal static void TextFieldKeyDown(MaterialSingleLineTextField textField, ListBox autocompleteList, Keys keyCode, Button acceptButton)
        {
            if(keyCode == Keys.Down && textField.Text.Length >= 3)
            {
                autocompleteList.Visible = true;
                autocompleteList.Focus();
                autocompleteList.SelectedIndex = 0;
            }
            // Workaround um mit Enter ein Button zu betätigen aber im
            // Autocomplete Dropdown auf Enter reagieren zu können
            else if(keyCode == Keys.Enter)
            {
                acceptButton.PerformClick();
            }
        }
        
        internal static void OpenStationInGmaps(String station)
        {
            var stationList = transport.GetStations(station).StationList;
            if (stationList.Count > 0)
            {
                var coordinates = stationList[0].Coordinate;
                string googleUrl = "https://www.google.ch/maps/?q=loc:" + coordinates.XCoordinate + "+" + coordinates.YCoordinate;
                Process.Start(googleUrl);
            }
        }
    }
}
