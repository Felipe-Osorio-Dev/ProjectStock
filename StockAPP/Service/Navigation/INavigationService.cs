namespace StockAPP.Service.Navigation
{
    public interface INavigationService
    {
        void SetParentMDI(Form parent);
        void NavigateTo<TForm, TPresenter>() where TForm : Form where TPresenter : class;
    }
}
