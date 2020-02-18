using UnityEngine;

namespace RootUtils {
    public static class ScreenPoint {
        public static bool IsOnScreen(Vector2 screenPoint) {
            bool nOverflow =
                NorthOverflow() > 0 ? true : false;
            bool eOverflow =
                EastOverflow() > 0 ? true : false;
            bool sOverflow =
                SouthOverflow() > 0 ? true : false;
            bool wOverflow =
                WestOverflow() > 0 ? true : false;

            if (nOverflow || eOverflow || sOverflow || wOverflow) {
                return false;
            }

            return true;
        }

        public static float NorthOverflow(Vector3 screenPoint) {
            return screenPoint.y - Screen.height;
        }

        public static float EastOverflow(Vector3 screenPoint) {
            return screenPoint.x - Screen.width;
        } 

        public static float SouthOverflow(Vector3 screenPoint) {
            return - screenPoint.y;
        }

        public static float WestOverflow(Vector3 screenPoint) {
            return - screenPoint.x;
        }

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