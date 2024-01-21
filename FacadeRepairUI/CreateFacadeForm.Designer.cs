namespace FacadeRepairUI
{
    partial class CreateFacadeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFacadeForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.objectNameLabel = new System.Windows.Forms.Label();
            this.facadeNameValue = new System.Windows.Forms.TextBox();
            this.facadeAddressValue = new System.Windows.Forms.TextBox();
            this.objectAddressLabel = new System.Windows.Forms.Label();
            this.objectOwnerValue = new System.Windows.Forms.TextBox();
            this.objectOwnerLabel = new System.Windows.Forms.Label();
            this.typeOfDamageLabel = new System.Windows.Forms.Label();
            this.typeOfDamageDropDown = new System.Windows.Forms.ComboBox();
            this.polygonsLabel = new System.Windows.Forms.Label();
            this.polygonsListBox = new System.Windows.Forms.ListBox();
            this.addPolygonButton = new System.Windows.Forms.Button();
            this.deletePolygonButton = new System.Windows.Forms.Button();
            this.createFacadeButton = new System.Windows.Forms.Button();
            this.loadPolygonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(240, 50);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Facade";
            // 
            // objectNameLabel
            // 
            this.objectNameLabel.AutoSize = true;
            this.objectNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.objectNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.objectNameLabel.Location = new System.Drawing.Point(14, 79);
            this.objectNameLabel.Name = "objectNameLabel";
            this.objectNameLabel.Size = new System.Drawing.Size(173, 37);
            this.objectNameLabel.TabIndex = 2;
            this.objectNameLabel.Text = "Object Name";
            // 
            // facadeNameValue
            // 
            this.facadeNameValue.Location = new System.Drawing.Point(21, 119);
            this.facadeNameValue.Name = "facadeNameValue";
            this.facadeNameValue.Size = new System.Drawing.Size(404, 35);
            this.facadeNameValue.TabIndex = 3;
            // 
            // facadeAddressValue
            // 
            this.facadeAddressValue.Location = new System.Drawing.Point(19, 224);
            this.facadeAddressValue.Name = "facadeAddressValue";
            this.facadeAddressValue.Size = new System.Drawing.Size(404, 35);
            this.facadeAddressValue.TabIndex = 5;
            // 
            // objectAddressLabel
            // 
            this.objectAddressLabel.AutoSize = true;
            this.objectAddressLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.objectAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.objectAddressLabel.Location = new System.Drawing.Point(14, 184);
            this.objectAddressLabel.Name = "objectAddressLabel";
            this.objectAddressLabel.Size = new System.Drawing.Size(196, 37);
            this.objectAddressLabel.TabIndex = 4;
            this.objectAddressLabel.Text = "Object Address";
            // 
            // objectOwnerValue
            // 
            this.objectOwnerValue.Location = new System.Drawing.Point(19, 329);
            this.objectOwnerValue.Name = "objectOwnerValue";
            this.objectOwnerValue.Size = new System.Drawing.Size(404, 35);
            this.objectOwnerValue.TabIndex = 7;
            // 
            // objectOwnerLabel
            // 
            this.objectOwnerLabel.AutoSize = true;
            this.objectOwnerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.objectOwnerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.objectOwnerLabel.Location = new System.Drawing.Point(14, 289);
            this.objectOwnerLabel.Name = "objectOwnerLabel";
            this.objectOwnerLabel.Size = new System.Drawing.Size(180, 37);
            this.objectOwnerLabel.TabIndex = 6;
            this.objectOwnerLabel.Text = "Object Owner";
            // 
            // typeOfDamageLabel
            // 
            this.typeOfDamageLabel.AutoSize = true;
            this.typeOfDamageLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeOfDamageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.typeOfDamageLabel.Location = new System.Drawing.Point(12, 394);
            this.typeOfDamageLabel.Name = "typeOfDamageLabel";
            this.typeOfDamageLabel.Size = new System.Drawing.Size(215, 37);
            this.typeOfDamageLabel.TabIndex = 8;
            this.typeOfDamageLabel.Text = "Type Of Damage";
            // 
            // typeOfDamageDropDown
            // 
            this.typeOfDamageDropDown.FormattingEnabled = true;
            this.typeOfDamageDropDown.Location = new System.Drawing.Point(244, 395);
            this.typeOfDamageDropDown.Name = "typeOfDamageDropDown";
            this.typeOfDamageDropDown.Size = new System.Drawing.Size(181, 38);
            this.typeOfDamageDropDown.TabIndex = 9;
            // 
            // polygonsLabel
            // 
            this.polygonsLabel.AutoSize = true;
            this.polygonsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.polygonsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.polygonsLabel.Location = new System.Drawing.Point(469, 61);
            this.polygonsLabel.Name = "polygonsLabel";
            this.polygonsLabel.Size = new System.Drawing.Size(125, 37);
            this.polygonsLabel.TabIndex = 10;
            this.polygonsLabel.Text = "Polygons";
            // 
            // polygonsListBox
            // 
            this.polygonsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.polygonsListBox.FormattingEnabled = true;
            this.polygonsListBox.ItemHeight = 30;
            this.polygonsListBox.Location = new System.Drawing.Point(466, 101);
            this.polygonsListBox.Name = "polygonsListBox";
            this.polygonsListBox.Size = new System.Drawing.Size(343, 332);
            this.polygonsListBox.TabIndex = 11;
            // 
            // addPolygonButton
            // 
            this.addPolygonButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addPolygonButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addPolygonButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addPolygonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPolygonButton.Location = new System.Drawing.Point(815, 112);
            this.addPolygonButton.Name = "addPolygonButton";
            this.addPolygonButton.Size = new System.Drawing.Size(178, 42);
            this.addPolygonButton.TabIndex = 12;
            this.addPolygonButton.Text = "Add Polygon";
            this.addPolygonButton.UseVisualStyleBackColor = true;
            // 
            // deletePolygonButton
            // 
            this.deletePolygonButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deletePolygonButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deletePolygonButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deletePolygonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePolygonButton.Location = new System.Drawing.Point(815, 284);
            this.deletePolygonButton.Name = "deletePolygonButton";
            this.deletePolygonButton.Size = new System.Drawing.Size(178, 42);
            this.deletePolygonButton.TabIndex = 13;
            this.deletePolygonButton.Text = "Delete Polygon";
            this.deletePolygonButton.UseVisualStyleBackColor = true;
            // 
            // createFacadeButton
            // 
            this.createFacadeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createFacadeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createFacadeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createFacadeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createFacadeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createFacadeButton.Location = new System.Drawing.Point(391, 472);
            this.createFacadeButton.Name = "createFacadeButton";
            this.createFacadeButton.Size = new System.Drawing.Size(225, 59);
            this.createFacadeButton.TabIndex = 14;
            this.createFacadeButton.Text = "Create Facade";
            this.createFacadeButton.UseVisualStyleBackColor = true;
            // 
            // loadPolygonButton
            // 
            this.loadPolygonButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadPolygonButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadPolygonButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadPolygonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadPolygonButton.Location = new System.Drawing.Point(815, 198);
            this.loadPolygonButton.Name = "loadPolygonButton";
            this.loadPolygonButton.Size = new System.Drawing.Size(178, 42);
            this.loadPolygonButton.TabIndex = 15;
            this.loadPolygonButton.Text = "Load Polygon";
            this.loadPolygonButton.UseVisualStyleBackColor = true;
            // 
            // CreateFacadeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 544);
            this.Controls.Add(this.loadPolygonButton);
            this.Controls.Add(this.createFacadeButton);
            this.Controls.Add(this.deletePolygonButton);
            this.Controls.Add(this.addPolygonButton);
            this.Controls.Add(this.polygonsListBox);
            this.Controls.Add(this.polygonsLabel);
            this.Controls.Add(this.typeOfDamageDropDown);
            this.Controls.Add(this.typeOfDamageLabel);
            this.Controls.Add(this.objectOwnerValue);
            this.Controls.Add(this.objectOwnerLabel);
            this.Controls.Add(this.facadeAddressValue);
            this.Controls.Add(this.objectAddressLabel);
            this.Controls.Add(this.facadeNameValue);
            this.Controls.Add(this.objectNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateFacadeForm";
            this.Text = "Create Facade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label objectNameLabel;
        private System.Windows.Forms.TextBox facadeNameValue;
        private System.Windows.Forms.TextBox facadeAddressValue;
        private System.Windows.Forms.Label objectAddressLabel;
        private System.Windows.Forms.TextBox objectOwnerValue;
        private System.Windows.Forms.Label objectOwnerLabel;
        private System.Windows.Forms.Label typeOfDamageLabel;
        private System.Windows.Forms.ComboBox typeOfDamageDropDown;
        private System.Windows.Forms.Label polygonsLabel;
        private System.Windows.Forms.ListBox polygonsListBox;
        private System.Windows.Forms.Button addPolygonButton;
        private System.Windows.Forms.Button deletePolygonButton;
        private System.Windows.Forms.Button createFacadeButton;
        private System.Windows.Forms.Button loadPolygonButton;
    }
}