using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBtn : MonoBehaviour {


    public GameObject obj1;
    public GameObject obj2;
    // Use this for initialization
    void Start () {
        obj1.SetActive(false);
        obj2.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClickMe() {

        obj1.SetActive(true);
        obj2.SetActive(true);

    }
}
