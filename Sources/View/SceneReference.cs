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

using UnityEngine;

namespace RimuruDev.Internal.Codebase.Runtime
{
    [SelectionBase]
    [DisallowMultipleComponent]
    [HelpURL("https://github.com/RimuruDev/Unity-SerializationSceneInEditor")]
    public sealed class SceneReference : MonoBehaviour
    {
        [field: SerializeField] public string SceneName { get; set; }
    }
}