namespace FirstGUIApplication
{
    partial class Sign_Up_Form
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
            Welcome_Button = new Button();
            First_Button = new Label();
            Last_name = new Label();
            Email_Button = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            undergrad_button = new RadioButton();
            Grad_Button = new RadioButton();
            Finish_Button = new Button();
            Close_Button = new Button();
            menuStrip1 = new MenuStrip();
            Menu_Options = new ToolStripMenuItem();
            thisIsTheFirstOptionToolStripMenuItem = new ToolStripMenuItem();
            thisIsAnotherOneToolStripMenuItem = new ToolStripMenuItem();
            moreOptionsToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            moreOptionsToolStripMenuItem1 = new ToolStripMenuItem();
            anotherOptionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Welcome_Button
            // 
            Welcome_Button.Location = new Point(254, 73);
            Welcome_Button.Name = "Welcome_Button";
            Welcome_Button.Size = new Size(332, 34);
            Welcome_Button.TabIndex = 0;
            Welcome_Button.Text = "Welcome to the Sign Up Form!";
            Welcome_Button.UseVisualStyleBackColor = true;
            Welcome_Button.Click += button1_Click;
            // 
            // First_Button
            // 
            First_Button.AutoSize = true;
            First_Button.Location = new Point(254, 171);
            First_Button.Name = "First_Button";
            First_Button.Size = new Size(101, 25);
            First_Button.TabIndex = 1;
            First_Button.Text = "First Name:";
            First_Button.Click += label1_Click;
            // 
            // Last_name
            // 
            Last_name.AutoSize = true;
            Last_name.Location = new Point(254, 214);
            Last_name.Name = "Last_name";
            Last_name.Size = new Size(99, 25);
            Last_name.TabIndex = 2;
            Last_name.Text = "Last Name:";
            // 
            // Email_Button
            // 
            Email_Button.AutoSize = true;
            Email_Button.Location = new Point(254, 253);
            Email_Button.Name = "Email_Button";
            Email_Button.Size = new Size(58, 25);
            Email_Button.TabIndex = 3;
            Email_Button.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 298);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 4;
            label4.Text = "Student:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(357, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(355, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(353, 250);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 7;
            // 
            // undergrad_button
            // 
            undergrad_button.AutoSize = true;
            undergrad_button.Location = new Point(355, 307);
            undergrad_button.Name = "undergrad_button";
            undergrad_button.Size = new Size(157, 29);
            undergrad_button.TabIndex = 8;
            undergrad_button.TabStop = true;
            undergrad_button.Text = "UnderGraduate";
            undergrad_button.UseVisualStyleBackColor = true;
            // 
            // Grad_Button
            // 
            Grad_Button.AutoSize = true;
            Grad_Button.Location = new Point(518, 307);
            Grad_Button.Name = "Grad_Button";
            Grad_Button.Size = new Size(109, 29);
            Grad_Button.TabIndex = 9;
            Grad_Button.TabStop = true;
            Grad_Button.Text = "Graduate";
            Grad_Button.UseVisualStyleBackColor = true;
            // 
            // Finish_Button
            // 
            Finish_Button.Location = new Point(244, 365);
            Finish_Button.Name = "Finish_Button";
            Finish_Button.Size = new Size(183, 34);
            Finish_Button.TabIndex = 10;
            Finish_Button.Text = "Finish Sign up!";
            Finish_Button.UseVisualStyleBackColor = true;
            Finish_Button.Click += button2_Click;
            // 
            // Close_Button
            // 
            Close_Button.Location = new Point(471, 365);
            Close_Button.Name = "Close_Button";
            Close_Button.Size = new Size(112, 34);
            Close_Button.TabIndex = 11;
            Close_Button.Text = "Close";
            Close_Button.UseVisualStyleBackColor = true;
            Close_Button.Click += Close_Button_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Menu_Options });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Options
            // 
            Menu_Options.DropDownItems.AddRange(new ToolStripItem[] { thisIsTheFirstOptionToolStripMenuItem, thisIsAnotherOneToolStripMenuItem, toolStripTextBox1 });
            Menu_Options.Name = "Menu_Options";
            Menu_Options.Size = new Size(78, 29);
            Menu_Options.Text = "Menu ";
            Menu_Options.Click += test1ToolStripMenuItem_Click;
            // 
            // thisIsTheFirstOptionToolStripMenuItem
            // 
            thisIsTheFirstOptionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem, moreOptionsToolStripMenuItem1 });
            thisIsTheFirstOptionToolStripMenuItem.Name = "thisIsTheFirstOptionToolStripMenuItem";
            thisIsTheFirstOptionToolStripMenuItem.Size = new Size(285, 34);
            thisIsTheFirstOptionToolStripMenuItem.Text = "This is the first option";
            // 
            // thisIsAnotherOneToolStripMenuItem
            // 
            thisIsAnotherOneToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { moreOptionsToolStripMenuItem });
            thisIsAnotherOneToolStripMenuItem.Name = "thisIsAnotherOneToolStripMenuItem";
            thisIsAnotherOneToolStripMenuItem.Size = new Size(285, 34);
            thisIsAnotherOneToolStripMenuItem.Text = "This is another one";
            // 
            // moreOptionsToolStripMenuItem
            // 
            moreOptionsToolStripMenuItem.Name = "moreOptionsToolStripMenuItem";
            moreOptionsToolStripMenuItem.Size = new Size(222, 34);
            moreOptionsToolStripMenuItem.Text = "More options";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 31);
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(270, 34);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // moreOptionsToolStripMenuItem1
            // 
            moreOptionsToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { anotherOptionToolStripMenuItem });
            moreOptionsToolStripMenuItem1.Name = "moreOptionsToolStripMenuItem1";
            moreOptionsToolStripMenuItem1.Size = new Size(270, 34);
            moreOptionsToolStripMenuItem1.Text = "more options";
            // 
            // anotherOptionToolStripMenuItem
            // 
            anotherOptionToolStripMenuItem.Name = "anotherOptionToolStripMenuItem";
            anotherOptionToolStripMenuItem.Size = new Size(270, 34);
            anotherOptionToolStripMenuItem.Text = "Another option";
            // 
            // Sign_Up_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Close_Button);
            Controls.Add(Finish_Button);
            Controls.Add(Grad_Button);
            Controls.Add(undergrad_button);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(Email_Button);
            Controls.Add(Last_name);
            Controls.Add(First_Button);
            Controls.Add(Welcome_Button);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Sign_Up_Form";
            Text = "Sign Up Form";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Welcome_Button;
        private Label First_Button;
        private Label Last_name;
        private Label Email_Button;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private RadioButton undergrad_button;
        private RadioButton Grad_Button;
        private Button Finish_Button;
        private Button Close_Button;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Menu_Options;
        private ToolStripMenuItem thisIsTheFirstOptionToolStripMenuItem;
        private ToolStripMenuItem thisIsAnotherOneToolStripMenuItem;
        private ToolStripMenuItem moreOptionsToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem moreOptionsToolStripMenuItem1;
        private ToolStripMenuItem anotherOptionToolStripMenuItem;
    }
}
