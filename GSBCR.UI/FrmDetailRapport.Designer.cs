﻿namespace GSBCR.UI
{
    partial class FrmDetailRapport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetailRapport));
            this.bsRapportVisite = new System.Windows.Forms.BindingSource(this.components);
            this.ucRapport1 = new GSBCR.UC.UcRapport();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapportVisite)).BeginInit();
            this.SuspendLayout();
            // 
            // ucRapport1
            // 
            this.ucRapport1.Location = new System.Drawing.Point(-1, 0);
            this.ucRapport1.Name = "ucRapport1";
            this.ucRapport1.rRapport = null;
            this.ucRapport1.Size = new System.Drawing.Size(517, 448);
            this.ucRapport1.TabIndex = 0;
            // 
            // FrmDetailRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 449);
            this.Controls.Add(this.ucRapport1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDetailRapport";
            this.Text = "GSBCR";
            ((System.ComponentModel.ISupportInitialize)(this.bsRapportVisite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsRapportVisite;
        private UC.UcRapport ucRapport1;
    }
}