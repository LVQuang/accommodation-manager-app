﻿namespace AccommodationManagerApp.Forms
{
    partial class ViewUserRoomInformation
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
            this.labelRoomStatus = new MaterialSkin.Controls.MaterialLabel();
            this.labelRoomTenant = new MaterialSkin.Controls.MaterialLabel();
            this.labelRoomBuilding = new MaterialSkin.Controls.MaterialLabel();
            this.labelRoomNumber = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ListViewUserRoom = new MaterialSkin.Controls.MaterialListView();
            this.colRoomId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRomBuilding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelRoomStatus);
            this.panel1.Controls.Add(this.labelRoomTenant);
            this.panel1.Controls.Add(this.labelRoomBuilding);
            this.panel1.Controls.Add(this.labelRoomNumber);
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.ListViewUserRoom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 333);
            this.panel1.TabIndex = 0;
            // 
            // labelRoomStatus
            // 
            this.labelRoomStatus.AutoSize = true;
            this.labelRoomStatus.Depth = 0;
            this.labelRoomStatus.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelRoomStatus.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelRoomStatus.Location = new System.Drawing.Point(611, 122);
            this.labelRoomStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRoomStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRoomStatus.Name = "labelRoomStatus";
            this.labelRoomStatus.Size = new System.Drawing.Size(181, 24);
            this.labelRoomStatus.TabIndex = 51;
            this.labelRoomStatus.Text = "____________________";
            // 
            // labelRoomTenant
            // 
            this.labelRoomTenant.AutoSize = true;
            this.labelRoomTenant.Depth = 0;
            this.labelRoomTenant.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelRoomTenant.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelRoomTenant.Location = new System.Drawing.Point(611, 86);
            this.labelRoomTenant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRoomTenant.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRoomTenant.Name = "labelRoomTenant";
            this.labelRoomTenant.Size = new System.Drawing.Size(181, 24);
            this.labelRoomTenant.TabIndex = 50;
            this.labelRoomTenant.Text = "____________________";
            // 
            // labelRoomBuilding
            // 
            this.labelRoomBuilding.AutoSize = true;
            this.labelRoomBuilding.Depth = 0;
            this.labelRoomBuilding.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelRoomBuilding.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelRoomBuilding.Location = new System.Drawing.Point(611, 49);
            this.labelRoomBuilding.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRoomBuilding.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRoomBuilding.Name = "labelRoomBuilding";
            this.labelRoomBuilding.Size = new System.Drawing.Size(181, 24);
            this.labelRoomBuilding.TabIndex = 49;
            this.labelRoomBuilding.Text = "____________________";
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Depth = 0;
            this.labelRoomNumber.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelRoomNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelRoomNumber.Location = new System.Drawing.Point(611, 16);
            this.labelRoomNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRoomNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(181, 24);
            this.labelRoomNumber.TabIndex = 48;
            this.labelRoomNumber.Text = "____________________";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(475, 86);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(105, 24);
            this.materialLabel8.TabIndex = 47;
            this.materialLabel8.Text = "Người thuê:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(475, 122);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(97, 24);
            this.materialLabel7.TabIndex = 46;
            this.materialLabel7.Text = "Trạng thái:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(476, 49);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(78, 24);
            this.materialLabel5.TabIndex = 45;
            this.materialLabel5.Text = "Toà nhà:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(476, 16);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 24);
            this.materialLabel1.TabIndex = 44;
            this.materialLabel1.Text = "Số nhà:";
            // 
            // ListViewUserRoom
            // 
            this.ListViewUserRoom.AutoArrange = false;
            this.ListViewUserRoom.AutoSizeTable = false;
            this.ListViewUserRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListViewUserRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewUserRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRoomId,
            this.colRomBuilding,
            this.colRoomStatus,
            this.colRoomNumber});
            this.ListViewUserRoom.Depth = 0;
            this.ListViewUserRoom.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListViewUserRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ListViewUserRoom.FullRowSelect = true;
            this.ListViewUserRoom.HideSelection = false;
            this.ListViewUserRoom.Location = new System.Drawing.Point(0, 0);
            this.ListViewUserRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListViewUserRoom.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListViewUserRoom.MouseState = MaterialSkin.MouseState.OUT;
            this.ListViewUserRoom.Name = "ListViewUserRoom";
            this.ListViewUserRoom.OwnerDraw = true;
            this.ListViewUserRoom.Size = new System.Drawing.Size(460, 333);
            this.ListViewUserRoom.TabIndex = 43;
            this.ListViewUserRoom.UseCompatibleStateImageBehavior = false;
            this.ListViewUserRoom.View = System.Windows.Forms.View.Details;
            this.ListViewUserRoom.SelectedIndexChanged += new System.EventHandler(this.ListViewUserRoom_SelectedIndexChanged);
            // 
            // colRoomId
            // 
            this.colRoomId.Text = "ID phòng";
            this.colRoomId.Width = 100;
            // 
            // colRomBuilding
            // 
            this.colRomBuilding.Text = "Toà nhà";
            this.colRomBuilding.Width = 112;
            // 
            // colRoomStatus
            // 
            this.colRoomStatus.Text = "Trạng thái";
            this.colRoomStatus.Width = 116;
            // 
            // colRoomNumber
            // 
            this.colRoomNumber.Text = "Số phòng";
            this.colRoomNumber.Width = 120;
            // 
            // ViewUserRoomInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 400);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(822, 400);
            this.MinimumSize = new System.Drawing.Size(822, 400);
            this.Name = "ViewUserRoomInformation";
            this.Sizable = false;
            this.Text = "Thông tin phòng cá nhân";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialListView ListViewUserRoom;
        private System.Windows.Forms.ColumnHeader colRoomId;
        private System.Windows.Forms.ColumnHeader colRomBuilding;
        private System.Windows.Forms.ColumnHeader colRoomStatus;
        private System.Windows.Forms.ColumnHeader colRoomNumber;
        private MaterialSkin.Controls.MaterialLabel labelRoomStatus;
        private MaterialSkin.Controls.MaterialLabel labelRoomTenant;
        private MaterialSkin.Controls.MaterialLabel labelRoomBuilding;
        private MaterialSkin.Controls.MaterialLabel labelRoomNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}