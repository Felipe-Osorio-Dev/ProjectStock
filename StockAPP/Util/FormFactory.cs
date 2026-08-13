using Microsoft.Extensions.DependencyInjection;

namespace StockAPP.Util
{
    public class FormFactory : IFormFactory
    {
        private readonly IServiceProvider _provider;

        public FormFactory(IServiceProvider provider)
        {
            _provider = provider;
        }

        public TForm CreateForm<TForm, TPresenter>()
            where TForm : Form
            where TPresenter : class
        {
            var form = _provider.GetRequiredService<TForm>();

            var presenter = ActivatorUtilities.CreateInstance<TPresenter>(_provider,form);

            return form;
        }
    }
}
