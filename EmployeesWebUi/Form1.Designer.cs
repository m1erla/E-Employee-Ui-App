namespace EmployeesWebUi
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
            this.dgwEmployee = new System.Windows.Forms.DataGridView();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbxEmployeeFirstNameAdd = new System.Windows.Forms.TextBox();
            this.tbxEmployeeLastNameAdd = new System.Windows.Forms.TextBox();
            this.lblTıtle = new System.Windows.Forms.Label();
            this.cbxTıtle = new System.Windows.Forms.ComboBox();
            this.gbxEmployeeAdd = new System.Windows.Forms.GroupBox();
            this.lblAddCity = new System.Windows.Forms.Label();
            this.tbxAddCity = new System.Windows.Forms.TextBox();
            this.lblAddAdress = new System.Windows.Forms.Label();
            this.tbxAddAdress = new System.Windows.Forms.TextBox();
            this.lblAddPostalCode = new System.Windows.Forms.Label();
            this.lblAddCountry = new System.Windows.Forms.Label();
            this.tbxAddPostalCode = new System.Windows.Forms.TextBox();
            this.tbxAddCountry = new System.Windows.Forms.TextBox();
            this.gbxUpdateEmployee = new System.Windows.Forms.GroupBox();
            this.tbxUpdateCity = new System.Windows.Forms.TextBox();
            this.tbxUpdatePostalCode = new System.Windows.Forms.TextBox();
            this.tbxUpdateAdress = new System.Windows.Forms.TextBox();
            this.tbxUpdateCountry = new System.Windows.Forms.TextBox();
            this.lblUpdateCity = new System.Windows.Forms.Label();
            this.lblUpdatePostalCode = new System.Windows.Forms.Label();
            this.lblUpdateAdress = new System.Windows.Forms.Label();
            this.lblUpdateCountry = new System.Windows.Forms.Label();
            this.cbxUpdateTitle = new System.Windows.Forms.ComboBox();
            this.tbxUpdateLastName = new System.Windows.Forms.TextBox();
            this.tbxUpdateFirstName = new System.Windows.Forms.TextBox();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.lblUpdateLastName = new System.Windows.Forms.Label();
            this.lblUpdateFirstName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFireEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployee)).BeginInit();
            this.gbxEmployeeAdd.SuspendLayout();
            this.gbxUpdateEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwEmployee
            // 
            this.dgwEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgwEmployee.Name = "dgwEmployee";
            this.dgwEmployee.Size = new System.Drawing.Size(1009, 291);
            this.dgwEmployee.TabIndex = 0;
            this.dgwEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEmployee_CellClick);
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.Location = new System.Drawing.Point(284, 136);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(110, 30);
            this.btnEmployeeAdd.TabIndex = 1;
            this.btnEmployeeAdd.Text = "Add";
            this.btnEmployeeAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(24, 32);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(24, 67);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // tbxEmployeeFirstNameAdd
            // 
            this.tbxEmployeeFirstNameAdd.Location = new System.Drawing.Point(105, 32);
            this.tbxEmployeeFirstNameAdd.Name = "tbxEmployeeFirstNameAdd";
            this.tbxEmployeeFirstNameAdd.Size = new System.Drawing.Size(129, 20);
            this.tbxEmployeeFirstNameAdd.TabIndex = 8;
            // 
            // tbxEmployeeLastNameAdd
            // 
            this.tbxEmployeeLastNameAdd.Location = new System.Drawing.Point(105, 67);
            this.tbxEmployeeLastNameAdd.Name = "tbxEmployeeLastNameAdd";
            this.tbxEmployeeLastNameAdd.Size = new System.Drawing.Size(129, 20);
            this.tbxEmployeeLastNameAdd.TabIndex = 9;
            // 
            // lblTıtle
            // 
            this.lblTıtle.AutoSize = true;
            this.lblTıtle.Location = new System.Drawing.Point(24, 109);
            this.lblTıtle.Name = "lblTıtle";
            this.lblTıtle.Size = new System.Drawing.Size(62, 13);
            this.lblTıtle.TabIndex = 11;
            this.lblTıtle.Text = "Department";
            // 
            // cbxTıtle
            // 
            this.cbxTıtle.FormattingEnabled = true;
            this.cbxTıtle.Location = new System.Drawing.Point(105, 106);
            this.cbxTıtle.Name = "cbxTıtle";
            this.cbxTıtle.Size = new System.Drawing.Size(129, 21);
            this.cbxTıtle.TabIndex = 12;
            // 
            // gbxEmployeeAdd
            // 
            this.gbxEmployeeAdd.Controls.Add(this.lblAddCity);
            this.gbxEmployeeAdd.Controls.Add(this.tbxAddCity);
            this.gbxEmployeeAdd.Controls.Add(this.lblAddAdress);
            this.gbxEmployeeAdd.Controls.Add(this.tbxAddAdress);
            this.gbxEmployeeAdd.Controls.Add(this.lblAddPostalCode);
            this.gbxEmployeeAdd.Controls.Add(this.lblAddCountry);
            this.gbxEmployeeAdd.Controls.Add(this.tbxAddPostalCode);
            this.gbxEmployeeAdd.Controls.Add(this.tbxAddCountry);
            this.gbxEmployeeAdd.Controls.Add(this.tbxEmployeeFirstNameAdd);
            this.gbxEmployeeAdd.Controls.Add(this.cbxTıtle);
            this.gbxEmployeeAdd.Controls.Add(this.btnEmployeeAdd);
            this.gbxEmployeeAdd.Controls.Add(this.lblTıtle);
            this.gbxEmployeeAdd.Controls.Add(this.tbxEmployeeLastNameAdd);
            this.gbxEmployeeAdd.Controls.Add(this.lblFirstName);
            this.gbxEmployeeAdd.Controls.Add(this.lblLastName);
            this.gbxEmployeeAdd.Location = new System.Drawing.Point(12, 309);
            this.gbxEmployeeAdd.Name = "gbxEmployeeAdd";
            this.gbxEmployeeAdd.Size = new System.Drawing.Size(460, 291);
            this.gbxEmployeeAdd.TabIndex = 13;
            this.gbxEmployeeAdd.TabStop = false;
            this.gbxEmployeeAdd.Text = "New Employees Add";
            // 
            // lblAddCity
            // 
            this.lblAddCity.AutoSize = true;
            this.lblAddCity.Location = new System.Drawing.Point(24, 268);
            this.lblAddCity.Name = "lblAddCity";
            this.lblAddCity.Size = new System.Drawing.Size(24, 13);
            this.lblAddCity.TabIndex = 20;
            this.lblAddCity.Text = "City";
            // 
            // tbxAddCity
            // 
            this.tbxAddCity.Location = new System.Drawing.Point(105, 265);
            this.tbxAddCity.Name = "tbxAddCity";
            this.tbxAddCity.Size = new System.Drawing.Size(129, 20);
            this.tbxAddCity.TabIndex = 19;
            // 
            // lblAddAdress
            // 
            this.lblAddAdress.AutoSize = true;
            this.lblAddAdress.Location = new System.Drawing.Point(24, 229);
            this.lblAddAdress.Name = "lblAddAdress";
            this.lblAddAdress.Size = new System.Drawing.Size(39, 13);
            this.lblAddAdress.TabIndex = 18;
            this.lblAddAdress.Text = "Adress";
            // 
            // tbxAddAdress
            // 
            this.tbxAddAdress.Location = new System.Drawing.Point(105, 229);
            this.tbxAddAdress.Name = "tbxAddAdress";
            this.tbxAddAdress.Size = new System.Drawing.Size(129, 20);
            this.tbxAddAdress.TabIndex = 17;
            // 
            // lblAddPostalCode
            // 
            this.lblAddPostalCode.AutoSize = true;
            this.lblAddPostalCode.Location = new System.Drawing.Point(24, 180);
            this.lblAddPostalCode.Name = "lblAddPostalCode";
            this.lblAddPostalCode.Size = new System.Drawing.Size(64, 13);
            this.lblAddPostalCode.TabIndex = 16;
            this.lblAddPostalCode.Text = "Postal Code";
            // 
            // lblAddCountry
            // 
            this.lblAddCountry.AutoSize = true;
            this.lblAddCountry.Location = new System.Drawing.Point(24, 142);
            this.lblAddCountry.Name = "lblAddCountry";
            this.lblAddCountry.Size = new System.Drawing.Size(43, 13);
            this.lblAddCountry.TabIndex = 15;
            this.lblAddCountry.Text = "Country";
            // 
            // tbxAddPostalCode
            // 
            this.tbxAddPostalCode.Location = new System.Drawing.Point(105, 180);
            this.tbxAddPostalCode.Name = "tbxAddPostalCode";
            this.tbxAddPostalCode.Size = new System.Drawing.Size(129, 20);
            this.tbxAddPostalCode.TabIndex = 14;
            // 
            // tbxAddCountry
            // 
            this.tbxAddCountry.Location = new System.Drawing.Point(105, 142);
            this.tbxAddCountry.Name = "tbxAddCountry";
            this.tbxAddCountry.Size = new System.Drawing.Size(129, 20);
            this.tbxAddCountry.TabIndex = 13;
            // 
            // gbxUpdateEmployee
            // 
            this.gbxUpdateEmployee.Controls.Add(this.tbxUpdateCity);
            this.gbxUpdateEmployee.Controls.Add(this.tbxUpdatePostalCode);
            this.gbxUpdateEmployee.Controls.Add(this.tbxUpdateAdress);
            this.gbxUpdateEmployee.Controls.Add(this.tbxUpdateCountry);
            this.gbxUpdateEmployee.Controls.Add(this.lblUpdateCity);
            this.gbxUpdateEmployee.Controls.Add(this.lblUpdatePostalCode);
            this.gbxUpdateEmployee.Controls.Add(this.lblUpdateAdress);
            this.gbxUpdateEmployee.Controls.Add(this.lblUpdateCountry);
            this.gbxUpdateEmployee.Controls.Add(this.cbxUpdateTitle);
            this.gbxUpdateEmployee.Controls.Add(this.tbxUpdateLastName);
            this.gbxUpdateEmployee.Controls.Add(this.tbxUpdateFirstName);
            this.gbxUpdateEmployee.Controls.Add(this.lblUpdateTitle);
            this.gbxUpdateEmployee.Controls.Add(this.lblUpdateLastName);
            this.gbxUpdateEmployee.Controls.Add(this.lblUpdateFirstName);
            this.gbxUpdateEmployee.Controls.Add(this.btnUpdate);
            this.gbxUpdateEmployee.Controls.Add(this.btnFireEmployee);
            this.gbxUpdateEmployee.Location = new System.Drawing.Point(561, 309);
            this.gbxUpdateEmployee.Name = "gbxUpdateEmployee";
            this.gbxUpdateEmployee.Size = new System.Drawing.Size(460, 291);
            this.gbxUpdateEmployee.TabIndex = 15;
            this.gbxUpdateEmployee.TabStop = false;
            this.gbxUpdateEmployee.Text = "Update Employees";
            // 
            // tbxUpdateCity
            // 
            this.tbxUpdateCity.Location = new System.Drawing.Point(99, 265);
            this.tbxUpdateCity.Name = "tbxUpdateCity";
            this.tbxUpdateCity.Size = new System.Drawing.Size(135, 20);
            this.tbxUpdateCity.TabIndex = 19;
            // 
            // tbxUpdatePostalCode
            // 
            this.tbxUpdatePostalCode.Location = new System.Drawing.Point(99, 180);
            this.tbxUpdatePostalCode.Name = "tbxUpdatePostalCode";
            this.tbxUpdatePostalCode.Size = new System.Drawing.Size(135, 20);
            this.tbxUpdatePostalCode.TabIndex = 26;
            // 
            // tbxUpdateAdress
            // 
            this.tbxUpdateAdress.Location = new System.Drawing.Point(99, 229);
            this.tbxUpdateAdress.Name = "tbxUpdateAdress";
            this.tbxUpdateAdress.Size = new System.Drawing.Size(135, 20);
            this.tbxUpdateAdress.TabIndex = 18;
            // 
            // tbxUpdateCountry
            // 
            this.tbxUpdateCountry.Location = new System.Drawing.Point(99, 142);
            this.tbxUpdateCountry.Name = "tbxUpdateCountry";
            this.tbxUpdateCountry.Size = new System.Drawing.Size(135, 20);
            this.tbxUpdateCountry.TabIndex = 25;
            // 
            // lblUpdateCity
            // 
            this.lblUpdateCity.AutoSize = true;
            this.lblUpdateCity.Location = new System.Drawing.Point(18, 268);
            this.lblUpdateCity.Name = "lblUpdateCity";
            this.lblUpdateCity.Size = new System.Drawing.Size(24, 13);
            this.lblUpdateCity.TabIndex = 17;
            this.lblUpdateCity.Text = "City";
            // 
            // lblUpdatePostalCode
            // 
            this.lblUpdatePostalCode.AutoSize = true;
            this.lblUpdatePostalCode.Location = new System.Drawing.Point(16, 180);
            this.lblUpdatePostalCode.Name = "lblUpdatePostalCode";
            this.lblUpdatePostalCode.Size = new System.Drawing.Size(64, 13);
            this.lblUpdatePostalCode.TabIndex = 24;
            this.lblUpdatePostalCode.Text = "Postal Code";
            // 
            // lblUpdateAdress
            // 
            this.lblUpdateAdress.AutoSize = true;
            this.lblUpdateAdress.Location = new System.Drawing.Point(18, 229);
            this.lblUpdateAdress.Name = "lblUpdateAdress";
            this.lblUpdateAdress.Size = new System.Drawing.Size(39, 13);
            this.lblUpdateAdress.TabIndex = 16;
            this.lblUpdateAdress.Text = "Adress";
            // 
            // lblUpdateCountry
            // 
            this.lblUpdateCountry.AutoSize = true;
            this.lblUpdateCountry.Location = new System.Drawing.Point(18, 142);
            this.lblUpdateCountry.Name = "lblUpdateCountry";
            this.lblUpdateCountry.Size = new System.Drawing.Size(43, 13);
            this.lblUpdateCountry.TabIndex = 23;
            this.lblUpdateCountry.Text = "Country";
            // 
            // cbxUpdateTitle
            // 
            this.cbxUpdateTitle.FormattingEnabled = true;
            this.cbxUpdateTitle.Location = new System.Drawing.Point(99, 106);
            this.cbxUpdateTitle.Name = "cbxUpdateTitle";
            this.cbxUpdateTitle.Size = new System.Drawing.Size(135, 21);
            this.cbxUpdateTitle.TabIndex = 22;
            // 
            // tbxUpdateLastName
            // 
            this.tbxUpdateLastName.Location = new System.Drawing.Point(99, 67);
            this.tbxUpdateLastName.Name = "tbxUpdateLastName";
            this.tbxUpdateLastName.Size = new System.Drawing.Size(135, 20);
            this.tbxUpdateLastName.TabIndex = 21;
            // 
            // tbxUpdateFirstName
            // 
            this.tbxUpdateFirstName.Location = new System.Drawing.Point(99, 32);
            this.tbxUpdateFirstName.Name = "tbxUpdateFirstName";
            this.tbxUpdateFirstName.Size = new System.Drawing.Size(135, 20);
            this.tbxUpdateFirstName.TabIndex = 20;
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.AutoSize = true;
            this.lblUpdateTitle.Location = new System.Drawing.Point(18, 109);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(62, 13);
            this.lblUpdateTitle.TabIndex = 18;
            this.lblUpdateTitle.Text = "Department";
            // 
            // lblUpdateLastName
            // 
            this.lblUpdateLastName.AutoSize = true;
            this.lblUpdateLastName.Location = new System.Drawing.Point(18, 67);
            this.lblUpdateLastName.Name = "lblUpdateLastName";
            this.lblUpdateLastName.Size = new System.Drawing.Size(58, 13);
            this.lblUpdateLastName.TabIndex = 17;
            this.lblUpdateLastName.Text = "Last Name";
            // 
            // lblUpdateFirstName
            // 
            this.lblUpdateFirstName.AutoSize = true;
            this.lblUpdateFirstName.Location = new System.Drawing.Point(18, 32);
            this.lblUpdateFirstName.Name = "lblUpdateFirstName";
            this.lblUpdateFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblUpdateFirstName.TabIndex = 16;
            this.lblUpdateFirstName.Text = "First Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(284, 142);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 26);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFireEmployee
            // 
            this.btnFireEmployee.Location = new System.Drawing.Point(284, 261);
            this.btnFireEmployee.Name = "btnFireEmployee";
            this.btnFireEmployee.Size = new System.Drawing.Size(110, 30);
            this.btnFireEmployee.TabIndex = 13;
            this.btnFireEmployee.Text = "Fire";
            this.btnFireEmployee.UseVisualStyleBackColor = true;
            this.btnFireEmployee.Click += new System.EventHandler(this.btnFireEmployee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 615);
            this.Controls.Add(this.gbxUpdateEmployee);
            this.Controls.Add(this.gbxEmployeeAdd);
            this.Controls.Add(this.dgwEmployee);
            this.Name = "Form1";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployee)).EndInit();
            this.gbxEmployeeAdd.ResumeLayout(false);
            this.gbxEmployeeAdd.PerformLayout();
            this.gbxUpdateEmployee.ResumeLayout(false);
            this.gbxUpdateEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwEmployee;
        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbxEmployeeFirstNameAdd;
        private System.Windows.Forms.TextBox tbxEmployeeLastNameAdd;
        private System.Windows.Forms.Label lblTıtle;
        private System.Windows.Forms.ComboBox cbxTıtle;
        private System.Windows.Forms.GroupBox gbxEmployeeAdd;
        private System.Windows.Forms.Button btnFireEmployee;
        private System.Windows.Forms.GroupBox gbxUpdateEmployee;
        private System.Windows.Forms.ComboBox cbxUpdateTitle;
        private System.Windows.Forms.TextBox tbxUpdateLastName;
        private System.Windows.Forms.TextBox tbxUpdateFirstName;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.Label lblUpdateLastName;
        private System.Windows.Forms.Label lblUpdateFirstName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxAddCountry;
        private System.Windows.Forms.Label lblAddPostalCode;
        private System.Windows.Forms.Label lblAddCountry;
        private System.Windows.Forms.TextBox tbxAddPostalCode;
        private System.Windows.Forms.TextBox tbxUpdatePostalCode;
        private System.Windows.Forms.TextBox tbxUpdateCountry;
        private System.Windows.Forms.Label lblUpdatePostalCode;
        private System.Windows.Forms.Label lblUpdateCountry;
        private System.Windows.Forms.Label lblAddCity;
        private System.Windows.Forms.TextBox tbxAddCity;
        private System.Windows.Forms.Label lblAddAdress;
        private System.Windows.Forms.TextBox tbxAddAdress;
        private System.Windows.Forms.TextBox tbxUpdateCity;
        private System.Windows.Forms.TextBox tbxUpdateAdress;
        private System.Windows.Forms.Label lblUpdateCity;
        private System.Windows.Forms.Label lblUpdateAdress;
    }
}

