using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using WritersWeb.View;

namespace WritersWeb.Confirmation
{
    public class Alert
    {
        public static new eDesktopAlertColor TypeColor { get; set; }

        // We can get access to desktop alert window before its displayed by handling this event
        public static void  Message(string label, string type)
        {
            string text = "<b>"+ label +"</b>";

            // checking type of validation to display
            if (type == "info"){
                TypeColor = eDesktopAlertColor.DarkBlue;
            }else if (type == "success"){
                TypeColor = eDesktopAlertColor.Green;
            }
            else if (type == "error"){
                TypeColor = eDesktopAlertColor.DarkRed;
            }
            else if (type == "warning"){
                TypeColor = eDesktopAlertColor.Orange;
            }
            else{
                TypeColor = eDesktopAlertColor.DarkRed;
            }

            long _RunningAlertId = 0;
            int _duration = 10;

            eAlertPosition position = (eAlertPosition)(eAlertPosition.TopRight);
            DesktopAlert.Show(text, "\uf006", eSymbolSet.Awesome, Color.Empty, TypeColor, position, _duration, _RunningAlertId, null);
        }
        public static void Confirmation(String text)
        {
            frmConfirmation show = new frmConfirmation();
            show.lblMessage.Text = text;
            show.ShowDialog();
        }
    }
}
