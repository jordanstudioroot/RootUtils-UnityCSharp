using UnityEngine;

namespace RootUtils {
    public static class UnityBuiltin {
        public static Font Font (string fontName) {
            Font result = Resources.GetBuiltinResource(
                typeof(Font), fontName + ".ttf"
            ) as Font;

            if (result) {
                return result;
            }
            else {
                throw new System.ArgumentException(
                    "Specified font not found in BuiltIn resources."
                );
            }
        }
    }
}
