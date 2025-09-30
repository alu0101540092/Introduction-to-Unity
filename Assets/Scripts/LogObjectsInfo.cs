using UnityEngine;

public class LogObjectsInfo : MonoBehaviour
{
  void Start()
  {
    GameObject[] all = FindObjectsByType<GameObject>(FindObjectsSortMode.None);

    foreach (GameObject go in all)
    {
      if (!go.activeInHierarchy) continue; // Skip inactive objects

      string tag = go.tag; // Get the tag of the GameObject
      Vector3 position = go.transform.position; // Get the position of the GameObject

      if (tag == "Untagged") continue; // Skip untagged objects

      Debug.Log($"[LogObjectsInfo] Name: '{go.name}' Tag: '{tag}' Position: {position}");
    }
  }
}