
namespace Projet_Affaire.GUI.GUIHOME
{
    partial class HomeUserControl1
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddVent = new System.Windows.Forms.Button();
            this.btnAddAchat = new System.Windows.Forms.Button();
            this.btnAddProj = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnAddFr = new System.Windows.Forms.Button();
            this.btnAddClt = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCompany = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelWelcom = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.btnAddVent);
            this.panel1.Controls.Add(this.btnAddAchat);
            this.panel1.Controls.Add(this.btnAddProj);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.btnAddFr);
            this.panel1.Controls.Add(this.btnAddClt);
            this.panel1.Controls.Add(this.btnAddCat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 548);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 63);
            this.panel1.TabIndex = 0;
            // 
            // btnAddVent
            // 
            this.btnAddVent.Image = global::Projet_Affaire.Properties.Resources.icons8_sell_32px;
            this.btnAddVent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddVent.Location = new System.Drawing.Point(954, 17);
            this.btnAddVent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddVent.Name = "btnAddVent";
            this.btnAddVent.Padding = new System.Windows.Forms.Padding(1);
            this.btnAddVent.Size = new System.Drawing.Size(141, 40);
            this.btnAddVent.TabIndex = 1;
            this.btnAddVent.Text = "Add Vente   ";
            this.btnAddVent.UseVisualStyleBackColor = true;
            // 
            // btnAddAchat
            // 
            this.btnAddAchat.Image = global::Projet_Affaire.Properties.Resources.icons8_buying_32px;
            this.btnAddAchat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAchat.Location = new System.Drawing.Point(796, 17);
            this.btnAddAchat.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAchat.Name = "btnAddAchat";
            this.btnAddAchat.Padding = new System.Windows.Forms.Padding(1);
            this.btnAddAchat.Size = new System.Drawing.Size(141, 40);
            this.btnAddAchat.TabIndex = 1;
            this.btnAddAchat.Text = "Add Achat    ";
            this.btnAddAchat.UseVisualStyleBackColor = true;
            // 
            // btnAddProj
            // 
            this.btnAddProj.Image = global::Projet_Affaire.Properties.Resources.icons8_project_management_32px;
            this.btnAddProj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProj.Location = new System.Drawing.Point(638, 17);
            this.btnAddProj.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProj.Name = "btnAddProj";
            this.btnAddProj.Padding = new System.Windows.Forms.Padding(1);
            this.btnAddProj.Size = new System.Drawing.Size(141, 40);
            this.btnAddProj.TabIndex = 1;
            this.btnAddProj.Text = "Add Projet    ";
            this.btnAddProj.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = global::Projet_Affaire.Properties.Resources.icons8_users_32px;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUser.Location = new System.Drawing.Point(480, 17);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Padding = new System.Windows.Forms.Padding(1);
            this.btnAddUser.Size = new System.Drawing.Size(141, 40);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add Users    ";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnAddFr
            // 
            this.btnAddFr.Image = global::Projet_Affaire.Properties.Resources.icons8_user_engagement_male_32px;
            this.btnAddFr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFr.Location = new System.Drawing.Point(322, 17);
            this.btnAddFr.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFr.Name = "btnAddFr";
            this.btnAddFr.Padding = new System.Windows.Forms.Padding(1);
            this.btnAddFr.Size = new System.Drawing.Size(141, 40);
            this.btnAddFr.TabIndex = 1;
            this.btnAddFr.Text = "Add Fourni.    ";
            this.btnAddFr.UseVisualStyleBackColor = true;
            // 
            // btnAddClt
            // 
            this.btnAddClt.Image = global::Projet_Affaire.Properties.Resources.icons8_administrator_male_32px;
            this.btnAddClt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddClt.Location = new System.Drawing.Point(164, 17);
            this.btnAddClt.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddClt.Name = "btnAddClt";
            this.btnAddClt.Padding = new System.Windows.Forms.Padding(1);
            this.btnAddClt.Size = new System.Drawing.Size(141, 40);
            this.btnAddClt.TabIndex = 1;
            this.btnAddClt.Text = "Add Client    ";
            this.btnAddClt.UseVisualStyleBackColor = true;
            // 
            // btnAddCat
            // 
            this.btnAddCat.Image = global::Projet_Affaire.Properties.Resources.icons8_categorize_32px;
            this.btnAddCat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCat.Location = new System.Drawing.Point(6, 17);
            this.btnAddCat.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Padding = new System.Windows.Forms.Padding(1);
            this.btnAddCat.Size = new System.Drawing.Size(141, 40);
            this.btnAddCat.TabIndex = 1;
            this.btnAddCat.Text = "Add Cat.           ";
            this.btnAddCat.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelCompany);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(11, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 100);
            this.panel2.TabIndex = 1;
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCompany.Location = new System.Drawing.Point(153, 37);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(69, 25);
            this.labelCompany.TabIndex = 2;
            this.labelCompany.Text = "S A M";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Projet_Affaire.Properties.Resources.icons8_buying_32px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelWelcom
            // 
            this.labelWelcom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcom.AutoSize = true;
            this.labelWelcom.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWelcom.Location = new System.Drawing.Point(857, 59);
            this.labelWelcom.Name = "labelWelcom";
            this.labelWelcom.Size = new System.Drawing.Size(154, 25);
            this.labelWelcom.TabIndex = 3;
            this.labelWelcom.Text = "Welcome Sami";
            // 
            // HomeUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelWelcom);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeUserControl1";
            this.Size = new System.Drawing.Size(1184, 611);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddVent;
        private System.Windows.Forms.Button btnAddAchat;
        private System.Windows.Forms.Button btnAddProj;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnAddFr;
        private System.Windows.Forms.Button btnAddClt;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelWelcom;
    }
}
