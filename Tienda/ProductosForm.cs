using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.Class;

namespace Tienda
{
    public partial class ProductosForm : Form
    {

        private int formStyle = 0; // 0 = ADD 1 = EDIT

        private string _productName, _productType, _productSex, _productCode, _productSize;
        private int _productAmount;
        private float _productPrice;

        public ProductosForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Globals.getMenu().openFormInPanel(new ProductosMain());
        }

        private void productoNameTxt__TextChanged(object sender, EventArgs e)
        {

        }

        private void saveProductBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productoNameTxt.getTexts()) || productoNameTxt.getTexts().Equals(productoNameTxt.PlaceholderText))
            {
                Globals.Notify("No se ha ingresado el nombre del producto", "Productos", Notification.alertTypeEnum.Error);
                return;
            }
            if (string.IsNullOrEmpty(productTypeTxt.Texts))
            {
                Globals.Notify("No se ha ingresado el tipo del producto", "Productos", Notification.alertTypeEnum.Error);
                return;
            }
            if (string.IsNullOrEmpty(prodPriceText.Texts) || prodPriceText.getTexts().Equals(prodPriceText.PlaceholderText))
            {
                Globals.Notify("No se ha ingresado el precio del producto", "Productos", Notification.alertTypeEnum.Error);
                return;
            }
            bool priceSuccess = float.TryParse(prodPriceText.Texts, out float price);
            if (!priceSuccess)
            {
                Globals.Notify("El precio del producto debe de ser un numero", "Productos", Notification.alertTypeEnum.Error);
                return;
            }
            if (!manRadio.Checked && !womanRadio.Checked && !undefinedRadio.Checked)
            {
                Globals.Notify("Selecciona un genero para el producto", "Productos", Notification.alertTypeEnum.Error);
                return;
            }
            if (string.IsNullOrEmpty(amountText.Texts) || amountText.getTexts().Equals(amountText.PlaceholderText))
            {
                Globals.Notify("No se ha ingresado la cantidad del producto", "Productos", Notification.alertTypeEnum.Error);
                return;
            }
            bool amountSuccess = int.TryParse(amountText.Texts, out int amount);
            if (!amountSuccess)
            {
                Globals.Notify("La cantidad del producto debe de ser un numero", "Productos", Notification.alertTypeEnum.Error);
                return;
            }

            if (formStyle.Equals(0))
            {
                string _sex = "Hombre";
                if (womanRadio.Checked)
                    _sex = "Mujer";
                else if (undefinedRadio.Checked)
                    _sex = "Indefinido";

                Globals.getSQLCon().openDB();
                Productos.addNewProduct(productoNameTxt.Texts, productTypeTxt.Texts, prodSizeText.Texts, float.Parse(prodPriceText.Texts), _sex, int.Parse(amountText.Texts));
                Globals.Notify("Se ha guardado el producto!", "Productos", Notification.alertTypeEnum.Success);
                Globals.getSQLCon().closeDB();
            } else if (formStyle.Equals(1))
            {
                string _sex = "Hombre";
                if (womanRadio.Checked)
                    _sex = "Mujer";
                else if (undefinedRadio.Checked)
                    _sex = "Indefinido";
                string productName = productoNameTxt.Texts;
                    if (string.IsNullOrEmpty(productName))
                        productName = productoNameTxt.getTexts();
                string prodType = productTypeTxt.Texts;
                if (string.IsNullOrEmpty(prodType))
                    prodType = productTypeTxt.getTexts();
                float productPrice = float.Parse(prodPriceText.getTexts());
                if (string.IsNullOrEmpty(prodPriceText.Texts))
                    productPrice = float.Parse(prodPriceText.PlaceholderText);
                int productAmount = Int32.Parse(amountText.getTexts());
                if (string.IsNullOrEmpty(amountText.Texts))
                    productAmount = Int32.Parse(amountText.PlaceholderText);
                string prodSize = "";
                if (!prodSizeText.Texts.Equals(prodSizeText.PlaceholderText))
                    prodSize = prodSizeText.Texts;
                Globals.getSQLCon().openDB();
                Productos.updateProductData(_productName, productName, _productType, prodType, _productSize, prodSize, _productPrice, productPrice, _productSex, _sex, _productAmount, productAmount);
                Globals.Notify("Se han guardado los cambios en el producto!", "Productos", Notification.alertTypeEnum.Success);
                Globals.getSQLCon().closeDB();
            }
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            if (formStyle.Equals(1))
            {
                saveProductBtn.Focus();
                productoNameTxt.Texts = _productName;
                productoNameTxt.setTexts(_productName);
                productTypeTxt.Texts = _productType;
                productTypeTxt.setTexts(_productType);
                prodSizeText.setTexts(_productSize.ToString());
                prodSizeText.Texts = _productSize.ToString();
                prodPriceText.setTexts(_productPrice.ToString());
                prodPriceText.Texts = _productPrice.ToString();
                amountText.setTexts(_productAmount.ToString());
                amountText.Texts = _productAmount.ToString();
                productoNameTxt.Texts = _productName;
                productoNameTxt.setTexts(_productName);
                productTypeTxt.Texts = _productType;
                productTypeTxt.setTexts(_productType);
                if (_productSex.Equals("Hombre"))
                    manRadio.Checked = true;
                else if (_productSex.Equals("Mujer"))
                    womanRadio.Checked = true;
                else if (_productSex.Equals("Indefinido"))
                    undefinedRadio.Checked = true;
            }
        }

        public void setProductData(string name, string type, string size, float price, string sex, int amount, string code)
        {
            formStyle = 1;
            this._productName = name;
            this._productType = type;
            this._productSize = size;
            this._productPrice = price;
            this._productSex = sex;
            this._productAmount = amount;
            this._productCode = code;
        }
    }
}
