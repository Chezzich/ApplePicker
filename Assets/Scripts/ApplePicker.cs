using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("Set In Inspector")]
    public GameObject backetPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpasingY = 2f;
    public List<GameObject> backetsList;

    void Start()
    {
        backetsList = new List<GameObject>();
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(backetPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + basketSpasingY * i;
            tBasketGO.transform.position = pos;
            backetsList.Add(tBasketGO);
        }
    }

    public void AppleDestroyed()
    {
        if (backetsList.Count == 0)
            return;
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tGO in tAppleArray)
        { 
            Destroy(tGO); 
        }

        int backetIndex = backetsList.Count - 1;
        GameObject tBacketGO = backetsList[backetIndex];
        backetsList.RemoveAt(backetIndex);
        Destroy(tBacketGO);

        if (backetsList.Count == 0)
        {
            SceneManager.LoadScene("GameOverScreen");
        }
    }
}
