using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float interval = 2f;
    public float radius = 5f;
    public int maxObjects = 8;
 
    private List<GameObject> _spawned = new List<GameObject>();
 
    void Start()
    {
        StartCoroutine(SpawnLoop());
    }
 
    IEnumerator SpawnLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);
            Spawn();
        }
    }
 
    public void Spawn()
    {
        
        _spawned.RemoveAll(g => g == null);
 
        if (_spawned.Count >= maxObjects) return;
        if (prefab == null) return;
 
        Vector2 circle = Random.insideUnitCircle * radius;
        Vector3 pos = transform.position + new Vector3(circle.x, 0, circle.y);
 
        GameObject go = Instantiate(prefab, pos, Quaternion.identity);
        _spawned.Add(go);
    }
 
    public void ClearAll()
    {
        foreach (var g in _spawned)
            if (g != null) DestroyImmediate(g);
        _spawned.Clear();
    }
 
    public int Count => _spawned.Count;
 
#if UNITY_EDITOR
    void OnDrawGizmos()
    {
        Gizmos.color = new Color(0f, 1f, 0.4f, 0.15f);
        Gizmos.DrawSphere(transform.position, radius);
 
        Gizmos.color = new Color(0f, 1f, 0.4f, 0.8f);
        Gizmos.DrawWireSphere(transform.position, radius);
    }
#endif
}
}
