using UnityEngine;
using UnityEditor;
using System.Collections;

using UniLOD;

[CustomEditor(typeof(LODModel))]
class LODModelInspector : Editor
{
    LODModelInternal Target;

    public override void OnInspectorGUI()
    {
        EditorGUILayout.BeginVertical();

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("LOD Type", GUILayout.Width(150));
        GUILayout.FlexibleSpace();
        GUILayout.Label(Target.Type.ToString());
        GUILayout.FlexibleSpace();
        EditorGUILayout.EndHorizontal();

        for (int i = 0; i < LODQualityLevels.Count; i++)
        {
            EditorGUILayout.BeginHorizontal();
            GUILayout.Label("ID (" + LODQualityLevels.GetLevelName(i) + ")", GUILayout.Width(150));
            GUILayout.FlexibleSpace();
            GUILayout.Label(Target.IDs[i].ToString());
            GUILayout.FlexibleSpace();
            EditorGUILayout.EndHorizontal();
        }

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Override default distances", GUILayout.Width(150));
        GUILayout.FlexibleSpace();
        Target.OverrideDefaultDistances = GUILayout.Toggle(Target.OverrideDefaultDistances, "");
        GUILayout.FlexibleSpace();
        EditorGUILayout.EndHorizontal();

        if (Target.OverrideDefaultDistances)
        {
            if (Target.Type == LODModelInternal.LODType.ChangeLOD)
            {
                for (int i = LODQualityLevels.Count - 1; i >= 0; i--)
                {
                    EditorGUILayout.BeginHorizontal();
                    GUILayout.Label("Distance(" + LODQualityLevels.GetLevelName(LODQualityLevels.Count - i - 1) + ")", GUILayout.Width(150));
                    Target.LODDistances[i] = EditorGUILayout.FloatField("", Target.LODDistances[i]);
                    EditorGUILayout.EndHorizontal();
                }
            }
            else
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.Label("Distance(Fade)", GUILayout.Width(150));
                Target.FadeDistance = EditorGUILayout.FloatField("", Target.FadeDistance);
                EditorGUILayout.EndHorizontal();
            }
        }
        EditorGUILayout.EndVertical();
    }

    void OnEnable()
    {
        Target = (LODModel)target;
    }
}