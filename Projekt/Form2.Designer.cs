namespace Projekt
{
	partial class Form2
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
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.chbIsActive = new System.Windows.Forms.CheckBox();
			this.cbxContractorType = new System.Windows.Forms.ComboBox();
			this.tbxContractorName = new System.Windows.Forms.TextBox();
			this.tbxNIP = new System.Windows.Forms.TextBox();
			this.tbxDescription = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Underline);
			this.label1.Location = new System.Drawing.Point(13, 25);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(206, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Dodaj / Edytuj kontrahenta";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.label2.Location = new System.Drawing.Point(10, 72);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nazwa kontrahenta";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.label3.Location = new System.Drawing.Point(10, 144);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "NIP";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.label4.Location = new System.Drawing.Point(10, 237);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Typ kontrahenta";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.label5.Location = new System.Drawing.Point(10, 323);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 17);
			this.label5.TabIndex = 5;
			this.label5.Text = "Opis firmy";
			// 
			// chbIsActive
			// 
			this.chbIsActive.AutoSize = true;
			this.chbIsActive.CheckAlign = System.Drawing.ContentAlignment.TopRight;
			this.chbIsActive.Checked = true;
			this.chbIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.chbIsActive.Location = new System.Drawing.Point(12, 407);
			this.chbIsActive.Name = "chbIsActive";
			this.chbIsActive.Size = new System.Drawing.Size(151, 21);
			this.chbIsActive.TabIndex = 6;
			this.chbIsActive.Text = "Kontrahent aktywny";
			this.chbIsActive.UseVisualStyleBackColor = true;
			// 
			// cbxContractorType
			// 
			this.cbxContractorType.FormattingEnabled = true;
			this.cbxContractorType.Items.AddRange(new object[] {
            "Klient",
            "Potencjalny klient"});
			this.cbxContractorType.Location = new System.Drawing.Point(150, 233);
			this.cbxContractorType.Name = "cbxContractorType";
			this.cbxContractorType.Size = new System.Drawing.Size(121, 21);
			this.cbxContractorType.TabIndex = 7;
			// 
			// tbxContractorName
			// 
			this.tbxContractorName.Location = new System.Drawing.Point(148, 72);
			this.tbxContractorName.Name = "tbxContractorName";
			this.tbxContractorName.Size = new System.Drawing.Size(323, 20);
			this.tbxContractorName.TabIndex = 8;
			// 
			// tbxNIP
			// 
			this.tbxNIP.Location = new System.Drawing.Point(148, 144);
			this.tbxNIP.Name = "tbxNIP";
			this.tbxNIP.Size = new System.Drawing.Size(323, 20);
			this.tbxNIP.TabIndex = 9;
			// 
			// tbxDescription
			// 
			this.tbxDescription.Location = new System.Drawing.Point(148, 320);
			this.tbxDescription.Multiline = true;
			this.tbxDescription.Name = "tbxDescription";
			this.tbxDescription.Size = new System.Drawing.Size(323, 63);
			this.tbxDescription.TabIndex = 10;
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnSave.Location = new System.Drawing.Point(587, 389);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(158, 39);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Zapisz";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tbxDescription);
			this.Controls.Add(this.tbxNIP);
			this.Controls.Add(this.tbxContractorName);
			this.Controls.Add(this.cbxContractorType);
			this.Controls.Add(this.chbIsActive);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chbIsActive;
		private System.Windows.Forms.ComboBox cbxContractorType;
		private System.Windows.Forms.TextBox tbxContractorName;
		private System.Windows.Forms.TextBox tbxNIP;
		private System.Windows.Forms.TextBox tbxDescription;
		private System.Windows.Forms.Button btnSave;
	}
}