namespace ADO.form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSqlServe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListarSQL = new System.Windows.Forms.Button();
            this.listProdutos = new System.Windows.Forms.ListBox();
            this.btnListarDataSet = new System.Windows.Forms.Button();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSqlServe
            // 
            this.btnSqlServe.Location = new System.Drawing.Point(12, 49);
            this.btnSqlServe.Name = "btnSqlServe";
            this.btnSqlServe.Size = new System.Drawing.Size(161, 49);
            this.btnSqlServe.TabIndex = 0;
            this.btnSqlServe.Text = "Conexao";
            this.btnSqlServe.UseVisualStyleBackColor = true;
            this.btnSqlServe.Click += new System.EventHandler(this.btnSqlServe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADO.NET";
            // 
            // btnListarSQL
            // 
            this.btnListarSQL.Location = new System.Drawing.Point(12, 154);
            this.btnListarSQL.Name = "btnListarSQL";
            this.btnListarSQL.Size = new System.Drawing.Size(161, 49);
            this.btnListarSQL.TabIndex = 2;
            this.btnListarSQL.Text = "Listar Data Reader";
            this.btnListarSQL.UseVisualStyleBackColor = true;
            this.btnListarSQL.Click += new System.EventHandler(this.btnListarSQL_Click);
            // 
            // listProdutos
            // 
            this.listProdutos.FormattingEnabled = true;
            this.listProdutos.ItemHeight = 15;
            this.listProdutos.Location = new System.Drawing.Point(201, 49);
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(379, 169);
            this.listProdutos.TabIndex = 3;
            // 
            // btnListarDataSet
            // 
            this.btnListarDataSet.Location = new System.Drawing.Point(12, 307);
            this.btnListarDataSet.Name = "btnListarDataSet";
            this.btnListarDataSet.Size = new System.Drawing.Size(161, 49);
            this.btnListarDataSet.TabIndex = 5;
            this.btnListarDataSet.Text = "Listar Data Set";
            this.btnListarDataSet.UseVisualStyleBackColor = true;
            this.btnListarDataSet.Click += new System.EventHandler(this.btnListarDataSet_Click);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(201, 265);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.RowTemplate.Height = 25;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(379, 152);
            this.dataGridViewProdutos.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 509);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.btnListarDataSet);
            this.Controls.Add(this.listProdutos);
            this.Controls.Add(this.btnListarSQL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSqlServe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSqlServe;
        private Label label1;
        private Button btnListarSQL;
        private ListBox listProdutos;
        private Button btnListarDataSet;
        private DataGridView dataGridViewProdutos;
    }
}