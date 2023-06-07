using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Threading;

public class Stock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string output;
///////////////////

string FENstr = "r1bqkbnr/pppp1ppp/2n5/1B2p3/4P3/5N2/PPPP1PPP/RNBQK2R b KQkq - 3 3";
using(System.Diagnostics.Process pProcess = new System.Diagnostics.Process())
{
    pProcess.StartInfo.FileName = @"C:\Users\Benjamin\Downloads\Program Files\stockfish_15.1_win_x64_avx2\stockfish-windows-2022-x86-64-avx2.exe";
    //pProcess.StartInfo.Arguments = "position fen "+FENstr; //argument
    pProcess.StartInfo.UseShellExecute = false;
    pProcess.StartInfo.RedirectStandardInput = true;
    pProcess.StartInfo.RedirectStandardOutput = true;
    pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
    pProcess.StartInfo.CreateNoWindow = true; //not diplay a windows
    pProcess.Start();
    //output = pProcess.StandardOutput.ReadLine();
    //Debug.Log(output);
    pProcess.StandardInput.WriteLine("position fen "+FENstr);
    pProcess.StandardInput.WriteLine("go movetime 3000\n");
    Thread.Sleep(3200);
    pProcess.StandardInput.WriteLine("quit");
    output = pProcess.StandardOutput.ReadToEnd(); //The output result
}
Debug.Log(output);


///////////////////
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
