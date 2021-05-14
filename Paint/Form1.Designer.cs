
namespace Paint
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Coords = new System.Windows.Forms.Label();
            this.btn_Rectangulo = new System.Windows.Forms.Button();
            this.btn_Elipse = new System.Windows.Forms.Button();
            this.btn_Linea = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Rojo = new System.Windows.Forms.Button();
            this.btn_Verde = new System.Windows.Forms.Button();
            this.btn_Azul = new System.Windows.Forms.Button();
            this.btn_Morado = new System.Windows.Forms.Button();
            this.btn_Blanco = new System.Windows.Forms.Button();
            this.btn_Amarillo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Coords
            // 
            this.lbl_Coords.AutoSize = true;
            this.lbl_Coords.Location = new System.Drawing.Point(31, 36);
            this.lbl_Coords.Name = "lbl_Coords";
            this.lbl_Coords.Size = new System.Drawing.Size(0, 13);
            this.lbl_Coords.TabIndex = 0;
            // 
            // btn_Rectangulo
            // 
            this.btn_Rectangulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Rectangulo.BackgroundImage")));
            this.btn_Rectangulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Rectangulo.Location = new System.Drawing.Point(95, 12);
            this.btn_Rectangulo.Name = "btn_Rectangulo";
            this.btn_Rectangulo.Size = new System.Drawing.Size(121, 72);
            this.btn_Rectangulo.TabIndex = 1;
            this.btn_Rectangulo.UseVisualStyleBackColor = true;
            this.btn_Rectangulo.Click += new System.EventHandler(this.btn_Rectangulo_Click);
            // 
            // btn_Elipse
            // 
            this.btn_Elipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Elipse.BackgroundImage")));
            this.btn_Elipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Elipse.Location = new System.Drawing.Point(222, 12);
            this.btn_Elipse.Name = "btn_Elipse";
            this.btn_Elipse.Size = new System.Drawing.Size(121, 72);
            this.btn_Elipse.TabIndex = 2;
            this.btn_Elipse.UseVisualStyleBackColor = true;
            this.btn_Elipse.Click += new System.EventHandler(this.btn_Elipse_Click);
            // 
            // btn_Linea
            // 
            this.btn_Linea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Linea.BackgroundImage")));
            this.btn_Linea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Linea.Location = new System.Drawing.Point(349, 12);
            this.btn_Linea.Name = "btn_Linea";
            this.btn_Linea.Size = new System.Drawing.Size(121, 72);
            this.btn_Linea.TabIndex = 3;
            this.btn_Linea.UseVisualStyleBackColor = true;
            this.btn_Linea.Click += new System.EventHandler(this.btn_Linea_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(476, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 81);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Rojo
            // 
            this.btn_Rojo.BackColor = System.Drawing.Color.Red;
            this.btn_Rojo.ForeColor = System.Drawing.Color.Red;
            this.btn_Rojo.Location = new System.Drawing.Point(592, 12);
            this.btn_Rojo.Name = "btn_Rojo";
            this.btn_Rojo.Size = new System.Drawing.Size(75, 23);
            this.btn_Rojo.TabIndex = 5;
            this.btn_Rojo.UseVisualStyleBackColor = false;
            this.btn_Rojo.Click += new System.EventHandler(this.btn_Rojo_Click);
            // 
            // btn_Verde
            // 
            this.btn_Verde.BackColor = System.Drawing.Color.Lime;
            this.btn_Verde.Location = new System.Drawing.Point(592, 70);
            this.btn_Verde.Name = "btn_Verde";
            this.btn_Verde.Size = new System.Drawing.Size(75, 23);
            this.btn_Verde.TabIndex = 6;
            this.btn_Verde.UseVisualStyleBackColor = false;
            this.btn_Verde.Click += new System.EventHandler(this.btn_Verde_Click);
            // 
            // btn_Azul
            // 
            this.btn_Azul.BackColor = System.Drawing.Color.Blue;
            this.btn_Azul.Location = new System.Drawing.Point(592, 41);
            this.btn_Azul.Name = "btn_Azul";
            this.btn_Azul.Size = new System.Drawing.Size(75, 23);
            this.btn_Azul.TabIndex = 7;
            this.btn_Azul.UseVisualStyleBackColor = false;
            this.btn_Azul.Click += new System.EventHandler(this.btn_Azul_Click);
            // 
            // btn_Morado
            // 
            this.btn_Morado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Morado.Location = new System.Drawing.Point(673, 12);
            this.btn_Morado.Name = "btn_Morado";
            this.btn_Morado.Size = new System.Drawing.Size(75, 23);
            this.btn_Morado.TabIndex = 8;
            this.btn_Morado.UseVisualStyleBackColor = false;
            this.btn_Morado.Click += new System.EventHandler(this.btn_Morado_Click);
            // 
            // btn_Blanco
            // 
            this.btn_Blanco.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Blanco.Location = new System.Drawing.Point(673, 41);
            this.btn_Blanco.Name = "btn_Blanco";
            this.btn_Blanco.Size = new System.Drawing.Size(75, 23);
            this.btn_Blanco.TabIndex = 9;
            this.btn_Blanco.UseVisualStyleBackColor = false;
            this.btn_Blanco.Click += new System.EventHandler(this.btn_Blanco_Click);
            // 
            // btn_Amarillo
            // 
            this.btn_Amarillo.BackColor = System.Drawing.Color.Yellow;
            this.btn_Amarillo.Location = new System.Drawing.Point(673, 70);
            this.btn_Amarillo.Name = "btn_Amarillo";
            this.btn_Amarillo.Size = new System.Drawing.Size(75, 23);
            this.btn_Amarillo.TabIndex = 10;
            this.btn_Amarillo.UseVisualStyleBackColor = false;
            this.btn_Amarillo.Click += new System.EventHandler(this.btn_Amarillo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Amarillo);
            this.Controls.Add(this.btn_Blanco);
            this.Controls.Add(this.btn_Morado);
            this.Controls.Add(this.btn_Azul);
            this.Controls.Add(this.btn_Verde);
            this.Controls.Add(this.btn_Rojo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Linea);
            this.Controls.Add(this.btn_Elipse);
            this.Controls.Add(this.btn_Rectangulo);
            this.Controls.Add(this.lbl_Coords);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Coords;
        private System.Windows.Forms.Button btn_Rectangulo;
        private System.Windows.Forms.Button btn_Elipse;
        private System.Windows.Forms.Button btn_Linea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Rojo;
        private System.Windows.Forms.Button btn_Verde;
        private System.Windows.Forms.Button btn_Azul;
        private System.Windows.Forms.Button btn_Morado;
        private System.Windows.Forms.Button btn_Blanco;
        private System.Windows.Forms.Button btn_Amarillo;
    }
}

