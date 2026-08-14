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
        public event EventHandler ClickedStockProducts;

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClickedRegisterProducts?.Invoke(this, EventArgs.Empty);
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClickedStockProducts?.Invoke(this, EventArgs.Empty);
        }
    }
}
