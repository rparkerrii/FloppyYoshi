using System;
using TMPro;
using UnityEngine;

public class KeyBinding: MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI buttonLbl;

    private void Start()
    {
        buttonLbl.text = PlayerPrefs.GetString("CustomKey");
    }

    private void Update()
    {
        if (buttonLbl.text == "Awaiting Input") 
        {
            foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKey(keyCode))
                {
                    buttonLbl.text = keyCode.ToString();
                    PlayerPrefs.SetString("CustomKey", keyCode.ToString());
                    PlayerPrefs.Save();
                }
            }
        }
    }
  
    public void ChangeKey()
    {
        buttonLbl.text = "Awaiting Input";
    }
}
