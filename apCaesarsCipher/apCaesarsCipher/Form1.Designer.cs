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
            this.lbResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.cbKey = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpDecoder = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tbcCifra.SuspendLayout();
            this.tpEnconder.SuspendLayout();
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
            this.tbcCifra.Size = new System.Drawing.Size(584, 335);
            this.tbcCifra.TabIndex = 0;
            // 
            // tpEnconder
            // 
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
            this.tpEnconder.Size = new System.Drawing.Size(576, 301);
            this.tpEnconder.TabIndex = 0;
            this.tpEnconder.Text = "Encoder";
            this.tpEnconder.UseVisualStyleBackColor = true;
            // 
            // lbResult
            // 
            this.lbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResult.Location = new System.Drawing.Point(154, 153);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(371, 123);
            this.lbResult.TabIndex = 6;
            this.lbResult.Text = "{ -- }";
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
            this.tpDecoder.Location = new System.Drawing.Point(4, 22);
            this.tpDecoder.Name = "tpDecoder";
            this.tpDecoder.Padding = new System.Windows.Forms.Padding(3);
            this.tpDecoder.Size = new System.Drawing.Size(530, 267);
            this.tpDecoder.TabIndex = 1;
            this.tpDecoder.Text = "Decoder";
            this.tpDecoder.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(6, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(559, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Note: if the string is too long, you can resize the window to see the result bett" +
    "er";
            // 
            // frmCifra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(608, 357);
            this.Controls.Add(this.tbcCifra);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCifra";
            this.Text = "Caesar\'s Cipher Enconder/Decoder";
            this.tbcCifra.ResumeLayout(false);
            this.tpEnconder.ResumeLayout(false);
            this.tpEnconder.PerformLayout();
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
    }
}

