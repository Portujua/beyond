namespace Jodie
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
      if (disposing && (components != null)) {
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
      this.btnConnect = new System.Windows.Forms.Button();
      this.aidenAddress = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.processList = new System.Windows.Forms.ListView();
      this.btnRefreshProcessList = new System.Windows.Forms.Button();
      this.btnScreenshot = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnConnect
      // 
      this.btnConnect.Location = new System.Drawing.Point(246, 7);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(90, 23);
      this.btnConnect.TabIndex = 0;
      this.btnConnect.Text = "Connect";
      this.btnConnect.UseVisualStyleBackColor = true;
      this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
      // 
      // aidenAddress
      // 
      this.aidenAddress.Location = new System.Drawing.Point(78, 9);
      this.aidenAddress.Name = "aidenAddress";
      this.aidenAddress.Size = new System.Drawing.Size(162, 20);
      this.aidenAddress.TabIndex = 1;
      this.aidenAddress.Text = "127.0.0.1";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Connect to";
      // 
      // processList
      // 
      this.processList.CheckBoxes = true;
      this.processList.FullRowSelect = true;
      this.processList.GridLines = true;
      this.processList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.processList.Location = new System.Drawing.Point(12, 35);
      this.processList.Name = "processList";
      this.processList.Size = new System.Drawing.Size(506, 203);
      this.processList.TabIndex = 3;
      this.processList.UseCompatibleStateImageBehavior = false;
      this.processList.View = System.Windows.Forms.View.List;
      // 
      // btnRefreshProcessList
      // 
      this.btnRefreshProcessList.Enabled = false;
      this.btnRefreshProcessList.Location = new System.Drawing.Point(12, 244);
      this.btnRefreshProcessList.Name = "btnRefreshProcessList";
      this.btnRefreshProcessList.Size = new System.Drawing.Size(124, 23);
      this.btnRefreshProcessList.TabIndex = 4;
      this.btnRefreshProcessList.Text = "Refresh Process List";
      this.btnRefreshProcessList.UseVisualStyleBackColor = true;
      this.btnRefreshProcessList.Click += new System.EventHandler(this.btnRefreshProcessList_Click);
      // 
      // btnScreenshot
      // 
      this.btnScreenshot.Enabled = false;
      this.btnScreenshot.Location = new System.Drawing.Point(142, 244);
      this.btnScreenshot.Name = "btnScreenshot";
      this.btnScreenshot.Size = new System.Drawing.Size(79, 23);
      this.btnScreenshot.TabIndex = 5;
      this.btnScreenshot.Text = "Screenshot";
      this.btnScreenshot.UseVisualStyleBackColor = true;
      this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(530, 276);
      this.Controls.Add(this.btnScreenshot);
      this.Controls.Add(this.btnRefreshProcessList);
      this.Controls.Add(this.processList);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.aidenAddress);
      this.Controls.Add(this.btnConnect);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Jodie";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.TextBox aidenAddress;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListView processList;
    private System.Windows.Forms.Button btnRefreshProcessList;
    private System.Windows.Forms.Button btnScreenshot;
  }
}

