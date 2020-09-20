namespace MilanovicMatej
{
    partial class Ljestvica_poredak
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ljestvicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ribicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektDataSet = new MilanovicMatej.ProjektDataSet();
            this.ribicBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ribicTableAdapter = new MilanovicMatej.ProjektDataSetTableAdapters.RibicTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ljestvicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribicBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ljestvicaBindingSource
            // 
            this.ljestvicaBindingSource.DataMember = "Ljestvica";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.ribicBindingSource1;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(2, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Poredak po kilazi";
            series1.XValueMember = "sifra_dozvole";
            series1.YValueMembers = "Ukupna_kilaza";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1009, 356);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // ribicBindingSource
            // 
            this.ribicBindingSource.DataMember = "Ribic";
            // 
            // projektDataSet
            // 
            this.projektDataSet.DataSetName = "ProjektDataSet";
            this.projektDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ribicBindingSource1
            // 
            this.ribicBindingSource1.DataMember = "Ribic";
            this.ribicBindingSource1.DataSource = this.projektDataSet;
            // 
            // ribicTableAdapter
            // 
            this.ribicTableAdapter.ClearBeforeFill = true;
            // 
            // Ljestvica_poredak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 356);
            this.Controls.Add(this.chart1);
            this.Name = "Ljestvica_poredak";
            this.Text = "Ljestvica_poredak";
            this.Load += new System.EventHandler(this.Ljestvica_poredak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ljestvicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribicBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
       
        private System.Windows.Forms.BindingSource ljestvicaBindingSource;
        
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
       
        private System.Windows.Forms.BindingSource ribicBindingSource;
        private ProjektDataSet projektDataSet;
        private System.Windows.Forms.BindingSource ribicBindingSource1;
        private ProjektDataSetTableAdapters.RibicTableAdapter ribicTableAdapter;
    }
}