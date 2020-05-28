namespace Open_API_2._0_Sample
{
    partial class Main
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
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.btnAuthorizeApplication = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnGetAccountsList = new System.Windows.Forms.Button();
            this.btnSendMarketOrder = new System.Windows.Forms.Button();
            this.btnSubscribeForSpots = new System.Windows.Forms.Button();
            this.btnUnSubscribeFrorSpots = new System.Windows.Forms.Button();
            this.btnGetDealsList = new System.Windows.Forms.Button();
            this.btnGetOrders = new System.Windows.Forms.Button();
            this.btnGetTransactions = new System.Windows.Forms.Button();
            this.btnGetTrendbars = new System.Windows.Forms.Button();
            this.btnGetTickData = new System.Windows.Forms.Button();
            this.btnGetSymbols = new System.Windows.Forms.Button();
            this.btnSendStopOrder = new System.Windows.Forms.Button();
            this.btnSendLimitOrder = new System.Windows.Forms.Button();
            this.btnSendStopLimitOrder = new System.Windows.Forms.Button();
            this.btnClosePosition = new System.Windows.Forms.Button();
            this.txtPositionID = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAccounts = new System.Windows.Forms.Label();
            this.cbAccounts = new System.Windows.Forms.ComboBox();
            this.lblTakeProfit = new System.Windows.Forms.Label();
            this.txtTakeProfit = new System.Windows.Forms.TextBox();
            this.lblStolLoss = new System.Windows.Forms.Label();
            this.lblID2 = new System.Windows.Forms.Label();
            this.txtStopLoss = new System.Windows.Forms.TextBox();
            this.txtPositionIDTPSL = new System.Windows.Forms.TextBox();
            this.btnAmentSLTP = new System.Windows.Forms.Button();
            this.btnAuthorizeAccount = new System.Windows.Forms.Button();
            this.m_btnMarketRangeOrder = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.m_btnCloseOrder = new System.Windows.Forms.Button();
            this.m_txtOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessages
            // 
            this.txtMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessages.Location = new System.Drawing.Point(0, 0);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessages.Size = new System.Drawing.Size(1186, 207);
            this.txtMessages.TabIndex = 0;
            // 
            // btnAuthorizeApplication
            // 
            this.btnAuthorizeApplication.Location = new System.Drawing.Point(14, 15);
            this.btnAuthorizeApplication.Name = "btnAuthorizeApplication";
            this.btnAuthorizeApplication.Size = new System.Drawing.Size(145, 23);
            this.btnAuthorizeApplication.TabIndex = 1;
            this.btnAuthorizeApplication.Text = "Authorize Application";
            this.btnAuthorizeApplication.UseVisualStyleBackColor = true;
            this.btnAuthorizeApplication.Click += new System.EventHandler(this.btnAuthorizeApplication_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnGetAccountsList
            // 
            this.btnGetAccountsList.Location = new System.Drawing.Point(14, 44);
            this.btnGetAccountsList.Name = "btnGetAccountsList";
            this.btnGetAccountsList.Size = new System.Drawing.Size(145, 23);
            this.btnGetAccountsList.TabIndex = 2;
            this.btnGetAccountsList.Text = "Get Accounts List";
            this.btnGetAccountsList.UseVisualStyleBackColor = true;
            this.btnGetAccountsList.Click += new System.EventHandler(this.btnGetAccountsList_Click);
            // 
            // btnSendMarketOrder
            // 
            this.btnSendMarketOrder.Location = new System.Drawing.Point(165, 73);
            this.btnSendMarketOrder.Name = "btnSendMarketOrder";
            this.btnSendMarketOrder.Size = new System.Drawing.Size(159, 23);
            this.btnSendMarketOrder.TabIndex = 4;
            this.btnSendMarketOrder.Text = "Send Market Order";
            this.btnSendMarketOrder.UseVisualStyleBackColor = true;
            this.btnSendMarketOrder.Click += new System.EventHandler(this.btnSendMarketOrder_Click);
            // 
            // btnSubscribeForSpots
            // 
            this.btnSubscribeForSpots.Location = new System.Drawing.Point(165, 15);
            this.btnSubscribeForSpots.Name = "btnSubscribeForSpots";
            this.btnSubscribeForSpots.Size = new System.Drawing.Size(159, 23);
            this.btnSubscribeForSpots.TabIndex = 5;
            this.btnSubscribeForSpots.Text = "Subscribe For Spots";
            this.btnSubscribeForSpots.UseVisualStyleBackColor = true;
            this.btnSubscribeForSpots.Click += new System.EventHandler(this.btnSubscribeForSpots_Click);
            // 
            // btnUnSubscribeFrorSpots
            // 
            this.btnUnSubscribeFrorSpots.Location = new System.Drawing.Point(164, 44);
            this.btnUnSubscribeFrorSpots.Name = "btnUnSubscribeFrorSpots";
            this.btnUnSubscribeFrorSpots.Size = new System.Drawing.Size(160, 23);
            this.btnUnSubscribeFrorSpots.TabIndex = 6;
            this.btnUnSubscribeFrorSpots.Text = "Unsubscribe From Spots";
            this.btnUnSubscribeFrorSpots.UseVisualStyleBackColor = true;
            this.btnUnSubscribeFrorSpots.Click += new System.EventHandler(this.btnUnSubscribeFrorSpots_Click);
            // 
            // btnGetDealsList
            // 
            this.btnGetDealsList.Location = new System.Drawing.Point(12, 131);
            this.btnGetDealsList.Name = "btnGetDealsList";
            this.btnGetDealsList.Size = new System.Drawing.Size(145, 23);
            this.btnGetDealsList.TabIndex = 7;
            this.btnGetDealsList.Text = "Get Deals";
            this.btnGetDealsList.UseVisualStyleBackColor = true;
            this.btnGetDealsList.Click += new System.EventHandler(this.btnGetDealsList_Click);
            // 
            // btnGetOrders
            // 
            this.btnGetOrders.Location = new System.Drawing.Point(12, 160);
            this.btnGetOrders.Name = "btnGetOrders";
            this.btnGetOrders.Size = new System.Drawing.Size(145, 23);
            this.btnGetOrders.TabIndex = 8;
            this.btnGetOrders.Text = "Get Orders";
            this.btnGetOrders.UseVisualStyleBackColor = true;
            this.btnGetOrders.Click += new System.EventHandler(this.btnGetOrders_Click);
            // 
            // btnGetTransactions
            // 
            this.btnGetTransactions.Location = new System.Drawing.Point(12, 189);
            this.btnGetTransactions.Name = "btnGetTransactions";
            this.btnGetTransactions.Size = new System.Drawing.Size(145, 23);
            this.btnGetTransactions.TabIndex = 9;
            this.btnGetTransactions.Text = "Get Transactions";
            this.btnGetTransactions.UseVisualStyleBackColor = true;
            this.btnGetTransactions.Click += new System.EventHandler(this.btnGetTransactions_Click);
            // 
            // btnGetTrendbars
            // 
            this.btnGetTrendbars.Location = new System.Drawing.Point(12, 218);
            this.btnGetTrendbars.Name = "btnGetTrendbars";
            this.btnGetTrendbars.Size = new System.Drawing.Size(145, 23);
            this.btnGetTrendbars.TabIndex = 10;
            this.btnGetTrendbars.Text = "Get Trendbars";
            this.btnGetTrendbars.UseVisualStyleBackColor = true;
            this.btnGetTrendbars.Click += new System.EventHandler(this.btnGetTrendbars_Click);
            // 
            // btnGetTickData
            // 
            this.btnGetTickData.Location = new System.Drawing.Point(12, 247);
            this.btnGetTickData.Name = "btnGetTickData";
            this.btnGetTickData.Size = new System.Drawing.Size(145, 23);
            this.btnGetTickData.TabIndex = 11;
            this.btnGetTickData.Text = "Get Tick Data";
            this.btnGetTickData.UseVisualStyleBackColor = true;
            this.btnGetTickData.Click += new System.EventHandler(this.btnGetTickData_Click);
            // 
            // btnGetSymbols
            // 
            this.btnGetSymbols.Location = new System.Drawing.Point(12, 102);
            this.btnGetSymbols.Name = "btnGetSymbols";
            this.btnGetSymbols.Size = new System.Drawing.Size(145, 23);
            this.btnGetSymbols.TabIndex = 12;
            this.btnGetSymbols.Text = "Get Symbols";
            this.btnGetSymbols.UseVisualStyleBackColor = true;
            this.btnGetSymbols.Click += new System.EventHandler(this.btnGetSymbols_Click);
            // 
            // btnSendStopOrder
            // 
            this.btnSendStopOrder.Location = new System.Drawing.Point(165, 102);
            this.btnSendStopOrder.Name = "btnSendStopOrder";
            this.btnSendStopOrder.Size = new System.Drawing.Size(159, 23);
            this.btnSendStopOrder.TabIndex = 14;
            this.btnSendStopOrder.Text = "Send Stop Order";
            this.btnSendStopOrder.UseVisualStyleBackColor = true;
            this.btnSendStopOrder.Click += new System.EventHandler(this.btnSendStopOrder_Click);
            // 
            // btnSendLimitOrder
            // 
            this.btnSendLimitOrder.Location = new System.Drawing.Point(165, 131);
            this.btnSendLimitOrder.Name = "btnSendLimitOrder";
            this.btnSendLimitOrder.Size = new System.Drawing.Size(159, 23);
            this.btnSendLimitOrder.TabIndex = 15;
            this.btnSendLimitOrder.Text = "Send Limit Order";
            this.btnSendLimitOrder.UseVisualStyleBackColor = true;
            this.btnSendLimitOrder.Click += new System.EventHandler(this.btnSendLimitOrder_Click);
            // 
            // btnSendStopLimitOrder
            // 
            this.btnSendStopLimitOrder.Location = new System.Drawing.Point(165, 160);
            this.btnSendStopLimitOrder.Name = "btnSendStopLimitOrder";
            this.btnSendStopLimitOrder.Size = new System.Drawing.Size(159, 23);
            this.btnSendStopLimitOrder.TabIndex = 16;
            this.btnSendStopLimitOrder.Text = "Send Stop Limit Order";
            this.btnSendStopLimitOrder.UseVisualStyleBackColor = true;
            this.btnSendStopLimitOrder.Click += new System.EventHandler(this.btnSendStopLimitOrder_Click);
            // 
            // btnClosePosition
            // 
            this.btnClosePosition.Location = new System.Drawing.Point(164, 189);
            this.btnClosePosition.Name = "btnClosePosition";
            this.btnClosePosition.Size = new System.Drawing.Size(160, 23);
            this.btnClosePosition.TabIndex = 17;
            this.btnClosePosition.Text = "Close Position";
            this.btnClosePosition.UseVisualStyleBackColor = true;
            this.btnClosePosition.Click += new System.EventHandler(this.btnClosePosition_Click);
            // 
            // txtPositionID
            // 
            this.txtPositionID.Location = new System.Drawing.Point(397, 191);
            this.txtPositionID.Name = "txtPositionID";
            this.txtPositionID.Size = new System.Drawing.Size(100, 20);
            this.txtPositionID.TabIndex = 18;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(566, 191);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(100, 20);
            this.txtVolume.TabIndex = 19;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(330, 197);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 13);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "Position ID:";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(503, 195);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(45, 13);
            this.lblVolume.TabIndex = 21;
            this.lblVolume.Text = "Volume:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 338);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.lblAccounts);
            this.splitContainer1.Panel1.Controls.Add(this.cbAccounts);
            this.splitContainer1.Panel1.Controls.Add(this.lblTakeProfit);
            this.splitContainer1.Panel1.Controls.Add(this.txtTakeProfit);
            this.splitContainer1.Panel1.Controls.Add(this.lblStolLoss);
            this.splitContainer1.Panel1.Controls.Add(this.lblID2);
            this.splitContainer1.Panel1.Controls.Add(this.txtStopLoss);
            this.splitContainer1.Panel1.Controls.Add(this.txtPositionIDTPSL);
            this.splitContainer1.Panel1.Controls.Add(this.btnAmentSLTP);
            this.splitContainer1.Panel1.Controls.Add(this.btnAuthorizeApplication);
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetAccountsList);
            this.splitContainer1.Panel1.Controls.Add(this.lblVolume);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblID);
            this.splitContainer1.Panel1.Controls.Add(this.btnSendMarketOrder);
            this.splitContainer1.Panel1.Controls.Add(this.txtVolume);
            this.splitContainer1.Panel1.Controls.Add(this.btnAuthorizeAccount);
            this.splitContainer1.Panel1.Controls.Add(this.m_txtOrderID);
            this.splitContainer1.Panel1.Controls.Add(this.btnSubscribeForSpots);
            this.splitContainer1.Panel1.Controls.Add(this.txtPositionID);
            this.splitContainer1.Panel1.Controls.Add(this.btnUnSubscribeFrorSpots);
            this.splitContainer1.Panel1.Controls.Add(this.m_btnCloseOrder);
            this.splitContainer1.Panel1.Controls.Add(this.btnClosePosition);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetDealsList);
            this.splitContainer1.Panel1.Controls.Add(this.m_btnMarketRangeOrder);
            this.splitContainer1.Panel1.Controls.Add(this.btnSendStopLimitOrder);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetOrders);
            this.splitContainer1.Panel1.Controls.Add(this.btnSendLimitOrder);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetTransactions);
            this.splitContainer1.Panel1.Controls.Add(this.btnSendStopOrder);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetTrendbars);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetTickData);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetSymbols);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtMessages);
            this.splitContainer1.Size = new System.Drawing.Size(1186, 575);
            this.splitContainer1.SplitterDistance = 364;
            this.splitContainer1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Get Tick Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAccounts
            // 
            this.lblAccounts.AutoSize = true;
            this.lblAccounts.Location = new System.Drawing.Point(12, 78);
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.Size = new System.Drawing.Size(50, 13);
            this.lblAccounts.TabIndex = 31;
            this.lblAccounts.Text = "Account:";
            // 
            // cbAccounts
            // 
            this.cbAccounts.FormattingEnabled = true;
            this.cbAccounts.Location = new System.Drawing.Point(73, 73);
            this.cbAccounts.Name = "cbAccounts";
            this.cbAccounts.Size = new System.Drawing.Size(85, 21);
            this.cbAccounts.TabIndex = 30;
            this.cbAccounts.SelectedIndexChanged += new System.EventHandler(this.cbAccounts_SelectedIndexChanged);
            // 
            // lblTakeProfit
            // 
            this.lblTakeProfit.AutoSize = true;
            this.lblTakeProfit.Location = new System.Drawing.Point(680, 223);
            this.lblTakeProfit.Name = "lblTakeProfit";
            this.lblTakeProfit.Size = new System.Drawing.Size(62, 13);
            this.lblTakeProfit.TabIndex = 29;
            this.lblTakeProfit.Text = "Take Profit:";
            // 
            // txtTakeProfit
            // 
            this.txtTakeProfit.Location = new System.Drawing.Point(743, 220);
            this.txtTakeProfit.Name = "txtTakeProfit";
            this.txtTakeProfit.Size = new System.Drawing.Size(100, 20);
            this.txtTakeProfit.TabIndex = 28;
            // 
            // lblStolLoss
            // 
            this.lblStolLoss.AutoSize = true;
            this.lblStolLoss.Location = new System.Drawing.Point(503, 221);
            this.lblStolLoss.Name = "lblStolLoss";
            this.lblStolLoss.Size = new System.Drawing.Size(57, 13);
            this.lblStolLoss.TabIndex = 27;
            this.lblStolLoss.Text = "Stop Loss:";
            // 
            // lblID2
            // 
            this.lblID2.AutoSize = true;
            this.lblID2.Location = new System.Drawing.Point(330, 223);
            this.lblID2.Name = "lblID2";
            this.lblID2.Size = new System.Drawing.Size(61, 13);
            this.lblID2.TabIndex = 26;
            this.lblID2.Text = "Position ID:";
            // 
            // txtStopLoss
            // 
            this.txtStopLoss.Location = new System.Drawing.Point(566, 218);
            this.txtStopLoss.Name = "txtStopLoss";
            this.txtStopLoss.Size = new System.Drawing.Size(100, 20);
            this.txtStopLoss.TabIndex = 25;
            // 
            // txtPositionIDTPSL
            // 
            this.txtPositionIDTPSL.Location = new System.Drawing.Point(397, 217);
            this.txtPositionIDTPSL.Name = "txtPositionIDTPSL";
            this.txtPositionIDTPSL.Size = new System.Drawing.Size(100, 20);
            this.txtPositionIDTPSL.TabIndex = 24;
            // 
            // btnAmentSLTP
            // 
            this.btnAmentSLTP.Location = new System.Drawing.Point(164, 218);
            this.btnAmentSLTP.Name = "btnAmentSLTP";
            this.btnAmentSLTP.Size = new System.Drawing.Size(160, 23);
            this.btnAmentSLTP.TabIndex = 23;
            this.btnAmentSLTP.Text = "Amend Stop Loss/Take Profit";
            this.btnAmentSLTP.UseVisualStyleBackColor = true;
            this.btnAmentSLTP.Click += new System.EventHandler(this.btnAmentSLTP_Click);
            // 
            // btnAuthorizeAccount
            // 
            this.btnAuthorizeAccount.Location = new System.Drawing.Point(338, 15);
            this.btnAuthorizeAccount.Name = "btnAuthorizeAccount";
            this.btnAuthorizeAccount.Size = new System.Drawing.Size(159, 23);
            this.btnAuthorizeAccount.TabIndex = 5;
            this.btnAuthorizeAccount.Text = "AuthorizeAccount";
            this.btnAuthorizeAccount.UseVisualStyleBackColor = true;
            this.btnAuthorizeAccount.Click += new System.EventHandler(this.btnAuthorizeAccount_Click);
            // 
            // m_btnMarketRangeOrder
            // 
            this.m_btnMarketRangeOrder.Location = new System.Drawing.Point(330, 160);
            this.m_btnMarketRangeOrder.Name = "m_btnMarketRangeOrder";
            this.m_btnMarketRangeOrder.Size = new System.Drawing.Size(159, 23);
            this.m_btnMarketRangeOrder.TabIndex = 16;
            this.m_btnMarketRangeOrder.Text = "Send Market Range Order";
            this.m_btnMarketRangeOrder.UseVisualStyleBackColor = true;
            this.m_btnMarketRangeOrder.Click += new System.EventHandler(this.m_btnMarketRangeOrder_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // m_btnCloseOrder
            // 
            this.m_btnCloseOrder.Location = new System.Drawing.Point(163, 247);
            this.m_btnCloseOrder.Name = "m_btnCloseOrder";
            this.m_btnCloseOrder.Size = new System.Drawing.Size(160, 23);
            this.m_btnCloseOrder.TabIndex = 17;
            this.m_btnCloseOrder.Text = "Close Order";
            this.m_btnCloseOrder.UseVisualStyleBackColor = true;
            this.m_btnCloseOrder.Click += new System.EventHandler(this.m_btnCloseOrder_Click);
            // 
            // m_txtOrderID
            // 
            this.m_txtOrderID.Location = new System.Drawing.Point(397, 248);
            this.m_txtOrderID.Name = "m_txtOrderID";
            this.m_txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.m_txtOrderID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Order ID:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 575);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Open API Client";
            this.Load += new System.EventHandler(this.Main_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.Button btnAuthorizeApplication;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnGetAccountsList;
        private System.Windows.Forms.Button btnSendMarketOrder;
        private System.Windows.Forms.Button btnSubscribeForSpots;
        private System.Windows.Forms.Button btnUnSubscribeFrorSpots;
        private System.Windows.Forms.Button btnGetDealsList;
        private System.Windows.Forms.Button btnGetOrders;
        private System.Windows.Forms.Button btnGetTransactions;
        private System.Windows.Forms.Button btnGetTrendbars;
        private System.Windows.Forms.Button btnGetTickData;
        private System.Windows.Forms.Button btnGetSymbols;
        private System.Windows.Forms.Button btnSendStopOrder;
        private System.Windows.Forms.Button btnSendLimitOrder;
        private System.Windows.Forms.Button btnSendStopLimitOrder;
        private System.Windows.Forms.Button btnClosePosition;
        private System.Windows.Forms.TextBox txtPositionID;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblTakeProfit;
        private System.Windows.Forms.TextBox txtTakeProfit;
        private System.Windows.Forms.Label lblStolLoss;
        private System.Windows.Forms.Label lblID2;
        private System.Windows.Forms.TextBox txtStopLoss;
        private System.Windows.Forms.TextBox txtPositionIDTPSL;
        private System.Windows.Forms.Button btnAmentSLTP;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblAccounts;
        private System.Windows.Forms.ComboBox cbAccounts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAuthorizeAccount;
        private System.Windows.Forms.Button m_btnMarketRangeOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txtOrderID;
        private System.Windows.Forms.Button m_btnCloseOrder;
    }
}

