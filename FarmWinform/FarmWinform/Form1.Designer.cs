namespace FarmWinform
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dgAnimalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAnimalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMilkProduced = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgOffspringCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.tbMilk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOffspring = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbAnimalType = new System.Windows.Forms.ComboBox();
            this.btnGetSound = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgAnimalID,
            this.dgAnimalType,
            this.dgMilkProduced,
            this.dgOffspringCount});
            this.dataGridView.Location = new System.Drawing.Point(394, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(531, 426);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // dgAnimalID
            // 
            this.dgAnimalID.DataPropertyName = "AnimalId";
            this.dgAnimalID.HeaderText = "ID";
            this.dgAnimalID.MinimumWidth = 6;
            this.dgAnimalID.Name = "dgAnimalID";
            this.dgAnimalID.ReadOnly = true;
            this.dgAnimalID.Visible = false;
            this.dgAnimalID.Width = 125;
            // 
            // dgAnimalType
            // 
            this.dgAnimalType.DataPropertyName = "AnimalTypeName";
            this.dgAnimalType.HeaderText = "Animal Type";
            this.dgAnimalType.MinimumWidth = 6;
            this.dgAnimalType.Name = "dgAnimalType";
            this.dgAnimalType.ReadOnly = true;
            this.dgAnimalType.Width = 125;
            // 
            // dgMilkProduced
            // 
            this.dgMilkProduced.DataPropertyName = "MilkProduced";
            this.dgMilkProduced.HeaderText = "Milk Produced";
            this.dgMilkProduced.MinimumWidth = 6;
            this.dgMilkProduced.Name = "dgMilkProduced";
            this.dgMilkProduced.ReadOnly = true;
            this.dgMilkProduced.Width = 125;
            // 
            // dgOffspringCount
            // 
            this.dgOffspringCount.DataPropertyName = "OffspringCount";
            this.dgOffspringCount.HeaderText = "Offspring Count";
            this.dgOffspringCount.MinimumWidth = 6;
            this.dgOffspringCount.Name = "dgOffspringCount";
            this.dgOffspringCount.ReadOnly = true;
            this.dgOffspringCount.Width = 125;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(12, 64);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(83, 16);
            this.Type.TabIndex = 1;
            this.Type.Text = "Animal Type";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(15, 211);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(105, 33);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbMilk
            // 
            this.tbMilk.Location = new System.Drawing.Point(97, 99);
            this.tbMilk.Name = "tbMilk";
            this.tbMilk.Size = new System.Drawing.Size(277, 22);
            this.tbMilk.TabIndex = 5;
            this.tbMilk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMilk_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Milk";
            // 
            // tbOffspring
            // 
            this.tbOffspring.Location = new System.Drawing.Point(97, 136);
            this.tbOffspring.Name = "tbOffspring";
            this.tbOffspring.Size = new System.Drawing.Size(277, 22);
            this.tbOffspring.TabIndex = 7;
            this.tbOffspring.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOffspring_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Offspring";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(144, 211);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 33);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(269, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 33);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbAnimalType
            // 
            this.cbAnimalType.FormattingEnabled = true;
            this.cbAnimalType.Location = new System.Drawing.Point(97, 64);
            this.cbAnimalType.Name = "cbAnimalType";
            this.cbAnimalType.Size = new System.Drawing.Size(277, 24);
            this.cbAnimalType.TabIndex = 12;
            // 
            // btnGetSound
            // 
            this.btnGetSound.Location = new System.Drawing.Point(15, 263);
            this.btnGetSound.Name = "btnGetSound";
            this.btnGetSound.Size = new System.Drawing.Size(105, 33);
            this.btnGetSound.TabIndex = 13;
            this.btnGetSound.Text = "Get Sound";
            this.btnGetSound.UseVisualStyleBackColor = true;
            this.btnGetSound.Click += new System.EventHandler(this.btnGetSound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.btnGetSound);
            this.Controls.Add(this.cbAnimalType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbOffspring);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMilk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbMilk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOffspring;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbAnimalType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAnimalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAnimalType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMilkProduced;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgOffspringCount;
        private System.Windows.Forms.Button btnGetSound;
    }
}

