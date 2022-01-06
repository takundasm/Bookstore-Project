namespace MNDTAK007_ProjectINF1003
{
    partial class orderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderForm));
            this.label1 = new System.Windows.Forms.Label();
            this.hoursTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.discountBox = new System.Windows.Forms.GroupBox();
            this.yesOption = new System.Windows.Forms.RadioButton();
            this.noOption = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.vatLbl = new System.Windows.Forms.Label();
            this.grossTxt = new System.Windows.Forms.TextBox();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vatTxt = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.clearBtn = new System.Windows.Forms.Button();
            this.enterBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.functionsGroupbox = new System.Windows.Forms.GroupBox();
            this.discountBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.functionsGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Form";
            // 
            // hoursTxt
            // 
            this.hoursTxt.Location = new System.Drawing.Point(196, 93);
            this.hoursTxt.Name = "hoursTxt";
            this.hoursTxt.Size = new System.Drawing.Size(100, 20);
            this.hoursTxt.TabIndex = 5;
            this.hoursTxt.TextChanged += new System.EventHandler(this.hoursTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hours required:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            // 
            // discountBox
            // 
            this.discountBox.Controls.Add(this.yesOption);
            this.discountBox.Controls.Add(this.noOption);
            this.discountBox.Location = new System.Drawing.Point(47, 161);
            this.discountBox.Name = "discountBox";
            this.discountBox.Size = new System.Drawing.Size(183, 75);
            this.discountBox.TabIndex = 8;
            this.discountBox.TabStop = false;
            this.discountBox.Text = "Do you have a discount Coupon?";
            // 
            // yesOption
            // 
            this.yesOption.AutoSize = true;
            this.yesOption.Location = new System.Drawing.Point(17, 19);
            this.yesOption.Name = "yesOption";
            this.yesOption.Size = new System.Drawing.Size(43, 17);
            this.yesOption.TabIndex = 1;
            this.yesOption.TabStop = true;
            this.yesOption.Text = "Yes";
            this.yesOption.UseVisualStyleBackColor = true;
            // 
            // noOption
            // 
            this.noOption.AutoSize = true;
            this.noOption.Location = new System.Drawing.Point(17, 42);
            this.noOption.Name = "noOption";
            this.noOption.Size = new System.Drawing.Size(39, 17);
            this.noOption.TabIndex = 0;
            this.noOption.TabStop = true;
            this.noOption.Text = "No";
            this.noOption.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "© The Net Cafe 2021";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(196, 54);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 20);
            this.nameTxt.TabIndex = 10;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(326, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 290);
            this.listBox1.TabIndex = 12;
            // 
            // vatLbl
            // 
            this.vatLbl.AutoSize = true;
            this.vatLbl.Location = new System.Drawing.Point(6, 51);
            this.vatLbl.Name = "vatLbl";
            this.vatLbl.Size = new System.Drawing.Size(57, 13);
            this.vatLbl.TabIndex = 13;
            this.vatLbl.Text = "VAT (14%)";
            // 
            // grossTxt
            // 
            this.grossTxt.Location = new System.Drawing.Point(106, 19);
            this.grossTxt.Name = "grossTxt";
            this.grossTxt.ReadOnly = true;
            this.grossTxt.Size = new System.Drawing.Size(100, 20);
            this.grossTxt.TabIndex = 14;
            // 
            // totalTxt
            // 
            this.totalTxt.Location = new System.Drawing.Point(106, 77);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.ReadOnly = true;
            this.totalTxt.Size = new System.Drawing.Size(100, 20);
            this.totalTxt.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total Owed:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.vatTxt);
            this.groupBox2.Controls.Add(this.grossTxt);
            this.groupBox2.Controls.Add(this.totalTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.vatLbl);
            this.groupBox2.Location = new System.Drawing.Point(47, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 103);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Gross Total";
            // 
            // vatTxt
            // 
            this.vatTxt.Location = new System.Drawing.Point(106, 51);
            this.vatTxt.Name = "vatTxt";
            this.vatTxt.ReadOnly = true;
            this.vatTxt.Size = new System.Drawing.Size(100, 20);
            this.vatTxt.TabIndex = 17;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem1});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fontToolStripMenuItem.Text = "Edit";
            // 
            // fontToolStripMenuItem1
            // 
            this.fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            this.fontToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.fontToolStripMenuItem1.Text = "&Font";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(228, 40);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "&Clear Form";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(131, 10);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(75, 23);
            this.enterBtn.TabIndex = 11;
            this.enterBtn.Text = "&Calculate Invoice";
            this.enterBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "&Print Invoice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "&Summarize";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // functionsGroupbox
            // 
            this.functionsGroupbox.Controls.Add(this.button2);
            this.functionsGroupbox.Controls.Add(this.button1);
            this.functionsGroupbox.Controls.Add(this.enterBtn);
            this.functionsGroupbox.Controls.Add(this.clearBtn);
            this.functionsGroupbox.Location = new System.Drawing.Point(98, 364);
            this.functionsGroupbox.Name = "functionsGroupbox";
            this.functionsGroupbox.Size = new System.Drawing.Size(313, 73);
            this.functionsGroupbox.TabIndex = 18;
            this.functionsGroupbox.TabStop = false;
            // 
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 483);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.functionsGroupbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.discountBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hoursTxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "orderForm";
            this.Text = "`";
            this.discountBox.ResumeLayout(false);
            this.discountBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.functionsGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hoursTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox discountBox;
        private System.Windows.Forms.RadioButton yesOption;
        private System.Windows.Forms.RadioButton noOption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label vatLbl;
        private System.Windows.Forms.TextBox grossTxt;
        private System.Windows.Forms.TextBox totalTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vatTxt;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox functionsGroupbox;
    }
}