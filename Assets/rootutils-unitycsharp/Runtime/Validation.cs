using UnityEngine;

namespace RootUtils {
    public static class Validation {
        private bool HasSingleInstance<T>() where T : UnityEngine.Object {
            T[] existing = Resources.FindObjectsOfTypeAll<T>();
            if (existing.Length == 1) {
                return true;
            }
            else {
                return false;
            }
        }

        private T GetSingleInstance<T>() where T : UnityEngine.Object {
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