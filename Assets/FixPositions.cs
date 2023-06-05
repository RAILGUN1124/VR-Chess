using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  
public class FixPositions : MonoBehaviour
{
    public GameObject WK;
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
    public GameObject[] pieces = new GameObject[32];
    public int[,] board = new int[10,10];
    public int[] prevf = new int[32];
    public int[] prank = new int[32];
    // Start is called before the first frame update
    void Start()
    {
        pieces[0] = WR1;
        pieces[1] = WN1;
        pieces[2] = WB1;
        pieces[3] = WQ;
        pieces[4] = WK;
        pieces[5] = WB2;
        pieces[6] = WN2;
        pieces[7] = WR2;
        pieces[8] = WP1;
        pieces[9] = WP2;
        pieces[10] = WP3;
        pieces[11] = WP4;
        pieces[12] = WP5;
        pieces[13] = WP6;
        pieces[14] = WP7;
        pieces[15] = WP8;
        pieces[16] = BR1;
        pieces[17] = BN1;
        pieces[18] = BB1;
        pieces[19] = BQ;
        pieces[20] = BK;
        pieces[21] = BB2;
        pieces[22] = BN2;
        pieces[23] = BR2;
        pieces[24] = BP1;
        pieces[25] = BP2;
        pieces[26] = BP3;
        pieces[27] = BP4;
        pieces[28] = BP5;
        pieces[29] = BP6;
        pieces[30] = BP7;
        pieces[31] = BP8;
        for(int i=0; i<10; i++){
            for(int j=0; j<10; j++){
                board[i,j] = -1;
            }
        }
        for(int i=0; i<32; i++){
            prevf[i] = (int)((pieces[i].transform.position.x+7.5)/1.5);
            prank[i] = (int)((pieces[i].transform.position.z+7.5)/1.5);
            board[prevf[i],prank[i]] = i;
        }
        Debug.Log(board[5,1]);
        /*
        pos = new float[10]; //pos = {0f, -5.25f, -3.75f, -2.25f, -0.75f, 0.75f, 2.25f, 3.75f, 5.25f, 0f};
        float[] file = new float[10];
        float[] prank = new float[10];
        for(int i=1; i<=8; i++){
            pos[i] = -6.75f + (float)(1.5*i);
            rank[i] = -6.75f + (float)(1.5*i);
        }
        */
        //Debug.Log(transform.position);
        
        //transform.position = new Vector3(file[5], 0.45f, rank[5]);
        //transform.position = new Vector3(pos[(int)((transform.position.x+6.75)/1.5)], 0.45f, pos[(int)((transform.position.z+6.75)/1.5)]);
        /*
        Debug.Log("Tracking White King's position");
        Debug.Log(pieces[4].transform.position);
        Debug.Log(pieces[4].transform.position.GetType());
        Vector3 WK1 = transform.position;
        Vector3 Test = new Vector3(0.75f, 0.45f, -5.25f);
        Debug.Log(Test.x);
        Debug.Log(WK.transform.eulerAngles.x);
        Debug.Log(WK.transform.eulerAngles.y);
        Debug.Log(WK.transform.eulerAngles.z);
        */
    }
  
    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<32; i++){
            if(Math.Abs(pieces[i].transform.position.y)<1 && (Math.Abs(pieces[i].transform.eulerAngles.x)>0.1)){
                pieces[i].transform.eulerAngles = new Vector3(0f, 0f, 0f);
                if(pieces[i].transform.position.x < -5.99 || pieces[i].transform.position.x > 5.99 || pieces[i].transform.position.z < -5.99 || pieces[i].transform.position.z > 5.99){
                    pieces[i].transform.position = new Vector3((float)(-6.75+1.5*prevf[i]), (float)(0.45-(((int)(i/8))%2)*0.17), (float)(-6.75+1.5*prank[i]));
                }
                else{
                    int newfile = (int)((pieces[i].transform.position.x+7.5)/1.5);
                    int newrank = (int)((pieces[i].transform.position.z+7.5)/1.5);
                    bool valid = false;
                    if(((int)(i/8))%2==1 /* is pawn */){
                        if(((int)(i/16))%2==0 /* is white */ && newfile==prevf[i] && newrank==prank[i]+1 && board[newfile,newrank]==-1){valid = true;}
                        else if(((int)(i/16))%2==0 && newfile==prevf[i] && newrank==prank[i]+2 && prank[i]==2 && board[newfile,newrank]==-1){valid = true;}
                        else if(((int)(i/16))%2==1 /* is black */ && newfile==prevf[i] && newrank==prank[i]-1 && board[newfile,newrank]==-1){valid = true;}
                        else if(((int)(i/16))%2==1 && newfile==prevf[i] && newrank==prank[i]-2 && prank[i]==6 && board[newfile,newrank]==-1){valid = true;}
                    }
                    if(valid){
                        board[prevf[i],prank[i]] = -1;
                        prevf[i] = newfile;
                        prank[i] = newrank;
                        pieces[i].transform.position = new Vector3((float)(-6.75+1.5*prevf[i]), (float)(0.45-(((int)(i/8))%2)*0.17), (float)(-6.75+1.5*prank[i]));
                        board[prevf[i],prank[i]] = i;
                    }
                    else{
                        pieces[i].transform.position = new Vector3((float)(-6.75+1.5*prevf[i]), (float)(0.45-(((int)(i/8))%2)*0.17), (float)(-6.75+1.5*prank[i]));
                    }
                }
            }
        }
        /*
        if(transform.position.y < 1 && (Math.Abs(transform.eulerAngles.x) > 0.1)){
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            if(transform.position.x < -5.99 || transform.position.x > 5.99 || transform.position.z < -5.99 || transform.position.z > 5.99){
                //transform.position = WK1P;
            }
        }
        */
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