using UnityEngine;

namespace RootUtils.Validation {

/// <summary>
/// Utility class for validating instances of UnityEngine.Object.
/// </summary>
    public static class InstanceValidation {
/// <summary>
///     Returns true if one and only one instance of the 
///     specified type of UnityEngine.Object exists.
/// </summary>
/// <typeparam name="T">
///     The specified type of UnityEngine.Object
/// </typeparam>
/// <returns>
///     True if a single instance of the specified type exists,
///     otherwise returns false.
/// </returns>
        public static bool SingleInstanceExists<T>() where T : UnityEngine.Object {
            T[] existing = Resources.FindObjectsOfTypeAll<T>();
            if (existing.Length == 1) {
                return true;
            }
            else {
                return false;
            }
        }

/// <summary>
///     Returns true if at least one instance of the specified
///     type of UnityEngine.Object exists.
/// </summary>
/// <typeparam name="T">
///     The specified type of UnityEngine.Object.
/// </typeparam>
/// <returns>
///     True if at least one instance of the specified type exists.
/// </returns>
        public static bool InstanceExists<T>() where T : UnityEngine.Object {
            T[] existing = Resources.FindObjectsOfTypeAll<T>();
            if (existing.Length > 0) {
                return true;
            }
            return false;
        }

/// <summary>
///     Returns the first detected instance of the specified type
///     of UnityEngine.Object.
/// </summary>
/// <typeparam name="T">
///     The desired type of UnityEngine.Object to be retrieved.
/// </typeparam>
/// <returns> A single instance of the specified type.</returns>
        public static T GetFirstInstance<T>() where T : UnityEngine.Object {
            T[] existing = Resources.FindObjectsOfTypeAll<T>();
            if (existing.Length == 1) {
                return existing[0];
            }
            else {
                return null;
            }
        }
    }
}