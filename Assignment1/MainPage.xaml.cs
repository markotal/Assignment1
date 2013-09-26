using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Assignment1
{
    public partial class MainPage : PhoneApplicationPage
    {
        private Boolean showSecurityDescription = false;
        private string textBlock1Text;
        private string textBlock2Text;
        private string textBlock3Text;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MainPage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            textBlock1Text = AppResources.TextBlockString1 + " ( " + AppResources.TextBlockString3 + " )";
            textBlock2Text = null;
            textBlock3Text = null;
            textBlock1_Tap(sender, null);

            ///anotherButton.Click += anotherButton_Click;
        }

        private void textBlock1_Tap(object sender, GestureEventArgs e)
        {
            if (showSecurityDescription == true)
            {
                textBlock1Text = AppResources.TextBlockString1 + " ( " + AppResources.TextBlockString2 + " )";
                textBlock2Text = AppResources.RadioButton1String2;
                textBlock3Text = AppResources.RadioButton2String2;
                showSecurityDescription = false;
            }
            else
            {
                textBlock1Text = AppResources.TextBlockString1 + " ( " + AppResources.TextBlockString3 + " )";
                textBlock2Text = null;
                textBlock3Text = null;
                showSecurityDescription = true;
            }

            textBlock1.Text = textBlock1Text;
            textBlock2.Text = textBlock2Text;
            textBlock3.Text = textBlock3Text;

            if (textBlock2.Text == null)
            {
                textBlock2.Height = 0;
            }
            else
            {
                textBlock2.Height = textBlock2.ActualHeight;
            }
            if (textBlock3.Text == null)
            {
                textBlock3.Height = 0;
            }
            else
            {
                textBlock3.Height = textBlock3.ActualHeight;
            }
        }

        private void button1_Tap(object sender, GestureEventArgs e)
        {
            if (textBox1.Text == "" || passwordBox1.Password == "")
            {
                MessageBox.Show(AppResources.LoginFailedString);
                passwordBox1.Password = "";
            }
            else
            {
                MessageBox.Show(AppResources.LoginOkString);
                passwordBox1.Password = "";
                textBox1.Text = "";
            }
        }
    }
}

