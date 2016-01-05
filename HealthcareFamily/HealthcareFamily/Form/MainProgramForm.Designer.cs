﻿namespace HealthcareFamilyGUI
{
    partial class MainProgramForm
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
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.lvwUserList = new System.Windows.Forms.ListView();
            this.cmdRefesh = new System.Windows.Forms.Button();
            this.cmdProfile = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdMeeting = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdEmergency = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdAddUser = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdNotification = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cmdRequestNewUser = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.txtName = new MetroFramework.Controls.MetroLabel();
            this.txtAge = new MetroFramework.Controls.MetroLabel();
            this.txtStatus = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // pnlAvatar
            // 
            this.pnlAvatar.Location = new System.Drawing.Point(42, 76);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Size = new System.Drawing.Size(85, 85);
            this.pnlAvatar.TabIndex = 0;
            // 
            // lvwUserList
            // 
            this.lvwUserList.Location = new System.Drawing.Point(23, 274);
            this.lvwUserList.Name = "lvwUserList";
            this.lvwUserList.Size = new System.Drawing.Size(418, 381);
            this.lvwUserList.TabIndex = 5;
            this.lvwUserList.UseCompatibleStateImageBehavior = false;
            this.lvwUserList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvwUserList_ItemCheck);
            this.lvwUserList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvwUserList_ItemChecked);
            this.lvwUserList.DoubleClick += new System.EventHandler(this.lvwUserList_DoubleClick);
            this.lvwUserList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwUserList_MouseDoubleClick);
            // 
            // cmdRefesh
            // 
            this.cmdRefesh.Location = new System.Drawing.Point(42, 185);
            this.cmdRefesh.Name = "cmdRefesh";
            this.cmdRefesh.Size = new System.Drawing.Size(25, 23);
            this.cmdRefesh.TabIndex = 7;
            this.cmdRefesh.Text = "Refesh";
            this.cmdRefesh.UseVisualStyleBackColor = true;
            this.cmdRefesh.Click += new System.EventHandler(this.cmdRefesh_Click);
            // 
            // cmdProfile
            // 
            this.cmdProfile.Image = null;
            this.cmdProfile.Location = new System.Drawing.Point(283, 63);
            this.cmdProfile.Name = "cmdProfile";
            this.cmdProfile.Size = new System.Drawing.Size(158, 32);
            this.cmdProfile.TabIndex = 11;
            this.cmdProfile.Text = "Profile";
            this.cmdProfile.UseSelectable = true;
            this.cmdProfile.UseVisualStyleBackColor = true;
            this.cmdProfile.Click += new System.EventHandler(this.cmdProfile_Click);
            // 
            // cmdMeeting
            // 
            this.cmdMeeting.Image = null;
            this.cmdMeeting.Location = new System.Drawing.Point(24, 232);
            this.cmdMeeting.Name = "cmdMeeting";
            this.cmdMeeting.Size = new System.Drawing.Size(195, 32);
            this.cmdMeeting.TabIndex = 12;
            this.cmdMeeting.Text = "Meeting";
            this.cmdMeeting.UseSelectable = true;
            this.cmdMeeting.UseVisualStyleBackColor = true;
            // 
            // cmdEmergency
            // 
            this.cmdEmergency.Image = null;
            this.cmdEmergency.Location = new System.Drawing.Point(225, 232);
            this.cmdEmergency.Name = "cmdEmergency";
            this.cmdEmergency.Size = new System.Drawing.Size(216, 32);
            this.cmdEmergency.TabIndex = 13;
            this.cmdEmergency.Text = "Emergency";
            this.cmdEmergency.UseSelectable = true;
            this.cmdEmergency.UseVisualStyleBackColor = true;
            // 
            // cmdAddUser
            // 
            this.cmdAddUser.Image = null;
            this.cmdAddUser.Location = new System.Drawing.Point(283, 176);
            this.cmdAddUser.Name = "cmdAddUser";
            this.cmdAddUser.Size = new System.Drawing.Size(158, 32);
            this.cmdAddUser.TabIndex = 14;
            this.cmdAddUser.Text = "Add New User";
            this.cmdAddUser.UseSelectable = true;
            this.cmdAddUser.UseVisualStyleBackColor = true;
            this.cmdAddUser.Click += new System.EventHandler(this.cmdAddUser_Click);
            // 
            // cmdNotification
            // 
            this.cmdNotification.Image = null;
            this.cmdNotification.Location = new System.Drawing.Point(283, 101);
            this.cmdNotification.Name = "cmdNotification";
            this.cmdNotification.Size = new System.Drawing.Size(158, 32);
            this.cmdNotification.TabIndex = 15;
            this.cmdNotification.Text = "Notification";
            this.cmdNotification.UseSelectable = true;
            this.cmdNotification.UseVisualStyleBackColor = true;
            // 
            // cmdRequestNewUser
            // 
            this.cmdRequestNewUser.Image = null;
            this.cmdRequestNewUser.Location = new System.Drawing.Point(283, 139);
            this.cmdRequestNewUser.Name = "cmdRequestNewUser";
            this.cmdRequestNewUser.Size = new System.Drawing.Size(158, 32);
            this.cmdRequestNewUser.TabIndex = 16;
            this.cmdRequestNewUser.Text = "Request New User";
            this.cmdRequestNewUser.UseSelectable = true;
            this.cmdRequestNewUser.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(141, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(81, 19);
            this.txtName.TabIndex = 17;
            this.txtName.Text = "metroLabel1";
            // 
            // txtAge
            // 
            this.txtAge.AutoSize = true;
            this.txtAge.Location = new System.Drawing.Point(141, 109);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(83, 19);
            this.txtAge.TabIndex = 18;
            this.txtAge.Text = "metroLabel2";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(141, 137);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(83, 19);
            this.txtStatus.TabIndex = 19;
            this.txtStatus.Text = "metroLabel3";
            // 
            // MainProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 729);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmdRequestNewUser);
            this.Controls.Add(this.cmdNotification);
            this.Controls.Add(this.cmdAddUser);
            this.Controls.Add(this.cmdEmergency);
            this.Controls.Add(this.cmdMeeting);
            this.Controls.Add(this.cmdProfile);
            this.Controls.Add(this.cmdRefesh);
            this.Controls.Add(this.lvwUserList);
            this.Controls.Add(this.pnlAvatar);
            this.MaximizeBox = false;
            this.Name = "MainProgramForm";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainProgramForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.ListView lvwUserList;
        private System.Windows.Forms.Button cmdRefesh;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdProfile;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdMeeting;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdEmergency;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdAddUser;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdNotification;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cmdRequestNewUser;
        private MetroFramework.Controls.MetroLabel txtName;
        private MetroFramework.Controls.MetroLabel txtAge;
        private MetroFramework.Controls.MetroLabel txtStatus;
    }
}