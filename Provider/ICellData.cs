using System;
using UnityEngine;
using System.Collections;

public interface ICellData
{
    string Name
    {
        get;
        set;
    }

    System.Object GetData(string name);

    void SetData(System.Object obj, string name);

    void Delete();
}
