using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timerScript : MonoBehaviour
{

    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currTime;
    public bool countUp;
// Start is called before the first frame update
void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {


        currTime = countUp ? currTime -= Time.deltaTime : currTime += Time.deltaTime;
        timerText.text = currTime.ToString();
    }
}
