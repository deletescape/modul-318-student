using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using System.Windows.Forms;
using SwissTransport;
using System.Net;

namespace UI
{
    class AutocompletionUtils
    {
        static Transport transport = new Transport();

        public static void TextChanged(MaterialSingleLineTextField textField, ListBox autocompleteList)
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

        public static void AutocompletionListDoubleClick(MaterialSingleLineTextField textField, ListBox autocompleteList)
        {
            if (autocompleteList.SelectedItem != null)
            {
                textField.Text = autocompleteList.SelectedItem.ToString();
                autocompleteList.Visible = false;
            }
        }

        public static void AutocompletionListLeave(ListBox autocompleteList)
        {
            autocompleteList.Visible = false;
        }

        public static void TextFieldLeave(ListBox autocompleteList)
        {
            if (!autocompleteList.Focused)
            {
                autocompleteList.Visible = false;
            }
        }

        public static void AutocompletionListKeyDown(MaterialSingleLineTextField textField, ListBox autocompleteList, Keys keyCode)
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

        public static void TextFieldKeyDown(MaterialSingleLineTextField textField, ListBox autocompleteList, Keys keyCode, Button acceptButton)
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
    }
}
