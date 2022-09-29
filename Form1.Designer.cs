
namespace FringillaFunctionality1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.sampleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgDistBckgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgDistFilmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zeroShiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lambdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thicknessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sampleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(796, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(179, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sampleNoDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.avgDistBckgDataGridViewTextBoxColumn,
            this.avgDistFilmDataGridViewTextBoxColumn,
            this.zeroShiftDataGridViewTextBoxColumn,
            this.nNumberDataGridViewTextBoxColumn,
            this.lambdaDataGridViewTextBoxColumn,
            this.thicknessDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.sampleBindingSource1;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(778, 507);
            this.dataGridView.TabIndex = 4;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.FlatAppearance.BorderSize = 3;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.Location = new System.Drawing.Point(796, 358);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(179, 161);
            this.btnExportExcel.TabIndex = 5;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // sampleNoDataGridViewTextBoxColumn
            // 
            this.sampleNoDataGridViewTextBoxColumn.DataPropertyName = "SampleNo";
            this.sampleNoDataGridViewTextBoxColumn.HeaderText = "SampleNo";
            this.sampleNoDataGridViewTextBoxColumn.Name = "sampleNoDataGridViewTextBoxColumn";
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "FileName";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            // 
            // avgDistBckgDataGridViewTextBoxColumn
            // 
            this.avgDistBckgDataGridViewTextBoxColumn.DataPropertyName = "AvgDistBckg";
            this.avgDistBckgDataGridViewTextBoxColumn.HeaderText = "AvgDistBckg";
            this.avgDistBckgDataGridViewTextBoxColumn.Name = "avgDistBckgDataGridViewTextBoxColumn";
            // 
            // avgDistFilmDataGridViewTextBoxColumn
            // 
            this.avgDistFilmDataGridViewTextBoxColumn.DataPropertyName = "AvgDistFilm";
            this.avgDistFilmDataGridViewTextBoxColumn.HeaderText = "AvgDistFilm";
            this.avgDistFilmDataGridViewTextBoxColumn.Name = "avgDistFilmDataGridViewTextBoxColumn";
            // 
            // zeroShiftDataGridViewTextBoxColumn
            // 
            this.zeroShiftDataGridViewTextBoxColumn.DataPropertyName = "ZeroShift";
            this.zeroShiftDataGridViewTextBoxColumn.HeaderText = "ZeroShift";
            this.zeroShiftDataGridViewTextBoxColumn.Name = "zeroShiftDataGridViewTextBoxColumn";
            // 
            // nNumberDataGridViewTextBoxColumn
            // 
            this.nNumberDataGridViewTextBoxColumn.DataPropertyName = "NNumber";
            this.nNumberDataGridViewTextBoxColumn.HeaderText = "NNumber";
            this.nNumberDataGridViewTextBoxColumn.Name = "nNumberDataGridViewTextBoxColumn";
            // 
            // lambdaDataGridViewTextBoxColumn
            // 
            this.lambdaDataGridViewTextBoxColumn.DataPropertyName = "Lambda";
            this.lambdaDataGridViewTextBoxColumn.HeaderText = "Lambda";
            this.lambdaDataGridViewTextBoxColumn.Name = "lambdaDataGridViewTextBoxColumn";
            // 
            // thicknessDataGridViewTextBoxColumn
            // 
            this.thicknessDataGridViewTextBoxColumn.DataPropertyName = "Thickness";
            this.thicknessDataGridViewTextBoxColumn.HeaderText = "Thickness";
            this.thicknessDataGridViewTextBoxColumn.Name = "thicknessDataGridViewTextBoxColumn";
            // 
            // sampleBindingSource1
            // 
            this.sampleBindingSource1.DataSource = typeof(FringillaFunctionality1.Sample);
            // 
            // sampleBindingSource
            // 
            this.sampleBindingSource.DataSource = typeof(FringillaFunctionality1.Sample);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 531);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "FringillaCollector";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.BindingSource sampleBindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgDistBckgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgDistFilmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zeroShiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lambdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thicknessDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sampleBindingSource1;
        private System.Windows.Forms.Button btnExportExcel;
    }
}

