using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ScrollView : MonoBehaviour
{
    private readonly List<GameObject> _items = new List<GameObject>();

    public ARFaceManager aRFaceManager;

    public void Filtru1(GameObject filter)
    {
        //aRFaceManager = gameObject.AddComponent<ARFaceManager>();
        aRFaceManager.facePrefab = filter;
    }
}
