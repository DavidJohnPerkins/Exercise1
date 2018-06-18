using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Exercise1
{
    public partial class QuotePage : ContentPage
    {
        private const int numQuotes = 3;
        private int quotePtr = 0;
        private string[] quotes = new string[numQuotes];

        public QuotePage()
        {
            InitializeComponent();
            quotes[0] = "Look deep into nature, and then you will understand everything better.";
            quotes[1] = "You can't blame gravity for falling in love.";
            quotes[2] = "Lottie thinks this is cool!";
            quoteLabel.Text = quotes[0];
        }

        private void Handle_Clicked(object sender, System.EventArgs e)
        {
            quotePtr += 1;
            if (quotePtr == numQuotes){
                quotePtr = 0;
            }
            quoteLabel.Text = quotes[quotePtr];
        }
    }
}
