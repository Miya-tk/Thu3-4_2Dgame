using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Button2View : MonoBehaviour
{   
    // MessageTextをアタッチする
    [SerializeField] private TextMeshProUGUI _messageText;
    //配列のインデックス
    private int _index = 0;
    //文字の配列データ
    private string[] _messages = {"Start Game.", "End Game"};
    /// <summary>
    ///押すたびにメッセージが切り替わるようにボタン設定
    /// </summary>
    public void OnMessageChangeClick()
    {
        _messageText.text = _messages[_index];
        // indexを1加算
        // _index = _index = 1;
        // _index +=1;
        _index++;
        //indxが配列の最大数以上になったら0に戻す
        //if(_indexn >= _messages.Length) _index = 0;
        _index %= _messages.Length;
    }
}
