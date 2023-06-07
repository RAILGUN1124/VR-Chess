using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Threading;

  
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
    public GameObject playercam;
    public AudioSource audioSource;
    public AudioSource audioSourceCapture;
    public GameObject GameOverScreen;
    public GameObject[] pieces = new GameObject[32];
    public int[,] board = new int[10,10];
    public int[] prevf = new int[32];
    public int[] prank = new int[32];
    public bool white = true;
    public int turn = 0;
    public string[] alpha = new string[32];
    public int target = -1;
    public int animationstep = 0;
    public float oldx = 0;
    public float oldy = 0;
    public float xdiff = 0;
    public float ydiff = 0;
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
        alpha[0] = "R";
        alpha[1] = "N";
        alpha[2] = "B";
        alpha[3] = "Q";
        alpha[4] = "K";
        alpha[5] = "B";
        alpha[6] = "N";
        alpha[7] = "R";
        alpha[8] = "P";
        alpha[9] = "P";
        alpha[10] = "P";
        alpha[11] = "P";
        alpha[12] = "P";
        alpha[13] = "P";
        alpha[14] = "P";
        alpha[15] = "P";
        alpha[16] = "r";
        alpha[17] = "n";
        alpha[18] = "b";
        alpha[19] = "q";
        alpha[20] = "k";
        alpha[21] = "b";
        alpha[22] = "n";
        alpha[23] = "r";
        alpha[24] = "p";
        alpha[25] = "p";
        alpha[26] = "p";
        alpha[27] = "p";
        alpha[28] = "p";
        alpha[29] = "p";
        alpha[30] = "p";
        alpha[31] = "p";
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
        GameOverScreen.SetActive(false);
        //Debug.Log(board[5,1]);
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
        if(white==true){
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
                        bool invalid = false;
                        if(((int)(i/8))%2==1 /*is pawn*/){
                            if(((int)(i/16))%2==0 /*is white*/ && newfile==prevf[i] && newrank==prank[i]+1 && board[newfile,newrank]==-1){valid = true;}
                            else if(((int)(i/16))%2==0 && newfile==prevf[i] && newrank==prank[i]+2 && prank[i]==2 && board[newfile,newrank]==-1){valid = true;}
                            else if(((int)(i/16))%2==1 /*is black*/ && newfile==prevf[i] && newrank==prank[i]-1 && board[newfile,newrank]==-1){valid = true;}
                            else if(((int)(i/16))%2==1 && newfile==prevf[i] && newrank==prank[i]-2 && prank[i]==7 && board[newfile,newrank]==-1){valid = true;}
                            else if(((int)(i/16))%2==0 && Math.Abs(newfile-prevf[i])==1 && newrank==prank[i]+1 && board[newfile,newrank]>=16){
                                //capture
                                valid = true;
                                pieces[board[newfile,newrank]].transform.position = new Vector3(0.0f, -2.0f, 0.0f);
                                audioSourceCapture.Play();
                            }
                            else if(((int)(i/16))%2==1 && Math.Abs(newfile-prevf[i])==1 && newrank==prank[i]-1 && board[newfile,newrank]<16 && board[newfile,newrank]>=0){
                                valid = true;
                                pieces[board[newfile,newrank]].transform.position = new Vector3(0.0f, -2.0f, 0.0f);
                                audioSourceCapture.Play();
                            }
                        }
                        else if(i==0 || i==7 || i==16 || i==23 /*rook*/){
                            //check if a piece is in the way
                            if(newfile==prevf[i] && newrank!=prank[i]){
                                for(int j=prank[i]+Math.Sign(newrank-prank[i]); j!=newrank; j+=Math.Sign(newrank-prank[i])){
                                    if(board[newfile, j]!=-1){invalid = true; break;}
                                }
                            }
                            else if(newfile!=prevf[i] && newrank==prank[i]){
                                for(int j=prevf[i]+Math.Sign(newfile-prevf[i]); j!=newfile; j+=Math.Sign(newfile-prevf[i])){
                                    if(board[j, newrank]!=-1){invalid = true; break;}
                                }
                            }
                            if(!invalid && (newfile==prevf[i] ^ newrank==prank[i])){
                                if(board[newfile,newrank]==-1){valid = true;}
                                else if(((int)(i/16))%2==0 && board[newfile,newrank]>=16){
                                    valid = true;
                                    pieces[board[newfile,newrank]].transform.position = new Vector3(0.0f, -2.0f, 0.0f);
                                    audioSourceCapture.Play();
                                }
                                else if(((int)(i/16))%2==1 && board[newfile,newrank]<16 && board[newfile,newrank]>=0){
                                    valid = true;
                                    pieces[board[newfile,newrank]].transform.position = new Vector3(0.0f, -2.0f, 0.0f);
                                    audioSourceCapture.Play();
                                }
                            }
                        }
                        else if(i==1 || i==6 || i==17 || i==22 /*knight*/){
                            if(Math.Abs(newfile-prevf[i])==2 && Math.Abs(newrank-prank[i])==1 || Math.Abs(newfile-prevf[i])==1 && Math.Abs(newrank-prank[i])==2){
                                if(board[newfile,newrank]==-1){valid = true;}
                                else if(((int)(i/16))%2==0 && board[newfile,newrank]>=16){
                                    valid = true;
                                    pieces[board[newfile,newrank]].transform.position = new Vector3(0.0f, -2.0f, 0.0f);
                                    audioSourceCapture.Play();
                                }
                                else if(((int)(i/16))%2==1 && board[newfile,newrank]<16 && board[newfile,newrank]>=0){
                                    valid = true;
                                    pieces[board[newfile,newrank]].transform.position = new Vector3(0.0f, -2.0f, 0.0f);
                                    audioSourceCapture.Play();
                                }
                            }
                        }
                        else if(i==2 || i==5 || i==18 || i==21 /*bishop*/){
                            if(newfile!=prevf[i] && Math.Abs(newfile-prevf[i])==Math.Abs(newrank-prank[i])){
                                for(int j=1; j<Math.Abs(newfile-prevf[i]); j++){
                                    if(board[prevf[i]+j*Math.Sign(newfile-prevf[i]),prank[i]+j*Math.Sign(newrank-prank[i])]!=-1){invalid = true; break;}
                                }
                                if(!invalid){
                                    if(board[newfile,newrank]==-1){valid = true;}
                                    else if(((int)(i/16))%2==0 && board[newfile,newrank]>=16){
                                        valid = true;
                                        pieces[board[newfile,newrank]].transform.position = new Vector3(0.0f, -2.0f, 0.0f);
                                        audioSourceCapture.Play();
                                    }
                                    else if(((int)(i/16))%2==1 && board[newfile,newrank]<16 && board[newfile,newrank]>=0){
                                        valid = true;
                                        pieces[board[newfile,newrank]].transform.position = new Vector3(0.0f, -2.0f, 0.0f);
                                        audioSourceCapture.Play();
                                    }
                                }
                            }
                        }
                        else if(i==3 || i==19 /*queen*/){
                            if(newfile==prevf[i] ^ newrank==prank[i] /*rook movement*/){
                                if(newfile==prevf[i] && newrank!=prank[i]){
                                    for(int j=prank[i]+Math.Sign(newrank-prank[i]); j!=newrank; j+=Math.Sign(newrank-prank[i])){
                                        if(board[newfile, j]!=-1){invalid = true; break;}
                                    }
                                }
                                else if(newfile!=prevf[i] && newrank==prank[i]){
                                    for(int j=prevf[i]+Math.Sign(newfile-prevf[i]); j!=newfile; j+=Math.Sign(newfile-prevf[i])){
                                        if(board[j, newrank]!=-1){invalid = true; break;}
                                    }
                                }
                                if(!invalid){
                                    if(board[newfile,newrank]==-1){valid = true;}
                                    else if(((int)(i/16))%2==0 && board[newfile,newrank]>=16){
                                        valid = true;
                                        pieces[board[newfile,newrank]].transform.position = new Vector3(0.0f, -2.0f, 0.0f);
                                        audioSourceCapture.Play();
                                    }
                                    else if(((int)(i/16))%2==1 && board[newfile,newrank]<16 && board[newfile,newrank]>=0){
                                        valid = true;
                                        pieces[board[newfile,newrank]].transform.position = new Vector3(0.0f, -2.0f, 0.0f);
                                        audioSourceCapture.Play();
                                    }
                                }
                            }
                            else if(newfile!=prevf[i] && Math.Abs(newfile-prevf[i])==Math.Abs(newrank-prank[i]) /*bishop movement*/){
                                for(int j=1; j<Math.Abs(newfile-prevf[i]); j++){
                                    if(board[prevf[i]+j*Math.Sign(newfile-prevf[i]),prank[i]+j*Math.Sign(newrank-prank[i])]!=-1){invalid = true; break;}
                                }
                                if(!invalid){
                                    if(board[newfile,newrank]==-1){valid = true;}
                                    else if(((int)(i/16))%2==0 && board[newfile,newrank]>=16){
                                        valid = true;
                                        pieces[board[newfile,newrank]].transform.position = new Vector3(0.0f, -2.0f, 0.0f);
                                        audioSourceCapture.Play();
                                    }
                                    else if(((int)(i/16))%2==1 && board[newfile,newrank]<16 && board[newfile,newrank]>=0){
                                        valid = true;
                                        pieces[board[newfile,newrank]].transform.position = new Vector3(0.0f, -2.0f, 0.0f);
                                        audioSourceCapture.Play();
                                    }
                                }
                            }
                        }
                        else if(i==4 || i==20 /*king*/){
                            if((newfile!=prevf[i] || newrank!=prank[i]) && Math.Abs(newfile-prevf[i])<=1 && Math.Abs(newrank-prank[i])<=1){
                                if(board[newfile,newrank]==-1){valid = true;}
                                else if(((int)(i/16))%2==0 && board[newfile,newrank]>=16){
                                    valid = true;
                                    pieces[board[newfile,newrank]].transform.position = new Vector3(0.0f, -2.0f, 0.0f);
                                    audioSourceCapture.Play();
                                }
                                else if(((int)(i/16))%2==1 && board[newfile,newrank]<16 && board[newfile,newrank]>=0){
                                    valid = true;
                                    pieces[board[newfile,newrank]].transform.position = new Vector3(0.0f, -2.0f, 0.0f);
                                    audioSourceCapture.Play();
                                }
                            }
                        }
                        if(valid){
                            board[prevf[i],prank[i]] = -1;
                            prevf[i] = newfile;
                            prank[i] = newrank;
                            pieces[i].transform.position = new Vector3((float)(-6.75+1.5*prevf[i]), (float)(0.45-(((int)(i/8))%2)*0.17), (float)(-6.75+1.5*prank[i]));
                            board[prevf[i],prank[i]] = i;
                            Debug.Log(board[prevf[i],prank[i]]);
                            white = false;
                            turn++;
                            
                        }
                        else{
                            pieces[i].transform.position = new Vector3((float)(-6.75+1.5*prevf[i]), (float)(0.45-(((int)(i/8))%2)*0.17), (float)(-6.75+1.5*prank[i]));
                        }
                    }
                }
            }
        }
        else if(animationstep==0){
            string FENstr = "";
            for(int i=1; i<=8; i++){
                int count = 0;
                for(int j=1; j<=8; j++){
                    if(board[j,9-i]==-1){
                        count++;
                    }
                    else{
                        if(count>0){
                            FENstr+=count.ToString();
                            count = 0;
                        }
                        FENstr+=alpha[board[j,9-i]];
                    }
                }
                if(count>0){
                    FENstr+=count.ToString();
                    count = 0;
                }
                if(i<8){FENstr += "/";}
            }
            FENstr += " b - - 0 ";
            FENstr += turn.ToString();
            Debug.Log(FENstr);
            string output;
            using(System.Diagnostics.Process pProcess = new System.Diagnostics.Process()){
                pProcess.StartInfo.FileName = @"C:\Users\123456\stockfish_15.1_win_x64_avx2\stockfish-windows-2022-x86-64-avx2.exe";
                pProcess.StartInfo.UseShellExecute = false;
                pProcess.StartInfo.RedirectStandardInput = true;
                pProcess.StartInfo.RedirectStandardOutput = true;
                pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                pProcess.StartInfo.CreateNoWindow = true; //not diplay a windows
                pProcess.Start();
                pProcess.StandardInput.WriteLine("position fen "+FENstr);
                pProcess.StandardInput.WriteLine("go movetime 1000\n");
                Thread.Sleep(1050);
                pProcess.StandardInput.WriteLine("quit");
                output = pProcess.StandardOutput.ReadToEnd(); //The output result
            }
            int mate1 = output.IndexOf("mate 1");
            if(output.IndexOf("bestmove")>-1){
                string best = output.Substring(output.IndexOf("bestmove"));
                Debug.Log(best);
                best = best.Substring(best.IndexOf(" ")+1,4);
                //Debug.Log(best);
                target = board[best[0]-96,best[1]-48];
                Debug.Log(target);
                board[best[0]-96,best[1]-48] = -1;
                xdiff = (float)(1.5*(best[2]-best[0]));
                //Debug.Log(xdiff);
                ydiff = (float)(1.5*(best[3]-best[1]));
                //Debug.Log(ydiff);
                if(board[best[2]-96,best[3]-48]!=-1){
                    pieces[board[best[2]-96,best[3]-48]].transform.position = new Vector3(0.0f, -2.0f, 0.0f);
                }
                board[best[2]-96,best[3]-48] = target;
                //animationstep = 1;
                prevf[target] = best[2]-96;
                prank[target] = best[3]-48;
                pieces[target].transform.position = new Vector3((float)(-6.75+1.5*prevf[target]), (float)(0.45-(((int)(target/8))%2)*0.17), (float)(-6.75+1.5*prank[target]));
            /*
            }
            else if(animationstep<10){
                pieces[target].transform.position = new Vector3(oldx+animationstep*xdiff/10, (float)(0.45-(((int)(target/8))%2)*0.17), oldy+animationstep*ydiff/10);
                animationstep++;
                Thread.Sleep(50);
            }
            else{
            */
                //pieces[target].transform.position = new Vector3(oldx+xdiff, (float)(0.45-(((int)(target/8))%2)*0.17), oldy+ydiff);
                //animationstep = 0;
                white = true;
                if(mate1>-1){
                    playercam.transform.position = new Vector3(playercam.transform.position.x, 20.0f, playercam.transform.position.z);
                    Debug.Log("Game Over");
                    animationstep = 1;
                    audioSource.Play();
                    GameOverScreen.SetActive(true);
                }
            }
            else{
                playercam.transform.position = new Vector3(playercam.transform.position.x, 20.0f, playercam.transform.position.z);
                Debug.Log("Game Over");
                animationstep = 1;
                audioSource.Play();
                GameOverScreen.SetActive(true);
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