using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FormManager : MonoBehaviour
{
    public TMP_InputField firstInput;
    public EventSystem eventSystem;


    private void OnEnable()
    {
        firstInput.Select();
    }
    private void Start()
    {
        eventSystem = EventSystem.current;
    }
    private void Update()
    {
        GameObject currentlySelected = eventSystem.currentSelectedGameObject;
        Selectable selectable = currentlySelected.GetComponent<Selectable>();
        if (selectable != null)
        {
            if (Input.GetKeyDown(KeyCode.Tab) && Input.GetKey(KeyCode.LeftShift))
            {
                Selectable previous = selectable.FindSelectableOnUp();
                if (previous != null)
                {
                    previous.Select();
                }
            }
            else if (Input.GetKeyDown(KeyCode.Tab))
            {
                Selectable next = selectable.FindSelectableOnDown();
                if (next != null)
                {
                    next.Select();
                }
            }
        }
    }
}

