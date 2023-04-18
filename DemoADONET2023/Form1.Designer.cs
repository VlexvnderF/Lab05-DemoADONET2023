namespace DemoADONET2023
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
            this.dgvDemo = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvDemo2 = new System.Windows.Forms.DataGridView();
            this.btnListar2 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDemo
            // 
            this.dgvDemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemo.Location = new System.Drawing.Point(19, 124);
            this.dgvDemo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDemo.Name = "dgvDemo";
            this.dgvDemo.RowHeadersWidth = 51;
            this.dgvDemo.RowTemplate.Height = 24;
            this.dgvDemo.Size = new System.Drawing.Size(523, 122);
            this.dgvDemo.TabIndex = 0;
            this.dgvDemo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDemo_CellContentClick);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(19, 62);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(106, 42);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvDemo2
            // 
            this.dgvDemo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemo2.Location = new System.Drawing.Point(19, 287);
            this.dgvDemo2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDemo2.Name = "dgvDemo2";
            this.dgvDemo2.RowHeadersWidth = 51;
            this.dgvDemo2.RowTemplate.Height = 24;
            this.dgvDemo2.Size = new System.Drawing.Size(523, 122);
            this.dgvDemo2.TabIndex = 2;
            // 
            // btnListar2
            // 
            this.btnListar2.Location = new System.Drawing.Point(150, 62);
            this.btnListar2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListar2.Name = "btnListar2";
            this.btnListar2.Size = new System.Drawing.Size(106, 42);
            this.btnListar2.TabIndex = 3;
            this.btnListar2.Text = "Listar";
            this.btnListar2.UseVisualStyleBackColor = true;
            this.btnListar2.Click += new System.EventHandler(this.btnListar2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(421, 86);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(104, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 430);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnListar2);
            this.Controls.Add(this.dgvDemo2);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvDemo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDemo;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvDemo2;
        private System.Windows.Forms.Button btnListar2;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

