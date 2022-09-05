using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehaviour : MonoBehaviour
{
    private SpriteRenderer renderObj;

    private void Awake()
    {
        renderObj = GetComponent<SpriteRenderer>();
    }
    
    
    
    public void ChangeRendererColor(ColorID obj)
    {
        renderObj.color = obj.value;
    }

    public void ChangeRendererColor(ColorIDDataList obj)
    {
        renderObj.color = obj.currentColor.value;
    }
}
