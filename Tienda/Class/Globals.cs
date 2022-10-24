using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.SQL;

namespace Tienda.Class
{
    class Globals
    {
        private static SQLCon _SQLCon = new SQLCon();
        private static Menu _menuForm;
        private static CheckoutMain _checkout = new CheckoutMain();
        private static GastosForm _gastos = new GastosForm();
        private static ProductosMain _productosForm = new ProductosMain();
        private static bool hideMercaderia = true;

        public static void Notify(string msg, string tittle, Notification.alertTypeEnum _type)
        {
            Notification notificaciones = new Notification();
            notificaciones.ShowInTaskbar = false;
            notificaciones.BringToFront();
            notificaciones.TopMost = true;
            notificaciones.setAlert(msg, tittle, _type);
        }

        public static SQLCon getSQLCon()
        {
            return _SQLCon;
        }

        public static void setSQLCon(SQLCon _con)
        {
            _SQLCon = _con;
        }

        public static Menu getMenu()
        {
            return _menuForm;
        }

        public static CheckoutMain getCheckout()
        {
            return _checkout;
        }

        public static GastosForm getGastos()
        {
            return _gastos;
        }

        public static void setCheckout(CheckoutMain _newCheckout)
        {
            _checkout = _newCheckout;
        }

        public static void setMenu(Menu _form)
        {
            _menuForm = _form;
        }

        public static bool getHideStatus()
        {
            return hideMercaderia;
        }

        public static void setHideStatus(bool status)
        {
            hideMercaderia = status;
        }

        public static void setProductsForm(ProductosMain _form)
        {
            _productosForm = _form;
        }

        public static ProductosMain getProductsForm()
        {
            return _productosForm;
        }
    }
}
