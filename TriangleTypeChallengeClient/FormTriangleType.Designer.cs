namespace TriangleTypeChallengeClient
{
    partial class FormTriangleType
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
            this.LabelTriangleTypeResult = new System.Windows.Forms.Label();
            this.labelTriangleType = new System.Windows.Forms.Label();
            this.lblTriangleBase = new System.Windows.Forms.Label();
            this.lblTriangleWidth = new System.Windows.Forms.Label();
            this.lblTriangleHeight = new System.Windows.Forms.Label();
            this.TextBoxTriangleBase = new System.Windows.Forms.TextBox();
            this.TextBoxTriangleWidth = new System.Windows.Forms.TextBox();
            this.TextBoxTriangleHeight = new System.Windows.Forms.TextBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTriangleTypeResult
            // 
            this.LabelTriangleTypeResult.AutoSize = true;
            this.LabelTriangleTypeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTriangleTypeResult.Location = new System.Drawing.Point(188, 317);
            this.LabelTriangleTypeResult.Name = "LabelTriangleTypeResult";
            this.LabelTriangleTypeResult.Size = new System.Drawing.Size(33, 25);
            this.LabelTriangleTypeResult.TabIndex = 17;
            this.LabelTriangleTypeResult.Text = "...";
            // 
            // labelTriangleType
            // 
            this.labelTriangleType.AutoSize = true;
            this.labelTriangleType.Location = new System.Drawing.Point(31, 317);
            this.labelTriangleType.Name = "labelTriangleType";
            this.labelTriangleType.Size = new System.Drawing.Size(156, 25);
            this.labelTriangleType.TabIndex = 16;
            this.labelTriangleType.Text = "Triangle Type: ";
            // 
            // lblTriangleBase
            // 
            this.lblTriangleBase.AutoSize = true;
            this.lblTriangleBase.Location = new System.Drawing.Point(556, 117);
            this.lblTriangleBase.Name = "lblTriangleBase";
            this.lblTriangleBase.Size = new System.Drawing.Size(61, 25);
            this.lblTriangleBase.TabIndex = 15;
            this.lblTriangleBase.Text = "Base";
            // 
            // lblTriangleWidth
            // 
            this.lblTriangleWidth.AutoSize = true;
            this.lblTriangleWidth.Location = new System.Drawing.Point(301, 114);
            this.lblTriangleWidth.Name = "lblTriangleWidth";
            this.lblTriangleWidth.Size = new System.Drawing.Size(67, 25);
            this.lblTriangleWidth.TabIndex = 14;
            this.lblTriangleWidth.Text = "Width";
            // 
            // lblTriangleHeight
            // 
            this.lblTriangleHeight.AutoSize = true;
            this.lblTriangleHeight.Location = new System.Drawing.Point(28, 111);
            this.lblTriangleHeight.Name = "lblTriangleHeight";
            this.lblTriangleHeight.Size = new System.Drawing.Size(74, 25);
            this.lblTriangleHeight.TabIndex = 13;
            this.lblTriangleHeight.Text = "Height";
            // 
            // TextBoxTriangleBase
            // 
            this.TextBoxTriangleBase.Location = new System.Drawing.Point(623, 114);
            this.TextBoxTriangleBase.Name = "TextBoxTriangleBase";
            this.TextBoxTriangleBase.Size = new System.Drawing.Size(150, 31);
            this.TextBoxTriangleBase.TabIndex = 12;
            this.TextBoxTriangleBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxTriangleWidth
            // 
            this.TextBoxTriangleWidth.Location = new System.Drawing.Point(374, 114);
            this.TextBoxTriangleWidth.Name = "TextBoxTriangleWidth";
            this.TextBoxTriangleWidth.Size = new System.Drawing.Size(150, 31);
            this.TextBoxTriangleWidth.TabIndex = 11;
            this.TextBoxTriangleWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxTriangleHeight
            // 
            this.TextBoxTriangleHeight.Location = new System.Drawing.Point(108, 109);
            this.TextBoxTriangleHeight.Name = "TextBoxTriangleHeight";
            this.TextBoxTriangleHeight.Size = new System.Drawing.Size(150, 31);
            this.TextBoxTriangleHeight.TabIndex = 10;
            this.TextBoxTriangleHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(328, 201);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(135, 62);
            this.ButtonSubmit.TabIndex = 9;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // FormTriangleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.LabelTriangleTypeResult);
            this.Controls.Add(this.labelTriangleType);
            this.Controls.Add(this.lblTriangleBase);
            this.Controls.Add(this.lblTriangleWidth);
            this.Controls.Add(this.lblTriangleHeight);
            this.Controls.Add(this.TextBoxTriangleBase);
            this.Controls.Add(this.TextBoxTriangleWidth);
            this.Controls.Add(this.TextBoxTriangleHeight);
            this.Controls.Add(this.ButtonSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormTriangleType";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triangle Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTriangleTypeResult;
        private System.Windows.Forms.Label labelTriangleType;
        private System.Windows.Forms.Label lblTriangleBase;
        private System.Windows.Forms.Label lblTriangleWidth;
        private System.Windows.Forms.Label lblTriangleHeight;
        private System.Windows.Forms.TextBox TextBoxTriangleBase;
        private System.Windows.Forms.TextBox TextBoxTriangleWidth;
        private System.Windows.Forms.TextBox TextBoxTriangleHeight;
        private System.Windows.Forms.Button ButtonSubmit;
    }
}

