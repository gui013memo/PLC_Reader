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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            button1 = new Button();
            Button_ConnectPLC = new Button();
            Button_DisconnectPLC = new Button();
            button4 = new Button();
            DGW_Main = new DataGridView();
            dBAdressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            purposeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pLCDBBindingSource = new BindingSource(components);
            label1 = new Label();
            pageSetupDialog1 = new PageSetupDialog();
            panel1 = new Panel();
            Label_PLC_Conn = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)DGW_Main).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pLCDBBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowFrame;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Cross;
            button1.FlatAppearance.BorderColor = Color.FromArgb(140, 140, 140);
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseDownBackColor = Color.Black;
            button1.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(36, 456);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(218, 53);
            button1.TabIndex = 0;
            button1.Text = "ENG_BUILD_DATA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Button_ConnectPLC
            // 
            Button_ConnectPLC.BackColor = SystemColors.WindowFrame;
            Button_ConnectPLC.BackgroundImageLayout = ImageLayout.Stretch;
            Button_ConnectPLC.Cursor = Cursors.Hand;
            Button_ConnectPLC.FlatAppearance.BorderColor = Color.ForestGreen;
            Button_ConnectPLC.FlatAppearance.BorderSize = 3;
            Button_ConnectPLC.FlatAppearance.MouseDownBackColor = Color.Black;
            Button_ConnectPLC.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            Button_ConnectPLC.FlatStyle = FlatStyle.Flat;
            Button_ConnectPLC.Font = new Font("Source Sans Pro", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Button_ConnectPLC.ForeColor = Color.Gainsboro;
            Button_ConnectPLC.Location = new Point(36, 76);
            Button_ConnectPLC.Margin = new Padding(3, 4, 3, 4);
            Button_ConnectPLC.Name = "Button_ConnectPLC";
            Button_ConnectPLC.Size = new Size(218, 77);
            Button_ConnectPLC.TabIndex = 1;
            Button_ConnectPLC.Text = "Connect";
            Button_ConnectPLC.UseVisualStyleBackColor = false;
            Button_ConnectPLC.Click += button2_Click;
            // 
            // Button_DisconnectPLC
            // 
            Button_DisconnectPLC.BackColor = SystemColors.WindowFrame;
            Button_DisconnectPLC.BackgroundImageLayout = ImageLayout.Stretch;
            Button_DisconnectPLC.Cursor = Cursors.Hand;
            Button_DisconnectPLC.FlatAppearance.BorderColor = Color.FromArgb(140, 140, 140);
            Button_DisconnectPLC.FlatAppearance.BorderSize = 3;
            Button_DisconnectPLC.FlatAppearance.MouseDownBackColor = Color.Black;
            Button_DisconnectPLC.FlatAppearance.MouseOverBackColor = Color.Crimson;
            Button_DisconnectPLC.FlatStyle = FlatStyle.Flat;
            Button_DisconnectPLC.Font = new Font("Source Sans Pro", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Button_DisconnectPLC.ForeColor = Color.Gainsboro;
            Button_DisconnectPLC.Location = new Point(36, 170);
            Button_DisconnectPLC.Margin = new Padding(3, 4, 3, 4);
            Button_DisconnectPLC.Name = "Button_DisconnectPLC";
            Button_DisconnectPLC.Size = new Size(218, 72);
            Button_DisconnectPLC.TabIndex = 2;
            Button_DisconnectPLC.Text = "Disconnect";
            Button_DisconnectPLC.UseVisualStyleBackColor = false;
            Button_DisconnectPLC.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.WindowFrame;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(140, 140, 140);
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatAppearance.MouseDownBackColor = Color.Black;
            button4.FlatAppearance.MouseOverBackColor = Color.LightSlateGray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Source Sans Pro", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Gainsboro;
            button4.Location = new Point(36, 262);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(218, 60);
            button4.TabIndex = 4;
            button4.Text = "  READ ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // DGW_Main
            // 
            DGW_Main.AllowUserToAddRows = false;
            DGW_Main.AllowUserToDeleteRows = false;
            DGW_Main.AllowUserToResizeRows = false;
            DGW_Main.AutoGenerateColumns = false;
            DGW_Main.BackgroundColor = Color.DimGray;
            DGW_Main.BorderStyle = BorderStyle.None;
            DGW_Main.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.DimGray;
            dataGridViewCellStyle11.Font = new Font("Microsoft Tai Le", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            DGW_Main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            DGW_Main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGW_Main.Columns.AddRange(new DataGridViewColumn[] { dBAdressDataGridViewTextBoxColumn, contentDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, purposeDataGridViewTextBoxColumn });
            DGW_Main.DataSource = pLCDBBindingSource;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle14.Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            DGW_Main.DefaultCellStyle = dataGridViewCellStyle14;
            DGW_Main.EnableHeadersVisualStyles = false;
            DGW_Main.GridColor = SystemColors.ButtonFace;
            DGW_Main.Location = new Point(292, 0);
            DGW_Main.Name = "DGW_Main";
            DGW_Main.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = Color.DimGray;
            dataGridViewCellStyle15.Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.Firebrick;
            dataGridViewCellStyle15.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            DGW_Main.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            DGW_Main.RowHeadersWidth = 51;
            DGW_Main.RowTemplate.DefaultCellStyle.BackColor = Color.DimGray;
            DGW_Main.RowTemplate.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            DGW_Main.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Firebrick;
            DGW_Main.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            DGW_Main.RowTemplate.Height = 29;
            DGW_Main.RowTemplate.ReadOnly = true;
            DGW_Main.Size = new Size(468, 657);
            DGW_Main.TabIndex = 5;
            // 
            // dBAdressDataGridViewTextBoxColumn
            // 
            dBAdressDataGridViewTextBoxColumn.DataPropertyName = "DBAdress";
            dataGridViewCellStyle12.BackColor = Color.Gray;
            dBAdressDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
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
            contentDataGridViewTextBoxColumn.Width = 125;
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
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            purposeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(175, 15);
            label1.Name = "label1";
            label1.Size = new Size(20, 23);
            label1.TabIndex = 3;
            label1.Text = "  ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Label_PLC_Conn);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Button_DisconnectPLC);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Button_ConnectPLC);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 352);
            panel1.TabIndex = 6;
            // 
            // Label_PLC_Conn
            // 
            Label_PLC_Conn.AutoSize = true;
            Label_PLC_Conn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Label_PLC_Conn.ForeColor = Color.Gainsboro;
            Label_PLC_Conn.Location = new Point(201, 8);
            Label_PLC_Conn.Name = "Label_PLC_Conn";
            Label_PLC_Conn.Size = new Size(85, 32);
            Label_PLC_Conn.TabIndex = 4;
            Label_PLC_Conn.Text = "Comm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Source Sans Pro", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(16, 5);
            label2.Name = "label2";
            label2.Size = new Size(75, 42);
            label2.TabIndex = 5;
            label2.Text = "PLC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Source Sans Pro", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(16, 380);
            label3.Name = "label3";
            label3.Size = new Size(159, 42);
            label3.TabIndex = 6;
            label3.Text = "DataBase";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowFrame;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Cross;
            button2.FlatAppearance.BorderColor = Color.FromArgb(140, 140, 140);
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatAppearance.MouseDownBackColor = Color.Cyan;
            button2.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Gainsboro;
            button2.Location = new Point(36, 533);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(218, 53);
            button2.TabIndex = 7;
            button2.Text = "Q_QUALITY_SEND_IF";
            button2.UseVisualStyleBackColor = false;
            // 
            // Main_form
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(757, 631);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(DGW_Main);
            Controls.Add(button1);
            Controls.Add(panel1);
            Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.MenuHighlight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main_form";
            Text = "TMS Reader";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGW_Main).EndInit();
            ((System.ComponentModel.ISupportInitialize)pLCDBBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button Button_ConnectPLC;
        private Button Button_DisconnectPLC;
        private Button button4;
        private DataGridView DGW_Main;
        private DataGridViewTextBoxColumn dataBlockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataBlockAdressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataTypeDataGridViewTextBoxColumn;
        private BindingSource pLCDBBindingSource;
        private Label label1;
        private PageSetupDialog pageSetupDialog1;
        private Panel panel1;
        private Label Label_PLC_Conn;
        private Label label2;
        private DataGridViewTextBoxColumn dBAdressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn purposeDataGridViewTextBoxColumn;
        private Label label3;
        private Button button2;
    }
}