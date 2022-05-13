namespace Santos_ProductProfile
{
    partial class frmHome
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
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.dataPRD = new System.Windows.Forms.DataGridView();
            this.prdPricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdManufact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrdID = new System.Windows.Forms.TextBox();
            this.txtprdName = new System.Windows.Forms.TextBox();
            this.txtPrdType = new System.Windows.Forms.TextBox();
            this.txtPrdManufact = new System.Windows.Forms.TextBox();
            this.txtPrdPPU = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdatee = new System.Windows.Forms.Button();
            this.btnClearer = new System.Windows.Forms.Button();
            this.tabPageEmployees = new System.Windows.Forms.TabPage();
            this.dataEmployees = new System.Windows.Forms.DataGridView();
            this.empAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empMname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txtempAddress = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtempLname = new System.Windows.Forms.TextBox();
            this.txtempFName = new System.Windows.Forms.TextBox();
            this.txtEmpMname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCLear = new System.Windows.Forms.Button();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPRD)).BeginInit();
            this.tabPageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployees)).BeginInit();
            this.tab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.btnClearer);
            this.tabPageProducts.Controls.Add(this.btnUpdatee);
            this.tabPageProducts.Controls.Add(this.btnAdd);
            this.tabPageProducts.Controls.Add(this.label10);
            this.tabPageProducts.Controls.Add(this.label9);
            this.tabPageProducts.Controls.Add(this.label8);
            this.tabPageProducts.Controls.Add(this.label7);
            this.tabPageProducts.Controls.Add(this.label6);
            this.tabPageProducts.Controls.Add(this.txtPrdPPU);
            this.tabPageProducts.Controls.Add(this.txtPrdManufact);
            this.tabPageProducts.Controls.Add(this.txtPrdType);
            this.tabPageProducts.Controls.Add(this.txtprdName);
            this.tabPageProducts.Controls.Add(this.txtPrdID);
            this.tabPageProducts.Controls.Add(this.dataPRD);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 25);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(919, 449);
            this.tabPageProducts.TabIndex = 1;
            this.tabPageProducts.Text = "Products";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // dataPRD
            // 
            this.dataPRD.AllowUserToAddRows = false;
            this.dataPRD.AllowUserToDeleteRows = false;
            this.dataPRD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPRD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prdID,
            this.prdName,
            this.prdType,
            this.prdManufact,
            this.prdPricePerUnit});
            this.dataPRD.Location = new System.Drawing.Point(224, 20);
            this.dataPRD.Name = "dataPRD";
            this.dataPRD.ReadOnly = true;
            this.dataPRD.RowHeadersWidth = 51;
            this.dataPRD.RowTemplate.Height = 24;
            this.dataPRD.Size = new System.Drawing.Size(676, 379);
            this.dataPRD.TabIndex = 0;
            this.dataPRD.SelectionChanged += new System.EventHandler(this.dataPRD_SelectionChanged);
            // 
            // prdPricePerUnit
            // 
            this.prdPricePerUnit.HeaderText = "Price Per Unit";
            this.prdPricePerUnit.MinimumWidth = 6;
            this.prdPricePerUnit.Name = "prdPricePerUnit";
            this.prdPricePerUnit.ReadOnly = true;
            this.prdPricePerUnit.Width = 125;
            // 
            // prdManufact
            // 
            this.prdManufact.HeaderText = "Manufacturer";
            this.prdManufact.MinimumWidth = 6;
            this.prdManufact.Name = "prdManufact";
            this.prdManufact.ReadOnly = true;
            this.prdManufact.Width = 125;
            // 
            // prdType
            // 
            this.prdType.HeaderText = "Product Type";
            this.prdType.MinimumWidth = 6;
            this.prdType.Name = "prdType";
            this.prdType.ReadOnly = true;
            this.prdType.Width = 125;
            // 
            // prdName
            // 
            this.prdName.HeaderText = "Product Name";
            this.prdName.MinimumWidth = 6;
            this.prdName.Name = "prdName";
            this.prdName.ReadOnly = true;
            this.prdName.Width = 125;
            // 
            // prdID
            // 
            this.prdID.HeaderText = "Prod ID";
            this.prdID.MinimumWidth = 6;
            this.prdID.Name = "prdID";
            this.prdID.ReadOnly = true;
            this.prdID.Width = 125;
            // 
            // txtPrdID
            // 
            this.txtPrdID.Location = new System.Drawing.Point(80, 101);
            this.txtPrdID.Name = "txtPrdID";
            this.txtPrdID.Size = new System.Drawing.Size(100, 22);
            this.txtPrdID.TabIndex = 1;
            // 
            // txtprdName
            // 
            this.txtprdName.Location = new System.Drawing.Point(80, 177);
            this.txtprdName.Name = "txtprdName";
            this.txtprdName.Size = new System.Drawing.Size(100, 22);
            this.txtprdName.TabIndex = 2;
            // 
            // txtPrdType
            // 
            this.txtPrdType.Location = new System.Drawing.Point(80, 244);
            this.txtPrdType.Name = "txtPrdType";
            this.txtPrdType.Size = new System.Drawing.Size(100, 22);
            this.txtPrdType.TabIndex = 3;
            // 
            // txtPrdManufact
            // 
            this.txtPrdManufact.Location = new System.Drawing.Point(80, 317);
            this.txtPrdManufact.Name = "txtPrdManufact";
            this.txtPrdManufact.Size = new System.Drawing.Size(100, 22);
            this.txtPrdManufact.TabIndex = 4;
            // 
            // txtPrdPPU
            // 
            this.txtPrdPPU.Location = new System.Drawing.Point(80, 396);
            this.txtPrdPPU.Name = "txtPrdPPU";
            this.txtPrdPPU.Size = new System.Drawing.Size(100, 22);
            this.txtPrdPPU.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Product ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Product Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Product Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Manufacturer:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Price - Per - Unit";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(215, 423);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdatee
            // 
            this.btnUpdatee.Location = new System.Drawing.Point(322, 423);
            this.btnUpdatee.Name = "btnUpdatee";
            this.btnUpdatee.Size = new System.Drawing.Size(89, 23);
            this.btnUpdatee.TabIndex = 12;
            this.btnUpdatee.Text = "UPDATE";
            this.btnUpdatee.UseVisualStyleBackColor = true;
            this.btnUpdatee.Click += new System.EventHandler(this.btnUpdatee_Click);
            // 
            // btnClearer
            // 
            this.btnClearer.Location = new System.Drawing.Point(453, 423);
            this.btnClearer.Name = "btnClearer";
            this.btnClearer.Size = new System.Drawing.Size(75, 23);
            this.btnClearer.TabIndex = 13;
            this.btnClearer.Text = "CLEAR";
            this.btnClearer.UseVisualStyleBackColor = true;
            this.btnClearer.Click += new System.EventHandler(this.btnClearer_Click);
            // 
            // tabPageEmployees
            // 
            this.tabPageEmployees.Controls.Add(this.btnCLear);
            this.tabPageEmployees.Controls.Add(this.btnUpdate);
            this.tabPageEmployees.Controls.Add(this.label5);
            this.tabPageEmployees.Controls.Add(this.label4);
            this.tabPageEmployees.Controls.Add(this.label3);
            this.tabPageEmployees.Controls.Add(this.label2);
            this.tabPageEmployees.Controls.Add(this.label1);
            this.tabPageEmployees.Controls.Add(this.txtEmpMname);
            this.tabPageEmployees.Controls.Add(this.txtempFName);
            this.tabPageEmployees.Controls.Add(this.txtempLname);
            this.tabPageEmployees.Controls.Add(this.txtEmpID);
            this.tabPageEmployees.Controls.Add(this.txtempAddress);
            this.tabPageEmployees.Controls.Add(this.button1);
            this.tabPageEmployees.Controls.Add(this.dataEmployees);
            this.tabPageEmployees.Location = new System.Drawing.Point(4, 25);
            this.tabPageEmployees.Name = "tabPageEmployees";
            this.tabPageEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployees.Size = new System.Drawing.Size(919, 449);
            this.tabPageEmployees.TabIndex = 0;
            this.tabPageEmployees.Text = "Employees";
            this.tabPageEmployees.UseVisualStyleBackColor = true;
            // 
            // dataEmployees
            // 
            this.dataEmployees.AllowUserToAddRows = false;
            this.dataEmployees.AllowUserToDeleteRows = false;
            this.dataEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empID,
            this.empLname,
            this.empFName,
            this.empMname,
            this.empAddress});
            this.dataEmployees.Location = new System.Drawing.Point(237, 30);
            this.dataEmployees.Name = "dataEmployees";
            this.dataEmployees.ReadOnly = true;
            this.dataEmployees.RowHeadersWidth = 51;
            this.dataEmployees.RowTemplate.Height = 24;
            this.dataEmployees.Size = new System.Drawing.Size(659, 398);
            this.dataEmployees.TabIndex = 0;
            this.dataEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEmployees_CellContentClick);
            this.dataEmployees.SelectionChanged += new System.EventHandler(this.dataEmployees_SelectionChanged);
            // 
            // empAddress
            // 
            this.empAddress.HeaderText = "Address";
            this.empAddress.MinimumWidth = 6;
            this.empAddress.Name = "empAddress";
            this.empAddress.ReadOnly = true;
            this.empAddress.Width = 125;
            // 
            // empMname
            // 
            this.empMname.HeaderText = "MiddleName";
            this.empMname.MinimumWidth = 6;
            this.empMname.Name = "empMname";
            this.empMname.ReadOnly = true;
            this.empMname.Width = 125;
            // 
            // empFName
            // 
            this.empFName.HeaderText = "FirstName";
            this.empFName.MinimumWidth = 6;
            this.empFName.Name = "empFName";
            this.empFName.ReadOnly = true;
            this.empFName.Width = 125;
            // 
            // empLname
            // 
            this.empLname.HeaderText = "Last Name";
            this.empLname.MinimumWidth = 6;
            this.empLname.Name = "empLname";
            this.empLname.ReadOnly = true;
            this.empLname.Width = 125;
            // 
            // empID
            // 
            this.empID.HeaderText = "Emp ID";
            this.empID.MinimumWidth = 6;
            this.empID.Name = "empID";
            this.empID.ReadOnly = true;
            this.empID.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtempAddress
            // 
            this.txtempAddress.Location = new System.Drawing.Point(114, 337);
            this.txtempAddress.Name = "txtempAddress";
            this.txtempAddress.Size = new System.Drawing.Size(100, 22);
            this.txtempAddress.TabIndex = 3;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(114, 89);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(100, 22);
            this.txtEmpID.TabIndex = 4;
            // 
            // txtempLname
            // 
            this.txtempLname.Location = new System.Drawing.Point(114, 151);
            this.txtempLname.Name = "txtempLname";
            this.txtempLname.Size = new System.Drawing.Size(100, 22);
            this.txtempLname.TabIndex = 5;
            this.txtempLname.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtempFName
            // 
            this.txtempFName.Location = new System.Drawing.Point(114, 214);
            this.txtempFName.Name = "txtempFName";
            this.txtempFName.Size = new System.Drawing.Size(100, 22);
            this.txtempFName.TabIndex = 6;
            // 
            // txtEmpMname
            // 
            this.txtEmpMname.Location = new System.Drawing.Point(114, 281);
            this.txtEmpMname.Name = "txtEmpMname";
            this.txtEmpMname.Size = new System.Drawing.Size(100, 22);
            this.txtEmpMname.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Emp ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Middle Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Address:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(129, 420);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCLear
            // 
            this.btnCLear.Location = new System.Drawing.Point(14, 404);
            this.btnCLear.Name = "btnCLear";
            this.btnCLear.Size = new System.Drawing.Size(89, 23);
            this.btnCLear.TabIndex = 14;
            this.btnCLear.Text = "Clear";
            this.btnCLear.UseVisualStyleBackColor = true;
            this.btnCLear.Click += new System.EventHandler(this.btnCLear_Click);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPageEmployees);
            this.tab1.Controls.Add(this.tabPageProducts);
            this.tab1.Location = new System.Drawing.Point(12, 12);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(927, 478);
            this.tab1.TabIndex = 0;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 518);
            this.Controls.Add(this.tab1);
            this.Name = "frmHome";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.tabPageProducts.ResumeLayout(false);
            this.tabPageProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPRD)).EndInit();
            this.tabPageEmployees.ResumeLayout(false);
            this.tabPageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployees)).EndInit();
            this.tab1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.Button btnClearer;
        private System.Windows.Forms.Button btnUpdatee;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrdPPU;
        private System.Windows.Forms.TextBox txtPrdManufact;
        private System.Windows.Forms.TextBox txtPrdType;
        private System.Windows.Forms.TextBox txtprdName;
        private System.Windows.Forms.TextBox txtPrdID;
        private System.Windows.Forms.DataGridView dataPRD;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdManufact;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdPricePerUnit;
        private System.Windows.Forms.TabPage tabPageEmployees;
        private System.Windows.Forms.Button btnCLear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpMname;
        private System.Windows.Forms.TextBox txtempFName;
        private System.Windows.Forms.TextBox txtempLname;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtempAddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn empID;
        private System.Windows.Forms.DataGridViewTextBoxColumn empLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn empFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn empMname;
        private System.Windows.Forms.DataGridViewTextBoxColumn empAddress;
        private System.Windows.Forms.TabControl tab1;
    }
}