namespace JuegoPOO
{
    public partial class Form1 : Form
    {
        Personaje jugador;
        Personaje enemigo;
        Random random = new Random();
        int nivelActual = 0;
        bool esBosFinal = false;
        bool juegoTerminado = false;
        private readonly Dictionary<string, string> _imagenesPersonaje = new()
    {
        { "Guerrero", @"imagenes\guerrero.png" },
        { "Mago",     @"imagenes\mago.png" },
        { "Arquero",  @"imagenes\arquero.png" },
        {  "117",   @"imagenes\117.png"   }
    };
        private readonly string _imagenEnemigo = @"imagenes\enemigo.png";
        private readonly string _imagenBoss = @"imagenes\boss.png";

        private void CargarImagenPersonaje(string nombrePersonaje)
        {
            try
            {
                if (_imagenesPersonaje.TryGetValue(nombrePersonaje, out string rutaRelativa))
                {
                    
                    string rutaBase = AppDomain.CurrentDomain.BaseDirectory;
                   
                    string rutaCompleta = Path.Combine(rutaBase, rutaRelativa);

                    if (File.Exists(rutaCompleta))
                    {
                        picPersonaje.Image = Image.FromFile(rutaCompleta);
                        AppendLog($"Imagen de {nombrePersonaje} cargada correctamente");
                    }
                    else
                    {
                        picPersonaje.Image = null;
                        AppendLog($"No se encontró la imagen en: {rutaCompleta}");
                    }
                }
            }
            catch (Exception ex)
            {
                AppendLog($"Error al cargar imagen: {ex.Message}");
            }
        }

