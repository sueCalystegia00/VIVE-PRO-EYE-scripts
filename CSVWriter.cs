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
        private static StreamWriter streamwriter;
        private string filepath;
        private string dataLabels = "timestamp" + "," + "pupilDia_L" + "," + "pupilDia_R" + "," +
                                                      "pupilPosL.X" + "," + "pupilPosL.Y" + "," +
                                                      "pupilPosR.X" + "," + "pupilPosR.Y" + "," +
                                                      "gazeDir_L.X" + "," + "gazeDir_L.Y" + "," + "gazeDir_L.Z" + "," +
                                                      "gazeDir_R.X" + "," + "gazeDir_R.Y" + "," + "gazeDir_R.Z";
        /// <summary>
        /// Use this for initialization
        /// </summary>
        void Start()
        {
            filepath = Application.dataPath + "/Resorces/SaveData.csv";
            streamwriter = new StreamWriter(filepath, true) { AutoFlush = true };
            streamwriter.WriteLine(dataLabels);
        }

        // Called by GetEyeDataModule
        public static void Write()
        {
            streamwriter.WriteLine(GetEyeDataModule.timeStamp + "," + GetEyeDataModule.eyeOpenLeft + "," + GetEyeDataModule.eyeOpenRight + ","+
                                               GetEyeDataModule.pupilDiameterLeft + "," + GetEyeDataModule.pupilDiameterRight + "," +
                                               GetEyeDataModule.pupilPositionLeft.x + "," + GetEyeDataModule.pupilPositionLeft.y + "," +
                                               GetEyeDataModule.pupilPositionRight.x + "," + GetEyeDataModule.pupilPositionRight.y + "," +
                                               GetEyeDataModule.gaze_direction_Left.x + "," + GetEyeDataModule.gaze_direction_Left.y + "," + GetEyeDataModule.gaze_direction_Left.z + "," +
                                               GetEyeDataModule.gaze_direction_Right.x + "," + GetEyeDataModule.gaze_direction_Right.y + "," + GetEyeDataModule.gaze_direction_Right.z);
        }
    }
}
