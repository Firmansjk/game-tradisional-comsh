using UnityEngine;
using UnityEngine.UI;

public class AvatarImageLoader : MonoBehaviour
{
    public Image playerOneAvatarImage;
    public Image playerTwoAvatarImage;

    private void Start()
    {
        // Load avatars for Player One and Player Two based on PlayerPrefs.
        LoadAvatarImage("PlayerOneAvatar", playerOneAvatarImage);
        LoadAvatarImage("PlayerTwoAvatar", playerTwoAvatarImage);
    }

    private void LoadAvatarImage(string avatarNameKey, Image avatarImage)
    {
        // Retrieve the avatar name from PlayerPrefs.
        string avatarName = PlayerPrefs.GetString(avatarNameKey);

        Debug.Log("Loading avatar: " + avatarName);

        if (!string.IsNullOrEmpty(avatarName))
        {
            // Load the avatar image sprite from the "Assets/Sprites/Avatar" folder.
            Sprite avatarSprite = Resources.Load<Sprite>("Avatar/" + avatarName);

            if (avatarSprite != null)
            {
                // Assign the loaded sprite to the Image component.
                avatarImage.sprite = avatarSprite;
            }
            else
            {
                // Handle the case when the avatar image is not found.
                Debug.LogWarning("Avatar image not found: " + avatarName);
            }
        }
        else
        {
            // Handle the case when the avatar name is not saved in PlayerPrefs.
            Debug.LogWarning("Avatar name not found in PlayerPrefs.");
        }
    }

}
