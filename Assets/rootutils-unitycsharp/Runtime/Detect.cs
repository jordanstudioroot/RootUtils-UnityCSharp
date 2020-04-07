using UnityEngine;
using System.Collections.Generic;

namespace RootUtils.AI {
    public static class Detect {
        public static List<GameObject> DetectToList(
            GameObject origin,
            float radius
        ) {
            List<GameObject> result = new List<GameObject>();
            
            Collider[] detected = Physics.OverlapSphere(
                origin.transform.position,
                radius
            );

            foreach (Collider col in detected) {
                if (col.gameObject != origin) {
                    result.Add(col.gameObject);
                }
            }

            return result;
        }

        public static GameObject[] DetectToArray(
            GameObject origin,
            float radius
        ) {
            return DetectToList(origin, radius).ToArray();
        }

        public static T DetectClosestWithComponent<T>(
            GameObject origin,
            float radius
        ) where T : Component {
            List<GameObject> detectedObjs = DetectToList(origin, radius);
            Distance.SortObjectsByDistance(origin, detectedObjs);

            foreach (GameObject obj in detectedObjs) {
                foreach (Component comp in obj.GetComponents<Component>()) {
                    if (comp is T) {
                        return (T)comp;
                    }
                }
            }

            return null;
        }

        public static List<T> DetectAllWithComponent<T>(
            GameObject origin,
            float radius
        ) where T : Component {
            List<GameObject> detectedObjs = DetectToList(origin, radius);
            Distance.SortObjectsByDistance(origin, detectedObjs);
            List<T> result = new List<T>();

            foreach (GameObject obj in detectedObjs) {
                foreach (Component comp in obj.GetComponents<Component>()) {
                    if (comp is T) {
                        result.Add((T)comp);
                    }
                }
            }

            return result;
        }
    }
}   