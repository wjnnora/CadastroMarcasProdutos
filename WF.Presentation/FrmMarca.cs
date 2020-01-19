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

namespace WF.Presentation
{    
    public partial class FrmMarca : Form
    {
        private Brand brandToBeUpdate = null;
        private readonly IRepositoryGeneric<Brand> brandRepository = new BrandRepository();
        public FrmMarca(Brand brand = null)
        {
            this.brandToBeUpdate = brand;
            InitializeComponent();
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            if (brandToBeUpdate != null)
            {
                this.Text += " - Editar";
                txbMarca.Text = brandToBeUpdate.Name;
            }
            else
            {
                txbMarca.Text = string.Empty;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {            
            Brand brand = new Brand();            
            string nomeMarca = "";

            try
            {
                nomeMarca = txbMarca.Text.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Erro: {ex.HResult}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (brandToBeUpdate == null)
                {
                    brand.Name = nomeMarca;
                    brandRepository.Insert(brand);
                }
                else
                {
                    brandToBeUpdate.Name = nomeMarca;
                    brandRepository.Update(brandToBeUpdate);
                }
            }
                    
            Close();
        }
    }
}
