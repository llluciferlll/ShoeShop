namespace ShoeShop
{
    partial class ProductEditForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblId = new Label();
            txtId = new TextBox();
            lblArticle = new Label();
            txtArticle = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblManufacturer = new Label();
            cmbManufacturer = new ComboBox();
            lblSupplier = new Label();
            cmbSupplier = new ComboBox();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            lblUnit = new Label();
            txtUnit = new TextBox();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            lblDiscount = new Label();
            numDiscount = new NumericUpDown();
            picPhoto = new PictureBox();
            btnPhoto = new Button();
            btnBack = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPhoto).BeginInit();
            SuspendLayout();
            //
            // lblId
            //
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 23);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            //
            // txtId
            //
            txtId.Location = new Point(190, 20);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(230, 27);
            txtId.TabIndex = 1;
            //
            // lblArticle
            //
            lblArticle.AutoSize = true;
            lblArticle.Location = new Point(20, 58);
            lblArticle.Name = "lblArticle";
            lblArticle.Size = new Size(65, 20);
            lblArticle.TabIndex = 2;
            lblArticle.Text = "Артикул:";
            //
            // txtArticle
            //
            txtArticle.Location = new Point(190, 55);
            txtArticle.Name = "txtArticle";
            txtArticle.Size = new Size(230, 27);
            txtArticle.TabIndex = 3;
            //
            // lblName
            //
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 93);
            lblName.Name = "lblName";
            lblName.Size = new Size(110, 20);
            lblName.TabIndex = 4;
            lblName.Text = "Наименование:";
            //
            // txtName
            //
            txtName.Location = new Point(190, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(230, 27);
            txtName.TabIndex = 5;
            //
            // lblCategory
            //
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 128);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(80, 20);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Категория:";
            //
            // cmbCategory
            //
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Location = new Point(190, 125);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(230, 27);
            cmbCategory.TabIndex = 7;
            //
            // lblDescription
            //
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 163);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(75, 20);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Описание:";
            //
            // txtDescription
            //
            txtDescription.Location = new Point(190, 160);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(230, 60);
            txtDescription.TabIndex = 9;
            //
            // lblManufacturer
            //
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(20, 233);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(115, 20);
            lblManufacturer.TabIndex = 10;
            lblManufacturer.Text = "Производитель:";
            //
            // cmbManufacturer
            //
            cmbManufacturer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbManufacturer.Location = new Point(190, 230);
            cmbManufacturer.Name = "cmbManufacturer";
            cmbManufacturer.Size = new Size(230, 27);
            cmbManufacturer.TabIndex = 11;
            //
            // lblSupplier
            //
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(20, 268);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(85, 20);
            lblSupplier.TabIndex = 12;
            lblSupplier.Text = "Поставщик:";
            //
            // cmbSupplier
            //
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.Location = new Point(190, 265);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(230, 27);
            cmbSupplier.TabIndex = 13;
            //
            // lblPrice
            //
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(20, 303);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(45, 20);
            lblPrice.TabIndex = 14;
            lblPrice.Text = "Цена:";
            //
            // numPrice
            //
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(190, 300);
            numPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(230, 27);
            numPrice.TabIndex = 15;
            //
            // lblUnit
            //
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(20, 338);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(140, 20);
            lblUnit.TabIndex = 16;
            lblUnit.Text = "Единица измерения:";
            //
            // txtUnit
            //
            txtUnit.Location = new Point(190, 335);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(230, 27);
            txtUnit.TabIndex = 17;
            txtUnit.Text = "шт.";
            //
            // lblQuantity
            //
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(20, 373);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(155, 20);
            lblQuantity.TabIndex = 18;
            lblQuantity.Text = "Количество на складе:";
            //
            // numQuantity
            //
            numQuantity.Location = new Point(190, 370);
            numQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(230, 27);
            numQuantity.TabIndex = 19;
            //
            // lblDiscount
            //
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(20, 408);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(85, 20);
            lblDiscount.TabIndex = 20;
            lblDiscount.Text = "Скидка, %:";
            //
            // numDiscount
            //
            numDiscount.Location = new Point(190, 405);
            numDiscount.Name = "numDiscount";
            numDiscount.Size = new Size(230, 27);
            numDiscount.TabIndex = 21;
            //
            // picPhoto
            //
            picPhoto.BorderStyle = BorderStyle.FixedSingle;
            picPhoto.Location = new Point(440, 20);
            picPhoto.Name = "picPhoto";
            picPhoto.Size = new Size(180, 150);
            picPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picPhoto.TabIndex = 22;
            picPhoto.TabStop = false;
            //
            // btnPhoto
            //
            btnPhoto.Location = new Point(440, 180);
            btnPhoto.Name = "btnPhoto";
            btnPhoto.Size = new Size(180, 35);
            btnPhoto.TabIndex = 23;
            btnPhoto.Text = "Выбрать фото";
            btnPhoto.UseVisualStyleBackColor = true;
            btnPhoto.Click += btnPhoto_Click;
            //
            // btnBack
            //
            btnBack.Location = new Point(20, 460);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(130, 40);
            btnBack.TabIndex = 24;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            //
            // btnSave
            //
            btnSave.BackColor = Color.MediumSpringGreen;
            btnSave.Location = new Point(190, 460);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 40);
            btnSave.TabIndex = 25;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // btnDelete
            //
            btnDelete.Location = new Point(330, 460);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 40);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            //
            // openFileDialog
            //
            openFileDialog.Filter = "Изображения|*.jpg;*.jpeg;*.png";
            //
            // ProductEditForm
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(640, 520);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblArticle);
            Controls.Add(txtArticle);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblCategory);
            Controls.Add(cmbCategory);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblManufacturer);
            Controls.Add(cmbManufacturer);
            Controls.Add(lblSupplier);
            Controls.Add(cmbSupplier);
            Controls.Add(lblPrice);
            Controls.Add(numPrice);
            Controls.Add(lblUnit);
            Controls.Add(txtUnit);
            Controls.Add(lblQuantity);
            Controls.Add(numQuantity);
            Controls.Add(lblDiscount);
            Controls.Add(numDiscount);
            Controls.Add(picPhoto);
            Controls.Add(btnPhoto);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProductEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ООО «Обувь» — Редактирование товара";
            Load += ProductEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private Label lblArticle;
        private TextBox txtArticle;
        private Label lblName;
        private TextBox txtName;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblManufacturer;
        private ComboBox cmbManufacturer;
        private Label lblSupplier;
        private ComboBox cmbSupplier;
        private Label lblPrice;
        private NumericUpDown numPrice;
        private Label lblUnit;
        private TextBox txtUnit;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Label lblDiscount;
        private NumericUpDown numDiscount;
        private PictureBox picPhoto;
        private Button btnPhoto;
        private Button btnBack;
        private Button btnSave;
        private Button btnDelete;
        private OpenFileDialog openFileDialog;
    }
}
