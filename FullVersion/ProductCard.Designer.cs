namespace ShoeShop
{
    partial class ProductCard
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
            picPhoto = new PictureBox();
            lblTitle = new Label();
            lblInfo = new Label();
            lblPriceCaption = new Label();
            lblPrice = new Label();
            lblNewPrice = new Label();
            lblStock = new Label();
            lblDiscount = new Label();
            ((System.ComponentModel.ISupportInitialize)picPhoto).BeginInit();
            SuspendLayout();
            //
            // picPhoto
            //
            picPhoto.Location = new Point(5, 5);
            picPhoto.Name = "picPhoto";
            picPhoto.Size = new Size(220, 168);
            picPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picPhoto.TabIndex = 0;
            picPhoto.TabStop = false;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            lblTitle.Location = new Point(235, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 20);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Категория | Наименование";
            //
            // lblInfo
            //
            lblInfo.Location = new Point(235, 30);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(530, 65);
            lblInfo.TabIndex = 2;
            lblInfo.Text = "Описание товара:\nПроизводитель:\nПоставщик:";
            //
            // lblPriceCaption
            //
            lblPriceCaption.AutoSize = true;
            lblPriceCaption.Location = new Point(235, 97);
            lblPriceCaption.Name = "lblPriceCaption";
            lblPriceCaption.Size = new Size(45, 20);
            lblPriceCaption.TabIndex = 3;
            lblPriceCaption.Text = "Цена:";
            //
            // lblPrice
            //
            lblPrice.Location = new Point(285, 97);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(90, 22);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "0.00";
            //
            // lblNewPrice
            //
            lblNewPrice.AutoSize = true;
            lblNewPrice.Location = new Point(380, 97);
            lblNewPrice.Name = "lblNewPrice";
            lblNewPrice.Size = new Size(0, 20);
            lblNewPrice.TabIndex = 5;
            //
            // lblStock
            //
            lblStock.Location = new Point(235, 122);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(530, 45);
            lblStock.TabIndex = 6;
            lblStock.Text = "Единица измерения:\nКоличество на складе:";
            //
            // lblDiscount
            //
            lblDiscount.BorderStyle = BorderStyle.FixedSingle;
            lblDiscount.Location = new Point(775, 5);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(155, 168);
            lblDiscount.TabIndex = 7;
            lblDiscount.Text = "Действующая скидка";
            lblDiscount.TextAlign = ContentAlignment.MiddleCenter;
            //
            // ProductCard
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblDiscount);
            Controls.Add(lblStock);
            Controls.Add(lblNewPrice);
            Controls.Add(lblPrice);
            Controls.Add(lblPriceCaption);
            Controls.Add(lblInfo);
            Controls.Add(lblTitle);
            Controls.Add(picPhoto);
            Margin = new Padding(5);
            Name = "ProductCard";
            Size = new Size(940, 180);
            ((System.ComponentModel.ISupportInitialize)picPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picPhoto;
        private Label lblTitle;
        private Label lblInfo;
        private Label lblPriceCaption;
        private Label lblPrice;
        private Label lblNewPrice;
        private Label lblStock;
        private Label lblDiscount;
    }
}
