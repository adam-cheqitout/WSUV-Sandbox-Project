using UnityEngine;
using System.Collections;

public class spawnPrefab : MonoBehaviour {
    public GameObject crate;
    private GameObject clone;
    public float distance = 3;
    void OnCollisionEnter(Collision collision)
    {
        clone = Instantiate(crate, transform.position + (Vector3.down * distance), transform.rotation) as GameObject;
    }
}
