using UnityEngine;
using UnityEditor;

/// <summary>
/// Provides a wrapper functionality for LODEditorInternal
/// </summary>
public class LODEditor : UniLOD.LODEditorInternal
{
    /// <summary>
    /// Initalize the window and find the highest quality LOD
    /// </summary>
    [MenuItem("Window/UniLOD/Scene editor")]
    static void Init()
    {
        LODEditor Window = (LODEditor)EditorWindow.GetWindow(typeof(LODEditor), false, "LOD Scene Editor");
        Window.Show();
    }

    new void OnEnable()
    {
        base.OnEnable();
    }

    new void OnGUI()
    {
        base.OnGUI();
    }

    new void Update()
    {
        base.Update();
    }
    
    new void OnSelectionChange()
    {
        base.OnSelectionChange();
    }

    new void OnHierarchyChange()
    {
        base.OnHierarchyChange();
    }
}