namespace CustomerInfo
{
    partial class Form1
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
            this.BtSave = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.BoxCustomerID = new System.Windows.Forms.TextBox();
            this.BoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtNew = new System.Windows.Forms.Button();
            this.BtEdit = new System.Windows.Forms.Button();
            this.BtCancel = new System.Windows.Forms.Button();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtSave
            // 
            this.BtSave.Location = new System.Drawing.Point(714, 520);
            this.BtSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(58, 25);
            this.BtSave.TabIndex = 6;
            this.BtSave.Text = "Save";
            this.BtSave.UseVisualStyleBackColor = true;
            this.BtSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.customerBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(36, 315);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(735, 189);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer ID:";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel.Controls.Add(this.BoxAddress);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.BoxEmail);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.BoxName);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.BoxCustomerID);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(36, 14);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(735, 217);
            this.panel.TabIndex = 7;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BoxCustomerID
            // 
            this.BoxCustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerID", true));
            this.BoxCustomerID.Location = new System.Drawing.Point(130, 36);
            this.BoxCustomerID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoxCustomerID.Name = "BoxCustomerID";
            this.BoxCustomerID.Size = new System.Drawing.Size(93, 20);
            this.BoxCustomerID.TabIndex = 0;
            // 
            // BoxName
            // 
            this.BoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "FullName", true));
            this.BoxName.Location = new System.Drawing.Point(130, 71);
            this.BoxName.Margin = new System.Windows.Forms.Padding(2);
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(434, 20);
            this.BoxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // BoxEmail
            // 
            this.BoxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Email", true));
            this.BoxEmail.Location = new System.Drawing.Point(130, 99);
            this.BoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.BoxEmail.Name = "BoxEmail";
            this.BoxEmail.Size = new System.Drawing.Size(434, 20);
            this.BoxEmail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // BoxAddress
            // 
            this.BoxAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address", true));
            this.BoxAddress.Location = new System.Drawing.Point(130, 130);
            this.BoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.BoxAddress.Multiline = true;
            this.BoxAddress.Name = "BoxAddress";
            this.BoxAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.BoxAddress.Size = new System.Drawing.Size(434, 70);
            this.BoxAddress.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address:";
            // 
            // BoxSearch
            // 
            this.BoxSearch.Location = new System.Drawing.Point(144, 260);
            this.BoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BoxSearch.Name = "BoxSearch";
            this.BoxSearch.Size = new System.Drawing.Size(434, 20);
            this.BoxSearch.TabIndex = 2;
            this.BoxSearch.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.BoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxSearch_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Search:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BtNew
            // 
            this.BtNew.Location = new System.Drawing.Point(528, 520);
            this.BtNew.Margin = new System.Windows.Forms.Padding(2);
            this.BtNew.Name = "BtNew";
            this.BtNew.Size = new System.Drawing.Size(58, 25);
            this.BtNew.TabIndex = 3;
            this.BtNew.Text = "New";
            this.BtNew.UseVisualStyleBackColor = true;
            this.BtNew.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtEdit
            // 
            this.BtEdit.Location = new System.Drawing.Point(590, 520);
            this.BtEdit.Margin = new System.Windows.Forms.Padding(2);
            this.BtEdit.Name = "BtEdit";
            this.BtEdit.Size = new System.Drawing.Size(58, 25);
            this.BtEdit.TabIndex = 4;
            this.BtEdit.Text = "Edit";
            this.BtEdit.UseVisualStyleBackColor = true;
            this.BtEdit.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtCancel
            // 
            this.BtCancel.Location = new System.Drawing.Point(652, 520);
            this.BtCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(58, 25);
            this.BtCancel.TabIndex = 5;
            this.BtCancel.Text = "Cancel";
            this.BtCancel.UseVisualStyleBackColor = true;
            this.BtCancel.Click += new System.EventHandler(this.button4_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(CustomerInfo.Customer);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 554);
            this.Controls.Add(this.BtCancel);
            this.Controls.Add(this.BtEdit);
            this.Controls.Add(this.BtNew);
            this.Controls.Add(this.BoxSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.BtSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cusumer Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox BoxCustomerID;
        private System.Windows.Forms.TextBox BoxAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BoxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtNew;
        private System.Windows.Forms.Button BtEdit;
        private System.Windows.Forms.Button BtCancel;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}

