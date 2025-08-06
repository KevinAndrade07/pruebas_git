
namespace ProjectUni
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
            this.tblPanelHeader = new System.Windows.Forms.TableLayoutPanel();
            this.tblPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.llbNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNumIdentificacion = new System.Windows.Forms.Label();
            this.txtNumIdentificacion = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tblPanel1.SuspendLayout();
            this.tblPanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPanelHeader
            // 
            this.tblPanelHeader.ColumnCount = 1;
            this.tblPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblPanelHeader.Location = new System.Drawing.Point(0, 0);
            this.tblPanelHeader.Name = "tblPanelHeader";
            this.tblPanelHeader.RowCount = 1;
            this.tblPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelHeader.Size = new System.Drawing.Size(690, 27);
            this.tblPanelHeader.TabIndex = 0;
            // 
            // tblPanel1
            // 
            this.tblPanel1.ColumnCount = 2;
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel1.Controls.Add(this.tblPanelPrincipal, 0, 0);
            this.tblPanel1.Controls.Add(this.dataGridView, 1, 0);
            this.tblPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel1.Location = new System.Drawing.Point(0, 27);
            this.tblPanel1.Name = "tblPanel1";
            this.tblPanel1.RowCount = 1;
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 372F));
            this.tblPanel1.Size = new System.Drawing.Size(690, 372);
            this.tblPanel1.TabIndex = 1;
            // 
            // tblPanelPrincipal
            // 
            this.tblPanelPrincipal.ColumnCount = 2;
            this.tblPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelPrincipal.Controls.Add(this.llbNombre, 0, 0);
            this.tblPanelPrincipal.Controls.Add(this.txtNombre, 1, 0);
            this.tblPanelPrincipal.Controls.Add(this.lblNumIdentificacion, 0, 1);
            this.tblPanelPrincipal.Controls.Add(this.txtNumIdentificacion, 1, 1);
            this.tblPanelPrincipal.Controls.Add(this.lblCorreo, 0, 2);
            this.tblPanelPrincipal.Controls.Add(this.txtCorreo, 1, 2);
            this.tblPanelPrincipal.Controls.Add(this.btnRegistrar, 0, 3);
            this.tblPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelPrincipal.Location = new System.Drawing.Point(3, 3);
            this.tblPanelPrincipal.Name = "tblPanelPrincipal";
            this.tblPanelPrincipal.RowCount = 4;
            this.tblPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPanelPrincipal.Size = new System.Drawing.Size(339, 366);
            this.tblPanelPrincipal.TabIndex = 0;
            this.tblPanelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.tblPanelPrincipal_Paint);
            // 
            // llbNombre
            // 
            this.llbNombre.AutoSize = true;
            this.llbNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.llbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbNombre.Location = new System.Drawing.Point(3, 0);
            this.llbNombre.Name = "llbNombre";
            this.llbNombre.Size = new System.Drawing.Size(76, 20);
            this.llbNombre.TabIndex = 0;
            this.llbNombre.Text = "Nombre:";
            this.llbNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.llbNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(172, 3);
            this.txtNombre.MaxLength = 200;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNumIdentificacion
            // 
            this.lblNumIdentificacion.AutoSize = true;
            this.lblNumIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumIdentificacion.Location = new System.Drawing.Point(3, 91);
            this.lblNumIdentificacion.Name = "lblNumIdentificacion";
            this.lblNumIdentificacion.Size = new System.Drawing.Size(122, 40);
            this.lblNumIdentificacion.TabIndex = 2;
            this.lblNumIdentificacion.Text = "Número de Identificación:";
            // 
            // txtNumIdentificacion
            // 
            this.txtNumIdentificacion.Location = new System.Drawing.Point(172, 94);
            this.txtNumIdentificacion.MaxLength = 12;
            this.txtNumIdentificacion.Name = "txtNumIdentificacion";
            this.txtNumIdentificacion.Size = new System.Drawing.Size(164, 20);
            this.txtNumIdentificacion.TabIndex = 3;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(3, 182);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(161, 20);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "Correo electrónico:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(172, 185);
            this.txtCorreo.MaxLength = 200;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(164, 20);
            this.txtCorreo.TabIndex = 5;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(348, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(339, 366);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(3, 276);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(103, 34);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(690, 399);
            this.Controls.Add(this.tblPanel1);
            this.Controls.Add(this.tblPanelHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tblPanel1.ResumeLayout(false);
            this.tblPanelPrincipal.ResumeLayout(false);
            this.tblPanelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPanelHeader;
        private System.Windows.Forms.TableLayoutPanel tblPanel1;
        private System.Windows.Forms.TableLayoutPanel tblPanelPrincipal;
        private System.Windows.Forms.Label llbNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNumIdentificacion;
        private System.Windows.Forms.TextBox txtNumIdentificacion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

