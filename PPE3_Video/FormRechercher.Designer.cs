namespace PPE3_Video
{
	partial class FormRechercher
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
			this.dgRecherche = new System.Windows.Forms.DataGridView();
			this.bsRecherche = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgRecherche)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsRecherche)).BeginInit();
			this.SuspendLayout();
			// 
			// dgRecherche
			// 
			this.dgRecherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgRecherche.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgRecherche.Location = new System.Drawing.Point(0, 0);
			this.dgRecherche.Name = "dgRecherche";
			this.dgRecherche.Size = new System.Drawing.Size(282, 259);
			this.dgRecherche.TabIndex = 0;
			// 
			// FormRechercher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 259);
			this.Controls.Add(this.dgRecherche);
			this.Name = "FormRechercher";
			this.Text = "FormRechercher";
			this.Load += new System.EventHandler(this.FormRechercher_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgRecherche)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsRecherche)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgRecherche;
		private System.Windows.Forms.BindingSource bsRecherche;
	}
}