using StockAPP.Service.Navigation;
using StockAPP.Views.MainContainer;
using StockAPP.Views.RegisterForm;

namespace StockAPP.Presenters.Main
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly INavigationService _navigationService;

        public MainPresenter(IMainView view, INavigationService navigationService)
        {
            _view = view;
            _navigationService = navigationService;

            _navigationService.SetParentMDI((Form) _view);

            _view.ClickedRegisterProducts += OnClickedRegisterProducts;
        }

        private void OnClickedRegisterProducts(object sender, EventArgs e)
        {
            using(RegisterDialog dialog = new RegisterDialog())
            {
                if(dialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }


            }
        }
    }
}
