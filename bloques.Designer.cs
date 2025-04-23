namespace proyecto_parcial
{
    partial class bloques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bloques));
            comboBox1 = new ComboBox();
            buttonbuscar = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            buttonexit = new Button();
            buttonreturn = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 149);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(327, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonbuscar
            // 
            buttonbuscar.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonbuscar.Location = new Point(84, 199);
            buttonbuscar.Name = "buttonbuscar";
            buttonbuscar.Size = new Size(166, 79);
            buttonbuscar.TabIndex = 1;
            buttonbuscar.Text = "buscar";
            buttonbuscar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(371, 94);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(393, 244);
            listBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 94);
            label1.Name = "label1";
            label1.Size = new Size(131, 29);
            label1.TabIndex = 3;
            label1.Text = "opciones";
            // 
            // buttonexit
            // 
            buttonexit.Location = new Point(694, 1);
            buttonexit.Name = "buttonexit";
            buttonexit.Size = new Size(107, 44);
            buttonexit.TabIndex = 4;
            buttonexit.Text = "exit";
            buttonexit.UseVisualStyleBackColor = true;
            buttonexit.Click += buttonexit_Click;
            // 
            // buttonreturn
            // 
            buttonreturn.Location = new Point(1, 1);
            buttonreturn.Name = "buttonreturn";
            buttonreturn.Size = new Size(81, 44);
            buttonreturn.TabIndex = 5;
            buttonreturn.Text = "regresar";
            buttonreturn.UseVisualStyleBackColor = true;
            buttonreturn.Click += buttonreturn_Click;
            // 
            // bloques
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(buttonreturn);
            Controls.Add(buttonexit);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(buttonbuscar);
            Controls.Add(comboBox1);
            Name = "bloques";
            Text = "bloques";
            Load += bloques_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button buttonbuscar;
        private ListBox listBox1;
        private Label label1;
        private Button buttonexit;
        private Button buttonreturn;
    }
}