namespace VariousTesting
{
	partial class TestingForm
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
			this.next = new System.Windows.Forms.Button();
			this.prev = new System.Windows.Forms.Button();
			this.count = new System.Windows.Forms.Label();
			this.question = new System.Windows.Forms.Label();
			this.time = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// next
			// 
			this.next.Location = new System.Drawing.Point(408, 236);
			this.next.Name = "next";
			this.next.Size = new System.Drawing.Size(80, 40);
			this.next.TabIndex = 0;
			this.next.Text = "Next";
			this.next.UseVisualStyleBackColor = true;
			this.next.Click += new System.EventHandler(this.Button_Click);
			// 
			// prev
			// 
			this.prev.Location = new System.Drawing.Point(12, 236);
			this.prev.Name = "prev";
			this.prev.Size = new System.Drawing.Size(80, 40);
			this.prev.TabIndex = 1;
			this.prev.Text = "Previous";
			this.prev.UseVisualStyleBackColor = true;
			this.prev.Click += new System.EventHandler(this.Button_Click);
			// 
			// count
			// 
			this.count.AutoSize = true;
			this.count.Location = new System.Drawing.Point(9, 9);
			this.count.Name = "count";
			this.count.Size = new System.Drawing.Size(46, 13);
			this.count.TabIndex = 2;
			this.count.Text = "<count>";
			// 
			// question
			// 
			this.question.Location = new System.Drawing.Point(9, 31);
			this.question.Name = "question";
			this.question.Size = new System.Drawing.Size(479, 26);
			this.question.TabIndex = 3;
			this.question.Text = "<question>";
			// 
			// time
			// 
			this.time.AutoSize = true;
			this.time.Location = new System.Drawing.Point(453, 9);
			this.time.Name = "time";
			this.time.Size = new System.Drawing.Size(38, 13);
			this.time.TabIndex = 4;
			this.time.Text = "<time>";
			// 
			// TestingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 288);
			this.Controls.Add(this.time);
			this.Controls.Add(this.question);
			this.Controls.Add(this.count);
			this.Controls.Add(this.prev);
			this.Controls.Add(this.next);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "TestingForm";
			this.Text = "Test";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button next;
		private System.Windows.Forms.Button prev;
		private System.Windows.Forms.Label count;
		private System.Windows.Forms.Label question;
		private System.Windows.Forms.Label time;
	}
}
