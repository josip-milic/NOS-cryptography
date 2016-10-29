namespace EncryptionProject
{
    partial class MainForm
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
            this.pnlTabs = new System.Windows.Forms.TabControl();
            this.tabAES = new System.Windows.Forms.TabPage();
            this.cbAESKeySize = new System.Windows.Forms.ComboBox();
            this.rbAESDecrypt = new System.Windows.Forms.RadioButton();
            this.rbAESEncrypt = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAESOutFileShow = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAESInFileShow = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAESKeyGen = new System.Windows.Forms.Button();
            this.tbAESKey = new System.Windows.Forms.TextBox();
            this.btnAESKeyShow = new System.Windows.Forms.Button();
            this.tbAESInFile = new System.Windows.Forms.TextBox();
            this.btnAESDoIt = new System.Windows.Forms.Button();
            this.tbAESOutFile = new System.Windows.Forms.TextBox();
            this.btnAESOutFileSave = new System.Windows.Forms.Button();
            this.btnAESSwapInOut = new System.Windows.Forms.Button();
            this.btnAESKey = new System.Windows.Forms.Button();
            this.btnAESInFile = new System.Windows.Forms.Button();
            this.tabRSA = new System.Windows.Forms.TabPage();
            this.cbRSAKeySize = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRSAPubKeyGen = new System.Windows.Forms.Button();
            this.tbRSAPubKey = new System.Windows.Forms.TextBox();
            this.btnRSAPubKeyShow = new System.Windows.Forms.Button();
            this.btnRSAPubKey = new System.Windows.Forms.Button();
            this.rbRSADecrypt = new System.Windows.Forms.RadioButton();
            this.rbRSAEncrypt = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRSAOutFileShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRSAInFileShow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRSAPrivKey = new System.Windows.Forms.TextBox();
            this.btnRSAPrivKeyShow = new System.Windows.Forms.Button();
            this.tbRSAInFile = new System.Windows.Forms.TextBox();
            this.btnRSADoIt = new System.Windows.Forms.Button();
            this.tbRSAOutFile = new System.Windows.Forms.TextBox();
            this.btnRSAOutFileSave = new System.Windows.Forms.Button();
            this.btnRSASwapInOut = new System.Windows.Forms.Button();
            this.btnRSAPrivKey = new System.Windows.Forms.Button();
            this.btnRSAInFile = new System.Windows.Forms.Button();
            this.tabSHA2 = new System.Windows.Forms.TabPage();
            this.cbSHA2Size = new System.Windows.Forms.ComboBox();
            this.rtbSHA2 = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSHA2OutFileShow = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSHA2InFileShow = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbSHA2InFile = new System.Windows.Forms.TextBox();
            this.btnSHA2DoIt = new System.Windows.Forms.Button();
            this.tbSHA2OutFile = new System.Windows.Forms.TextBox();
            this.btnSHA2OutFileSave = new System.Windows.Forms.Button();
            this.btnSHA2InFile = new System.Windows.Forms.Button();
            this.tabSHA2Manual = new System.Windows.Forms.TabPage();
            this.rtbSHA2Manual = new System.Windows.Forms.RichTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btnSHA2ManualOutFileShow = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.btnSHA2ManualInFileShow = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.tbSHA2ManualInFile = new System.Windows.Forms.TextBox();
            this.btnSHA2ManualDoIt = new System.Windows.Forms.Button();
            this.tbSHA2ManualOutFile = new System.Windows.Forms.TextBox();
            this.btnSHA2ManualOutFileSave = new System.Windows.Forms.Button();
            this.btnSHA2ManualInFile = new System.Windows.Forms.Button();
            this.tabEnvelope = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEnvelopePubKey = new System.Windows.Forms.TextBox();
            this.btnEnvelopePubKeyShow = new System.Windows.Forms.Button();
            this.btnEnvelopePubKey = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEnvelopeOutFileShow = new System.Windows.Forms.Button();
            this.btnEnvelopeShow = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEnvelopeInFileShow = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbEnvelopePrivKey = new System.Windows.Forms.TextBox();
            this.btnEnvelopePrivKeyShow = new System.Windows.Forms.Button();
            this.tbEnvelopeInFile = new System.Windows.Forms.TextBox();
            this.tbEnvelopeOutFile = new System.Windows.Forms.TextBox();
            this.btnEnvelopeShowIt = new System.Windows.Forms.Button();
            this.btnEnvelopeDoIt = new System.Windows.Forms.Button();
            this.btnEnvelopeOutFileSave = new System.Windows.Forms.Button();
            this.tbEnvelope = new System.Windows.Forms.TextBox();
            this.btnEnvelopeSave = new System.Windows.Forms.Button();
            this.btnEnvelopePrivKey = new System.Windows.Forms.Button();
            this.btnEnvelopeInFile = new System.Windows.Forms.Button();
            this.tabSignature = new System.Windows.Forms.TabPage();
            this.chbSignatureSHA2 = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbSignaturePrivKey = new System.Windows.Forms.TextBox();
            this.btnSignaturePrivKeyShow = new System.Windows.Forms.Button();
            this.btnSignaturePrivKey = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSignatureShow = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSignatureInFileShow = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.tbSignaturePubKey = new System.Windows.Forms.TextBox();
            this.btnSignaturePubKeyShow = new System.Windows.Forms.Button();
            this.tbSignatureInFile = new System.Windows.Forms.TextBox();
            this.btnSignatureCheckIt = new System.Windows.Forms.Button();
            this.btnSignatureDoIt = new System.Windows.Forms.Button();
            this.tbSignature = new System.Windows.Forms.TextBox();
            this.btnSignatureSave = new System.Windows.Forms.Button();
            this.btnSignaturePubKey = new System.Windows.Forms.Button();
            this.btnSignatureInFile = new System.Windows.Forms.Button();
            this.tabSeal = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.tbSealReceiverPubKey = new System.Windows.Forms.TextBox();
            this.btnSealReceiverPubKeyShow = new System.Windows.Forms.Button();
            this.btnSealReceiverPubKey = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnSealSignatureShow = new System.Windows.Forms.Button();
            this.btnSealEnvelopeShow = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.btnSealSenderPrivKeyShow = new System.Windows.Forms.Button();
            this.tbSealInFile = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tbSealOutFile = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbSealReceiverPrivKey = new System.Windows.Forms.TextBox();
            this.btnSealOutFileShow = new System.Windows.Forms.Button();
            this.btnSealInFileShow = new System.Windows.Forms.Button();
            this.btnSealReceiverPrivKeyShow = new System.Windows.Forms.Button();
            this.tbSealSenderPubKey = new System.Windows.Forms.TextBox();
            this.btnSealSenderPubKeyShow = new System.Windows.Forms.Button();
            this.tbSealSenderPrivKey = new System.Windows.Forms.TextBox();
            this.btnSealOpenIt = new System.Windows.Forms.Button();
            this.tbSealSignature = new System.Windows.Forms.TextBox();
            this.btnSealDoIt = new System.Windows.Forms.Button();
            this.tbSealEnvelope = new System.Windows.Forms.TextBox();
            this.btnSealSignatureSave = new System.Windows.Forms.Button();
            this.btnSealOutFileSave = new System.Windows.Forms.Button();
            this.btnSealInFile = new System.Windows.Forms.Button();
            this.btnSealReceiverPrivKey = new System.Windows.Forms.Button();
            this.btnSealEnvelope = new System.Windows.Forms.Button();
            this.btnSealSenderPubKey = new System.Windows.Forms.Button();
            this.btnSealSenderPrivKey = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDefault = new System.Windows.Forms.Button();
            this.chbOpenGenerated = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlTabs.SuspendLayout();
            this.tabAES.SuspendLayout();
            this.tabRSA.SuspendLayout();
            this.tabSHA2.SuspendLayout();
            this.tabSHA2Manual.SuspendLayout();
            this.tabEnvelope.SuspendLayout();
            this.tabSignature.SuspendLayout();
            this.tabSeal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabs
            // 
            this.pnlTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTabs.Controls.Add(this.tabAES);
            this.pnlTabs.Controls.Add(this.tabRSA);
            this.pnlTabs.Controls.Add(this.tabSHA2);
            this.pnlTabs.Controls.Add(this.tabSHA2Manual);
            this.pnlTabs.Controls.Add(this.tabEnvelope);
            this.pnlTabs.Controls.Add(this.tabSignature);
            this.pnlTabs.Controls.Add(this.tabSeal);
            this.pnlTabs.Location = new System.Drawing.Point(3, 2);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.SelectedIndex = 0;
            this.pnlTabs.Size = new System.Drawing.Size(728, 401);
            this.pnlTabs.TabIndex = 1;
            // 
            // tabAES
            // 
            this.tabAES.Controls.Add(this.cbAESKeySize);
            this.tabAES.Controls.Add(this.rbAESDecrypt);
            this.tabAES.Controls.Add(this.rbAESEncrypt);
            this.tabAES.Controls.Add(this.label6);
            this.tabAES.Controls.Add(this.btnAESOutFileShow);
            this.tabAES.Controls.Add(this.label5);
            this.tabAES.Controls.Add(this.btnAESInFileShow);
            this.tabAES.Controls.Add(this.label4);
            this.tabAES.Controls.Add(this.btnAESKeyGen);
            this.tabAES.Controls.Add(this.tbAESKey);
            this.tabAES.Controls.Add(this.btnAESKeyShow);
            this.tabAES.Controls.Add(this.tbAESInFile);
            this.tabAES.Controls.Add(this.btnAESDoIt);
            this.tabAES.Controls.Add(this.tbAESOutFile);
            this.tabAES.Controls.Add(this.btnAESOutFileSave);
            this.tabAES.Controls.Add(this.btnAESSwapInOut);
            this.tabAES.Controls.Add(this.btnAESKey);
            this.tabAES.Controls.Add(this.btnAESInFile);
            this.tabAES.Location = new System.Drawing.Point(4, 22);
            this.tabAES.Name = "tabAES";
            this.tabAES.Padding = new System.Windows.Forms.Padding(3);
            this.tabAES.Size = new System.Drawing.Size(720, 375);
            this.tabAES.TabIndex = 1;
            this.tabAES.Text = "AES";
            this.tabAES.UseVisualStyleBackColor = true;
            // 
            // cbAESKeySize
            // 
            this.cbAESKeySize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbAESKeySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAESKeySize.FormattingEnabled = true;
            this.cbAESKeySize.Items.AddRange(new object[] {
            "128 bita",
            "192 bita",
            "256 bita"});
            this.cbAESKeySize.Location = new System.Drawing.Point(637, 130);
            this.cbAESKeySize.Name = "cbAESKeySize";
            this.cbAESKeySize.Size = new System.Drawing.Size(74, 21);
            this.cbAESKeySize.TabIndex = 4;
            // 
            // rbAESDecrypt
            // 
            this.rbAESDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAESDecrypt.AutoSize = true;
            this.rbAESDecrypt.Location = new System.Drawing.Point(202, 202);
            this.rbAESDecrypt.Name = "rbAESDecrypt";
            this.rbAESDecrypt.Size = new System.Drawing.Size(84, 17);
            this.rbAESDecrypt.TabIndex = 3;
            this.rbAESDecrypt.TabStop = true;
            this.rbAESDecrypt.Text = "Dekriptiranje";
            this.rbAESDecrypt.UseVisualStyleBackColor = true;
            // 
            // rbAESEncrypt
            // 
            this.rbAESEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAESEncrypt.AutoSize = true;
            this.rbAESEncrypt.Checked = true;
            this.rbAESEncrypt.Location = new System.Drawing.Point(125, 202);
            this.rbAESEncrypt.Name = "rbAESEncrypt";
            this.rbAESEncrypt.Size = new System.Drawing.Size(71, 17);
            this.rbAESEncrypt.TabIndex = 3;
            this.rbAESEncrypt.TabStop = true;
            this.rbAESEncrypt.Text = "Kriptiranje";
            this.rbAESEncrypt.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ključ:";
            // 
            // btnAESOutFileShow
            // 
            this.btnAESOutFileShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAESOutFileShow.Location = new System.Drawing.Point(554, 164);
            this.btnAESOutFileShow.Name = "btnAESOutFileShow";
            this.btnAESOutFileShow.Size = new System.Drawing.Size(75, 21);
            this.btnAESOutFileShow.TabIndex = 2;
            this.btnAESOutFileShow.Text = "Pregledaj";
            this.btnAESOutFileShow.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ulazna datoteka:";
            // 
            // btnAESInFileShow
            // 
            this.btnAESInFileShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAESInFileShow.Location = new System.Drawing.Point(554, 136);
            this.btnAESInFileShow.Name = "btnAESInFileShow";
            this.btnAESInFileShow.Size = new System.Drawing.Size(75, 21);
            this.btnAESInFileShow.TabIndex = 2;
            this.btnAESInFileShow.Text = "Pregledaj";
            this.btnAESInFileShow.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Izlazna datoteka:";
            // 
            // btnAESKeyGen
            // 
            this.btnAESKeyGen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAESKeyGen.Location = new System.Drawing.Point(636, 109);
            this.btnAESKeyGen.Name = "btnAESKeyGen";
            this.btnAESKeyGen.Size = new System.Drawing.Size(76, 21);
            this.btnAESKeyGen.TabIndex = 2;
            this.btnAESKeyGen.Text = "Generiraj";
            this.btnAESKeyGen.UseVisualStyleBackColor = true;
            this.btnAESKeyGen.Click += new System.EventHandler(this.btnAESKeyGen_Click);
            // 
            // tbAESKey
            // 
            this.tbAESKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAESKey.Location = new System.Drawing.Point(125, 109);
            this.tbAESKey.Name = "tbAESKey";
            this.tbAESKey.Size = new System.Drawing.Size(342, 20);
            this.tbAESKey.TabIndex = 1;
            // 
            // btnAESKeyShow
            // 
            this.btnAESKeyShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAESKeyShow.Location = new System.Drawing.Point(554, 109);
            this.btnAESKeyShow.Name = "btnAESKeyShow";
            this.btnAESKeyShow.Size = new System.Drawing.Size(75, 21);
            this.btnAESKeyShow.TabIndex = 2;
            this.btnAESKeyShow.Text = "Pregledaj";
            this.btnAESKeyShow.UseVisualStyleBackColor = true;
            // 
            // tbAESInFile
            // 
            this.tbAESInFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAESInFile.Location = new System.Drawing.Point(125, 137);
            this.tbAESInFile.Name = "tbAESInFile";
            this.tbAESInFile.Size = new System.Drawing.Size(342, 20);
            this.tbAESInFile.TabIndex = 1;
            // 
            // btnAESDoIt
            // 
            this.btnAESDoIt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAESDoIt.Location = new System.Drawing.Point(125, 225);
            this.btnAESDoIt.Name = "btnAESDoIt";
            this.btnAESDoIt.Size = new System.Drawing.Size(161, 33);
            this.btnAESDoIt.TabIndex = 2;
            this.btnAESDoIt.Text = "Obavi";
            this.btnAESDoIt.UseVisualStyleBackColor = true;
            this.btnAESDoIt.Click += new System.EventHandler(this.btnAESDoIt_Click);
            // 
            // tbAESOutFile
            // 
            this.tbAESOutFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAESOutFile.Location = new System.Drawing.Point(125, 165);
            this.tbAESOutFile.Name = "tbAESOutFile";
            this.tbAESOutFile.Size = new System.Drawing.Size(342, 20);
            this.tbAESOutFile.TabIndex = 1;
            // 
            // btnAESOutFileSave
            // 
            this.btnAESOutFileSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAESOutFileSave.Location = new System.Drawing.Point(473, 164);
            this.btnAESOutFileSave.Name = "btnAESOutFileSave";
            this.btnAESOutFileSave.Size = new System.Drawing.Size(75, 21);
            this.btnAESOutFileSave.TabIndex = 2;
            this.btnAESOutFileSave.Text = "Odaberi";
            this.btnAESOutFileSave.UseVisualStyleBackColor = true;
            // 
            // btnAESSwapInOut
            // 
            this.btnAESSwapInOut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAESSwapInOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.btnAESSwapInOut.Location = new System.Drawing.Point(106, 140);
            this.btnAESSwapInOut.Name = "btnAESSwapInOut";
            this.btnAESSwapInOut.Size = new System.Drawing.Size(16, 41);
            this.btnAESSwapInOut.TabIndex = 2;
            this.btnAESSwapInOut.Text = "↑↓";
            this.btnAESSwapInOut.UseVisualStyleBackColor = true;
            this.btnAESSwapInOut.Click += new System.EventHandler(this.btnAESSwapInOut_Click);
            // 
            // btnAESKey
            // 
            this.btnAESKey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAESKey.Location = new System.Drawing.Point(473, 109);
            this.btnAESKey.Name = "btnAESKey";
            this.btnAESKey.Size = new System.Drawing.Size(75, 21);
            this.btnAESKey.TabIndex = 2;
            this.btnAESKey.Text = "Odaberi";
            this.btnAESKey.UseVisualStyleBackColor = true;
            // 
            // btnAESInFile
            // 
            this.btnAESInFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAESInFile.Location = new System.Drawing.Point(473, 136);
            this.btnAESInFile.Name = "btnAESInFile";
            this.btnAESInFile.Size = new System.Drawing.Size(75, 21);
            this.btnAESInFile.TabIndex = 2;
            this.btnAESInFile.Text = "Odaberi";
            this.btnAESInFile.UseVisualStyleBackColor = true;
            // 
            // tabRSA
            // 
            this.tabRSA.Controls.Add(this.cbRSAKeySize);
            this.tabRSA.Controls.Add(this.label8);
            this.tabRSA.Controls.Add(this.btnRSAPubKeyGen);
            this.tabRSA.Controls.Add(this.tbRSAPubKey);
            this.tabRSA.Controls.Add(this.btnRSAPubKeyShow);
            this.tabRSA.Controls.Add(this.btnRSAPubKey);
            this.tabRSA.Controls.Add(this.rbRSADecrypt);
            this.tabRSA.Controls.Add(this.rbRSAEncrypt);
            this.tabRSA.Controls.Add(this.label1);
            this.tabRSA.Controls.Add(this.btnRSAOutFileShow);
            this.tabRSA.Controls.Add(this.label2);
            this.tabRSA.Controls.Add(this.btnRSAInFileShow);
            this.tabRSA.Controls.Add(this.label3);
            this.tabRSA.Controls.Add(this.tbRSAPrivKey);
            this.tabRSA.Controls.Add(this.btnRSAPrivKeyShow);
            this.tabRSA.Controls.Add(this.tbRSAInFile);
            this.tabRSA.Controls.Add(this.btnRSADoIt);
            this.tabRSA.Controls.Add(this.tbRSAOutFile);
            this.tabRSA.Controls.Add(this.btnRSAOutFileSave);
            this.tabRSA.Controls.Add(this.btnRSASwapInOut);
            this.tabRSA.Controls.Add(this.btnRSAPrivKey);
            this.tabRSA.Controls.Add(this.btnRSAInFile);
            this.tabRSA.Location = new System.Drawing.Point(4, 22);
            this.tabRSA.Name = "tabRSA";
            this.tabRSA.Size = new System.Drawing.Size(720, 375);
            this.tabRSA.TabIndex = 2;
            this.tabRSA.Text = "RSA";
            this.tabRSA.UseVisualStyleBackColor = true;
            // 
            // cbRSAKeySize
            // 
            this.cbRSAKeySize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbRSAKeySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRSAKeySize.FormattingEnabled = true;
            this.cbRSAKeySize.Items.AddRange(new object[] {
            "512 bita",
            "768 bita",
            "1024 bita",
            "1280 bita",
            "1536 bita",
            "2048 bita",
            "3072 bita",
            "4096 bita"});
            this.cbRSAKeySize.Location = new System.Drawing.Point(636, 121);
            this.cbRSAKeySize.Name = "cbRSAKeySize";
            this.cbRSAKeySize.Size = new System.Drawing.Size(74, 21);
            this.cbRSAKeySize.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Javni ključ:";
            // 
            // btnRSAPubKeyGen
            // 
            this.btnRSAPubKeyGen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRSAPubKeyGen.Location = new System.Drawing.Point(635, 99);
            this.btnRSAPubKeyGen.Name = "btnRSAPubKeyGen";
            this.btnRSAPubKeyGen.Size = new System.Drawing.Size(76, 21);
            this.btnRSAPubKeyGen.TabIndex = 25;
            this.btnRSAPubKeyGen.Text = "Generiraj";
            this.btnRSAPubKeyGen.UseVisualStyleBackColor = true;
            this.btnRSAPubKeyGen.Click += new System.EventHandler(this.btnRSAKeyGen_Click);
            // 
            // tbRSAPubKey
            // 
            this.tbRSAPubKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRSAPubKey.Location = new System.Drawing.Point(125, 96);
            this.tbRSAPubKey.Name = "tbRSAPubKey";
            this.tbRSAPubKey.Size = new System.Drawing.Size(341, 20);
            this.tbRSAPubKey.TabIndex = 24;
            // 
            // btnRSAPubKeyShow
            // 
            this.btnRSAPubKeyShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRSAPubKeyShow.Location = new System.Drawing.Point(553, 96);
            this.btnRSAPubKeyShow.Name = "btnRSAPubKeyShow";
            this.btnRSAPubKeyShow.Size = new System.Drawing.Size(75, 21);
            this.btnRSAPubKeyShow.TabIndex = 27;
            this.btnRSAPubKeyShow.Text = "Pregledaj";
            this.btnRSAPubKeyShow.UseVisualStyleBackColor = true;
            // 
            // btnRSAPubKey
            // 
            this.btnRSAPubKey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRSAPubKey.Location = new System.Drawing.Point(472, 96);
            this.btnRSAPubKey.Name = "btnRSAPubKey";
            this.btnRSAPubKey.Size = new System.Drawing.Size(75, 21);
            this.btnRSAPubKey.TabIndex = 26;
            this.btnRSAPubKey.Text = "Odaberi";
            this.btnRSAPubKey.UseVisualStyleBackColor = true;
            // 
            // rbRSADecrypt
            // 
            this.rbRSADecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbRSADecrypt.AutoSize = true;
            this.rbRSADecrypt.Location = new System.Drawing.Point(202, 220);
            this.rbRSADecrypt.Name = "rbRSADecrypt";
            this.rbRSADecrypt.Size = new System.Drawing.Size(84, 17);
            this.rbRSADecrypt.TabIndex = 21;
            this.rbRSADecrypt.TabStop = true;
            this.rbRSADecrypt.Text = "Dekriptiranje";
            this.rbRSADecrypt.UseVisualStyleBackColor = true;
            // 
            // rbRSAEncrypt
            // 
            this.rbRSAEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbRSAEncrypt.AutoSize = true;
            this.rbRSAEncrypt.Checked = true;
            this.rbRSAEncrypt.Location = new System.Drawing.Point(125, 220);
            this.rbRSAEncrypt.Name = "rbRSAEncrypt";
            this.rbRSAEncrypt.Size = new System.Drawing.Size(71, 17);
            this.rbRSAEncrypt.TabIndex = 20;
            this.rbRSAEncrypt.TabStop = true;
            this.rbRSAEncrypt.Text = "Kriptiranje";
            this.rbRSAEncrypt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Privatni ključ:";
            // 
            // btnRSAOutFileShow
            // 
            this.btnRSAOutFileShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRSAOutFileShow.Location = new System.Drawing.Point(553, 182);
            this.btnRSAOutFileShow.Name = "btnRSAOutFileShow";
            this.btnRSAOutFileShow.Size = new System.Drawing.Size(75, 21);
            this.btnRSAOutFileShow.TabIndex = 18;
            this.btnRSAOutFileShow.Text = "Pregledaj";
            this.btnRSAOutFileShow.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ulazna datoteka:";
            // 
            // btnRSAInFileShow
            // 
            this.btnRSAInFileShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRSAInFileShow.Location = new System.Drawing.Point(553, 154);
            this.btnRSAInFileShow.Name = "btnRSAInFileShow";
            this.btnRSAInFileShow.Size = new System.Drawing.Size(75, 21);
            this.btnRSAInFileShow.TabIndex = 17;
            this.btnRSAInFileShow.Text = "Pregledaj";
            this.btnRSAInFileShow.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Izlazna datoteka:";
            // 
            // tbRSAPrivKey
            // 
            this.tbRSAPrivKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRSAPrivKey.Location = new System.Drawing.Point(125, 125);
            this.tbRSAPrivKey.Name = "tbRSAPrivKey";
            this.tbRSAPrivKey.Size = new System.Drawing.Size(341, 20);
            this.tbRSAPrivKey.TabIndex = 10;
            // 
            // btnRSAPrivKeyShow
            // 
            this.btnRSAPrivKeyShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRSAPrivKeyShow.Location = new System.Drawing.Point(553, 125);
            this.btnRSAPrivKeyShow.Name = "btnRSAPrivKeyShow";
            this.btnRSAPrivKeyShow.Size = new System.Drawing.Size(75, 21);
            this.btnRSAPrivKeyShow.TabIndex = 19;
            this.btnRSAPrivKeyShow.Text = "Pregledaj";
            this.btnRSAPrivKeyShow.UseVisualStyleBackColor = true;
            // 
            // tbRSAInFile
            // 
            this.tbRSAInFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRSAInFile.Location = new System.Drawing.Point(125, 155);
            this.tbRSAInFile.Name = "tbRSAInFile";
            this.tbRSAInFile.Size = new System.Drawing.Size(341, 20);
            this.tbRSAInFile.TabIndex = 9;
            // 
            // btnRSADoIt
            // 
            this.btnRSADoIt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRSADoIt.Location = new System.Drawing.Point(125, 243);
            this.btnRSADoIt.Name = "btnRSADoIt";
            this.btnRSADoIt.Size = new System.Drawing.Size(161, 33);
            this.btnRSADoIt.TabIndex = 14;
            this.btnRSADoIt.Text = "Obavi";
            this.btnRSADoIt.UseVisualStyleBackColor = true;
            this.btnRSADoIt.Click += new System.EventHandler(this.btnRSADoIt_Click);
            // 
            // tbRSAOutFile
            // 
            this.tbRSAOutFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRSAOutFile.Location = new System.Drawing.Point(125, 183);
            this.tbRSAOutFile.Name = "tbRSAOutFile";
            this.tbRSAOutFile.Size = new System.Drawing.Size(341, 20);
            this.tbRSAOutFile.TabIndex = 8;
            // 
            // btnRSAOutFileSave
            // 
            this.btnRSAOutFileSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRSAOutFileSave.Location = new System.Drawing.Point(472, 182);
            this.btnRSAOutFileSave.Name = "btnRSAOutFileSave";
            this.btnRSAOutFileSave.Size = new System.Drawing.Size(75, 21);
            this.btnRSAOutFileSave.TabIndex = 13;
            this.btnRSAOutFileSave.Text = "Odaberi";
            this.btnRSAOutFileSave.UseVisualStyleBackColor = true;
            // 
            // btnRSASwapInOut
            // 
            this.btnRSASwapInOut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRSASwapInOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.btnRSASwapInOut.Location = new System.Drawing.Point(106, 158);
            this.btnRSASwapInOut.Name = "btnRSASwapInOut";
            this.btnRSASwapInOut.Size = new System.Drawing.Size(16, 41);
            this.btnRSASwapInOut.TabIndex = 12;
            this.btnRSASwapInOut.Text = "↑↓";
            this.btnRSASwapInOut.UseVisualStyleBackColor = true;
            this.btnRSASwapInOut.Click += new System.EventHandler(this.btnRSASwapInOut_Click);
            // 
            // btnRSAPrivKey
            // 
            this.btnRSAPrivKey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRSAPrivKey.Location = new System.Drawing.Point(472, 125);
            this.btnRSAPrivKey.Name = "btnRSAPrivKey";
            this.btnRSAPrivKey.Size = new System.Drawing.Size(75, 21);
            this.btnRSAPrivKey.TabIndex = 16;
            this.btnRSAPrivKey.Text = "Odaberi";
            this.btnRSAPrivKey.UseVisualStyleBackColor = true;
            // 
            // btnRSAInFile
            // 
            this.btnRSAInFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRSAInFile.Location = new System.Drawing.Point(472, 154);
            this.btnRSAInFile.Name = "btnRSAInFile";
            this.btnRSAInFile.Size = new System.Drawing.Size(75, 21);
            this.btnRSAInFile.TabIndex = 15;
            this.btnRSAInFile.Text = "Odaberi";
            this.btnRSAInFile.UseVisualStyleBackColor = true;
            // 
            // tabSHA2
            // 
            this.tabSHA2.Controls.Add(this.cbSHA2Size);
            this.tabSHA2.Controls.Add(this.rtbSHA2);
            this.tabSHA2.Controls.Add(this.label11);
            this.tabSHA2.Controls.Add(this.btnSHA2OutFileShow);
            this.tabSHA2.Controls.Add(this.label9);
            this.tabSHA2.Controls.Add(this.btnSHA2InFileShow);
            this.tabSHA2.Controls.Add(this.label10);
            this.tabSHA2.Controls.Add(this.tbSHA2InFile);
            this.tabSHA2.Controls.Add(this.btnSHA2DoIt);
            this.tabSHA2.Controls.Add(this.tbSHA2OutFile);
            this.tabSHA2.Controls.Add(this.btnSHA2OutFileSave);
            this.tabSHA2.Controls.Add(this.btnSHA2InFile);
            this.tabSHA2.Location = new System.Drawing.Point(4, 22);
            this.tabSHA2.Name = "tabSHA2";
            this.tabSHA2.Size = new System.Drawing.Size(720, 375);
            this.tabSHA2.TabIndex = 3;
            this.tabSHA2.Text = "SHA-2";
            this.tabSHA2.UseVisualStyleBackColor = true;
            // 
            // cbSHA2Size
            // 
            this.cbSHA2Size.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbSHA2Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSHA2Size.FormattingEnabled = true;
            this.cbSHA2Size.Items.AddRange(new object[] {
            "256 bita",
            "384 bita",
            "512 bita"});
            this.cbSHA2Size.Location = new System.Drawing.Point(111, 167);
            this.cbSHA2Size.Name = "cbSHA2Size";
            this.cbSHA2Size.Size = new System.Drawing.Size(74, 21);
            this.cbSHA2Size.TabIndex = 29;
            // 
            // rtbSHA2
            // 
            this.rtbSHA2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSHA2.Location = new System.Drawing.Point(111, 267);
            this.rtbSHA2.Name = "rtbSHA2";
            this.rtbSHA2.ReadOnly = true;
            this.rtbSHA2.Size = new System.Drawing.Size(434, 76);
            this.rtbSHA2.TabIndex = 15;
            this.rtbSHA2.Text = "";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(108, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Sažetak:";
            // 
            // btnSHA2OutFileShow
            // 
            this.btnSHA2OutFileShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSHA2OutFileShow.Location = new System.Drawing.Point(632, 126);
            this.btnSHA2OutFileShow.Name = "btnSHA2OutFileShow";
            this.btnSHA2OutFileShow.Size = new System.Drawing.Size(75, 21);
            this.btnSHA2OutFileShow.TabIndex = 8;
            this.btnSHA2OutFileShow.Text = "Pregledaj";
            this.btnSHA2OutFileShow.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ulazna datoteka:";
            // 
            // btnSHA2InFileShow
            // 
            this.btnSHA2InFileShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSHA2InFileShow.Location = new System.Drawing.Point(632, 98);
            this.btnSHA2InFileShow.Name = "btnSHA2InFileShow";
            this.btnSHA2InFileShow.Size = new System.Drawing.Size(75, 21);
            this.btnSHA2InFileShow.TabIndex = 9;
            this.btnSHA2InFileShow.Text = "Pregledaj";
            this.btnSHA2InFileShow.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Izlazna datoteka:";
            // 
            // tbSHA2InFile
            // 
            this.tbSHA2InFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHA2InFile.Location = new System.Drawing.Point(109, 99);
            this.tbSHA2InFile.Name = "tbSHA2InFile";
            this.tbSHA2InFile.Size = new System.Drawing.Size(436, 20);
            this.tbSHA2InFile.TabIndex = 6;
            // 
            // btnSHA2DoIt
            // 
            this.btnSHA2DoIt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSHA2DoIt.Location = new System.Drawing.Point(109, 196);
            this.btnSHA2DoIt.Name = "btnSHA2DoIt";
            this.btnSHA2DoIt.Size = new System.Drawing.Size(161, 33);
            this.btnSHA2DoIt.TabIndex = 10;
            this.btnSHA2DoIt.Text = "Obavi";
            this.btnSHA2DoIt.UseVisualStyleBackColor = true;
            this.btnSHA2DoIt.Click += new System.EventHandler(this.btnSHA2DoIt_Click);
            // 
            // tbSHA2OutFile
            // 
            this.tbSHA2OutFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHA2OutFile.Location = new System.Drawing.Point(109, 127);
            this.tbSHA2OutFile.Name = "tbSHA2OutFile";
            this.tbSHA2OutFile.Size = new System.Drawing.Size(436, 20);
            this.tbSHA2OutFile.TabIndex = 7;
            // 
            // btnSHA2OutFileSave
            // 
            this.btnSHA2OutFileSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSHA2OutFileSave.Location = new System.Drawing.Point(551, 126);
            this.btnSHA2OutFileSave.Name = "btnSHA2OutFileSave";
            this.btnSHA2OutFileSave.Size = new System.Drawing.Size(75, 21);
            this.btnSHA2OutFileSave.TabIndex = 11;
            this.btnSHA2OutFileSave.Text = "Odaberi";
            this.btnSHA2OutFileSave.UseVisualStyleBackColor = true;
            // 
            // btnSHA2InFile
            // 
            this.btnSHA2InFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSHA2InFile.Location = new System.Drawing.Point(551, 98);
            this.btnSHA2InFile.Name = "btnSHA2InFile";
            this.btnSHA2InFile.Size = new System.Drawing.Size(75, 21);
            this.btnSHA2InFile.TabIndex = 13;
            this.btnSHA2InFile.Text = "Odaberi";
            this.btnSHA2InFile.UseVisualStyleBackColor = true;
            // 
            // tabSHA2Manual
            // 
            this.tabSHA2Manual.Controls.Add(this.rtbSHA2Manual);
            this.tabSHA2Manual.Controls.Add(this.label29);
            this.tabSHA2Manual.Controls.Add(this.btnSHA2ManualOutFileShow);
            this.tabSHA2Manual.Controls.Add(this.label30);
            this.tabSHA2Manual.Controls.Add(this.btnSHA2ManualInFileShow);
            this.tabSHA2Manual.Controls.Add(this.label32);
            this.tabSHA2Manual.Controls.Add(this.label31);
            this.tabSHA2Manual.Controls.Add(this.tbSHA2ManualInFile);
            this.tabSHA2Manual.Controls.Add(this.btnSHA2ManualDoIt);
            this.tabSHA2Manual.Controls.Add(this.tbSHA2ManualOutFile);
            this.tabSHA2Manual.Controls.Add(this.btnSHA2ManualOutFileSave);
            this.tabSHA2Manual.Controls.Add(this.btnSHA2ManualInFile);
            this.tabSHA2Manual.Location = new System.Drawing.Point(4, 22);
            this.tabSHA2Manual.Name = "tabSHA2Manual";
            this.tabSHA2Manual.Size = new System.Drawing.Size(720, 375);
            this.tabSHA2Manual.TabIndex = 7;
            this.tabSHA2Manual.Text = "SHA-2 Ručno";
            this.tabSHA2Manual.UseVisualStyleBackColor = true;
            // 
            // rtbSHA2Manual
            // 
            this.rtbSHA2Manual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSHA2Manual.Location = new System.Drawing.Point(111, 267);
            this.rtbSHA2Manual.Name = "rtbSHA2Manual";
            this.rtbSHA2Manual.ReadOnly = true;
            this.rtbSHA2Manual.Size = new System.Drawing.Size(434, 76);
            this.rtbSHA2Manual.TabIndex = 40;
            this.rtbSHA2Manual.Text = "";
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(108, 245);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(49, 13);
            this.label29.TabIndex = 39;
            this.label29.Text = "Sažetak:";
            // 
            // btnSHA2ManualOutFileShow
            // 
            this.btnSHA2ManualOutFileShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSHA2ManualOutFileShow.Location = new System.Drawing.Point(632, 126);
            this.btnSHA2ManualOutFileShow.Name = "btnSHA2ManualOutFileShow";
            this.btnSHA2ManualOutFileShow.Size = new System.Drawing.Size(75, 21);
            this.btnSHA2ManualOutFileShow.TabIndex = 34;
            this.btnSHA2ManualOutFileShow.Text = "Pregledaj";
            this.btnSHA2ManualOutFileShow.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(15, 102);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(88, 13);
            this.label30.TabIndex = 30;
            this.label30.Text = "Ulazna datoteka:";
            // 
            // btnSHA2ManualInFileShow
            // 
            this.btnSHA2ManualInFileShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSHA2ManualInFileShow.Location = new System.Drawing.Point(632, 98);
            this.btnSHA2ManualInFileShow.Name = "btnSHA2ManualInFileShow";
            this.btnSHA2ManualInFileShow.Size = new System.Drawing.Size(75, 21);
            this.btnSHA2ManualInFileShow.TabIndex = 35;
            this.btnSHA2ManualInFileShow.Text = "Pregledaj";
            this.btnSHA2ManualInFileShow.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(108, 175);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(48, 13);
            this.label32.TabIndex = 31;
            this.label32.Text = "256 bita:";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(15, 130);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(88, 13);
            this.label31.TabIndex = 31;
            this.label31.Text = "Izlazna datoteka:";
            // 
            // tbSHA2ManualInFile
            // 
            this.tbSHA2ManualInFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHA2ManualInFile.Location = new System.Drawing.Point(109, 99);
            this.tbSHA2ManualInFile.Name = "tbSHA2ManualInFile";
            this.tbSHA2ManualInFile.Size = new System.Drawing.Size(436, 20);
            this.tbSHA2ManualInFile.TabIndex = 32;
            // 
            // btnSHA2ManualDoIt
            // 
            this.btnSHA2ManualDoIt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSHA2ManualDoIt.Location = new System.Drawing.Point(109, 196);
            this.btnSHA2ManualDoIt.Name = "btnSHA2ManualDoIt";
            this.btnSHA2ManualDoIt.Size = new System.Drawing.Size(161, 33);
            this.btnSHA2ManualDoIt.TabIndex = 36;
            this.btnSHA2ManualDoIt.Text = "Obavi";
            this.btnSHA2ManualDoIt.UseVisualStyleBackColor = true;
            this.btnSHA2ManualDoIt.Click += new System.EventHandler(this.btnSHA2ManualDoIt_Click);
            // 
            // tbSHA2ManualOutFile
            // 
            this.tbSHA2ManualOutFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHA2ManualOutFile.Location = new System.Drawing.Point(109, 127);
            this.tbSHA2ManualOutFile.Name = "tbSHA2ManualOutFile";
            this.tbSHA2ManualOutFile.Size = new System.Drawing.Size(436, 20);
            this.tbSHA2ManualOutFile.TabIndex = 33;
            // 
            // btnSHA2ManualOutFileSave
            // 
            this.btnSHA2ManualOutFileSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSHA2ManualOutFileSave.Location = new System.Drawing.Point(551, 126);
            this.btnSHA2ManualOutFileSave.Name = "btnSHA2ManualOutFileSave";
            this.btnSHA2ManualOutFileSave.Size = new System.Drawing.Size(75, 21);
            this.btnSHA2ManualOutFileSave.TabIndex = 37;
            this.btnSHA2ManualOutFileSave.Text = "Odaberi";
            this.btnSHA2ManualOutFileSave.UseVisualStyleBackColor = true;
            // 
            // btnSHA2ManualInFile
            // 
            this.btnSHA2ManualInFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSHA2ManualInFile.Location = new System.Drawing.Point(551, 98);
            this.btnSHA2ManualInFile.Name = "btnSHA2ManualInFile";
            this.btnSHA2ManualInFile.Size = new System.Drawing.Size(75, 21);
            this.btnSHA2ManualInFile.TabIndex = 38;
            this.btnSHA2ManualInFile.Text = "Odaberi";
            this.btnSHA2ManualInFile.UseVisualStyleBackColor = true;
            // 
            // tabEnvelope
            // 
            this.tabEnvelope.Controls.Add(this.label12);
            this.tabEnvelope.Controls.Add(this.tbEnvelopePubKey);
            this.tabEnvelope.Controls.Add(this.btnEnvelopePubKeyShow);
            this.tabEnvelope.Controls.Add(this.btnEnvelopePubKey);
            this.tabEnvelope.Controls.Add(this.label13);
            this.tabEnvelope.Controls.Add(this.btnEnvelopeOutFileShow);
            this.tabEnvelope.Controls.Add(this.btnEnvelopeShow);
            this.tabEnvelope.Controls.Add(this.label14);
            this.tabEnvelope.Controls.Add(this.btnEnvelopeInFileShow);
            this.tabEnvelope.Controls.Add(this.label16);
            this.tabEnvelope.Controls.Add(this.label15);
            this.tabEnvelope.Controls.Add(this.tbEnvelopePrivKey);
            this.tabEnvelope.Controls.Add(this.btnEnvelopePrivKeyShow);
            this.tabEnvelope.Controls.Add(this.tbEnvelopeInFile);
            this.tabEnvelope.Controls.Add(this.tbEnvelopeOutFile);
            this.tabEnvelope.Controls.Add(this.btnEnvelopeShowIt);
            this.tabEnvelope.Controls.Add(this.btnEnvelopeDoIt);
            this.tabEnvelope.Controls.Add(this.btnEnvelopeOutFileSave);
            this.tabEnvelope.Controls.Add(this.tbEnvelope);
            this.tabEnvelope.Controls.Add(this.btnEnvelopeSave);
            this.tabEnvelope.Controls.Add(this.btnEnvelopePrivKey);
            this.tabEnvelope.Controls.Add(this.btnEnvelopeInFile);
            this.tabEnvelope.Location = new System.Drawing.Point(4, 22);
            this.tabEnvelope.Name = "tabEnvelope";
            this.tabEnvelope.Size = new System.Drawing.Size(720, 375);
            this.tabEnvelope.TabIndex = 6;
            this.tabEnvelope.Text = "Digitalna omotnica";
            this.tabEnvelope.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Javni ključ primatelja:";
            // 
            // tbEnvelopePubKey
            // 
            this.tbEnvelopePubKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEnvelopePubKey.Location = new System.Drawing.Point(165, 110);
            this.tbEnvelopePubKey.Name = "tbEnvelopePubKey";
            this.tbEnvelopePubKey.Size = new System.Drawing.Size(372, 20);
            this.tbEnvelopePubKey.TabIndex = 45;
            // 
            // btnEnvelopePubKeyShow
            // 
            this.btnEnvelopePubKeyShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEnvelopePubKeyShow.Location = new System.Drawing.Point(624, 110);
            this.btnEnvelopePubKeyShow.Name = "btnEnvelopePubKeyShow";
            this.btnEnvelopePubKeyShow.Size = new System.Drawing.Size(75, 21);
            this.btnEnvelopePubKeyShow.TabIndex = 47;
            this.btnEnvelopePubKeyShow.Text = "Pregledaj";
            this.btnEnvelopePubKeyShow.UseVisualStyleBackColor = true;
            // 
            // btnEnvelopePubKey
            // 
            this.btnEnvelopePubKey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEnvelopePubKey.Location = new System.Drawing.Point(543, 110);
            this.btnEnvelopePubKey.Name = "btnEnvelopePubKey";
            this.btnEnvelopePubKey.Size = new System.Drawing.Size(75, 21);
            this.btnEnvelopePubKey.TabIndex = 46;
            this.btnEnvelopePubKey.Text = "Odaberi";
            this.btnEnvelopePubKey.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Privatni ključ primatelja:";
            // 
            // btnEnvelopeOutFileShow
            // 
            this.btnEnvelopeOutFileShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEnvelopeOutFileShow.Location = new System.Drawing.Point(624, 242);
            this.btnEnvelopeOutFileShow.Name = "btnEnvelopeOutFileShow";
            this.btnEnvelopeOutFileShow.Size = new System.Drawing.Size(75, 21);
            this.btnEnvelopeOutFileShow.TabIndex = 40;
            this.btnEnvelopeOutFileShow.Text = "Pregledaj";
            this.btnEnvelopeOutFileShow.UseVisualStyleBackColor = true;
            // 
            // btnEnvelopeShow
            // 
            this.btnEnvelopeShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEnvelopeShow.Location = new System.Drawing.Point(624, 137);
            this.btnEnvelopeShow.Name = "btnEnvelopeShow";
            this.btnEnvelopeShow.Size = new System.Drawing.Size(75, 21);
            this.btnEnvelopeShow.TabIndex = 40;
            this.btnEnvelopeShow.Text = "Pregledaj";
            this.btnEnvelopeShow.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Ulazna datoteka:";
            // 
            // btnEnvelopeInFileShow
            // 
            this.btnEnvelopeInFileShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEnvelopeInFileShow.Location = new System.Drawing.Point(624, 81);
            this.btnEnvelopeInFileShow.Name = "btnEnvelopeInFileShow";
            this.btnEnvelopeInFileShow.Size = new System.Drawing.Size(75, 21);
            this.btnEnvelopeInFileShow.TabIndex = 39;
            this.btnEnvelopeInFileShow.Text = "Pregledaj";
            this.btnEnvelopeInFileShow.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(46, 246);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Izlazna datoteka:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(46, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Digitalna omotnica:";
            // 
            // tbEnvelopePrivKey
            // 
            this.tbEnvelopePrivKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEnvelopePrivKey.Location = new System.Drawing.Point(165, 215);
            this.tbEnvelopePrivKey.Name = "tbEnvelopePrivKey";
            this.tbEnvelopePrivKey.Size = new System.Drawing.Size(372, 20);
            this.tbEnvelopePrivKey.TabIndex = 33;
            // 
            // btnEnvelopePrivKeyShow
            // 
            this.btnEnvelopePrivKeyShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEnvelopePrivKeyShow.Location = new System.Drawing.Point(624, 214);
            this.btnEnvelopePrivKeyShow.Name = "btnEnvelopePrivKeyShow";
            this.btnEnvelopePrivKeyShow.Size = new System.Drawing.Size(75, 21);
            this.btnEnvelopePrivKeyShow.TabIndex = 41;
            this.btnEnvelopePrivKeyShow.Text = "Pregledaj";
            this.btnEnvelopePrivKeyShow.UseVisualStyleBackColor = true;
            // 
            // tbEnvelopeInFile
            // 
            this.tbEnvelopeInFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEnvelopeInFile.Location = new System.Drawing.Point(165, 82);
            this.tbEnvelopeInFile.Name = "tbEnvelopeInFile";
            this.tbEnvelopeInFile.Size = new System.Drawing.Size(372, 20);
            this.tbEnvelopeInFile.TabIndex = 32;
            // 
            // tbEnvelopeOutFile
            // 
            this.tbEnvelopeOutFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEnvelopeOutFile.Location = new System.Drawing.Point(165, 243);
            this.tbEnvelopeOutFile.Name = "tbEnvelopeOutFile";
            this.tbEnvelopeOutFile.Size = new System.Drawing.Size(372, 20);
            this.tbEnvelopeOutFile.TabIndex = 31;
            // 
            // btnEnvelopeShowIt
            // 
            this.btnEnvelopeShowIt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEnvelopeShowIt.Location = new System.Drawing.Point(164, 269);
            this.btnEnvelopeShowIt.Name = "btnEnvelopeShowIt";
            this.btnEnvelopeShowIt.Size = new System.Drawing.Size(161, 33);
            this.btnEnvelopeShowIt.TabIndex = 36;
            this.btnEnvelopeShowIt.Text = "Otvori digitalnu omotnicu";
            this.btnEnvelopeShowIt.UseVisualStyleBackColor = true;
            this.btnEnvelopeShowIt.Click += new System.EventHandler(this.btnEnvelopeShowIt_Click);
            // 
            // btnEnvelopeDoIt
            // 
            this.btnEnvelopeDoIt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEnvelopeDoIt.Location = new System.Drawing.Point(164, 164);
            this.btnEnvelopeDoIt.Name = "btnEnvelopeDoIt";
            this.btnEnvelopeDoIt.Size = new System.Drawing.Size(161, 33);
            this.btnEnvelopeDoIt.TabIndex = 36;
            this.btnEnvelopeDoIt.Text = "Generiraj digitalnu omotnicu";
            this.btnEnvelopeDoIt.UseVisualStyleBackColor = true;
            this.btnEnvelopeDoIt.Click += new System.EventHandler(this.btnEnvelopeDoIt_Click);
            // 
            // btnEnvelopeOutFileSave
            // 
            this.btnEnvelopeOutFileSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEnvelopeOutFileSave.Location = new System.Drawing.Point(543, 242);
            this.btnEnvelopeOutFileSave.Name = "btnEnvelopeOutFileSave";
            this.btnEnvelopeOutFileSave.Size = new System.Drawing.Size(75, 21);
            this.btnEnvelopeOutFileSave.TabIndex = 35;
            this.btnEnvelopeOutFileSave.Text = "Odaberi";
            this.btnEnvelopeOutFileSave.UseVisualStyleBackColor = true;
            // 
            // tbEnvelope
            // 
            this.tbEnvelope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEnvelope.Location = new System.Drawing.Point(165, 138);
            this.tbEnvelope.Name = "tbEnvelope";
            this.tbEnvelope.Size = new System.Drawing.Size(372, 20);
            this.tbEnvelope.TabIndex = 31;
            // 
            // btnEnvelopeSave
            // 
            this.btnEnvelopeSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEnvelopeSave.Location = new System.Drawing.Point(543, 137);
            this.btnEnvelopeSave.Name = "btnEnvelopeSave";
            this.btnEnvelopeSave.Size = new System.Drawing.Size(75, 21);
            this.btnEnvelopeSave.TabIndex = 35;
            this.btnEnvelopeSave.Text = "Odaberi";
            this.btnEnvelopeSave.UseVisualStyleBackColor = true;
            // 
            // btnEnvelopePrivKey
            // 
            this.btnEnvelopePrivKey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEnvelopePrivKey.Location = new System.Drawing.Point(543, 214);
            this.btnEnvelopePrivKey.Name = "btnEnvelopePrivKey";
            this.btnEnvelopePrivKey.Size = new System.Drawing.Size(75, 21);
            this.btnEnvelopePrivKey.TabIndex = 38;
            this.btnEnvelopePrivKey.Text = "Odaberi";
            this.btnEnvelopePrivKey.UseVisualStyleBackColor = true;
            // 
            // btnEnvelopeInFile
            // 
            this.btnEnvelopeInFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEnvelopeInFile.Location = new System.Drawing.Point(543, 81);
            this.btnEnvelopeInFile.Name = "btnEnvelopeInFile";
            this.btnEnvelopeInFile.Size = new System.Drawing.Size(75, 21);
            this.btnEnvelopeInFile.TabIndex = 37;
            this.btnEnvelopeInFile.Text = "Odaberi";
            this.btnEnvelopeInFile.UseVisualStyleBackColor = true;
            // 
            // tabSignature
            // 
            this.tabSignature.Controls.Add(this.chbSignatureSHA2);
            this.tabSignature.Controls.Add(this.label17);
            this.tabSignature.Controls.Add(this.tbSignaturePrivKey);
            this.tabSignature.Controls.Add(this.btnSignaturePrivKeyShow);
            this.tabSignature.Controls.Add(this.btnSignaturePrivKey);
            this.tabSignature.Controls.Add(this.label18);
            this.tabSignature.Controls.Add(this.btnSignatureShow);
            this.tabSignature.Controls.Add(this.label19);
            this.tabSignature.Controls.Add(this.btnSignatureInFileShow);
            this.tabSignature.Controls.Add(this.label21);
            this.tabSignature.Controls.Add(this.tbSignaturePubKey);
            this.tabSignature.Controls.Add(this.btnSignaturePubKeyShow);
            this.tabSignature.Controls.Add(this.tbSignatureInFile);
            this.tabSignature.Controls.Add(this.btnSignatureCheckIt);
            this.tabSignature.Controls.Add(this.btnSignatureDoIt);
            this.tabSignature.Controls.Add(this.tbSignature);
            this.tabSignature.Controls.Add(this.btnSignatureSave);
            this.tabSignature.Controls.Add(this.btnSignaturePubKey);
            this.tabSignature.Controls.Add(this.btnSignatureInFile);
            this.tabSignature.Location = new System.Drawing.Point(4, 22);
            this.tabSignature.Name = "tabSignature";
            this.tabSignature.Size = new System.Drawing.Size(720, 375);
            this.tabSignature.TabIndex = 4;
            this.tabSignature.Text = "Digitalni potpis";
            this.tabSignature.UseVisualStyleBackColor = true;
            // 
            // chbSignatureSHA2
            // 
            this.chbSignatureSHA2.AutoSize = true;
            this.chbSignatureSHA2.Location = new System.Drawing.Point(331, 248);
            this.chbSignatureSHA2.Name = "chbSignatureSHA2";
            this.chbSignatureSHA2.Size = new System.Drawing.Size(116, 17);
            this.chbSignatureSHA2.TabIndex = 70;
            this.chbSignatureSHA2.Text = "Koristiti ručni SHA2";
            this.chbSignatureSHA2.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(42, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 13);
            this.label17.TabIndex = 66;
            this.label17.Text = "Privatni ključ pošiljatelja:";
            // 
            // tbSignaturePrivKey
            // 
            this.tbSignaturePrivKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSignaturePrivKey.Location = new System.Drawing.Point(164, 109);
            this.tbSignaturePrivKey.Name = "tbSignaturePrivKey";
            this.tbSignaturePrivKey.Size = new System.Drawing.Size(380, 20);
            this.tbSignaturePrivKey.TabIndex = 67;
            // 
            // btnSignaturePrivKeyShow
            // 
            this.btnSignaturePrivKeyShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSignaturePrivKeyShow.Location = new System.Drawing.Point(631, 108);
            this.btnSignaturePrivKeyShow.Name = "btnSignaturePrivKeyShow";
            this.btnSignaturePrivKeyShow.Size = new System.Drawing.Size(75, 21);
            this.btnSignaturePrivKeyShow.TabIndex = 69;
            this.btnSignaturePrivKeyShow.Text = "Pregledaj";
            this.btnSignaturePrivKeyShow.UseVisualStyleBackColor = true;
            // 
            // btnSignaturePrivKey
            // 
            this.btnSignaturePrivKey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSignaturePrivKey.Location = new System.Drawing.Point(550, 108);
            this.btnSignaturePrivKey.Name = "btnSignaturePrivKey";
            this.btnSignaturePrivKey.Size = new System.Drawing.Size(75, 21);
            this.btnSignaturePrivKey.TabIndex = 68;
            this.btnSignaturePrivKey.Text = "Odaberi";
            this.btnSignaturePrivKey.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(42, 217);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "Javni ključ pošiljatelja:";
            // 
            // btnSignatureShow
            // 
            this.btnSignatureShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSignatureShow.Location = new System.Drawing.Point(631, 136);
            this.btnSignatureShow.Name = "btnSignatureShow";
            this.btnSignatureShow.Size = new System.Drawing.Size(75, 21);
            this.btnSignatureShow.TabIndex = 63;
            this.btnSignatureShow.Text = "Pregledaj";
            this.btnSignatureShow.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(42, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = "Ulazna datoteka:";
            // 
            // btnSignatureInFileShow
            // 
            this.btnSignatureInFileShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSignatureInFileShow.Location = new System.Drawing.Point(631, 80);
            this.btnSignatureInFileShow.Name = "btnSignatureInFileShow";
            this.btnSignatureInFileShow.Size = new System.Drawing.Size(75, 21);
            this.btnSignatureInFileShow.TabIndex = 62;
            this.btnSignatureInFileShow.Text = "Pregledaj";
            this.btnSignatureInFileShow.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(42, 140);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 13);
            this.label21.TabIndex = 50;
            this.label21.Text = "Digitalni potpis:";
            // 
            // tbSignaturePubKey
            // 
            this.tbSignaturePubKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSignaturePubKey.Location = new System.Drawing.Point(164, 214);
            this.tbSignaturePubKey.Name = "tbSignaturePubKey";
            this.tbSignaturePubKey.Size = new System.Drawing.Size(380, 20);
            this.tbSignaturePubKey.TabIndex = 55;
            // 
            // btnSignaturePubKeyShow
            // 
            this.btnSignaturePubKeyShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSignaturePubKeyShow.Location = new System.Drawing.Point(631, 213);
            this.btnSignaturePubKeyShow.Name = "btnSignaturePubKeyShow";
            this.btnSignaturePubKeyShow.Size = new System.Drawing.Size(75, 21);
            this.btnSignaturePubKeyShow.TabIndex = 65;
            this.btnSignaturePubKeyShow.Text = "Pregledaj";
            this.btnSignaturePubKeyShow.UseVisualStyleBackColor = true;
            // 
            // tbSignatureInFile
            // 
            this.tbSignatureInFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSignatureInFile.Location = new System.Drawing.Point(164, 81);
            this.tbSignatureInFile.Name = "tbSignatureInFile";
            this.tbSignatureInFile.Size = new System.Drawing.Size(380, 20);
            this.tbSignatureInFile.TabIndex = 54;
            // 
            // btnSignatureCheckIt
            // 
            this.btnSignatureCheckIt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSignatureCheckIt.Location = new System.Drawing.Point(164, 239);
            this.btnSignatureCheckIt.Name = "btnSignatureCheckIt";
            this.btnSignatureCheckIt.Size = new System.Drawing.Size(161, 33);
            this.btnSignatureCheckIt.TabIndex = 59;
            this.btnSignatureCheckIt.Text = "Provjeri digitalni potpis";
            this.btnSignatureCheckIt.UseVisualStyleBackColor = true;
            this.btnSignatureCheckIt.Click += new System.EventHandler(this.btnSignatureCheckIt_Click);
            // 
            // btnSignatureDoIt
            // 
            this.btnSignatureDoIt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSignatureDoIt.Location = new System.Drawing.Point(164, 163);
            this.btnSignatureDoIt.Name = "btnSignatureDoIt";
            this.btnSignatureDoIt.Size = new System.Drawing.Size(161, 33);
            this.btnSignatureDoIt.TabIndex = 58;
            this.btnSignatureDoIt.Text = "Generiraj digitalni potpis";
            this.btnSignatureDoIt.UseVisualStyleBackColor = true;
            this.btnSignatureDoIt.Click += new System.EventHandler(this.btnSignatureDoIt_Click);
            // 
            // tbSignature
            // 
            this.tbSignature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSignature.Location = new System.Drawing.Point(164, 137);
            this.tbSignature.Name = "tbSignature";
            this.tbSignature.Size = new System.Drawing.Size(380, 20);
            this.tbSignature.TabIndex = 52;
            // 
            // btnSignatureSave
            // 
            this.btnSignatureSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSignatureSave.Location = new System.Drawing.Point(550, 136);
            this.btnSignatureSave.Name = "btnSignatureSave";
            this.btnSignatureSave.Size = new System.Drawing.Size(75, 21);
            this.btnSignatureSave.TabIndex = 56;
            this.btnSignatureSave.Text = "Odaberi";
            this.btnSignatureSave.UseVisualStyleBackColor = true;
            // 
            // btnSignaturePubKey
            // 
            this.btnSignaturePubKey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSignaturePubKey.Location = new System.Drawing.Point(550, 213);
            this.btnSignaturePubKey.Name = "btnSignaturePubKey";
            this.btnSignaturePubKey.Size = new System.Drawing.Size(75, 21);
            this.btnSignaturePubKey.TabIndex = 61;
            this.btnSignaturePubKey.Text = "Odaberi";
            this.btnSignaturePubKey.UseVisualStyleBackColor = true;
            // 
            // btnSignatureInFile
            // 
            this.btnSignatureInFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSignatureInFile.Location = new System.Drawing.Point(550, 80);
            this.btnSignatureInFile.Name = "btnSignatureInFile";
            this.btnSignatureInFile.Size = new System.Drawing.Size(75, 21);
            this.btnSignatureInFile.TabIndex = 60;
            this.btnSignatureInFile.Text = "Odaberi";
            this.btnSignatureInFile.UseVisualStyleBackColor = true;
            // 
            // tabSeal
            // 
            this.tabSeal.Controls.Add(this.label20);
            this.tabSeal.Controls.Add(this.tbSealReceiverPubKey);
            this.tabSeal.Controls.Add(this.btnSealReceiverPubKeyShow);
            this.tabSeal.Controls.Add(this.btnSealReceiverPubKey);
            this.tabSeal.Controls.Add(this.label25);
            this.tabSeal.Controls.Add(this.label28);
            this.tabSeal.Controls.Add(this.label27);
            this.tabSeal.Controls.Add(this.label22);
            this.tabSeal.Controls.Add(this.btnSealSignatureShow);
            this.tabSeal.Controls.Add(this.btnSealEnvelopeShow);
            this.tabSeal.Controls.Add(this.label23);
            this.tabSeal.Controls.Add(this.btnSealSenderPrivKeyShow);
            this.tabSeal.Controls.Add(this.tbSealInFile);
            this.tabSeal.Controls.Add(this.label26);
            this.tabSeal.Controls.Add(this.tbSealOutFile);
            this.tabSeal.Controls.Add(this.label24);
            this.tabSeal.Controls.Add(this.tbSealReceiverPrivKey);
            this.tabSeal.Controls.Add(this.btnSealOutFileShow);
            this.tabSeal.Controls.Add(this.btnSealInFileShow);
            this.tabSeal.Controls.Add(this.btnSealReceiverPrivKeyShow);
            this.tabSeal.Controls.Add(this.tbSealSenderPubKey);
            this.tabSeal.Controls.Add(this.btnSealSenderPubKeyShow);
            this.tabSeal.Controls.Add(this.tbSealSenderPrivKey);
            this.tabSeal.Controls.Add(this.btnSealOpenIt);
            this.tabSeal.Controls.Add(this.tbSealSignature);
            this.tabSeal.Controls.Add(this.btnSealDoIt);
            this.tabSeal.Controls.Add(this.tbSealEnvelope);
            this.tabSeal.Controls.Add(this.btnSealSignatureSave);
            this.tabSeal.Controls.Add(this.btnSealOutFileSave);
            this.tabSeal.Controls.Add(this.btnSealInFile);
            this.tabSeal.Controls.Add(this.btnSealReceiverPrivKey);
            this.tabSeal.Controls.Add(this.btnSealEnvelope);
            this.tabSeal.Controls.Add(this.btnSealSenderPubKey);
            this.tabSeal.Controls.Add(this.btnSealSenderPrivKey);
            this.tabSeal.Location = new System.Drawing.Point(4, 22);
            this.tabSeal.Name = "tabSeal";
            this.tabSeal.Size = new System.Drawing.Size(720, 375);
            this.tabSeal.TabIndex = 5;
            this.tabSeal.Text = "Digitalni pečat";
            this.tabSeal.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(39, 89);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(121, 13);
            this.label20.TabIndex = 84;
            this.label20.Text = "Privatni ključ pošiljatelja:";
            // 
            // tbSealReceiverPubKey
            // 
            this.tbSealReceiverPubKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSealReceiverPubKey.Location = new System.Drawing.Point(162, 57);
            this.tbSealReceiverPubKey.Name = "tbSealReceiverPubKey";
            this.tbSealReceiverPubKey.Size = new System.Drawing.Size(381, 20);
            this.tbSealReceiverPubKey.TabIndex = 85;
            // 
            // btnSealReceiverPubKeyShow
            // 
            this.btnSealReceiverPubKeyShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSealReceiverPubKeyShow.Location = new System.Drawing.Point(630, 56);
            this.btnSealReceiverPubKeyShow.Name = "btnSealReceiverPubKeyShow";
            this.btnSealReceiverPubKeyShow.Size = new System.Drawing.Size(75, 21);
            this.btnSealReceiverPubKeyShow.TabIndex = 87;
            this.btnSealReceiverPubKeyShow.Text = "Pregledaj";
            this.btnSealReceiverPubKeyShow.UseVisualStyleBackColor = true;
            // 
            // btnSealReceiverPubKey
            // 
            this.btnSealReceiverPubKey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSealReceiverPubKey.Location = new System.Drawing.Point(549, 56);
            this.btnSealReceiverPubKey.Name = "btnSealReceiverPubKey";
            this.btnSealReceiverPubKey.Size = new System.Drawing.Size(75, 21);
            this.btnSealReceiverPubKey.TabIndex = 86;
            this.btnSealReceiverPubKey.Text = "Odaberi";
            this.btnSealReceiverPubKey.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(39, 60);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(107, 13);
            this.label25.TabIndex = 70;
            this.label25.Text = "Javni ključ primatelja:";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(39, 299);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(88, 13);
            this.label28.TabIndex = 70;
            this.label28.Text = "Izlazna datoteka:";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(39, 266);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(117, 13);
            this.label27.TabIndex = 70;
            this.label27.Text = "Privatni ključ primatelja:";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(39, 235);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 13);
            this.label22.TabIndex = 70;
            this.label22.Text = "Javni ključ pošiljatelja:";
            // 
            // btnSealSignatureShow
            // 
            this.btnSealSignatureShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSealSignatureShow.Location = new System.Drawing.Point(630, 143);
            this.btnSealSignatureShow.Name = "btnSealSignatureShow";
            this.btnSealSignatureShow.Size = new System.Drawing.Size(75, 21);
            this.btnSealSignatureShow.TabIndex = 82;
            this.btnSealSignatureShow.Text = "Pregledaj";
            this.btnSealSignatureShow.UseVisualStyleBackColor = true;
            // 
            // btnSealEnvelopeShow
            // 
            this.btnSealEnvelopeShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSealEnvelopeShow.Location = new System.Drawing.Point(630, 113);
            this.btnSealEnvelopeShow.Name = "btnSealEnvelopeShow";
            this.btnSealEnvelopeShow.Size = new System.Drawing.Size(75, 21);
            this.btnSealEnvelopeShow.TabIndex = 82;
            this.btnSealEnvelopeShow.Text = "Pregledaj";
            this.btnSealEnvelopeShow.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(39, 31);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 13);
            this.label23.TabIndex = 71;
            this.label23.Text = "Ulazna datoteka:";
            // 
            // btnSealSenderPrivKeyShow
            // 
            this.btnSealSenderPrivKeyShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSealSenderPrivKeyShow.Location = new System.Drawing.Point(630, 85);
            this.btnSealSenderPrivKeyShow.Name = "btnSealSenderPrivKeyShow";
            this.btnSealSenderPrivKeyShow.Size = new System.Drawing.Size(75, 21);
            this.btnSealSenderPrivKeyShow.TabIndex = 81;
            this.btnSealSenderPrivKeyShow.Text = "Pregledaj";
            this.btnSealSenderPrivKeyShow.UseVisualStyleBackColor = true;
            // 
            // tbSealInFile
            // 
            this.tbSealInFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSealInFile.Location = new System.Drawing.Point(162, 27);
            this.tbSealInFile.Name = "tbSealInFile";
            this.tbSealInFile.Size = new System.Drawing.Size(381, 20);
            this.tbSealInFile.TabIndex = 75;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(39, 147);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(78, 13);
            this.label26.TabIndex = 72;
            this.label26.Text = "Digitalni potpis:";
            // 
            // tbSealOutFile
            // 
            this.tbSealOutFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSealOutFile.Location = new System.Drawing.Point(162, 296);
            this.tbSealOutFile.Name = "tbSealOutFile";
            this.tbSealOutFile.Size = new System.Drawing.Size(381, 20);
            this.tbSealOutFile.TabIndex = 75;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(39, 117);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 13);
            this.label24.TabIndex = 72;
            this.label24.Text = "Digitalna omotnica:";
            // 
            // tbSealReceiverPrivKey
            // 
            this.tbSealReceiverPrivKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSealReceiverPrivKey.Location = new System.Drawing.Point(162, 263);
            this.tbSealReceiverPrivKey.Name = "tbSealReceiverPrivKey";
            this.tbSealReceiverPrivKey.Size = new System.Drawing.Size(381, 20);
            this.tbSealReceiverPrivKey.TabIndex = 75;
            // 
            // btnSealOutFileShow
            // 
            this.btnSealOutFileShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSealOutFileShow.Location = new System.Drawing.Point(630, 295);
            this.btnSealOutFileShow.Name = "btnSealOutFileShow";
            this.btnSealOutFileShow.Size = new System.Drawing.Size(75, 21);
            this.btnSealOutFileShow.TabIndex = 83;
            this.btnSealOutFileShow.Text = "Pregledaj";
            this.btnSealOutFileShow.UseVisualStyleBackColor = true;
            // 
            // btnSealInFileShow
            // 
            this.btnSealInFileShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSealInFileShow.Location = new System.Drawing.Point(630, 26);
            this.btnSealInFileShow.Name = "btnSealInFileShow";
            this.btnSealInFileShow.Size = new System.Drawing.Size(75, 21);
            this.btnSealInFileShow.TabIndex = 83;
            this.btnSealInFileShow.Text = "Pregledaj";
            this.btnSealInFileShow.UseVisualStyleBackColor = true;
            // 
            // btnSealReceiverPrivKeyShow
            // 
            this.btnSealReceiverPrivKeyShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSealReceiverPrivKeyShow.Location = new System.Drawing.Point(630, 262);
            this.btnSealReceiverPrivKeyShow.Name = "btnSealReceiverPrivKeyShow";
            this.btnSealReceiverPrivKeyShow.Size = new System.Drawing.Size(75, 21);
            this.btnSealReceiverPrivKeyShow.TabIndex = 83;
            this.btnSealReceiverPrivKeyShow.Text = "Pregledaj";
            this.btnSealReceiverPrivKeyShow.UseVisualStyleBackColor = true;
            // 
            // tbSealSenderPubKey
            // 
            this.tbSealSenderPubKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSealSenderPubKey.Location = new System.Drawing.Point(162, 232);
            this.tbSealSenderPubKey.Name = "tbSealSenderPubKey";
            this.tbSealSenderPubKey.Size = new System.Drawing.Size(381, 20);
            this.tbSealSenderPubKey.TabIndex = 75;
            // 
            // btnSealSenderPubKeyShow
            // 
            this.btnSealSenderPubKeyShow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSealSenderPubKeyShow.Location = new System.Drawing.Point(630, 231);
            this.btnSealSenderPubKeyShow.Name = "btnSealSenderPubKeyShow";
            this.btnSealSenderPubKeyShow.Size = new System.Drawing.Size(75, 21);
            this.btnSealSenderPubKeyShow.TabIndex = 83;
            this.btnSealSenderPubKeyShow.Text = "Pregledaj";
            this.btnSealSenderPubKeyShow.UseVisualStyleBackColor = true;
            // 
            // tbSealSenderPrivKey
            // 
            this.tbSealSenderPrivKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSealSenderPrivKey.Location = new System.Drawing.Point(162, 86);
            this.tbSealSenderPrivKey.Name = "tbSealSenderPrivKey";
            this.tbSealSenderPrivKey.Size = new System.Drawing.Size(381, 20);
            this.tbSealSenderPrivKey.TabIndex = 74;
            // 
            // btnSealOpenIt
            // 
            this.btnSealOpenIt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSealOpenIt.Location = new System.Drawing.Point(162, 322);
            this.btnSealOpenIt.Name = "btnSealOpenIt";
            this.btnSealOpenIt.Size = new System.Drawing.Size(161, 33);
            this.btnSealOpenIt.TabIndex = 78;
            this.btnSealOpenIt.Text = "Otvori digitalni pečat";
            this.btnSealOpenIt.UseVisualStyleBackColor = true;
            this.btnSealOpenIt.Click += new System.EventHandler(this.btnSealOpenIt_Click);
            // 
            // tbSealSignature
            // 
            this.tbSealSignature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSealSignature.Location = new System.Drawing.Point(162, 144);
            this.tbSealSignature.Name = "tbSealSignature";
            this.tbSealSignature.Size = new System.Drawing.Size(381, 20);
            this.tbSealSignature.TabIndex = 73;
            // 
            // btnSealDoIt
            // 
            this.btnSealDoIt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSealDoIt.Location = new System.Drawing.Point(162, 170);
            this.btnSealDoIt.Name = "btnSealDoIt";
            this.btnSealDoIt.Size = new System.Drawing.Size(161, 33);
            this.btnSealDoIt.TabIndex = 77;
            this.btnSealDoIt.Text = "Generiraj digitalni pečat";
            this.btnSealDoIt.UseVisualStyleBackColor = true;
            this.btnSealDoIt.Click += new System.EventHandler(this.btnSealDoIt_Click);
            // 
            // tbSealEnvelope
            // 
            this.tbSealEnvelope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSealEnvelope.Location = new System.Drawing.Point(162, 114);
            this.tbSealEnvelope.Name = "tbSealEnvelope";
            this.tbSealEnvelope.Size = new System.Drawing.Size(381, 20);
            this.tbSealEnvelope.TabIndex = 73;
            // 
            // btnSealSignatureSave
            // 
            this.btnSealSignatureSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSealSignatureSave.Location = new System.Drawing.Point(549, 143);
            this.btnSealSignatureSave.Name = "btnSealSignatureSave";
            this.btnSealSignatureSave.Size = new System.Drawing.Size(75, 21);
            this.btnSealSignatureSave.TabIndex = 76;
            this.btnSealSignatureSave.Text = "Odaberi";
            this.btnSealSignatureSave.UseVisualStyleBackColor = true;
            // 
            // btnSealOutFileSave
            // 
            this.btnSealOutFileSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSealOutFileSave.Location = new System.Drawing.Point(549, 295);
            this.btnSealOutFileSave.Name = "btnSealOutFileSave";
            this.btnSealOutFileSave.Size = new System.Drawing.Size(75, 21);
            this.btnSealOutFileSave.TabIndex = 80;
            this.btnSealOutFileSave.Text = "Odaberi";
            this.btnSealOutFileSave.UseVisualStyleBackColor = true;
            // 
            // btnSealInFile
            // 
            this.btnSealInFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSealInFile.Location = new System.Drawing.Point(549, 26);
            this.btnSealInFile.Name = "btnSealInFile";
            this.btnSealInFile.Size = new System.Drawing.Size(75, 21);
            this.btnSealInFile.TabIndex = 80;
            this.btnSealInFile.Text = "Odaberi";
            this.btnSealInFile.UseVisualStyleBackColor = true;
            // 
            // btnSealReceiverPrivKey
            // 
            this.btnSealReceiverPrivKey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSealReceiverPrivKey.Location = new System.Drawing.Point(549, 262);
            this.btnSealReceiverPrivKey.Name = "btnSealReceiverPrivKey";
            this.btnSealReceiverPrivKey.Size = new System.Drawing.Size(75, 21);
            this.btnSealReceiverPrivKey.TabIndex = 80;
            this.btnSealReceiverPrivKey.Text = "Odaberi";
            this.btnSealReceiverPrivKey.UseVisualStyleBackColor = true;
            // 
            // btnSealEnvelope
            // 
            this.btnSealEnvelope.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSealEnvelope.Location = new System.Drawing.Point(549, 113);
            this.btnSealEnvelope.Name = "btnSealEnvelope";
            this.btnSealEnvelope.Size = new System.Drawing.Size(75, 21);
            this.btnSealEnvelope.TabIndex = 76;
            this.btnSealEnvelope.Text = "Odaberi";
            this.btnSealEnvelope.UseVisualStyleBackColor = true;
            // 
            // btnSealSenderPubKey
            // 
            this.btnSealSenderPubKey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSealSenderPubKey.Location = new System.Drawing.Point(549, 231);
            this.btnSealSenderPubKey.Name = "btnSealSenderPubKey";
            this.btnSealSenderPubKey.Size = new System.Drawing.Size(75, 21);
            this.btnSealSenderPubKey.TabIndex = 80;
            this.btnSealSenderPubKey.Text = "Odaberi";
            this.btnSealSenderPubKey.UseVisualStyleBackColor = true;
            // 
            // btnSealSenderPrivKey
            // 
            this.btnSealSenderPrivKey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSealSenderPrivKey.Location = new System.Drawing.Point(549, 85);
            this.btnSealSenderPrivKey.Name = "btnSealSenderPrivKey";
            this.btnSealSenderPrivKey.Size = new System.Drawing.Size(75, 21);
            this.btnSealSenderPrivKey.TabIndex = 79;
            this.btnSealSenderPrivKey.Text = "Odaberi";
            this.btnSealSenderPrivKey.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(672, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Josip Milić";
            // 
            // btnDefault
            // 
            this.btnDefault.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDefault.Location = new System.Drawing.Point(351, 404);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(122, 23);
            this.btnDefault.TabIndex = 29;
            this.btnDefault.Text = "Vrati početne putanje";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // chbOpenGenerated
            // 
            this.chbOpenGenerated.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chbOpenGenerated.AutoSize = true;
            this.chbOpenGenerated.Location = new System.Drawing.Point(479, 408);
            this.chbOpenGenerated.Name = "chbOpenGenerated";
            this.chbOpenGenerated.Size = new System.Drawing.Size(187, 17);
            this.chbOpenGenerated.TabIndex = 70;
            this.chbOpenGenerated.Text = "Otvori datoteke nakon generiranja";
            this.chbOpenGenerated.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Location = new System.Drawing.Point(7, 408);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(338, 15);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.TextChanged += new System.EventHandler(this.lblStatusTextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 429);
            this.Controls.Add(this.chbOpenGenerated);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnlTabs);
            this.Controls.Add(this.lblStatus);
            this.MaximumSize = new System.Drawing.Size(2000, 468);
            this.MinimumSize = new System.Drawing.Size(700, 468);
            this.Name = "MainForm";
            this.Text = "Enkripcija";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTabs.ResumeLayout(false);
            this.tabAES.ResumeLayout(false);
            this.tabAES.PerformLayout();
            this.tabRSA.ResumeLayout(false);
            this.tabRSA.PerformLayout();
            this.tabSHA2.ResumeLayout(false);
            this.tabSHA2.PerformLayout();
            this.tabSHA2Manual.ResumeLayout(false);
            this.tabSHA2Manual.PerformLayout();
            this.tabEnvelope.ResumeLayout(false);
            this.tabEnvelope.PerformLayout();
            this.tabSignature.ResumeLayout(false);
            this.tabSignature.PerformLayout();
            this.tabSeal.ResumeLayout(false);
            this.tabSeal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl pnlTabs;
        private System.Windows.Forms.TabPage tabAES;
        private System.Windows.Forms.RadioButton rbAESDecrypt;
        private System.Windows.Forms.RadioButton rbAESEncrypt;
        private System.Windows.Forms.Button btnAESOutFileShow;
        private System.Windows.Forms.Button btnAESInFileShow;
        private System.Windows.Forms.Button btnAESKeyGen;
        private System.Windows.Forms.Button btnAESKeyShow;
        private System.Windows.Forms.Button btnAESDoIt;
        private System.Windows.Forms.Button btnAESOutFileSave;
        private System.Windows.Forms.Button btnAESInFile;
        private System.Windows.Forms.Button btnAESKey;
        private System.Windows.Forms.TextBox tbAESOutFile;
        private System.Windows.Forms.TextBox tbAESInFile;
        private System.Windows.Forms.TextBox tbAESKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbAESKeySize;
        private System.Windows.Forms.Button btnAESSwapInOut;
        private System.Windows.Forms.TabPage tabRSA;
        private System.Windows.Forms.ComboBox cbRSAKeySize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRSAPubKeyGen;
        private System.Windows.Forms.TextBox tbRSAPubKey;
        private System.Windows.Forms.Button btnRSAPubKeyShow;
        private System.Windows.Forms.Button btnRSAPubKey;
        private System.Windows.Forms.RadioButton rbRSADecrypt;
        private System.Windows.Forms.RadioButton rbRSAEncrypt;
        private System.Windows.Forms.Button btnRSAOutFileShow;
        private System.Windows.Forms.Button btnRSAInFileShow;
        private System.Windows.Forms.TextBox tbRSAPrivKey;
        private System.Windows.Forms.Button btnRSAPrivKeyShow;
        private System.Windows.Forms.TextBox tbRSAInFile;
        private System.Windows.Forms.Button btnRSADoIt;
        private System.Windows.Forms.TextBox tbRSAOutFile;
        private System.Windows.Forms.Button btnRSAOutFileSave;
        private System.Windows.Forms.Button btnRSASwapInOut;
        private System.Windows.Forms.Button btnRSAPrivKey;
        private System.Windows.Forms.Button btnRSAInFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabSHA2;
        private System.Windows.Forms.RichTextBox rtbSHA2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSHA2OutFileShow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSHA2InFileShow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSHA2InFile;
        private System.Windows.Forms.Button btnSHA2DoIt;
        private System.Windows.Forms.TextBox tbSHA2OutFile;
        private System.Windows.Forms.Button btnSHA2OutFileSave;
        private System.Windows.Forms.Button btnSHA2InFile;
        private System.Windows.Forms.ComboBox cbSHA2Size;
        private System.Windows.Forms.TabPage tabEnvelope;
        private System.Windows.Forms.TabPage tabSignature;
        private System.Windows.Forms.TabPage tabSeal;
        private System.Windows.Forms.Button btnEnvelopeOutFileShow;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbEnvelopeOutFile;
        private System.Windows.Forms.Button btnEnvelopeShowIt;
        private System.Windows.Forms.Button btnEnvelopeOutFileSave;
        private System.Windows.Forms.Button btnEnvelopeInFile;
        private System.Windows.Forms.Button btnEnvelopePrivKey;
        private System.Windows.Forms.Button btnEnvelopeSave;
        private System.Windows.Forms.TextBox tbEnvelope;
        private System.Windows.Forms.Button btnEnvelopeDoIt;
        private System.Windows.Forms.TextBox tbEnvelopeInFile;
        private System.Windows.Forms.Button btnEnvelopePrivKeyShow;
        private System.Windows.Forms.TextBox tbEnvelopePrivKey;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnEnvelopeInFileShow;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEnvelopeShow;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEnvelopePubKey;
        private System.Windows.Forms.Button btnEnvelopePubKeyShow;
        private System.Windows.Forms.TextBox tbEnvelopePubKey;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbSignaturePrivKey;
        private System.Windows.Forms.Button btnSignaturePrivKeyShow;
        private System.Windows.Forms.Button btnSignaturePrivKey;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSignatureShow;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnSignatureInFileShow;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbSignaturePubKey;
        private System.Windows.Forms.Button btnSignaturePubKeyShow;
        private System.Windows.Forms.TextBox tbSignatureInFile;
        private System.Windows.Forms.Button btnSignatureCheckIt;
        private System.Windows.Forms.Button btnSignatureDoIt;
        private System.Windows.Forms.TextBox tbSignature;
        private System.Windows.Forms.Button btnSignatureSave;
        private System.Windows.Forms.Button btnSignaturePubKey;
        private System.Windows.Forms.Button btnSignatureInFile;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbSealReceiverPubKey;
        private System.Windows.Forms.Button btnSealReceiverPubKeyShow;
        private System.Windows.Forms.Button btnSealReceiverPubKey;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnSealSignatureShow;
        private System.Windows.Forms.Button btnSealEnvelopeShow;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnSealSenderPrivKeyShow;
        private System.Windows.Forms.TextBox tbSealInFile;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbSealOutFile;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbSealReceiverPrivKey;
        private System.Windows.Forms.Button btnSealOutFileShow;
        private System.Windows.Forms.Button btnSealInFileShow;
        private System.Windows.Forms.Button btnSealReceiverPrivKeyShow;
        private System.Windows.Forms.TextBox tbSealSenderPubKey;
        private System.Windows.Forms.Button btnSealSenderPubKeyShow;
        private System.Windows.Forms.TextBox tbSealSenderPrivKey;
        private System.Windows.Forms.Button btnSealOpenIt;
        private System.Windows.Forms.TextBox tbSealSignature;
        private System.Windows.Forms.Button btnSealDoIt;
        private System.Windows.Forms.TextBox tbSealEnvelope;
        private System.Windows.Forms.Button btnSealSignatureSave;
        private System.Windows.Forms.Button btnSealOutFileSave;
        private System.Windows.Forms.Button btnSealInFile;
        private System.Windows.Forms.Button btnSealReceiverPrivKey;
        private System.Windows.Forms.Button btnSealEnvelope;
        private System.Windows.Forms.Button btnSealSenderPubKey;
        private System.Windows.Forms.Button btnSealSenderPrivKey;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.TabPage tabSHA2Manual;
        private System.Windows.Forms.RichTextBox rtbSHA2Manual;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnSHA2ManualOutFileShow;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnSHA2ManualInFileShow;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tbSHA2ManualInFile;
        private System.Windows.Forms.Button btnSHA2ManualDoIt;
        private System.Windows.Forms.TextBox tbSHA2ManualOutFile;
        private System.Windows.Forms.Button btnSHA2ManualOutFileSave;
        private System.Windows.Forms.Button btnSHA2ManualInFile;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.CheckBox chbSignatureSHA2;
        private System.Windows.Forms.CheckBox chbOpenGenerated;
        private System.Windows.Forms.Label lblStatus;
    }
}

