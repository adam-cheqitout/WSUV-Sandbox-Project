using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActivateObject : MonoBehaviour {

    public GameObject target;
    public Text mainUIText;

    void OnCollisionEnter(Collision collision)
    {
        if (target.active)
        {
            mainUIText.GetComponent<Text>().text = target.GetComponent<ObjectText>().showMessage();
            target.active = false;
        }
        else
        {
            target.active = true;
            mainUIText.GetComponent<Text>().text = target.GetComponent<ObjectText>().showMessage();
        }
    }
}
