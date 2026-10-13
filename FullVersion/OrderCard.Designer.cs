namespace ShoeShop
{
    partial class OrderCard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            lblArticle = new Label();
            lblInfo = new Label();
            lblDelivery = new Label();
            SuspendLayout();
            //
            // lblArticle
            //
            lblArticle.AutoSize = true;
            lblArticle.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            lblArticle.Location = new Point(10, 8);
            lblArticle.Name = "lblArticle";
            lblArticle.Size = new Size(130, 20);
            lblArticle.TabIndex = 0;
            lblArticle.Text = "Артикул заказа";
            //
            // lblInfo
            //
            lblInfo.Location = new Point(10, 32);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(720, 70);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Статус заказа:\nАдрес пункта выдачи:\nДата заказа:";
            //
            // lblDelivery
            //
            lblDelivery.BorderStyle = BorderStyle.FixedSingle;
            lblDelivery.Location = new Point(760, 5);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(170, 98);
            lblDelivery.TabIndex = 2;
            lblDelivery.Text = "Дата доставки";
            lblDelivery.TextAlign = ContentAlignment.MiddleCenter;
            //
            // OrderCard
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblDelivery);
            Controls.Add(lblInfo);
            Controls.Add(lblArticle);
            Margin = new Padding(5);
            Name = "OrderCard";
            Size = new Size(940, 110);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblArticle;
        private Label lblInfo;
        private Label lblDelivery;
    }
}
