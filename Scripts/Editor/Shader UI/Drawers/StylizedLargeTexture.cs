#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace HoyoToon
{
    public class StylizedLargeTextureDrawer : MaterialPropertyDrawer
    {
        public override void OnGUI(Rect position, MaterialProperty prop, GUIContent label, MaterialEditor editor)
        {
            GUILib.StylizedBigTextureProperty(position, prop, label, editor, ((ShaderTextureProperty)ShaderEditor.Active.CurrentProperty).hasScaleOffset);
        }

        public override float GetPropertyHeight(MaterialProperty prop, string label, MaterialEditor editor)
        {
            DrawingData.LastPropertyUsedCustomDrawer = true;
            return base.GetPropertyHeight(prop, label, editor);
        }
    }
}
#endif