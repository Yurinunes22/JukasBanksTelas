namespace PrjJukasTelas
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
            btnCriarAcesso = new Button();
            btnVoltar = new Button();
            txtGenero = new TextBox();
            txtDataNasc = new TextBox();
            txtCelular = new TextBox();
            txtConfirmaSenha = new TextBox();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            txtNomeCliente = new TextBox();
            txtCpf = new TextBox();
            lblLogin = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCriarAcesso
            // 
            btnCriarAcesso.Location = new Point(53, 480);
            btnCriarAcesso.Name = "btnCriarAcesso";
            btnCriarAcesso.Size = new Size(179, 41);
            btnCriarAcesso.TabIndex = 27;
            btnCriarAcesso.Text = "Criar Acesso";
            btnCriarAcesso.UseVisualStyleBackColor = true;
            btnCriarAcesso.Click += btnCriarAcesso_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Arial Rounded MT Bold", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltar.Location = new Point(537, 480);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(221, 41);
            btnVoltar.TabIndex = 25;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // txtGenero
            // 
            txtGenero.BackColor = SystemColors.ControlLightLight;
            txtGenero.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtGenero.Location = new Point(537, 208);
            txtGenero.MaxLength = 11;
            txtGenero.Name = "txtGenero";
            txtGenero.PlaceholderText = "Genero";
            txtGenero.Size = new Size(217, 38);
            txtGenero.TabIndex = 24;
            // 
            // txtDataNasc
            // 
            txtDataNasc.BackColor = SystemColors.ControlLightLight;
            txtDataNasc.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtDataNasc.Location = new Point(537, 138);
            txtDataNasc.MaxLength = 11;
            txtDataNasc.Name = "txtDataNasc";
            txtDataNasc.PlaceholderText = "Data de Nascimento";
            txtDataNasc.Size = new Size(217, 38);
            txtDataNasc.TabIndex = 23;
            // 
            // txtCelular
            // 
            txtCelular.BackColor = SystemColors.ControlLight;
            txtCelular.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelular.Location = new Point(537, 73);
            txtCelular.MaxLength = 11;
            txtCelular.Name = "txtCelular";
            txtCelular.PlaceholderText = "Celular";
            txtCelular.Size = new Size(217, 38);
            txtCelular.TabIndex = 22;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.BackColor = SystemColors.ControlLightLight;
            txtConfirmaSenha.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmaSenha.Location = new Point(32, 340);
            txtConfirmaSenha.MaxLength = 6;
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.PlaceholderText = "Confirma Senha";
            txtConfirmaSenha.Size = new Size(217, 38);
            txtConfirmaSenha.TabIndex = 20;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.ControlLightLight;
            txtSenha.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(32, 277);
            txtSenha.MaxLength = 6;
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(217, 38);
            txtSenha.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLightLight;
            txtEmail.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(32, 208);
            txtEmail.MaxLength = 11;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail";
            txtEmail.Size = new Size(217, 38);
            txtEmail.TabIndex = 18;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BackColor = SystemColors.ControlLightLight;
            txtNomeCliente.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCliente.Location = new Point(32, 138);
            txtNomeCliente.MaxLength = 11;
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.PlaceholderText = "Nome Completo";
            txtNomeCliente.Size = new Size(217, 38);
            txtNomeCliente.TabIndex = 17;
            // 
            // txtCpf
            // 
            txtCpf.BackColor = SystemColors.ControlLightLight;
            txtCpf.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpf.Location = new Point(32, 73);
            txtCpf.MaxLength = 11;
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "000.000.000-00";
            txtCpf.Size = new Size(217, 38);
            txtCpf.TabIndex = 16;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial Rounded MT Bold", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(32, 22);
            lblLogin.Margin = new Padding(5, 0, 5, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(217, 27);
            lblLogin.TabIndex = 21;
            lblLogin.Text = "Crie Seu Cadastro";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(486, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 293);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 545);
            Controls.Add(btnCriarAcesso);
            Controls.Add(btnVoltar);
            Controls.Add(txtGenero);
            Controls.Add(txtDataNasc);
            Controls.Add(txtCelular);
            Controls.Add(txtConfirmaSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNomeCliente);
            Controls.Add(txtCpf);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "TelaMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCriarAcesso;
        private Button btnVoltar;
        private TextBox txtGenero;
        private TextBox txtDataNasc;
        private TextBox txtCelular;
        private TextBox txtConfirmaSenha;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private TextBox txtNomeCliente;
        private TextBox txtCpf;
        private Label lblLogin;
        private PictureBox pictureBox1;
    }
}