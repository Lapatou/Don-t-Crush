using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private Vector3 startPos;
    private void Awake()
    {
        startPos = GameObject.FindGameObjectsWithTag("Player")[0].transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject go = collision.gameObject;
        if (go.CompareTag("Player"))
        {
            go.transform.position = startPos + new Vector3(Random.Range(-9f, 9f), 0f, 0f);
        }
    }
}
