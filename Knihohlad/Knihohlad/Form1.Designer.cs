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
            this.VyhladavanieInput = new System.Windows.Forms.TextBox();
            this.VyhladavanieButton = new System.Windows.Forms.Button();
            this.VyhladavanieNadpis = new System.Windows.Forms.Label();
            this.VyhladavanieComboBox = new System.Windows.Forms.ComboBox();
            this.PridatNadpis = new System.Windows.Forms.Label();
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PridajURL = new System.Windows.Forms.TextBox();
            this.Nazov = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.Label();
            this.Image = new System.Windows.Forms.PictureBox();
            this.Popis = new System.Windows.Forms.RichTextBox();
            this.PridatButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // VyhladavanieInput
            // 
            this.VyhladavanieInput.Location = new System.Drawing.Point(918, 124);
            this.VyhladavanieInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VyhladavanieInput.Name = "VyhladavanieInput";
            this.VyhladavanieInput.Size = new System.Drawing.Size(92, 20);
            this.VyhladavanieInput.TabIndex = 1;
            // 
            // VyhladavanieButton
            // 
            this.VyhladavanieButton.Location = new System.Drawing.Point(1013, 100);
            this.VyhladavanieButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VyhladavanieButton.Name = "VyhladavanieButton";
            this.VyhladavanieButton.Size = new System.Drawing.Size(56, 42);
            this.VyhladavanieButton.TabIndex = 2;
            this.VyhladavanieButton.Text = "Vyhľadaj";
            this.VyhladavanieButton.UseVisualStyleBackColor = true;
            // 
            // VyhladavanieNadpis
            // 
            this.VyhladavanieNadpis.AutoSize = true;
            this.VyhladavanieNadpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VyhladavanieNadpis.Location = new System.Drawing.Point(916, 64);
            this.VyhladavanieNadpis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VyhladavanieNadpis.Name = "VyhladavanieNadpis";
            this.VyhladavanieNadpis.Size = new System.Drawing.Size(144, 26);
            this.VyhladavanieNadpis.TabIndex = 3;
            this.VyhladavanieNadpis.Text = "Vyhľadávanie";
            // 
            // VyhladavanieComboBox
            // 
            this.VyhladavanieComboBox.FormattingEnabled = true;
            this.VyhladavanieComboBox.Items.AddRange(new object[] {
            "nazov",
            "autor",
            "kategoria",
            "cena"});
            this.VyhladavanieComboBox.Location = new System.Drawing.Point(918, 100);
            this.VyhladavanieComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VyhladavanieComboBox.Name = "VyhladavanieComboBox";
            this.VyhladavanieComboBox.Size = new System.Drawing.Size(92, 21);
            this.VyhladavanieComboBox.TabIndex = 4;
            // 
            // PridatNadpis
            // 
            this.PridatNadpis.AutoSize = true;
            this.PridatNadpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PridatNadpis.Location = new System.Drawing.Point(916, 168);
            this.PridatNadpis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PridatNadpis.Name = "PridatNadpis";
            this.PridatNadpis.Size = new System.Drawing.Size(139, 26);
            this.PridatNadpis.TabIndex = 5;
            this.PridatNadpis.Text = "Pridať knižku";
            // 
            // PridatNazov
            // 
            this.PridatNazov.Location = new System.Drawing.Point(985, 206);
            this.PridatNazov.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PridatNazov.Name = "PridatNazov";
            this.PridatNazov.Size = new System.Drawing.Size(76, 20);
            this.PridatNazov.TabIndex = 6;
            // 
            // Názov
            // 
            this.Názov.AutoSize = true;
            this.Názov.Location = new System.Drawing.Point(916, 208);
            this.Názov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Názov.Name = "Názov";
            this.Názov.Size = new System.Drawing.Size(38, 13);
            this.Názov.TabIndex = 7;
            this.Názov.Text = "Názov";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(916, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Autor";
            // 
            // PridatAutor
            // 
            this.PridatAutor.Location = new System.Drawing.Point(985, 237);
            this.PridatAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PridatAutor.Name = "PridatAutor";
            this.PridatAutor.Size = new System.Drawing.Size(76, 20);
            this.PridatAutor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(916, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kategória";
            // 
            // PridatKategoria
            // 
            this.PridatKategoria.Location = new System.Drawing.Point(985, 271);
            this.PridatKategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PridatKategoria.Name = "PridatKategoria";
            this.PridatKategoria.Size = new System.Drawing.Size(76, 20);
            this.PridatKategoria.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(916, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cena";
            // 
            // PridatCena
            // 
            this.PridatCena.Location = new System.Drawing.Point(985, 307);
            this.PridatCena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PridatCena.Name = "PridatCena";
            this.PridatCena.Size = new System.Drawing.Size(76, 20);
            this.PridatCena.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Items.AddRange(new object[] {
            ""});
            this.listBox1.Location = new System.Drawing.Point(9, 18);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(492, 524);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(968, 384);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Popis";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(918, 407);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(140, 79);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(916, 349);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "URL obrázok";
            // 
            // PridajURL
            // 
            this.PridajURL.Location = new System.Drawing.Point(985, 347);
            this.PridajURL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PridajURL.Name = "PridajURL";
            this.PridajURL.Size = new System.Drawing.Size(76, 20);
            this.PridajURL.TabIndex = 17;
            // 
            // Nazov
            // 
            this.Nazov.AutoSize = true;
            this.Nazov.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nazov.Location = new System.Drawing.Point(569, 24);
            this.Nazov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nazov.Name = "Nazov";
            this.Nazov.Size = new System.Drawing.Size(0, 31);
            this.Nazov.TabIndex = 19;
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autor.Location = new System.Drawing.Point(571, 68);
            this.Autor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(0, 20);
            this.Autor.TabIndex = 20;
            // 
            // Image
            // 
            this.Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Image.Location = new System.Drawing.Point(573, 100);
            this.Image.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(286, 341);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image.TabIndex = 21;
            this.Image.TabStop = false;
            // 
            // Popis
            // 
            this.Popis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Popis.Location = new System.Drawing.Point(573, 461);
            this.Popis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Popis.Name = "Popis";
            this.Popis.ReadOnly = true;
            this.Popis.Size = new System.Drawing.Size(286, 89);
            this.Popis.TabIndex = 22;
            this.Popis.Text = "";
            // 
            // PridatButton
            // 
            this.PridatButton.Location = new System.Drawing.Point(918, 499);
            this.PridatButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PridatButton.Name = "PridatButton";
            this.PridatButton.Size = new System.Drawing.Size(142, 42);
            this.PridatButton.TabIndex = 23;
            this.PridatButton.Text = "Pridaj";
            this.PridatButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 612);
            this.Controls.Add(this.PridatButton);
            this.Controls.Add(this.Popis);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.Nazov);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PridajURL);
            this.Controls.Add(this.richTextBox1);
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
            this.Controls.Add(this.PridatNadpis);
            this.Controls.Add(this.VyhladavanieComboBox);
            this.Controls.Add(this.VyhladavanieNadpis);
            this.Controls.Add(this.VyhladavanieButton);
            this.Controls.Add(this.VyhladavanieInput);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox VyhladavanieInput;
        private System.Windows.Forms.Button VyhladavanieButton;
        private System.Windows.Forms.Label VyhladavanieNadpis;
        private System.Windows.Forms.ComboBox VyhladavanieComboBox;
        private System.Windows.Forms.Label PridatNadpis;
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PridajURL;
        private System.Windows.Forms.Label Nazov;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.RichTextBox Popis;
        private System.Windows.Forms.Button PridatButton;
    }
}

