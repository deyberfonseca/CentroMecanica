
namespace Vistas
{
    partial class RegistroMecanicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroMecanicos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSegundoAp = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtPrimerAp = new System.Windows.Forms.TextBox();
            this.btnRegistrarMecanicos = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.MaskedTextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.lblSegundoApellido);
            this.panel1.Controls.Add(this.txtSegundoAp);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.lblPrimerApellido);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.txtPrimerAp);
            this.panel1.Controls.Add(this.btnRegistrarMecanicos);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 462);
            this.panel1.TabIndex = 0;
            // 
            // txtSegundoAp
            // 
            this.txtSegundoAp.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtSegundoAp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSegundoAp.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoAp.Location = new System.Drawing.Point(419, 264);
            this.txtSegundoAp.Name = "txtSegundoAp";
            this.txtSegundoAp.Size = new System.Drawing.Size(251, 31);
            this.txtSegundoAp.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(419, 153);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(251, 31);
            this.txtNombre.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(419, 318);
            this.txtTelefono.Mask = "999999999";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(251, 31);
            this.txtTelefono.TabIndex = 10;
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegresar.FlatAppearance.BorderSize = 2;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(534, 395);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(152, 51);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar ";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(178, 321);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(125, 23);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Teléfono: ";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(178, 265);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(220, 23);
            this.lblSegundoApellido.TabIndex = 7;
            this.lblSegundoApellido.Text = "Segundo Apellido: ";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(177, 210);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(204, 23);
            this.lblPrimerApellido.TabIndex = 6;
            this.lblPrimerApellido.Text = "Primer Apellido: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(177, 156);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(106, 23);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(177, 107);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(184, 23);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Identificación: ";
            // 
            // txtPrimerAp
            // 
            this.txtPrimerAp.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtPrimerAp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrimerAp.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerAp.Location = new System.Drawing.Point(419, 207);
            this.txtPrimerAp.Name = "txtPrimerAp";
            this.txtPrimerAp.Size = new System.Drawing.Size(251, 31);
            this.txtPrimerAp.TabIndex = 3;
            // 
            // btnRegistrarMecanicos
            // 
            this.btnRegistrarMecanicos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrarMecanicos.FlatAppearance.BorderSize = 2;
            this.btnRegistrarMecanicos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrarMecanicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegistrarMecanicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarMecanicos.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarMecanicos.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarMecanicos.Image")));
            this.btnRegistrarMecanicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarMecanicos.Location = new System.Drawing.Point(261, 395);
            this.btnRegistrarMecanicos.Name = "btnRegistrarMecanicos";
            this.btnRegistrarMecanicos.Size = new System.Drawing.Size(160, 51);
            this.btnRegistrarMecanicos.TabIndex = 2;
            this.btnRegistrarMecanicos.Text = "  Registrar ";
            this.btnRegistrarMecanicos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarMecanicos.UseVisualStyleBackColor = true;
            this.btnRegistrarMecanicos.Click += new System.EventHandler(this.btnRegistrarMecanicos_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(419, 104);
            this.txtId.Mask = "999999999";
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(251, 31);
            this.txtId.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(234, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(317, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de Mecanicos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-11, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 290);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // RegistroMecanicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 462);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroMecanicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroMecanicos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPrimerAp;
        private System.Windows.Forms.Button btnRegistrarMecanicos;
        private System.Windows.Forms.MaskedTextBox txtId;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtSegundoAp;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}