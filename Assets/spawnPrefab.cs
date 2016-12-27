using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class spawnPrefab : MonoBehaviour {
    public GameObject crate;
    private GameObject clone;
    public float distance = 3;
    public Text activeUIText;

    void OnCollisionEnter(Collision collision)
    {
        clone = Instantiate(crate, transform.position + (Vector3.down * distance), transform.rotation) as GameObject;
        activeUIText.GetComponent<Text>().text = "Prefab Spawned";
    }
}
