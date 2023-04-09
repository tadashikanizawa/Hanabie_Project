namespace Hanabie_Project
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
            dataGridView1 = new DataGridView();
            Zenchou_Textbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Hachou_Textbox = new TextBox();
            label3 = new Label();
            Kubushita_Textbox = new TextBox();
            label4 = new Label();
            Kei_TextBox = new TextBox();
            label5 = new Label();
            Kado_Textbox = new TextBox();
            Mark_ComboBox = new ComboBox();
            Type_ComboBox = new ComboBox();
            label6 = new Label();
            ID_TextBox = new TextBox();
            label7 = new Label();
            Laminas_TextBox = new TextBox();
            label8 = new Label();
            checkBoxKei = new CheckBox();
            checkBoxKubushita = new CheckBox();
            checkBoxHachou = new CheckBox();
            checkBoxKado = new CheckBox();
            checkBoxZenchou = new CheckBox();
            checkBoxLaminas = new CheckBox();
            label9 = new Label();
            label10 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1105, 413);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Zenchou_Textbox
            // 
            Zenchou_Textbox.Location = new Point(1183, 215);
            Zenchou_Textbox.Name = "Zenchou_Textbox";
            Zenchou_Textbox.Size = new Size(75, 23);
            Zenchou_Textbox.TabIndex = 1;
            Zenchou_Textbox.TextChanged += Textboxs_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1146, 218);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "全長";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1146, 189);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "刃長";
            // 
            // Hachou_Textbox
            // 
            Hachou_Textbox.Location = new Point(1183, 186);
            Hachou_Textbox.Name = "Hachou_Textbox";
            Hachou_Textbox.Size = new Size(75, 23);
            Hachou_Textbox.TabIndex = 3;
            Hachou_Textbox.TextChanged += Textboxs_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1146, 161);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "首下";
            // 
            // Kubushita_Textbox
            // 
            Kubushita_Textbox.Location = new Point(1183, 157);
            Kubushita_Textbox.Name = "Kubushita_Textbox";
            Kubushita_Textbox.Size = new Size(75, 23);
            Kubushita_Textbox.TabIndex = 5;
            Kubushita_Textbox.TextChanged += Textboxs_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1158, 103);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 8;
            label4.Text = "径";
            // 
            // Kei_TextBox
            // 
            Kei_TextBox.Location = new Point(1183, 99);
            Kei_TextBox.Name = "Kei_TextBox";
            Kei_TextBox.Size = new Size(75, 23);
            Kei_TextBox.TabIndex = 7;
            Kei_TextBox.TextChanged += Textboxs_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1158, 132);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 10;
            label5.Text = "角";
            // 
            // Kado_Textbox
            // 
            Kado_Textbox.Location = new Point(1183, 128);
            Kado_Textbox.Name = "Kado_Textbox";
            Kado_Textbox.Size = new Size(75, 23);
            Kado_Textbox.TabIndex = 9;
            Kado_Textbox.TextChanged += Textboxs_TextChanged;
            // 
            // Mark_ComboBox
            // 
            Mark_ComboBox.FormattingEnabled = true;
            Mark_ComboBox.Location = new Point(1151, 27);
            Mark_ComboBox.Name = "Mark_ComboBox";
            Mark_ComboBox.Size = new Size(121, 23);
            Mark_ComboBox.TabIndex = 11;
            Mark_ComboBox.SelectedIndexChanged += ComboBoxes_SelectedIndexChanged;
            // 
            // Type_ComboBox
            // 
            Type_ComboBox.FormattingEnabled = true;
            Type_ComboBox.Location = new Point(1151, 70);
            Type_ComboBox.Name = "Type_ComboBox";
            Type_ComboBox.Size = new Size(121, 23);
            Type_ComboBox.TabIndex = 12;
            Type_ComboBox.SelectedIndexChanged += ComboBoxes_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1159, 247);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 14;
            label6.Text = "ID";
            // 
            // ID_TextBox
            // 
            ID_TextBox.Location = new Point(1183, 244);
            ID_TextBox.Name = "ID_TextBox";
            ID_TextBox.Size = new Size(100, 23);
            ID_TextBox.TabIndex = 13;
            ID_TextBox.TextChanged += Textboxs_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1146, 276);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 16;
            label7.Text = "刃数";
            // 
            // Laminas_TextBox
            // 
            Laminas_TextBox.Location = new Point(1183, 273);
            Laminas_TextBox.Name = "Laminas_TextBox";
            Laminas_TextBox.Size = new Size(75, 23);
            Laminas_TextBox.TabIndex = 15;
            Laminas_TextBox.TextChanged += Textboxs_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 428);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 17;
            label8.Text = "label8";
            label8.Visible = false;
            // 
            // checkBoxKei
            // 
            checkBoxKei.AutoSize = true;
            checkBoxKei.Location = new Point(1264, 101);
            checkBoxKei.Name = "checkBoxKei";
            checkBoxKei.Size = new Size(89, 19);
            checkBoxKei.TabIndex = 18;
            checkBoxKei.Text = "等しい値のみ";
            checkBoxKei.UseVisualStyleBackColor = true;
            checkBoxKei.CheckedChanged += checkBoxKei_CheckedChanged;
            // 
            // checkBoxKubushita
            // 
            checkBoxKubushita.AutoSize = true;
            checkBoxKubushita.Location = new Point(1264, 161);
            checkBoxKubushita.Name = "checkBoxKubushita";
            checkBoxKubushita.Size = new Size(89, 19);
            checkBoxKubushita.TabIndex = 19;
            checkBoxKubushita.Text = "等しい値のみ";
            checkBoxKubushita.UseVisualStyleBackColor = true;
            checkBoxKubushita.CheckedChanged += checkBoxKei_CheckedChanged;
            // 
            // checkBoxHachou
            // 
            checkBoxHachou.AutoSize = true;
            checkBoxHachou.Location = new Point(1264, 190);
            checkBoxHachou.Name = "checkBoxHachou";
            checkBoxHachou.Size = new Size(89, 19);
            checkBoxHachou.TabIndex = 20;
            checkBoxHachou.Text = "等しい値のみ";
            checkBoxHachou.UseVisualStyleBackColor = true;
            checkBoxHachou.CheckedChanged += checkBoxKei_CheckedChanged;
            // 
            // checkBoxKado
            // 
            checkBoxKado.AutoSize = true;
            checkBoxKado.Location = new Point(1264, 130);
            checkBoxKado.Name = "checkBoxKado";
            checkBoxKado.Size = new Size(89, 19);
            checkBoxKado.TabIndex = 21;
            checkBoxKado.Text = "等しい値のみ";
            checkBoxKado.UseVisualStyleBackColor = true;
            checkBoxKado.CheckedChanged += checkBoxKei_CheckedChanged;
            // 
            // checkBoxZenchou
            // 
            checkBoxZenchou.AutoSize = true;
            checkBoxZenchou.Location = new Point(1264, 217);
            checkBoxZenchou.Name = "checkBoxZenchou";
            checkBoxZenchou.Size = new Size(89, 19);
            checkBoxZenchou.TabIndex = 22;
            checkBoxZenchou.Text = "等しい値のみ";
            checkBoxZenchou.UseVisualStyleBackColor = true;
            checkBoxZenchou.CheckedChanged += checkBoxKei_CheckedChanged;
            // 
            // checkBoxLaminas
            // 
            checkBoxLaminas.AutoSize = true;
            checkBoxLaminas.Location = new Point(1264, 277);
            checkBoxLaminas.Name = "checkBoxLaminas";
            checkBoxLaminas.Size = new Size(89, 19);
            checkBoxLaminas.TabIndex = 23;
            checkBoxLaminas.Text = "等しい値のみ";
            checkBoxLaminas.UseVisualStyleBackColor = true;
            checkBoxLaminas.CheckedChanged += checkBoxKei_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1193, 9);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 24;
            label9.Text = "メーカー";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1193, 53);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 25;
            label10.Text = "タイプ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1336, 434);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(70, 15);
            linkLabel1.TabIndex = 26;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "SourceCode";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1418, 458);
            Controls.Add(linkLabel1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(checkBoxLaminas);
            Controls.Add(checkBoxZenchou);
            Controls.Add(checkBoxKado);
            Controls.Add(checkBoxHachou);
            Controls.Add(checkBoxKubushita);
            Controls.Add(checkBoxKei);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Laminas_TextBox);
            Controls.Add(label6);
            Controls.Add(ID_TextBox);
            Controls.Add(Type_ComboBox);
            Controls.Add(Mark_ComboBox);
            Controls.Add(label5);
            Controls.Add(Kado_Textbox);
            Controls.Add(label4);
            Controls.Add(Kei_TextBox);
            Controls.Add(label3);
            Controls.Add(Kubushita_Textbox);
            Controls.Add(label2);
            Controls.Add(Hachou_Textbox);
            Controls.Add(label1);
            Controls.Add(Zenchou_Textbox);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Tools Search System(Sample)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox Zenchou_Textbox;
        private Label label1;
        private Label label2;
        private TextBox Hachou_Textbox;
        private Label label3;
        private TextBox Kubushita_Textbox;
        private Label label4;
        private TextBox Kei_TextBox;
        private Label label5;
        private TextBox Kado_Textbox;
        private ComboBox Mark_ComboBox;
        private ComboBox Type_ComboBox;
        private Label label6;
        private TextBox ID_TextBox;
        private Label label7;
        private TextBox Laminas_TextBox;
        private Label label8;
        private CheckBox checkBoxKei;
        private CheckBox checkBoxKubushita;
        private CheckBox checkBoxHachou;
        private CheckBox checkBoxKado;
        private CheckBox checkBoxZenchou;
        private CheckBox checkBoxLaminas;
        private Label label9;
        private Label label10;
        private LinkLabel linkLabel1;
    }
}