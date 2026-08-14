using StockAPP.DTO.Responses;
using System.ComponentModel;

namespace StockAPP.Views.Stock
{
    public interface IStockView
    {
        BindingList<ProductResponseDTO> ListProducts { get; set; }
        event EventHandler LoadProducts;
    }
}
