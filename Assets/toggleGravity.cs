using UnityEngine;
using System.Collections;

public class toggleGravity : MonoBehaviour {

    public Rigidbody[] objects;
    private bool gravityActive = true;
    void OnCollisionEnter()
    {
        if (gravityActive)
        {
            for (var i = 0; i < objects.Length; ++i)
            {
                objects[i].useGravity = false;
                objects[i].AddForce(Vector3.up * 5000);
                gravityActive = false;
            }
        }
        else
        {
            for (var i = 0; i < objects.Length; ++i)
            {
                objects[i].useGravity = true;
                gravityActive = true;
            }
        }
    }
}
