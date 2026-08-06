namespace StockAPP.Views.RegisterForm
{
    partial class RegisterDialog
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            numericAmount = new NumericUpDown();
            label5 = new Label();
            dateTimePickerValidate = new DateTimePicker();
            btnRegister = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericAmount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(23, 31);
            label1.Name = "label1";
            label1.Size = new Size(148, 21);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Produto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(23, 105);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(183, 105);
            label3.Name = "label3";
            label3.Size = new Size(125, 19);
            label3.TabIndex = 3;
            label3.Text = "Cod. Fabrica (EAN):";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 23);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(342, 105);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 5;
            label4.Text = "Unidade:";
            // 
            // numericAmount
            // 
            numericAmount.Location = new Point(342, 128);
            numericAmount.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericAmount.Name = "numericAmount";
            numericAmount.Size = new Size(125, 23);
            numericAmount.TabIndex = 6;
            numericAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(506, 105);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 7;
            label5.Text = "Validade:";
            // 
            // dateTimePickerValidate
            // 
            dateTimePickerValidate.Format = DateTimePickerFormat.Short;
            dateTimePickerValidate.Location = new Point(506, 128);
            dateTimePickerValidate.Name = "dateTimePickerValidate";
            dateTimePickerValidate.Size = new Size(125, 23);
            dateTimePickerValidate.TabIndex = 8;
            // 
            // btnRegister
            // 
            btnRegister.DialogResult = DialogResult.OK;
            btnRegister.Location = new Point(447, 229);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Cadastrar";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(556, 229);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // RegisterDialog
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(655, 264);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(dateTimePickerValidate);
            Controls.Add(label5);
            Controls.Add(numericAmount);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)numericAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private NumericUpDown numericAmount;
        private Label label5;
        private DateTimePicker dateTimePickerValidate;
        private Button btnRegister;
        private Button btnCancel;
    }
}