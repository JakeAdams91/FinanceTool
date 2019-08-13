namespace FinanceTool2
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInvestmentCalc = new System.Windows.Forms.Button();
            this.btnBudgetTool = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.investCalc1 = new FinanceTool2.InvestCalc();
            this.budgetTool1 = new FinanceTool2.BudgetTool();
            this.dashboard1 = new FinanceTool2.Dashboard();
            this.panel1.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(98)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.btnInvestmentCalc);
            this.panel1.Controls.Add(this.btnBudgetTool);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.LogoPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 528);
            this.panel1.TabIndex = 0;
            // 
            // btnInvestmentCalc
            // 
            this.btnInvestmentCalc.BackColor = System.Drawing.Color.DimGray;
            this.btnInvestmentCalc.FlatAppearance.BorderSize = 0;
            this.btnInvestmentCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvestmentCalc.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvestmentCalc.ForeColor = System.Drawing.Color.White;
            this.btnInvestmentCalc.Location = new System.Drawing.Point(0, 150);
            this.btnInvestmentCalc.Name = "btnInvestmentCalc";
            this.btnInvestmentCalc.Size = new System.Drawing.Size(174, 50);
            this.btnInvestmentCalc.TabIndex = 5;
            this.btnInvestmentCalc.Text = "Investment Calc";
            this.btnInvestmentCalc.UseVisualStyleBackColor = false;
            this.btnInvestmentCalc.Click += new System.EventHandler(this.BtnInvestmentCalc_Click);
            // 
            // btnBudgetTool
            // 
            this.btnBudgetTool.BackColor = System.Drawing.Color.DimGray;
            this.btnBudgetTool.FlatAppearance.BorderSize = 0;
            this.btnBudgetTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBudgetTool.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBudgetTool.ForeColor = System.Drawing.Color.White;
            this.btnBudgetTool.Location = new System.Drawing.Point(0, 100);
            this.btnBudgetTool.Name = "btnBudgetTool";
            this.btnBudgetTool.Size = new System.Drawing.Size(174, 50);
            this.btnBudgetTool.TabIndex = 4;
            this.btnBudgetTool.Text = "Budget Tool";
            this.btnBudgetTool.UseVisualStyleBackColor = false;
            this.btnBudgetTool.Click += new System.EventHandler(this.BtnBudgetTool_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.DimGray;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 50);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(174, 50);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(137)))), ((int)(((byte)(26)))));
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(174, 51);
            this.LogoPanel.TabIndex = 2;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.Window;
            this.headerPanel.Controls.Add(this.btnClose);
            this.headerPanel.Controls.Add(this.lblHeader);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(174, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(627, 51);
            this.headerPanel.TabIndex = 1;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(23, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(129, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Dashboard";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::FinanceTool2.Properties.Resources.CloseI;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(590, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // investCalc1
            // 
            this.investCalc1.Location = new System.Drawing.Point(174, 52);
            this.investCalc1.Name = "investCalc1";
            this.investCalc1.Size = new System.Drawing.Size(625, 476);
            this.investCalc1.TabIndex = 4;
            this.investCalc1.Visible = false;
            // 
            // budgetTool1
            // 
            this.budgetTool1.Location = new System.Drawing.Point(174, 50);
            this.budgetTool1.Name = "budgetTool1";
            this.budgetTool1.Size = new System.Drawing.Size(625, 476);
            this.budgetTool1.TabIndex = 3;
            this.budgetTool1.Visible = false;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(174, 52);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(625, 476);
            this.dashboard1.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(801, 528);
            this.Controls.Add(this.investCalc1);
            this.Controls.Add(this.budgetTool1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button btnInvestmentCalc;
        private System.Windows.Forms.Button btnBudgetTool;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnClose;
        private Dashboard dashboard1;
        private BudgetTool budgetTool1;
        private InvestCalc investCalc1;
    }
}

