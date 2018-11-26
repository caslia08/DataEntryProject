namespace DataEntryProject
{
    partial class FrmDataEntry
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
            this.components = new System.ComponentModel.Container();
            this.GrbDataEntry = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtzip = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbtimer = new System.Windows.Forms.GroupBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timTimer = new System.Windows.Forms.Timer(this.components);
            this.GrbDataEntry.SuspendLayout();
            this.grbtimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbDataEntry
            // 
            this.GrbDataEntry.Controls.Add(this.btnClear);
            this.GrbDataEntry.Controls.Add(this.btnAccept);
            this.GrbDataEntry.Controls.Add(this.txtzip);
            this.GrbDataEntry.Controls.Add(this.txtProvince);
            this.GrbDataEntry.Controls.Add(this.txtCity);
            this.GrbDataEntry.Controls.Add(this.txtaddress);
            this.GrbDataEntry.Controls.Add(this.txtName);
            this.GrbDataEntry.Controls.Add(this.label5);
            this.GrbDataEntry.Controls.Add(this.label4);
            this.GrbDataEntry.Controls.Add(this.label3);
            this.GrbDataEntry.Controls.Add(this.label2);
            this.GrbDataEntry.Controls.Add(this.label1);
            this.GrbDataEntry.Location = new System.Drawing.Point(12, 12);
            this.GrbDataEntry.Name = "GrbDataEntry";
            this.GrbDataEntry.Size = new System.Drawing.Size(282, 342);
            this.GrbDataEntry.TabIndex = 0;
            this.GrbDataEntry.TabStop = false;
            this.GrbDataEntry.Text = "Data Entry";
            this.GrbDataEntry.Enter += new System.EventHandler(this.GrbDataEntry_Enter);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(176, 252);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnButtons_Leave);
            this.btnClear.MouseHover += new System.EventHandler(this.btnButton_Hover);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(20, 252);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            this.btnAccept.MouseLeave += new System.EventHandler(this.btnButtons_Leave);
            this.btnAccept.MouseHover += new System.EventHandler(this.btnButton_Hover);
            // 
            // txtzip
            // 
            this.txtzip.Location = new System.Drawing.Point(120, 210);
            this.txtzip.Name = "txtzip";
            this.txtzip.Size = new System.Drawing.Size(131, 20);
            this.txtzip.TabIndex = 9;
            this.txtzip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinput_keypress);
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(120, 168);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(131, 20);
            this.txtProvince.TabIndex = 8;
            this.txtProvince.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinput_keypress);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(120, 123);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(131, 20);
            this.txtCity.TabIndex = 7;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinput_keypress);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(120, 82);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(131, 20);
            this.txtaddress.TabIndex = 6;
            this.txtaddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinput_keypress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(131, 20);
            this.txtName.TabIndex = 5;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinput_keypress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Province";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // grbtimer
            // 
            this.grbtimer.Controls.Add(this.btnPause);
            this.grbtimer.Controls.Add(this.btnexit);
            this.grbtimer.Controls.Add(this.btnstart);
            this.grbtimer.Controls.Add(this.textBox1);
            this.grbtimer.Location = new System.Drawing.Point(312, 22);
            this.grbtimer.Name = "grbtimer";
            this.grbtimer.Size = new System.Drawing.Size(255, 332);
            this.grbtimer.TabIndex = 1;
            this.grbtimer.TabStop = false;
            this.grbtimer.Text = "Timer";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(37, 148);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 13;
            this.btnPause.Text = "&Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(72, 242);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(37, 103);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 23);
            this.btnstart.TabIndex = 12;
            this.btnstart.Text = "&Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(37, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "00:00:00";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timTimer
            // 
            this.timTimer.Interval = 1000;
            this.timTimer.Tick += new System.EventHandler(this.timTimer_Tick);
            // 
            // FrmDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 374);
            this.Controls.Add(this.grbtimer);
            this.Controls.Add(this.GrbDataEntry);
            this.Name = "FrmDataEntry";
            this.Text = "Data Entry Form";
            this.GrbDataEntry.ResumeLayout(false);
            this.GrbDataEntry.PerformLayout();
            this.grbtimer.ResumeLayout(false);
            this.grbtimer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbDataEntry;
        private System.Windows.Forms.GroupBox grbtimer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtzip;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timTimer;
    }
}

