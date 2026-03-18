namespace JuegoPOO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCrear = new Button();
            btnAtacar = new Button();
            btnEspecial = new Button();
            lblJugador = new Label();
            lblVidaJugador = new Label();
            lblVidaEnemigo = new Label();
            cmbPersonaje = new ComboBox();
            pbVidaEnemigo = new ProgressBar();
            pbVidaJugador = new ProgressBar();
            txtLog = new TextBox();
            btnCurar = new Button();
            picPersonaje = new PictureBox();
            picEnemigo = new PictureBox();
            pbProgreso = new ProgressBar();
            lblProgreso = new Label();
            ((System.ComponentModel.ISupportInitialize)picPersonaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEnemigo).BeginInit();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCrear.Location = new Point(10, 495);
            btnCrear.Margin = new Padding(3, 2, 3, 2);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(82, 22);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear Personaje";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnAtacar
            // 
            btnAtacar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAtacar.Location = new Point(10, 521);
            btnAtacar.Margin = new Padding(3, 2, 3, 2);
            btnAtacar.Name = "btnAtacar";
            btnAtacar.Size = new Size(82, 22);
            btnAtacar.TabIndex = 1;
            btnAtacar.Text = "Atacar";
            btnAtacar.UseVisualStyleBackColor = true;
            btnAtacar.Click += btnAtacar_Click;
            // 
            // btnEspecial
            // 
            btnEspecial.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEspecial.Location = new Point(10, 547);
            btnEspecial.Margin = new Padding(3, 2, 3, 2);
            btnEspecial.Name = "btnEspecial";
            btnEspecial.Size = new Size(82, 22);
            btnEspecial.TabIndex = 2;
            btnEspecial.Text = "Ataque Especial";
            btnEspecial.UseVisualStyleBackColor = true;
            btnEspecial.Click += btnEspecial_Click;
            // 
            // lblJugador
            // 
            lblJugador.AutoSize = true;
            lblJugador.BackColor = SystemColors.WindowFrame;
            lblJugador.Location = new Point(10, 7);
            lblJugador.Name = "lblJugador";
            lblJugador.Size = new Size(49, 15);
            lblJugador.TabIndex = 3;
            lblJugador.Text = "Jugador";
            lblJugador.Click += lblJugador_Click;
            // 
            // lblVidaJugador
            // 
            lblVidaJugador.AutoSize = true;
            lblVidaJugador.BackColor = SystemColors.WindowFrame;
            lblVidaJugador.Location = new Point(10, 41);
            lblVidaJugador.Name = "lblVidaJugador";
            lblVidaJugador.Size = new Size(94, 15);
            lblVidaJugador.TabIndex = 4;
            lblVidaJugador.Text = "Vida del Jugador";
            // 
            // lblVidaEnemigo
            // 
            lblVidaEnemigo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblVidaEnemigo.AutoSize = true;
            lblVidaEnemigo.BackColor = SystemColors.WindowFrame;
            lblVidaEnemigo.Location = new Point(1035, 34);
            lblVidaEnemigo.Name = "lblVidaEnemigo";
            lblVidaEnemigo.Size = new Size(99, 15);
            lblVidaEnemigo.TabIndex = 5;
            lblVidaEnemigo.Text = "Vida del Enemigo";
            // 
            // cmbPersonaje
            // 
            cmbPersonaje.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbPersonaje.BackColor = SystemColors.WindowFrame;
            cmbPersonaje.FormattingEnabled = true;
            cmbPersonaje.Items.AddRange(new object[] { "Guerrero", "Mago", "Arquero" });
            cmbPersonaje.Location = new Point(10, 469);
            cmbPersonaje.Margin = new Padding(3, 2, 3, 2);
            cmbPersonaje.Name = "cmbPersonaje";
            cmbPersonaje.Size = new Size(133, 23);
            cmbPersonaje.TabIndex = 6;
            // 
            // pbVidaEnemigo
            // 
            pbVidaEnemigo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbVidaEnemigo.BackColor = SystemColors.WindowFrame;
            pbVidaEnemigo.Location = new Point(897, 52);
            pbVidaEnemigo.Margin = new Padding(3, 2, 3, 2);
            pbVidaEnemigo.Name = "pbVidaEnemigo";
            pbVidaEnemigo.Size = new Size(248, 22);
            pbVidaEnemigo.TabIndex = 7;
            // 
            // pbVidaJugador
            // 
            pbVidaJugador.BackColor = SystemColors.WindowFrame;
            pbVidaJugador.Location = new Point(10, 58);
            pbVidaJugador.Margin = new Padding(3, 2, 3, 2);
            pbVidaJugador.Name = "pbVidaJugador";
            pbVidaJugador.Size = new Size(223, 22);
            pbVidaJugador.TabIndex = 8;
            // 
            // txtLog
            // 
            txtLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLog.BackColor = SystemColors.WindowFrame;
            txtLog.Location = new Point(206, 547);
            txtLog.Margin = new Padding(3, 2, 3, 2);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(768, 49);
            txtLog.TabIndex = 9;
            txtLog.TextChanged += txtLog_TextChanged;
            // 
            // btnCurar
            // 
            btnCurar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCurar.Location = new Point(10, 574);
            btnCurar.Margin = new Padding(3, 2, 3, 2);
            btnCurar.Name = "btnCurar";
            btnCurar.Size = new Size(82, 22);
            btnCurar.TabIndex = 10;
            btnCurar.Text = "Curar";
            btnCurar.UseVisualStyleBackColor = true;
            btnCurar.Click += btnCurar_Click;
            // 
            // picPersonaje
            // 
            picPersonaje.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picPersonaje.BackColor = Color.Transparent;
            picPersonaje.Location = new Point(10, 85);
            picPersonaje.Margin = new Padding(3, 2, 3, 2);
            picPersonaje.Name = "picPersonaje";
            picPersonaje.Size = new Size(223, 362);
            picPersonaje.SizeMode = PictureBoxSizeMode.Zoom;
            picPersonaje.TabIndex = 11;
            picPersonaje.TabStop = false;
            // 
            // picEnemigo
            // 
            picEnemigo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picEnemigo.BackColor = Color.Transparent;
            picEnemigo.Location = new Point(897, 85);
            picEnemigo.Margin = new Padding(3, 2, 3, 2);
            picEnemigo.Name = "picEnemigo";
            picEnemigo.Size = new Size(248, 362);
            picEnemigo.SizeMode = PictureBoxSizeMode.Zoom;
            picEnemigo.TabIndex = 12;
            picEnemigo.TabStop = false;
            // 
            // pbProgreso
            // 
            pbProgreso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pbProgreso.BackColor = SystemColors.WindowFrame;
            pbProgreso.Location = new Point(206, 18);
            pbProgreso.Margin = new Padding(3, 2, 3, 2);
            pbProgreso.Maximum = 5;
            pbProgreso.Name = "pbProgreso";
            pbProgreso.Size = new Size(768, 22);
            pbProgreso.TabIndex = 13;
            // 
            // lblProgreso
            // 
            lblProgreso.AutoSize = true;
            lblProgreso.BackColor = SystemColors.WindowFrame;
            lblProgreso.Location = new Point(206, 1);
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(77, 15);
            lblProgreso.TabIndex = 14;
            lblProgreso.Text = "Progreso: 0/5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1175, 605);
            Controls.Add(picPersonaje);
            Controls.Add(picEnemigo);
            Controls.Add(pbProgreso);
            Controls.Add(lblProgreso);
            Controls.Add(txtLog);
            Controls.Add(pbVidaJugador);
            Controls.Add(pbVidaEnemigo);
            Controls.Add(cmbPersonaje);
            Controls.Add(lblVidaEnemigo);
            Controls.Add(lblVidaJugador);
            Controls.Add(lblJugador);
            Controls.Add(btnEspecial);
            Controls.Add(btnAtacar);
            Controls.Add(btnCrear);
            Controls.Add(btnCurar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(800, 420);
            Name = "Form1";
            Text = "JuegoPOO";
            TransparencyKey = Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)picPersonaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEnemigo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCrear;
        private Button btnAtacar;
        private Button btnEspecial;
        private Label lblJugador;
        private Label lblVidaJugador;
        private Label lblVidaEnemigo;
        private ComboBox cmbPersonaje;
        private ProgressBar pbVidaEnemigo;
        private ProgressBar pbVidaJugador;
        private TextBox txtLog;
        private Button btnCurar;
        private PictureBox picPersonaje;
        private PictureBox picEnemigo;
        private ProgressBar pbProgreso;
        private Label lblProgreso;
    }
}
