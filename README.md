<h1 align="center">Fog Of War - Unity</h3>

<div align="center">

[![Status](https://img.shields.io/badge/status-active-success.svg)]()
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](/LICENSE)

</div>

---

## 📝 Table of Contents

- [Video](#video)
- [What is Fog Of War?](#whatisfogofwar)
- [How does it work?](#howdoesitwork)
- [Contact](#Contact)
- [Contributing](../CONTRIBUTING.md)

## About <a name = "about"></a>
I recently came up with a game idea in wihch fog of war will play a huge role, but was unable to find proper implementation. Therefore I tried to gather all information that i found and made n cheap example of it. you will be able to play along with my demo, learning what lays under the hood.

## 🎥 Video <a name = "video"></a>



https://github.com/xddemir/Unity-FogOfWar/assets/56155535/9fc68425-db2d-4a7d-80dc-2c2711277a2b





## What is Fog Of War? <a name = "whatisfogofwar"></a>
Fog of war is a term that refers to describe the uncertainty in situation awareness experienced for militars in military operations. However, in video games, the fog of war reffers to giving the player partial information of a certain area, which makes the player re-think the strategy of the gameplay taking in account the leaking information.

## How does this work? <a name = "howdoesitwork"></a>
`FogOfWar.cs` includes all mechanism to use fog in this particular project. It raycasts the obstacles and renders vertexes by the radiant angle which means each line that touches the obstacles does not go through therefore it creates triangular meshes. `StencilShader.shader` creates a layermask for actual scene and makes scene objects invisible. Once we play the scene objects with stencil are rendered properly. 


## ✍️ Contact <a name = "Contact"></a>

- [@xddemir](https://github.com/xddemir) - Github
- [@dogukan.demir991@gmail.com](dogukan.demir991@gmail.com) - Email


See also the list of [contributors](https://github.com/xddemir/Stardew-Valley-Coop/contributors) who participated in this project.

