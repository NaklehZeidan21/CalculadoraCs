namespace Calculadora
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textoResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.boton5 = new System.Windows.Forms.Button();
            this.boton6 = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.boton7 = new System.Windows.Forms.Button();
            this.boton8 = new System.Windows.Forms.Button();
            this.boton9 = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.boton0 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.elevado = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // textoResultado
            // 
            this.textoResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(191)))));
            this.textoResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoResultado.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textoResultado.Location = new System.Drawing.Point(12, 12);
            this.textoResultado.Multiline = true;
            this.textoResultado.Name = "textoResultado";
            this.textoResultado.ReadOnly = true;
            this.textoResultado.Size = new System.Drawing.Size(351, 51);
            this.textoResultado.TabIndex = 0;
            this.textoResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textoResultado.TextChanged += new System.EventHandler(this.textoResultado_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(165)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(12, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "⌫";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(182)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Location = new System.Drawing.Point(190, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.Color.White;
            this.boton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton1.FlatAppearance.BorderSize = 0;
            this.boton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.boton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.boton1.Location = new System.Drawing.Point(12, 104);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(83, 41);
            this.boton1.TabIndex = 3;
            this.boton1.Text = "1";
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.button3_Click);
            // 
            // boton2
            // 
            this.boton2.BackColor = System.Drawing.Color.White;
            this.boton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.boton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.boton2.Location = new System.Drawing.Point(101, 104);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(83, 41);
            this.boton2.TabIndex = 4;
            this.boton2.Text = "2";
            this.boton2.UseVisualStyleBackColor = false;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // boton3
            // 
            this.boton3.BackColor = System.Drawing.Color.White;
            this.boton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.boton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.boton3.Location = new System.Drawing.Point(190, 104);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(83, 41);
            this.boton3.TabIndex = 5;
            this.boton3.Text = "3";
            this.boton3.UseVisualStyleBackColor = false;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // suma
            // 
            this.suma.BackColor = System.Drawing.Color.WhiteSmoke;
            this.suma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suma.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.suma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.suma.Location = new System.Drawing.Point(279, 104);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(83, 41);
            this.suma.TabIndex = 6;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = false;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // boton4
            // 
            this.boton4.BackColor = System.Drawing.Color.White;
            this.boton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.boton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.boton4.Location = new System.Drawing.Point(12, 151);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(83, 41);
            this.boton4.TabIndex = 7;
            this.boton4.Text = "4";
            this.boton4.UseVisualStyleBackColor = false;
            this.boton4.Click += new System.EventHandler(this.button7_Click);
            // 
            // boton5
            // 
            this.boton5.BackColor = System.Drawing.Color.White;
            this.boton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.boton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.boton5.Location = new System.Drawing.Point(101, 151);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(83, 41);
            this.boton5.TabIndex = 8;
            this.boton5.Text = "5";
            this.boton5.UseVisualStyleBackColor = false;
            this.boton5.Click += new System.EventHandler(this.boton5_Click);
            // 
            // boton6
            // 
            this.boton6.BackColor = System.Drawing.Color.White;
            this.boton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.boton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.boton6.Location = new System.Drawing.Point(190, 151);
            this.boton6.Name = "boton6";
            this.boton6.Size = new System.Drawing.Size(83, 41);
            this.boton6.TabIndex = 9;
            this.boton6.Text = "6";
            this.boton6.UseVisualStyleBackColor = false;
            this.boton6.Click += new System.EventHandler(this.boton6_Click);
            // 
            // resta
            // 
            this.resta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.resta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.resta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.resta.Location = new System.Drawing.Point(279, 151);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(83, 41);
            this.resta.TabIndex = 10;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = false;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // boton7
            // 
            this.boton7.BackColor = System.Drawing.Color.White;
            this.boton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.boton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.boton7.Location = new System.Drawing.Point(12, 198);
            this.boton7.Name = "boton7";
            this.boton7.Size = new System.Drawing.Size(83, 41);
            this.boton7.TabIndex = 11;
            this.boton7.Text = "7";
            this.boton7.UseVisualStyleBackColor = false;
            this.boton7.Click += new System.EventHandler(this.button11_Click);
            // 
            // boton8
            // 
            this.boton8.BackColor = System.Drawing.Color.White;
            this.boton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.boton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.boton8.Location = new System.Drawing.Point(101, 198);
            this.boton8.Name = "boton8";
            this.boton8.Size = new System.Drawing.Size(83, 41);
            this.boton8.TabIndex = 12;
            this.boton8.Text = "8";
            this.boton8.UseVisualStyleBackColor = false;
            this.boton8.Click += new System.EventHandler(this.boton8_Click);
            // 
            // boton9
            // 
            this.boton9.BackColor = System.Drawing.Color.White;
            this.boton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.boton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.boton9.Location = new System.Drawing.Point(190, 198);
            this.boton9.Name = "boton9";
            this.boton9.Size = new System.Drawing.Size(83, 41);
            this.boton9.TabIndex = 13;
            this.boton9.Text = "9";
            this.boton9.UseVisualStyleBackColor = false;
            this.boton9.Click += new System.EventHandler(this.boton9_Click);
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mult.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.mult.Location = new System.Drawing.Point(280, 198);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(83, 41);
            this.mult.TabIndex = 14;
            this.mult.Text = "x";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // boton0
            // 
            this.boton0.BackColor = System.Drawing.Color.White;
            this.boton0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.boton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.boton0.Location = new System.Drawing.Point(12, 245);
            this.boton0.Name = "boton0";
            this.boton0.Size = new System.Drawing.Size(83, 41);
            this.boton0.TabIndex = 15;
            this.boton0.Text = "0";
            this.boton0.UseVisualStyleBackColor = false;
            this.boton0.Click += new System.EventHandler(this.boton0_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.White;
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.button16.Location = new System.Drawing.Point(101, 245);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(83, 41);
            this.button16.TabIndex = 16;
            this.button16.Text = ".";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // elevado
            // 
            this.elevado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.elevado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elevado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.elevado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.elevado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.elevado.Location = new System.Drawing.Point(190, 245);
            this.elevado.Name = "elevado";
            this.elevado.Size = new System.Drawing.Size(83, 41);
            this.elevado.TabIndex = 17;
            this.elevado.Text = "^";
            this.elevado.UseVisualStyleBackColor = false;
            this.elevado.Click += new System.EventHandler(this.button17_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.Color.WhiteSmoke;
            this.div.Cursor = System.Windows.Forms.Cursors.Hand;
            this.div.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.div.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.div.Location = new System.Drawing.Point(279, 245);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(83, 41);
            this.div.TabIndex = 18;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.button19.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.button19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button19.Location = new System.Drawing.Point(12, 292);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(351, 58);
            this.button19.TabIndex = 19;
            this.button19.Text = "=";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Turquoise;
            this.button3.Location = new System.Drawing.Point(33, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 35);
            this.button3.TabIndex = 21;
            this.button3.Text = "Graficar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(69, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "GRAFICAR FUNCION LINEAL";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 380);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 29);
            this.textBox1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(149, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "y = mx + b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 29;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 442);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(351, 229);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 380);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(31, 29);
            this.textBox2.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(375, 683);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.div);
            this.Controls.Add(this.elevado);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.boton0);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.boton9);
            this.Controls.Add(this.boton8);
            this.Controls.Add(this.boton7);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.boton6);
            this.Controls.Add(this.boton5);
            this.Controls.Add(this.boton4);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textoResultado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button boton5;
        private System.Windows.Forms.Button boton6;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button boton7;
        private System.Windows.Forms.Button boton8;
        private System.Windows.Forms.Button boton9;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button boton0;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button elevado;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

