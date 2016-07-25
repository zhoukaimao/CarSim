using UnityEngine;

/// <summary>
/// Provides a wrapper functionality for AssetBundleManagerInternal
/// </summary>
public class AssetBundleManager : UniLOD.AssetBundleManagerInternal
{
    new void Update()
    {
        base.Update();
    }

    new void OnDisable()
    {
        base.OnDisable();
    }
}