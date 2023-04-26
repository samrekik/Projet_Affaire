using Projet_Affaire.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_Affaire.GUI;
namespace Projet_Affaire
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            classManager = new ClassManager(this);
            //load homePage
            classManager.LoadPAge(GUI.GUIHOME.HomeUserControl1.Instance());
        }
        private readonly ClassManager classManager;
        #region event
        private void btnHome_Click(object sender, EventArgs e)
        {
            classManager.LoadPAge(GUI.GUIHOME.HomeUserControl1.Instance());
        }
        #endregion
    }
}
