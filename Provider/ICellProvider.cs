using System;
using System.Collections;
using System.Collections.Generic;

public interface ICellProvider
{
    int Count
    {
        get;
    }

    string GetLabel(int col, Object obj);

    string[] GetAllLabel();

    Func<Object> GetCellAccessor(Object obj);
}