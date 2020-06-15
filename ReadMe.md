# VIVE pro eye Scripts
Examples to measure eye movement data using VIVE pro eye.<br>
* SRanipal_Unity_SDK version 1.1.0.1
* Eye_ver2

## Overview
* GetEyeDataModule.cs ~
  This is a sample code to use the callback function to get the eye information at 120Hz, which is higher than Unity's frequency of object update (90Hz).

## Usage
1. Place the prefab for eye movement measurement in your scene．
   Assets/ViveSR/Prefabs/SRanipal Eye Framework.prefab
2. Check the boxes of "Enable Eye" and "Enable Eye Data Callback".
3. Set the "Enable Eye Version" to "version 2".
4. Add this script to the object of SRanipal Eye Framework.
