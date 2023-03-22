namespace Knihohlad
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.VyhladavanieNadpis = new System.Windows.Forms.Label();
            this.PridatNazov = new System.Windows.Forms.TextBox();
            this.Názov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PridatAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PridatKategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PridatCena = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pridatPopis = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PridajURL = new System.Windows.Forms.TextBox();
            this.Nazov = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Popis = new System.Windows.Forms.RichTextBox();
            this.PridatButton = new System.Windows.Forms.Button();
            this.VyhladavanieInput = new System.Windows.Forms.TextBox();
            this.Kategoria = new System.Windows.Forms.Label();
            this.hodnotenie = new System.Windows.Forms.Label();
            this.cena = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pridatHodnotenie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VyhladavanieNadpis
            // 
            this.VyhladavanieNadpis.AutoSize = true;
            this.VyhladavanieNadpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VyhladavanieNadpis.Location = new System.Drawing.Point(373, 115);
            this.VyhladavanieNadpis.Name = "VyhladavanieNadpis";
            this.VyhladavanieNadpis.Size = new System.Drawing.Size(188, 32);
            this.VyhladavanieNadpis.TabIndex = 3;
            this.VyhladavanieNadpis.Text = "Vyhľadávanie";
            // 
            // PridatNazov
            // 
            this.PridatNazov.Location = new System.Drawing.Point(1757, 205);
            this.PridatNazov.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PridatNazov.Name = "PridatNazov";
            this.PridatNazov.Size = new System.Drawing.Size(133, 22);
            this.PridatNazov.TabIndex = 6;
            this.PridatNazov.TextChanged += new System.EventHandler(this.PridatNazov_TextChanged);
            // 
            // Názov
            // 
            this.Názov.AutoSize = true;
            this.Názov.Location = new System.Drawing.Point(1665, 207);
            this.Názov.Name = "Názov";
            this.Názov.Size = new System.Drawing.Size(46, 16);
            this.Názov.TabIndex = 7;
            this.Názov.Text = "Názov";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1665, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Autor";
            // 
            // PridatAutor
            // 
            this.PridatAutor.Location = new System.Drawing.Point(1757, 256);
            this.PridatAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PridatAutor.Name = "PridatAutor";
            this.PridatAutor.Size = new System.Drawing.Size(133, 22);
            this.PridatAutor.TabIndex = 8;
            this.PridatAutor.TextChanged += new System.EventHandler(this.PridatAutor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1665, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kategória";
            // 
            // PridatKategoria
            // 
            this.PridatKategoria.Location = new System.Drawing.Point(1757, 294);
            this.PridatKategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PridatKategoria.Name = "PridatKategoria";
            this.PridatKategoria.Size = new System.Drawing.Size(133, 22);
            this.PridatKategoria.TabIndex = 10;
            this.PridatKategoria.TextChanged += new System.EventHandler(this.PridatKategoria_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1669, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cena";
            // 
            // PridatCena
            // 
            this.PridatCena.Location = new System.Drawing.Point(1757, 374);
            this.PridatCena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PridatCena.Name = "PridatCena";
            this.PridatCena.Size = new System.Drawing.Size(133, 22);
            this.PridatCena.TabIndex = 12;
            this.PridatCena.TextChanged += new System.EventHandler(this.PridatCena_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Items.AddRange(new object[] {
            ""});
            this.listBox1.Location = new System.Drawing.Point(34, 256);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(835, 562);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1765, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Popis";
            // 
            // pridatPopis
            // 
            this.pridatPopis.Location = new System.Drawing.Point(1672, 482);
            this.pridatPopis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pridatPopis.Name = "pridatPopis";
            this.pridatPopis.Size = new System.Drawing.Size(218, 156);
            this.pridatPopis.TabIndex = 16;
            this.pridatPopis.Text = "";
            this.pridatPopis.TextChanged += new System.EventHandler(this.pridatPopis_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1669, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "URL obrázok";
            // 
            // PridajURL
            // 
            this.PridajURL.Location = new System.Drawing.Point(1757, 419);
            this.PridajURL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PridajURL.Name = "PridajURL";
            this.PridajURL.Size = new System.Drawing.Size(133, 22);
            this.PridajURL.TabIndex = 17;
            this.PridajURL.TextChanged += new System.EventHandler(this.PridajURL_TextChanged);
            // 
            // Nazov
            // 
            this.Nazov.AutoSize = true;
            this.Nazov.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nazov.Location = new System.Drawing.Point(945, 106);
            this.Nazov.Name = "Nazov";
            this.Nazov.Size = new System.Drawing.Size(125, 42);
            this.Nazov.TabIndex = 19;
            this.Nazov.Text = "Nazov";
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autor.Location = new System.Drawing.Point(947, 164);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(67, 29);
            this.Autor.TabIndex = 20;
            this.Autor.Text = "autor";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox1.Location = new System.Drawing.Point(937, 294);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(381, 420);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 21;
            this.PictureBox1.TabStop = false;
            // 
            // Popis
            // 
            this.Popis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Popis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Popis.Location = new System.Drawing.Point(936, 773);
            this.Popis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Popis.Name = "Popis";
            this.Popis.ReadOnly = true;
            this.Popis.Size = new System.Drawing.Size(381, 212);
            this.Popis.TabIndex = 22;
            this.Popis.Text = "";
            // 
            // PridatButton
            // 
            this.PridatButton.Location = new System.Drawing.Point(1672, 739);
            this.PridatButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PridatButton.Name = "PridatButton";
            this.PridatButton.Size = new System.Drawing.Size(218, 52);
            this.PridatButton.TabIndex = 23;
            this.PridatButton.Text = "Pridaj";
            this.PridatButton.UseVisualStyleBackColor = true;
            // 
            // VyhladavanieInput
            // 
            this.VyhladavanieInput.Location = new System.Drawing.Point(363, 159);
            this.VyhladavanieInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VyhladavanieInput.Name = "VyhladavanieInput";
            this.VyhladavanieInput.Size = new System.Drawing.Size(209, 22);
            this.VyhladavanieInput.TabIndex = 1;
            this.VyhladavanieInput.TextChanged += new System.EventHandler(this.VyhladavanieInput_TextChanged);
            // 
            // Kategoria
            // 
            this.Kategoria.AutoSize = true;
            this.Kategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kategoria.Location = new System.Drawing.Point(947, 218);
            this.Kategoria.Name = "Kategoria";
            this.Kategoria.Size = new System.Drawing.Size(92, 25);
            this.Kategoria.TabIndex = 24;
            this.Kategoria.Text = "kategoria";
            // 
            // hodnotenie
            // 
            this.hodnotenie.AutoSize = true;
            this.hodnotenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hodnotenie.Location = new System.Drawing.Point(1112, 733);
            this.hodnotenie.Name = "hodnotenie";
            this.hodnotenie.Size = new System.Drawing.Size(218, 46);
            this.hodnotenie.TabIndex = 25;
            this.hodnotenie.Text = "hodnotenie";
            // 
            // cena
            // 
            this.cena.AutoSize = true;
            this.cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cena.Location = new System.Drawing.Point(931, 716);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(107, 46);
            this.cena.TabIndex = 26;
            this.cena.Text = "cena";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1668, 810);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 52);
            this.button1.TabIndex = 27;
            this.button1.Text = "Odstranit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(1672, 662);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(218, 52);
            this.EditButton.TabIndex = 41;
            this.EditButton.Text = "Editovat";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1665, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Hodnotenie (0-5)";
            // 
            // pridatHodnotenie
            // 
            this.pridatHodnotenie.Location = new System.Drawing.Point(1797, 334);
            this.pridatHodnotenie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pridatHodnotenie.Name = "pridatHodnotenie";
            this.pridatHodnotenie.Size = new System.Drawing.Size(93, 22);
            this.pridatHodnotenie.TabIndex = 42;
            this.pridatHodnotenie.TextChanged += new System.EventHandler(this.pridatHodnotenie_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pridatHodnotenie);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.hodnotenie);
            this.Controls.Add(this.Kategoria);
            this.Controls.Add(this.PridatButton);
            this.Controls.Add(this.Popis);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.Nazov);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PridajURL);
            this.Controls.Add(this.pridatPopis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PridatCena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PridatKategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PridatAutor);
            this.Controls.Add(this.Názov);
            this.Controls.Add(this.PridatNazov);
            this.Controls.Add(this.VyhladavanieNadpis);
            this.Controls.Add(this.VyhladavanieInput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label VyhladavanieNadpis;
        private System.Windows.Forms.TextBox PridatNazov;
        private System.Windows.Forms.Label Názov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PridatAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PridatKategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PridatCena;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox pridatPopis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PridajURL;
        private System.Windows.Forms.Label Nazov;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.RichTextBox Popis;
        private System.Windows.Forms.Button PridatButton;
        private System.Windows.Forms.TextBox VyhladavanieInput;
        private System.Windows.Forms.Label Kategoria;
        private System.Windows.Forms.Label hodnotenie;
        private System.Windows.Forms.Label cena;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pridatHodnotenie;
    }
}

