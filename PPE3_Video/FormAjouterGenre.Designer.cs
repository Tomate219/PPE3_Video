namespace PPE3_Video
{
    partial class FormAjouterGenre
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
            this.btValider = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.videoPPE3Groupe4DataSet = new PPE3_Video.VideoPPE3Groupe4DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPPE3Groupe4DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(84, 129);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(75, 23);
            this.btValider.TabIndex = 0;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(52, 70);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(136, 20);
            this.tbNom.TabIndex = 1;
            this.tbNom.Text = "Saisissez le nom du genre";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.videoPPE3Groupe4DataSet;
            this.bindingSource1.Position = 0;
            // 
            // videoPPE3Groupe4DataSet
            // 
            this.videoPPE3Groupe4DataSet.DataSetName = "VideoPPE3Groupe4DataSet";
            this.videoPPE3Groupe4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormAjouterGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 195);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.btValider);
            this.Name = "FormAjouterGenre";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ajouter un Genre";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPPE3Groupe4DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.BindingSource bindingSource1;
        private VideoPPE3Groupe4DataSet videoPPE3Groupe4DataSet;
    }
}