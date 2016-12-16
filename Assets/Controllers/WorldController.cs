using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class WorldController : MonoBehaviour {

    //allows other controllers to access this class, handy//
    public static WorldController Instance { get; protected set; }


    public WorldData World { get; protected set; }

    Action <int, int, int, int> upf;
    Action <int, float, float, int> upp;


    void Start () {
        upf = PlayerController.Instance.returnUPF();
        upp = PlayerController.Instance.returnUPP();
        Instance = this;
        World = new WorldData(upf, upp);
        World.AddPlayer();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
