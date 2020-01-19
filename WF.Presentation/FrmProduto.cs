using Domain;
using Repository.Commom;
using Repository.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF.Presentation.ViewModel;

namespace WF.Presentation
{
    public partial class FrmProduto : Form
    {
        private readonly IRepositoryGeneric<Product> productRepository = new ProductRepository();
        private readonly IRepositoryGeneric<Brand> brandRepository = new BrandRepository();
        private Product productToBeUpdate = null;
        public FrmProduto(Product product = null)
        {
            this.productToBeUpdate = product;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void FrmProduto_Load(object sender, EventArgs e)
        {
            if (productToBeUpdate != null)
            {
                this.Text = " - Editar";
                txtNomeProduto.Text = productToBeUpdate.Name.Trim(); ;
            }

            List<Brand> brands = await brandRepository.GetAll();
            List<BrandViewModel> brandViewModels = new List<BrandViewModel>();
            foreach (var brand in brands)
            {
                BrandViewModel vm = new BrandViewModel
                {
                    Id = brand.Id,
                    Name = brand.Name
                };
                brandViewModels.Add(vm);
            }
            cbmMarcas.DataSource = brandViewModels;
            cbmMarcas.DisplayMember = "Name";
            cbmMarcas.ValueMember = "Id";
            cbmMarcas.Refresh();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeProduto = "";
            int idMarca = 0;

            try
            {
                nomeProduto = txtNomeProduto.Text.Trim();
                idMarca = Convert.ToInt32(cbmMarcas.SelectedValue);
                if (idMarca == 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Erro: {ex.HResult}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (productToBeUpdate == null)
                {
                    Product product = new Product
                    {
                        IdBrand = idMarca,
                        Name = nomeProduto
                    };
                    productRepository.Insert(product);
                }
                else
                {
                    productToBeUpdate.Name = nomeProduto;
                    productToBeUpdate.IdBrand = idMarca;
                    productRepository.Update(productToBeUpdate);
                }
            }

            Close();
        }
    }
}
