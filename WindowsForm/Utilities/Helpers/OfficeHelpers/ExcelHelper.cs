using Babel.Licensing;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.DTOs.ProductDtos.ForAPI;
using System;
using System.Collections.Generic;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsForm.Utilities.Helpers.OfficeHelpers
{
    public class ExcelHelper
    {
        private readonly IProductService _productService;
        public ExcelHelper(IProductService productService)
        {
            _productService = productService;
        }

        public void CreateExcel()
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();
            List<ExcelDto> products = _productService.GetAllByForExcelDto().Data;
            List<string> columnNames = new List<string>() { "S/S",
                                                            "Malın adı",
                                                            "Malın ədədi",
                                                            "Malın kodu (barkod)",
                                                            "Malın alış qiyməti",
                                                            "Malın satış qiyməti",
                                                            "Qeyd"};

            for (int i = 0; i < columnNames.Count; i++)
            {
                excelApp.Cells[1, i + 1] = columnNames[i];
            }
            for (int i = 1; i < products.Count+1; i++)
            {
                int columnIndex = 1;
                ExcelDto product = products[i-1];
                int rowIndex = i ;
                excelApp.Cells[rowIndex + 1, columnIndex] = i;
                columnIndex++;

                excelApp.Cells[rowIndex + 1, columnIndex] = product.ProductName;
                columnIndex++;

                excelApp.Cells[rowIndex + 1, columnIndex] = product.UnitsInStock;
                columnIndex++;

                excelApp.Cells[rowIndex + 1, columnIndex] = product.BarcodeNumber;
                columnIndex++;

                excelApp.Cells[rowIndex + 1, columnIndex] = product.PurchasePrice;
                columnIndex++;

                excelApp.Cells[rowIndex + 1, columnIndex] = product.UnitPrice;
                columnIndex++;

                //excelApp.Cells[rowIndex + 1, columnIndex] = product.Description;
                //columnIndex++;
            }
            excelApp.Visible = true;
        }
    }
}
