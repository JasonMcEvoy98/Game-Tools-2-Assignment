using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Materials : MonoBehaviour {
    public Material matofoject;
    public Color newcol;
    public KeyCode changecolo;
	// Use this for initialization
	void Start () {
        matofoject.color = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(changecolo))
        {
            if (matofoject.color == Color.black){
                matofoject.color = newcol;
            }
            else
            {
                matofoject.color = Color.black;
            }
        }
	}
}
