namespace StockAPP.Service.Navigation
{
    public interface INavigationService
    {
        void SetParentMDI(Form parent);
        void NavigateTo<TForm>() where TForm : Form;
    }
}
