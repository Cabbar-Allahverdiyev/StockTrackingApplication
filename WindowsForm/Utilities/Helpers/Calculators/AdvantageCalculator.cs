using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using WindowsForm.Core.Constants.ControllerNames.SettingForm;
using WindowsForm.Core.Constants.Messages.WeekMessgaes;

namespace WindowsForm.Utilities.Helpers.Calculators
{
    public static class AdvantageCalculator
    {
        public static int SelectedDayWhichOfTheWeek(string day)
        {
            List<string> days = WeekMessages.AzerbaijaniMessages();
            for (int i = 0; i < days.Count; i++)
            {
                if (days[i] == day)
                    return i + 1;
            }
            return -1;
        }

        public static decimal WhatIsAdvantageToday(IFormSettingService _formSettingService)
        {
            int day = SelectedDayWhichOfTheWeek(_formSettingService.GetByName(SettingControllerName.ComboBoxWhichDays).Data.Value);
            if (day == (int)DateTime.Now.DayOfWeek)
                return decimal.Parse(_formSettingService.GetByName(SettingControllerName.TextBoxWeeklyInterestRate).Data.Value);
            return decimal.Parse(_formSettingService.GetByName(SettingControllerName.TextBoxIGeneralInterestRate).Data.Value);
        }
    }
}
