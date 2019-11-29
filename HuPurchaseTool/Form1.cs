using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HuEncryptString;
using System.Threading;

namespace HuPurchaseTool
{
    public partial class frmPurchase : Form
    {
        Dictionary<string, string> ADIDAS_URL = new Dictionary<string, string>{
            { "UK", "https://www.adidas.co.uk/" },
            { "US", "https://www.adidas.com/us/" }
        };
        const string URL_TAIL = ".html?forceSelSize=";
        string SAVE_FILE_URL = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\HuFile.txt");
        const string ENCRYPT_PASS = "TOXIC";
        bool processing = false;

        public frmPurchase(string user)
        {
            InitializeComponent();
            if (HUUserManagement.GetInstance().checkUserPermission(user, "ultimate"))
            {
                btnUserSetting.Visible = true;
            }
        }

        private string makeURL(string code, string size, bool incognito = true)
        {
            string location = rdbOptionUK.Checked ? "UK" : "US";
            return ADIDAS_URL[location] + code + URL_TAIL + Uri.EscapeUriString(size) + (incognito?" --incognito":"");
        }

        private List<String> splitCondition(List<String> listStr, String delimiters, int minLen = 1) {
            foreach (var delimiter in delimiters) {
                List<String> listRet = new List<string> { };
                foreach (var str in listStr)
                {
                    foreach (var strSplit in str.Split(delimiter))
                    {
                        if (strSplit.Length >= minLen)
                        {
                            listRet.Add(strSplit);
                        }
                    }
                }
                listStr = listRet;
            }
            return listStr;
        }

        private List<String> validateSize(List<String> sizes) {
            var ret= new List<String>{};
            for (int i = 0; i < sizes.Count; i++) {
                var rawSize = sizes[i].ToUpper();
                var size = "";
                var isMW = false;
                for (var j = 0; j < rawSize.Length; j++) {
                    var c = rawSize[j];
                    if (j == 0 && c == ' ') {
                        continue;
                    }
                    else if (c == ' ' && rawSize[j - 1] == ' ') {
                        continue;
                    }
                    else if (c == '\\')
                    {
                        c = '/';
                    }
                    if (c == '/') {
                        isMW = true;
                    }
                    size += c;
                }

                if (isMW) {
                    var iM = size.IndexOf('M');
                    var iW = size.IndexOf('W');
                    if (iM != -1 && iW != -1) {
                        if (iM + 1 < size.Length && size[iM + 1] != ' ') {
                            size = size.Insert(iM + 1, " ");
                        }
                        iW = size.IndexOf('W');
                        if (iW + 1 < size.Length && size[iW + 1] != ' ')
                        {
                            size = size.Insert(iW + 1, " ");
                        }
                        var iSp = size.IndexOf('/');
                        if (iSp > 0 && size[iSp - 1] != ' ') {
                            size = size.Insert(iSp, " ");
                            iSp = size.IndexOf('/');
                        }
                        if (iSp + 1 < size.Length && size[iSp + 1] != ' ') {
                            size = size.Insert(iSp + 1, " ");
                        }
                    }
                }
                ret.Add(size);
            }
            return ret;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPurChaseCode.Text = "";
            txtSize.Text = "";
        }

        private void btnOpenURL_Click(object sender, EventArgs e)
        {
            if (processing) {
                MessageBox.Show("Please wait to open new items");
                return;
            }
            processing = true;
            var codes = splitCondition(new List<string> { txtPurChaseCode.Text }, "\n\r", 3);
            var sizes = splitCondition(new List<string> { txtSize.Text }, "\n\r", 1);

            if (chkCheckSize.Checked) {
                sizes = validateSize(sizes);
            }

            if (!chkChromeCMD.Checked)
            {
                double delayTab = 1.0;
                try
                {
                    delayTab = Double.Parse(txtDelayTab.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Delay Tab is wrong format", ex.Message);
                }

                for (var i = 0; i < codes.Count(); i++)
                {
                    using (var process = new Process())
                    {
                        var size = (i < sizes.Count()) ? sizes[i] : "";
                        Process.Start("chrome", makeURL(codes[i], size));
                        Thread.Sleep((i == 0) ? 15000 : ((int)delayTab * 1000));
                    }
                }
            }
            else {
                if (codes.Count > 0) {
                    using (var process = new Process())
                    {
                        var size = (0 < sizes.Count()) ? sizes[0] : "";
                        Process.Start("chrome", makeURL(codes[0], size));
                        Thread.Sleep(15000);
                    }
                }
                if (codes.Count > 1)
                {
                    using (var process = new Process())
                    {
                        var cmd = "";
                        for (var i = 1; i < codes.Count; i++)
                        {
                            var size = (i < sizes.Count()) ? sizes[i] : "";
                            cmd += makeURL(codes[i], size, false) + " ";
                        }
                        cmd += " --incognito";
                        Process.Start("chrome", cmd);
                    }
                }
            }
            
            processing = false;
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            string message = "Successful to save file ";
            string title = "Save File";
            try
            {
                var encryptedstring = StringCipher.Encrypt(txtPurChaseCode.Text, ENCRYPT_PASS);
                System.IO.File.WriteAllText(SAVE_FILE_URL, encryptedstring);

            }
            catch (Exception ex) {
                message = ex.Message;
                title = "Error to Save File";
            }

            MessageBox.Show(message, title);
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            string message = "Successful to delete file ";
            string title = "Delete File";
            try
            {
                if (File.Exists(SAVE_FILE_URL))
                {
                    File.Delete(SAVE_FILE_URL);
                }
                else {
                    message = "File does not exists ";
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                title = "Error to delete file";
            }

            MessageBox.Show(message, title);
        }      

        private void frmPurchase_Load(object sender, EventArgs e)
        {

        }

        private void btnValidateSize_Click(object sender, EventArgs e)
        {
            var sizes = splitCondition(new List<string> { txtSize.Text }, "\n\r", 1);
            var validate_sizes = validateSize(sizes);
            txtSize.Clear();
            for (var i = 0; i < validate_sizes.Count; i++)
            {
                if (i > 0) txtSize.AppendText("\r\n");
                txtSize.AppendText(validate_sizes[i]);
            }
            //txtSize.Text = m;
        }

        private void btnUserSetting_Click(object sender, EventArgs e)
        {
            var usermanagerForm = new UserManagement();
            this.Hide();
            usermanagerForm.ShowDialog();
            this.Show();
        }

        private void btnCheckPrice_Click(object sender, EventArgs e)
        {
            var checkPriceForm = new frmCheckPrice();
            this.Hide();
            checkPriceForm.ShowDialog();
            this.Show();
        }
    }
}
