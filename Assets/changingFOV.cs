using UnityEngine;
using System.Collections;

public class changingFOV : MonoBehaviour {
    public Camera self;
    public float min = 10;
    public float max = 90;
    public float speed = 1;

	// Update is called once per frame
	void Update () {
        self.fieldOfView = Mathf.Lerp(min, max, Mathf.PingPong(Time.time * speed, 1));
	}
}
