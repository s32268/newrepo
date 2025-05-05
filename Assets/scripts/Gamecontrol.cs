using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string mainWorld = "default";
    public TextMeshProUGUI mainWorldText;


    // Start is called before the first frame update
    void Start()
    {
        mainWorldText.text = mainWorld;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
