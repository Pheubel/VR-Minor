---
markdown:
  path: ReadMe.md

export_on_save:
  markdown: true
---

## XR Development

### Sprint 3

#### Learning Goals

#### Process

We wanted to expand the decor of the training area, one of which ways was to add posters to the area. To stay within the futuristic theme, I decided to make a hologram shader. To start I watched Brackey's tutorial on how to create a holographic in Unity using shader graphs ([HOLOGRAM using Unity Shader Graph](https://www.youtube.com/watch?v=KGGB5LFEejg)).

@import "./DocAssets/ShaderGraphCompleet.png"
After I had lines and emmission working after the tutorial i decided i wanted to add some grain to add to the holographic look. For this I experimented around with noise generation nodes and settled on using gradient noise as it's pattern works well for simulating the dithering pattern. I made the noise pattern change by changing the UV offset with the time passed.

@import "./DocAssets/ShaderGraphExtra.png"

Inside our enviroment we used it to display the safety measures.

@import "./DocAssets/hologramPoster.gif"

TODO: Timeline?

[How to use Unity3D Timeline in 10 minutes](https://www.youtube.com/watch?v=E5EYO3w-Xco)



[How to make a custom signal receiver with emitter parameter](https://gametorrahod.com/how-to-make-a-custom-signal-receiver-with-emitter-parameter/)

TODO: hoe te gebruiken

TODO: eigen audio implementatie met scripts

[What you NEED to know about game audio as a beginner in 2021! Unity3d](https://www.youtube.com/watch?v=B9yxkJuHLek)

TODO: problemen er mee

TODO: FMOD?

TODO: conclusie