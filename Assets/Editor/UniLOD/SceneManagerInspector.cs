using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.IO;

using UniLOD;

[CustomEditor(typeof(SceneManager))]
class SceneManagerInspector : Editor
{
    SceneManager Target;
    string[] CurrentScenes = new string[0];
    int SelectedScene = -1;

    public override void OnInspectorGUI()
    {
        EditorGUILayout.BeginVertical();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.BeginVertical();
        for (int i = LODQualityLevels.Count - 1; i >= 0; i--)
        {
            EditorGUILayout.BeginHorizontal();
            GUILayout.Label("Distance(" + LODQualityLevels.GetLevelName(LODQualityLevels.Count - 1 - i) + ")");
            Target.DefaultDistancesArray[i] = EditorGUILayout.FloatField(Target.DefaultDistancesArray[i], GUILayout.Width(50));
            EditorGUILayout.EndHorizontal();
        }

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Distance(Fade)");
        Target.DefaultFadeDistance = EditorGUILayout.FloatField(Target.DefaultFadeDistance, GUILayout.Width(50));
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Streaming zone buffer (Distance units)");
        Target.LoadZoneSize = EditorGUILayout.FloatField(Target.LoadZoneSize, GUILayout.Width(50));
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Update camera every (Distance units)");
        Target.DistanceDeltaBeforeUpdate = EditorGUILayout.FloatField(Target.DistanceDeltaBeforeUpdate, GUILayout.Width(50));
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.EndVertical();
        GUILayout.FlexibleSpace();
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space();

        EditorGUILayout.BeginHorizontal();
        Target.LoadAtStart = GUILayout.Toggle(Target.LoadAtStart, "Load at start");
        GUILayout.FlexibleSpace();
        if (Target.LoadAtStart)
        {
            if (CurrentScenes.Length != 0)
            {
                int NewSelectedScene = EditorGUILayout.Popup(SelectedScene == -1 ? 0 : SelectedScene, CurrentScenes);
                if (NewSelectedScene != SelectedScene)
                {
                    SelectedScene = NewSelectedScene;
                    Target.DefaultScene = LODOptionsInternal.SceneFolder.TrimStart(
                        "Assets/Resources".ToCharArray()) + "/" + CurrentScenes[SelectedScene];
                }
            }
            else
                EditorGUILayout.Popup(0, new string[] { "No scenes" });
        }
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space();

        EditorGUILayout.BeginHorizontal();
        Target.PreloadData = GUILayout.Toggle(Target.PreloadData, "Preload data", GUI.skin.button);
        Target.PreloadData = !GUILayout.Toggle(!Target.PreloadData, "Stream data", GUI.skin.button);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.EndVertical();
    }

    void OnEnable()
    {
        Target = (SceneManager)target;

        DirectoryInfo DI = new DirectoryInfo(LODOptionsInternal.SceneFolder);

        FileInfo[] Files = DI.GetFiles();

        List<string> Scenes = new List<string>();
        for (int i = 0; i < Files.Length; i++)
        {
            if (Files[i].Extension == ".txt")
                Scenes.Add(Path.GetFileNameWithoutExtension(Files[i].Name));
        }

        CurrentScenes = Scenes.ToArray();

        SelectedScene = -1;
        string CurrentDefaultScene = Path.GetFileNameWithoutExtension(Target.DefaultScene);
        for (int i = 0; i < CurrentScenes.Length; i++)
        {
            if (CurrentScenes[i] == CurrentDefaultScene)
                SelectedScene = i;
        }
    }
}