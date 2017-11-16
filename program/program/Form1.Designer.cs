using System;

namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        string[] item =
        {
            "httpbuffersize\n",
            "unpacktmpfile",
            "loadaltevent",
            "createnewsocket",
            "destroybatch",
            "removenewcookie",
            "removeoldcookie",
            "encodenewfolder",
            "loadregisterlist",
            "create3axisvector",
            "create2axisvector",
            "wordcounter",
            "mergesocket",
            "bufferpingset",
            "patcheventlog",
            "checkhttptype",
            "tempdatapass",
            "getdatapassword",
            "sendintelpass",
            "getmysqldomain",
            "changeusername",
            "callmodule",
            "batchallfiles",
            "decryptdatabatch",
            "dodecahedron",
            "disconnectserver",
            "uploaduserstats",
            "sizeofhexagon",
            "getxmlprotocol",
            "deleteallids",
            "createnewpackage",
            "eventlistdir",
            "exportconfigpackage",
            "createfilethread",
            "disconnectchannel",
            "setnewproxy",
            "statusofprocess",
            "includedirectory",
            "generatecodepack",
            "systemgridtype",
            "blockthreat",
            "changepassword",
            "ghostfilesystem",
            "joinnetworkclient",
            "channelsetpackage",
            "getpartoffile",
            "emitconfiglist",
            "systemportkey",
            "fileexpresslog",
            "getfirewallchannel",
            "encryptunpackedbatch",
            "rootcookieset",
            "hostnewserver",
            "respondertimeout",
            "loadloggedpassword"
        };
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 264);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "20000";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 298);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 21);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "50000";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 414);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(230, 21);
            this.textBox3.TabIndex = 15;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keydown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(14, 326);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 17;
            this.button13.Text = "test";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 488);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

            
        }

        #endregion
        
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button13;
    }
}

