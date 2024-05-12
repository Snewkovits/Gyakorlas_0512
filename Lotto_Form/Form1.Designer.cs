namespace Lotto_Form
{
    partial class Form1
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
            this.sorsoltSzamok = new System.Windows.Forms.DataGridView();
            this.SzamBekeres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LekeresGomb = new System.Windows.Forms.Button();
            this.RogzitesGomb = new System.Windows.Forms.Button();
            this.BekuldesGomb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sorsoltSzamok)).BeginInit();
            this.SuspendLayout();
            // 
            // sorsoltSzamok
            // 
            this.sorsoltSzamok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sorsoltSzamok.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.sorsoltSzamok.Location = new System.Drawing.Point(264, 12);
            this.sorsoltSzamok.Name = "sorsoltSzamok";
            this.sorsoltSzamok.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sorsoltSzamok.Size = new System.Drawing.Size(549, 426);
            this.sorsoltSzamok.TabIndex = 0;
            // 
            // SzamBekeres
            // 
            this.SzamBekeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.SzamBekeres.Location = new System.Drawing.Point(12, 38);
            this.SzamBekeres.Name = "SzamBekeres";
            this.SzamBekeres.Size = new System.Drawing.Size(226, 27);
            this.SzamBekeres.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Írd be a számokat:";
            // 
            // LekeresGomb
            // 
            this.LekeresGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LekeresGomb.Location = new System.Drawing.Point(16, 389);
            this.LekeresGomb.Name = "LekeresGomb";
            this.LekeresGomb.Size = new System.Drawing.Size(105, 30);
            this.LekeresGomb.TabIndex = 3;
            this.LekeresGomb.Text = "Lekérés";
            this.LekeresGomb.UseVisualStyleBackColor = true;
            this.LekeresGomb.Click += new System.EventHandler(this.LekeresGomb_Click);
            // 
            // RogzitesGomb
            // 
            this.RogzitesGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.RogzitesGomb.Location = new System.Drawing.Point(127, 389);
            this.RogzitesGomb.Name = "RogzitesGomb";
            this.RogzitesGomb.Size = new System.Drawing.Size(111, 30);
            this.RogzitesGomb.TabIndex = 4;
            this.RogzitesGomb.Text = "Rögzítés";
            this.RogzitesGomb.UseVisualStyleBackColor = true;
            this.RogzitesGomb.Click += new System.EventHandler(this.RogzitesGomb_Click);
            // 
            // BekuldesGomb
            // 
            this.BekuldesGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BekuldesGomb.Location = new System.Drawing.Point(12, 71);
            this.BekuldesGomb.Name = "BekuldesGomb";
            this.BekuldesGomb.Size = new System.Drawing.Size(226, 34);
            this.BekuldesGomb.TabIndex = 5;
            this.BekuldesGomb.Text = "Beküldés";
            this.BekuldesGomb.UseVisualStyleBackColor = true;
            this.BekuldesGomb.Click += new System.EventHandler(this.BekuldesGomb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.BekuldesGomb);
            this.Controls.Add(this.RogzitesGomb);
            this.Controls.Add(this.LekeresGomb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SzamBekeres);
            this.Controls.Add(this.sorsoltSzamok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sorsoltSzamok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sorsoltSzamok;
        private System.Windows.Forms.TextBox SzamBekeres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LekeresGomb;
        private System.Windows.Forms.Button RogzitesGomb;
        private System.Windows.Forms.Button BekuldesGomb;
    }
}

