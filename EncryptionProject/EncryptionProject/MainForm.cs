using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EncryptionProject
{
    public partial class MainForm : Form
    {
        private static string TESTNAME = "plaintext";

        CryptoAES cryptoAES;
        CryptoRSA cryptoRSA;
        CryptoSHA2 cryptoSHA2;
        CryptoSHA2Manual cryptoSHA2Manual;
        CryptoEnvelope cryptoEnvelope;
        CryptoSignature cryptoSignature;

        private OpenFileDialog ofd;
        private SaveFileDialog sfd;

        public MainForm()
        {
            InitializeComponent();
        }

        #region MAIN FORM LOAD
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeGenericButtons();
            InitializeTextBoxes();

            ofd = new OpenFileDialog();
            sfd = new SaveFileDialog();
            cryptoAES = new CryptoAES();
            cryptoRSA = new CryptoRSA();
            cryptoSHA2 = new CryptoSHA2();
            cryptoSHA2Manual = new CryptoSHA2Manual();
            cryptoEnvelope = new CryptoEnvelope(cryptoAES, cryptoRSA);
            cryptoSignature = new CryptoSignature(cryptoSHA2, cryptoRSA);

            cbAESKeySize.SelectedIndex
                = cbSHA2Size.SelectedIndex 
                = 0;
            cbRSAKeySize.SelectedIndex = 2;

            ofd.Filter = sfd.Filter =
                    "txt files (*.txt)|*.txt|" +
                    "pdf files (*.pdf)|*.pdf|" +
                    "All files (*.*)|*.*";
        }
        #endregion

        #region COMMON STATUS MESSAGES
        private static string OUT_FILE_SUCC_C = "Datoteka je uspješno kriptirana";
        private static string OUT_FILE_SUCC_D = "Datoteka je uspješno dekriptirana";
        private static string SWAP = "Putanje ulazne i izlazne datoteke su zamijenjene";
        private static string HASH_FILE_SUCC = "Sažetak je uspješno napravljen";
        private static string SIGN_FILE_SUCC = "Potpis je uspješno napravljen";
        private static string ENV_FILE_SUCC = "Omotnica je uspješno napravljena";
        private static string ENV_FILE_SUCC_OPEN = "Omotnica je uspješno otvorena";
        private static string SEAL_FILE_SUCC = "Pečat je uspješno napravljen";
        private static string SEAL_FILE_SUCC_OPEN = "Pečat je uspješno otvoren";
        #endregion

        #region GENERIC BUTTONS (OPEN/SAVE/SHOW)
        private void SetFileName(TextBox tb)
        {
            if (tb == null) return;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tb.Text = ofd.FileName;
            }
        }

        private void SetSaveFileName(TextBox tb)
        {
            if (tb == null) return;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                tb.Text = sfd.FileName;
            }
        }

        private void OpenFile(TextBox tb)
        {
            if (tb == null) return;
            try
            {
                System.Diagnostics.Process.Start(tb.Text);
            }
            catch (Exception)
            {
                ShowFileNotFound(tb);
            }
        }

        private void InitializeGenericButtons()
        {
            foreach (TabPage tabPage in this.pnlTabs.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control.Name.StartsWith("btn"))
                    {
                        ((Button)control).Click += GenericButtonClick;
                    }
                }
            }
        }

        private void SwapTexts(TextBox tbx1, TextBox tbx2)
        {
            string temp = tbx1.Text;
            tbx1.Text = tbx2.Text;
            tbx2.Text = temp;
            lblStatus.Text = SWAP;
        }

        private TextBox FindTextBox(string tbName)
        {
            return this.Controls.Find(tbName, true).FirstOrDefault() as TextBox;
        }

        void GenericButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string name = button.Name;
            if (name.EndsWith("Show"))
            {
                OpenFile(FindTextBox("tb" + name.Substring(3, name.Length - 7)));
            }
            else if (name.EndsWith("Save"))
            {
                SetSaveFileName(FindTextBox("tb" + name.Substring(3, name.Length - 7)));
            }
            else
            {
                SetFileName(FindTextBox("tb" + name.Substring(3, name.Length - 3)));
            }
        }
        #endregion

        #region TEXTBOX INITIALIZATION (DEFAULT PATHS)
        private void btnDefault_Click(object sender, EventArgs e)
        {
            InitializeTextBoxes();
        }

        private string[] SplitCamelCase(string str)
        {
            string strRegex = @"(?<=[a-z])([A-Z])|(?<=[A-Z])([A-Z][a-z])";
            Regex myRegex = new Regex(strRegex, RegexOptions.None);
            string strTargetString = @str;
            string strReplace = @" $1$2";

            return myRegex.Replace(strTargetString, strReplace).Split(' ');
        }

        private void tbxDoubleClicked(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            tbx.SelectionStart = tbx.Text.Length;
            tbx.ScrollToCaret();
        }

        private void InitializeTextBoxes()
        {
            foreach (TabPage tabPage in this.pnlTabs.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control.Name.StartsWith("tb"))
                    {
                        string path = "";
                        TextBox tbx = (TextBox)control;
                        tbx.BackColorChanged += new EventHandler(tbxBackColorChanged);
                        tbx.MouseDoubleClick += new MouseEventHandler(tbxDoubleClicked);
                        string name = tbx.Name.Substring(2);
                        if (name.Contains("InFile")) path = @"Files\" + TESTNAME + ".txt";
                        else if (name.Contains("OutFile"))
                        {
                            string part = SplitCamelCase(name)[0];
                            if (part.Contains("Out")) part = part.Replace("Out", "");
                            path = @"Files\" + TESTNAME + "_" + part.ToLower() + "_out.txt";
                        }
                        else if (name.Contains("PubKey")) path = @"Files\rsa_pub_key.txt";
                        else if (name.Contains("PrivKey")) path = @"Files\rsa_priv_key.txt";
                        else if (name.Contains("Key")) path = @"Files\aes_key.txt";

                        else continue;
                        tbx.Text = Path.GetFullPath(path);
                    }
                }
            }
            tbEnvelope.Text = Path.GetFullPath(@"Files\" + TESTNAME + "_envelope.txt");
            tbSignature.Text = Path.GetFullPath(@"Files\" + TESTNAME + "_signature.txt");
            tbSealEnvelope.Text = Path.GetFullPath(@"Files\" + TESTNAME + "_seal_envelope.txt");
            tbSealSignature.Text = Path.GetFullPath(@"Files\" + TESTNAME + "_seal_signature.txt");

            tbSealReceiverPubKey.Text = Path.GetFullPath(@"Files\rsa_pub_key2.txt");
            tbSealReceiverPrivKey.Text = Path.GetFullPath(@"Files\rsa_priv_key2.txt");
        }
        #endregion

        #region SHOW MESSAGE METHODS
        private void ShowErrorMessage(string text)
        {
            MessageBox.Show(text,
                    "Dogodila se pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowSuccessMessage(string text)
        {
            MessageBox.Show(text,
                    "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region FILE PATH VALIDATION
        private void ShowFileNotFound(TextBox textBox)
        {
            ShowErrorMessage(string.Format("Datoteka s putanjom '{0}' nije pronađena!", textBox.Text));
            textBox.BackColor = Color.Yellow;
        }

        private void ShowFilePathNotValid(TextBox textBox)
        {
            ShowErrorMessage(string.Format("Putanja datoteke '{0}' nije ispravna!", textBox.Text));
            textBox.BackColor = Color.Yellow;
        }

        private bool CheckFilesExistence(TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (!File.Exists(textBox.Text))
                {
                    ShowFileNotFound(textBox);
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region AES NONGENERIC BUTTONS

        private void btnAESSwapInOut_Click(object sender, EventArgs e)
        {
            SwapTexts(tbAESInFile, tbAESOutFile);
        }

        private void btnAESKeyGen_Click(object sender, EventArgs e)
        {
            int keySize = int.Parse(cbAESKeySize.Text.Split(' ')[0]);
            cryptoAES.CurrentKeySize = keySize;
            try
            {
                cryptoAES.GenerateKeyFile(tbAESKey.Text);
                lblStatus.Text = "Simetričan ključ je uspješno generiran";
                if (chbOpenGenerated.Checked) btnAESKeyShow.PerformClick();
            }
            catch (Exception)
            {
                ShowFilePathNotValid(tbAESKey);
            }
        }

        private void btnAESDoIt_Click(object sender, EventArgs e)
        {
            if (CheckFilesExistence(new TextBox[] { tbAESKey, tbAESInFile })) return;
            try
            {
                cryptoAES.ParseKeyFile(tbAESKey.Text);
                cryptoAES.GenerateOutFile(rbAESEncrypt.Checked, tbAESInFile.Text, tbAESOutFile.Text);
                if (rbAESEncrypt.Checked) lblStatus.Text = OUT_FILE_SUCC_C;
                else lblStatus.Text = OUT_FILE_SUCC_D;
                if (chbOpenGenerated.Checked) btnAESOutFileShow.PerformClick();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }
        #endregion

        #region RSA NONGENERIC BUTTONS
        private void btnRSADoIt_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbRSAEncrypt.Checked)
                {
                    if (CheckFilesExistence(new TextBox[] { tbRSAPubKey, tbRSAInFile })) return;
                    cryptoRSA.ParsePubKeyFile(tbRSAPubKey.Text);
                }
                else
                {
                    if (CheckFilesExistence(new TextBox[] { tbRSAPrivKey, tbRSAInFile })) return;
                    cryptoRSA.ParsePubKeyFile(tbRSAPubKey.Text);
                    cryptoRSA.ParsePrivKeyFile(tbRSAPrivKey.Text);
                }

                cryptoRSA.GenerateOutFile(rbRSAEncrypt.Checked, tbRSAInFile.Text, tbRSAOutFile.Text);

                if (rbRSAEncrypt.Checked) lblStatus.Text = OUT_FILE_SUCC_C;
                else lblStatus.Text = OUT_FILE_SUCC_D;
                if (chbOpenGenerated.Checked) btnRSAOutFileShow.PerformClick();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void btnRSAKeyGen_Click(object sender, EventArgs e)
        {
            try
            {
                int keySize = int.Parse(cbRSAKeySize.Text.Split(' ')[0]);
                cryptoRSA.GenerateKeyFiles(keySize, tbRSAPubKey.Text, tbRSAPrivKey.Text);
                lblStatus.Text = "Ključevi su uspješno generirani";
                if (chbOpenGenerated.Checked)
                {
                    btnRSAPubKeyShow.PerformClick();
                    btnRSAPrivKeyShow.PerformClick();
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void btnRSASwapInOut_Click(object sender, EventArgs e)
        {
            SwapTexts(tbRSAInFile, tbRSAOutFile);
        }
        #endregion

        #region SHA2 NONGENERIC BUTTONS
        private void btnSHA2DoIt_Click(object sender, EventArgs e)
        {
            cryptoSHA2.SetHashSize(int.Parse(cbSHA2Size.Text.Split(' ')[0]));
            try
            {
                cryptoSHA2.GenerateOutFile(true, tbSHA2InFile.Text, tbSHA2OutFile.Text);
                rtbSHA2.Text = cryptoSHA2.GetDataString();
                lblStatus.Text = HASH_FILE_SUCC;
            }
            catch (Exception)
            {
                ShowFilePathNotValid(tbSHA2InFile);
            }
        }
        #endregion

        #region SHA2 MANUAL NONGENERIC BUTTONS
        private void btnSHA2ManualDoIt_Click(object sender, EventArgs e)
        {
            try
            {
                cryptoSHA2Manual.GenerateOutFile(true, tbSHA2ManualInFile.Text, tbSHA2ManualOutFile.Text);
                rtbSHA2Manual.Text = cryptoSHA2Manual.GetDataString();
                lblStatus.Text = HASH_FILE_SUCC;
            }
            catch (Exception)
            {
                ShowFilePathNotValid(tbSHA2InFile);
            }
        }
        #endregion

        #region ENVELOPE NONGENERIC BUTTONS
        private void btnEnvelopeDoIt_Click(object sender, EventArgs e)
        {
            if (CheckFilesExistence(new TextBox[] { tbEnvelopePubKey, tbEnvelopeInFile })) return;
            try
            {
                cryptoRSA.ParsePubKeyFile(tbEnvelopePubKey.Text);
                cryptoEnvelope.GenerateOutFile(true, tbEnvelopeInFile.Text, tbEnvelope.Text);
                if (chbOpenGenerated.Checked) btnEnvelopeShow.PerformClick();
                lblStatus.Text = ENV_FILE_SUCC;
            }
            catch (ArgumentException)
            {
                ShowFilePathNotValid(tbEnvelope);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void btnEnvelopeShowIt_Click(object sender, EventArgs e)
        {
            if (CheckFilesExistence(new TextBox[] { tbEnvelopePrivKey })) return;
            try
            {
                cryptoRSA.ParsePubKeyFile(tbEnvelopePubKey.Text);
                cryptoRSA.ParsePrivKeyFile(tbEnvelopePrivKey.Text);
                cryptoEnvelope.GenerateOutFile(false, tbEnvelope.Text, tbEnvelopeOutFile.Text);
                btnEnvelopeOutFileShow.PerformClick();
                lblStatus.Text = ENV_FILE_SUCC_OPEN;
            }
            catch (ArgumentException)
            {
                ShowFilePathNotValid(tbEnvelopeOutFile);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }
        #endregion

        #region SIGNATURE NONGENERIC BUTTONS
        private void btnSignatureDoIt_Click(object sender, EventArgs e)
        {
            if (CheckFilesExistence(new TextBox[2] { tbSignaturePrivKey, tbSignatureInFile })) return;
            try
            {
                cryptoRSA.ParsePubKeyFile(tbSignaturePubKey.Text);
                cryptoRSA.ParsePrivKeyFile(tbSignaturePrivKey.Text);
                cryptoSHA2.SetHashSize(256);
                cryptoSignature.GenerateOutFile(true, tbSignatureInFile.Text, tbSignature.Text);
                if (chbOpenGenerated.Checked) btnSignatureShow.PerformClick();
                lblStatus.Text = SIGN_FILE_SUCC;
            }
            catch (ArgumentException)
            {
                ShowFilePathNotValid(tbEnvelopeOutFile);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void btnSignatureCheckIt_Click(object sender, EventArgs e)
        {
            if (CheckFilesExistence(new TextBox[1] { tbSignaturePubKey })) return;
            try
            {
                cryptoRSA.ParsePubKeyFile(tbSignaturePubKey.Text);
                bool correctSignature = false;
                if (chbSignatureSHA2.Checked)
                {
                    cryptoSHA2Manual.SetHashSize(256);
                    correctSignature = cryptoSignature.CheckSignature(tbSignatureInFile.Text,
                    tbSignature.Text, cryptoSHA2Manual);
                }
                else
                {
                    cryptoSHA2.SetHashSize(256);
                    correctSignature = cryptoSignature.CheckSignature(tbSignatureInFile.Text,
                    tbSignature.Text, cryptoSHA2);
                }

                if (correctSignature) ShowSuccessMessage("Potpis je ispravan!");
                else ShowErrorMessage("Potpis je neispravan!");
            }
            catch (ArgumentException)
            {
                ShowFilePathNotValid(tbEnvelopeOutFile);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }
        #endregion

        #region SEAL NONGENERIC BUTTONS
        private void btnSealDoIt_Click(object sender, EventArgs e)
        {
            if (CheckFilesExistence(new TextBox[] { tbSealReceiverPubKey, tbSealInFile })) return;
            try
            {
                cryptoRSA.ParsePubKeyFile(tbSealReceiverPubKey.Text);
                cryptoEnvelope.GenerateOutFile(true, tbSealInFile.Text, tbSealEnvelope.Text);

                if (CheckFilesExistence(new TextBox[] { tbSealSenderPrivKey, tbSealEnvelope })) return;
                cryptoRSA.ParsePrivKeyFile(tbSealSenderPrivKey.Text);

                cryptoSignature.GenerateOutFile(true, tbSealEnvelope.Text, tbSealSignature.Text);
                if (chbOpenGenerated.Checked) btnSealEnvelopeShow.PerformClick();
                lblStatus.Text = SEAL_FILE_SUCC;

            }
            catch (ArgumentException)
            {
                ShowFilePathNotValid(tbSealSignature);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void btnSealOpenIt_Click(object sender, EventArgs e)
        {
            if (CheckFilesExistence(new TextBox[] { tbSealSenderPubKey, tbSealReceiverPrivKey })) return;
            try
            {
                cryptoRSA.ParsePubKeyFile(tbSealSenderPubKey.Text);
                if (cryptoSignature.CheckSignature(tbSealEnvelope.Text, tbSealSignature.Text, cryptoSHA2))
                {
                    cryptoRSA.ParsePrivKeyFile(tbSealReceiverPrivKey.Text);
                    cryptoEnvelope.GenerateOutFile(false, tbSealEnvelope.Text, tbSealOutFile.Text);
                    btnSealOutFileShow.PerformClick();
                    lblStatus.Text = SEAL_FILE_SUCC_OPEN;
                }
                else
                {
                    MessageBox.Show("Potpis nije valjan!");
                }
            }
            catch (ArgumentException)
            {
                ShowFilePathNotValid(tbSealOutFile);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }
        #endregion

        #region DELAYED CHANGE METHODS
        private void tbxBackColorChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            var t = new Timer();
            t.Interval = 2000;
            t.Tick += (s, ev) =>
            {
                tbx.BackColor = Color.White;
                t.Stop();
            };
            t.Start();
        }

        private void lblStatusTextChanged(object sender, EventArgs e)
        {
            var t = new Timer();
            t.Interval = 3000;
            t.Tick += (s, ev) =>
            {
                lblStatus.Text = "";
                t.Stop();
            };
            t.Start();
        }
        #endregion
    }
}
