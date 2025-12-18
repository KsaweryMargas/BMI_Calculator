using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BMI_Calculator
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
            men = new CheckBox();
            women = new CheckBox();
            oblicz = new Button();
            w = new Label();
            label2 = new Label();
            wynikBMI = new Label();
            wynikKategoria = new Label();
            wpiszweight = new TextBox();
            wpiszheight = new TextBox();
            height = new Label();
            weight = new Label();
            opisKategorii = new Label();
            tabelaBMI = new DataGridView();
            age = new Label();
            wpiszwiek = new TextBox();
            SuspendLayout();
            // 
            // men
            // 
            men.AutoSize = true;
            men.Location = new Point(27, 188);
            men.Name = "men";
            men.Size = new Size(50, 19);
            men.TabIndex = 0;
            men.Text = "Men";
            men.UseVisualStyleBackColor = true;
            // 
            // women
            // 
            women.AutoSize = true;
            women.Location = new Point(94, 188);
            women.Name = "women";
            women.Size = new Size(68, 19);
            women.TabIndex = 1;
            women.Text = "Women";
            women.UseVisualStyleBackColor = true;
            // 
            // oblicz
            // 
            oblicz.BackColor = Color.SeaGreen;
            oblicz.ForeColor = SystemColors.ButtonHighlight;
            oblicz.Location = new Point(22, 213);
            oblicz.Name = "oblicz";
            oblicz.Size = new Size(83, 40);
            oblicz.TabIndex = 2;
            oblicz.Text = "Submit";
            oblicz.UseVisualStyleBackColor = false;
            oblicz.Click += oblicz_Click;
            // 
            // w
            // 
            w.AutoSize = true;
            w.Location = new Point(27, 281);
            w.Name = "w";
            w.Size = new Size(31, 15);
            w.TabIndex = 3;
            w.Text = "BMI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 329);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Kategoria:";
            // 
            // wynikBMI
            // 
            wynikBMI.AutoSize = true;
            wynikBMI.Location = new Point(139, 281);
            wynikBMI.Name = "wynikBMI";
            wynikBMI.Size = new Size(22, 15);
            wynikBMI.TabIndex = 5;
            wynikBMI.Text = "---";
            // 
            // wynikKategoria
            // 
            wynikKategoria.AutoSize = true;
            wynikKategoria.Location = new Point(138, 329);
            wynikKategoria.Name = "wynikKategoria";
            wynikKategoria.Size = new Size(22, 15);
            wynikKategoria.TabIndex = 6;
            wynikKategoria.Text = "---";
            // 
            // wpiszweight
            // 
            wpiszweight.BackColor = SystemColors.ControlLightLight;
            wpiszweight.Location = new Point(27, 150);
            wpiszweight.Name = "wpiszweight";
            wpiszweight.Size = new Size(135, 23);
            wpiszweight.TabIndex = 7;
            wpiszweight.Text = "kg";
            // 
            // wpiszheight
            // 
            wpiszheight.BackColor = SystemColors.ControlLightLight;
            wpiszheight.Location = new Point(27, 95);
            wpiszheight.Name = "wpiszheight";
            wpiszheight.Size = new Size(135, 23);
            wpiszheight.TabIndex = 8;
            wpiszheight.Text = "cm";
            // 
            // height
            // 
            height.AutoSize = true;
            height.Location = new Point(27, 77);
            height.Name = "height";
            height.Size = new Size(78, 15);
            height.TabIndex = 9;
            height.Text = "Wzrost w cm:";
            // 
            // weight
            // 
            weight.AutoSize = true;
            weight.Location = new Point(27, 132);
            weight.Name = "weight";
            weight.Size = new Size(68, 15);
            weight.TabIndex = 10;
            weight.Text = "Waga w kg:";
            // 
            // opisKategorii
            // 
            opisKategorii.AutoSize = true;
            opisKategorii.Location = new Point(27, 375);
            opisKategorii.Name = "opisKategorii";
            opisKategorii.Size = new Size(22, 15);
            opisKategorii.TabIndex = 11;
            opisKategorii.Text = "---";
            // 
            // tabelaBMI
            // 
            tabelaBMI.AllowUserToAddRows = false;
            tabelaBMI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaBMI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaBMI.Location = new Point(271, 12);
            tabelaBMI.Name = "tabelaBMI";
            tabelaBMI.ReadOnly = true;
            tabelaBMI.RowHeadersVisible = false;
            tabelaBMI.ScrollBars = ScrollBars.None;
            tabelaBMI.Size = new Size(237, 223);
            tabelaBMI.TabIndex = 13;
            // 
            // age
            // 
            age.AutoSize = true;
            age.Location = new Point(27, 19);
            age.Name = "age";
            age.Size = new Size(36, 15);
            age.TabIndex = 14;
            age.Text = "Wiek:";
            // 
            // wpiszwiek
            // 
            wpiszwiek.Location = new Point(27, 37);
            wpiszwiek.Name = "wpiszwiek";
            wpiszwiek.Size = new Size(135, 23);
            wpiszwiek.TabIndex = 15;
            wpiszwiek.Text = "wiek";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 453);
            Controls.Add(wpiszwiek);
            Controls.Add(age);
            Controls.Add(tabelaBMI);
            Controls.Add(opisKategorii);
            Controls.Add(weight);
            Controls.Add(height);
            Controls.Add(wpiszheight);
            Controls.Add(wpiszweight);
            Controls.Add(wynikKategoria);
            Controls.Add(wynikBMI);
            Controls.Add(label2);
            Controls.Add(w);
            Controls.Add(oblicz);
            Controls.Add(women);
            Controls.Add(men);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox men;
        private CheckBox women;
        private Button oblicz;
        private Label w;
        private Label label2;
        private Label wynikBMI;
        private Label wynikKategoria;
        private TextBox wpiszweight;
        private TextBox wpiszheight;
        private Label height;
        private Label weight;
        private Label opisKategorii;
        private DataGridView tabelaBMI;
        private Label age;
        private TextBox wpiszwiek;
    }
}
