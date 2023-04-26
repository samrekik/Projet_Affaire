using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace Projet_Affaire.Code
{
  
   public class ClassManager
    {
        private readonly Main main;

        public ClassManager(Main main)
        {
            this.main = main;
        }
        public void LoadPAge(UserControl PageUserControl)
        {
            //load old page
            var oldPage = main.panelMain.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldPage !=null )
            {
                main.panelMain.Controls.Remove(oldPage );
                oldPage.Dispose();
            }
            //load new page
            PageUserControl.Dock = DockStyle.Fill;
            main.panelMain.Controls.Add(PageUserControl);
            
        }
    }
}
