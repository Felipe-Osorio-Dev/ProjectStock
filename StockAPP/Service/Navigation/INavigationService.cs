namespace StockAPP.Service.Navigation
{
    internal interface INavigationService
    {
        void SetParentMDI(Form parent);
        void NavigateTo<TForm>() where TForm : Form, new();
    }
}
