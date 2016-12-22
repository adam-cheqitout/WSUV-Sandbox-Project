using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class toggleColliders : MonoBehaviour {

    public GameObject[] objects;
    public Text mainUIText;

    void OnCollisionEnter(Collision collision)
    {
        for(var i = 0; i < objects.Length; ++i)
        {
            if (objects[i].GetComponent<Collider>().enabled)
            {
                objects[i].GetComponent<Collider>().enabled = false;
                mainUIText.GetComponent<Text>().text = "COLLIDERS DISABLED";
            }
            else
            {
                objects[i].GetComponent<Collider>().enabled = true;
                mainUIText.GetComponent<Text>().text = "COLLIDERS ENABLED";
            }
        }
    }
}
