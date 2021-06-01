namespace Match_Method
{
    partial class Variable
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
            this.label1 = new System.Windows.Forms.Label();
            this.variableUser = new System.Windows.Forms.NumericUpDown();
            this.OkeyBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.variableUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(110, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // variableUser
            // 
            this.variableUser.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.variableUser.DecimalPlaces = 2;
            this.variableUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variableUser.Location = new System.Drawing.Point(115, 106);
            this.variableUser.Name = "variableUser";
            this.variableUser.Size = new System.Drawing.Size(279, 30);
            this.variableUser.TabIndex = 1;
            // 
            // OkeyBtn
            // 
            this.OkeyBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkeyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkeyBtn.Location = new System.Drawing.Point(115, 154);
            this.OkeyBtn.Name = "OkeyBtn";
            this.OkeyBtn.Size = new System.Drawing.Size(129, 40);
            this.OkeyBtn.TabIndex = 2;
            this.OkeyBtn.Text = "Okey";
            this.OkeyBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.Location = new System.Drawing.Point(265, 154);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(129, 40);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // Variable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(568, 316);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkeyBtn);
            this.Controls.Add(this.variableUser);
            this.Controls.Add(this.label1);
            this.Name = "Variable";
            this.Text = "Ввод данных";
            ((System.ComponentModel.ISupportInitialize)(this.variableUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown variableUser;
        public System.Windows.Forms.Button OkeyBtn;
        public System.Windows.Forms.Button CancelBtn;
    }
}