
namespace Auth3
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.tsl_total = new System.Windows.Forms.ToolStripLabel();
            this.dgv_cart = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_order = new System.Windows.Forms.ToolStripButton();
            this.tsb_clear = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Controls.Add(this.dgv_cart);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 428);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_close,
            this.tsl_total});
            this.toolStrip2.Location = new System.Drawing.Point(0, 402);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(788, 26);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsb_close
            // 
            this.tsb_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_close.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsb_close.Image = ((System.Drawing.Image)(resources.GetObject("tsb_close.Image")));
            this.tsb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_close.Name = "tsb_close";
            this.tsb_close.Size = new System.Drawing.Size(77, 23);
            this.tsb_close.Text = "Закрыть";
            this.tsb_close.Click += new System.EventHandler(this.tsb_close_Click);
            // 
            // tsl_total
            // 
            this.tsl_total.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsl_total.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsl_total.Name = "tsl_total";
            this.tsl_total.Size = new System.Drawing.Size(63, 23);
            this.tsl_total.Text = "Итог: 0";
            // 
            // dgv_cart
            // 
            this.dgv_cart.AllowUserToAddRows = false;
            this.dgv_cart.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            this.dgv_cart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_cart.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cart.Location = new System.Drawing.Point(0, 26);
            this.dgv_cart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_cart.Name = "dgv_cart";
            this.dgv_cart.ReadOnly = true;
            this.dgv_cart.RowHeadersVisible = false;
            this.dgv_cart.RowHeadersWidth = 51;
            this.dgv_cart.RowTemplate.Height = 24;
            this.dgv_cart.Size = new System.Drawing.Size(788, 402);
            this.dgv_cart.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_order,
            this.tsb_clear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(788, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_order
            // 
            this.tsb_order.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_order.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsb_order.Image = ((System.Drawing.Image)(resources.GetObject("tsb_order.Image")));
            this.tsb_order.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_order.Name = "tsb_order";
            this.tsb_order.Size = new System.Drawing.Size(93, 23);
            this.tsb_order.Text = "Оформить";
            this.tsb_order.Click += new System.EventHandler(this.tsb_order_Click);
            // 
            // tsb_clear
            // 
            this.tsb_clear.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_clear.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsb_clear.Image = ((System.Drawing.Image)(resources.GetObject("tsb_clear.Image")));
            this.tsb_clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_clear.Name = "tsb_clear";
            this.tsb_clear.Size = new System.Drawing.Size(86, 23);
            this.tsb_clear.Text = "Очистить";
            this.tsb_clear.Click += new System.EventHandler(this.tsb_clear_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(788, 428);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cart";
            this.Text = "Корзина";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_cart;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsb_close;
        private System.Windows.Forms.ToolStripButton tsb_order;
        private System.Windows.Forms.ToolStripButton tsb_clear;
        private System.Windows.Forms.ToolStripLabel tsl_total;
    }
}