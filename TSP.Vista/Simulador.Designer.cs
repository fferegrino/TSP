namespace TSP.Vista
{
    partial class Simulador
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulador));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelGeneraciones = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelMejorValor = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelVariaciones = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbPoblacionSize = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tbNumeroCiudades = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tbPMutacion = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbMaxGeneraciones = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.tbVariacion = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.tbDelay = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bGeneraAleatorios = new System.Windows.Forms.ToolStripButton();
            this.bCorrerAlgoritmo = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbMejorValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mapArea = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelGeneraciones,
            this.labelMejorValor,
            this.labelVariaciones});
            this.statusStrip1.Location = new System.Drawing.Point(0, 538);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1124, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelGeneraciones
            // 
            this.labelGeneraciones.Name = "labelGeneraciones";
            this.labelGeneraciones.Size = new System.Drawing.Size(90, 17);
            this.labelGeneraciones.Text = "Generaciones: 0";
            // 
            // labelMejorValor
            // 
            this.labelMejorValor.Name = "labelMejorValor";
            this.labelMejorValor.Size = new System.Drawing.Size(79, 17);
            this.labelMejorValor.Text = "Mejor valor: 0";
            // 
            // labelVariaciones
            // 
            this.labelVariaciones.Name = "labelVariaciones";
            this.labelVariaciones.Size = new System.Drawing.Size(76, 17);
            this.labelVariaciones.Text = "Variaciones 0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tbPoblacionSize,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.tbNumeroCiudades,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.tbPMutacion,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tbMaxGeneraciones,
            this.toolStripSeparator4,
            this.toolStripLabel5,
            this.tbVariacion,
            this.toolStripSeparator5,
            this.toolStripLabel6,
            this.tbDelay,
            this.toolStripSeparator6,
            this.bGeneraAleatorios,
            this.bCorrerAlgoritmo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1124, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabel2.Text = "Población";
            // 
            // tbPoblacionSize
            // 
            this.tbPoblacionSize.AutoSize = false;
            this.tbPoblacionSize.Name = "tbPoblacionSize";
            this.tbPoblacionSize.Size = new System.Drawing.Size(40, 25);
            this.tbPoblacionSize.Text = "200";

            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(117, 22);
            this.toolStripLabel3.Text = "Número de ciudades";
            // 
            // tbNumeroCiudades
            // 
            this.tbNumeroCiudades.AutoSize = false;
            this.tbNumeroCiudades.Name = "tbNumeroCiudades";
            this.tbNumeroCiudades.Size = new System.Drawing.Size(30, 25);
            this.tbNumeroCiudades.Text = "20";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(71, 22);
            this.toolStripLabel4.Text = "% Mutación";
            // 
            // tbPMutacion
            // 
            this.tbPMutacion.AutoSize = false;
            this.tbPMutacion.Name = "tbPMutacion";
            this.tbPMutacion.Size = new System.Drawing.Size(25, 25);
            this.tbPMutacion.Text = "50";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(106, 22);
            this.toolStripLabel1.Text = "Max. Generaciones";
            // 
            // tbMaxGeneraciones
            // 
            this.tbMaxGeneraciones.AutoSize = false;
            this.tbMaxGeneraciones.Name = "tbMaxGeneraciones";
            this.tbMaxGeneraciones.Size = new System.Drawing.Size(50, 25);
            this.tbMaxGeneraciones.Text = "1500";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel5.Text = "Variedad";
            // 
            // tbVariacion
            // 
            this.tbVariacion.AutoSize = false;
            this.tbVariacion.Name = "tbVariacion";
            this.tbVariacion.Size = new System.Drawing.Size(25, 25);
            this.tbVariacion.Text = "10";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel6.Text = "Delay";
            // 
            // tbDelay
            // 
            this.tbDelay.AutoSize = false;
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(25, 25);
            this.tbDelay.Text = "50";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bGeneraAleatorios
            // 
            this.bGeneraAleatorios.Image = global::TSP.Vista.Properties.Resources.BuildSolution_104;
            this.bGeneraAleatorios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bGeneraAleatorios.Name = "bGeneraAleatorios";
            this.bGeneraAleatorios.Size = new System.Drawing.Size(118, 22);
            this.bGeneraAleatorios.Text = "Generar ciudades";
            this.bGeneraAleatorios.Click += new System.EventHandler(this.bGeneraAleatorios_Click);
            // 
            // bCorrerAlgoritmo
            // 
            this.bCorrerAlgoritmo.Image = global::TSP.Vista.Properties.Resources.startwithoutdebugging_6556;
            this.bCorrerAlgoritmo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bCorrerAlgoritmo.Name = "bCorrerAlgoritmo";
            this.bCorrerAlgoritmo.Size = new System.Drawing.Size(114, 22);
            this.bCorrerAlgoritmo.Text = "Iniciar algoritmo";
            this.bCorrerAlgoritmo.Click += new System.EventHandler(this.bIniciarSimulacion_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.tbMejorValor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(979, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 507);
            this.panel1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(4, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 420);
            this.listBox1.TabIndex = 5;
            // 
            // tbMejorValor
            // 
            this.tbMejorValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMejorValor.Location = new System.Drawing.Point(6, 484);
            this.tbMejorValor.Name = "tbMejorValor";
            this.tbMejorValor.Size = new System.Drawing.Size(136, 20);
            this.tbMejorValor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mejor valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mejor ruta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resultados";
            // 
            // mapArea
            // 
            this.mapArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapArea.Location = new System.Drawing.Point(0, 28);
            this.mapArea.Name = "mapArea";
            this.mapArea.Size = new System.Drawing.Size(973, 507);
            this.mapArea.TabIndex = 1;
            this.mapArea.TabStop = false;
            this.mapArea.Paint += new System.Windows.Forms.PaintEventHandler(this.mapArea_Paint);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mapArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Simulador";
            this.Text = "Problema del agente viajero";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mapArea;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelGeneraciones;
        private System.Windows.Forms.ToolStripStatusLabel labelMejorValor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbMaxGeneraciones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tbPoblacionSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox tbNumeroCiudades;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox tbPMutacion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox tbVariacion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton bGeneraAleatorios;
        private System.Windows.Forms.ToolStripStatusLabel labelVariaciones;
        private System.Windows.Forms.ToolStripButton bCorrerAlgoritmo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbMejorValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripTextBox tbDelay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

