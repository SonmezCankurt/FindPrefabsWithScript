using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class FindPrefabWithScriptWindow : EditorWindow
{
    private MonoScript script;
    private bool searchInChildren = true;
    private List<GameObject> prefabsWithScript = new List<GameObject>();
    private Vector2 scrollPosition;

    [MenuItem("Custom Tools/Find Prefabs with Script")]
    public static void ShowWindow()
    {
        GetWindow<FindPrefabWithScriptWindow>("Find Prefabs with Script");
    }

    private void OnGUI()
    {
        GUILayout.Label("Find Prefabs with Script", EditorStyles.boldLabel);

        script = EditorGUILayout.ObjectField("Script", script, typeof(MonoScript), false) as MonoScript;

        searchInChildren = EditorGUILayout.Toggle("Search In Children", searchInChildren);

        if (GUILayout.Button("Find"))
        {
            FindPrefabsWithScript();
        }

        scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);
        foreach (GameObject prefab in prefabsWithScript)
        {
            EditorGUILayout.ObjectField(prefab, typeof(GameObject), true);
        }
        EditorGUILayout.EndScrollView();
    }

    private void FindPrefabsWithScript()
    {
        prefabsWithScript.Clear();

        if (script == null)
            return;

        System.Type scriptType = script.GetClass();
        if (scriptType == null)
            return;

        string[] prefabPaths = AssetDatabase.FindAssets("t:Prefab");
        foreach (string path in prefabPaths)
        {
            string assetPath = AssetDatabase.GUIDToAssetPath(path);
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(assetPath);

            if (PrefabUtility.IsPartOfPrefabAsset(prefab))
            {
                if (searchInChildren)
                {
                    Component[] components = prefab.GetComponentsInChildren(scriptType, true);
                    if (components.Length > 0)
                    {
                        prefabsWithScript.Add(prefab);
                    }
                }
                else
                {
                    Component component = prefab.GetComponent(scriptType);
                    if (component != null)
                    {
                        prefabsWithScript.Add(prefab);
                    }
                }
            }
        }
    }
}
