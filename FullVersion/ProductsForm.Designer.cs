namespace ShoeShop
{
    partial class ProductsForm
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
            panelHeader = new Panel();
            picLogo = new PictureBox();
            lblTitle = new Label();
            lblUser = new Label();
            btnLogout = new Button();
            panelTools = new Panel();
            panelFilter = new Panel();
            txtSearch = new TextBox();
            cmbSupplier = new ComboBox();
            cmbSort = new ComboBox();
            btnAdd = new Button();
            btnOrders = new Button();
            flowProducts = new FlowLayoutPanel();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelTools.SuspendLayout();
            panelFilter.SuspendLayout();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.Chartreuse;
            panelHeader.Controls.Add(picLogo);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblUser);
            panelHeader.Controls.Add(btnLogout);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 70);
            panelHeader.TabIndex = 0;
            //
            // picLogo
            //
            picLogo.ImageLocation = "Icon.png";
            picLogo.Location = new Point(10, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(60, 60);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(80, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(170, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Список товаров";
            //
            // lblUser
            //
            lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUser.Location = new Point(520, 10);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(350, 50);
            lblUser.TabIndex = 2;
            lblUser.Text = "ФИО";
            lblUser.TextAlign = ContentAlignment.MiddleRight;
            //
            // btnLogout
            //
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.MediumSpringGreen;
            btnLogout.Location = new Point(880, 15);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(105, 40);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Выход";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            //
            // panelTools
            //
            panelTools.Controls.Add(panelFilter);
            panelTools.Controls.Add(btnAdd);
            panelTools.Controls.Add(btnOrders);
            panelTools.Dock = DockStyle.Top;
            panelTools.Location = new Point(0, 70);
            panelTools.Name = "panelTools";
            panelTools.Size = new Size(1000, 50);
            panelTools.TabIndex = 1;
            //
            // panelFilter
            //
            panelFilter.Controls.Add(txtSearch);
            panelFilter.Controls.Add(cmbSupplier);
            panelFilter.Controls.Add(cmbSort);
            panelFilter.Location = new Point(0, 0);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(700, 50);
            panelFilter.TabIndex = 0;
            //
            // txtSearch
            //
            txtSearch.Location = new Point(10, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Поиск...";
            txtSearch.Size = new Size(250, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += LoadProducts;
            //
            // cmbSupplier
            //
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.Location = new Point(270, 12);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(200, 27);
            cmbSupplier.TabIndex = 1;
            cmbSupplier.SelectedIndexChanged += LoadProducts;
            //
            // cmbSort
            //
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.Items.AddRange(new object[] { "Количество: по возрастанию", "Количество: по убыванию" });
            cmbSort.Location = new Point(480, 12);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(210, 27);
            cmbSort.TabIndex = 2;
            cmbSort.SelectedIndexChanged += LoadProducts;
            //
            // btnAdd
            //
            btnAdd.BackColor = Color.MediumSpringGreen;
            btnAdd.Location = new Point(710, 7);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 36);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить товар";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            //
            // btnOrders
            //
            btnOrders.Location = new Point(860, 7);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(125, 36);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "Заказы";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            //
            // flowProducts
            //
            flowProducts.AutoScroll = true;
            flowProducts.Dock = DockStyle.Fill;
            flowProducts.FlowDirection = FlowDirection.TopDown;
            flowProducts.Location = new Point(0, 120);
            flowProducts.Name = "flowProducts";
            flowProducts.Size = new Size(1000, 580);
            flowProducts.TabIndex = 2;
            flowProducts.WrapContents = false;
            //
            // ProductsForm
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1000, 700);
            Controls.Add(flowProducts);
            Controls.Add(panelTools);
            Controls.Add(panelHeader);
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ООО «Обувь» — Список товаров";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelTools.ResumeLayout(false);
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox picLogo;
        private Label lblTitle;
        private Label lblUser;
        private Button btnLogout;
        private Panel panelTools;
        private Panel panelFilter;
        private TextBox txtSearch;
        private ComboBox cmbSupplier;
        private ComboBox cmbSort;
        private Button btnAdd;
        private Button btnOrders;
        private FlowLayoutPanel flowProducts;
    }
}
