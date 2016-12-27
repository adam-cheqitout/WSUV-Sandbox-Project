using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class swapMaterial : MonoBehaviour {

    public PhysicMaterial ice;
    public PhysicMaterial rubber;
    public Collider[] objects;
    private bool iceActive;
    public Text mainUIText;

    void OnCollisionEnter()
    {
        if (iceActive)
        {
            for (var i = 0; i < objects.Length; ++i)
            {
                objects[i].material = rubber;
                iceActive = false;
            }
            mainUIText.GetComponent<Text>().text = "Physics Material - Rubber";
        }
        else
        {
            for (var i = 0; i < objects.Length; ++i)
            {
                objects[i].material = ice;
                iceActive = true;
            }
            mainUIText.GetComponent<Text>().text = "Physics Material - Ice";
        }
    }
	
}
