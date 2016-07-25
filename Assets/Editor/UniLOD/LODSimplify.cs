using UnityEngine;
using UnityEditor;

/// <summary>
/// Provides a wrapper functionality for LODSimplifyInternal
/// </summary>
public class LODSimplify : UniLOD.LODSimplifyInternal
{
    /// <summary>
    /// Initalize the window
    /// </summary>
    [MenuItem("Window/UniLOD/Mesh simplifier")]
    protected static void Init()
    {
        if(Application.platform == RuntimePlatform.WindowsEditor)
        {
            LODSimplify Window = (LODSimplify)EditorWindow.GetWindow(typeof(LODSimplify), false, "LOD Simplify");
            Window.Show();
        }
        else
        {
            EditorUtility.DisplayDialog("Error", "This funcionality is only available when running on Windows.", "OK");
        }
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