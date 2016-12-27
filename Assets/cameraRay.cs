using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cameraRay : MonoBehaviour {
    public Camera camera;
    public Text mainUIText;
    public Transform currentTarget;

    void Update()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            currentTarget = hit.transform;
            try
            {
                mainUIText.GetComponent<Text>().text = currentTarget.GetComponent<ObjectText>().showMessage();
            }
            catch
            {
                //print("no object text");
            }
        }
    }
}
