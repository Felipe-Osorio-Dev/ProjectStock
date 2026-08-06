using StockAPP.Presenters.Main;
using StockAPP.Views.MainContainer;

namespace StockAPP
{
    public partial class MainContainerMDI : Form, IMainView
    {
        public MainContainerMDI()
        {
            InitializeComponent();
        }

        public event EventHandler ClickedRegisterProducts;

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClickedRegisterProducts?.Invoke(this, EventArgs.Empty);
        }
    }
}
