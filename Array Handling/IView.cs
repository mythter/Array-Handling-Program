/*
Файл: IView.cs
Лабораторная робота № 3
Автор: Положий А. С.
Тема: Розробка та дослідження програми обробки масивів
Дата створення: 09.03.2023
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHandling
{
    internal interface IView
    {
        // Numeric Up Down.
        int N { get; set; }
        int A { get; set; }
        int B { get; set; }

        // Text fields. 
        string InitialArr { get; set; }
        string Result { get; set; }

        // Radio buttons.
        bool Op1 { get; set; }
        bool Op2 { get; set; }
        bool Op3 { get; set; }
        bool Op4 { get; set; }

        // Buttons.
        event EventHandler GenerateAttempted;
        event EventHandler WriteF1Attempted;
        event EventHandler WriteF2Attempted;
        event EventHandler ReadF1Attempted;

        // Helpers.
        event EventHandler RadioCheckChanged;

        // Program data.
        int[] Array { get; set; }

        // File dialogs.
        SaveFileDialog Save { get; set; }
        OpenFileDialog Open { get; set; }

        // Data grid view.
        DataGridView DataGrid { get; set; }
    }
}
