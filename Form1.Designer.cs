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
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Välj sport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valda lag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Spelschema och resultat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(178, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Klicka på önskade lag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tabell";
            // 
            // cmb_sport
            // 
            this.cmb_sport.DataSource = this.sportBindingSource;
            this.cmb_sport.DisplayMember = "Sport";
            this.cmb_sport.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sport.FormattingEnabled = true;
            this.cmb_sport.Location = new System.Drawing.Point(20, 35);
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
            this.txt_team1.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_team1.Location = new System.Drawing.Point(20, 93);
            this.txt_team1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_team1.Name = "txt_team1";
            this.txt_team1.Size = new System.Drawing.Size(130, 22);
            this.txt_team1.TabIndex = 6;
            // 
            // txt_team2
            // 
            this.txt_team2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F);
            this.txt_team2.Location = new System.Drawing.Point(20, 121);
            this.txt_team2.Margin = new System.Windows.Forms.Padding(2);
            this.txt_team2.Name = "txt_team2";
            this.txt_team2.Size = new System.Drawing.Size(130, 21);
            this.txt_team2.TabIndex = 7;
            // 
            // txt_team3
            // 
            this.txt_team3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F);
            this.txt_team3.Location = new System.Drawing.Point(20, 154);
            this.txt_team3.Margin = new System.Windows.Forms.Padding(2);
            this.txt_team3.Name = "txt_team3";
            this.txt_team3.Size = new System.Drawing.Size(130, 21);
            this.txt_team3.TabIndex = 8;
            // 
            // txt_team4
            // 
            this.txt_team4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F);
            this.txt_team4.Location = new System.Drawing.Point(20, 187);
            this.txt_team4.Margin = new System.Windows.Forms.Padding(2);
            this.txt_team4.Name = "txt_team4";
            this.txt_team4.Size = new System.Drawing.Size(130, 21);
            this.txt_team4.TabIndex = 9;
            // 
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(20, 236);
            this.btn_create.Margin = new System.Windows.Forms.Padding(2);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(129, 35);
            this.btn_create.TabIndex = 10;
            this.btn_create.Text = "Skapa spelschema";
            this.btn_create.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(20, 277);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(129, 35);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Lägg till nya lag";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.Location = new System.Drawing.Point(20, 316);
            this.btn_quit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(129, 33);
            this.btn_quit.TabIndex = 12;
            this.btn_quit.Text = "Avsluta";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
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
            this.dgv_teamlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teamlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lagDataGridViewTextBoxColumn});
            this.dgv_teamlist.DataSource = this.lagBindingSource;
            this.dgv_teamlist.Location = new System.Drawing.Point(182, 35);
            this.dgv_teamlist.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_teamlist.Name = "dgv_teamlist";
            this.dgv_teamlist.RowHeadersWidth = 62;
            this.dgv_teamlist.RowTemplate.Height = 28;
            this.dgv_teamlist.Size = new System.Drawing.Size(226, 277);
            this.dgv_teamlist.TabIndex = 13;
            // 
            // lagDataGridViewTextBoxColumn
            // 
            this.lagDataGridViewTextBoxColumn.DataPropertyName = "Lag";
            this.lagDataGridViewTextBoxColumn.HeaderText = "Lag";
            this.lagDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lagDataGridViewTextBoxColumn.Name = "lagDataGridViewTextBoxColumn";
            this.lagDataGridViewTextBoxColumn.Width = 175;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(448, 35);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(297, 128);
            this.dataGridView2.TabIndex = 14;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(448, 202);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.Size = new System.Drawing.Size(297, 110);
            this.dataGridView3.TabIndex = 15;
            // 
            // frm_homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 381);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dgv_teamlist);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_create);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_quit;
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lagDataGridViewTextBoxColumn;
    }
}

