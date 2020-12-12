using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class SetFaceFilter : MonoBehaviour
{
    public ARFaceManager aRFaceManager;
    public ARSession aRSession;
    public void Filtru1(GameObject filter)
    {
        aRSession.Reset();
        aRFaceManager.facePrefab = filter;

    }
}
