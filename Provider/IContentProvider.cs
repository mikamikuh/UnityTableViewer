using System;
using System.Collections;
using System.Collections.Generic;

public interface IContentProvider
{
    int Count
    {
        get;
    }

    IList<ICellData> Contents
    {
        get;
    }
}