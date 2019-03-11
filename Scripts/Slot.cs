using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems; 
public class Slot : MonoBehaviour,IPointerClickHandler {

	public Stack<Item> items;
	public Stack<Item> Items{
		get { return items; }
		set { items = value; }
	}
	public Text stackTxt;
	public Sprite slotEmpty;
	public Sprite slotHighlight;
	public bool IsEmpty
	{
		get {return items.Count==0;}
	}
	public bool IsAvailable{
		get{ return CurrentItem.maxSize > items.Count; }
	}
	public Item CurrentItem{
		get {return items.Peek (); }
	}
	void Start () {
		items = new Stack<Item> ();
		RectTransform slotRect = GetComponent<RectTransform> ();
		RectTransform txtRect = stackTxt.GetComponent<RectTransform> ();
		int txtScaleFactor = (int)(slotRect.sizeDelta.x * 0.60);
		stackTxt.resizeTextMaxSize = txtScaleFactor;
		stackTxt.resizeTextMinSize = txtScaleFactor;
		txtRect.SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, slotRect.sizeDelta.x);
		txtRect.SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, slotRect.sizeDelta.y);
	}
	// Update is called once per frame
	void Update () {
	
	}
	public void AddItem (Item item){
		items.Push (item);
		if (items.Count > 1)
			stackTxt.text = items.Count.ToString ();
		ChangeSprite (item.spriteNeutral, item.spriteHighlighted);
	}
	public void AddItems( Stack<Item> items){
		this.items = new Stack<Item> (items);
		stackTxt.text = items.Count > 1 ? items.Count.ToString () : string.Empty;
		ChangeSprite (CurrentItem.spriteNeutral, CurrentItem.spriteHighlighted);
	}
	private void ChangeSprite(Sprite neutral, Sprite higlight){
		GetComponent<Image> ().sprite = neutral;
		SpriteState st = new SpriteState ();
		st.highlightedSprite = higlight;
		st.pressedSprite = neutral;
		GetComponent<Button> ().spriteState = st;
	}
	private void UseItem(){
         if (!IsEmpty){
			items.Pop ().Use ();
			stackTxt.text = items.Count > 1 ? items.Count.ToString () : string.Empty;
			if (IsEmpty) {
				ChangeSprite (slotEmpty, slotHighlight);
				Inventory.EmptySlots++;
			}
				
		}
	}
	public void ClearSlot(){
		items.Clear ();
		ChangeSprite (slotEmpty, slotHighlight);
		stackTxt.text = string.Empty;
	}
	public void OnPointerClick(PointerEventData eventData){
        if (eventData.button == PointerEventData.InputButton.Right)
			UseItem ();
	}
}
