using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


    public class ModelSwap : MonoBehaviour {
 
    public GameObject[] modelArray;
    public GameObject ui;
    // change00 private int modelNumber;
    private int modelNumber = 0;
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
            // modelArray[x].SetActive(false);
            
            
            if (x == modelNumber)
            {
                modelArray[x].SetActive(true);
            }
            else
            {
                modelArray[x].SetActive(false);
            }
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
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void ShowUI()
    {
        ui.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void PressButton()
    {
        modelNumber++;
        if (modelNumber >= modelArray.Length)
        {
            modelNumber = 0;
        }
        ModelSwitch();
    }

    public void ConfirmButton()
    {
        SceneManager.LoadScene("CarCntrl");
    }
}

