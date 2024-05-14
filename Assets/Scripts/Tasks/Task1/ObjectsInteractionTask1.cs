using UnityEngine;

public class ObjectsInteractionTask1 : MonoBehaviour
{
    // TODO: Получите доступ к объекту со скриптом Refrigerator при помощи атрибута [SerializeField]
    // TODO: При нажатии на кнопку 1 на клавиатуре вызывайте у него метод Interact
    
    [SerializeField] 
    private Refrigerator _refrigerator;
    
    private void Update() {
        if(Input.GetKeyUp(KeyCode.Alpha1)) {
            _refrigerator.Interact();
        }
    }
    
   
}
