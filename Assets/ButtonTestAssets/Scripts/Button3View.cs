using UnityEngine;

public class Button3View : MonoBehaviour
{
    // �ړ�����Ώۂ�transform���A�^�b�`����
    [SerializeField] private Transform _targetTransform;

    public void OnTargetMove()
    {
        _targetTransform.localPosition = new Vector3(2.7f, -3.5f, 0);
    }
}
