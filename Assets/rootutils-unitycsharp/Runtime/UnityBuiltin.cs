using UnityEngine;

namespace RootUtils.Assets {

/// <summary>
/// Utility class for retreiving Unity's built in resources.
/// </summary>
    public static class UnityBuiltin {

/// <summary>
/// Returns the specified built in font if such a font exists.
/// </summary>
/// <param name="fontName">The name of the desired built in font.</param>
/// <returns>
///     The specified font.
/// </returns>
/// <exception cref="System.ArgumentException">
///     If the specified font does not exist.
/// </exception>
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
