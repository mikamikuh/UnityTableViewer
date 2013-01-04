using System;
using UnityEngine;
using UnityEditor;
using System.Collections;


public abstract class CellProvider : ICellProvider
{

    public virtual int Count
    {
        get
        {
            return 0;
        }
    }

    public virtual string GetLabel(int col, System.Object obj)
    {
        return obj.ToString();
    }

    public virtual string[] GetAllLabel()
    {
        return null;
    }

    public Func<System.Object> GetCellAccessor(System.Object obj)
    {
        if (obj.GetType() == typeof(string))
        {
            return () => { return EditorGUILayout.TextField((string)obj, GUILayout.ExpandWidth(true)); };
        }
        else if (obj.GetType() == typeof(int))
        {
            return () => { return EditorGUILayout.IntField((int)obj, GUILayout.ExpandWidth(true)); };
        }
        else if (obj.GetType() == typeof(float))
        {
            return () => { return EditorGUILayout.FloatField((float)obj, GUILayout.ExpandWidth(true)); };
        }
        else if (obj.GetType () == typeof(bool))
        {
            return () => { return EditorGUILayout.Toggle((bool)obj, GUILayout.ExpandWidth (true)); };
        }
        else if (obj.GetType () == typeof(Color))
        {
            return () => { return EditorGUILayout.ColorField((Color)obj, GUILayout.ExpandWidth (true)); };
        }
        else if (obj.GetType () == typeof(Vector2))
        {
            return () => { return EditorGUILayout.Vector2Field("", (Vector2)obj, GUILayout.ExpandWidth (true)); };
        }
        else if (obj.GetType () == typeof(Vector3))
        {
            return () => { return EditorGUILayout.Vector3Field("", (Vector3)obj, GUILayout.ExpandWidth (true)); };
        }
        else if (obj.GetType () == typeof(Vector4))
        {
            return () => { return EditorGUILayout.Vector2Field("", (Vector4)obj, GUILayout.ExpandWidth (true)); };
        }
        else if (obj.GetType () == typeof(AnimationCurve))
        {
            return () => { return EditorGUILayout.CurveField((AnimationCurve)obj, GUILayout.ExpandWidth (true)); };
        }
        else if (obj.GetType () == typeof(Rect))
        {
            return () => { return EditorGUILayout.RectField((Rect)obj, GUILayout.ExpandWidth (true)); };
        }
        else if (obj.GetType () == typeof(Texture))
        {
            return () => { return EditorGUILayout.ObjectField((Texture)obj, typeof(Texture), GUILayout.ExpandWidth (true)); };
        }
        else if (obj.GetType () == typeof(Texture2D))
        {
            return () => { return EditorGUILayout.ObjectField((Texture2D)obj, typeof(Texture), GUILayout.ExpandWidth (true)); };
        }
        else if (obj.GetType () == typeof(UnityEngine.Object))
        {
            return () => { return EditorGUILayout.ObjectField((UnityEngine.Object)obj, typeof(GameObject), GUILayout.ExpandWidth (true)); };
        }

        return null;
    }
}