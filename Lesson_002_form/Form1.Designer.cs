
namespace Lesson_002_form
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
            this.lblMinValName = new System.Windows.Forms.Label();
            this.lblMaxValName = new System.Windows.Forms.Label();
            this.lblMinVal = new System.Windows.Forms.Label();
            this.lblMaxVal = new System.Windows.Forms.Label();
            this.btnByte = new System.Windows.Forms.Button();
            this.btnSbyte = new System.Windows.Forms.Button();
            this.btnShort = new System.Windows.Forms.Button();
            this.btnUshort = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.bUint = new System.Windows.Forms.Button();
            this.btnLong = new System.Windows.Forms.Button();
            this.btnUlong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMinValName
            // 
            this.lblMinValName.AutoSize = true;
            this.lblMinValName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinValName.Location = new System.Drawing.Point(24, 59);
            this.lblMinValName.Name = "lblMinValName";
            this.lblMinValName.Size = new System.Drawing.Size(101, 28);
            this.lblMinValName.TabIndex = 0;
            this.lblMinValName.Text = "Min value:";
            // 
            // lblMaxValName
            // 
            this.lblMaxValName.AutoSize = true;
            this.lblMaxValName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaxValName.Location = new System.Drawing.Point(385, 59);
            this.lblMaxValName.Name = "lblMaxValName";
            this.lblMaxValName.Size = new System.Drawing.Size(104, 28);
            this.lblMaxValName.TabIndex = 1;
            this.lblMaxValName.Text = "Max value:";
            // 
            // lblMinVal
            // 
            this.lblMinVal.AutoSize = true;
            this.lblMinVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinVal.Location = new System.Drawing.Point(131, 59);
            this.lblMinVal.Name = "lblMinVal";
            this.lblMinVal.Size = new System.Drawing.Size(17, 28);
            this.lblMinVal.TabIndex = 2;
            this.lblMinVal.Text = " ";
            // 
            // lblMaxVal
            // 
            this.lblMaxVal.AutoSize = true;
            this.lblMaxVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaxVal.Location = new System.Drawing.Point(495, 59);
            this.lblMaxVal.Name = "lblMaxVal";
            this.lblMaxVal.Size = new System.Drawing.Size(17, 28);
            this.lblMaxVal.TabIndex = 3;
            this.lblMaxVal.Text = " ";
            // 
            // btnByte
            // 
            this.btnByte.Location = new System.Drawing.Point(24, 113);
            this.btnByte.Name = "btnByte";
            this.btnByte.Size = new System.Drawing.Size(112, 34);
            this.btnByte.TabIndex = 4;
            this.btnByte.Text = "byte";
            this.btnByte.UseVisualStyleBackColor = true;
            this.btnByte.Click += new System.EventHandler(this.btnByte_Click);
            // 
            // btnSbyte
            // 
            this.btnSbyte.Location = new System.Drawing.Point(216, 113);
            this.btnSbyte.Name = "btnSbyte";
            this.btnSbyte.Size = new System.Drawing.Size(112, 34);
            this.btnSbyte.TabIndex = 4;
            this.btnSbyte.Text = "sbyte";
            this.btnSbyte.UseVisualStyleBackColor = true;
            this.btnSbyte.Click += new System.EventHandler(this.btnSbyte_Click);
            // 
            // btnShort
            // 
            this.btnShort.Location = new System.Drawing.Point(405, 113);
            this.btnShort.Name = "btnShort";
            this.btnShort.Size = new System.Drawing.Size(112, 34);
            this.btnShort.TabIndex = 4;
            this.btnShort.Text = "short";
            this.btnShort.UseVisualStyleBackColor = true;
            this.btnShort.Click += new System.EventHandler(this.btnShort_Click);
            // 
            // btnUshort
            // 
            this.btnUshort.Location = new System.Drawing.Point(600, 113);
            this.btnUshort.Name = "btnUshort";
            this.btnUshort.Size = new System.Drawing.Size(112, 34);
            this.btnUshort.TabIndex = 4;
            this.btnUshort.Text = "ushort";
            this.btnUshort.UseVisualStyleBackColor = true;
            this.btnUshort.Click += new System.EventHandler(this.btnUshort_Click);
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(24, 178);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(112, 34);
            this.btnInt.TabIndex = 4;
            this.btnInt.Text = "int";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // bUint
            // 
            this.bUint.Location = new System.Drawing.Point(216, 178);
            this.bUint.Name = "bUint";
            this.bUint.Size = new System.Drawing.Size(112, 34);
            this.bUint.TabIndex = 4;
            this.bUint.Text = "uint";
            this.bUint.UseVisualStyleBackColor = true;
            this.bUint.Click += new System.EventHandler(this.bUint_Click);
            // 
            // btnLong
            // 
            this.btnLong.Location = new System.Drawing.Point(405, 178);
            this.btnLong.Name = "btnLong";
            this.btnLong.Size = new System.Drawing.Size(112, 34);
            this.btnLong.TabIndex = 4;
            this.btnLong.Text = "long";
            this.btnLong.UseVisualStyleBackColor = true;
            this.btnLong.Click += new System.EventHandler(this.btnLong_Click);
            // 
            // btnUlong
            // 
            this.btnUlong.Location = new System.Drawing.Point(600, 178);
            this.btnUlong.Name = "btnUlong";
            this.btnUlong.Size = new System.Drawing.Size(112, 34);
            this.btnUlong.TabIndex = 4;
            this.btnUlong.Text = "ulong";
            this.btnUlong.UseVisualStyleBackColor = true;
            this.btnUlong.Click += new System.EventHandler(this.btnUlong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(339, 9);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(21, 32);
            this.lblType.TabIndex = 2;
            this.lblType.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 242);
            this.Controls.Add(this.btnUlong);
            this.Controls.Add(this.btnUshort);
            this.Controls.Add(this.btnLong);
            this.Controls.Add(this.bUint);
            this.Controls.Add(this.btnShort);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btnSbyte);
            this.Controls.Add(this.btnByte);
            this.Controls.Add(this.lblMaxVal);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblMinVal);
            this.Controls.Add(this.lblMaxValName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMinValName);
            this.Name = "Form1";
            this.Text = "Lesson 002";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinValName;
        private System.Windows.Forms.Label lblMaxValName;
        private System.Windows.Forms.Label lblMinVal;
        private System.Windows.Forms.Label lblMaxVal;
        private System.Windows.Forms.Button btnByte;
        private System.Windows.Forms.Button btnSbyte;
        private System.Windows.Forms.Button btnShort;
        private System.Windows.Forms.Button btnUshort;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button bUint;
        private System.Windows.Forms.Button btnLong;
        private System.Windows.Forms.Button btnUlong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblType;
    }
}

