using StockAPP.Util;

namespace StockAPP.Service.Navigation
{
    internal class NavigationService : INavigationService
    {
        private readonly IFormFactory _formFactory;
        private Form? _mdiParent;

        public NavigationService(IFormFactory formFactory)
        {
            _formFactory = formFactory;
        }

        public void NavigateTo<TForm, TPresenter>() where TForm : Form where TPresenter : class
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

            var form = _formFactory.CreateForm<TForm, TPresenter>();

            form.MdiParent = _mdiParent;
            form.Show();
        }

        public void SetParentMDI(Form parent)
        {
            _mdiParent = parent;
        }
    }
}
