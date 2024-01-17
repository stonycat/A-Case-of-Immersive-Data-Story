# Design and Evaluation of an Interactive VR Data Story for Promoting the Situation Awareness of Public Health Threats
We implemented **a case of VR data story** with five design considerations:
1. (Providing) Alternative data representations, 
2. (Considering) Multiple perspectives for situational understanding,
3. (Offering) Embodied interactions for improving the sense of presence,
4. Combining audio and visual channels,
5. (Leveraging) Spatial cues for story exploration and awareness-raising.

The story aims to communicate health risk information to the public and raise people's situation awareness of the potential health threats in public environments.

This work is published in [the International Journal of Human-Computer Studies (IJHCS)](https://www.sciencedirect.com/journal/international-journal-of-human-computer-studies), Jan. 2024, titled [From Reader to Experiencer: Design and Evaluation of an Interactive VR Data Story for Promoting the Situation Awareness of Public Health Threats](https://www.sciencedirect.com/science/article/abs/pii/S1071581923001465).

(If you would like to) cite this paper (BibTex from Google Scholar): <br>
`\```@article{zhu2024reader,<br>
title={From reader to experiencer: Design and evaluation of a VR data story for promoting the situation awareness of public health threats},<br>
author={Zhu, Qian and Yuan, Linping and Xu, Zian and Yang, Leni and Xia, Meng and Wang, Zhuo and Liang, Hai-Ning and Ma, Xiaojuan},<br>
journal={International Journal of Human-Computer Studies},<br>
volume={181},<br>
pages={103137},<br>
year={2024},<br>
publisher={Elsevier}<br>
}`


## Functions in this case of VR Data Story:
1. Three kinds of immersive data representations of Covid-19 depiction (trajectory, particles, heatmap).
2. We offer three types of perspectives for users to experience: the 1st-person perspective, the 3rd-person perspective, and the perspective of the characters (i.e., the students and the teacher).
3. We implemented four kinds of embodied interactions in the VR data story, including VR wrist menu, interactive buttons within the environment, an interactive concentration indicator board that shows the level of COVID-19 based on users' locations, and two movement methods (continuous movement and VR teleportation).
4. We converted and refined the original textual content of the data story into spatial audio clips in VR to guide users to understand and explore the story.
5. We provided several useful spatial cues in the form of visual and textual elements in the immersive data story.

## Usage
The example scene can be found in the Assets/Scenes/ folder. The VR data story has been tested using a standalone VR headset, such as Oculus Quest 2 (with both controllers).

## Acknowledgements
This case of immersive data story was developed by the first authors and the co-authors (Linping Yuan and Zian Xu) of this paper.
We added logging functions within this Unity project to record users' behaviors data. Details are shown in the Assets/LogTool/ folder.





