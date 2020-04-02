using UnityEngine;

public static class Destroy {
    private void DestroyAll<T>() where T : UnityEngine.MonoBehaviour {
        foreach(T t in GameObject.FindObjectsOfType<T>()) {
            GameObject.Destroy(t.transform.gameObject);
        }
    }
}