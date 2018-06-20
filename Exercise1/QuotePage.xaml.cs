using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Exercise1
{
    public partial class QuotePage : ContentPage
    {
       
        public QuotePage()
        {
            InitializeComponent();

            quoteLabel.Text = Quotes.GetNextQuote();
        }

        private void Handle_Clicked(object sender, System.EventArgs e)
        {
            quoteLabel.Text = Quotes.GetQuote(((Button)sender).Text);
        }
    }
}
