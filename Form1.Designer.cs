
namespace MajorProject1_final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.loanAmountInput = new System.Windows.Forms.TextBox();
            this.annualAPRselect = new System.Windows.Forms.ComboBox();
            this.rebateInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.acceptLoanButton = new System.Windows.Forms.Button();
            this.displayAllLoansButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.totalInterestOutput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.totalLoansOutput = new System.Windows.Forms.TextBox();
            this.monthview = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.interestView = new System.Windows.Forms.ListView();
            this.label11 = new System.Windows.Forms.Label();
            this.principleView = new System.Windows.Forms.ListView();
            this.label12 = new System.Windows.Forms.Label();
            this.paymentView = new System.Windows.Forms.ListView();
            this.Hello = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label13 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Academic and Industry Collaboration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle Loan Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1058, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loan Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Annual APR%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rebate?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(83, 303);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(28, 27);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(CheckBox1_Changed);
            // 
            // loanAmountInput
            // 
            this.loanAmountInput.Location = new System.Drawing.Point(251, 190);
            this.loanAmountInput.Name = "loanAmountInput";
            this.loanAmountInput.Size = new System.Drawing.Size(100, 31);
            this.loanAmountInput.TabIndex = 7;
            this.loanAmountInput.TextChanged += new System.EventHandler(OnTextChanged);

            // 
            // annualAPRselect
            // 
            this.annualAPRselect.FormattingEnabled = true;
            this.annualAPRselect.Location = new System.Drawing.Point(251, 248);
            this.annualAPRselect.Name = "annualAPRselect";
            this.annualAPRselect.Size = new System.Drawing.Size(121, 33);
            this.annualAPRselect.TabIndex = 8;
            this.annualAPRselect.TextChanged += new System.EventHandler(OnTextChanged);
            // 
            // rebateInput
            // 
            this.rebateInput.Location = new System.Drawing.Point(251, 303);
            this.rebateInput.Name = "rebateInput";
            this.rebateInput.Size = new System.Drawing.Size(100, 31);
            this.rebateInput.TabIndex = 9;
            this.rebateInput.TextChanged += new System.EventHandler(OnTextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Loan Months";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(518, 244);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(55, 29);
            this.radioButton6.TabIndex = 11;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "6";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(onRadioButtonCheckedChanged);
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Location = new System.Drawing.Point(612, 244);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(67, 29);
            this.radioButton18.TabIndex = 12;
            this.radioButton18.TabStop = true;
            this.radioButton18.Text = "18";
            this.radioButton18.UseVisualStyleBackColor = true; 
            this.radioButton18.CheckedChanged += new System.EventHandler(onRadioButtonCheckedChanged);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(518, 304);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(67, 29);
            this.radioButton12.TabIndex = 13;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "12";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(onRadioButtonCheckedChanged);
            // 
            // radioButton24
            // 
            this.radioButton24.AutoSize = true;
            this.radioButton24.Location = new System.Drawing.Point(612, 305);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(67, 29);
            this.radioButton24.TabIndex = 14;
            this.radioButton24.TabStop = true;
            this.radioButton24.Text = "24";
            this.radioButton24.UseVisualStyleBackColor = true;
            this.radioButton24.CheckedChanged += new System.EventHandler(onRadioButtonCheckedChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(1036, 249);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(148, 76);
            this.calculateButton.TabIndex = 15;
            this.calculateButton.Text = "Calculate Loan";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(CalculateButton_Click);
            // 
            // acceptLoanButton
            // 
            this.acceptLoanButton.Location = new System.Drawing.Point(1036, 332);
            this.acceptLoanButton.Name = "acceptLoanButton";
            this.acceptLoanButton.Size = new System.Drawing.Size(148, 81);
            this.acceptLoanButton.TabIndex = 16;
            this.acceptLoanButton.Text = "Accept Loan";
            this.acceptLoanButton.UseVisualStyleBackColor = true;
            this.acceptLoanButton.Click += new System.EventHandler(onAcceptLoanClicked);
            // 
            // displayAllLoansButton
            // 
            this.displayAllLoansButton.Location = new System.Drawing.Point(1036, 419);
            this.displayAllLoansButton.Name = "displayAllLoansButton";
            this.displayAllLoansButton.Size = new System.Drawing.Size(148, 84);
            this.displayAllLoansButton.TabIndex = 17;
            this.displayAllLoansButton.Text = "Display All Loans";
            this.displayAllLoansButton.UseVisualStyleBackColor = true;
            this.displayAllLoansButton.Click += new System.EventHandler(onDisplayAllLoansClicked);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1036, 509);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(148, 62);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1031, 593);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Total Interest:";
            // 
            // totalInterestOutput
            // 
            this.totalInterestOutput.Location = new System.Drawing.Point(1036, 621);
            this.totalInterestOutput.Name = "totalInterestOutput";
            this.totalInterestOutput.Size = new System.Drawing.Size(186, 31);
            this.totalInterestOutput.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1033, 677);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total loans:";
            // 
            // totalLoansOutput
            // 
            this.totalLoansOutput.Location = new System.Drawing.Point(1036, 705);
            this.totalLoansOutput.Name = "totalLoansOutput";
            this.totalLoansOutput.Size = new System.Drawing.Size(186, 31);
            this.totalLoansOutput.TabIndex = 22;
            // 
            // monthview
            // 
            this.monthview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Hello});
            this.monthview.HideSelection = false;
            this.monthview.Location = new System.Drawing.Point(83, 462);
            this.monthview.Name = "monthview";
            this.monthview.Size = new System.Drawing.Size(134, 310);
            this.monthview.TabIndex = 24;
            this.monthview.UseCompatibleStateImageBehavior = false;
            
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Month";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(268, 419);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Interest";
            // 
            // interestView
            // 
            this.interestView.HideSelection = false;
            this.interestView.Location = new System.Drawing.Point(251, 462);
            this.interestView.Name = "interestView";
            this.interestView.Size = new System.Drawing.Size(121, 310);
            this.interestView.TabIndex = 27;
            this.interestView.UseCompatibleStateImageBehavior = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 419);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Principle";
            // 
            // principleView
            // 
            this.principleView.HideSelection = false;
            this.principleView.Location = new System.Drawing.Point(413, 462);
            this.principleView.Name = "principleView";
            this.principleView.Size = new System.Drawing.Size(121, 310);
            this.principleView.TabIndex = 29;
            this.principleView.UseCompatibleStateImageBehavior = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(595, 419);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "Payment";
            // 
            // paymentView
            // 
            this.paymentView.HideSelection = false;
            this.paymentView.Location = new System.Drawing.Point(582, 462);
            this.paymentView.Name = "paymentView";
            this.paymentView.Size = new System.Drawing.Size(121, 310);
            this.paymentView.TabIndex = 31;
            this.paymentView.UseCompatibleStateImageBehavior = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(759, 419);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "Balance";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(750, 462);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 310);
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 869);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.paymentView);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.principleView);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.interestView);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.monthview);
            this.Controls.Add(this.totalLoansOutput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.totalInterestOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayAllLoansButton);
            this.Controls.Add(this.acceptLoanButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.radioButton24);
            this.Controls.Add(this.radioButton12);
            this.Controls.Add(this.radioButton18);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rebateInput);
            this.Controls.Add(this.annualAPRselect);
            this.Controls.Add(this.loanAmountInput);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox loanAmountInput;
        private System.Windows.Forms.ComboBox annualAPRselect;
        private System.Windows.Forms.TextBox rebateInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton24;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button acceptLoanButton;
        private System.Windows.Forms.Button displayAllLoansButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalInterestOutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totalLoansOutput;
        private System.Windows.Forms.ListView monthview;
        private System.Windows.Forms.ColumnHeader Hello;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView interestView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView principleView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView paymentView;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listView1;
    }
}

