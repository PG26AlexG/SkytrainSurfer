# SkytrainSurfer

## USAGE
Unity Version: 2023.2.2

### SkytrainSurfer
This is a class project that I took apart in where I did the Gameplay programming, VFX, and post processing

![RunSHorter](https://github.com/user-attachments/assets/426e54dc-bb16-46ff-a400-2d658aae2fc6)


### Movement
When writing the movement code the decision to keep the player stationary was made to allow the world generation and the curve of the world code simpler.
I took control over the specifics on how the character moves so that the jump and the swipe movements while not physically accurate feel good.

#### Challenges
When dealing with the state transitions when doing two states in quick sucuession it took some time to dial in those transitions to avoid them appearing broken or janky.
I resolved it by taking account of the player's vertical position and applying it as an offset, as well as taking the player's active lane into account with the other calcuations.
This avoided any weird hops or freezes in the character's movement.

![swiggleShort](https://github.com/user-attachments/assets/433f8935-b240-4145-b860-34d1da46cb74)


## VFX
I added in VFX to provide more feedback to the user

I added in a smoke effect which was the most difficult effect out of the 3.
First I created a shader that renders spheres that moved up in a way that felt like dust and altered the color to look dustier.
Afterwards I took a dust clipmask to apply to a shader that reduces it's transparency in areas to give it that dusty feel. The masks add onto eachother to produce that thicker effect.

After doing the smoke VFX I added in the trail effect. The actual appearance was built into unity, all I did was adjust it's behaviour to be more wavy as opposed to being so rigid.
The glowing was achieved with post processing, specifically bloom to give it a more mystical feel.

The final VFX I added was the coin collection VFX. It, like the trail is a default unity VFX that I make small alterations to. The most notable one here was altering it's color to give it that vibrant apparence of achievement.

#### Challenges
With the smoke VFX the challenge I found was adding the shader onto the VFX due to a lack of documentation. After a little bit of research on the open web I definately found a way to add the shader onto the VFX which gave me n effect that I was pretty happy with.

![SlideShorter](https://github.com/user-attachments/assets/94805473-d189-45d9-af6b-08d326347718)
