namespace _WanaDecryptor_
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            bar1 = new PictureBox();
            label10 = new Label();
            pictureBox3 = new PictureBox();
            date1 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            bar2 = new PictureBox();
            label11 = new Label();
            pictureBox4 = new PictureBox();
            date2 = new Label();
            label6 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            panel4 = new Panel();
            label2 = new Label();
            payment_btn = new Button();
            decrypt_btn = new Button();
            checking_payment_box = new Panel();
            cancel_checking = new Button();
            connecting_bar = new ProgressBar();
            label8 = new Label();
            label7 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            label9 = new Label();
            listBox1 = new ListBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            time_left_timer = new System.Windows.Forms.Timer(components);
            lang_list = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            checking_payment_box.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._lock;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(49, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 135);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(bar1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(date1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 135);
            panel1.TabIndex = 1;
            // 
            // bar1
            // 
            bar1.Location = new Point(198, -1);
            bar1.Name = "bar1";
            bar1.Size = new Size(34, 10);
            bar1.TabIndex = 14;
            bar1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 24F);
            label10.ForeColor = Color.Khaki;
            label10.Location = new Point(11, 86);
            label10.Name = "label10";
            label10.Size = new Size(186, 39);
            label10.TabIndex = 13;
            label10.Text = "00:00:00:00";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.time_left_bar;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(207, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 109);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // date1
            // 
            date1.AutoSize = true;
            date1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            date1.ForeColor = Color.White;
            date1.Location = new Point(27, 38);
            date1.Name = "date1";
            date1.Size = new Size(165, 19);
            date1.TabIndex = 11;
            date1.Text = "XX/XX/XXXX   XX:XX:XX";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(67, 64);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 10;
            label5.Text = "Time left";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(1, 11);
            label3.Name = "label3";
            label3.Size = new Size(195, 21);
            label3.TabIndex = 9;
            label3.Text = "Payment will be raised on";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(bar2);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(date2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 288);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 135);
            panel2.TabIndex = 2;
            // 
            // bar2
            // 
            bar2.Location = new Point(197, 0);
            bar2.Name = "bar2";
            bar2.Size = new Size(34, 10);
            bar2.TabIndex = 15;
            bar2.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 24F);
            label11.ForeColor = Color.Khaki;
            label11.Location = new Point(11, 85);
            label11.Name = "label11";
            label11.Size = new Size(186, 39);
            label11.TabIndex = 14;
            label11.Text = "00:00:00:00";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.time_left_bar;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(207, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(19, 110);
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // date2
            // 
            date2.AutoSize = true;
            date2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            date2.ForeColor = Color.White;
            date2.Location = new Point(24, 35);
            date2.Name = "date2";
            date2.Size = new Size(165, 19);
            date2.TabIndex = 12;
            date2.Text = "XX/XX/XXXX   XX:XX:XX";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(67, 63);
            label6.Name = "label6";
            label6.Size = new Size(65, 19);
            label6.TabIndex = 11;
            label6.Text = "Time left";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(8, 9);
            label4.Name = "label4";
            label4.Size = new Size(186, 21);
            label4.TabIndex = 10;
            label4.Text = "Your files will be lost on ";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(256, 434);
            panel3.Name = "panel3";
            panel3.Size = new Size(584, 97);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(172, 8);
            label1.Name = "label1";
            label1.Size = new Size(314, 21);
            label1.TabIndex = 8;
            label1.Text = "Send 300$ worth of bitcoin to this adress:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.bitcoin_accepted;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-2, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(166, 72);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.Location = new Point(535, 51);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(42, 32);
            button1.TabIndex = 6;
            button1.Text = "Copy";
            button1.UseVisualStyleBackColor = false;
            button1.Click += copy_wallet;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label2);
            panel4.Location = new Point(170, 51);
            panel4.Name = "panel4";
            panel4.Size = new Size(361, 32);
            panel4.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(-1, 0);
            label2.Name = "label2";
            label2.Size = new Size(268, 21);
            label2.TabIndex = 0;
            label2.Text = "AbCdEfGhIjKlMnOpRsTuVwXyZAbC";
            // 
            // payment_btn
            // 
            payment_btn.BackColor = SystemColors.ControlLight;
            payment_btn.FlatStyle = FlatStyle.Popup;
            payment_btn.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            payment_btn.Location = new Point(256, 537);
            payment_btn.Name = "payment_btn";
            payment_btn.Size = new Size(278, 35);
            payment_btn.TabIndex = 4;
            payment_btn.Text = "Check Payment";
            payment_btn.UseVisualStyleBackColor = false;
            payment_btn.Click += check_payment;
            // 
            // decrypt_btn
            // 
            decrypt_btn.BackColor = SystemColors.ControlLight;
            decrypt_btn.FlatStyle = FlatStyle.Popup;
            decrypt_btn.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            decrypt_btn.Location = new Point(564, 537);
            decrypt_btn.Name = "decrypt_btn";
            decrypt_btn.Size = new Size(276, 35);
            decrypt_btn.TabIndex = 5;
            decrypt_btn.Text = "Decrypt";
            decrypt_btn.UseVisualStyleBackColor = false;
            decrypt_btn.Click += decrypt_files;
            // 
            // checking_payment_box
            // 
            checking_payment_box.BackColor = SystemColors.Control;
            checking_payment_box.BorderStyle = BorderStyle.FixedSingle;
            checking_payment_box.Controls.Add(cancel_checking);
            checking_payment_box.Controls.Add(connecting_bar);
            checking_payment_box.Controls.Add(label8);
            checking_payment_box.Controls.Add(label7);
            checking_payment_box.Location = new Point(264, 143);
            checking_payment_box.Name = "checking_payment_box";
            checking_payment_box.Size = new Size(326, 145);
            checking_payment_box.TabIndex = 6;
            // 
            // cancel_checking
            // 
            cancel_checking.BackColor = SystemColors.ControlLight;
            cancel_checking.FlatStyle = FlatStyle.Popup;
            cancel_checking.Font = new Font("Segoe UI Semibold", 10F);
            cancel_checking.Location = new Point(234, 107);
            cancel_checking.Margin = new Padding(0);
            cancel_checking.Name = "cancel_checking";
            cancel_checking.Size = new Size(81, 28);
            cancel_checking.TabIndex = 9;
            cancel_checking.Text = "Cancel";
            cancel_checking.UseVisualStyleBackColor = false;
            cancel_checking.Click += cancel_checking_Click;
            // 
            // connecting_bar
            // 
            connecting_bar.Location = new Point(9, 78);
            connecting_bar.Name = "connecting_bar";
            connecting_bar.Size = new Size(306, 23);
            connecting_bar.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 45);
            label8.Name = "label8";
            label8.Size = new Size(126, 15);
            label8.TabIndex = 1;
            label8.Text = "Connecting to server...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 12);
            label7.Name = "label7";
            label7.Size = new Size(143, 15);
            label7.TabIndex = 0;
            label7.Text = "Checking your payment...";
            // 
            // timer
            // 
            timer.Interval = 225;
            timer.Tick += timer_Tick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(290, 2);
            label9.Name = "label9";
            label9.Size = new Size(372, 28);
            label9.TabIndex = 1;
            label9.Text = "Ooops, your files have been encrypted!";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras et accum", "san ante. Maecenas fringilla lacus eget enim commodo, id efficitur lib", "ero scelerisque. Donec sem nibh, imperdiet eget purus eget, hendrerit ", "rhoncus felis. Fusce tempor sollicitudin metus, vel gravida urna viver", "ra eu. Sed sollicitudin felis in lectus viverra ornare id eget nisl. P", "roin elementum odio sed nisl ornare, non suscipit lectus elementum. I", "nteger ligula odio, lobortis eget tortor ac, blandit rutrum sapien. Cu", "rabitur eget sem pellentesque, mollis libero quis, rutrum tortor. Phas", "ellus quis ligula nec mi semper pretium. Aliquam nec ex tortor. Suspen", "disse et lorem ut velit egestas finibus. Vivamus vitae purus ut ex vol", "utpat commodo nec vitae magna. Sed feugiat lacus in semper lobortis. Cu", "rabitur dictum eu nullain porttitor. In lectus augue, commodo lobortis ", "massa non, pretium tmpus enim. Pellentesque et risus nibh.", "", "Integer in odio quis elit vulputate tincidunt at non leo. In et turpis", " neque. Duis quis pulvinar quam, quis vulputate neque. Donec quis rutr", "um nisi. Vestibulum cursus, risus non porttitor facilisis, odio ipsum ", "mollis neque, a egestas ex justo eu nunc. Curabitur maximus rutrum sap", "ien ut vehicula. Fusce ac elit mi. Proin posuere mi eget iaculis curs", "us. Vestibulum vel imperdiet lacus, vel posuere erat. Integer dolor l", "igula, ornare non porta consectetur, dapibus non eros. Nullam id orna", "re lectus, vel semper velit. Quisque mi sem, facilisis in scelerisque", " a, elementum nec sem. In tellus felis, luctus non ipsum nec, pellent", "esque scelerisque quam.", "", "Mauris vitae augue tristique, ornare diam sit amet, malesuada metus. ", "Ut placerat blandit mauris, sit amet ultricies tortor consequat sed. ", "Pellentesque quis lacus eros. Morbi vestibulum felis turpis. Morbi ut", " ullamcorper leo. Integer a malesuada metus. Maecenas sollicitudin lor", "em ut aliquet viverra. Donec consectetur, ligula nec porta pharetra, n", "isl arcu ultrices velit, sit amet viverra odio tortor a enim. In dapib", "us urna convallis egestas ornare. Pellentesque euismod placerat nulla,", " vitae tincidunt ipsum pretium sit amet. Mauris nec fringilla risus, s", "it amet sollicitudin dui. Aenean quis mi mollis, pretium urna id, port", "a diam. Vestibulum ante ipsum primis in faucibus orci luctus et ultric", "es posuere cubilia curae; Praesent ut interdum odio." });
            listBox1.Location = new Point(256, 39);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.None;
            listBox1.Size = new Size(584, 384);
            listBox1.TabIndex = 8;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.MediumTurquoise;
            linkLabel1.Location = new Point(31, 457);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(80, 15);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "About bitcoin";
            linkLabel1.LinkClicked += links;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.MediumTurquoise;
            linkLabel2.Location = new Point(31, 491);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(114, 15);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "How to buy bitcoin?";
            linkLabel2.LinkClicked += links;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            linkLabel3.LinkColor = Color.MediumTurquoise;
            linkLabel3.Location = new Point(28, 520);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(114, 30);
            linkLabel3.TabIndex = 11;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Contact Us";
            linkLabel3.LinkClicked += links;
            // 
            // time_left_timer
            // 
            time_left_timer.Interval = 1000;
            time_left_timer.Tick += time_left;
            // 
            // lang_list
            // 
            lang_list.DropDownStyle = ComboBoxStyle.DropDownList;
            lang_list.FormattingEnabled = true;
            lang_list.Items.AddRange(new object[] { "English", "Polish", "German", "Chinese", "Russian", "Spanish", "Italian" });
            lang_list.Location = new Point(698, 9);
            lang_list.Name = "lang_list";
            lang_list.Size = new Size(141, 23);
            lang_list.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(133, 27, 16);
            ClientSize = new Size(844, 579);
            Controls.Add(lang_list);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(checking_payment_box);
            Controls.Add(listBox1);
            Controls.Add(label9);
            Controls.Add(decrypt_btn);
            Controls.Add(payment_btn);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wana Decrypt0r 2.0";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            checking_payment_box.ResumeLayout(false);
            checking_payment_box.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Button payment_btn;
        private Button decrypt_btn;
        private Button decrypt;
        private Button payment;
        private Label label5;
        private Label label6;
        private Panel checking_payment_box;
        private Button cancel_checking;
        private ProgressBar connecting_bar;
        private Label label8;
        private Label label7;
        private System.Windows.Forms.Timer timer;
        private Label label9;
        private ListBox listBox1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private Label date1;
        private Label date2;
        private System.Windows.Forms.Timer time_left_timer;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label10;
        private Label label11;
        private PictureBox bar1;
        private PictureBox bar2;
        private ComboBox lang_list;
    }
}
