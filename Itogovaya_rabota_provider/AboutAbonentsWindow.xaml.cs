using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Word = Microsoft.Office.Interop.Word;

namespace Itogovaya_rabota_provider
{
    /// <summary>
    /// Логика взаимодействия для AboutAbonentsWindow.xaml
    /// </summary>
    public partial class AboutAbonentsWindow : Window
    {
        public AboutAbonentsWindow()
        {
            InitializeComponent();
        }

        private void BtnExportToWord_Click(object sender, RoutedEventArgs e)
        {
            var application = new Word.Application();
            Word.Document document = application.Documents.Add();

            // Сохраняем документ
            string docxPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Test1.docx");
            string pdfPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Test1.pdf");

            document.SaveAs2(docxPath);
            document.SaveAs2(pdfPath, Word.WdExportFormat.wdExportFormatPDF);

            // Открываем документ для просмотра
            application.Visible = true;
        }
    }
}
