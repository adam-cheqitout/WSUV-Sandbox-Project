using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class toggleGravity : MonoBehaviour {

    public Rigidbody[] objects;
    private bool gravityActive = true;
    public Text mainUIText;

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
            mainUIText.GetComponent<Text>().text = "Gravity Off";
        }
        else
        {
            for (var i = 0; i < objects.Length; ++i)
            {
                objects[i].useGravity = true;
                gravityActive = true;
            }
            mainUIText.GetComponent<Text>().text = "Gravity On";
        }
    }
}
