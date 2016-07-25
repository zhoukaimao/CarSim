using UnityEngine;
using UnityEditor;

/// <summary>
/// Provides a wrapper functionality for LODCreatorInternal
/// </summary>
public class LODCreator : UniLOD.LODCreatorInternal
{
    /// <summary>
    /// Initalize the window
    /// </summary>
    [MenuItem("Window/UniLOD/Prefab creator")]
    protected static void Init()
    {
        LODCreator Window = (LODCreator)EditorWindow.GetWindow(typeof(LODCreator), false, "LOD Prefab Creator");
        Window.Show();
    }

    new void OnGUI()
    {
        base.OnGUI();
    }

    new void Update()
    {
        base.Update();
    }
}