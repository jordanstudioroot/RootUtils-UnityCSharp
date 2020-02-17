using System.Collections.Generic;
using UnityEngine;

namespace RootUtils {
    public static class Distance {
        public static GameObject Closest(
            GameObject source,
            List<GameObject> targets
        ) {
            GameObject result = null;
            float closestDist = Mathf.Infinity;

            foreach (GameObject obj in targets) {
                float objDistance = Vector3.Distance(
                    source.transform.position,
                    obj.transform.position
                );

                if (objDistance < closestDist) {
                    result = obj;
                }
            }

            return result;
        }

        public static List<GameObject> SortObjectsByDistance(
            GameObject source,
            List<GameObject> targets
        ) {
            targets.Sort(
                (a, b) => 
                    Vector3.Distance(
                        source.transform.position,
                        a.transform.position
                    ).CompareTo(
                        Vector3.Distance(
                            source.transform.position,
                            b.transform.position
                        )
                    )
            );

            return targets;
        }

        public static List<Vector3> SortPointsByDistance(
            GameObject source,
            List<Vector3> targets
        ) {
            targets.Sort(
                (a, b) => 
                    Vector3.Distance(
                        source.transform.position,
                        a
                    ).CompareTo(
                        Vector3.Distance(
                            source.transform.position,
                            b
                        )
                    )
            );

            return targets;
        }
    }
}