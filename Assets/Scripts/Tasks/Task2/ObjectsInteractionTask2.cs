using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    // TODO: В методе Awake создайте на сцене в точке LampRoot одну из наборов ламп (из папки Prefabs/Lamps)
    [SerializeField]
    private GameObject _lampPrefab;
    
    [SerializeField]
    private GameObject _lampRoot;
    
    private GameObject _lamp;
    
    private void Awake() {
        _lamp = _lampPrefab;
        Instantiate(_lamp, _lampRoot.transform);
    }
}