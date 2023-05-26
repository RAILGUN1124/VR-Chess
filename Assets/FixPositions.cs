using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  
public class FixPositions : MonoBehaviour
{
    public GameObject WR1;
    public GameObject WN1;
    public GameObject WB1;
    public GameObject WQ;
    public GameObject WB2;
    public GameObject WN2;
    public GameObject WR2;
    public GameObject WP1;
    public GameObject WP2;
    public GameObject WP3;
    public GameObject WP4;
    public GameObject WP5;
    public GameObject WP6;
    public GameObject WP7;
    public GameObject WP8;
    public GameObject BR1;
    public GameObject BN1;
    public GameObject BB1;
    public GameObject BQ;
    public GameObject BK;
    public GameObject BB2;
    public GameObject BN2;
    public GameObject BR2;
    public GameObject BP1;
    public GameObject BP2;
    public GameObject BP3;
    public GameObject BP4;
    public GameObject BP5;
    public GameObject BP6;
    public GameObject BP7;
    public GameObject BP8;
    public Vector3 WK1P;
    public Vector3 WR1P;
    public Vector3 WN1P;
    public Vector3 WB1P;
    public Vector3 WQP;
    public Vector3 WB2P;
    public Vector3 WN2P;
    public Vector3 WR2P;
    public Vector3 WP1P;
    public Vector3 WP2P;
    public Vector3 WP3P;
    public Vector3 WP4P;
    public Vector3 WP5P;
    public Vector3 WP6P;
    public Vector3 WP7P;
    public Vector3 WP8P;
    public Vector3 BR1P;
    public Vector3 BN1P;
    public Vector3 BB1P;
    public Vector3 BQP;
    public Vector3 BKP;
    public Vector3 BB2P;
    public Vector3 BN2P;
    public Vector3 BR2P;
    public Vector3 BP1P;
    public Vector3 BP2P;
    public Vector3 BP3P;
    public Vector3 BP4P;
    public Vector3 BP5P;
    public Vector3 BP6P;
    public Vector3 BP7P;
    public Vector3 BP8P;
      
    // Start is called before the first frame update
    void Start()
    {
        WK1P = transform.position;
        WR1P = WR1.transform.position;
        WN1P = WN1.transform.position;
        WB1P = WB1.transform.position;
        WQP = WQ.transform.position;
        WB2P = WB2.transform.position;
        WN2P = WN2.transform.position;
        WR2P = WR2.transform.position;
        WP1P = WP1.transform.position;
        WP2P = WP2.transform.position;
        WP3P = WP3.transform.position;
        WP4P = WP4.transform.position;
        WP5P = WP5.transform.position;
        WP6P = WP6.transform.position;
        WP7P = WP7.transform.position;
        WP8P = WP8.transform.position;
        BR1P = BR1.transform.position;
        BN1P = BN1.transform.position;
        BB1P = BB1.transform.position;
        BQP = BQ.transform.position;
        BKP = BK.transform.position;
        BB2P = BB2.transform.position;
        BN2P = BN2.transform.position;
        BR2P = BR2.transform.position;
        BP1P = BP1.transform.position;
        BP2P = BP2.transform.position;
        BP3P = BP3.transform.position;
        BP4P = BP4.transform.position;
        BP5P = BP5.transform.position;
        BP6P = BP6.transform.position;
        BP7P = BP7.transform.position;
        BP8P = BP8.transform.position;
        /*
        pos = new float[10]; //pos = {0f, -5.25f, -3.75f, -2.25f, -0.75f, 0.75f, 2.25f, 3.75f, 5.25f, 0f};
        float[] file = new float[10];
        float[] rank = new float[10];
        for(int i=1; i<=8; i++){
            pos[i] = -6.75f + (float)(1.5*i);
            rank[i] = -6.75f + (float)(1.5*i);
        }
        */
        //Debug.Log(transform.position);
        /*
        //transform.position = new Vector3(file[5], 0.45f, rank[5]);
        //transform.position = new Vector3(pos[(int)((transform.position.x+6.75)/1.5)], 0.45f, pos[(int)((transform.position.z+6.75)/1.5)]);
        Debug.Log("Tracking White King's position");
        Debug.Log(transform.position);
        Debug.Log(transform.position.GetType());
        Vector3 WK1 = transform.position;
        Vector3 Test = new Vector3(0.75f, 0.45f, -5.25f);
        Debug.Log(Test.x);
        Debug.Log(transform.eulerAngles.x);
        Debug.Log(transform.eulerAngles.y);
        Debug.Log(transform.eulerAngles.z);
        */
    }
  
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < 1 && (Math.Abs(transform.eulerAngles.x) > 0.1)){
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(transform.position.x < -5.99 || transform.position.x > 5.99 || transform.position.z < -5.99 || transform.position.z > 5.99){
                transform.position = WK1P;
            }
        }
