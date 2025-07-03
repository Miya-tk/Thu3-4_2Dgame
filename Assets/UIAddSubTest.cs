using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAddSubTest : MonoBehaviour
{
    [SerializeField] private GameObject _iconPrefab;    //  追加・削除する icon のプレハブ
    [SerializeField] private Transform _iconParent;     // 追加する親のオブジェクト transform

    // Input system
    private GamePlayerInput _gameInput;

    private int _iconCount = 1;
    // 生成したオブジェクトを管理する配列
    private List<GameObject> _icons = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        //input System の初期化
        _gameInput = new GamePlayerInput(); 
        _gameInput.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // マウス左クリック
        if (_gameInput.Player.LeftClick.triggered)
        {
            if (_iconCount == 4) return;
            // _iconCount = _iconCount + 1;
            // _iconCount += 1;
            _iconCount++;
            var icon = Instantiate(_iconPrefab,_iconParent);    // icon を生成
            _icons.Add(icon);                                   // 生成した icon をリストに追加
            Debug.Log("左クリック:" + _iconCount);
        }
        // 右クリック
        else if (_gameInput.Player.RightClick.triggered)
        {
            if (_iconCount == 1) return;
            // _iconCount = _iconCount - 1;
            // _iconCount -= 1;
            _iconCount--;
            var icon = _icons[^1];                              // 一番最後に追加した icon を取得
            _icons.Remove(icon);                                // リストから削除
            Destroy(icon);                                      // icon を削除
            Debug.Log("右クリック:" +_iconCount);
        }
    }
}
