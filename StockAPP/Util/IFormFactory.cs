namespace StockAPP.Util
{
    public interface IFormFactory
    {
        TForm CreateForm<TForm, TPresenter>() where TForm : Form where TPresenter : class;
    }
}
