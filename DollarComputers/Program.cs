using DollarComputers.Models;
using DollarComputers.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public static class Program
    {
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static OrderForm orderForm;
        public static AboutForm aboutForm;
        public static ProductInfoForm productInfoForm;
        public static SelectForm selectForm;

        public static Product product;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splashForm = new SplashForm();
            startForm = new StartForm();
            orderForm = new OrderForm();
            aboutForm = new AboutForm();
            productInfoForm = new ProductInfoForm();
            selectForm = new SelectForm();

            product = new Product();

            Application.Run(selectForm);
        }
    }
}
