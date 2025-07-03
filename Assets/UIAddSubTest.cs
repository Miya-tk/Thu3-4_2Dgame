using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAddSubTest : MonoBehaviour
{
    [SerializeField] private GameObject _iconPrefab;    //  �ǉ��E�폜���� icon �̃v���n�u
    [SerializeField] private Transform _iconParent;     // �ǉ�����e�̃I�u�W�F�N�g transform

    // Input system
    private GamePlayerInput _gameInput;

    private int _iconCount = 1;
    // ���������I�u�W�F�N�g���Ǘ�����z��
    private List<GameObject> _icons = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        //input System �̏�����
        _gameInput = new GamePlayerInput(); 
        _gameInput.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // �}�E�X���N���b�N
        if (_gameInput.Player.LeftClick.triggered)
        {
            if (_iconCount == 4) return;
            // _iconCount = _iconCount + 1;
            // _iconCount += 1;
            _iconCount++;
            var icon = Instantiate(_iconPrefab,_iconParent);    // icon �𐶐�
            _icons.Add(icon);                                   // �������� icon �����X�g�ɒǉ�
            Debug.Log("���N���b�N:" + _iconCount);
        }
        // �E�N���b�N
        else if (_gameInput.Player.RightClick.triggered)
        {
            if (_iconCount == 1) return;
            // _iconCount = _iconCount - 1;
            // _iconCount -= 1;
            _iconCount--;
            var icon = _icons[^1];                              // ��ԍŌ�ɒǉ����� icon ���擾
            _icons.Remove(icon);                                // ���X�g����폜
            Destroy(icon);                                      // icon ���폜
            Debug.Log("�E�N���b�N:" +_iconCount);
        }
    }
}
