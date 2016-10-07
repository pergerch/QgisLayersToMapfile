namespace QgisLayersToMapfile
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtQlr = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.txtMap = new System.Windows.Forms.TextBox();
			this.txtNameData = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name;Data";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 378);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Result";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "QLR";
			// 
			// txtQlr
			// 
			this.txtQlr.AcceptsReturn = true;
			this.txtQlr.AcceptsTab = true;
			this.txtQlr.Location = new System.Drawing.Point(102, 191);
			this.txtQlr.Multiline = true;
			this.txtQlr.Name = "txtQlr";
			this.txtQlr.Size = new System.Drawing.Size(501, 178);
			this.txtQlr.TabIndex = 5;
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(609, 325);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(42, 47);
			this.btnOk.TabIndex = 6;
			this.btnOk.Text = "GO!";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// txtMap
			// 
			this.txtMap.AcceptsReturn = true;
			this.txtMap.AcceptsTab = true;
			this.txtMap.Location = new System.Drawing.Point(102, 375);
			this.txtMap.Multiline = true;
			this.txtMap.Name = "txtMap";
			this.txtMap.Size = new System.Drawing.Size(549, 178);
			this.txtMap.TabIndex = 7;
			// 
			// txtNameData
			// 
			this.txtNameData.AcceptsReturn = true;
			this.txtNameData.AcceptsTab = true;
			this.txtNameData.Location = new System.Drawing.Point(102, 7);
			this.txtNameData.Multiline = true;
			this.txtNameData.Name = "txtNameData";
			this.txtNameData.Size = new System.Drawing.Size(549, 178);
			this.txtNameData.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(670, 567);
			this.Controls.Add(this.txtNameData);
			this.Controls.Add(this.txtMap);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.txtQlr);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtQlr;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.TextBox txtMap;
		private System.Windows.Forms.TextBox txtNameData;
	}
}

