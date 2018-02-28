

using UnityEngine;

public class SetSize : MonoBehaviour {


    public static void Set_Size(GameObject gameObject, float width, float height) {
        if (gameObject != null) {
            var rectTransform = gameObject.GetComponent<RectTransform>();
            if (rectTransform != null) {
                rectTransform.sizeDelta = new Vector2(width, height);
            }
        }
    }


    public static void Set_Height(Component component, float height) {
        if (component != null) {
            Set_Height(component.gameObject, height);
        }
    }
    public static void Set_Height(GameObject gameObject, float height) {
        if (gameObject != null) {
            var rectTransform = gameObject.GetComponent<RectTransform>();
            if (rectTransform != null) {
                rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, height);
            }
        }
    }


    public static void Set_Width(Component component, float width) {
        if (component != null) {
            Set_Width(component.gameObject, width);
        }
    }
    public static void Set_Width(GameObject gameObject, float width) {
        if (gameObject != null) {
            var rectTransform = gameObject.GetComponent<RectTransform>();
            if (rectTransform != null) {
                rectTransform.sizeDelta = new Vector2(width, rectTransform.sizeDelta.y);
            }
        }
    }
}