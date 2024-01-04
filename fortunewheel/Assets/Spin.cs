using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyUI.PickerWheelUI;
using UnityEngine.UI;
using TMPro;
using EasyUI.Popup;

public class Spin : MonoBehaviour
{
    [SerializeField] private Button uiSpinButton;
    [SerializeField] private TMP_Text uiSpinButtonText;
    [SerializeField] private PickerWheel PickerWheel;
    [SerializeField] private AudioSource audioSource ;

    
    private bool popup = false;

    // Start is called before the first frame update
    void Start()
    {
        uiSpinButton.onClick.AddListener(()=>{
            uiSpinButton.interactable = false;
            uiSpinButtonText.text = "Spinning...";
            PickerWheel.OnSpinStart (()=>{Debug.Log("Spin started");});
            PickerWheel.OnSpinEnd ( wheelPiece =>{
                Debug.Log("Spin ended: Label: "+wheelPiece.Label+", Amount:"+wheelPiece.Amount);
                audioSource.PlayOneShot (audioSource.clip);
                uiSpinButton.interactable = true;
                uiSpinButtonText.text = "Spin!";
                Popup.Show("Congratulations!", "You got "+wheelPiece.Label+"!");
            });
            PickerWheel.Spin();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
