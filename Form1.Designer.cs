
namespace I_hate_probability
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
            this.mainTab = new System.Windows.Forms.TabControl();
            this.twoWayVenn = new System.Windows.Forms.TabPage();
            this.threeWayVenn = new System.Windows.Forms.TabPage();
            this.mainTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.twoWayVenn);
            this.mainTab.Controls.Add(this.threeWayVenn);
            this.mainTab.Location = new System.Drawing.Point(13, 13);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(1131, 739);
            this.mainTab.TabIndex = 0;
            // 
            // twoWayVenn
            // 
            this.twoWayVenn.Location = new System.Drawing.Point(4, 22);
            this.twoWayVenn.Name = "twoWayVenn";
            this.twoWayVenn.Padding = new System.Windows.Forms.Padding(3);
            this.twoWayVenn.Size = new System.Drawing.Size(1123, 713);
            this.twoWayVenn.TabIndex = 0;
            this.twoWayVenn.Text = "Two-Way Venn Diagram ";
            this.twoWayVenn.UseVisualStyleBackColor = true;
            // 
            // threeWayVenn
            // 
            this.threeWayVenn.Location = new System.Drawing.Point(4, 22);
            this.threeWayVenn.Name = "threeWayVenn";
            this.threeWayVenn.Padding = new System.Windows.Forms.Padding(3);
            this.threeWayVenn.Size = new System.Drawing.Size(1123, 713);
            this.threeWayVenn.TabIndex = 1;
            this.threeWayVenn.Text = "Three-Way Venn Diagram";
            this.threeWayVenn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 764);
            this.Controls.Add(this.mainTab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage twoWayVenn;
        private System.Windows.Forms.TabPage threeWayVenn;
    }
}

