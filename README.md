# Bomberman-Replica
First videogame development project.

# Introduction
This is a replica of the "Super Bomberman" Game in SNES.

The idea is to place a bomb near a wall to destroy it and use the same bomb to defeat the second player.

# Demo
<p align="center">
  <img src="demo.gif">
</p>



# Controls

It is a Two-Player game.

- Player One Controls
              
| Key            | Description |
| -------------- | ----------- |
| UpArrowKey     | Move Up     |
| DownArrowKey   | Move Down   |
| LeftArrowKey   | Move Left   |
| RightArrowKey  | Move Right  |
| SpaceBar       | Place Bomb  |

  
- Player Two Controls

| Key            | Description |
| -------------- | ----------- |
| NumPad8        | Move Up     |
| NumPad5        | Move Down   |
| NumPad4        | Move Left   |
| NumPad6        | Move Right  |
| End Key        | Place Bomb  |

  <center>

| Player 1 Controls || Player 2 Controls |
|--|-|--|
|<table><tr><th>Key</th><th>Description</th></tr><tr align="center"><td>UpArrowKey</td><td>Move Up</td></tr><tr align="center"><td>DownArrowKey</td><td>Move Down</td></tr><tr align="center"><td>LeftArrowKey</td><td>Move Left</td></tr><tr align="center"><td>RightArrowKey</td><td>Move Right</td></tr><tr align="center"><td>SpaceBar</td><td>Place Bomb</td></tr> </table>|<span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>| <table> <tr><th>Key</th><th>Description</th></tr><tr align="center"><td>NumPad 8</td><td>Move Up</td></tr><tr align="center"><td>NumPad 5</td><td>Move Down</td></tr><tr align="center"><td>NumPad 4</td><td>Move Left</td></tr><tr align="center"><td>NumPad 6</td><td>Move Right</td></tr><tr align="center"><td>End Key</td><td>Place Bomb</td></tr> </table>|

  </center>

# Changing Controls
You can change the controls by making changes in the following files present in <i>/Assets/Scripts</i> directory.

- Player One
<pre>
○ Player One Movement | Player1.cs
○ Player One Bomb     | BombSpawner.cs
</pre>

- Player Two
<pre>
○ Player Two Movement | Player2Script.cs
○ Player Two Bomb     | Player2BombSpawner.cs
</pre>

