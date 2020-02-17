using UnityEngine;
using UnityEngine.EventSystems;

namespace RootUtils {
    public static class EventSystemUtils {
        public static void TryInitEventSystem() {
            if (!GameObject.FindObjectOfType<EventSystem>()) {
                GameObject eventSystem = new GameObject("EventSystem");
                eventSystem.AddComponent<EventSystem>();
                eventSystem.AddComponent<StandaloneInputModule>();
            }
        }
    }
}
