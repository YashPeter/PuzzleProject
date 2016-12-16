using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    //Importing Sprites into the main class
    public Sprite p1l1;
    public Sprite p1l2;
    public Sprite p1l3;
    public Sprite p1l4;
    public Sprite p1l5;

    public Sprite p1r1;
    public Sprite p1r2;
    public Sprite p1r3;
    public Sprite p1r4;
    public Sprite p1r5;

    public Sprite p1u1;
    public Sprite p1u2;
    public Sprite p1u3;
    public Sprite p1u4;
    public Sprite p1u5;

    public Sprite p1d1;
    public Sprite p1d2;
    public Sprite p1d3;
    public Sprite p1d4;
    public Sprite p1d5;
    // Use this for initialization

    public static PlayerController Instance { get; protected set; }

    public Action<int, int, int, int> upf;
    public Action<int, float, float, int> upp;


    void Start()
    {
        Instance = this;
        upf = changeGivenPlayerFrame;
        upp = translateGivenPlayerFrame;
        //return WorldController.Instance.World.*insertmethod*
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Action<int, int, int, int> returnUPF()
    {
        return upf;
    }

    public Action<int, float, float, int> returnUPP()
    {
        return upp;
    }

    public void changeGivenPlayerFrame(int arraypos, int frame, int direction, int currplay)
    {

    }

    public void translateGivenPlayerFrame(int arraypos, float x, float y, int currplay)
    {

    }
}
