using UnityEngine;
using System.Collections;

public class startOff : MonoBehaviour {

    public GameObject self;
    public bool activeOnStart;
   
	// Use this for initialization
	void Start () {
        self.active = activeOnStart;
	}
	
}
