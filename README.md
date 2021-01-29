# Photometric Approach to Surface Reconstruction of Artist Paintings


Interactive renderer program for the surface reconstruction of oil paintings, using [Two-Shot SVBRDF Capture for Stationary Materials](https://mediatech.aalto.fi/publications/graphics/TwoShotSVBRDF/) by Aittala et al (2015).



## Get Started

1. Two photographs of the oilpainting should be taken without changing the camera position, preferably using stable tripod. Any smart phone camera would work, if the shots are succesful in terms of resolution and consistency.
     - First photo should be taken under constant illumination conditions, but distinct highlight and shadows should be avoided in this guide photo. 
     - Second photo should be taken using flash light, and the circular highligt due to the flash lighting should be close to the image center.

2. Place the input photos in a single directory file, and named them as 
     - guide.png or guide.jpg or guide.tiff 
     - flash.png or flash.jpg or flash.tiff
     
3.  The directory file which consists images should be encapsulated by another file. To clarify, let's call this file _data_ . Inside of the _data_ file there should be the main directory. (e.g. data/painting)

4. After downloading source code of Two-Shot svBRDF capture model, open the source code in MATLAB (only MATLAB source code, not the renderer) by adding the paths of source code file. 

5. In the main code file called SOLVE_ALL, replace the data_path with path of your _data_ file. Then, add your directory file name to the dataset list called files. (e.g. painting) 

6. Required add-ons for the succesful execution of the model in MATLAB are listed below.
     - Parallel Computing Toolbox
     - Image Processing Toolbox
     - Simulink
     - Global Optimization Toolbox
     - Symbolic Math Toolbox

7. Before running the model in MATLAB, field of view (FOV) value of the device used for photography and resolution of the photos should be updated in tex_alternate.m file. 









## References

Miika Aittala, Tim Weyrich, and Jaakko Lehtinen. 2015. Two-shot SVBRDF capture for stationary materials. <i>ACM Trans. Graph.</i> 34, 4, Article 110 (August 2015), 13 pages. DOI:https://doi.org/10.1145/2766967
