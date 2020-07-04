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
        private string dataLabels = "timestamp" + "," + 
                                    "gazeOrigin_L.X" + "," + "gazeOrigin_L.Y" + "," + "gazeOrigin_L.Z" + "," +
                                    "gazeOrigin_R.X" + "," + "gazeOrigin_R.Y" + "," + "gazeOrigin_R.Z" + "," +
                                    "gazeDir_L.X" + "," + "gazeDir_L.Y" + "," + "gazeDir_L.Z" + "," +
                                    "gazeDir_R.X" + "," + "gazeDir_R.Y" + "," + "gazeDir_R.Z" + "," +
                                    "pupilDia_L" + "," + "pupilDia_R" + "," +
                                    "eyeOpenness_L" + "," + "eyeOpenness_R" + "," +
                                    "pupilPosL.X" + "," + "pupilPosL.Y" + "," +
                                    "pupilPosR.X" + "," + "pupilPosR.Y";
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
            streamwriter.WriteLine( GetEyeDataModule.timeStamp + "," + 
                                    GetEyeDataModule.gazeOriginLeft.x + "," + GetEyeDataModule.gazeOriginLeft.y + "," + GetEyeDataModule.gazeOriginLeft.z + "," +
                                    GetEyeDataModule.gazeOriginRight.x + "," + GetEyeDataModule.gazeOriginRight.y + "," + GetEyeDataModule.gazeOriginRight.z + ","+
                                    GetEyeDataModule.gazeDirectionLeft.x + "," + GetEyeDataModule.gazeDirectionLeft.y + "," + GetEyeDataModule.gazeDirectionLeft.z + "," +
                                    GetEyeDataModule.gazeDirectionRight.x + "," + GetEyeDataModule.gazeDirectionRight.y + "," + GetEyeDataModule.gazeDirectionRight.z + "," +
                                    GetEyeDataModule.pupilDiameterLeft + "," + GetEyeDataModule.pupilDiameterRight + "," +
                                    GetEyeDataModule.eyeOpenLeft + "," + GetEyeDataModule.eyeOpenRight + ","+
                                    GetEyeDataModule.pupilPositionLeft.x + "," + GetEyeDataModule.pupilPositionLeft.y + "," +
                                    GetEyeDataModule.pupilPositionRight.x + "," + GetEyeDataModule.pupilPositionRight.y);
        }
    }
}
