using System.Windows.Forms;
namespace AutoUpdaterUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pathToAutoUpdaterLabel = new System.Windows.Forms.Label();
            this.clientIDLabel = new System.Windows.Forms.Label();
            this.clientkeyLabel = new System.Windows.Forms.Label();
            this.projectIDLabel = new System.Windows.Forms.Label();
            this.pathToDownloadLabel = new System.Windows.Forms.Label();
            this.filesToIgnoreLabel = new System.Windows.Forms.Label();
            this.pathToBackupsLavel = new System.Windows.Forms.Label();
            this.apiAdressLabel = new System.Windows.Forms.Label();
            this.fileAfterUpdateLabel = new System.Windows.Forms.Label();
            this.pathToAutoUpdaterTextBox = new System.Windows.Forms.TextBox();
            this.clientIDTextBox = new System.Windows.Forms.TextBox();
            this.clientKeyTextBox = new System.Windows.Forms.TextBox();
            this.projectIDTextBox = new System.Windows.Forms.TextBox();
            this.pathToDownloadTextBox = new System.Windows.Forms.TextBox();
            this.filesToIgnoreTextBox = new System.Windows.Forms.TextBox();
            this.pathToBackupsTextBox = new System.Windows.Forms.TextBox();
            this.apiAdressTextBox = new System.Windows.Forms.TextBox();
            this.fileAfterUpdateTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pathToAutoUpdaterLabel
            // 
            this.pathToAutoUpdaterLabel.AutoSize = true;
            this.pathToAutoUpdaterLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathToAutoUpdaterLabel.Location = new System.Drawing.Point(36, 39);
            this.pathToAutoUpdaterLabel.Name = "pathToAutoUpdaterLabel";
            this.pathToAutoUpdaterLabel.Size = new System.Drawing.Size(489, 27);
            this.pathToAutoUpdaterLabel.TabIndex = 0;
            this.pathToAutoUpdaterLabel.Text = "Путь к исполняемому файлу автообновлятора:";
            // 
            // clientIDLabel
            // 
            this.clientIDLabel.AutoSize = true;
            this.clientIDLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientIDLabel.Location = new System.Drawing.Point(36, 84);
            this.clientIDLabel.Name = "clientIDLabel";
            this.clientIDLabel.Size = new System.Drawing.Size(267, 27);
            this.clientIDLabel.TabIndex = 2;
            this.clientIDLabel.Text = "Идентификатор клиента:";
            // 
            // clientkeyLabel
            // 
            this.clientkeyLabel.AutoSize = true;
            this.clientkeyLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientkeyLabel.Location = new System.Drawing.Point(36, 129);
            this.clientkeyLabel.Name = "clientkeyLabel";
            this.clientkeyLabel.Size = new System.Drawing.Size(163, 27);
            this.clientkeyLabel.TabIndex = 4;
            this.clientkeyLabel.Text = "Ключ клиента:";
            // 
            // projectIDLabel
            // 
            this.projectIDLabel.AutoSize = true;
            this.projectIDLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projectIDLabel.Location = new System.Drawing.Point(36, 175);
            this.projectIDLabel.Name = "projectIDLabel";
            this.projectIDLabel.Size = new System.Drawing.Size(266, 27);
            this.projectIDLabel.TabIndex = 5;
            this.projectIDLabel.Text = "Идентификатор проекта:";
            // 
            // pathToDownloadLabel
            // 
            this.pathToDownloadLabel.AutoSize = true;
            this.pathToDownloadLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathToDownloadLabel.Location = new System.Drawing.Point(36, 216);
            this.pathToDownloadLabel.Name = "pathToDownloadLabel";
            this.pathToDownloadLabel.Size = new System.Drawing.Size(523, 27);
            this.pathToDownloadLabel.TabIndex = 6;
            this.pathToDownloadLabel.Text = "Путь к целевой папке, куда будут скачаны файлы:";
            // 
            // filesToIgnoreLabel
            // 
            this.filesToIgnoreLabel.AutoSize = true;
            this.filesToIgnoreLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filesToIgnoreLabel.Location = new System.Drawing.Point(36, 263);
            this.filesToIgnoreLabel.Name = "filesToIgnoreLabel";
            this.filesToIgnoreLabel.Size = new System.Drawing.Size(235, 27);
            this.filesToIgnoreLabel.TabIndex = 7;
            this.filesToIgnoreLabel.Text = "Игнорировать файлы:";
            // 
            // pathToBackupsLavel
            // 
            this.pathToBackupsLavel.AutoSize = true;
            this.pathToBackupsLavel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathToBackupsLavel.Location = new System.Drawing.Point(36, 308);
            this.pathToBackupsLavel.Name = "pathToBackupsLavel";
            this.pathToBackupsLavel.Size = new System.Drawing.Size(238, 27);
            this.pathToBackupsLavel.TabIndex = 8;
            this.pathToBackupsLavel.Text = "Путь к папке бэкапов:";
            // 
            // apiAdressLabel
            // 
            this.apiAdressLabel.AutoSize = true;
            this.apiAdressLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apiAdressLabel.Location = new System.Drawing.Point(36, 347);
            this.apiAdressLabel.Name = "apiAdressLabel";
            this.apiAdressLabel.Size = new System.Drawing.Size(286, 27);
            this.apiAdressLabel.TabIndex = 9;
            this.apiAdressLabel.Text = "Адрес api автообновления:";
            // 
            // fileAfterUpdateLabel
            // 
            this.fileAfterUpdateLabel.AutoSize = true;
            this.fileAfterUpdateLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileAfterUpdateLabel.Location = new System.Drawing.Point(33, 383);
            this.fileAfterUpdateLabel.Name = "fileAfterUpdateLabel";
            this.fileAfterUpdateLabel.Size = new System.Drawing.Size(744, 27);
            this.fileAfterUpdateLabel.TabIndex = 10;
            this.fileAfterUpdateLabel.Text = "Путь к исполняемому файлу для запуска после окончания обновления:";
            // 
            // pathToAutoUpdaterTextBox
            // 
            this.pathToAutoUpdaterTextBox.Location = new System.Drawing.Point(799, 39);
            this.pathToAutoUpdaterTextBox.Name = "pathToAutoUpdaterTextBox";
            this.pathToAutoUpdaterTextBox.Size = new System.Drawing.Size(250, 27);
            this.pathToAutoUpdaterTextBox.TabIndex = 11;
            // 
            // clientIDTextBox
            // 
            this.clientIDTextBox.Location = new System.Drawing.Point(799, 84);
            this.clientIDTextBox.Name = "clientIDTextBox";
            this.clientIDTextBox.Size = new System.Drawing.Size(250, 27);
            this.clientIDTextBox.TabIndex = 3;
            // 
            // clientKeyTextBox
            // 
            this.clientKeyTextBox.Location = new System.Drawing.Point(799, 129);
            this.clientKeyTextBox.Name = "clientKeyTextBox";
            this.clientKeyTextBox.Size = new System.Drawing.Size(250, 27);
            this.clientKeyTextBox.TabIndex = 12;
            // 
            // projectIDTextBox
            // 
            this.projectIDTextBox.Location = new System.Drawing.Point(799, 175);
            this.projectIDTextBox.Name = "projectIDTextBox";
            this.projectIDTextBox.Size = new System.Drawing.Size(250, 27);
            this.projectIDTextBox.TabIndex = 13;
            // 
            // pathToDownloadTextBox
            // 
            this.pathToDownloadTextBox.Location = new System.Drawing.Point(799, 216);
            this.pathToDownloadTextBox.Name = "pathToDownloadTextBox";
            this.pathToDownloadTextBox.Size = new System.Drawing.Size(250, 27);
            this.pathToDownloadTextBox.TabIndex = 14;
            // 
            // filesToIgnoreTextBox
            // 
            this.filesToIgnoreTextBox.Location = new System.Drawing.Point(799, 263);
            this.filesToIgnoreTextBox.Name = "filesToIgnoreTextBox";
            this.filesToIgnoreTextBox.Size = new System.Drawing.Size(250, 27);
            this.filesToIgnoreTextBox.TabIndex = 15;
            // 
            // pathToBackupsTextBox
            // 
            this.pathToBackupsTextBox.Location = new System.Drawing.Point(799, 308);
            this.pathToBackupsTextBox.Name = "pathToBackupsTextBox";
            this.pathToBackupsTextBox.Size = new System.Drawing.Size(250, 27);
            this.pathToBackupsTextBox.TabIndex = 16;
            // 
            // apiAdressTextBox
            // 
            this.apiAdressTextBox.Location = new System.Drawing.Point(799, 347);
            this.apiAdressTextBox.Name = "apiAdressTextBox";
            this.apiAdressTextBox.Size = new System.Drawing.Size(250, 27);
            this.apiAdressTextBox.TabIndex = 17;
            // 
            // fileAfterUpdateTextBox
            // 
            this.fileAfterUpdateTextBox.Location = new System.Drawing.Point(799, 383);
            this.fileAfterUpdateTextBox.Name = "fileAfterUpdateTextBox";
            this.fileAfterUpdateTextBox.Size = new System.Drawing.Size(250, 27);
            this.fileAfterUpdateTextBox.TabIndex = 18;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.Location = new System.Drawing.Point(400, 450);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(300, 50);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1082, 503);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.fileAfterUpdateTextBox);
            this.Controls.Add(this.apiAdressTextBox);
            this.Controls.Add(this.pathToBackupsTextBox);
            this.Controls.Add(this.filesToIgnoreTextBox);
            this.Controls.Add(this.pathToDownloadTextBox);
            this.Controls.Add(this.projectIDTextBox);
            this.Controls.Add(this.clientKeyTextBox);
            this.Controls.Add(this.pathToAutoUpdaterTextBox);
            this.Controls.Add(this.fileAfterUpdateLabel);
            this.Controls.Add(this.apiAdressLabel);
            this.Controls.Add(this.pathToBackupsLavel);
            this.Controls.Add(this.filesToIgnoreLabel);
            this.Controls.Add(this.pathToDownloadLabel);
            this.Controls.Add(this.projectIDLabel);
            this.Controls.Add(this.clientkeyLabel);
            this.Controls.Add(this.clientIDTextBox);
            this.Controls.Add(this.clientIDLabel);
            this.Controls.Add(this.pathToAutoUpdaterLabel);
            this.Name = "Form1";
            this.Text = "AutoUpdater";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label pathToAutoUpdaterLabel;
        private Label clientIDLabel;
        private TextBox clientIDTextBox;
        private Label clientkeyLabel;
        private Label projectIDLabel;
        private Label pathToDownloadLabel;
        private Label filesToIgnoreLabel;
        private Label pathToBackupsLavel;
        private Label apiAdressLabel;
        private Label fileAfterUpdateLabel;
        private TextBox pathToAutoUpdaterTextBox;
        private TextBox clientKeyTextBox;
        private TextBox projectIDTextBox;
        private TextBox pathToDownloadTextBox;
        private TextBox filesToIgnoreTextBox;
        private TextBox pathToBackupsTextBox;
        private TextBox apiAdressTextBox;
        private TextBox fileAfterUpdateTextBox;
        private Button SaveButton;
    }
}