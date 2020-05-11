using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Covid19TR
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DayPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = DayPicker.Items[DayPicker.SelectedIndex];
            Covid19ViewModel model = new Covid19ViewModel(name);
            TestedText.Text = model.CovidDay.tested;
            InfectedText.Text = model.CovidDay.infected;
            DeceasedText.Text = model.CovidDay.deceased;
            RecoveredText.Text = model.CovidDay.recovered;
        }
    }
}
