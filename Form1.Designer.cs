namespace ToDoList
{
    partial class ToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoList));
            label1 = new Label();
            label2 = new Label();
            titleTextBox = new TextBox();
            label3 = new Label();
            descriptionTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            toDoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 9);
            label1.Name = "label1";
            label1.Size = new Size(266, 57);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(776, 28);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(12, 101);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(776, 23);
            titleTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(776, 28);
            label3.TabIndex = 1;
            label3.Text = "Description";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(12, 158);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(776, 23);
            descriptionTextBox.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(12, 187);
            button1.Name = "button1";
            button1.Size = new Size(190, 37);
            button1.TabIndex = 3;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(208, 187);
            button2.Name = "button2";
            button2.Size = new Size(190, 37);
            button2.TabIndex = 3;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(404, 187);
            button3.Name = "button3";
            button3.Size = new Size(190, 37);
            button3.TabIndex = 3;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(600, 187);
            button4.Name = "button4";
            button4.Size = new Size(190, 37);
            button4.TabIndex = 3;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // toDoListView
            // 
            toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoListView.BackgroundColor = SystemColors.ControlLightLight;
            toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDoListView.Location = new Point(12, 230);
            toDoListView.Name = "toDoListView";
            toDoListView.Size = new Size(776, 417);
            toDoListView.TabIndex = 4;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 659);
            Controls.Add(toDoListView);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ToDoList";
            Text = "ToDoList";
            Load += ToDoList_Load;
            ((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox titleTextBox;
        private Label label3;
        private TextBox descriptionTextBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView toDoListView;
    }
}
