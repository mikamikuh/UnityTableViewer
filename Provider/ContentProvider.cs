using System;
using System.Collections;
using System.Collections.Generic;

public class ContentProvider : IContentProvider
{

    private IList<ICellData> contents;

    public IList<ICellData> Contents
    {
        get
        {
            return this.contents;
        }
    }

    public int Count
    {
        get
        {
            return this.contents.Count;
        }
    }

    public ContentProvider(IList<ICellData> contents)
    {
        this.contents = contents;
    }
}
