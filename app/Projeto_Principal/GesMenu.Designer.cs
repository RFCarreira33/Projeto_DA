﻿namespace Projeto_Principal
{
    partial class GesMenu
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
            this.components = new System.ComponentModel.Container();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.lblNomeRestaurante = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listBoxPratosInativos = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddFoto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxIngredientes = new System.Windows.Forms.ListBox();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RoundedBorders = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.buttonAddEngrediente = new System.Windows.Forms.Button();
            this.buttonRemvEngrediente = new System.Windows.Forms.Button();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.itemPic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblNomeRest = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.Location = new System.Drawing.Point(697, 101);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(257, 342);
            this.listBoxMenu.TabIndex = 0;
            // 
            // lblNomeRestaurante
            // 
            this.lblNomeRestaurante.AutoSize = true;
            this.lblNomeRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomeRestaurante.Location = new System.Drawing.Point(693, 27);
            this.lblNomeRestaurante.Name = "lblNomeRestaurante";
            this.lblNomeRestaurante.Size = new System.Drawing.Size(168, 20);
            this.lblNomeRestaurante.TabIndex = 1;
            this.lblNomeRestaurante.Text = "Menu do Restaurante:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(70, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(167, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(69, 454);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(85, 23);
            this.btnRegistar.TabIndex = 6;
            this.btnRegistar.Text = "Registar Prato";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(697, 463);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(257, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // listBoxPratosInativos
            // 
            this.listBoxPratosInativos.FormattingEnabled = true;
            this.listBoxPratosInativos.Location = new System.Drawing.Point(377, 230);
            this.listBoxPratosInativos.Name = "listBoxPratosInativos";
            this.listBoxPratosInativos.Size = new System.Drawing.Size(244, 186);
            this.listBoxPratosInativos.TabIndex = 8;
            this.listBoxPratosInativos.SelectedIndexChanged += new System.EventHandler(this.listBoxPratosInativos_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(377, 469);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(244, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Adicionar ao Menu";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddFoto
            // 
            this.btnAddFoto.Location = new System.Drawing.Point(147, 176);
            this.btnAddFoto.Name = "btnAddFoto";
            this.btnAddFoto.Size = new System.Drawing.Size(30, 23);
            this.btnAddFoto.TabIndex = 10;
            this.btnAddFoto.Text = "...";
            this.btnAddFoto.UseVisualStyleBackColor = true;
            this.btnAddFoto.Click += new System.EventHandler(this.btnAddFoto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fotografia";
            // 
            // listBoxIngredientes
            // 
            this.listBoxIngredientes.FormattingEnabled = true;
            this.listBoxIngredientes.Location = new System.Drawing.Point(69, 325);
            this.listBoxIngredientes.Name = "listBoxIngredientes";
            this.listBoxIngredientes.Size = new System.Drawing.Size(187, 82);
            this.listBoxIngredientes.TabIndex = 12;
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Location = new System.Drawing.Point(69, 299);
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(160, 20);
            this.txtIngredientes.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ingredientes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "€";
            // 
            // RoundedBorders
            // 
            this.RoundedBorders.TargetControl = this;
            // 
            // buttonAddEngrediente
            // 
            this.buttonAddEngrediente.Location = new System.Drawing.Point(235, 299);
            this.buttonAddEngrediente.Name = "buttonAddEngrediente";
            this.buttonAddEngrediente.Size = new System.Drawing.Size(21, 23);
            this.buttonAddEngrediente.TabIndex = 37;
            this.buttonAddEngrediente.Text = "+";
            this.buttonAddEngrediente.UseVisualStyleBackColor = true;
            this.buttonAddEngrediente.Click += new System.EventHandler(this.buttonAddEngrediente_Click);
            // 
            // buttonRemvEngrediente
            // 
            this.buttonRemvEngrediente.Location = new System.Drawing.Point(69, 413);
            this.buttonRemvEngrediente.Name = "buttonRemvEngrediente";
            this.buttonRemvEngrediente.Size = new System.Drawing.Size(187, 23);
            this.buttonRemvEngrediente.TabIndex = 38;
            this.buttonRemvEngrediente.Text = "Remover Ingrediente";
            this.buttonRemvEngrediente.UseVisualStyleBackColor = true;
            this.buttonRemvEngrediente.Click += new System.EventHandler(this.buttonRemvEngrediente_Click);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(136, 222);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoria.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Categoria";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(166, 454);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(91, 23);
            this.btnAtualizar.TabIndex = 42;
            this.btnAtualizar.Text = "Atualizar Prato";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // itemPic
            // 
            this.itemPic.Location = new System.Drawing.Point(392, 40);
            this.itemPic.Margin = new System.Windows.Forms.Padding(2);
            this.itemPic.Name = "itemPic";
            this.itemPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.itemPic.ShadowDecoration.Parent = this.itemPic;
            this.itemPic.Size = new System.Drawing.Size(144, 144);
            this.itemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemPic.TabIndex = 44;
            this.itemPic.TabStop = false;
            // 
            // lblNomeRest
            // 
            this.lblNomeRest.AutoSize = true;
            this.lblNomeRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomeRest.Location = new System.Drawing.Point(752, 61);
            this.lblNomeRest.Name = "lblNomeRest";
            this.lblNomeRest.Size = new System.Drawing.Size(51, 20);
            this.lblNomeRest.TabIndex = 45;
            this.lblNomeRest.Text = "Nome";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(377, 440);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(244, 23);
            this.buttonDelete.TabIndex = 46;
            this.buttonDelete.Text = "Apagar Prato";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Consultar Categorias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.DecimalPlaces = 2;
            this.txtPreco.Location = new System.Drawing.Point(105, 111);
            this.txtPreco.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(72, 20);
            this.txtPreco.TabIndex = 49;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPreco.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Não existem categorias ativas";
            this.label7.Visible = false;
            // 
            // GesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 545);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.lblNomeRest);
            this.Controls.Add(this.itemPic);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.buttonRemvEngrediente);
            this.Controls.Add(this.buttonAddEngrediente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIngredientes);
            this.Controls.Add(this.listBoxIngredientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddFoto);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxPratosInativos);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNomeRestaurante);
            this.Controls.Add(this.listBoxMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GesMenu";
            this.Text = "Gerir Menus";
            this.Load += new System.EventHandler(this.GesMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.Label lblNomeRestaurante;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listBoxPratosInativos;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxIngredientes;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Elipse RoundedBorders;
        private System.Windows.Forms.Button buttonRemvEngrediente;
        private System.Windows.Forms.Button buttonAddEngrediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Button btnAtualizar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox itemPic;
        private System.Windows.Forms.Label lblNomeRest;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txtPreco;
        private System.Windows.Forms.Label label7;
    }
}