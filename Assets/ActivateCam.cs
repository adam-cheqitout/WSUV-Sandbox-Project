using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActivateCam : MonoBehaviour
{

    public Camera target;
    public Text mainUIText;

    void Start()
    {
        target.enabled = false;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (target.enabled)
        {
            target.enabled = false;
            mainUIText.GetComponent<Text>().text = target.GetComponent<ObjectText>().showMessage();
        }
        else
        {
            target.enabled = true;
            mainUIText.GetComponent<Text>().text = target.GetComponent<ObjectText>().showMessage();
        }
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            target.enabled = false;
        }
    }
}