using StockAPP.DTO.Responses;
using StockAPP.Service.Api;
using StockAPP.Views.Stock;
using System.ComponentModel;

namespace StockAPP.Presenters.Stock
{
    public class StockPresenter
    {
        private readonly IStockView _view;
        private readonly IProductService _service;

        public StockPresenter(IStockView view, IProductService productService)
        {
            _view = view;
            _service = productService;

            _view.LoadProducts += OnLoadProducts;
        }

        private async void OnLoadProducts(object sender, EventArgs e)
        {
            var response = await _service.LoadProductsAsync();
            _view.ListProducts = new BindingList<ProductResponseDTO>(response.Value);
        }
    }
}
