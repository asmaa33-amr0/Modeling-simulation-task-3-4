namespace InventorySimulation
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
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Testing = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayWithin_Cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beginning_Inv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Random_Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ending_Inv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shortage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Random_Lead_Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lead_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days_untill_oerder_arrives = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(693, 491);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 82;
            this.label7.Text = "Test File";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(1293, 478);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 43);
            this.button1.TabIndex = 72;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(24, 492);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 16);
            this.label6.TabIndex = 71;
            this.label6.Text = "EndingInventoryAverage";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(464, 492);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "ShortageQuantityAverage";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(45, 512);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 65;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(468, 512);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 64;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(676, 511);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 63;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(715, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Inventory System";
            // 
            // Testing
            // 
            this.Testing.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Testing.Location = new System.Drawing.Point(876, 478);
            this.Testing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Testing.Name = "Testing";
            this.Testing.Size = new System.Drawing.Size(127, 44);
            this.Testing.TabIndex = 81;
            this.Testing.Text = "Testing";
            this.Testing.UseVisualStyleBackColor = true;
            this.Testing.Click += new System.EventHandler(this.Testing_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(1075, 478);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 44);
            this.button2.TabIndex = 80;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(276, 491);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 16);
            this.label10.TabIndex = 79;
            this.label10.Text = "demandAverage";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(276, 511);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(132, 22);
            this.textBox8.TabIndex = 78;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.Cycle,
            this.DayWithin_Cycle,
            this.Beginning_Inv,
            this.Random_Demand,
            this.Demand,
            this.Ending_Inv,
            this.Shortage,
            this.Order_Quantity,
            this.Random_Lead_Day,
            this.Lead_Time,
            this.Days_untill_oerder_arrives});
            this.dataGridView1.Location = new System.Drawing.Point(28, 116);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1657, 284);
            this.dataGridView1.TabIndex = 83;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.MinimumWidth = 6;
            this.Day.Name = "Day";
            this.Day.Width = 125;
            // 
            // Cycle
            // 
            this.Cycle.HeaderText = "Cycle";
            this.Cycle.MinimumWidth = 6;
            this.Cycle.Name = "Cycle";
            this.Cycle.Width = 125;
            // 
            // DayWithin_Cycle
            // 
            this.DayWithin_Cycle.HeaderText = "Day_Within_Cycle";
            this.DayWithin_Cycle.MinimumWidth = 6;
            this.DayWithin_Cycle.Name = "DayWithin_Cycle";
            this.DayWithin_Cycle.Width = 125;
            // 
            // Beginning_Inv
            // 
            this.Beginning_Inv.HeaderText = "Beginning_Inv";
            this.Beginning_Inv.MinimumWidth = 6;
            this.Beginning_Inv.Name = "Beginning_Inv";
            this.Beginning_Inv.Width = 125;
            // 
            // Random_Demand
            // 
            this.Random_Demand.HeaderText = "Random_Demand";
            this.Random_Demand.MinimumWidth = 6;
            this.Random_Demand.Name = "Random_Demand";
            this.Random_Demand.Width = 125;
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Demand";
            this.Demand.MinimumWidth = 6;
            this.Demand.Name = "Demand";
            this.Demand.Width = 125;
            // 
            // Ending_Inv
            // 
            this.Ending_Inv.HeaderText = "Ending_Inv";
            this.Ending_Inv.MinimumWidth = 6;
            this.Ending_Inv.Name = "Ending_Inv";
            this.Ending_Inv.Width = 125;
            // 
            // Shortage
            // 
            this.Shortage.HeaderText = "Shortage";
            this.Shortage.MinimumWidth = 6;
            this.Shortage.Name = "Shortage";
            this.Shortage.Width = 125;
            // 
            // Order_Quantity
            // 
            this.Order_Quantity.HeaderText = "Order_Quantity";
            this.Order_Quantity.MinimumWidth = 6;
            this.Order_Quantity.Name = "Order_Quantity";
            this.Order_Quantity.Width = 125;
            // 
            // Random_Lead_Day
            // 
            this.Random_Lead_Day.HeaderText = "Random_Lead_Day";
            this.Random_Lead_Day.MinimumWidth = 6;
            this.Random_Lead_Day.Name = "Random_Lead_Day";
            this.Random_Lead_Day.Width = 125;
            // 
            // Lead_Time
            // 
            this.Lead_Time.HeaderText = "Lead_Time";
            this.Lead_Time.MinimumWidth = 6;
            this.Lead_Time.Name = "Lead_Time";
            this.Lead_Time.Width = 125;
            // 
            // Days_untill_oerder_arrives
            // 
            this.Days_untill_oerder_arrives.HeaderText = "Days_untill_oerder_arrives";
            this.Days_untill_oerder_arrives.MinimumWidth = 6;
            this.Days_untill_oerder_arrives.Name = "Days_untill_oerder_arrives";
            this.Days_untill_oerder_arrives.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 724);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Testing);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Testing;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayWithin_Cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beginning_Inv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Random_Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ending_Inv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shortage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Random_Lead_Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lead_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days_untill_oerder_arrives;
    }
}