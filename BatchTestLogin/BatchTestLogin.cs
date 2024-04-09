using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Linq;
using DAL;
using LSExtensionWindowLib;
using LSSERVICEPROVIDERLib;
using MSXML;
using One1.Controls;
using Telerik.WinControls.UI;
using Common;
using XmlService;

namespace BatchTestLogin
{

    [ComVisible(true)]
    [ProgId("BatchTestLogin.BatchTestLogin")]
    public partial class BatchTestLogin : UserControl, IExtensionWindow
    {
        #region Ctor
        public BatchTestLogin()
        {
            InitializeComponent();
            this.BackColor = Color.FromName("Control");

        }
        #endregion


        #region private members


        private IExtensionWindowSite2 _ntlsSite;
        private INautilusDBConnection _ntlsCon;
        private IDataLayer _dal;
        private bool _allowDummyStock;
        private int numOfBatches;
        private bool _isDummyStock;
        private NautilusServiceProvider sp;

        #endregion


        #region Implementation of IExtensionWindow

        public bool CloseQuery()
        {
            if (lsvBatches.Items.Count > 0)
            {
                DialogResult dr = MessageBox.Show("?" + "אצוות לא הוזנו למערכת. האם לצאת בכל זאת",
                                                  "הזנת אצווה", MessageBoxButtons.YesNo);
                return dr == DialogResult.Yes;                
            }
            return true;
        }

        public void Internationalise() { }

        public void SetSite(object site)
        {
            _ntlsSite = (IExtensionWindowSite2)site;
            _ntlsSite.SetWindowInternalName("BatchTestLogin");
            _ntlsSite.SetWindowRegistryName("BatchTestLogin");
            _ntlsSite.SetWindowTitle("הזנת אצווה");
        }

        public void PreDisplay()
        {
            Utils.CreateConstring(_ntlsCon);
            _dal = new DataLayer();
            Init(_dal);
        }

        public WindowButtonsType GetButtons()
        {
            return LSExtensionWindowLib.WindowButtonsType.windowButtonsNone;
        }

        public bool SaveData()
        {
            return false;
        }

        public void SetServiceProvider(object serviceProvider)
        {            
            sp = serviceProvider as NautilusServiceProvider;
            _ntlsCon = Utils.GetNtlsCon(sp);
        }

        public void SetParameters(string parameters)
        {
            _allowDummyStock = parameters.Split('=')[1]=="true";
        }

        public void Setup()
        {

        }

        public WindowRefreshType DataChange()
        {
            return LSExtensionWindowLib.WindowRefreshType.windowRefreshNone;
        }

        public WindowRefreshType ViewRefresh()
        {
            return LSExtensionWindowLib.WindowRefreshType.windowRefreshNone;
        }

        public void refresh() { }

        public void SaveSettings(int hKey) { }

        public void RestoreSettings(int hKey) { }


        #endregion


        public void Init(IDataLayer dal)
        {
            _dal = dal;
            _dal.Connect();
        }


        private void BatchTestLogin_Resize(object sender, EventArgs e)
        {
            lblHeader.Location = new Point(Width / 2 - lblHeader.Width / 2, lblHeader.Location.Y);
            radGroupBox1.Location = new Point(Width / 2 - radGroupBox1.Width / 2, radGroupBox1.Location.Y);
        }


        private void txtBatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;

                    bool proceedToExpiration = false;
                    bool registerForLogin = false;
                    //                    string stockAliquotName;
                    string batchName = "";
                    string batchDescription = "";
                    string batchComment = "";

                    Aliquot batchAliquot = _dal.GetAliquotByNameToLower(txtBatch.Text.Trim());

