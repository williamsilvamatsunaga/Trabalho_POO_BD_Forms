namespace CadastroFuncionario
{
    partial class FormListar
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgListar = new System.Windows.Forms.DataGridView();
            this.btListar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listar Funcionários";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgListar
            // 
            this.dgListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListar.Location = new System.Drawing.Point(16, 64);
            this.dgListar.Name = "dgListar";
            this.dgListar.Size = new System.Drawing.Size(772, 301);
            this.dgListar.TabIndex = 2;
            // 
            // btListar2
            // 
            this.btListar2.BackColor = System.Drawing.Color.Blue;
            this.btListar2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListar2.Location = new System.Drawing.Point(708, 395);
            this.btListar2.Name = "btListar2";
            this.btListar2.Size = new System.Drawing.Size(80, 30);
            this.btListar2.TabIndex = 13;
            this.btListar2.Text = "Listar";
            this.btListar2.UseVisualStyleBackColor = false;
            this.btListar2.Click += new System.EventHandler(this.btListar2_Click);
            // 
            // FormListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btListar2);
            this.Controls.Add(this.dgListar);
            this.Controls.Add(this.label1);
            this.Name = "FormListar";
            this.Text = "FormListar";
            ((System.ComponentModel.ISupportInitialize)(this.dgListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgListar;
        private System.Windows.Forms.Button btListar2;
    }
}