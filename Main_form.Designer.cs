namespace EngineNum_match_validator
{
    partial class Main_form
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            DGW_Main = new DataGridView();
            dBAdressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            purposeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pLCDBBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)DGW_Main).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pLCDBBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Cross;
            button1.FlatAppearance.BorderColor = Color.LightCoral;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseDownBackColor = Color.Cyan;
            button1.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(12, 483);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(192, 103);
            button1.TabIndex = 0;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Cross;
            button2.FlatAppearance.BorderColor = Color.LightCoral;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatAppearance.MouseDownBackColor = Color.Cyan;
            button2.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(12, 119);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(192, 102);
            button2.TabIndex = 1;
            button2.Text = "Connect PLC";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Cross;
            button3.FlatAppearance.BorderColor = Color.LightCoral;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatAppearance.MouseDownBackColor = Color.Cyan;
            button3.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(12, 229);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(192, 102);
            button3.TabIndex = 2;
            button3.Text = "Disconnect PLC";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 55);
            label1.Name = "label1";
            label1.Size = new Size(91, 46);
            label1.TabIndex = 3;
            label1.Text = "CON";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Cross;
            button4.FlatAppearance.BorderColor = Color.LightCoral;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatAppearance.MouseDownBackColor = Color.Cyan;
            button4.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(41, 353);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(119, 96);
            button4.TabIndex = 4;
            button4.Text = "READ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // DGW_Main
            // 
            DGW_Main.AllowUserToAddRows = false;
            DGW_Main.AllowUserToDeleteRows = false;
            DGW_Main.AllowUserToOrderColumns = true;
            DGW_Main.AutoGenerateColumns = false;
            DGW_Main.BackgroundColor = Color.Black;
            DGW_Main.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGW_Main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGW_Main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGW_Main.Columns.AddRange(new DataGridViewColumn[] { dBAdressDataGridViewTextBoxColumn, contentDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, purposeDataGridViewTextBoxColumn });
            DGW_Main.DataSource = pLCDBBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGW_Main.DefaultCellStyle = dataGridViewCellStyle2;
            DGW_Main.Location = new Point(235, 26);
            DGW_Main.Name = "DGW_Main";
            DGW_Main.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGW_Main.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGW_Main.RowHeadersWidth = 51;
            DGW_Main.RowTemplate.Height = 29;
            DGW_Main.RowTemplate.ReadOnly = true;
            DGW_Main.Size = new Size(463, 665);
            DGW_Main.TabIndex = 5;
            // 
            // dBAdressDataGridViewTextBoxColumn
            // 
            dBAdressDataGridViewTextBoxColumn.DataPropertyName = "DBAdress";
            dBAdressDataGridViewTextBoxColumn.FillWeight = 6F;
            dBAdressDataGridViewTextBoxColumn.HeaderText = "DBAdress";
            dBAdressDataGridViewTextBoxColumn.MaxInputLength = 6;
            dBAdressDataGridViewTextBoxColumn.MinimumWidth = 6;
            dBAdressDataGridViewTextBoxColumn.Name = "dBAdressDataGridViewTextBoxColumn";
            dBAdressDataGridViewTextBoxColumn.ReadOnly = true;
            dBAdressDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            dBAdressDataGridViewTextBoxColumn.Width = 80;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            contentDataGridViewTextBoxColumn.HeaderText = "Content";
            contentDataGridViewTextBoxColumn.MinimumWidth = 6;
            contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            contentDataGridViewTextBoxColumn.ReadOnly = true;
            contentDataGridViewTextBoxColumn.Width = 80;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            typeDataGridViewTextBoxColumn.Width = 50;
            // 
            // purposeDataGridViewTextBoxColumn
            // 
            purposeDataGridViewTextBoxColumn.DataPropertyName = "Purpose";
            purposeDataGridViewTextBoxColumn.HeaderText = "Purpose";
            purposeDataGridViewTextBoxColumn.MinimumWidth = 6;
            purposeDataGridViewTextBoxColumn.Name = "purposeDataGridViewTextBoxColumn";
            purposeDataGridViewTextBoxColumn.ReadOnly = true;
            purposeDataGridViewTextBoxColumn.Width = 200;
            // 
            // pLCDBBindingSource
            // 
            pLCDBBindingSource.DataSource = typeof(PLC_DB);
            // 
            // Main_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(711, 704);
            Controls.Add(DGW_Main);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main_form";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGW_Main).EndInit();
            ((System.ComponentModel.ISupportInitialize)pLCDBBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
        private DataGridView DGW_Main;
        private DataGridViewTextBoxColumn dataBlockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataBlockAdressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataTypeDataGridViewTextBoxColumn;
        private BindingSource pLCDBBindingSource;
        private DataGridViewTextBoxColumn dBAdressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn purposeDataGridViewTextBoxColumn;
    }
}