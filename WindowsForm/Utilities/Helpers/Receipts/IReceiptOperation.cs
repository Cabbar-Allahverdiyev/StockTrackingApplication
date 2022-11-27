using Business.Abstract;
using Core.Utilities.Results;
using Entities.DTOs.CartDtos;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForm.Utilities.Helpers.Receipts
{
    public interface IReceiptOperation
    {
        IDataResult<PrintDocument> PrepareAReceipt(System.Drawing.Printing.PrintPageEventArgs e,
                                                          PrintDocument printDocReceipt,
                                                          IDataResult<CartListDtoForReceipt> carts,
                                                          ReceiptDto receiptDto);
        IResult PrintReceipt(PrintPreviewDialog printPreviewDialog,
                                    PrintDocument printDocReceipt);

        void PrintShowDialog(PrintDocument printDocReceipt);

        IResult PrintReceiptCheckedIsTrue(IUserService userService,
                                                IBonusCardService bonusCardService,
                                                int userId,
                                                int bonusCardId,
                                                bool situation,
                                                decimal bonusIcreasedValue,
                                                ref ReceiptDto receiptDto,
                                                PrintDocument printDocReceipt,
                                                PrintPreviewDialog printPreviewDialogReceipt);
    }
}
