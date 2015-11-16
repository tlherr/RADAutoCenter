using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCenter
{
    public partial class WelcomeForm : Form
    {

        private delegate void CloseDelegate();

        //The type of form to be displayed as the splash screen.
        private static WelcomeForm splashForm;

        static public void ShowSplashScreen()
        {
            // Make sure it is only launched once.

            if (splashForm != null)
                return;
            Thread thread = new Thread(new ThreadStart(WelcomeForm.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
      
            Thread.Sleep(5000);
        }


        public WelcomeForm()
        {
            InitializeComponent();
        }

        static private void ShowForm()
        {
            splashForm = new WelcomeForm();
            Application.Run(splashForm);
        }

        static public void CloseForm()
        {
            splashForm.Invoke(new CloseDelegate(WelcomeForm.CloseFormInternal));
        }

        static private void CloseFormInternal()
        {
            splashForm.Close();
        }
    }
}
