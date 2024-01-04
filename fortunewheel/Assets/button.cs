using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    public Button yourButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        
    }

    void TaskOnClick(){
        audioSource.PlayOneShot (audioSource.clip);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
