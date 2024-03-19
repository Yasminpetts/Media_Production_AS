using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class ModelSwap : MonoBehaviour {
 
    public GameObject[] modelArray;
    public GameObject ui;
    private int modelNumber;
    // Start is called before the first frame update
    void Start()
    {
        modelNumber = 0;
        ModelSwitch();
        HideUI();

    }
    public void ModelSwitch()
    {
        for (int x = 0; x < modelArray.Length; x++)
        {
            if (x == modelNumber)
            {
                modelArray[x].SetActive(true);
            }
            else
            {
                modelArray[x].SetActive(false);
            }
        }
        modelNumber++;
        if (modelNumber >= modelArray.Length)
        {
            modelNumber = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ShowUI();
        }
    }

    public void HideUI()
    {
        ui.SetActive(false);
    }
    public void ShowUI()
    {
        ui.SetActive(true);
    }
}

