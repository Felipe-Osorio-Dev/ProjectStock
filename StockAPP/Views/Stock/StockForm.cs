using StockAPP.DTO.Responses;
using System.ComponentModel;

namespace StockAPP.Views.Stock
{
    public partial class StockForm : Form, IStockView
    {
        private readonly BindingSource _bindingSource = new();
        public StockForm()
        {
            InitializeComponent();
            dgvProducts.DataSource = _bindingSource;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadProducts?.Invoke(this, EventArgs.Empty);
        }

        public BindingList<ProductResponseDTO> ListProducts 
        {   
            get => new BindingList<ProductResponseDTO>();
            set => _bindingSource.DataSource = value; 
        }

        public event EventHandler LoadProducts;
    }
}
