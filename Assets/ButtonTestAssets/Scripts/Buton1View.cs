using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Buton1View : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _messageText;
    /// <summary>
    ///  �{�^������������Ăяo�����
    ///  �e�L�X�g�� Hello World! ��\������
    /// </summary>
    public void OnclickButton()
    {
        _messageText.text = "Hello World!";
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
