using UnityEngine;

public class Button4View : MonoBehaviour
{
    // 対象のspriteRendererをアタッチする
    [SerializeField] private SpriteRenderer _targetRenderer;
    // 色配列のindex
    private int _index = 0;
    // 色配列を生成する
    private Color[] _colors = 
    {
        Color.cyan,
        Color.blue,
        Color.green,
        Color.yellow,
        new Color32(0,0xff,0xff,0x10),  //Color32 = 0~255で表す
        new Color (0f,1f,0f,0.1f),      //Color = 0~1で表す
    };

    /// <summary>
    /// ボタンを押すごとに色を変える
    /// </summary>
    public void OnChangeColor()
    {
        _targetRenderer.color = _colors[_index];    // 選択した index の色を指定
        _index++;                                   // indexを1加算
        _index %= _colors.Length;                   //色の最大数を超えないように調整
    }
}
