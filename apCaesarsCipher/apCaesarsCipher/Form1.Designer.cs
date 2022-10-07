namespace apCaesarsCipher
{
    partial class frmCifra
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcCifra = new System.Windows.Forms.TabControl();
            this.tpEnconder = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.cbKey = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpDecoder = new System.Windows.Forms.TabPage();
            this.listResult = new System.Windows.Forms.ListBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtEncryptedString = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbcCifra.SuspendLayout();
            this.tpEnconder.SuspendLayout();
            this.tpDecoder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCifra
            // 
            this.tbcCifra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcCifra.Controls.Add(this.tpEnconder);
            this.tbcCifra.Controls.Add(this.tpDecoder);
            this.tbcCifra.Location = new System.Drawing.Point(12, 12);
            this.tbcCifra.Name = "tbcCifra";
            this.tbcCifra.SelectedIndex = 0;
            this.tbcCifra.Size = new System.Drawing.Size(584, 390);
            this.tbcCifra.TabIndex = 0;
            // 
            // tpEnconder
            // 
            this.tpEnconder.Controls.Add(this.label6);
            this.tpEnconder.Controls.Add(this.label4);
            this.tpEnconder.Controls.Add(this.lbResult);
            this.tpEnconder.Controls.Add(this.label3);
            this.tpEnconder.Controls.Add(this.btnEncode);
            this.tpEnconder.Controls.Add(this.cbKey);
            this.tpEnconder.Controls.Add(this.label2);
            this.tpEnconder.Controls.Add(this.txtString);
            this.tpEnconder.Controls.Add(this.label1);
            this.tpEnconder.Location = new System.Drawing.Point(4, 30);
            this.tpEnconder.Name = "tpEnconder";
            this.tpEnconder.Padding = new System.Windows.Forms.Padding(3);
            this.tpEnconder.Size = new System.Drawing.Size(576, 356);
            this.tpEnconder.TabIndex = 0;
            this.tpEnconder.Text = "Encoder";
            this.tpEnconder.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(11, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(559, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Note: if the string is too long, you can resize the window to see the result bett" +
    "er";
            // 
            // lbResult
            // 
            this.lbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResult.BackColor = System.Drawing.Color.Transparent;
            this.lbResult.Location = new System.Drawing.Point(154, 153);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(371, 132);
            this.lbResult.TabIndex = 6;
            this.lbResult.Text = "{ -- }";
            this.lbResult.DoubleClick += new System.EventHandler(this.lbResult_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result:";
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(285, 95);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(194, 29);
            this.btnEncode.TabIndex = 4;
            this.btnEncode.Text = "Enconde String";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // cbKey
            // 
            this.cbKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKey.FormattingEnabled = true;
            this.cbKey.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.cbKey.Location = new System.Drawing.Point(154, 95);
            this.cbKey.Name = "cbKey";
            this.cbKey.Size = new System.Drawing.Size(104, 29);
            this.cbKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Key:";
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(154, 18);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtString.Size = new System.Drawing.Size(325, 64);
            this.txtString.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "String to encode:";
            // 
            // tpDecoder
            // 
            this.tpDecoder.Controls.Add(this.listResult);
            this.tpDecoder.Controls.Add(this.btnDecode);
            this.tpDecoder.Controls.Add(this.txtEncryptedString);
            this.tpDecoder.Controls.Add(this.label5);
            this.tpDecoder.Location = new System.Drawing.Point(4, 30);
            this.tpDecoder.Name = "tpDecoder";
            this.tpDecoder.Padding = new System.Windows.Forms.Padding(3);
            this.tpDecoder.Size = new System.Drawing.Size(576, 356);
            this.tpDecoder.TabIndex = 1;
            this.tpDecoder.Text = "Decoder";
            this.tpDecoder.UseVisualStyleBackColor = true;
            // 
            // listResult
            // 
            this.listResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listResult.FormattingEnabled = true;
            this.listResult.ItemHeight = 21;
            this.listResult.Location = new System.Drawing.Point(25, 175);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(517, 151);
            this.listResult.TabIndex = 3;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(163, 120);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(184, 40);
            this.btnDecode.TabIndex = 2;
            this.btnDecode.Text = "Decode String";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // txtEncryptedString
            // 
            this.txtEncryptedString.Location = new System.Drawing.Point(163, 18);
            this.txtEncryptedString.Multiline = true;
            this.txtEncryptedString.Name = "txtEncryptedString";
            this.txtEncryptedString.Size = new System.Drawing.Size(379, 87);
            this.txtEncryptedString.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "String to Decode:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(11, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Note: Double click the text to copy it";
            // 
            // frmCifra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(608, 412);
            this.Controls.Add(this.tbcCifra);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCifra";
            this.Text = "Caesar\'s Cipher Enconder/Decoder";
            this.tbcCifra.ResumeLayout(false);
            this.tpEnconder.ResumeLayout(false);
            this.tpEnconder.PerformLayout();
            this.tpDecoder.ResumeLayout(false);
            this.tpDecoder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCifra;
        private System.Windows.Forms.TabPage tpEnconder;
        private System.Windows.Forms.TabPage tpDecoder;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.ComboBox cbKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEncryptedString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.Label label6;
    }
}

