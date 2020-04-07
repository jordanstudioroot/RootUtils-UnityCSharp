using UnityEngine;

namespace RootUtils.ScreenSpace {
/// <summary>
/// A utility class for retrieving facts about a particular 2d screen point.
/// </summary>
    public static class ScreenPoint {

/// <summary>
/// Returns true if the specified point is on screen.
/// </summary>
/// <param name="screenPoint">A specified 2d point.</param>
/// <returns>True if the point is on screen, otherwise false.</returns>
        public static bool IsOnScreen(Vector2 screenPoint) {
            bool nOverflow =
                NorthOverflow(screenPoint) > 0 ? true : false;
            bool eOverflow =
                EastOverflow(screenPoint) > 0 ? true : false;
            bool sOverflow =
                SouthOverflow(screenPoint) > 0 ? true : false;
            bool wOverflow =
                WestOverflow(screenPoint) > 0 ? true : false;

            if (nOverflow || eOverflow || sOverflow || wOverflow) {
                return false;
            }

            return true;
        }

/// <summary>
/// Returns the delta of a given screen point and the north border of the screen.
/// </summary>
/// <param name="screenPoint">A specified 2d point.</param>
/// <returns>
///     A negative delta if the screen point is below the north screen border,
///     otherwise a 0 or positive delta.
/// </returns>
        public static float NorthOverflow(Vector2 screenPoint) {
            return screenPoint.y - Screen.height;
        }

/// <summary>
/// Returns the delta of a given screen point and the east border of the screen.
/// </summary>
/// <param name="screenPoint">A specified 2d point.</param>
/// <returns>
///     A negative delta if the screen point is left the east screen border,
///     otherwise a 0 or positive delta.
/// </returns>
        public static float EastOverflow(Vector2 screenPoint) {
            return screenPoint.x - Screen.width;
        } 

/// <summary>
/// Returns the delta of a given screen point and the south border of the screen.
/// </summary>
/// <param name="screenPoint">A specified 2d point.</param>
/// <returns>
///     A negative delta if the screen point is above the south screen border,
///     otherwise a 0 or positive delta.
/// </returns>
        public static float SouthOverflow(Vector2 screenPoint) {
            return - screenPoint.y;
        }

/// <summary>
/// Returns the delta of a given screen point and the west border of the screen.
/// </summary>
/// <param name="screenPoint">A specified 2d point.</param>
/// <returns>
///     A negative delta if the screen point is right of the west screen border,
///     otherwise a 0 or positive delta.
/// </returns>
        public static float WestOverflow(Vector2 screenPoint) {
            return - screenPoint.x;
        }

/// <summary>
///     Returns the world position of a 2d point in screen space relative to the
///     specified camera.
/// </summary>
/// <param name="camera">A specified camera to be used as a reference point.</param>
/// <param name="screenPoint">A specified 2d point in screen space.</param>
/// <returns>
///     A point in world space corresponding to the specified screen point and
///     camera position.
/// </returns>
        public static Vector3 GetWorldPosition(
            Camera camera,
            Vector2 screenPoint
        ) {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(screenPoint);
            
            if (Physics.Raycast(ray, out hit)) {
                return hit.point;
            }

            return Vector3.negativeInfinity;
        }

/// <summary>
///     Returns the first object under a given screen point using a
///     specified camera as reference.
/// </summary>
/// <param name="camera">The camera to be used as reference.</param>
/// <param name="screenPoint">A specified 2d point in screen space.</param>
/// <returns>The first object under the specified 2d screen point.</returns>
        public static GameObject GetObjectUnder(
            Camera camera,
            Vector2 screenPoint
        ) {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(screenPoint);
            
            if (Physics.Raycast(ray, out hit)) {
                return hit.transform.gameObject;
            }

            return null;
        }

/// <summary>
///     Returns all objects under a given screen point using a
///     specified camera as reference.
/// </summary>
/// <param name="camera">The camera to be used as reference.</param>
/// <param name="screenPoint">A specified 2d point in screen space.</param>
/// <returns>All objects under the specified 2d screen point.</returns>
        public static GameObject[] GetObjectsUnder(
            Camera camera,
            Vector2 screenPoint
        ) {
            Ray ray = camera.ScreenPointToRay(screenPoint);
            RaycastHit[] hits = Physics.RaycastAll(ray);
            GameObject[] result = new GameObject[hits.Length];

            for (int i = 0; i < hits.Length; i++) {
                result[i] = hits[i].transform.gameObject;
            }

            return result;
        }
    }
}