using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Projet_Affaire.Properties;
namespace Projet_Affaire.Code
{
   public static class MessageCollection
    {
        //Message
        public static void ShowEmptyDataMessage()
        {
            MessageBox.Show(Resources.EmptyMessageText, Resources.EmptyMessageCaption, 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        //Dialog
    }
}

