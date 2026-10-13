namespace ShoeShop
{
    partial class OrdersForm
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
            btnAdd = new Button();
            lblUser = new Label();
            btnBack = new Button();
            flowOrders = new FlowLayoutPanel();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.Chartreuse;
            panelHeader.Controls.Add(picLogo);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnAdd);
            panelHeader.Controls.Add(lblUser);
            panelHeader.Controls.Add(btnBack);
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
            lblTitle.Size = new Size(90, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Заказы";
            //
            // btnAdd
            //
            btnAdd.BackColor = Color.MediumSpringGreen;
            btnAdd.Location = new Point(220, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(160, 40);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Добавить заказ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            //
            // lblUser
            //
            lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUser.Location = new Point(520, 10);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(350, 50);
            lblUser.TabIndex = 3;
            lblUser.Text = "ФИО";
            lblUser.TextAlign = ContentAlignment.MiddleRight;
            //
            // btnBack
            //
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.Location = new Point(880, 15);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(105, 40);
            btnBack.TabIndex = 4;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            //
            // flowOrders
            //
            flowOrders.AutoScroll = true;
            flowOrders.Dock = DockStyle.Fill;
            flowOrders.FlowDirection = FlowDirection.TopDown;
            flowOrders.Location = new Point(0, 70);
            flowOrders.Name = "flowOrders";
            flowOrders.Size = new Size(1000, 580);
            flowOrders.TabIndex = 1;
            flowOrders.WrapContents = false;
            //
            // OrdersForm
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1000, 650);
            Controls.Add(flowOrders);
            Controls.Add(panelHeader);
            Name = "OrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ООО «Обувь» — Заказы";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox picLogo;
        private Label lblTitle;
        private Button btnAdd;
        private Label lblUser;
        private Button btnBack;
        private FlowLayoutPanel flowOrders;
    }
}
