using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobilna
{
    public partial class MainPage : ContentPage
    {
        string[] Quotes = { "Dzień dobry", "Good morning", "Buenos dias" };
        int i = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void ChangeQuote(object sender, EventArgs e)
        {
            i = (i + 1) % Quotes.Length;
            Quote.Text = Quotes[i];
        }
    }
}
