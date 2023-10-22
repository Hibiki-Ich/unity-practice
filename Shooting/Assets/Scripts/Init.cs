#if UNITY_EDITOR

using UnityEditor;

public class RefreshPlay
{
    [InitializeOnLoadMethod]
    public static void Run()
    {
        EditorApplication.playModeStateChanged += (PlayModeStateChange state) =>
        {
            if (state == PlayModeStateChange.ExitingEditMode)
            {
                AssetDatabase.Refresh();
            }
        };
    }
}

#endif

