using Microsoft.Extensions.DependencyInjection;

namespace StockAPP.Service.Navigation
{
    internal class NavigationService : INavigationService
    {
        private readonly IServiceProvider _provider;
        private Form? _mdiParent;

        public NavigationService(IServiceProvider provider)
        {
            _provider = provider;
        }

        public void NavigateTo<TForm>() where TForm : Form
        {
            if (_mdiParent == null)
            {
                throw new InvalidOperationException("MDI não esta configurado");
            }

            var existingForm = _mdiParent.MdiChildren.FirstOrDefault();

            if (existingForm != null)
            {
                existingForm.Activate();
                return ;
            }

            var form = _provider.GetRequiredService<TForm>();

            form.MdiParent = _mdiParent;
            form.Show();
        }

        public void SetParentMDI(Form parent)
        {
            _mdiParent = parent;
        }
    }
}
