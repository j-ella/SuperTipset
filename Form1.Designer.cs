namespace SuperTipset
{
    partial class frm_homepage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_sport = new System.Windows.Forms.ComboBox();
            this.sportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.superTipsetDataSet = new SuperTipset.SuperTipsetDataSet();
            this.txt_team1 = new System.Windows.Forms.TextBox();
            this.txt_team2 = new System.Windows.Forms.TextBox();
            this.txt_team3 = new System.Windows.Forms.TextBox();
            this.txt_team4 = new System.Windows.Forms.TextBox();
            this.sportTableAdapter = new SuperTipset.SuperTipsetDataSetTableAdapters.SportTableAdapter();
            this.lagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lagTableAdapter = new SuperTipset.SuperTipsetDataSetTableAdapters.LagTableAdapter();
            this.lagBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lagBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKLagSportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lagBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.lagBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.fKLagSportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_teamlist = new System.Windows.Forms.DataGridView();
            this.lagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.dgv_gameSchedule = new System.Windows.Forms.DataGridView();
            this.pic_logoHome = new System.Windows.Forms.PictureBox();
            this.btn_clear = new System.Windows.Forms.PictureBox();
            this.btn_create = new System.Windows.Forms.PictureBox();
            this.btn_add = new System.Windows.Forms.PictureBox();
            this.btn_quit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTipsetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLagSportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLagSportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teamlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gameSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logoHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_create)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(217, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Välj sport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(26, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valda lag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(446, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Spelschema och resultat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(217, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "2. Klicka på önskade lag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(447, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tabell";
            // 
            // cmb_sport
            // 
            this.cmb_sport.DataSource = this.sportBindingSource;
            this.cmb_sport.DisplayMember = "Sport";
            this.cmb_sport.Font = new System.Drawing.Font("Inter", 8.5F);
            this.cmb_sport.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_sport.FormattingEnabled = true;
            this.cmb_sport.Location = new System.Drawing.Point(220, 33);
            this.cmb_sport.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_sport.Name = "cmb_sport";
            this.cmb_sport.Size = new System.Drawing.Size(130, 22);
            this.cmb_sport.TabIndex = 5;
            this.cmb_sport.SelectedIndexChanged += new System.EventHandler(this.cmb_sport_SelectedIndexChanged);
            // 
            // sportBindingSource
            // 
            this.sportBindingSource.DataMember = "Sport";
            this.sportBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.superTipsetDataSet;
            this.bindingSource1.Position = 0;
            // 
            // superTipsetDataSet
            // 
            this.superTipsetDataSet.DataSetName = "SuperTipsetDataSet";
            this.superTipsetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_team1
            // 
            this.txt_team1.Font = new System.Drawing.Font("Inter", 8.5F);
            this.txt_team1.Location = new System.Drawing.Point(29, 175);
            this.txt_team1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_team1.Name = "txt_team1";
            this.txt_team1.Size = new System.Drawing.Size(130, 21);
            this.txt_team1.TabIndex = 6;
            // 
            // txt_team2
            // 
            this.txt_team2.Font = new System.Drawing.Font("Inter", 8.5F);
            this.txt_team2.Location = new System.Drawing.Point(29, 203);
            this.txt_team2.Margin = new System.Windows.Forms.Padding(2);
            this.txt_team2.Name = "txt_team2";
            this.txt_team2.Size = new System.Drawing.Size(130, 21);
            this.txt_team2.TabIndex = 7;
            // 
            // txt_team3
            // 
            this.txt_team3.Font = new System.Drawing.Font("Inter", 8.5F);
            this.txt_team3.Location = new System.Drawing.Point(29, 230);
            this.txt_team3.Margin = new System.Windows.Forms.Padding(2);
            this.txt_team3.Name = "txt_team3";
            this.txt_team3.Size = new System.Drawing.Size(130, 21);
            this.txt_team3.TabIndex = 8;
            // 
            // txt_team4
            // 
            this.txt_team4.Font = new System.Drawing.Font("Inter", 8.5F);
            this.txt_team4.Location = new System.Drawing.Point(29, 256);
            this.txt_team4.Margin = new System.Windows.Forms.Padding(2);
            this.txt_team4.Name = "txt_team4";
            this.txt_team4.Size = new System.Drawing.Size(130, 21);
            this.txt_team4.TabIndex = 9;
            // 
            // sportTableAdapter
            // 
            this.sportTableAdapter.ClearBeforeFill = true;
            // 
            // lagBindingSource
            // 
            this.lagBindingSource.DataMember = "Lag";
            this.lagBindingSource.DataSource = this.bindingSource1;
            // 
            // lagTableAdapter
            // 
            this.lagTableAdapter.ClearBeforeFill = true;
            // 
            // lagBindingSource4
            // 
            this.lagBindingSource4.DataMember = "Lag";
            this.lagBindingSource4.DataSource = this.bindingSource1;
            // 
            // fKLagSportBindingSource1
            // 
            this.fKLagSportBindingSource1.DataMember = "FK_Lag_Sport";
            this.fKLagSportBindingSource1.DataSource = this.sportBindingSource;
            // 
            // dgv_teamlist
            // 
            this.dgv_teamlist.AutoGenerateColumns = false;
            this.dgv_teamlist.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_teamlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_teamlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_teamlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teamlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lagDataGridViewTextBoxColumn});
            this.dgv_teamlist.DataSource = this.lagBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Inter", 7.8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(139)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_teamlist.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_teamlist.Location = new System.Drawing.Point(216, 94);
            this.dgv_teamlist.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_teamlist.Name = "dgv_teamlist";
            this.dgv_teamlist.RowHeadersWidth = 62;
            this.dgv_teamlist.RowTemplate.Height = 28;
            this.dgv_teamlist.Size = new System.Drawing.Size(191, 343);
            this.dgv_teamlist.TabIndex = 13;
            this.dgv_teamlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_teamlist_CellClick);
            // 
            // lagDataGridViewTextBoxColumn
            // 
            this.lagDataGridViewTextBoxColumn.DataPropertyName = "Lag";
            this.lagDataGridViewTextBoxColumn.HeaderText = "Lag";
            this.lagDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lagDataGridViewTextBoxColumn.Name = "lagDataGridViewTextBoxColumn";
            this.lagDataGridViewTextBoxColumn.Width = 173;
            // 
            // dgv_result
            // 
            this.dgv_result.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Inter", 7.8F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(139)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_result.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_result.Location = new System.Drawing.Point(450, 263);
            this.dgv_result.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.RowHeadersWidth = 62;
            this.dgv_result.Size = new System.Drawing.Size(411, 174);
            this.dgv_result.TabIndex = 15;
            // 
            // dgv_gameSchedule
            // 
            this.dgv_gameSchedule.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_gameSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_gameSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Inter", 7.8F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(139)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_gameSchedule.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_gameSchedule.Location = new System.Drawing.Point(450, 35);
            this.dgv_gameSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_gameSchedule.Name = "dgv_gameSchedule";
            this.dgv_gameSchedule.RowHeadersWidth = 51;
            this.dgv_gameSchedule.Size = new System.Drawing.Size(411, 185);
            this.dgv_gameSchedule.TabIndex = 16;
            // 
            // pic_logoHome
            // 
            this.pic_logoHome.BackColor = System.Drawing.Color.Transparent;
            this.pic_logoHome.Image = global::SuperTipset.Properties.Resources.transperant_logga;
            this.pic_logoHome.Location = new System.Drawing.Point(-2, 2);
            this.pic_logoHome.Name = "pic_logoHome";
            this.pic_logoHome.Size = new System.Drawing.Size(192, 152);
            this.pic_logoHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logoHome.TabIndex = 18;
            this.pic_logoHome.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.Image = global::SuperTipset.Properties.Resources.btn_cleartest7;
            this.btn_clear.Location = new System.Drawing.Point(761, 225);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 33);
            this.btn_clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_clear.TabIndex = 20;
            this.btn_clear.TabStop = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_create
            // 
            this.btn_create.Image = global::SuperTipset.Properties.Resources.btn_createtest2;
            this.btn_create.Location = new System.Drawing.Point(29, 290);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(127, 33);
            this.btn_create.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_create.TabIndex = 21;
            this.btn_create.TabStop = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = global::SuperTipset.Properties.Resources.btn_addteams2;
            this.btn_add.Location = new System.Drawing.Point(29, 357);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(127, 33);
            this.btn_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_add.TabIndex = 22;
            this.btn_add.TabStop = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Image = global::SuperTipset.Properties.Resources.btn_quit2;
            this.btn_quit.Location = new System.Drawing.Point(29, 396);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(127, 33);
            this.btn_quit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_quit.TabIndex = 23;
            this.btn_quit.TabStop = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // frm_homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 448);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.pic_logoHome);
            this.Controls.Add(this.dgv_gameSchedule);
            this.Controls.Add(this.dgv_result);
            this.Controls.Add(this.dgv_teamlist);
            this.Controls.Add(this.txt_team4);
            this.Controls.Add(this.txt_team3);
            this.Controls.Add(this.txt_team2);
            this.Controls.Add(this.txt_team1);
            this.Controls.Add(this.cmb_sport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_homepage";
            this.Text = "Startsida";
            this.Load += new System.EventHandler(this.frm_homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superTipsetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLagSportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLagSportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teamlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gameSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logoHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_create)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_sport;
        private System.Windows.Forms.TextBox txt_team1;
        private System.Windows.Forms.TextBox txt_team2;
        private System.Windows.Forms.TextBox txt_team3;
        private System.Windows.Forms.TextBox txt_team4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private SuperTipsetDataSet superTipsetDataSet;
        private System.Windows.Forms.BindingSource sportBindingSource;
        private SuperTipsetDataSetTableAdapters.SportTableAdapter sportTableAdapter;
        private System.Windows.Forms.BindingSource lagBindingSource;
        private SuperTipsetDataSetTableAdapters.LagTableAdapter lagTableAdapter;
        private System.Windows.Forms.BindingSource lagBindingSource1;
        private System.Windows.Forms.BindingSource lagBindingSource2;
        private System.Windows.Forms.BindingSource lagBindingSource3;
        private System.Windows.Forms.BindingSource fKLagSportBindingSource;
        private System.Windows.Forms.BindingSource lagBindingSource4;
        private System.Windows.Forms.BindingSource fKLagSportBindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridView dgv_teamlist;
        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.DataGridView dgv_gameSchedule;
        private System.Windows.Forms.PictureBox pic_logoHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn lagDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox btn_clear;
        private System.Windows.Forms.PictureBox btn_create;
        private System.Windows.Forms.PictureBox btn_add;
        private System.Windows.Forms.PictureBox btn_quit;
    }
}

