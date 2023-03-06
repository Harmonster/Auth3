
namespace Auth3
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_logout = new System.Windows.Forms.ToolStripButton();
            this.tsb_cart = new System.Windows.Forms.ToolStripButton();
            this.DeleteColumn = new Auth3.DataGridViewImageButtons.DataGridViewDeleteColumn();
            this.AddColumn = new Auth3.DataGridViewImageButtons.DataGridViewAddColumn();
            this.EditColumn = new Auth3.DataGridViewImageButtons.DataGridViewEditColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_products);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // dgv_products
            // 
            this.dgv_products.AllowUserToAddRows = false;
            this.dgv_products.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen;
            this.dgv_products.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_products.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeleteColumn,
            this.AddColumn,
            this.EditColumn,
            this.AmountColumn});
            this.dgv_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_products.Location = new System.Drawing.Point(10, 31);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.RowHeadersVisible = false;
            this.dgv_products.RowHeadersWidth = 51;
            this.dgv_products.RowTemplate.Height = 24;
            this.dgv_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_products.Size = new System.Drawing.Size(780, 409);
            this.dgv_products.TabIndex = 1;
            this.dgv_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_products_CellClick);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 440);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(780, 10);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 419);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(790, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 419);
            this.panel2.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_logout,
            this.tsb_cart});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_logout
            // 
            this.tsb_logout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_logout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_logout.Image = ((System.Drawing.Image)(resources.GetObject("tsb_logout.Image")));
            this.tsb_logout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_logout.Name = "tsb_logout";
            this.tsb_logout.Size = new System.Drawing.Size(139, 28);
            this.tsb_logout.Text = "Сменить профиль";
            this.tsb_logout.Click += new System.EventHandler(this.tsb_logout_Click);
            // 
            // tsb_cart
            // 
            this.tsb_cart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_cart.Image = ((System.Drawing.Image)(resources.GetObject("tsb_cart.Image")));
            this.tsb_cart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_cart.Name = "tsb_cart";
            this.tsb_cart.Size = new System.Drawing.Size(73, 28);
            this.tsb_cart.Text = "Корзина";
            this.tsb_cart.Click += new System.EventHandler(this.tsb_cart_Click);
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.MinimumWidth = 6;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Visible = false;
            this.DeleteColumn.Width = 20;
            // 
            // AddColumn
            // 
            this.AddColumn.HeaderText = "";
            this.AddColumn.MinimumWidth = 6;
            this.AddColumn.Name = "AddColumn";
            this.AddColumn.Visible = false;
            this.AddColumn.Width = 20;
            // 
            // EditColumn
            // 
            this.EditColumn.HeaderText = "";
            this.EditColumn.MinimumWidth = 6;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.Visible = false;
            this.EditColumn.Width = 20;
            // 
            // AmountColumn
            // 
            this.AmountColumn.HeaderText = "";
            this.AmountColumn.MinimumWidth = 6;
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.Width = 125;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Products";
            this.Text = "Продукция";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Products_FormClosed);
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton tsb_logout;
        public System.Windows.Forms.DataGridView dgv_products;
        public System.Windows.Forms.ToolStripButton tsb_cart;
        private DataGridViewImageButtons.DataGridViewDeleteColumn DeleteColumn;
        private DataGridViewImageButtons.DataGridViewAddColumn AddColumn;
        private DataGridViewImageButtons.DataGridViewEditColumn EditColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
    }
}