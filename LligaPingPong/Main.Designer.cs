namespace LligaPingPong
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.liga = new System.Windows.Forms.TabPage();
            this.Bmostrarpartidos = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lvPartits = new System.Windows.Forms.ListView();
            this.jugador1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.puntuacion1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jugador2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.puntuacion2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ganador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inputPunts2 = new System.Windows.Forms.TextBox();
            this.inputPunts1 = new System.Windows.Forms.TextBox();
            this.canviarResultat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.crearLliga = new System.Windows.Forms.Button();
            this.cargarLlista = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lvJugadors = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.points_player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.match_played = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inputPunts = new System.Windows.Forms.TextBox();
            this.inputPartits = new System.Windows.Forms.TextBox();
            this.inputNom = new System.Windows.Forms.TextBox();
            this.crearJugador = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.liga.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // liga
            // 
            this.liga.Controls.Add(this.Bmostrarpartidos);
            this.liga.Controls.Add(this.label9);
            this.liga.Controls.Add(this.lvPartits);
            this.liga.Controls.Add(this.inputPunts2);
            this.liga.Controls.Add(this.inputPunts1);
            this.liga.Controls.Add(this.canviarResultat);
            this.liga.Controls.Add(this.label7);
            this.liga.Controls.Add(this.label6);
            this.liga.Location = new System.Drawing.Point(4, 22);
            this.liga.Name = "liga";
            this.liga.Padding = new System.Windows.Forms.Padding(3);
            this.liga.Size = new System.Drawing.Size(969, 510);
            this.liga.TabIndex = 1;
            this.liga.Text = "Lliga";
            this.liga.UseVisualStyleBackColor = true;
            // 
            // Bmostrarpartidos
            // 
            this.Bmostrarpartidos.AutoSize = true;
            this.Bmostrarpartidos.Location = new System.Drawing.Point(746, 383);
            this.Bmostrarpartidos.Name = "Bmostrarpartidos";
            this.Bmostrarpartidos.Size = new System.Drawing.Size(206, 27);
            this.Bmostrarpartidos.TabIndex = 28;
            this.Bmostrarpartidos.Text = "veure partits";
            this.Bmostrarpartidos.UseVisualStyleBackColor = true;
            this.Bmostrarpartidos.Click += new System.EventHandler(this.veure_partits_click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Llista de resultats";
            // 
            // lvPartits
            // 
            this.lvPartits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.jugador1,
            this.puntuacion1,
            this.jugador2,
            this.puntuacion2,
            this.ganador,
            this.columnHeader1});
            this.lvPartits.Location = new System.Drawing.Point(14, 53);
            this.lvPartits.Margin = new System.Windows.Forms.Padding(2);
            this.lvPartits.Name = "lvPartits";
            this.lvPartits.Size = new System.Drawing.Size(704, 440);
            this.lvPartits.TabIndex = 25;
            this.lvPartits.UseCompatibleStateImageBehavior = false;
            this.lvPartits.View = System.Windows.Forms.View.Details;
            this.lvPartits.SelectedIndexChanged += new System.EventHandler(this.lvPartits_SelectedIndexChanged);
            // 
            // jugador1
            // 
            this.jugador1.Text = "jugador1";
            this.jugador1.Width = 130;
            // 
            // puntuacion1
            // 
            this.puntuacion1.DisplayIndex = 2;
            this.puntuacion1.Text = "punts 1";
            this.puntuacion1.Width = 179;
            // 
            // jugador2
            // 
            this.jugador2.DisplayIndex = 1;
            this.jugador2.Text = "jugador2";
            this.jugador2.Width = 136;
            // 
            // puntuacion2
            // 
            this.puntuacion2.Text = "punts 2";
            this.puntuacion2.Width = 167;
            // 
            // ganador
            // 
            this.ganador.Text = "GUANYADOR";
            this.ganador.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // inputPunts2
            // 
            this.inputPunts2.Location = new System.Drawing.Point(853, 178);
            this.inputPunts2.Name = "inputPunts2";
            this.inputPunts2.Size = new System.Drawing.Size(100, 20);
            this.inputPunts2.TabIndex = 15;
            // 
            // inputPunts1
            // 
            this.inputPunts1.Location = new System.Drawing.Point(853, 148);
            this.inputPunts1.Name = "inputPunts1";
            this.inputPunts1.Size = new System.Drawing.Size(100, 20);
            this.inputPunts1.TabIndex = 10;
            // 
            // canviarResultat
            // 
            this.canviarResultat.AutoSize = true;
            this.canviarResultat.Location = new System.Drawing.Point(746, 222);
            this.canviarResultat.Name = "canviarResultat";
            this.canviarResultat.Size = new System.Drawing.Size(206, 27);
            this.canviarResultat.TabIndex = 24;
            this.canviarResultat.Text = "canviar resultat";
            this.canviarResultat.UseVisualStyleBackColor = true;
            this.canviarResultat.Click += new System.EventHandler(this.canviar_resultat_click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(743, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Punts jugador2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(743, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Punts jugador1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.crearLliga);
            this.tabPage1.Controls.Add(this.cargarLlista);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.lvJugadors);
            this.tabPage1.Controls.Add(this.inputPunts);
            this.tabPage1.Controls.Add(this.inputPartits);
            this.tabPage1.Controls.Add(this.inputNom);
            this.tabPage1.Controls.Add(this.crearJugador);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(969, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Jugadors";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // crearLliga
            // 
            this.crearLliga.AutoSize = true;
            this.crearLliga.Location = new System.Drawing.Point(749, 403);
            this.crearLliga.Name = "crearLliga";
            this.crearLliga.Size = new System.Drawing.Size(207, 27);
            this.crearLliga.TabIndex = 28;
            this.crearLliga.Text = "crear lliga";
            this.crearLliga.UseVisualStyleBackColor = true;
            this.crearLliga.Click += new System.EventHandler(this.crear_lliga_click);
            // 
            // cargarLlista
            // 
            this.cargarLlista.AutoSize = true;
            this.cargarLlista.Location = new System.Drawing.Point(752, 359);
            this.cargarLlista.Name = "cargarLlista";
            this.cargarLlista.Size = new System.Drawing.Size(204, 28);
            this.cargarLlista.TabIndex = 21;
            this.cargarLlista.Text = "cargar llista";
            this.cargarLlista.UseVisualStyleBackColor = true;
            this.cargarLlista.Click += new System.EventHandler(this.cargar_llista_click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(285, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Llista jugadors";
            // 
            // lvJugadors
            // 
            this.lvJugadors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.points_player,
            this.match_played,
            this.columnHeader2});
            this.lvJugadors.Location = new System.Drawing.Point(6, 59);
            this.lvJugadors.Name = "lvJugadors";
            this.lvJugadors.Size = new System.Drawing.Size(722, 441);
            this.lvJugadors.TabIndex = 24;
            this.lvJugadors.UseCompatibleStateImageBehavior = false;
            this.lvJugadors.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "nom";
            this.name.Width = 146;
            // 
            // points_player
            // 
            this.points_player.Text = "punts";
            this.points_player.Width = 148;
            // 
            // match_played
            // 
            this.match_played.Text = "partits jugats";
            this.match_played.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 0;
            // 
            // inputPunts
            // 
            this.inputPunts.Location = new System.Drawing.Point(848, 265);
            this.inputPunts.Name = "inputPunts";
            this.inputPunts.Size = new System.Drawing.Size(109, 20);
            this.inputPunts.TabIndex = 18;
            // 
            // inputPartits
            // 
            this.inputPartits.Location = new System.Drawing.Point(848, 228);
            this.inputPartits.Name = "inputPartits";
            this.inputPartits.Size = new System.Drawing.Size(109, 20);
            this.inputPartits.TabIndex = 16;
            // 
            // inputNom
            // 
            this.inputNom.AccessibleName = "";
            this.inputNom.Location = new System.Drawing.Point(848, 187);
            this.inputNom.Name = "inputNom";
            this.inputNom.Size = new System.Drawing.Size(109, 20);
            this.inputNom.TabIndex = 0;
            // 
            // crearJugador
            // 
            this.crearJugador.AutoSize = true;
            this.crearJugador.Location = new System.Drawing.Point(752, 313);
            this.crearJugador.Name = "crearJugador";
            this.crearJugador.Size = new System.Drawing.Size(204, 28);
            this.crearJugador.TabIndex = 21;
            this.crearJugador.Text = "crear jugador";
            this.crearJugador.UseVisualStyleBackColor = true;
            this.crearJugador.Click += new System.EventHandler(this.crear_jugador_click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(747, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Punts";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(749, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "No. partits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(749, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(793, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Afegir jugador";
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.liga);
            this.tabControl1.Location = new System.Drawing.Point(14, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(977, 536);
            this.tabControl1.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1001, 551);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Ping Pong";
            this.liga.ResumeLayout(false);
            this.liga.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage liga;
        private System.Windows.Forms.Button Bmostrarpartidos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvPartits;
        private System.Windows.Forms.ColumnHeader jugador1;
        private System.Windows.Forms.ColumnHeader jugador2;
        private System.Windows.Forms.ColumnHeader puntuacion1;
        private System.Windows.Forms.ColumnHeader puntuacion2;
        private System.Windows.Forms.ColumnHeader ganador;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox inputPunts2;
        private System.Windows.Forms.TextBox inputPunts1;
        private System.Windows.Forms.Button canviarResultat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button crearLliga;
        private System.Windows.Forms.Button cargarLlista;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView lvJugadors;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader points_player;
        private System.Windows.Forms.ColumnHeader match_played;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox inputPunts;
        private System.Windows.Forms.TextBox inputPartits;
        private System.Windows.Forms.TextBox inputNom;
        private System.Windows.Forms.Button crearJugador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

