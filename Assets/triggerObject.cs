using UnityEngine;
using System.Collections;

public class triggerObject : MonoBehaviour {
    public GameObject target;
    public Renderer rend;

    void Start()
    {
        target.active = false;
        rend = GetComponent<Renderer>();
        rend.material.EnableKeyword("_EmissionColor");
    }

    void OnCollisionEnter(Collision collision)
    {
        target.active = true;
        rend.material.SetColor("_EmissionColor", Color.green);
    }

    void OnCollisionExit(Collision collision)
    {
        target.active = false;
        rend.material.SetColor("_EmissionColor", Color.black);
    }
}
