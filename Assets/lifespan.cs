using UnityEngine;
using System.Collections;

public class lifespan : MonoBehaviour {
    public float lifetime = 20;
	
	/*
        It's important that we destroy instantiated objects after a time if there's a risk that there might be too many of them. 
        If we leave them in the scene, we run the risk of memory leaks - the game will use up more and more RAM until it becomes unplayable/unstable.
    */
	void Update () {
        lifetime -= Time.deltaTime;
        if(lifetime < 0)
        {
            Destroy(gameObject);
        }
	}
}
