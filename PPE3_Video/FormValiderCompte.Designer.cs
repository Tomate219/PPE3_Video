namespace PPE3_Video
{
    partial class FormValiderCompte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbBoxMailClient = new System.Windows.Forms.ComboBox();
            this.videoPPE3Groupe4DataSet = new PPE3_Video.VideoPPE3Groupe4DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.clientTableAdapter = new PPE3_Video.VideoPPE3Groupe4DataSetTableAdapters.clientTableAdapter();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtBoxIdClient = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoPPE3Groupe4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbBoxMailClient
            // 
            this.cbBoxMailClient.DataSource = this.clientBindingSource1;
            this.cbBoxMailClient.DisplayMember = "emailClient";
            this.cbBoxMailClient.FormattingEnabled = true;
            this.cbBoxMailClient.Location = new System.Drawing.Point(12, 44);
            this.cbBoxMailClient.Name = "cbBoxMailClient";
            this.cbBoxMailClient.Size = new System.Drawing.Size(179, 21);
            this.cbBoxMailClient.TabIndex = 0;
            this.cbBoxMailClient.ValueMember = "idClient";
            this.cbBoxMailClient.SelectedValueChanged += new System.EventHandler(this.cbBoxMailClient_SelectedValueChanged);
            // 
            // videoPPE3Groupe4DataSet
            // 
            this.videoPPE3Groupe4DataSet.DataSetName = "VideoPPE3Groupe4DataSet";
            this.videoPPE3Groupe4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indiquez l\'Email du client :";
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(8, 246);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(109, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(123, 246);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(102, 23);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // txtBoxIdClient
            // 
            this.txtBoxIdClient.Location = new System.Drawing.Point(12, 96);
            this.txtBoxIdClient.Name = "txtBoxIdClient";
            this.txtBoxIdClient.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIdClient.TabIndex = 4;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.videoPPE3Groupe4DataSet;
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "client";
            this.clientBindingSource1.DataSource = this.videoPPE3Groupe4DataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // FormValiderCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 313);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtBoxIdClient);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBoxMailClient);
            this.Name = "FormValiderCompte";
            this.Text = "Formulaire de validation d\'un compte";
            ((System.ComponentModel.ISupportInitialize)(this.videoPPE3Groupe4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxMailClient;
        private System.Windows.Forms.Label label1;
        private VideoPPE3Groupe4DataSet videoPPE3Groupe4DataSet;
        private VideoPPE3Groupe4DataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox txtBoxIdClient;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}