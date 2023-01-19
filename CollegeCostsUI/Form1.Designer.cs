
namespace CollegeCostsUI
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
            this.collegeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.instateCheckbox = new System.Windows.Forms.CheckBox();
            this.outStateCheckBox = new System.Windows.Forms.CheckBox();
            this.includeRoomBoardCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.instateTuitionTextBox = new System.Windows.Forms.TextBox();
            this.outStateTuitionTextBox = new System.Windows.Forms.TextBox();
            this.roomBoardTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalTuitionTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // collegeListBox
            // 
            this.collegeListBox.FormattingEnabled = true;
            this.collegeListBox.Location = new System.Drawing.Point(136, 43);
            this.collegeListBox.Name = "collegeListBox";
            this.collegeListBox.Size = new System.Drawing.Size(248, 199);
            this.collegeListBox.TabIndex = 0;
            this.collegeListBox.SelectedIndexChanged += new System.EventHandler(this.collegeListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "College";
            // 
            // instateCheckbox
            // 
            this.instateCheckbox.AutoSize = true;
            this.instateCheckbox.Checked = true;
            this.instateCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.instateCheckbox.Location = new System.Drawing.Point(91, 259);
            this.instateCheckbox.Name = "instateCheckbox";
            this.instateCheckbox.Size = new System.Drawing.Size(154, 17);
            this.instateCheckbox.TabIndex = 2;
            this.instateCheckbox.Text = "Calculate for In-state tuition";
            this.instateCheckbox.UseVisualStyleBackColor = true;
            this.instateCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // outStateCheckBox
            // 
            this.outStateCheckBox.AutoSize = true;
            this.outStateCheckBox.Location = new System.Drawing.Point(91, 282);
            this.outStateCheckBox.Name = "outStateCheckBox";
            this.outStateCheckBox.Size = new System.Drawing.Size(162, 17);
            this.outStateCheckBox.TabIndex = 3;
            this.outStateCheckBox.Text = "Calculate for Out-state tuition";
            this.outStateCheckBox.UseVisualStyleBackColor = true;
            this.outStateCheckBox.CheckedChanged += new System.EventHandler(this.outStateCheckBox_CheckedChanged);
            // 
            // includeRoomBoardCheckBox
            // 
            this.includeRoomBoardCheckBox.AutoSize = true;
            this.includeRoomBoardCheckBox.Checked = true;
            this.includeRoomBoardCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeRoomBoardCheckBox.Location = new System.Drawing.Point(91, 305);
            this.includeRoomBoardCheckBox.Name = "includeRoomBoardCheckBox";
            this.includeRoomBoardCheckBox.Size = new System.Drawing.Size(195, 17);
            this.includeRoomBoardCheckBox.TabIndex = 4;
            this.includeRoomBoardCheckBox.Text = "Include Room/Board in tuition costs";
            this.includeRoomBoardCheckBox.UseVisualStyleBackColor = true;
            this.includeRoomBoardCheckBox.CheckedChanged += new System.EventHandler(this.includeRoomBoardCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "In-state Tuition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Out-state Tuition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Room/board";
            // 
            // instateTuitionTextBox
            // 
            this.instateTuitionTextBox.Location = new System.Drawing.Point(576, 40);
            this.instateTuitionTextBox.Name = "instateTuitionTextBox";
            this.instateTuitionTextBox.ReadOnly = true;
            this.instateTuitionTextBox.Size = new System.Drawing.Size(100, 20);
            this.instateTuitionTextBox.TabIndex = 8;
            // 
            // outStateTuitionTextBox
            // 
            this.outStateTuitionTextBox.Location = new System.Drawing.Point(576, 75);
            this.outStateTuitionTextBox.Name = "outStateTuitionTextBox";
            this.outStateTuitionTextBox.ReadOnly = true;
            this.outStateTuitionTextBox.Size = new System.Drawing.Size(100, 20);
            this.outStateTuitionTextBox.TabIndex = 9;
            // 
            // roomBoardTextBox
            // 
            this.roomBoardTextBox.Location = new System.Drawing.Point(576, 110);
            this.roomBoardTextBox.Name = "roomBoardTextBox";
            this.roomBoardTextBox.ReadOnly = true;
            this.roomBoardTextBox.Size = new System.Drawing.Size(100, 20);
            this.roomBoardTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(470, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Tuition";
            // 
            // totalTuitionTextBox
            // 
            this.totalTuitionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTuitionTextBox.Location = new System.Drawing.Point(576, 162);
            this.totalTuitionTextBox.Name = "totalTuitionTextBox";
            this.totalTuitionTextBox.ReadOnly = true;
            this.totalTuitionTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTuitionTextBox.TabIndex = 12;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(701, 318);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.totalTuitionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roomBoardTextBox);
            this.Controls.Add(this.outStateTuitionTextBox);
            this.Controls.Add(this.instateTuitionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.includeRoomBoardCheckBox);
            this.Controls.Add(this.outStateCheckBox);
            this.Controls.Add(this.instateCheckbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.collegeListBox);
            this.Name = "Form1";
            this.Text = "College Costs UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox collegeListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox instateCheckbox;
        private System.Windows.Forms.CheckBox outStateCheckBox;
        private System.Windows.Forms.CheckBox includeRoomBoardCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox instateTuitionTextBox;
        private System.Windows.Forms.TextBox outStateTuitionTextBox;
        private System.Windows.Forms.TextBox roomBoardTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalTuitionTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}

