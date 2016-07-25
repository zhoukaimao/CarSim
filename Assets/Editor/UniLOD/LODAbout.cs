using UnityEngine;
using UnityEditor;
using System.Collections;

/// <summary>
/// Opens a window with some general information
/// </summary>
public class LODAbout : UniLOD.LODAboutInternal
{

    /// <summary>
    /// Initalize the window
    /// </summary>
    [MenuItem("Window/UniLOD/About")]
    protected static void Init()
    {
        LODAbout Window = (LODAbout)EditorWindow.GetWindow(typeof(LODAbout), false, "About UniLOD");
        Window.Show();

        Window.position = new Rect(200, 200, 450, 200);
    }

    new void OnGUI()
    {
        base.OnGUI();
    }
}