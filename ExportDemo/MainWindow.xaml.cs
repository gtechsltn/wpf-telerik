using Microsoft.Win32;
using System.Windows;
using Telerik.Windows.Documents.FormatProviders.Html;
using Telerik.Windows.Documents.FormatProviders.OpenXml.Docx;
using Telerik.Windows.Documents.FormatProviders.Pdf;
using Telerik.Windows.Documents.FormatProviders.Rtf;
using Telerik.Windows.Documents.FormatProviders.Txt;
using Telerik.Windows.Documents.FormatProviders.Xaml;

namespace ExportDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnExportToHtmlClicked(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog { DefaultExt = ".html", Filter = "HTML File (*.html)|*.html" };

            var dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == true)
            {
                using (var outputStream = saveFileDialog.OpenFile())
                {
                    var htmlFormatProvider = new HtmlFormatProvider();
                    htmlFormatProvider.Export(radRichTextBox.Document, outputStream);
                }
            }
        }

        private void OnExportToPdfClicked(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog { DefaultExt = ".pdf", Filter = "PDF File (*.pdf)|*.pdf" };

            var dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == true)
            {
                using (var outputStream = saveFileDialog.OpenFile())
                {
                    var pdfFormatProvider = new PdfFormatProvider();
                    pdfFormatProvider.Export(radRichTextBox.Document, outputStream);
                }
            }
        }

        private void OnExportToRtfClicked(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog { DefaultExt = ".rtf", Filter = "RTF File (*.rtf)|*.rtf" };

            var dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == true)
            {
                using (var outputStream = saveFileDialog.OpenFile())
                {
                    var rtfFormatProvider = new RtfFormatProvider();
                    rtfFormatProvider.Export(radRichTextBox.Document, outputStream);
                }
            }
        }

        private void OnExportToDocxClicked(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog { DefaultExt = ".docx", Filter = "Word Documents (*.docx)|*.docx" };

            var dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == true)
            {
                using (var outputStream = saveFileDialog.OpenFile())
                {
                    var docxFormatProvider = new DocxFormatProvider();
                    docxFormatProvider.Export(radRichTextBox.Document, outputStream);
                }
            }
        }

        private void OnExportToXamlClicked(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog { DefaultExt = ".xaml", Filter = "XAML File (*.xaml)|*.xaml" };

            var dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == true)
            {
                using (var outputStream = saveFileDialog.OpenFile())
                {
                    var xamlFormatProvider = new XamlFormatProvider();
                    xamlFormatProvider.Export(radRichTextBox.Document, outputStream);
                }
            }
        }

        private void OnExportToTxtClicked(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog { DefaultExt = ".txt", Filter = "Text File (*.txt)|*.txt" };

            var dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == true)
            {
                using (var outputStream = saveFileDialog.OpenFile())
                {
                    var txtFormatProvider = new TxtFormatProvider();
                    txtFormatProvider.Export(radRichTextBox.Document, outputStream);
                }
            }
        }
    }
}
