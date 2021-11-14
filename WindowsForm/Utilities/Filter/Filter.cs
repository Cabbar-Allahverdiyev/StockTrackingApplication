using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsForm.Utilities.Filter
{
    class T
    {
        public string MehsulAdi { get; set; }
    }

    public class Filter<T> where T : class, new()
    {
        public IDataResult<List<T>> GetAll(List<T> list, List<T> oldList,string searchText)
        {
            List<T> newProductList = new List<T>();
            List<T> oldProductList = oldList;
            List<T> productList = list;
            searchText = searchText.ToLower();
            for (int i = 0; i < productList.Count; i++)
            {
               
                productList[i].MehsulAdi = productList[i].MehsulAdi.ToLower();
            }

            foreach (var product in productList)
            {
                if (product.MehsulAdi.Contains(searchText))
                {
                    newProductList.Add(product);
                }
            }

            if (textBoxAxtar.Text != "")
            {
                if (newProductList.Count == 0)
                {
                    FormsMessage.ErrorMessage(ProductMessages.ProductNotFound);
                    return;
                }
                dataGridViewFormPrdouctList.DataSource = newProductList;
                return;
            }

            dataGridViewFormPrdouctList.DataSource = oldProductList;
        }

    }
}
