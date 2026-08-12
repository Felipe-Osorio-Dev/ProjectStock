using StockAPP.DTO.Requests;
using StockAPP.Service.Api;
using StockAPP.Service.Navigation;
using StockAPP.Views.MainContainer;
using StockAPP.Views.RegisterForm;

namespace StockAPP.Presenters.Main
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly INavigationService _navigationService;
        private readonly IProductService _service;

        public MainPresenter(IMainView view, INavigationService navigationService, IProductService service)
        {
            _view = view;
            _navigationService = navigationService;
            _service = service;

            _navigationService.SetParentMDI((Form) _view);

            _view.ClickedRegisterProducts += OnClickedRegisterProducts;
        }

        private async void OnClickedRegisterProducts(object sender, EventArgs e)
        {
            using(RegisterDialog dialog = new RegisterDialog())
            {
                if(dialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                var createProduct = new RegisterProductDTO
                {
                    Name = dialog.ProductName,
                    EAN = dialog.EAN,
                    Amount = dialog.Amount,
                    Validate = dialog.Validate
                };

                var result = await _service.RegisterProductAsync(createProduct);

                if(result.IsSuccess)
                {
                    MessageBox.Show("O produto: " + result.Value.Name + " foi cadastrado com sucesso.");
                    return;
                }

                MessageBox.Show(result.Error);
            }
        }
    }
}
