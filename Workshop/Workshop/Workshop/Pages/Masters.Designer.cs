namespace Workshop.Pages
{
    partial class Masters
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
            EntranceTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)EntranceTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(509, 73);
            label1.Name = "label1";
            label1.Size = new Size(160, 48);
            label1.TabIndex = 2;
            label1.Text = "Мастера";
            // 
            // EntranceTable
            // 
            EntranceTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            EntranceTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            EntranceTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EntranceTable.Location = new Point(2, 147);
            EntranceTable.Name = "EntranceTable";
            EntranceTable.RowHeadersWidth = 62;
            EntranceTable.RowTemplate.Height = 33;
            EntranceTable.Size = new Size(1123, 318);
            EntranceTable.TabIndex = 3;
            // 
            // Masters
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 844);
            Controls.Add(EntranceTable);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Masters";
            Text = "Masters";
            ((System.ComponentModel.ISupportInitialize)EntranceTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView EntranceTable;
    }
}