////////////////////////////////////////////////////////////////////////////////////////////////////
        if(WR1.transform.position.y < 1 && (Math.Abs(WR1.transform.eulerAngles.x) > 0.1)){
            WR1.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(WR1.transform.position.x < -5.99 || WR1.transform.position.x > 5.99 || WR1.transform.position.z < -5.99 || WR1.transform.position.z > 5.99){
                WR1.transform.position = WR1P;
            }
        }
        if(WN1.transform.position.y < 1 && (Math.Abs(WN1.transform.eulerAngles.x) > 0.1)){
            WN1.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(WN1.transform.position.x < -5.99 || WN1.transform.position.x > 5.99 || WN1.transform.position.z < -5.99 || WN1.transform.position.z > 5.99){
                WN1.transform.position = WN1P;
            }
        }
        if(WB1.transform.position.y < 1 && (Math.Abs(WB1.transform.eulerAngles.x) > 0.1)){
            WB1.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(WB1.transform.position.x < -5.99 || WB1.transform.position.x > 5.99 || WB1.transform.position.z < -5.99 || WB1.transform.position.z > 5.99){
                WB1.transform.position = WB1P;
            }
        }
        if(WQ.transform.position.y < 1 && (Math.Abs(WQ.transform.eulerAngles.x) > 0.1)){
            WQ.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(WQ.transform.position.x < -5.99 || WQ.transform.position.x > 5.99 || WQ.transform.position.z < -5.99 || WQ.transform.position.z > 5.99){
                WQ.transform.position = WQP;
            }
        }
        if(WB2.transform.position.y < 1 && (Math.Abs(WB2.transform.eulerAngles.x) > 0.1)){
            WB2.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(WB2.transform.position.x < -5.99 || WB2.transform.position.x > 5.99 || WB2.transform.position.z < -5.99 || WB2.transform.position.z > 5.99){
                WB2.transform.position = WB2P;
            }
        }
        if(WN2.transform.position.y < 1 && (Math.Abs(WN2.transform.eulerAngles.x) > 0.1)){
            WN2.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(WN2.transform.position.x < -5.99 || WN2.transform.position.x > 5.99 || WN2.transform.position.z < -5.99 || WN2.transform.position.z > 5.99){
                WN2.transform.position = WN2P;
            }
        }
        if(WR2.transform.position.y < 1 && (Math.Abs(WR2.transform.eulerAngles.x) > 0.1)){
            WR2.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(WR2.transform.position.x < -5.99 || WR2.transform.position.x > 5.99 || WR2.transform.position.z < -5.99 || WR2.transform.position.z > 5.99){
                WR2.transform.position = WR2P;
            }
        }
        if(WP1.transform.position.y < 1 && (Math.Abs(WP1.transform.eulerAngles.x) > 0.1)){
            WP1.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(WP1.transform.position.x < -5.99 || WP1.transform.position.x > 5.99 || WP1.transform.position.z < -5.99 || WP1.transform.position.z > 5.99){
                WP1.transform.position = WP1P;
            }
        }
        if(WP2.transform.position.y < 1 && (Math.Abs(WP2.transform.eulerAngles.x) > 0.1)){
            WP2.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(WP2.transform.position.x < -5.99 || WP2.transform.position.x > 5.99 || WP2.transform.position.z < -5.99 || WP2.transform.position.z > 5.99){
                WP2.transform.position = WP2P;
            }
        }
        if(WP3.transform.position.y < 1 && (Math.Abs(WP3.transform.eulerAngles.x) > 0.1)){
            WP3.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(WP3.transform.position.x < -5.99 || WP3.transform.position.x > 5.99 || WP3.transform.position.z < -5.99 || WP3.transform.position.z > 5.99){
                WP3.transform.position = WP3P;
            }
        }
        if(WP4.transform.position.y < 1 && (Math.Abs(WP4.transform.eulerAngles.x) > 0.1)){
            WP4.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(WP4.transform.position.x < -5.99 || WP4.transform.position.x > 5.99 || WP4.transform.position.z < -5.99 || WP4.transform.position.z > 5.99){
                WP4.transform.position = WP4P;
            }
        }
        if(WP5.transform.position.y < 1 && (Math.Abs(WP5.transform.eulerAngles.x) > 0.1)){
            WP5.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(WP5.transform.position.x < -5.99 || WP5.transform.position.x > 5.99 || WP5.transform.position.z < -5.99 || WP5.transform.position.z > 5.99){
                WP5.transform.position = WP5P;
            }
        }
        if(WP6.transform.position.y < 1 && (Math.Abs(WP6.transform.eulerAngles.x) > 0.1)){
            WP6.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(WP6.transform.position.x < -5.99 || WP6.transform.position.x > 5.99 || WP6.transform.position.z < -5.99 || WP6.transform.position.z > 5.99){
                WP6.transform.position = WP6P;
            }
        }
        if(WP7.transform.position.y < 1 && (Math.Abs(WP7.transform.eulerAngles.x) > 0.1)){
            WP7.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(WP7.transform.position.x < -5.99 || WP7.transform.position.x > 5.99 || WP7.transform.position.z < -5.99 || WP7.transform.position.z > 5.99){
                WP7.transform.position = WP7P;
            }
        }
        if(WP8.transform.position.y < 1 && (Math.Abs(WP8.transform.eulerAngles.x) > 0.1)){
            WP8.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(WP8.transform.position.x < -5.99 || WP8.transform.position.x > 5.99 || WP8.transform.position.z < -5.99 || WP8.transform.position.z > 5.99){
                WP8.transform.position = WP8P;
            }
        }
        if(BR1.transform.position.y < 1 && (Math.Abs(BR1.transform.eulerAngles.x) > 0.1)){
            BR1.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(BR1.transform.position.x < -5.99 || BR1.transform.position.x > 5.99 || BR1.transform.position.z < -5.99 || BR1.transform.position.z > 5.99){
                BR1.transform.position = BR1P;
            }
        }
        if(BN1.transform.position.y < 1 && (Math.Abs(BN1.transform.eulerAngles.x) > 0.1)){
            BN1.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(BN1.transform.position.x < -5.99 || BN1.transform.position.x > 5.99 || BN1.transform.position.z < -5.99 || BN1.transform.position.z > 5.99){
                BN1.transform.position = BN1P;
            }
        }
        if(BB1.transform.position.y < 1 && (Math.Abs(BB1.transform.eulerAngles.x) > 0.1)){
            BB1.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(BB1.transform.position.x < -5.99 || BB1.transform.position.x > 5.99 || BB1.transform.position.z < -5.99 || BB1.transform.position.z > 5.99){
                BB1.transform.position = BB1P;
            }
        }
        if(BQ.transform.position.y < 1 && (Math.Abs(BQ.transform.eulerAngles.x) > 0.1)){
            BQ.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(BQ.transform.position.x < -5.99 || BQ.transform.position.x > 5.99 || BQ.transform.position.z < -5.99 || BQ.transform.position.z > 5.99){
                BQ.transform.position = BQP;
            }
        }
        if(BK.transform.position.y < 1 && (Math.Abs(BK.transform.eulerAngles.x) > 0.1)){
            BK.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(BK.transform.position.x < -5.99 || BK.transform.position.x > 5.99 || BK.transform.position.z < -5.99 || BK.transform.position.z > 5.99){
                BK.transform.position = BKP;
            }
        }
        if(BB2.transform.position.y < 1 && (Math.Abs(BB2.transform.eulerAngles.x) > 0.1)){
            BB2.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(BB2.transform.position.x < -5.99 || BB2.transform.position.x > 5.99 || BB2.transform.position.z < -5.99 || BB2.transform.position.z > 5.99){
                BB2.transform.position = BB2P;
            }
        }
        if(BN2.transform.position.y < 1 && (Math.Abs(BN2.transform.eulerAngles.x) > 0.1)){
            BN2.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(BN2.transform.position.x < -5.99 || BN2.transform.position.x > 5.99 || BN2.transform.position.z < -5.99 || BN2.transform.position.z > 5.99){
                BN2.transform.position = BN2P;
            }
        }
        if(BR2.transform.position.y < 1 && (Math.Abs(BR2.transform.eulerAngles.x) > 0.1)){
            BR2.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(BR2.transform.position.x < -5.99 || BR2.transform.position.x > 5.99 || BR2.transform.position.z < -5.99 || BR2.transform.position.z > 5.99){
                BR2.transform.position = BR2P;
            }
     }
        if(BP1.transform.position.y < 1 && (Math.Abs(BP1.transform.eulerAngles.x) > 0.1)){
            BP1.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(BP1.transform.position.x < -5.99 || BP1.transform.position.x > 5.99 || BP1.transform.position.z < -5.99 || BP1.transform.position.z > 5.99){
                BP1.transform.position = BP1P;
            }
        }
        if(BP2.transform.position.y < 1 && (Math.Abs(BP2.transform.eulerAngles.x) > 0.1)){
            BP2.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(BP2.transform.position.x < -5.99 || BP2.transform.position.x > 5.99 || BP2.transform.position.z < -5.99 || BP2.transform.position.z > 5.99){
                BP2.transform.position = BP2P;
            }
        }
        if(BP3.transform.position.y < 1 && (Math.Abs(BP3.transform.eulerAngles.x) > 0.1)){
            BP3.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(BP3.transform.position.x < -5.99 || BP3.transform.position.x > 5.99 || BP3.transform.position.z < -5.99 || BP3.transform.position.z > 5.99){
                BP3.transform.position = BP3P;
            }
        }
        if(BP4.transform.position.y < 1 && (Math.Abs(BP4.transform.eulerAngles.x) > 0.1)){
            BP4.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(BP4.transform.position.x < -5.99 || BP4.transform.position.x > 5.99 || BP4.transform.position.z < -5.99 || BP4.transform.position.z > 5.99){
                BP4.transform.position = BP4P;
            }
        }
        if(BP5.transform.position.y < 1 && (Math.Abs(BP5.transform.eulerAngles.x) > 0.1)){
            BP5.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(BP5.transform.position.x < -5.99 || BP5.transform.position.x > 5.99 || BP5.transform.position.z < -5.99 || BP5.transform.position.z > 5.99){
                BP5.transform.position = BP5P;
            }
        }
        if(BP6.transform.position.y < 1 && (Math.Abs(BP6.transform.eulerAngles.x) > 0.1)){
            BP6.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(BP6.transform.position.x < -5.99 || BP6.transform.position.x > 5.99 || BP6.transform.position.z < -5.99 || BP6.transform.position.z > 5.99){
                BP6.transform.position = BP6P;
            }
        }
        if(BP7.transform.position.y < 1 && (Math.Abs(BP7.transform.eulerAngles.x) > 0.1)){
            BP7.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(BP7.transform.position.x < -5.99 || BP7.transform.position.x > 5.99 || BP7.transform.position.z < -5.99 || BP7.transform.position.z > 5.99){
                BP7.transform.position = BP7P;
            }
        }
        if(BP8.transform.position.y < 1 && (Math.Abs(BP8.transform.eulerAngles.x) > 0.1)){
            BP8.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(BP8.transform.position.x < -5.99 || BP8.transform.position.x > 5.99 || BP8.transform.position.z < -5.99 || BP8.transform.position.z > 5.99){
                BP8.transform.position = BP8P;
            }
        }
////////////////////////////////////////////////////////////////////////////////////////////////////
        /*
        if(followPosition)
            anyobject.transform.position = transform.position + offset;
        float xRot = 0f;
        float yRot = 0f;
        float zRot = 0f;
        if(followXRot)
            xRot = transform.eulerAngles.x;
        if(followYRot)
            yRot = transform.eulerAngles.y;
        if(followZRot)
            zRot = transform.eulerAngles.z;
        anyobject.transform.eulerAngles = new Vector3(xRot, yRot, zRot);
        */
    }
}