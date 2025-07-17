using UnityEngine;

public class Button4View : MonoBehaviour
{
    // �Ώۂ�spriteRenderer���A�^�b�`����
    [SerializeField] private SpriteRenderer _targetRenderer;
    // �F�z���index
    private int _index = 0;
    // �F�z��𐶐�����
    private Color[] _colors = 
    {
        Color.cyan,
        Color.blue,
        Color.green,
        Color.yellow,
        new Color32(0,0xff,0xff,0x10),  //Color32 = 0~255�ŕ\��
        new Color (0f,1f,0f,0.1f),      //Color = 0~1�ŕ\��
    };

    /// <summary>
    /// �{�^�����������ƂɐF��ς���
    /// </summary>
    public void OnChangeColor()
    {
        _targetRenderer.color = _colors[_index];    // �I������ index �̐F���w��
        _index++;                                   // index��1���Z
        _index %= _colors.Length;                   //�F�̍ő吔�𒴂��Ȃ��悤�ɒ���
    }
}
