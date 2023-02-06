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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.btnLexico = new System.Windows.Forms.Button();
            this.dtgTokens = new System.Windows.Forms.DataGridView();
            this.btnSintactico = new System.Windows.Forms.Button();
            this.dtgSintactico = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtgSemantico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTokens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSintactico)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSemantico)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEditor
            // 
            this.txtEditor.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.ForeColor = System.Drawing.SystemColors.Info;
            this.txtEditor.Location = new System.Drawing.Point(0, 0);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(600, 500);
            this.txtEditor.TabIndex = 0;
            this.txtEditor.TabStop = false;
            this.txtEditor.Text = "#Ejemplo\r\n*int x=0\r\nif(x==0)\r\n$\r\nRun.Up(500,front)\r\nwait(1000)\r\nRun.Stop()\r\n$$";
            // 
            // btnLexico
            // 
            this.btnLexico.Location = new System.Drawing.Point(116, 20);
            this.btnLexico.Name = "btnLexico";
            this.btnLexico.Size = new System.Drawing.Size(110, 60);
            this.btnLexico.TabIndex = 1;
            this.btnLexico.Text = "Compilar Léxico";
            this.btnLexico.UseVisualStyleBackColor = true;
            this.btnLexico.Click += new System.EventHandler(this.btnLexico_Click);
            // 
            // dtgTokens
            // 
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
            this.dtgTokens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgTokens.Location = new System.Drawing.Point(0, 0);
            this.dtgTokens.Name = "dtgTokens";
            this.dtgTokens.ReadOnly = true;
            this.dtgTokens.RowHeadersVisible = false;
            this.dtgTokens.Size = new System.Drawing.Size(600, 200);
            this.dtgTokens.TabIndex = 2;
            // 
            // btnSintactico
            // 
            this.btnSintactico.Location = new System.Drawing.Point(397, 20);
            this.btnSintactico.Name = "btnSintactico";
            this.btnSintactico.Size = new System.Drawing.Size(110, 60);
            this.btnSintactico.TabIndex = 4;
            this.btnSintactico.Text = "Compilar Sintáctico";
            this.btnSintactico.UseVisualStyleBackColor = true;
            this.btnSintactico.Click += new System.EventHandler(this.btnSintactico_Click);
            // 
            // dtgSintactico
            // 
            this.dtgSintactico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSintactico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgSintactico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSintactico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgSintactico.Location = new System.Drawing.Point(0, 0);
            this.dtgSintactico.Name = "dtgSintactico";
            this.dtgSintactico.ReadOnly = true;
            this.dtgSintactico.RowHeadersVisible = false;
            this.dtgSintactico.Size = new System.Drawing.Size(600, 200);
            this.dtgSintactico.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTodo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLexico);
            this.panel1.Controls.Add(this.btnSintactico);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 600);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 100);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Compilar Semántico";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(1012, 20);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(110, 60);
            this.btnTodo.TabIndex = 6;
            this.btnTodo.Text = "Compilar Todo";
            this.btnTodo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(600, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 600);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 100);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtEditor);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 500);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgTokens);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 200);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtgSintactico);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 200);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(600, 200);
            this.panel6.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dtgSemantico);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 400);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(600, 200);
            this.panel7.TabIndex = 8;
            // 
            // dtgSemantico
            // 
            this.dtgSemantico.AllowUserToAddRows = false;
            this.dtgSemantico.AllowUserToDeleteRows = false;
            this.dtgSemantico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSemantico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgSemantico.Location = new System.Drawing.Point(0, 0);
            this.dtgSemantico.Name = "dtgSemantico";
            this.dtgSemantico.ReadOnly = true;
            this.dtgSemantico.Size = new System.Drawing.Size(600, 200);
            this.dtgSemantico.TabIndex = 0;
            // 
            // FrmCompilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCompilador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarSof";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTokens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSintactico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSemantico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.Button btnLexico;
        private System.Windows.Forms.DataGridView dtgTokens;
        private System.Windows.Forms.Button btnSintactico;
        private System.Windows.Forms.DataGridView dtgSintactico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dtgSemantico;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

