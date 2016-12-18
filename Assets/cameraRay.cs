using UnityEngine;
using System.Collections;

public class cameraRay : MonoBehaviour {
    public Camera camera;

    void Update()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            try
            {
                hit.transform.parent.gameObject.active = true;
            }
            catch
            {
                print("No parent");
            }
            // Do something with the object that was hit by the raycast.
        }
    }
}
