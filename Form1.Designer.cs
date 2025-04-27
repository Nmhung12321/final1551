namespace SPApplication
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mainPanel = new Panel();
            resultPanel = new Panel();
            resultTextBox = new TextBox();
            copyResultButton = new Button();
            inputPanel = new Panel();
            outputCodeButton = new Button();
            characterCountLabel = new Label();
            decreaseShiftButton = new Button();
            increaseShiftButton = new Button();
            shiftNumericUpDown = new NumericUpDown();
            inputCodeButton = new Button();
            sortButton = new Button();
            outputButton = new Button();
            encodeButton = new Button();
            shiftLabel = new Label();
            inputTextBox = new TextBox();
            inputLabel = new Label();
            welcomeLabel = new Label();
            errorProvider1 = new ErrorProvider(components);
            mainPanel.SuspendLayout();
            resultPanel.SuspendLayout();
            inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shiftNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(resultPanel);
            mainPanel.Controls.Add(inputPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(844, 600);
            mainPanel.TabIndex = 0;
            // 
            // resultPanel
            // 
            resultPanel.BackColor = Color.WhiteSmoke;
            resultPanel.Controls.Add(resultTextBox);
            resultPanel.Controls.Add(copyResultButton);
            resultPanel.Dock = DockStyle.Fill;
            resultPanel.Location = new Point(0, 350);
            resultPanel.Name = "resultPanel";
            resultPanel.Padding = new Padding(30);
            resultPanel.Size = new Size(844, 250);
            resultPanel.TabIndex = 1;
            // 
            // resultTextBox
            // 
            resultTextBox.Dock = DockStyle.Top;
            resultTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultTextBox.Location = new Point(30, 30);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.ScrollBars = ScrollBars.Vertical;
            resultTextBox.Size = new Size(784, 150);
            resultTextBox.TabIndex = 0;
            // 
            // copyResultButton
            // 
            copyResultButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            copyResultButton.BackColor = Color.SteelBlue;
            copyResultButton.FlatAppearance.BorderSize = 0;
            copyResultButton.FlatStyle = FlatStyle.Flat;
            copyResultButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            copyResultButton.ForeColor = Color.White;
            copyResultButton.Location = new Point(664, 190);
            copyResultButton.Name = "copyResultButton";
            copyResultButton.Size = new Size(150, 40);
            copyResultButton.TabIndex = 1;
            copyResultButton.Text = "Copy Result";
            copyResultButton.UseVisualStyleBackColor = false;
            copyResultButton.Click += CopyResultButton_Click;
            // 
            // inputPanel
            // 
            inputPanel.BackColor = Color.White;
            inputPanel.Controls.Add(outputCodeButton);
            inputPanel.Controls.Add(characterCountLabel);
            inputPanel.Controls.Add(decreaseShiftButton);
            inputPanel.Controls.Add(increaseShiftButton);
            inputPanel.Controls.Add(shiftNumericUpDown);
            inputPanel.Controls.Add(inputCodeButton);
            inputPanel.Controls.Add(sortButton);
            inputPanel.Controls.Add(outputButton);
            inputPanel.Controls.Add(encodeButton);
            inputPanel.Controls.Add(shiftLabel);
            inputPanel.Controls.Add(inputTextBox);
            inputPanel.Controls.Add(inputLabel);
            inputPanel.Controls.Add(welcomeLabel);
            inputPanel.Dock = DockStyle.Top;
            inputPanel.Location = new Point(0, 0);
            inputPanel.Name = "inputPanel";
            inputPanel.Padding = new Padding(30);
            inputPanel.Size = new Size(844, 350);
            inputPanel.TabIndex = 0;
            // 
            // outputCodeButton
            // 
            outputCodeButton.Anchor = AnchorStyles.Top;
            outputCodeButton.BackColor = Color.SteelBlue;
            outputCodeButton.FlatAppearance.BorderSize = 0;
            outputCodeButton.FlatStyle = FlatStyle.Flat;
            outputCodeButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputCodeButton.ForeColor = Color.White;
            outputCodeButton.Location = new Point(654, 280);
            outputCodeButton.Name = "outputCodeButton";
            outputCodeButton.Size = new Size(154, 50);
            outputCodeButton.TabIndex = 13;
            outputCodeButton.Text = "OutputCode";
            outputCodeButton.UseVisualStyleBackColor = false;
            outputCodeButton.Click += OutputCodeButton_Click;
            // 
            // characterCountLabel
            // 
            characterCountLabel.AutoSize = true;
            characterCountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            characterCountLabel.ForeColor = Color.Gray;
            characterCountLabel.Location = new Point(30, 170);
            characterCountLabel.Name = "characterCountLabel";
            characterCountLabel.Size = new Size(87, 15);
            characterCountLabel.TabIndex = 12;
            characterCountLabel.Text = "0/40 characters";
            // 
            // decreaseShiftButton
            // 
            decreaseShiftButton.BackColor = Color.LightSteelBlue;
            decreaseShiftButton.FlatAppearance.BorderSize = 0;
            decreaseShiftButton.FlatStyle = FlatStyle.Flat;
            decreaseShiftButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            decreaseShiftButton.Location = new Point(230, 220);
            decreaseShiftButton.Name = "decreaseShiftButton";
            decreaseShiftButton.Size = new Size(50, 35);
            decreaseShiftButton.TabIndex = 11;
            decreaseShiftButton.Text = "-";
            decreaseShiftButton.UseVisualStyleBackColor = false;
            decreaseShiftButton.Click += DecreaseShiftButton_Click;
            // 
            // increaseShiftButton
            // 
            increaseShiftButton.BackColor = Color.LightSteelBlue;
            increaseShiftButton.FlatAppearance.BorderSize = 0;
            increaseShiftButton.FlatStyle = FlatStyle.Flat;
            increaseShiftButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            increaseShiftButton.Location = new Point(180, 220);
            increaseShiftButton.Name = "increaseShiftButton";
            increaseShiftButton.Size = new Size(50, 35);
            increaseShiftButton.TabIndex = 10;
            increaseShiftButton.Text = "+";
            increaseShiftButton.UseVisualStyleBackColor = false;
            increaseShiftButton.Click += IncreaseShiftButton_Click;
            // 
            // shiftNumericUpDown
            // 
            shiftNumericUpDown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shiftNumericUpDown.Location = new Point(30, 220);
            shiftNumericUpDown.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            shiftNumericUpDown.Minimum = new decimal(new int[] { 25, 0, 0, int.MinValue });
            shiftNumericUpDown.Name = "shiftNumericUpDown";
            shiftNumericUpDown.ReadOnly = true;
            shiftNumericUpDown.Size = new Size(150, 29);
            shiftNumericUpDown.TabIndex = 9;
            shiftNumericUpDown.ValueChanged += shiftNumericUpDown_ValueChanged;
            // 
            // inputCodeButton
            // 
            inputCodeButton.Anchor = AnchorStyles.Top;
            inputCodeButton.BackColor = Color.SteelBlue;
            inputCodeButton.FlatAppearance.BorderSize = 0;
            inputCodeButton.FlatStyle = FlatStyle.Flat;
            inputCodeButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputCodeButton.ForeColor = Color.White;
            inputCodeButton.Location = new Point(498, 280);
            inputCodeButton.Name = "inputCodeButton";
            inputCodeButton.Size = new Size(150, 50);
            inputCodeButton.TabIndex = 8;
            inputCodeButton.Text = "InputCode";
            inputCodeButton.UseVisualStyleBackColor = false;
            inputCodeButton.Click += InputCodeButton_Click;
            // 
            // sortButton
            // 
            sortButton.Anchor = AnchorStyles.Top;
            sortButton.BackColor = Color.SteelBlue;
            sortButton.FlatAppearance.BorderSize = 0;
            sortButton.FlatStyle = FlatStyle.Flat;
            sortButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sortButton.ForeColor = Color.White;
            sortButton.Location = new Point(342, 280);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(150, 50);
            sortButton.TabIndex = 7;
            sortButton.Text = "Sort";
            sortButton.UseVisualStyleBackColor = false;
            sortButton.Click += SortButton_Click;
            // 
            // outputButton
            // 
            outputButton.Anchor = AnchorStyles.Top;
            outputButton.BackColor = Color.SteelBlue;
            outputButton.FlatAppearance.BorderSize = 0;
            outputButton.FlatStyle = FlatStyle.Flat;
            outputButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputButton.ForeColor = Color.White;
            outputButton.Location = new Point(186, 280);
            outputButton.Name = "outputButton";
            outputButton.Size = new Size(150, 50);
            outputButton.TabIndex = 6;
            outputButton.Text = "Output";
            outputButton.UseVisualStyleBackColor = false;
            outputButton.Click += OutputButton_Click;
            // 
            // encodeButton
            // 
            encodeButton.Anchor = AnchorStyles.Top;
            encodeButton.BackColor = Color.SteelBlue;
            encodeButton.FlatAppearance.BorderSize = 0;
            encodeButton.FlatStyle = FlatStyle.Flat;
            encodeButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            encodeButton.ForeColor = Color.White;
            encodeButton.Location = new Point(30, 280);
            encodeButton.Name = "encodeButton";
            encodeButton.Size = new Size(150, 50);
            encodeButton.TabIndex = 5;
            encodeButton.Text = "Print";
            encodeButton.UseVisualStyleBackColor = false;
            encodeButton.Click += EncodeButton_Click;
            // 
            // shiftLabel
            // 
            shiftLabel.AutoSize = true;
            shiftLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shiftLabel.Location = new Point(30, 190);
            shiftLabel.Name = "shiftLabel";
            shiftLabel.Size = new Size(165, 21);
            shiftLabel.TabIndex = 4;
            shiftLabel.Text = "Shift Value (-25 to 25):";
            // 
            // inputTextBox
            // 
            inputTextBox.CharacterCasing = CharacterCasing.Upper;
            inputTextBox.Dock = DockStyle.Top;
            inputTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputTextBox.Location = new Point(30, 83);
            inputTextBox.MaxLength = 40;
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.ScrollBars = ScrollBars.Vertical;
            inputTextBox.Size = new Size(784, 100);
            inputTextBox.TabIndex = 3;
            inputTextBox.TextChanged += InputTextBox_TextChanged;
            inputTextBox.KeyPress += InputTextBox_KeyPress;
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.Dock = DockStyle.Top;
            inputLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputLabel.Location = new Point(30, 62);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(152, 21);
            inputLabel.TabIndex = 2;
            inputLabel.Text = "Input Text (A-Z only):";
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Dock = DockStyle.Top;
            welcomeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.ForeColor = Color.SteelBlue;
            welcomeLabel.Location = new Point(30, 30);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(262, 32);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = "SP Cipher Application";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 600);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(816, 639);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SP Cipher Application";
            mainPanel.ResumeLayout(false);
            resultPanel.ResumeLayout(false);
            resultPanel.PerformLayout();
            inputPanel.ResumeLayout(false);
            inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shiftNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button copyResultButton;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Label characterCountLabel;
        private System.Windows.Forms.Button decreaseShiftButton;
        private System.Windows.Forms.Button increaseShiftButton;
        private System.Windows.Forms.NumericUpDown shiftNumericUpDown;
        private System.Windows.Forms.Button inputCodeButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private Button outputCodeButton;
        private ErrorProvider errorProvider1;
    }
}