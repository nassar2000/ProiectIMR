using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeScreenshot : MonoBehaviour
{



    public void TakeAShot()
    {
        StartCoroutine(CaptureIt());
    }

    IEnumerator CaptureIt()
    {

        yield return new WaitForEndOfFrame();
        string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
        string fileName = "/Screenshot" + timeStamp + ".png";
        string path = Application.persistentDataPath + fileName;

        Texture2D screenImage = new Texture2D(900, 1300, TextureFormat.RGB24, false);
        //Get Image from screen
        screenImage.ReadPixels(new Rect(100, 600, Screen.width, Screen.height), 0, 0);
        screenImage.Apply();
        //Convert to png
        byte[] imageBytes = screenImage.EncodeToPNG();

        //Save image to file
        System.IO.File.WriteAllBytes(path, imageBytes);
    }

}
