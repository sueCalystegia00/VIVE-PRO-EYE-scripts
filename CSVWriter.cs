using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;
using UnityEngine;
using System.IO;

namespace ViveSR.anipal.Eye
{

  ///<summary>
  /// This source code is based on SRanipal_Unity_SDK version 1.1.0.1.
  /// This class collects eye movement data measured by VIVE-PRO-EYE.
  ///</summary>

  public class CSVWriter : MonoBehaviour
  {
    GetEyeDataModule Module;
    static StreamWriter streamwriter;
    private string filepath = Application.dataPath + @"\Resorces\SaveData.csv";
    private string dataLabels = "timestamp" +","+ "pupilDia_L" +","+ "pupilDia_R" +","+ 
                                                  "pupilPosL.X" +","+ "pupilPosL.Y" +","+ 
                                                  "pupilPosR.X" + "," + "pupilPosR.Y" +"," +
                                                  "gazeDir_L.X" + "," + "gazeDir_L.Y" +"," + "gazeDir_L.Z" +","+
                                                  "gazeDir_R.X" + "," + "gazeDir_R.Y" + "," + "gazeDir_R.Z";
    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
      streamwriter = new StreamWriter(filepath, true) { AutoFlush = true };
      streamwriter.WriteLine(dataLabels);

      Module = GetComponent<GetEyeDataModule>();
    }

    // Called by GetEyeDataModule
    void Write()
    {
      writer90.WriteLine(timeStamp +","+ Module.eyeOpenLeft +","+ Module.eyeOpenRight +","+
                                         Module.pupilDiameterLeft +","+ Module.pupilDiameterRight +","+
                                         Module.pupilPositionLeft.x +","+ Module.pupilPositionLeft.y +","+ 
                                         Module.pupilPositionRight.x +","+ Module.pupilPositionRight.y +","+
                                         Module.gaze_direction_Left.x +","+ Module.gaze_direction_Left.y +","+ Module.gaze_direction_Left.z +","+
                                         Module.gaze_direction_Right.x +","+ Module.gaze_direction_Right.y +","+ Module.gaze_direction_Right.z );
    }
  }
}