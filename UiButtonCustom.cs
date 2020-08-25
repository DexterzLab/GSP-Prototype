using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public class UiButtonCustom : UiCustom
{

    //now we need to programme how this object is getting information from the scripatable object
    Image image;
    Button button;

    protected override void OnSkinUI()
    {
        base.OnSkinUI();

        //first get the components already attached to the object
        image = GetComponent<Image>();
        button = GetComponent<Button>();

        //next we programme how the button will behave by defualt, in this case we want it to do a sprite swap
        //we also ned to say where the sprite is being placed e.g button.targetgraphic
        button.transition = Selectable.Transition.SpriteSwap;
        button.targetGraphic = image;

        //now we actually have to use the information
        //first we say what default sprite is used for our image on the game object, in this case its just the buttonsprite set in the scriptable object
        image.sprite = skinData.buttonSprite;

        //then we will the button behaivour and say what images the behaivours(highlights, etc) will use, in this case its the buttonspritestate set in the scriptable object
        button.spriteState = skinData.buttonSpriteState;

    }


}
