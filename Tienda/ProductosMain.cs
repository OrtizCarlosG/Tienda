using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.Class;
using System.Drawing.Printing;
namespace Tienda
{
    public partial class ProductosMain : Form
    {

        private Productos _productos;
        private bool _print = false;
        private Etiqueta etiqueta1, etiqueta2;
        public ProductosMain()
        {
            InitializeComponent();
            Globals.setProductsForm(this);
        }
        private void ProductosMain_Load(object sender, EventArgs e)
        {
            _productos = new Productos();
            Globals.getSQLCon().openDB();
            dataGridView1.DataSource = _productos.getProductos();
            totalLbl.Text = $"${_productos.getProductsTotalPrice()}";
            Globals.getSQLCon().closeDB();
            if (Globals.getHideStatus())
            {
                hideMercaderia.Image = Properties.Resources.icons8_eye_30px;
                totalLbl.Visible = true;
            }
            else
            {
                hideMercaderia.Image = Properties.Resources.icons8_invisible_64px;
                totalLbl.Visible = false;
            }
        }

        private void addProdBtn_Click(object sender, EventArgs e)
        {
            Globals.getMenu().openFormInPanel(new ProductosForm());
        }

        private void modProdBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ProductosForm _form = new ProductosForm();
                Globals.getSQLCon().openDB();
                string _code = Productos.getProductCode(getProductName(), getProductType(), getProductSize(), getProductPrice());
                Globals.getSQLCon().closeDB();
                _form.setProductData(getProductName(), getProductType(), getProductSize(), getProductPrice(), getProductSex(), getProductAmount(), _code);
                Globals.getMenu().openFormInPanel(_form);
            } else
            {
                Globals.Notify("Seleccione el producto que desea modificar!", "Productos", Notification.alertTypeEnum.Error);
            }
        }

        private string getProductName()
        {
            int i = dataGridView1.SelectedCells[0].RowIndex;
            return dataGridView1.Rows[i].Cells[0].Value.ToString();
        }

        private string getProductType()
        {
            int i = dataGridView1.SelectedCells[1].RowIndex;
            return dataGridView1.Rows[i].Cells[1].Value.ToString();
        }
        private string getProductSize()
        {
            int i = dataGridView1.SelectedCells[2].RowIndex;
            return dataGridView1.Rows[i].Cells[2].Value.ToString();
        }
        private float getProductPrice()
        {
            int i = dataGridView1.SelectedCells[3].RowIndex;
            return float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
        }
        private string getProductSex()
        {
            int i = dataGridView1.SelectedCells[4].RowIndex;
            return dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private int getProductAmount()
        {
            int i = dataGridView1.SelectedCells[5].RowIndex;
            return Int32.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DeleteProductForm _form = new DeleteProductForm();
                _form.setProductData(getProductName(), getProductType(), getProductSize(), getProductSex(), getProductPrice(), getProductAmount());
                _form.ShowDialog();
                
            } else
            {
                Globals.Notify("Seleccione el producto que desea eliminar!", "Productos", Notification.alertTypeEnum.Error);
            }
        }

        public void refreshTotalPrice()
        {
            dataGridView1.DataSource = _productos.getProductos();
            totalLbl.Text = $"${_productos.getProductsTotalPrice()}";
        }

        private void proyectoZTextBox1__TextChanged(object sender, EventArgs e)
        {
            _productos.getProductos().DefaultView.RowFilter = "Producto LIKE '%" + searchTxt.Texts + "%' OR Tipo LIKE '%" + searchTxt.Texts + "%' OR RawCode LIKE '%" + searchTxt.Texts +"%'";
        }

        private void ticketBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (!_print)
                {
                    if (etiqueta1 == null)
                    {
                        Globals.getSQLCon().openDB();
                        string codigo = Productos.getProductCode(getProductName(), getProductType(), getProductSize(), getProductPrice());
                        Globals.getSQLCon().closeDB();
                        if (string.IsNullOrEmpty(codigo))
                        {
                            Globals.Notify("Este producto no cuenta con un codigo de barras asignado", "Productos", Notification.alertTypeEnum.Error);
                            return;
                        }
                        etiqueta1 = new Etiqueta(getProductName(), codigo, getProductSize(), getProductPrice());
                        Globals.Notify("Seleccione el segundo producto para imprimir su etiqueta", "Productos", Notification.alertTypeEnum.Info);
                    }
                    else
                    {
                        Globals.getSQLCon().openDB();
                        string codigo = Productos.getProductCode(getProductName(), getProductType(), getProductSize(), getProductPrice());
                        Globals.getSQLCon().closeDB();
                        if (string.IsNullOrEmpty(codigo))
                        {
                            Globals.Notify("Este producto no cuenta con un codigo de barras asignado", "Productos", Notification.alertTypeEnum.Error);
                            return;
                        }
                        etiqueta2 = new Etiqueta(getProductName(), codigo, getProductSize(), getProductPrice());
                        _print = true;
                    }
                }
                if (_print)
                {
                    printDocument1 = new PrintDocument();
                    PrinterSettings ps = new PrinterSettings();
                    ps.DefaultPageSettings.PaperSize = new PaperSize("Custom", 450, 100);
                    //ps.DefaultPageSettings.Landscape = true;
                    printDocument1.PrinterSettings = ps;
                    printDocument1.PrintPage += ImprimirTickets;
                    PrintDialog printdlg = new PrintDialog();
                    PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();

                    // preview the assigned document or you can create a different previewButton for it
                    printPrvDlg.Document = printDocument1;
                    printPrvDlg.ShowDialog(); // this shows the preview and then show the Printer Dlg below

                    printdlg.Document = printDocument1;

                    if (printdlg.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                    etiqueta1 = null;
                    etiqueta2 = null;
                    _print = false;
                }
            } else
            {
                Globals.Notify("No hay productos para generar codigos de barra", "Productos", Notification.alertTypeEnum.Error);
            }

        }

        private void ImprimirTickets(object sender, PrintPageEventArgs e)
        {
          

            BarcodeLib.Barcode Code = new BarcodeLib.Barcode();
            Code.IncludeLabel = true;
            Code.DisableEAN13CountryException = true;
            Image barCode = Code.Encode(BarcodeLib.TYPE.EAN13, etiqueta1.getCodigo(), Color.Black, Color.White, 187, 50);
            e.Graphics.DrawImage(barCode, new Point(0,40));
            Font arialFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            e.Graphics.DrawString(etiqueta1.getProducto(), arialFont, Brushes.Black, new Point(10, 5));
            if (!string.IsNullOrEmpty(etiqueta1.getTalle()))
                e.Graphics.DrawString($"T: {etiqueta1.getTalle()}", arialFont, Brushes.Black, new Point(145, 5));
            e.Graphics.DrawString($"${etiqueta1.getPrecio()}", arialFont, Brushes.Black, new Point(75, 20));

            // PRODUCTO 2
            Image barCode2 = Code.Encode(BarcodeLib.TYPE.EAN13, etiqueta2.getCodigo(), Color.Black, Color.White, 187, 50);
            e.Graphics.DrawImage(barCode2, new Point(215, 40));
            e.Graphics.DrawString(etiqueta2.getProducto(), arialFont, Brushes.Black, new Point(215, 5));
            if (!string.IsNullOrEmpty(etiqueta2.getTalle()))
                e.Graphics.DrawString($"T: {etiqueta2.getTalle()}", arialFont, Brushes.Black, new Point(355, 5));
            e.Graphics.DrawString($"${etiqueta2.getPrecio()}", arialFont, Brushes.Black, new Point(275, 20));
        }

        private void hideMercaderia_MouseEnter(object sender, EventArgs e)
        {
            if (Globals.getHideStatus())
            {
                hideMercaderia.Image = Properties.Resources.icons8_eye_30px_1;
            } else
            {
                hideMercaderia.Image = Properties.Resources.icons8_invisible_64px_1;
            }
        }

        private void hideMercaderia_MouseLeave(object sender, EventArgs e)
        {
            if (Globals.getHideStatus())
            {
                hideMercaderia.Image = Properties.Resources.icons8_eye_30px;
            }
            else
            {
                hideMercaderia.Image = Properties.Resources.icons8_invisible_64px;
            }
        }

        private void hideMercaderia_Click(object sender, EventArgs e)
        {
            if (Globals.getHideStatus())
            {
                Globals.setHideStatus(false);
                hideMercaderia.Image = Properties.Resources.icons8_invisible_64px_1;
                totalLbl.Visible = false;
            } else
            {
                Globals.setHideStatus(true);
                hideMercaderia.Image = Properties.Resources.icons8_eye_30px_1;
                totalLbl.Visible = true;
            }
        }

        //OLD CODE
        //Globals.getSQLCon().openDB();
        //string codigo = Productos.getProductCode(getProductName(), getProductType(), getProductSize());
        //Globals.getSQLCon().closeDB();
        //  if (string.IsNullOrEmpty(codigo))
        //{
        //  Globals.Notify("Este producto no cuenta con un codigo de barras asignado", "Productos", Notification.alertTypeEnum.Error);
        //return;
        //}
        //BarcodeLib.Barcode Code = new BarcodeLib.Barcode();
        //Code.IncludeLabel = true;
        //Image _image = DrawFilledRectangle(55, 45);
        //Image barCode = Code.Encode(BarcodeLib.TYPE.CODE128, codigo, Color.Black, Color.White);
        //Font arialFont = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
        //e.Graphics.DrawImage(barCode, new Point(3,3));
        //e.Graphics.DrawString(getProductName(), arialFont, Brushes.Black, new Point(0, 0));
        //e.Graphics.DrawString($"Talle: {getProductSize()}", arialFont, Brushes.Black, new Point(3, 0));
        //e.Graphics.DrawString($"${getProductPrice()}", arialFont, Brushes.Black, new Point(3, 50));
        //SaveFileDialog saveBtn = new SaveFileDialog();
        //saveBtn.AddExtension = true;
        //saveBtn.Filter = "Imagee PNG (*.png) | *.png";
        //saveBtn.ShowDialog();
        //if (!string.IsNullOrEmpty(saveBtn.FileName))
        //{
        //    _image.Save(saveBtn.FileName, ImageFormat.Png);
        //}
        //_image.Dispose();
        private Bitmap DrawFilledRectangle(int x, int y)
        {
            Bitmap bmp = new Bitmap(x, y);
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle ImageSize = new Rectangle(0, 0, x, y);
                graph.FillRectangle(Brushes.White, ImageSize);
            }
            return bmp;
        }
    }
}
