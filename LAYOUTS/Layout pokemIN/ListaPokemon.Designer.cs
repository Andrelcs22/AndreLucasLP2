namespace Layout_pokemIN
{
    partial class ListaPokemon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaPokemon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nomeL = new System.Windows.Forms.TextBox();
            this.tipoL = new System.Windows.Forms.TextBox();
            this.ataqueL = new System.Windows.Forms.TextBox();
            this.defesaL = new System.Windows.Forms.TextBox();
            this.hpL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.hpL);
            this.groupBox1.Controls.Add(this.defesaL);
            this.groupBox1.Controls.Add(this.ataqueL);
            this.groupBox1.Controls.Add(this.tipoL);
            this.groupBox1.Controls.Add(this.nomeL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro Pokémon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ataque:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Defesa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "HP:";
            // 
            // nomeL
            // 
            this.nomeL.Location = new System.Drawing.Point(56, 13);
            this.nomeL.Name = "nomeL";
            this.nomeL.Size = new System.Drawing.Size(100, 20);
            this.nomeL.TabIndex = 1;
            // 
            // tipoL
            // 
            this.tipoL.Location = new System.Drawing.Point(94, 47);
            this.tipoL.Name = "tipoL";
            this.tipoL.Size = new System.Drawing.Size(100, 20);
            this.tipoL.TabIndex = 5;
            // 
            // ataqueL
            // 
            this.ataqueL.Location = new System.Drawing.Point(56, 91);
            this.ataqueL.Name = "ataqueL";
            this.ataqueL.Size = new System.Drawing.Size(100, 20);
            this.ataqueL.TabIndex = 6;
            // 
            // defesaL
            // 
            this.defesaL.Location = new System.Drawing.Point(94, 136);
            this.defesaL.Name = "defesaL";
            this.defesaL.Size = new System.Drawing.Size(100, 20);
            this.defesaL.TabIndex = 7;
            // 
            // hpL
            // 
            this.hpL.Location = new System.Drawing.Point(56, 173);
            this.hpL.Name = "hpL";
            this.hpL.Size = new System.Drawing.Size(100, 20);
            this.hpL.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ListaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaPokemon";
            this.Text = "PokémIN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox hpL;
        private System.Windows.Forms.TextBox defesaL;
        private System.Windows.Forms.TextBox ataqueL;
        private System.Windows.Forms.TextBox tipoL;
        private System.Windows.Forms.TextBox nomeL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}