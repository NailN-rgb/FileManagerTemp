namespace FIleManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backButton = new System.Windows.Forms.Button();
            this.fileWayTextBox = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.FName = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.FType = new System.Windows.Forms.Label();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mainTree = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // fileWayTextBox
            // 
            this.fileWayTextBox.Location = new System.Drawing.Point(174, 12);
            this.fileWayTextBox.Name = "fileWayTextBox";
            this.fileWayTextBox.Size = new System.Drawing.Size(865, 20);
            this.fileWayTextBox.TabIndex = 2;
            this.fileWayTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxKey_UP);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(93, 9);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Открыть...";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Location = new System.Drawing.Point(9, 501);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(67, 13);
            this.FName.TabIndex = 4;
            this.FName.Text = "Имя Файла";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(82, 501);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(13, 13);
            this.fileNameLabel.TabIndex = 5;
            this.fileNameLabel.Text = "--";
            this.fileNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // FType
            // 
            this.FType.AutoSize = true;
            this.FType.Location = new System.Drawing.Point(894, 501);
            this.FType.Name = "FType";
            this.FType.Size = new System.Drawing.Size(64, 13);
            this.FType.TabIndex = 6;
            this.FType.Text = "Тип Файла";
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Location = new System.Drawing.Point(964, 501);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(13, 13);
            this.fileTypeLabel.TabIndex = 7;
            this.fileTypeLabel.Text = "--";
            // 
            // icons
            // 
            this.icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.icons.ImageSize = new System.Drawing.Size(24, 24);
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 58);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mainTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(1027, 429);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.TabIndex = 8;
            // 
            // mainTree
            // 
            this.mainTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTree.Location = new System.Drawing.Point(0, 0);
            this.mainTree.Name = "mainTree";
            this.mainTree.Size = new System.Drawing.Size(342, 429);
            this.mainTree.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.icons;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(681, 429);
            this.listView1.SmallImageList = this.icons;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1013, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.FType);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.fileWayTextBox);
            this.Controls.Add(this.backButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox fileWayTextBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label FType;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView mainTree;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
    }
}

