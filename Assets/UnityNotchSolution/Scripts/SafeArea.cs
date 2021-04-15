using UnityEngine;

[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class SafeArea : MonoBehaviour
{
	private RectTransform _rectTransform;
	private Rect _lastSafeArea = new Rect(0, 0, 0, 0);
	
	private static readonly Vector2 UnitVector = Vector2.one;
	
	private void Awake()
	{
		_rectTransform = GetComponent<RectTransform>();
		Refresh();
	}
	
	#if UNITY_EDITOR
	private void Update()
	{
		Refresh();
	}
	#endif
	
	private void Refresh()
	{
		Rect safeArea = Screen.safeArea;

		if (safeArea != _lastSafeArea)
			ApplySafeArea(safeArea);
	}
	
	private void ApplySafeArea(Rect r)
	{
		if (!_rectTransform)
			_rectTransform = GetComponent<RectTransform>();
		
		_lastSafeArea = r;
		
		Vector2 anchorMin = r.position;
		Vector2 anchorMax = r.position + r.size;
		anchorMin.x /= Screen.width;
		anchorMin.y /= Screen.height;
		anchorMax.x /= Screen.width;
		anchorMax.y /= Screen.height;
		
		if (anchorMax.x > 1.0f || anchorMax.y > 1.0f)
			anchorMax = UnitVector;
		
		_rectTransform.anchorMin = anchorMin;
		_rectTransform.anchorMax = anchorMax;
	}
}