using UnityEngine;
using UnityEditor;

/// <summary>
/// Provides a wrapper functionality for LODOptionsInternal
/// </summary>
public class LODOptions : UniLOD.LODOptionsInternal
{
    /// <summary>
    /// Initalize the window
    /// </summary>
    [MenuItem("Window/UniLOD/Options")]
    static void Init()
    {
        LODOptions Window = (LODOptions)EditorWindow.GetWindow(typeof(LODOptions), false, "LOD Options");
        Window.Show();
    }

    new void OnGUI()
    {
        base.OnGUI();
    }
}