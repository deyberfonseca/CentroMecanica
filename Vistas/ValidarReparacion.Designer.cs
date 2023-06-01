
namespace Vistas
{
    partial class ValidarReparacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidarReparacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIng = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.MaskedTextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.cmbIdRep = new System.Windows.Forms.ComboBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.dgvPendientes = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.dtpFechaSalida);
            this.panel1.Controls.Add(this.lblFechaIng);
            this.panel1.Controls.Add(this.txtCosto);
            this.panel1.Controls.Add(this.lblCosto);
            this.panel1.Controls.Add(this.btnValidar);
            this.panel1.Controls.Add(this.cmbIdRep);
            this.panel1.Controls.Add(this.lblPlaca);
            this.panel1.Controls.Add(this.dgvPendientes);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 574);
            this.panel1.TabIndex = 0;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Enabled = false;
            this.dtpFechaSalida.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaSalida.Location = new System.Drawing.Point(135, 89);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(365, 27);
            this.dtpFechaSalida.TabIndex = 49;
            // 
            // lblFechaIng
            // 
            this.lblFechaIng.AutoSize = true;
            this.lblFechaIng.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIng.Location = new System.Drawing.Point(43, 89);
            this.lblFechaIng.Name = "lblFechaIng";
            this.lblFechaIng.Size = new System.Drawing.Size(86, 23);
            this.lblFechaIng.TabIndex = 48;
            this.lblFechaIng.Text = "Fecha :";
            this.lblFechaIng.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCosto
            // 
            this.txtCosto.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCosto.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(577, 333);
            this.txtCosto.Mask = "999999999";
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(165, 31);
            this.txtCosto.TabIndex = 47;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(487, 339);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(84, 23);
            this.lblCosto.TabIndex = 46;
            this.lblCosto.Text = "Costo:";
            // 
            // btnValidar
            // 
            this.btnValidar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnValidar.FlatAppearance.BorderSize = 2;
            this.btnValidar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnValidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Image = ((System.Drawing.Image)(resources.GetObject("btnValidar.Image")));
            this.btnValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidar.Location = new System.Drawing.Point(518, 491);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(140, 51);
            this.btnValidar.TabIndex = 45;
            this.btnValidar.Text = "Validar";
            this.btnValidar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // cmbIdRep
            // 
            this.cmbIdRep.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmbIdRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdRep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbIdRep.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdRep.FormattingEnabled = true;
            this.cmbIdRep.IntegralHeight = false;
            this.cmbIdRep.Location = new System.Drawing.Point(207, 333);
            this.cmbIdRep.MaxDropDownItems = 10;
            this.cmbIdRep.Name = "cmbIdRep";
            this.cmbIdRep.Size = new System.Drawing.Size(86, 31);
            this.cmbIdRep.TabIndex = 44;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(34, 335);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(178, 23);
            this.lblPlaca.TabIndex = 43;
            this.lblPlaca.Text = "Id Reparación: ";
            this.lblPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvPendientes
            // 
            this.dgvPendientes.AllowUserToAddRows = false;
            this.dgvPendientes.AllowUserToDeleteRows = false;
            this.dgvPendientes.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendientes.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPendientes.Location = new System.Drawing.Point(12, 122);
            this.dgvPendientes.Name = "dgvPendientes";
            this.dgvPendientes.ReadOnly = true;
            this.dgvPendientes.Size = new System.Drawing.Size(928, 205);
            this.dgvPendientes.TabIndex = 25;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegresar.FlatAppearance.BorderSize = 2;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(723, 491);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(141, 51);
            this.btnRegresar.TabIndex = 23;
            this.btnRegresar.Text = "Regresar ";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(333, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(281, 30);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Validar Reparacion";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(68, 333);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(373, 241);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(949, 473);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // ValidarReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 574);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ValidarReparacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValidarReparacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPendientes;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbIdRep;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.MaskedTextBox txtCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label lblFechaIng;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}