        private void CargarImagenEnemigo()
        {
            try
            {
                string rutaBase = AppDomain.CurrentDomain.BaseDirectory;
                string rutaRelativa = esBosFinal ? _imagenBoss : _imagenEnemigo;
                string rutaCompleta = Path.Combine(rutaBase, rutaRelativa);

                if (File.Exists(rutaCompleta))
                {
                    picEnemigo.Image = Image.FromFile(rutaCompleta);
                    string tipoEnemigo = esBosFinal ? "BOSS Final" : "enemigo";
                    AppendLog($"Imagen del {tipoEnemigo} cargada correctamente");
                }
                
            }
            catch (Exception ex)
            {
                AppendLog($"Error al cargar imagen del enemigo: {ex.Message}");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void DesbloquearHeroe()
        {
            
            if (!cmbPersonaje.Items.Contains("Heroe"))
            {
                cmbPersonaje.Items.Add("Heroe");
                AppendLog("Héroe desbloqueado y disponible en el selector de personajes");
                MessageBox.Show("¡Se desbloqueó el Héroe! Ahora puedes seleccionarlo.", "Desbloqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void HabilitarBotonesAtaque(bool habilitar)
        {
            btnAtacar.Enabled = habilitar;
            btnEspecial.Enabled = habilitar;
            btnCurar.Enabled = habilitar;
        }

        private void ActualizarVidas()
        {
            
            if (jugador != null)
            {
                int vidaJugador = Math.Max(0, jugador.Vida);
                lblVidaJugador.Text = $"Vida del Jugador: {vidaJugador}";
                if (pbVidaJugador.Maximum <= 0) pbVidaJugador.Maximum = vidaJugador > 0 ? vidaJugador : 1;
                pbVidaJugador.Value = Math.Min(pbVidaJugador.Maximum, vidaJugador);
            }

            if (enemigo != null)
            {
                int vidaEnemigo = Math.Max(0, enemigo.Vida);
                lblVidaEnemigo.Text = $"Vida del Enemigo: {vidaEnemigo}";
                if (pbVidaEnemigo.Maximum <= 0) pbVidaEnemigo.Maximum = vidaEnemigo > 0 ? vidaEnemigo : 1;
                pbVidaEnemigo.Value = Math.Min(pbVidaEnemigo.Maximum, vidaEnemigo);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            
            if (cmbPersonaje.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un tipo de personaje.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            switch (cmbPersonaje.Text)
            {
                case "Guerrero":
                    jugador = new Guerrero(); 
                    break;
                case "Mago":
                    jugador = new Mago();      
                    break;
                case "Arquero":
                    jugador = new Arquero();   
                    break;
                case "Heroe":        
                    jugador = new Heroe();
                    break;
            }

            
            if (nivelActual < 5)
            {
                
                esBosFinal = false;
                int vidaEnemigo = 100 + (nivelActual * 30);      // Ej: Nivel 0 = 100, Nivel 4 = 220
                int atqueEnemigo = 20 + (nivelActual * 5);       // Ej: Nivel 0 = 20, Nivel 4 = 40
                enemigo = new Personaje($"Enemigo Nivel {nivelActual + 1}", vidaEnemigo, atqueEnemigo);
            }
            else if (nivelActual == 5)
            {
                
                esBosFinal = true;
                enemigo = new Boss();  
            }

            
            lblJugador.Text = jugador.Nombre;
            pbVidaJugador.Maximum = jugador.Vida;
            pbVidaJugador.Value = jugador.Vida;
            pbVidaEnemigo.Maximum = enemigo.Vida;
            pbVidaEnemigo.Value = enemigo.Vida;


            ActualizarVidas();
            CargarImagenPersonaje(jugador.Nombre);
            CargarImagenEnemigo();
            HabilitarBotonesAtaque(true);
            juegoTerminado = false;
            txtLog.Clear();
        }
        private void btnAtacar_Click(object sender, EventArgs e)
        {
            
            int daño = jugador.Atacar();
            enemigo.Vida -= daño;
            AppendLog($"Jugador hizo {daño} de daño");
            int contra = enemigo.Atacar();
            jugador.Vida -= contra;
            AppendLog($"Enemigo hizo {contra} de daño");
            pbVidaJugador.Value = Math.Max(0, jugador.Vida);
            pbVidaEnemigo.Value = Math.Max(0, enemigo.Vida);
            ActualizarVidas();
        }

        private void btnEspecial_Click(object sender, EventArgs e)
        {
            int daño = jugador.Atacar() * 2;
            enemigo.Vida -= daño;
            AppendLog($"Jugador hizo {daño} de daño con ataque especial");
            int contra = enemigo.Atacar();
            jugador.Vida -= contra;
            AppendLog($"Enemigo hizo {contra} de daño");


            pbVidaJugador.Value = Math.Max(0, jugador.Vida);
            pbVidaEnemigo.Value = Math.Max(0, enemigo.Vida);
            ActualizarVidas();
        }

        private void btnCurar_Click(object sender, EventArgs e)
        {
            int curacion = random.Next(20, 40); 
            jugador.Vida = Math.Min(jugador.Vida + curacion, pbVidaJugador.Maximum);
            AppendLog($"Jugador se curó {curacion} de vida");
            pbVidaJugador.Value = jugador.Vida;
            ActualizarVidas();
        }


        private void txtLog_TextChanged(object sender, EventArgs e)
        {
            if (juegoTerminado)
                return;
            if (enemigo.Vida <= 0)
            {
                juegoTerminado = true;

                if (esBosFinal)
                {
                    
                    MessageBox.Show("¡¡GANASTE!! ¡¡VENCISTE AL BOSS FINAL!!");
                    nivelActual = 0;          
                    pbProgreso.Value = 0;     
                    lblProgreso.Text = "Progreso: 0/5";
                }
                else
                {
                    
                    nivelActual++;
                    pbProgreso.Value = nivelActual;
                    lblProgreso.Text = $"Progreso: {nivelActual}/5";

                    if (nivelActual < 5)
                    {
                        
                        MessageBox.Show($"¡Victoria! Avanzaste al nivel {nivelActual + 1}");
                    }
                    else if (nivelActual == 5)
                    {
                        
                        DesbloquearHeroe();
                        MessageBox.Show("¡Has llegado al BOSS FINAL! ¡Prepárate!");
                    }
                    
                }

               
                HabilitarBotonesAtaque(false);
            }
          
            else if (jugador.Vida <= 0)
            {
                juegoTerminado = true;

                MessageBox.Show("¡Perdiste! El juego ha terminado.");
                HabilitarBotonesAtaque(false);
            }
        }

        private void lblJugador_Click(object sender, EventArgs e)
        {
            cmbPersonaje.Text = jugador.Nombre;
        }

        private void AppendLog(string message)
        {
            string line = $" {message}{Environment.NewLine}";
            txtLog.AppendText(line);
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }
    }
}
