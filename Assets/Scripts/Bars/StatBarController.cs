using UnityEngine;

public abstract class StatBarController : MonoBehaviour
{
    [SerializeField] protected GameObject barObject;
    [SerializeField] protected float maxValue = 100f;
    [SerializeField] protected float currentValue;

    protected virtual void Start()
    {
        currentValue = maxValue;
        UpdateBar();
    }

    protected virtual void Update()
    {
        UpdateBar();
    }

    protected virtual void UpdateBar()
    {
        currentValue = Mathf.Clamp(currentValue, 0f, maxValue);
        float normalizedValue = currentValue / maxValue;
        barObject.transform.localScale = new Vector3(normalizedValue, 1f, 0f);
    }

    public virtual void ModifyValue(float amount)
    {
        currentValue += amount;
    }

    public virtual void SetValue(float value)
    {
        currentValue = value;
    }

    public float GetValue()
    {
        return currentValue;
    }

    public float GetMaxValue()
    {
        return maxValue;
    }
}
