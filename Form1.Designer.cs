namespace z_weather_app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblCityName = new Label();
            txtCityName = new TextBox();
            lblDegreeUnit = new Label();
            txtDegreeUnit = new TextBox();
            lblWindUnit = new Label();
            txtWindUnit = new TextBox();
            lblPrecipitationUnit = new Label();
            txtPrecipitationUnit = new TextBox();
            btnExit = new Button();
            btnClear = new Button();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // lblCityName
            // 
            lblCityName.AutoSize = true;
            lblCityName.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCityName.Location = new Point(12, 9);
            lblCityName.Name = "lblCityName";
            lblCityName.Size = new Size(157, 23);
            lblCityName.TabIndex = 0;
            lblCityName.Text = "Name of City:";
            // 
            // txtCityName
            // 
            txtCityName.BorderStyle = BorderStyle.FixedSingle;
            txtCityName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCityName.Location = new Point(175, 9);
            txtCityName.Multiline = true;
            txtCityName.Name = "txtCityName";
            txtCityName.Size = new Size(165, 23);
            txtCityName.TabIndex = 1;
            txtCityName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDegreeUnit
            // 
            lblDegreeUnit.AutoSize = true;
            lblDegreeUnit.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDegreeUnit.Location = new Point(76, 56);
            lblDegreeUnit.Name = "lblDegreeUnit";
            lblDegreeUnit.Size = new Size(93, 23);
            lblDegreeUnit.TabIndex = 2;
            lblDegreeUnit.Text = "C° / F°:";
            // 
            // txtDegreeUnit
            // 
            txtDegreeUnit.BorderStyle = BorderStyle.FixedSingle;
            txtDegreeUnit.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDegreeUnit.Location = new Point(175, 56);
            txtDegreeUnit.Multiline = true;
            txtDegreeUnit.Name = "txtDegreeUnit";
            txtDegreeUnit.Size = new Size(165, 23);
            txtDegreeUnit.TabIndex = 2;
            txtDegreeUnit.TextAlign = HorizontalAlignment.Center;
            // 
            // lblWindUnit
            // 
            lblWindUnit.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWindUnit.Location = new Point(12, 97);
            lblWindUnit.Name = "lblWindUnit";
            lblWindUnit.Size = new Size(157, 48);
            lblWindUnit.TabIndex = 4;
            lblWindUnit.Text = "Wind Speed Unit:";
            lblWindUnit.TextAlign = ContentAlignment.BottomRight;
            // 
            // txtWindUnit
            // 
            txtWindUnit.BorderStyle = BorderStyle.FixedSingle;
            txtWindUnit.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWindUnit.Location = new Point(175, 110);
            txtWindUnit.Multiline = true;
            txtWindUnit.Name = "txtWindUnit";
            txtWindUnit.Size = new Size(165, 23);
            txtWindUnit.TabIndex = 3;
            txtWindUnit.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPrecipitationUnit
            // 
            lblPrecipitationUnit.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecipitationUnit.Location = new Point(12, 160);
            lblPrecipitationUnit.Name = "lblPrecipitationUnit";
            lblPrecipitationUnit.Size = new Size(157, 48);
            lblPrecipitationUnit.TabIndex = 6;
            lblPrecipitationUnit.Text = "Precipitation Unit:";
            lblPrecipitationUnit.TextAlign = ContentAlignment.BottomRight;
            // 
            // txtPrecipitationUnit
            // 
            txtPrecipitationUnit.BorderStyle = BorderStyle.FixedSingle;
            txtPrecipitationUnit.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecipitationUnit.Location = new Point(175, 174);
            txtPrecipitationUnit.Multiline = true;
            txtPrecipitationUnit.Name = "txtPrecipitationUnit";
            txtPrecipitationUnit.Size = new Size(165, 23);
            txtPrecipitationUnit.TabIndex = 4;
            txtPrecipitationUnit.TextAlign = HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(130, 393);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(89, 30);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(130, 326);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(89, 30);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(114, 262);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(124, 30);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(185, 165, 194);
            ClientSize = new Size(376, 450);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(txtPrecipitationUnit);
            Controls.Add(lblPrecipitationUnit);
            Controls.Add(txtWindUnit);
            Controls.Add(lblWindUnit);
            Controls.Add(txtDegreeUnit);
            Controls.Add(lblDegreeUnit);
            Controls.Add(txtCityName);
            Controls.Add(lblCityName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Weather App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCityName;
        private TextBox txtCityName;
        private Label lblDegreeUnit;
        private TextBox txtDegreeUnit;
        private Label lblWindUnit;
        private TextBox txtWindUnit;
        private Label lblPrecipitationUnit;
        private TextBox txtPrecipitationUnit;
        private Button btnExit;
        private Button btnClear;
        private Button btnCalculate;
    }
}
