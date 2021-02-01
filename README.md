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


## Output

<img width="1678" alt="Screenshot 2021-01-24 at 15 49 02" src="https://user-images.githubusercontent.com/48667985/106440509-fe057600-6489-11eb-9aa8-1c75bc83cab8.png">

<img width="1678" alt="Screenshot 2021-01-24 at 15 50 26" src="https://user-images.githubusercontent.com/48667985/106440817-50469700-648a-11eb-92b8-ed933e96be2a.png">

<img width="1678" alt="Screenshot 2021-01-24 at 15 52 15" src="https://user-images.githubusercontent.com/48667985/106440908-72401980-648a-11eb-8952-e46381c3be17.png">

<img width="1678" alt="Screenshot 2021-01-24 at 15 58 58" src="https://user-images.githubusercontent.com/48667985/106441019-96035f80-648a-11eb-8a9e-089b89f23869.png">


## Rendering

1. Create a new project with Unity using High Definition RP 7.3.1 version template

2. Add a 3D Object, Plane to the scene to illustrate the painting

3. Prepare the texture maps
     - Convert Specular Map and Diffusion Map into PNG using ImageMagick
     - Convert Normal Map into TIFF using ImageMagick
     - Use the input as the Base Map 
     - Make a copy of the Normal Map and convert it to a black and white image
     - Adjusting image tones and correcting colors of the copied map with the image editor
     - Save the copied map as the Height Map
     
4. Add a Spot Light, which has the script MovingSLight.cs 

5. Add a Canvas, an Event System and 5 Buttons. Names of the Buttons are
     - Up
     - Down
     - Left
     - Right
     - Quit
     
6. The C# scripts of the buttons are in the Assets folder. For each button add the corresponding script to the Inspector of that button. Set OnClick() of a button as follows:

<img width="450" alt="Screenshot 2021-02-01 at 13 30 09" src="https://user-images.githubusercontent.com/48667985/106446780-b71b7e80-6491-11eb-964a-11e169cd045c.png">

7. The Spot Light is controllable by the keyboard. The keyboard preferences have to be set in Project Settings->Input Manager

8. The Plane rotates according to the directions written on the buttons when the buttons are pressed. The Inspector of the Plane contains scripts of the Buttons and the Material 

<img width="470" alt="Screenshot 2021-02-01 at 14 03 42" src="https://user-images.githubusercontent.com/48667985/106451321-732b7800-6497-11eb-95e2-90c156f5534f.png">

9. Create a HDRP/LitTesellation Material and apply texture maps to the Material

10. Apply the Material to the Plane

11. Set the Material 
     - Surface Options->Displacement Mode->Tesellation Displacement
     - Tesellation Options->Tesellation Factor can be adjusted
     - Surface Inputs->Base Map->Metallic can be adjusted
     - Surface Inputs->Base Map->Smoothness Remapping can be adjusted
     - Surface Inputs->Base Map->Ambient Occlusion Remapping can be adjusted
     - Surface Inputs->Height Map->Parametrization->Amplitude can be adjusted
     
12. Set the position of the Plane, Spot Light, Main Camera and Canvas

## References

Miika Aittala, Tim Weyrich, and Jaakko Lehtinen. 2015. Two-shot SVBRDF capture for stationary materials. <i>ACM Trans. Graph.</i> 34, 4, Article 110 (August 2015), 13 pages. DOI:https://doi.org/10.1145/2766967





# Türkçe

# Sanatçı Resimlerinin Yüzey Rekonstrüksiyonuna Fotometrik Yaklaşım


Interactive renderer program for the surface reconstruction of oil paintings, using [Two-Shot SVBRDF Capture for Stationary Materials](https://mediatech.aalto.fi/publications/graphics/TwoShotSVBRDF/) by Aittala et al (2015).



## Başlangıç

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


## Çıktı

<img width="1678" alt="Screenshot 2021-01-24 at 15 49 02" src="https://user-images.githubusercontent.com/48667985/106440509-fe057600-6489-11eb-9aa8-1c75bc83cab8.png">

<img width="1678" alt="Screenshot 2021-01-24 at 15 50 26" src="https://user-images.githubusercontent.com/48667985/106440817-50469700-648a-11eb-92b8-ed933e96be2a.png">

<img width="1678" alt="Screenshot 2021-01-24 at 15 52 15" src="https://user-images.githubusercontent.com/48667985/106440908-72401980-648a-11eb-8952-e46381c3be17.png">

<img width="1678" alt="Screenshot 2021-01-24 at 15 58 58" src="https://user-images.githubusercontent.com/48667985/106441019-96035f80-648a-11eb-8a9e-089b89f23869.png">


## İşleme

1. Yeni bir Unity projesi High Definition RP 7.3.1 versiyon şablonu kullanılarak oluşturulur

2. Sahneye resmin illüstrasyonu için 3D Object, Plane eklenir

3. Texture Map hazırlanır
     - Convert Specular Map and Diffusion Map into PNG using ImageMagick
     - Convert Normal Map into TIFF using ImageMagick
     - Use the input as the Base Map 
     - Make a copy of the Normal Map and convert it to a black and white image
     - Adjusting image tones and correcting colors of the copied map with the image editor
     - Save the copied map as the Height Map
     
4. Spot Light eklenir, which has the script MovingSLight.cs 

5. Canvas, Event System ve 5 Button sahneye eklenir. Button isimleri şu şekildedir
     - Up
     - Down
     - Left
     - Right
     - Quit
     
6. The C# scripts of the buttons are in the Assets folder. For each button add the corresponding script to the Inspector of that button. Set OnClick() of a button as follows:

<img width="450" alt="Screenshot 2021-02-01 at 13 30 09" src="https://user-images.githubusercontent.com/48667985/106446780-b71b7e80-6491-11eb-964a-11e169cd045c.png">

7. The Spot Light is controllable by the keyboard. The keyboard preferences have to be set in Project Settings->Input Manager

8. The Plane rotates according to the directions written on the buttons when the buttons are pressed. The Inspector of the Plane contains scripts of the Buttons and the Material 

<img width="470" alt="Screenshot 2021-02-01 at 14 03 42" src="https://user-images.githubusercontent.com/48667985/106451321-732b7800-6497-11eb-95e2-90c156f5534f.png">

9. Create a HDRP/LitTesellation Material and apply texture maps to the Material

10. Apply the Material to the Plane

11. Set the Material 
     - Surface Options->Displacement Mode->Tesellation Displacement
     - Tesellation Options->Tesellation Factor can be adjusted
     - Surface Inputs->Base Map->Metallic can be adjusted
     - Surface Inputs->Base Map->Smoothness Remapping can be adjusted
     - Surface Inputs->Base Map->Ambient Occlusion Remapping can be adjusted
     - Surface Inputs->Height Map->Parametrization->Amplitude can be adjusted
     
12. Set the position of the Plane, Spot Light, Main Camera and Canvas

## Referanslar

Miika Aittala, Tim Weyrich, and Jaakko Lehtinen. 2015. Two-shot SVBRDF capture for stationary materials. <i>ACM Trans. Graph.</i> 34, 4, Article 110 (August 2015), 13 pages. DOI:https://doi.org/10.1145/2766967
