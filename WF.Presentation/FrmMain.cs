using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Repository.EF;
using Repository.Commom;
using WF.Presentation.ViewModel;

namespace WF.Presentation
{
    public partial class FrmMain : Form
    {
        private readonly IRepositoryGeneric<Brand> brandRepository = new BrandRepository();
        private readonly IRepositoryGeneric<Product> productRepository = new ProductRepository();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewMarcasAsync();
            PreencherDataGridViewProdutosAsync();
        }

        #region CarregaDataGridViews()
        private async void PreencherDataGridViewMarcasAsync()
        {
            List<Brand> brands = await brandRepository.GetAll();
            List<BrandViewModel> brandViewModel = new List<BrandViewModel>();
            foreach (var brand in brands)
            {
                BrandViewModel vm = new BrandViewModel()
                {
                    Id = brand.Id,
                    Name = brand.Name
                };
                brandViewModel.Add(vm);
            }
            dvgMarcas.Invoke((MethodInvoker)delegate
            {
                dvgMarcas.DataSource = brandViewModel;
                dvgMarcas.Refresh();
            });
        }

        private async void PreencherDataGridViewProdutosAsync()
        {
            List<Product> products = await productRepository.GetAll();
            List<ProductModelView> productModelViews = new List<ProductModelView>();
            foreach (var product in products)
            {
                ProductModelView vm = new ProductModelView
                {
                    Id = product.Id,
                    IdBrand = product.IdBrand,
                    Name = product.Name,
                    ProductBrand = product.ProductBrand.Name
                };
                productModelViews.Add(vm);
            }
            dvgProdutos.Invoke((MethodInvoker)delegate
            {
                dvgProdutos.DataSource = productModelViews;
                dvgProdutos.Refresh();
            });
        }
        #endregion

        #region Marca()
        private void btnCadastrarMarca_Click(object sender, EventArgs e)
        {
            new FrmMarca().ShowDialog();
            PreencherDataGridViewMarcasAsync();
        }
        private void btnAlterarMarca_Click(object sender, EventArgs e)
        {
            Brand brand = GetMarcaSelecionada();
            if (brand != null)
            {
                new FrmMarca(brand).ShowDialog();
                PreencherDataGridViewMarcasAsync();
                PreencherDataGridViewProdutosAsync();
            }
            else
            {
                MessageBox.Show("Selecione uma marca.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeletarMarca_Click(object sender, EventArgs e)
        {
            Brand brand = GetMarcaSelecionada();

            if (brand != null)
            {
                brandRepository.Delete(brand);
                PreencherDataGridViewMarcasAsync();
                PreencherDataGridViewProdutosAsync();
            }
            else
            {
                MessageBox.Show("Selecione uma marca.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Produto()
        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            new FrmProduto().ShowDialog();
            PreencherDataGridViewProdutosAsync();
        }

        private void btnAtualizarProduto_Click(object sender, EventArgs e)
        {
            Product product = GetProdutoSelecionado();
            if (product != null)
            {
                new FrmProduto(product).ShowDialog();
                PreencherDataGridViewProdutosAsync();
            }
            else
            {
                MessageBox.Show("Selecione um produto.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeletarProduto_Click(object sender, EventArgs e)
        {
            Product product = GetProdutoSelecionado();
            if (product != null)
            {
                productRepository.Delete(product);
                PreencherDataGridViewProdutosAsync();
                PreencherDataGridViewMarcasAsync();
            }
            else
            {
                MessageBox.Show("Selecione uma marca.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Metodos de Retorno()
        private Product GetProdutoSelecionado()
        {
            if (dvgProdutos.SelectedRows.Count > 0)
            {
                int idProdutoSelecionado = Convert.ToInt32(dvgProdutos.SelectedRows[0].Cells[0].Value);
                Product product = productRepository.GetById(idProdutoSelecionado);
                return product;
            }
            else
            {
                return null;
            }
        }

        private Brand GetMarcaSelecionada()
        {
            if (dvgMarcas.SelectedRows.Count > 0)
            {
                int idMarcaSelecionada = Convert.ToInt32(dvgMarcas.SelectedRows[0].Cells[0].Value);
                Brand marcaSelecionada = brandRepository.GetById(idMarcaSelecionada);
                return marcaSelecionada;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
