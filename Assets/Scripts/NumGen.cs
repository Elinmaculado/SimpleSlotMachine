using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumGen : MonoBehaviour
{
    public TMP_Text slotNum;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        DelayNum();
    }

    // Update is called once per frame
    void Update()
    {
        slotNum.text = Random.Range(1, 5).ToString();

    }
    public void offEnabled()
    {
        Invoke("DelayNum", time);
    }

    public void OnEnable()
    {
        enabled = true;
    }

    void DelayNum()
    {
        enabled = false;
    }
}
