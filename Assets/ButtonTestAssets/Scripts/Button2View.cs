using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Button2View : MonoBehaviour
{   
    // MessageText���A�^�b�`����
    [SerializeField] private TextMeshProUGUI _messageText;
    //�z��̃C���f�b�N�X
    private int _index = 0;
    //�����̔z��f�[�^
    private string[] _messages = {"Start Game.", "End Game"};
    /// <summary>
    ///�������тɃ��b�Z�[�W���؂�ւ��悤�Ƀ{�^���ݒ�
    /// </summary>
    public void OnMessageChangeClick()
    {
        _messageText.text = _messages[_index];
        // index��1���Z
        // _index = _index = 1;
        // _index +=1;
        _index++;
        //indx���z��̍ő吔�ȏ�ɂȂ�����0�ɖ߂�
        //if(_indexn >= _messages.Length) _index = 0;
        _index %= _messages.Length;
    }
}
