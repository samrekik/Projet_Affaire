using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projet_Affaire.GUI.GUIHOME
{
    public partial class HomeUserControl1 : UserControl
    {
        private static HomeUserControl1 _homeUserControl1;
        public HomeUserControl1()
        {
            InitializeComponent();
        }
        public static HomeUserControl1 Instance()
        {
            return _homeUserControl1 ?? (new HomeUserControl1());
        }
       
    }
}
