namespace VDFCreator
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.STICK_RIGHT = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DPAD_LEFT = new System.Windows.Forms.Button();
            this.DPAD_UP = new System.Windows.Forms.Button();
            this.DPAD_RIGHT = new System.Windows.Forms.Button();
            this.DPAD_DOWN = new System.Windows.Forms.Button();
            this.BUTTON_SOUTH = new System.Windows.Forms.Button();
            this.BUTTON_EAST = new System.Windows.Forms.Button();
            this.BUTTON_LEFT = new System.Windows.Forms.Button();
            this.BUTTON_NORTH = new System.Windows.Forms.Button();
            this.BUTTON_START = new System.Windows.Forms.Button();
            this.BUTTON_SELECT = new System.Windows.Forms.Button();
            this.STICK_LEFT = new System.Windows.Forms.Button();
            this.SHOULDER_RIGHT = new System.Windows.Forms.Button();
            this.TRIGGER_RIGHT = new System.Windows.Forms.Button();
            this.SHOULDER_LEFT = new System.Windows.Forms.Button();
            this.TRIGGER_LEFT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::VDFCreator.Properties.Resources.XboxOne_Diagram_Simple;
            this.pictureBox1.Location = new System.Drawing.Point(141, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // STICK_RIGHT
            // 
            this.STICK_RIGHT.Location = new System.Drawing.Point(463, 256);
            this.STICK_RIGHT.Name = "STICK_RIGHT";
            this.STICK_RIGHT.Size = new System.Drawing.Size(31, 23);
            this.STICK_RIGHT.TabIndex = 1;
            this.STICK_RIGHT.Text = "STICK_RIGHT";
            this.STICK_RIGHT.UseVisualStyleBackColor = true;
            this.STICK_RIGHT.Click += new System.EventHandler(this.STICK_RIGHT_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(141, 428);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 294);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // DPAD_LEFT
            // 
            this.DPAD_LEFT.Location = new System.Drawing.Point(304, 256);
            this.DPAD_LEFT.Name = "DPAD_LEFT";
            this.DPAD_LEFT.Size = new System.Drawing.Size(30, 23);
            this.DPAD_LEFT.TabIndex = 3;
            this.DPAD_LEFT.Text = "DPAD_LEFT";
            this.DPAD_LEFT.UseVisualStyleBackColor = true;
            this.DPAD_LEFT.Click += new System.EventHandler(this.DPAD_LEFT_Click);
            // 
            // DPAD_UP
            // 
            this.DPAD_UP.Location = new System.Drawing.Point(327, 230);
            this.DPAD_UP.Name = "DPAD_UP";
            this.DPAD_UP.Size = new System.Drawing.Size(30, 23);
            this.DPAD_UP.TabIndex = 4;
            this.DPAD_UP.Text = "DPAD_UP";
            this.DPAD_UP.UseVisualStyleBackColor = true;
            this.DPAD_UP.Click += new System.EventHandler(this.DPAD_UP_Click);
            // 
            // DPAD_RIGHT
            // 
            this.DPAD_RIGHT.Location = new System.Drawing.Point(353, 256);
            this.DPAD_RIGHT.Name = "DPAD_RIGHT";
            this.DPAD_RIGHT.Size = new System.Drawing.Size(30, 23);
            this.DPAD_RIGHT.TabIndex = 5;
            this.DPAD_RIGHT.Text = "DPAD_RIGHT";
            this.DPAD_RIGHT.UseVisualStyleBackColor = true;
            this.DPAD_RIGHT.Click += new System.EventHandler(this.DPAD_RIGHT_Click);
            // 
            // DPAD_DOWN
            // 
            this.DPAD_DOWN.Location = new System.Drawing.Point(327, 288);
            this.DPAD_DOWN.Name = "DPAD_DOWN";
            this.DPAD_DOWN.Size = new System.Drawing.Size(30, 23);
            this.DPAD_DOWN.TabIndex = 6;
            this.DPAD_DOWN.Text = "DPAD_DOWN";
            this.DPAD_DOWN.UseVisualStyleBackColor = true;
            this.DPAD_DOWN.Click += new System.EventHandler(this.DPAD_DOWN_Click);
            // 
            // BUTTON_SOUTH
            // 
            this.BUTTON_SOUTH.Location = new System.Drawing.Point(526, 204);
            this.BUTTON_SOUTH.Name = "BUTTON_SOUTH";
            this.BUTTON_SOUTH.Size = new System.Drawing.Size(31, 23);
            this.BUTTON_SOUTH.TabIndex = 7;
            this.BUTTON_SOUTH.Text = "BUTTON_SOUTH";
            this.BUTTON_SOUTH.UseVisualStyleBackColor = true;
            this.BUTTON_SOUTH.Click += new System.EventHandler(this.BUTTON_SOUTH_Click);
            // 
            // BUTTON_EAST
            // 
            this.BUTTON_EAST.Location = new System.Drawing.Point(562, 172);
            this.BUTTON_EAST.Name = "BUTTON_EAST";
            this.BUTTON_EAST.Size = new System.Drawing.Size(31, 23);
            this.BUTTON_EAST.TabIndex = 8;
            this.BUTTON_EAST.Text = "BUTTON_EAST";
            this.BUTTON_EAST.UseVisualStyleBackColor = true;
            this.BUTTON_EAST.Click += new System.EventHandler(this.BUTTON_EAST_Click);
            // 
            // BUTTON_LEFT
            // 
            this.BUTTON_LEFT.Location = new System.Drawing.Point(492, 172);
            this.BUTTON_LEFT.Name = "BUTTON_LEFT";
            this.BUTTON_LEFT.Size = new System.Drawing.Size(31, 23);
            this.BUTTON_LEFT.TabIndex = 9;
            this.BUTTON_LEFT.Text = "BUTTON_WEST";
            this.BUTTON_LEFT.UseVisualStyleBackColor = true;
            this.BUTTON_LEFT.Click += new System.EventHandler(this.BUTTON_LEFT_Click);
            // 
            // BUTTON_NORTH
            // 
            this.BUTTON_NORTH.Location = new System.Drawing.Point(526, 131);
            this.BUTTON_NORTH.Name = "BUTTON_NORTH";
            this.BUTTON_NORTH.Size = new System.Drawing.Size(31, 23);
            this.BUTTON_NORTH.TabIndex = 10;
            this.BUTTON_NORTH.Text = "BUTTON_NORTH";
            this.BUTTON_NORTH.UseVisualStyleBackColor = true;
            this.BUTTON_NORTH.Click += new System.EventHandler(this.BUTTON_NORTH_Click);
            // 
            // BUTTON_START
            // 
            this.BUTTON_START.Location = new System.Drawing.Point(431, 172);
            this.BUTTON_START.Name = "BUTTON_START";
            this.BUTTON_START.Size = new System.Drawing.Size(31, 23);
            this.BUTTON_START.TabIndex = 11;
            this.BUTTON_START.Text = "BUTTON_START";
            this.BUTTON_START.UseVisualStyleBackColor = true;
            this.BUTTON_START.Click += new System.EventHandler(this.BUTTON_START_Click);
            // 
            // BUTTON_SELECT
            // 
            this.BUTTON_SELECT.Location = new System.Drawing.Point(362, 172);
            this.BUTTON_SELECT.Name = "BUTTON_SELECT";
            this.BUTTON_SELECT.Size = new System.Drawing.Size(31, 23);
            this.BUTTON_SELECT.TabIndex = 12;
            this.BUTTON_SELECT.Text = "BUTTON_SELECT";
            this.BUTTON_SELECT.UseVisualStyleBackColor = true;
            this.BUTTON_SELECT.Click += new System.EventHandler(this.BUTTON_SELECT_Click);
            // 
            // STICK_LEFT
            // 
            this.STICK_LEFT.Location = new System.Drawing.Point(265, 181);
            this.STICK_LEFT.Name = "STICK_LEFT";
            this.STICK_LEFT.Size = new System.Drawing.Size(31, 23);
            this.STICK_LEFT.TabIndex = 13;
            this.STICK_LEFT.Text = "STICK_LEFT";
            this.STICK_LEFT.UseVisualStyleBackColor = true;
            this.STICK_LEFT.Click += new System.EventHandler(this.STICK_LEFT_Click);
            // 
            // SHOULDER_RIGHT
            // 
            this.SHOULDER_RIGHT.Location = new System.Drawing.Point(526, 62);
            this.SHOULDER_RIGHT.Name = "SHOULDER_RIGHT";
            this.SHOULDER_RIGHT.Size = new System.Drawing.Size(31, 23);
            this.SHOULDER_RIGHT.TabIndex = 14;
            this.SHOULDER_RIGHT.Text = "SHOULDER_RIGHT";
            this.SHOULDER_RIGHT.UseVisualStyleBackColor = true;
            this.SHOULDER_RIGHT.Click += new System.EventHandler(this.SHOULDER_RIGHT_Click);
            // 
            // TRIGGER_RIGHT
            // 
            this.TRIGGER_RIGHT.Location = new System.Drawing.Point(526, 23);
            this.TRIGGER_RIGHT.Name = "TRIGGER_RIGHT";
            this.TRIGGER_RIGHT.Size = new System.Drawing.Size(31, 23);
            this.TRIGGER_RIGHT.TabIndex = 15;
            this.TRIGGER_RIGHT.Text = "TRIGGER_RIGHT";
            this.TRIGGER_RIGHT.UseVisualStyleBackColor = true;
            this.TRIGGER_RIGHT.Click += new System.EventHandler(this.TRIGGER_RIGHT_Click);
            // 
            // SHOULDER_LEFT
            // 
            this.SHOULDER_LEFT.Location = new System.Drawing.Point(265, 62);
            this.SHOULDER_LEFT.Name = "SHOULDER_LEFT";
            this.SHOULDER_LEFT.Size = new System.Drawing.Size(31, 23);
            this.SHOULDER_LEFT.TabIndex = 16;
            this.SHOULDER_LEFT.Text = "SHOULDER_LEFT";
            this.SHOULDER_LEFT.UseVisualStyleBackColor = true;
            this.SHOULDER_LEFT.Click += new System.EventHandler(this.SHOULDER_LEFT_Click);
            // 
            // TRIGGER_LEFT
            // 
            this.TRIGGER_LEFT.Location = new System.Drawing.Point(265, 23);
            this.TRIGGER_LEFT.Name = "TRIGGER_LEFT";
            this.TRIGGER_LEFT.Size = new System.Drawing.Size(31, 23);
            this.TRIGGER_LEFT.TabIndex = 17;
            this.TRIGGER_LEFT.Text = "TRIGGER_LEFT";
            this.TRIGGER_LEFT.UseVisualStyleBackColor = true;
            this.TRIGGER_LEFT.Click += new System.EventHandler(this.TRIGGER_LEFT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 785);
            this.Controls.Add(this.TRIGGER_LEFT);
            this.Controls.Add(this.SHOULDER_LEFT);
            this.Controls.Add(this.TRIGGER_RIGHT);
            this.Controls.Add(this.SHOULDER_RIGHT);
            this.Controls.Add(this.STICK_LEFT);
            this.Controls.Add(this.BUTTON_SELECT);
            this.Controls.Add(this.BUTTON_START);
            this.Controls.Add(this.BUTTON_NORTH);
            this.Controls.Add(this.BUTTON_LEFT);
            this.Controls.Add(this.BUTTON_EAST);
            this.Controls.Add(this.BUTTON_SOUTH);
            this.Controls.Add(this.DPAD_DOWN);
            this.Controls.Add(this.DPAD_RIGHT);
            this.Controls.Add(this.DPAD_UP);
            this.Controls.Add(this.DPAD_LEFT);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.STICK_RIGHT);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button STICK_RIGHT;
        private TableLayoutPanel tableLayoutPanel1;
        private Button DPAD_LEFT;
        private Button DPAD_UP;
        private Button DPAD_RIGHT;
        private Button DPAD_DOWN;
        private Button BUTTON_SOUTH;
        private Button BUTTON_EAST;
        private Button BUTTON_LEFT;
        private Button BUTTON_NORTH;
        private Button BUTTON_START;
        private Button BUTTON_SELECT;
        private Button STICK_LEFT;
        private Button SHOULDER_RIGHT;
        private Button TRIGGER_RIGHT;
        private Button SHOULDER_LEFT;
        private Button TRIGGER_LEFT;
    }
}