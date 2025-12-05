# Tag Utils
A simple GUI to edit a couple values in the game [Tag: The Power of Paint](https://store.steampowered.com/app/1808400/Tag_The_Power_of_Paint/)
***
## Currently supported
- Render Distance/Far-Clipping Plane
- Movement Keys (only for gameplay, not editor)
- Paint Can Select
- Paint Can Cheats (for Tag v1.1 only)
- Change the color of the level transition effect

Most keyboard keys are supported but some are missing. Check [TagUtility.cs](/TagUtility.cs) for all available keys and their string versions.

Keys are based on the QWERTY layout. For example, if you enter Z on a QWERTZ keyboard, the game will use Y instead, since that is where the Z key is on a QWERTY keyboard.
***
## Caveats
- Paint Can Select & Cheats do not accept mouse buttons due to technical limitations
- Render Distance should be kept within limits for better performance (infinity crashes the game)
- Gamepad is not supported, but other programs should easily map gamepad buttons to keyboard keys
- Keys with multiple positions (shift, ctrl, alt) can only be either left or right. It defaults to left, unless specified as "rshift" or "right shift" for example.