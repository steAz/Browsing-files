namespace przegladaniePlikow
{
    partial class Form2
    {
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.CheckBox checkBoxII;
        private System.Windows.Forms.CheckBox checkBoxIII;
        private System.Windows.Forms.CheckBox checkBoxIV;
        private System.Windows.Forms.RadioButton radioButton;
        private System.Windows.Forms.RadioButton radioButtonII;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button buttonII;
        private System.Windows.Forms.Label nameLabel;

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

            this.checkBox = new System.Windows.Forms.CheckBox();
            this.checkBoxII = new System.Windows.Forms.CheckBox();
            this.checkBoxIII = new System.Windows.Forms.CheckBox();
            this.checkBoxIV = new System.Windows.Forms.CheckBox();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.radioButtonII = new System.Windows.Forms.RadioButton();
            this.button = new System.Windows.Forms.Button();
            this.buttonII = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.checkBoxIV);
            this.Controls.Add(this.checkBoxIII);
            this.Controls.Add(this.checkBoxII);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.radioButtonII);
            this.Controls.Add(this.radioButton);
            this.Controls.Add(this.button);
            this.Controls.Add(this.buttonII);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";

            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(54, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;

            //
            // button
            //
            this.button.AutoSize = true;
            this.button.Location = new System.Drawing.Point(10, 160);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(20, 10);
            this.button.Text = "OK";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.buttonOK_Click);

            //
            // buttonII
            //
            this.buttonII.AutoSize = true;
            this.buttonII.Location = new System.Drawing.Point(40, 160);
            this.buttonII.Name = "buttonII";
            this.buttonII.Size = new System.Drawing.Size(20, 10);
            this.buttonII.Text = "Cancel";
            this.buttonII.UseVisualStyleBackColor = true;
            this.buttonII.Click += new System.EventHandler(this.buttonCancel_Click);

            // 
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.Location = new System.Drawing.Point(4, 8);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(20, 10);
            this.radioButton.TabIndex = 0;
            this.radioButton.TabStop = true;
            this.radioButton.Text = "File";
            this.radioButton.UseVisualStyleBackColor = true;
            // 
            // radioButtonII
            // 
            this.radioButtonII.AutoSize = true;
            this.radioButtonII.Location = new System.Drawing.Point(4, 28);
            this.radioButtonII.Name = "radioButtonII";
            this.radioButtonII.Size = new System.Drawing.Size(20, 10);
            this.radioButtonII.TabIndex = 1;
            this.radioButtonII.TabStop = true;
            this.radioButtonII.Text = "Directory";
            this.radioButtonII.UseVisualStyleBackColor = true;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(10, 60);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(50, 10);
            this.checkBox.TabIndex = 2;
            this.checkBox.Text = "Read only";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // checkBoxII
            // 
            this.checkBoxII.AutoSize = true;
            this.checkBoxII.Location = new System.Drawing.Point(10, 80);
            this.checkBoxII.Name = "checkBoxII";
            this.checkBoxII.Size = new System.Drawing.Size(50, 10);
            this.checkBoxII.TabIndex = 3;
            this.checkBoxII.Text = "Archive";
            this.checkBoxII.UseVisualStyleBackColor = true;
            // 
            // checkBoxIII
            // 
            this.checkBoxIII.AutoSize = true;
            this.checkBoxIII.Location = new System.Drawing.Point(10, 100);
            this.checkBoxIII.Name = "checkBoxIII";
            this.checkBoxIII.Size = new System.Drawing.Size(50, 10);
            this.checkBoxIII.TabIndex = 4;
            this.checkBoxIII.Text = "Hidden";
            this.checkBoxIII.UseVisualStyleBackColor = true;
            // 
            // checkBoxIV
            // 
            this.checkBoxIV.AutoSize = true;
            this.checkBoxIV.Location = new System.Drawing.Point(10, 120);
            this.checkBoxIV.Name = "checkBoxIV";
            this.checkBoxIV.Size = new System.Drawing.Size(50, 10);
            this.checkBoxIV.TabIndex = 5;
            this.checkBoxIV.Text = "System";
            this.checkBoxIV.UseVisualStyleBackColor = true;
          
            


        }

        #endregion
    }
}