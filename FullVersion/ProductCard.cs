using System.Data;

namespace ShoeShop
{
    public partial class ProductCard : UserControl
    {
        public ProductCard(DataRow row)
        {
            InitializeComponent();
            decimal price = (decimal)row["price"];
            int discount = (int)row["discount"];
            int quantity = (int)row["quantity"];
            picPhoto.Image = Db.LoadImage(row["photo"].ToString());
            lblTitle.Text = $"{row["category"]} | {row["name"]}";
            lblInfo.Text = $"Описание товара: {row["description"]}\nПроизводитель: {row["manufacturer"]}\nПоставщик: {row["supplier"]}";
            lblPrice.Text = $"{price:0.00}";
            lblStock.Text = $"Единица измерения: {row["unit"]}\nКоличество на складе: {quantity}";
            lblDiscount.Text = $"Действующая скидка\n{discount}%";
            if (discount > 0)
            {
                lblPrice.Font = new Font(lblPrice.Font, FontStyle.Strikeout);
                lblPrice.ForeColor = Color.Red;
                lblNewPrice.Text = $"{price * (100 - discount) / 100:0.00}";
            }
            if (discount > 15)
                BackColor = Color.SeaGreen; // #2E8B57
            if (quantity == 0)
                BackColor = Color.LightBlue;
            // Клик по фото или надписи считается кликом по всей карточке
            foreach (Control control in Controls)
                control.Click += (sender, e) => OnClick(e);
        }
    }
}
