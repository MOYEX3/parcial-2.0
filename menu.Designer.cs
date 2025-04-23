namespace proyecto_parcial
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            buttonexportar = new Button();
            textBoxexportar = new TextBox();
            txtnombre = new TextBox();
            textBox2 = new TextBox();
            txtnivel = new TextBox();
            txtid = new TextBox();
            lblnombre = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            buttoneliminar = new Button();
            buttonactualizar = new Button();
            buttonañadir = new Button();
            button1 = new Button();
            buttoninevntario = new Button();
            buttonexit = new Button();
            SuspendLayout();
            // 
            // buttonexportar
            // 
            buttonexportar.Location = new Point(635, 402);
            buttonexportar.Name = "buttonexportar";
            buttonexportar.Size = new Size(94, 29);
            buttonexportar.TabIndex = 0;
            buttonexportar.Text = "exportar";
            buttonexportar.UseVisualStyleBackColor = true;
            buttonexportar.Click += buttonexportar_Click;
            // 
            // textBoxexportar
            // 
            textBoxexportar.Location = new Point(635, 437);
            textBoxexportar.Name = "textBoxexportar";
            textBoxexportar.Size = new Size(111, 27);
            textBoxexportar.TabIndex = 1;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(119, 82);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(223, 27);
            txtnombre.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 27);
            textBox2.TabIndex = 2;
            // 
            // txtnivel
            // 
            txtnivel.Location = new Point(119, 167);
            txtnivel.Name = "txtnivel";
            txtnivel.Size = new Size(223, 27);
            txtnivel.TabIndex = 2;
            // 
            // txtid
            // 
            txtid.Location = new Point(119, 264);
            txtid.Name = "txtid";
            txtid.Size = new Size(223, 27);
            txtid.TabIndex = 2;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(191, 39);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(99, 26);
            lblnombre.TabIndex = 3;
            lblnombre.Text = "nombre ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(191, 131);
            label2.Name = "label2";
            label2.Size = new Size(67, 26);
            label2.TabIndex = 3;
            label2.Text = "nivel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 223);
            label3.Name = "label3";
            label3.Size = new Size(496, 21);
            label3.TabIndex = 3;
            label3.Text = "id ( solo si desea actualizar o eliminar jugador )";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 440);
            label1.Name = "label1";
            label1.Size = new Size(601, 26);
            label1.TabIndex = 3;
            label1.Text = "nombre del jugador que desea exportar su inventario";
            // 
            // buttoneliminar
            // 
            buttoneliminar.Location = new Point(339, 322);
            buttoneliminar.Name = "buttoneliminar";
            buttoneliminar.Size = new Size(94, 29);
            buttoneliminar.TabIndex = 4;
            buttoneliminar.Text = "eliminar";
            buttoneliminar.UseVisualStyleBackColor = true;
            buttoneliminar.Click += buttoneliminar_Click;
            // 
            // buttonactualizar
            // 
            buttonactualizar.Location = new Point(196, 323);
            buttonactualizar.Name = "buttonactualizar";
            buttonactualizar.Size = new Size(94, 29);
            buttonactualizar.TabIndex = 5;
            buttonactualizar.Text = "actualizar";
            buttonactualizar.UseVisualStyleBackColor = true;
            buttonactualizar.Click += buttonactualizar_Click;
            // 
            // buttonañadir
            // 
            buttonañadir.Location = new Point(57, 323);
            buttonañadir.Name = "buttonañadir";
            buttonañadir.Size = new Size(94, 29);
            buttonañadir.TabIndex = 6;
            buttonañadir.Text = "añadir";
            buttonañadir.UseVisualStyleBackColor = true;
            buttonañadir.Click += buttonañadir_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(582, 125);
            button1.Name = "button1";
            button1.Size = new Size(193, 129);
            button1.TabIndex = 8;
            button1.Text = "menu bloques";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttoninevntario
            // 
            buttoninevntario.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttoninevntario.Location = new Point(807, 125);
            buttoninevntario.Name = "buttoninevntario";
            buttoninevntario.Size = new Size(190, 123);
            buttoninevntario.TabIndex = 9;
            buttoninevntario.Text = "menu inventario ";
            buttoninevntario.UseVisualStyleBackColor = true;
            buttoninevntario.Click += buttoninevntario_Click;
            // 
            // buttonexit
            // 
            buttonexit.Location = new Point(923, -1);
            buttonexit.Name = "buttonexit";
            buttonexit.Size = new Size(92, 36);
            buttonexit.TabIndex = 10;
            buttonexit.Text = "exit";
            buttonexit.UseVisualStyleBackColor = true;
            buttonexit.Click += buttonexit_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1018, 484);
            Controls.Add(buttonexit);
            Controls.Add(buttoninevntario);
            Controls.Add(button1);
            Controls.Add(buttonañadir);
            Controls.Add(buttonactualizar);
            Controls.Add(buttoneliminar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblnombre);
            Controls.Add(txtid);
            Controls.Add(txtnivel);
            Controls.Add(textBox2);
            Controls.Add(txtnombre);
            Controls.Add(textBoxexportar);
            Controls.Add(buttonexportar);
            Name = "menu";
            Text = "menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonexportar;
        private TextBox textBoxexportar;
        private TextBox txtnombre;
        private TextBox textBox2;
        private TextBox txtnivel;
        private TextBox txtid;
        private Label lblnombre;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button buttoneliminar;
        private Button buttonactualizar;
        private Button buttonañadir;
        private Button button1;
        private Button buttoninevntario;
        private Button buttonexit;
    }
}