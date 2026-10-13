namespace ShoeShop
{
    partial class OrderEditForm
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
            lblArticles = new Label();
            txtArticles = new TextBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblPoint = new Label();
            cmbPoint = new ComboBox();
            lblOrderDate = new Label();
            dtpOrder = new DateTimePicker();
            lblDeliveryDate = new Label();
            dtpDelivery = new DateTimePicker();
            btnBack = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            SuspendLayout();
            //
            // lblArticles
            //
            lblArticles.AutoSize = true;
            lblArticles.Location = new Point(20, 23);
            lblArticles.Name = "lblArticles";
            lblArticles.Size = new Size(65, 20);
            lblArticles.TabIndex = 0;
            lblArticles.Text = "Артикул:";
            //
            // txtArticles
            //
            txtArticles.Location = new Point(190, 20);
            txtArticles.Name = "txtArticles";
            txtArticles.PlaceholderText = "А112Т4, 2, F635R4, 2";
            txtArticles.Size = new Size(310, 27);
            txtArticles.TabIndex = 1;
            //
            // lblStatus
            //
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(20, 63);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(110, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Статус заказа:";
            //
            // cmbStatus
            //
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new object[] { "Новый", "Завершен" });
            cmbStatus.Location = new Point(190, 60);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(310, 27);
            cmbStatus.TabIndex = 3;
            //
            // lblPoint
            //
            lblPoint.AutoSize = true;
            lblPoint.Location = new Point(20, 103);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(155, 20);
            lblPoint.TabIndex = 4;
            lblPoint.Text = "Адрес пункта выдачи:";
            //
            // cmbPoint
            //
            cmbPoint.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPoint.Location = new Point(190, 100);
            cmbPoint.Name = "cmbPoint";
            cmbPoint.Size = new Size(310, 27);
            cmbPoint.TabIndex = 5;
            //
            // lblOrderDate
            //
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(20, 143);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(95, 20);
            lblOrderDate.TabIndex = 6;
            lblOrderDate.Text = "Дата заказа:";
            //
            // dtpOrder
            //
            dtpOrder.Format = DateTimePickerFormat.Short;
            dtpOrder.Location = new Point(190, 140);
            dtpOrder.Name = "dtpOrder";
            dtpOrder.Size = new Size(310, 27);
            dtpOrder.TabIndex = 7;
            //
            // lblDeliveryDate
            //
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Location = new Point(20, 183);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(95, 20);
            lblDeliveryDate.TabIndex = 8;
            lblDeliveryDate.Text = "Дата выдачи:";
            //
            // dtpDelivery
            //
            dtpDelivery.Format = DateTimePickerFormat.Short;
            dtpDelivery.Location = new Point(190, 180);
            dtpDelivery.Name = "dtpDelivery";
            dtpDelivery.Size = new Size(310, 27);
            dtpDelivery.TabIndex = 9;
            //
            // btnBack
            //
            btnBack.Location = new Point(20, 240);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(130, 40);
            btnBack.TabIndex = 10;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            //
            // btnSave
            //
            btnSave.BackColor = Color.MediumSpringGreen;
            btnSave.Location = new Point(190, 240);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 40);
            btnSave.TabIndex = 11;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // btnDelete
            //
            btnDelete.Location = new Point(350, 240);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 40);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            //
            // OrderEditForm
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(520, 300);
            Controls.Add(lblArticles);
            Controls.Add(txtArticles);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(lblPoint);
            Controls.Add(cmbPoint);
            Controls.Add(lblOrderDate);
            Controls.Add(dtpOrder);
            Controls.Add(lblDeliveryDate);
            Controls.Add(dtpDelivery);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "OrderEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ООО «Обувь» — Редактирование заказа";
            Load += OrderEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblArticles;
        private TextBox txtArticles;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblPoint;
        private ComboBox cmbPoint;
        private Label lblOrderDate;
        private DateTimePicker dtpOrder;
        private Label lblDeliveryDate;
        private DateTimePicker dtpDelivery;
        private Button btnBack;
        private Button btnSave;
        private Button btnDelete;
    }
}