                    if (batchAliquot == null)
                    {
                        // not an aliquot
                        if (_allowDummyStock)
                        {
                            batchName = txtBatch.Text.Trim();
                            batchDescription = "";
                            batchComment = "אצווה שאינה קיימת במערכת.";
                            registerForLogin = true;
                            _isDummyStock= true;
                            // register the test although it's not a real aliquot.
                        }
                        else
                        {
                            CustomMessageBox.Show("הערך שהוזן אינו תקין. אין אפשרות להזין את האצווה.",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Error);
                        }
                    }
                    else // a real aliquot
                    {                        
                        if (batchAliquot.StockTemplate == null)
                        {
                            // message: error in typed data. cannot register test.
                            CustomMessageBox.Show("הערך שהוזן אינו תקין. אין אפשרות להזין את האצווה.",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Error);
                        }
                        else // a real stock aliquot
                        {
                            batchDescription = batchAliquot.StockTemplate.Name;
                            switch (batchAliquot.Condition)
                            {
                                case "K":
                                    proceedToExpiration = true;
                                    break;
                                case "P":
                                    DialogResult dr = MessageBox.Show("?"+"אצווה בהסגר. האם להמשיך בכל זאת",
                                                                      "הזנת אצווה", MessageBoxButtons.YesNo);
                                    if (dr == DialogResult.Yes)
                                    {
                                        proceedToExpiration = true;
                                        batchComment = ".אצווה בהסגר";
                                    }
                                    break;
                                default:
                                    CustomMessageBox.Show("אצווה אינה בשימוש.",
                                                          MessageBoxButtons.OK,
                                                          MessageBoxIcon.Error);
                                    
                                    break;
                            }
                            if (proceedToExpiration)
                            {
                                DateTime expiresOn = batchAliquot.ExpiresOn.GetValueOrDefault();
                                if (expiresOn == null || DateTime.Compare(expiresOn, DateTime.Now) >= 0)
                                {
                                    // האצווה בתוקף
                                    registerForLogin = true;
                                    batchName = batchAliquot.Name;
                                }
                                else
                                {
                                    DialogResult dr = MessageBox.Show("?"+"אצווה אינה בתוקף. האם להמשיך בכל זאת",
                                                                      "הזנת אצווה", MessageBoxButtons.YesNo);
                                    if (dr == DialogResult.Yes)
                                    {
                                        registerForLogin = true;
                                        batchName = batchAliquot.Name;
                                        batchComment += " אצווה אינה בתוקף";
                                        batchComment += ".";
                                    }
                                }
                            }
                        }
                    }
                    if (registerForLogin)
                    {
                        //                        lsvBatches.Items.Add(new string[]{ batchName, batchDescription, batchComment});

                        ListViewDataItem item = new ListViewDataItem(batchName,
                                                                     new[] {batchName, batchDescription, batchComment});
                        item.TextAlignment = ContentAlignment.MiddleLeft;                        
                        item.Tag = _isDummyStock ? "DUMMY" : "";
                        item.Image = imageList1.Images[0];
                        lsvBatches.Items.Add(item);
                        lblNumOfBatches.Text =  (++numOfBatches).ToString();                       
                    }

                    Cursor = Cursors.Default;
                    txtBatch.Text = "";
                    _isDummyStock = false;
                    txtBatch.Focus();
                }
                
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    CustomMessageBox.Show(ex.Message + Environment.NewLine + ex.Data, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private bool Login(string stockTemplateName, bool isDummyStock)
        {
            LoginXmlHandler loginXmlHandler = new LoginXmlHandler(sp);
            loginXmlHandler.CreateLoginXml("SAMPLE", "רישום אצוות קוסמטיקה");

            if (isDummyStock)
                loginXmlHandler.AddProperties("U_BATCH", stockTemplateName);
            else
                loginXmlHandler.AddProperties("U_BATCH_STOCK_ALIQUOT", stockTemplateName);
                
            return loginXmlHandler.ProcssXml();
        }


        private void BatchTestLogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnLoginBatches_Click(object sender, EventArgs e)
        {
            try
            {
                txtBatch.Enabled = false;
                lsvBatches.Enabled = false;
                btnExit.Enabled = false;
                btnLoginBatches.Enabled = false;

                bool succeed = true;
                var items = lsvBatches.Items;
                foreach (ListViewDataItem item in items)
                {
                    //debug:
                    //MessageBox.Show(item.Value.ToString());
                    bool result = Login(item.Value.ToString(), (string) item.Tag == "DUMMY");
                    if (!result)
                        succeed = false;
                }
                if (!succeed)
                    CustomMessageBox.Show("."+"בעיה בהזנת אצוות", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
            catch(Exception ex)
            {
                CustomMessageBox.Show("."+"בעיה בהזנת אצוות" + "\n" + ex.Data + "\n\n"+ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
            finally
            {
                txtBatch.Enabled = true;
                lsvBatches.Enabled = true;
                btnExit.Enabled = true;
                btnLoginBatches.Enabled = true;
                lsvBatches.Items.Clear();
                numOfBatches = 0;
                lblNumOfBatches.Text = "";
                txtBatch.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _ntlsSite.CloseWindow();
        }

    
        

        private void lsvBatches_ItemRemoved(object sender, ListViewItemEventArgs e)
        {
            lblNumOfBatches.Text = (--numOfBatches).ToString();
        }


        public void SetAllowDummyStock(bool allow)
        {
            _allowDummyStock = allow;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtBatch.Focus();
            timer1.Stop();
        }

        private void txtBatch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

