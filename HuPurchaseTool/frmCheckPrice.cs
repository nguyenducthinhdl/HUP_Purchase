using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HuPurchaseTool
{
    public partial class frmCheckPrice : Form
    {
        const string IN_STOCK = "IN_STOCK";
        public frmCheckPrice()
        {
            InitializeComponent();
        }

        private string makeCheckPriceURL(string code, out string error) {
            error = "";
            string ret = "";
            string uk_begin = "https://www.adidas.co.uk/api/products/";
            var url = (rdbOptionUK.Checked ? uk_begin : "https://www.adidas.com/api/products/") + code + "?sitePath=" + (rdbOptionUK.Checked ? "uk" : "us");
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = true;
                request.Accept = "application/json, text/javascript, */*; q=0.01";
                request.Headers.Add("Origin", @"https://tr42.klanlar.org");
                request.Headers.Add("X-Requested-With", @"XMLHttpRequest");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36";
                request.Headers.Add("TribalWars-Ajax", @"1");

                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    var jsonText = reader.ReadToEnd();
                    var jsonValue = JObject.Parse(jsonText);
                    if (jsonValue.ContainsKey("id") && jsonValue["id"].ToString() == code)
                    {
                        ret = jsonValue["pricing_information"]["currentPrice"].ToString();
                    }
                    else {
                        error = "Code Not avaiable";
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return ret;
        }

        private List<string> makeCheckSizeURL(string code, out string error)
        {
            var ret = new List<string> { };
            error = "";
            string uk_begin = "https://www.adidas.co.uk/api/products/";
            var url = (rdbOptionUK.Checked ? uk_begin : "https://www.adidas.com/api/products/") + code +  "/availability?sitePath=" + (rdbOptionUK.Checked?"uk":"us");
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = true;
                request.Accept = "application/json, text/javascript, */*; q=0.01";
                request.Headers.Add("Origin", @"https://tr42.klanlar.org");
                request.Headers.Add("X-Requested-With", @"XMLHttpRequest");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36";
                request.Headers.Add("TribalWars-Ajax", @"1");

                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    var jsonText = reader.ReadToEnd();
                    var jsonValue = JObject.Parse(jsonText);
                    if (jsonValue.ContainsKey("id") && jsonValue["id"].ToString() == code)
                    {
                        if (jsonValue["availability_status"].ToString() != IN_STOCK)
                        {
                            error = "NOT IN STOCK";
                        }
                        else
                        {
                            foreach (var itemSize in jsonValue["variation_list"].ToList())
                            {
                                if (itemSize["availability_status"].ToString() == IN_STOCK)
                                {
                                    ret.Add(itemSize["size"].ToString());
                                }
                            }
                        }
                    }
                    else {
                        error = "Code Not avaiable";
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            
            return ret;
        }

        private void btnCheckPrice_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                if (dgvr.Cells[0].FormattedValue.ToString().Length > 2)
                {
                    string code = dgvr.Cells[0].FormattedValue.ToString();
                    var error = "";
                    var price = makeCheckPriceURL(code, out error);
                    dgvr.Cells[3].Value = "";
                    dgvr.Cells[3].Style.BackColor = Color.White;
                    if (error.Length > 0)
                    {
                        dgvr.Cells[3].Value = error;
                        dgvr.Cells[3].Style.BackColor = Color.Red;
                    }
                    else {
                        dgvr.Cells[2].Value = price;
                        double filePrice = 0.0; 
                        if (Double.TryParse(dgvr.Cells[1].FormattedValue.ToString(), out filePrice)) {
                            if (filePrice <= Double.Parse(price))
                            {
                                dgvr.Cells[3].Value = "PRICE OK";
                                dgvr.Cells[3].Style.BackColor = Color.LightGreen;
                            }
                            else {
                                dgvr.Cells[3].Value = "FILE PRICE TOO BIG";
                                dgvr.Cells[3].Style.BackColor = Color.Red;
                            }
                        }
                    }

                }
            }
        }

        private void btnCheckSize_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                if (dgvr.Cells[0].FormattedValue.ToString().Length > 2)
                {
                    string code = dgvr.Cells[0].FormattedValue.ToString();
                    var error = "";
                    var listSize = makeCheckSizeURL(code, out error);
                    var strListSize = string.Join(", \n", listSize);
                    dgvr.Cells[3].Value = "";
                    dgvr.Cells[3].Style.BackColor = Color.White;
                    if (error.Length > 0)
                    {
                        dgvr.Cells[3].Value = error;
                        dgvr.Cells[3].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        dgvr.Cells[2].Value = strListSize;
                        var fileSize = dgvr.Cells[1].FormattedValue.ToString();
                        if (fileSize.Length > 0) {
                            var find = false;
                            foreach (var size in listSize) {
                                if (size == fileSize) {
                                    find = true;
                                    break;
                                }
                            }
                            if (find)
                            {
                                dgvr.Cells[3].Value = "Size is OK";
                                dgvr.Cells[3].Style.BackColor = Color.LightGreen;
                            }
                            else {
                                dgvr.Cells[3].Value = "Size is BAD";
                                dgvr.Cells[3].Style.BackColor = Color.Red;
                            }
                        }
                    }

                }
            }
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            //if user clicked Shift+Ins or Ctrl+V (paste from clipboard)
            if ((e.Shift && e.KeyCode == Keys.Insert) || (e.Control && e.KeyCode == Keys.V))
            {
                char[] rowSplitter = { '\r', '\n' };
                char[] columnSplitter = { '\t' };
                //get the text from clipboard
                IDataObject dataInClipboard = Clipboard.GetDataObject();
                string stringInClipboard = (string)dataInClipboard.GetData(DataFormats.Text);
                //split it into lines
                string[] rowsInClipboard = stringInClipboard.Split(rowSplitter, StringSplitOptions.RemoveEmptyEntries);
                //get the row and column of selected cell in grid
                int r = dataGridView1.SelectedCells[0].RowIndex;
                int c = dataGridView1.SelectedCells[0].ColumnIndex;
                //add rows into grid to fit clipboard lines
                if (dataGridView1.Rows.Count < (r + rowsInClipboard.Length))
                {
                    dataGridView1.Rows.Add(r + rowsInClipboard.Length - dataGridView1.Rows.Count);
                }

                // loop through the lines, split them into cells and place the values in the corresponding cell.
                for (int iRow = 0; iRow < rowsInClipboard.Length; iRow++)
                {
                    //split row into cell values
                    string[] valuesInRow = rowsInClipboard[iRow].Split(columnSplitter);
                    //cycle through cell values
                    for (int iCol = 0; iCol < valuesInRow.Length; iCol++)
                    {
                        //assign cell value, only if it within columns of the grid
                        if (dataGridView1.ColumnCount - 1 >= c + iCol)
                        {
                            dataGridView1.Rows[r + iRow].Cells[c + iCol].Value = valuesInRow[iCol];
                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
  
}
