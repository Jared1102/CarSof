namespace PresentacionCarSof
{
    partial class FrmCompilador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.btnLexico = new System.Windows.Forms.Button();
            this.dtgTokens = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTokens)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEditor
            // 
            this.txtEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditor.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEditor.ForeColor = System.Drawing.SystemColors.Info;
            this.txtEditor.Location = new System.Drawing.Point(35, 28);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(450, 629);
            this.txtEditor.TabIndex = 0;
            this.txtEditor.TabStop = false;
            // 
            // btnLexico
            // 
            this.btnLexico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLexico.AutoSize = true;
            this.btnLexico.Location = new System.Drawing.Point(527, 611);
            this.btnLexico.Name = "btnLexico";
            this.btnLexico.Size = new System.Drawing.Size(106, 46);
            this.btnLexico.TabIndex = 1;
            this.btnLexico.Text = "Léxico";
            this.btnLexico.UseVisualStyleBackColor = true;
            this.btnLexico.Click += new System.EventHandler(this.btnLexico_Click);
            // 
            // dtgTokens
            // 
            this.dtgTokens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgTokens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTokens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTokens.Location = new System.Drawing.Point(682, 28);
            this.dtgTokens.Name = "dtgTokens";
            this.dtgTokens.ReadOnly = true;
            this.dtgTokens.RowHeadersVisible = false;
            this.dtgTokens.Size = new System.Drawing.Size(450, 629);
            this.dtgTokens.TabIndex = 2;
            // 
            // FrmCompilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1169, 692);
            this.Controls.Add(this.dtgTokens);
            this.Controls.Add(this.btnLexico);
            this.Controls.Add(this.txtEditor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCompilador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarSof";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTokens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.Button btnLexico;
        private System.Windows.Forms.DataGridView dtgTokens;
    }
}

