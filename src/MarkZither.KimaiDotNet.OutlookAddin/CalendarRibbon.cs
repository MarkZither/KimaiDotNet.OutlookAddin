using Microsoft.Office.Tools.Ribbon;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarkZither.KimaiDotNet.OutlookAddin
{
    public partial class CalendarRibbon
    {
        private void CalendarRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnApiCredentials_Click(object sender, RibbonControlEventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.ShowDialog();
        }
    }
}
