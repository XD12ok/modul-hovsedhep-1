namespace mdul_HOVSEDEP_18_9_2025
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
            this.TableSeatingBtn = new System.Windows.Forms.Button();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.HistoryBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TableSeatingBtn
            // 
            this.TableSeatingBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TableSeatingBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TableSeatingBtn.Location = new System.Drawing.Point(12, 23);
            this.TableSeatingBtn.Name = "TableSeatingBtn";
            this.TableSeatingBtn.Size = new System.Drawing.Size(75, 68);
            this.TableSeatingBtn.TabIndex = 0;
            this.TableSeatingBtn.Text = "Table Seating";
            this.TableSeatingBtn.UseVisualStyleBackColor = false;
            this.TableSeatingBtn.Click += new System.EventHandler(this.TableSeatingBtn_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MenuBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MenuBtn.Location = new System.Drawing.Point(12, 169);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(75, 68);
            this.MenuBtn.TabIndex = 0;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // HistoryBtn
            // 
            this.HistoryBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.HistoryBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HistoryBtn.Location = new System.Drawing.Point(12, 329);
            this.HistoryBtn.Name = "HistoryBtn";
            this.HistoryBtn.Size = new System.Drawing.Size(75, 68);
            this.HistoryBtn.TabIndex = 0;
            this.HistoryBtn.Text = "History";
            this.HistoryBtn.UseVisualStyleBackColor = false;
            this.HistoryBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(130, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(971, 396);
            this.mainPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.HistoryBtn);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.TableSeatingBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TableSeatingBtn;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Button HistoryBtn;
        private System.Windows.Forms.Panel mainPanel;
    }
}

