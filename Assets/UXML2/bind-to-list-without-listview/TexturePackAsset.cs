using System.Collections.Generic;
using UnityEngine;

namespace UIToolkitExamples_05
{
    [CreateAssetMenu(menuName = "UIToolkitExamples/TexturePackAsset")]
    public class TexturePackAsset : ScriptableObject
    {
        public List<Texture2D> textures;

        public void Reset()
        {
            textures = new() { null, null, null, null };
        }
    }
}