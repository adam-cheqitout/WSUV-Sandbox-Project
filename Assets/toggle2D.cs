using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class toggle2D : MonoBehaviour {

    public Camera target;
    public GameObject ball;
    public Text mainUIText;
    public CharacterController controller;
    void Start()
    {
        target.enabled = false;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (target.enabled)
        {
            target.enabled = false;
            ball.GetComponent<ballMovement>().deactivate();
            mainUIText.GetComponent<Text>().text = target.GetComponent<ObjectText>().showMessage();
            controller.enabled = true;
        }
        else
        {
            target.enabled = true;
            ball.GetComponent<ballMovement>().activate();
            mainUIText.GetComponent<Text>().text = target.GetComponent<ObjectText>().showMessage();
            controller.enabled = false;
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            target.enabled = false;
            ball.GetComponent<ballMovement>().deactivate();
            controller.enabled = true;
        }
    }
}
