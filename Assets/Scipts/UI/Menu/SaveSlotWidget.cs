using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SaveSlotWidget : MonoBehaviour
{
    private string SaveName;

    private GameManager Manager;
    private LoadWidget LoadWidget;

    [SerializeField]
    private TMP_Text SaveNameText;


    private void Awake()
    {
        Manager = GameManager.Instance;
        
    }

    public void Intialize(LoadWidget parentWidget, string saveName)
    {
        LoadWidget = parentWidget;
        SaveName = saveName;
        SaveNameText.text = saveName;
    }

    public void SelectSave()
    {
        Manager.SetActiveSave(SaveName);
        UnityEngine.Debug.Log("Load Scene");

        LoadWidget.LoadScene();
    }

}
