using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using BTTUAN3.Database;
using BTTUAN3.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BTTUAN3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDataGridView(dataGridView_data);
        }
        public static void LoadDataGridView(DataGridView gv)
        {
            using (var context = new ProductDbContext())
            {
                var products = context.Products.ToList();
                gv.DataSource = products;
            }
        }
        private void EmptyData()
        {
            input_masp.Text = "";
            input_name.Text = "";
            input_price.Text = "";
            input_capacity.Text = "";
            input_origin.Text = "";
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            string id = input_masp.Text;
            string name = input_name.Text;
            int capacity = Int32.Parse(input_capacity.Text);
            int price = Int32.Parse(input_price.Text);
            string origin = input_origin.Text;
            DateTime dateTime = datetime_expired.Value;
            Insert(id, name, capacity, price, origin, dateTime);
            LoadDataGridView(dataGridView_data);
            MessageBox.Show("Lưu thành công");
            EmptyData();
        }

        private void btn_jp_Click(object sender, EventArgs e)
        {
            using (var context = new ProductDbContext())
            {
                var jpProducts = context.Products.Where(p => p.Origin == "Nhật Bản").ToList(); // Lọc các sản phẩm có xuất xứ từ Nhật Bản

                // Gán DataTable đã lọc vào DataSource của DataGridView
                dataGridView_query.DataSource = jpProducts;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            EmptyData();
        }

        private void btn_max_price_Click(object sender, EventArgs e)
        {
            using (var context = new ProductDbContext())
            {
                var maxPrice = context.Products.Max(p => p.Price); // Tìm giá cao nhất
                var maxPriceProducts = context.Products.Where(p => p.Price == maxPrice).ToList(); // Lọc các sản phẩm có giá bằng giá cao nhất

                // Hiển thị trong DataGridView
                dataGridView_query.DataSource = maxPriceProducts;
            }
        }

        private void btn_expired_Click(object sender, EventArgs e)
        {
            using (var context = new ProductDbContext())
            {
                var Expired = context.Products.Where(p => p.Expired <= DateTime.Now).ToList();
                dataGridView_query.DataSource = Expired;
            }
        }
        public static void Insert(string id, string name, int capacity, int price, string origin, DateTime expired)
        {
            using (var context = new ProductDbContext())
            {
                var product = new Product
                {
                    Id = id,
                    NameProduct = name,
                    Capacity = capacity,
                    Price = price,
                    Origin = origin,
                    Expired = expired
                };

                context.Products.Add(product);
                context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }
        }
        public static void Delete(int id)
        {
            using (var context = new ProductDbContext())
            {
                var product = context.Products.SingleOrDefault(p => p.Id == id.ToString());
                if (product != null)
                {
                    context.Products.Remove(product);
                    context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                }
            }
        }
        public static List<Product> Load()
        {
            using (var context = new ProductDbContext())
            {
                return context.Products.ToList(); // Trả về danh sách các sản phẩm
            }
        }

        private void btn_delete_all_Click(object sender, EventArgs e)
        {
            using (var context = new ProductDbContext())
            {
                foreach (var product in context.Products)
                    context.Products.Remove(product);
                context.SaveChanges();
            }
            LoadDataGridView(dataGridView_data);
            MessageBox.Show("Xóa thành công!");
        }

        private void btn_delete_expired_Click(object sender, EventArgs e)
        {
            using (var context = new ProductDbContext())
            {
                var check = context.Products.AsQueryable().ToList().FindAll(x => x.Expired <= DateTime.Now);

                if (check.Any())
                {
                    context.Products.RemoveRange(check);
                    context.SaveChanges();
                    LoadDataGridView(dataGridView_data);
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào để xóa.");
                }
                context.SaveChanges();
                LoadDataGridView(dataGridView_data);

            }

        }

        private void btn_check_expired_Click(object sender, EventArgs e)
        {
            using (var context = new ProductDbContext())
            {
                var check = context.Products.AsQueryable().ToList();

                if (check.Exists(x => x.Expired <= DateTime.Now))
                {
                    MessageBox.Show("Tồn tại sản phẩm hết hạn!");
                }
                else
                {
                    MessageBox.Show("Không tồn tại sản phẩm hết hạn!");
                }
            }
        }

        private void button_btw_Click(object sender, EventArgs e)
        {
            if (input_min.Text != "" && input_max.Text != "")
            {
                int min = Int32.Parse(input_min.Text);
                int max = Int32.Parse(input_max.Text);
                if (min < max)
                {
                    using (var context = new ProductDbContext())
                    {
                        var result = context.Products.AsQueryable().ToList().FindAll(x => x.Price >= min && x.Price <= max);
                        dataGridView_query.DataSource = result;
                    }
                }
            }
        }

        private void btn_delete_origin_Click(object sender, EventArgs e)
        {
            if (input_check_origin.Text != "")
            {
                string origin=input_check_origin.Text;
                using (var context = new ProductDbContext())
                {
                    var check = context.Products.AsQueryable().ToList().FindAll(x => x.Origin == origin);
                    if (check.Any())
                    {
                        context.Products.RemoveRange(check);
                        context.SaveChanges();
                        LoadDataGridView(dataGridView_data);
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm nào để xóa.");
                    }
                    context.SaveChanges();
                    LoadDataGridView(dataGridView_data);
                }
            }
        }
    }
}
