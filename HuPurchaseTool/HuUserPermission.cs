using HuEncryptString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuPurchaseTool
{
    static class GlobalVariable
    {
        public const string HU_USER_ULTIMATE = "nguyen_hung";
        public const string HU_PASS_ULTIMATE = "nguyenhung2804";
        public const string HU_USER_FILE = "HuFile.txt";
        public const string HU_ENCRYPT_PASS = "thienlanh89";
    }

    class HuUserPermission
    {
        public HuUserPermission(string userName, string userPassword, string userPermission = "Normal User")
        {
            name = userName;
            password = userPassword;
            permission = userPermission;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string permission;
        public string Permission
        {
            get { return permission; }
            set { permission = value; }
        }
    }

    class HUUserManagement {
        public Dictionary<string, HuUserPermission> listUsers = new Dictionary<string, HuUserPermission> { };

        HUUserManagement() {
            listUsers.Add(GlobalVariable.HU_USER_ULTIMATE, new HuUserPermission(GlobalVariable.HU_USER_ULTIMATE, GlobalVariable.HU_PASS_ULTIMATE, "ultimate") );
            read();
        }

        public string getPermission(string userName) {
            if (listUsers.ContainsKey(userName)) {
                return listUsers[userName].Permission;
            }
            return "";
        }

        public bool checkUserPassword(string userName, string password) {
            return listUsers.ContainsKey(userName) && listUsers[userName].Password == password;
        }

        public bool checkUserPermission(string userName, string permission)
        {
            return listUsers.ContainsKey(userName) && listUsers[userName].Permission == permission;
        }

        public void clear() {
            listUsers.Clear();
            listUsers.Add(GlobalVariable.HU_USER_ULTIMATE, new HuUserPermission(GlobalVariable.HU_USER_ULTIMATE, GlobalVariable.HU_PASS_ULTIMATE, "ultimate"));
        }

        public void save(DataGridView dataView) {
            string message = "Successful to save file ";
            string title = "Save File";
            try
            {
                var text = "";
                foreach (DataGridViewRow val in dataView.Rows)
                {
                    if (val.Cells[0].FormattedValue.ToString().Length > 2) {
                        text += val.Cells[0].FormattedValue + "\n";
                        text += val.Cells[1].FormattedValue + "\n";
                        text += val.Cells[2].FormattedValue + "\n";
                    }
                }
                var encryptedstring = StringCipher.Encrypt(text, GlobalVariable.HU_ENCRYPT_PASS);
                System.IO.File.WriteAllText(GlobalVariable.HU_USER_FILE, encryptedstring);
                clear();
                read();
            }
            catch (Exception ex)
            {
                message = ex.Message;
                title = "Error to Save File";
            }

            MessageBox.Show(message, title);
        }

        public void bindListUser(DataGridView dataView) {
            dataView.Rows.Clear();
            foreach (var pair in listUsers)
            {
                if (pair.Key != GlobalVariable.HU_USER_ULTIMATE)
                {
                    dataView.Rows.Add(new string[] { pair.Value.Name, pair.Value.Password, pair.Value.Permission });
                }
            }
        }

        public void read() {
            if (!System.IO.File.Exists(GlobalVariable.HU_USER_FILE)) {
                return;
            }
            string message = "Successful to save file ";
            string title = "Save File";
            try
            {
                var text = StringCipher.Decrypt(System.IO.File.ReadAllText(GlobalVariable.HU_USER_FILE), GlobalVariable.HU_ENCRYPT_PASS);
                var textLines = text.Split('\n');
                var nbUser = (int) textLines.Length / 3;
                for (var i = 0; i < nbUser; i++) {
                    if (textLines[i * 3].Length > 2) 
                    listUsers.Add(textLines[i * 3], new HuUserPermission(textLines[i*3], textLines[i * 3 + 1], textLines[i * 3 + 2]));
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                title = "Error to Read File";
                MessageBox.Show(message, title);
            }
        }

        private static HUUserManagement instance = null;
        private static readonly object padlock = new object();
        public static HUUserManagement GetInstance() {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new HUUserManagement();
                    }
                }
            }
            return instance;
        }
    
    }
}
