// **************************************************************** //
// Made for GammaSnaplight: https://github.com/GammaSnaplight
// **************************************************************** //
//
//   Copyright (c) RimuruDev. All rights reserved.
//   Contact me: 
//          - Gmail:    rimuru.dev@gmail.com
//          - GitHub:   https://github.com/RimuruDev
//          - LinkedIn: https://www.linkedin.com/in/rimuru/
//          - GitHub Organizations: https://github.com/Rimuru-Dev
//
// **************************************************************** //

using UnityEditor;
using RimuruDev.Internal.Codebase.Runtime;
using UnityEngine;

namespace External.RimuruDevUtils.Editor.SceneDrawer
{
    [CustomEditor(typeof(SceneReference))]
    [HelpURL("https://github.com/RimuruDev/Unity-SerializationSceneInEditor")]
    public sealed class SceneReferenceEditor : UnityEditor.Editor
    {
        private const string Label = "Scene";

        public override void OnInspectorGUI()
        {
            var sceneRef = (SceneReference)target;

            EditorGUI.BeginChangeCheck();

            var sceneAsset = AssetDatabase.LoadAssetAtPath<SceneAsset>(sceneRef.SceneName);

            sceneAsset = EditorGUILayout.ObjectField(Label, sceneAsset, typeof(SceneAsset), false) as SceneAsset;

            if (EditorGUI.EndChangeCheck() && sceneAsset != null)
                sceneRef.SceneName = AssetDatabase.GetAssetPath(sceneAsset);
        }
    }
}