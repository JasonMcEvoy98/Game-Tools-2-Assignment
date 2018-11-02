using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0,0,10);
    }

    //coin behaviour
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<PlayerScore>().points++;
        if (other.CompareTag ("Player")){
            Destroy(gameObject);
        }
    }
}
