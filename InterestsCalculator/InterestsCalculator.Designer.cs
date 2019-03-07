namespace InterestsCalculator
{
  partial class MainForm
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
      this.MainPanel = new System.Windows.Forms.Panel();
      this.accountBalanceNumeric = new System.Windows.Forms.NumericUpDown();
      this.interestsLabel = new System.Windows.Forms.Label();
      this.interestsTextBox = new System.Windows.Forms.TextBox();
      this.accountBalanceLabel = new System.Windows.Forms.Label();
      this.TitleLabel = new System.Windows.Forms.Label();
      this.MainPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.accountBalanceNumeric)).BeginInit();
      this.SuspendLayout();
      // 
      // MainPanel
      // 
      this.MainPanel.Controls.Add(this.accountBalanceNumeric);
      this.MainPanel.Controls.Add(this.interestsLabel);
      this.MainPanel.Controls.Add(this.interestsTextBox);
      this.MainPanel.Controls.Add(this.accountBalanceLabel);
      this.MainPanel.Controls.Add(this.TitleLabel);
      this.MainPanel.Location = new System.Drawing.Point(12, 12);
      this.MainPanel.Name = "MainPanel";
      this.MainPanel.Size = new System.Drawing.Size(260, 237);
      this.MainPanel.TabIndex = 0;
      // 
      // accountBalanceNumeric
      // 
      this.accountBalanceNumeric.DecimalPlaces = 2;
      this.accountBalanceNumeric.Location = new System.Drawing.Point(137, 101);
      this.accountBalanceNumeric.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
      this.accountBalanceNumeric.Name = "accountBalanceNumeric";
      this.accountBalanceNumeric.Size = new System.Drawing.Size(120, 20);
      this.accountBalanceNumeric.TabIndex = 1;
      this.accountBalanceNumeric.Tag = "";
      this.accountBalanceNumeric.ValueChanged += new System.EventHandler(this.accountBalanceNumeric_ValueChanged);
      // 
      // interestsLabel
      // 
      this.interestsLabel.AutoSize = true;
      this.interestsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.interestsLabel.Location = new System.Drawing.Point(3, 142);
      this.interestsLabel.Name = "interestsLabel";
      this.interestsLabel.Size = new System.Drawing.Size(64, 16);
      this.interestsLabel.TabIndex = 0;
      this.interestsLabel.Text = "Interests: ";
      // 
      // interestsTextBox
      // 
      this.interestsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.interestsTextBox.Location = new System.Drawing.Point(137, 139);
      this.interestsTextBox.Name = "interestsTextBox";
      this.interestsTextBox.ReadOnly = true;
      this.interestsTextBox.Size = new System.Drawing.Size(120, 22);
      this.interestsTextBox.TabIndex = 3;
      // 
      // accountBalanceLabel
      // 
      this.accountBalanceLabel.AutoSize = true;
      this.accountBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.accountBalanceLabel.Location = new System.Drawing.Point(3, 101);
      this.accountBalanceLabel.Name = "accountBalanceLabel";
      this.accountBalanceLabel.Size = new System.Drawing.Size(133, 16);
      this.accountBalanceLabel.TabIndex = 0;
      this.accountBalanceLabel.Text = "Account Balance (£): ";
      // 
      // TitleLabel
      // 
      this.TitleLabel.AutoSize = true;
      this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TitleLabel.Location = new System.Drawing.Point(62, 9);
      this.TitleLabel.Name = "TitleLabel";
      this.TitleLabel.Size = new System.Drawing.Size(147, 20);
      this.TitleLabel.TabIndex = 0;
      this.TitleLabel.Text = "Interests Calculator";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.MainPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "MainForm";
      this.Text = "Interests Calculator";
      this.MainPanel.ResumeLayout(false);
      this.MainPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.accountBalanceNumeric)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel MainPanel;
    private System.Windows.Forms.Label interestsLabel;
    private System.Windows.Forms.TextBox interestsTextBox;
    private System.Windows.Forms.Label accountBalanceLabel;
    private System.Windows.Forms.Label TitleLabel;
    private System.Windows.Forms.NumericUpDown accountBalanceNumeric;
  }
}

