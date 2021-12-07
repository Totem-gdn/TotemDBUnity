using UnityEngine;

namespace TotemTransformers
{
    public class TotemItemTransformer {
        public static Color EntityColorToUnityColor(ColorEntity color)
        {
            return new Color(color.red, color.green, color.blue, color.alpha);
        }
    }
}