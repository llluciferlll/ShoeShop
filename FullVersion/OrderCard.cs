using System.Data;

namespace ShoeShop
{
    public partial class OrderCard : UserControl
    {
        public OrderCard(DataRow row)
        {
            InitializeComponent();
            lblArticle.Text = $"Артикул заказа: {row["articles"]}";
            lblInfo.Text = $"Статус заказа: {row["status"]}\nАдрес пункта выдачи: {row["address"]}\nДата заказа: {row["order_date"]:dd.MM.yyyy}";
            lblDelivery.Text = $"Дата доставки\n{row["delivery_date"]:dd.MM.yyyy}";
            foreach (Control control in Controls)
                control.Click += (sender, e) => OnClick(e);
        }
    }
}
