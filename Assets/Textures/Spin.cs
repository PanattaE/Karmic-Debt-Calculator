using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spin : MonoBehaviour {
    public Transform Background;
    void spin()
    {
        Background.transform.Rotate(0, 0, .75f);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        spin();
	}
}
