# Photometric Approach to Surface Reconstruction of Artist Paintings


Interactive renderer program for the surface reconstruction of oil paintings, using [Two-Shot SVBRDF Capture for Stationary Materials](https://mediatech.aalto.fi/publications/graphics/TwoShotSVBRDF/) by Aittala et al (2015).

## Supervisor

Selim Balcısoy

## Contributors

Begüm Çelik

Ece Alptekin

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
     - Tesellation Options->Tesellation Mode->Phong 
     - Tesellation Options->Tesellation Factor can be adjusted
     - Surface Inputs->Base Map->Metallic can be adjusted
     - Surface Inputs->Base Map->Smoothness Remapping can be adjusted
     - Surface Inputs->Base Map->Ambient Occlusion Remapping can be adjusted
     - Surface Inputs->Height Map->Parametrization->Amplitude can be adjusted
     
12. Set the position of the Plane, Spot Light, Main Camera and Canvas

## Output

<img width="1576" alt="Screenshot 2021-02-01 at 15 44 39" src="https://user-images.githubusercontent.com/48667985/106461092-5ac25a00-64a5-11eb-9ce1-e36dd2b17c4c.png">
<img width="1576" alt="Screenshot 2021-02-01 at 15 46 08" src="https://user-images.githubusercontent.com/48667985/106461134-69a90c80-64a5-11eb-88f2-8ac3337a3cde.png">
<img width="1576" alt="Screenshot 2021-02-01 at 15 46 40" src="https://user-images.githubusercontent.com/48667985/106461168-762d6500-64a5-11eb-9ca1-b43a382464ff.png">
<img width="1576" alt="Screenshot 2021-02-01 at 15 47 58" src="https://user-images.githubusercontent.com/48667985/106461193-7e85a000-64a5-11eb-9dac-a9d4d9607580.png">
<img width="1576" alt="Screenshot 2021-02-01 at 15 48 59" src="https://user-images.githubusercontent.com/48667985/106461215-86454480-64a5-11eb-8824-b66769f73819.png">
<img width="1576" alt="Screenshot 2021-02-01 at 15 49 24" src="https://user-images.githubusercontent.com/48667985/106461233-8ba28f00-64a5-11eb-87e1-25819312b535.png">

## References

Miika Aittala, Tim Weyrich, and Jaakko Lehtinen. 2015. Two-shot SVBRDF capture for stationary materials. <i>ACM Trans. Graph.</i> 34, 4, Article 110 (August 2015), 13 pages. DOI:https://doi.org/10.1145/2766967

# Yağlı Boya Resimlerin Fotometrik Yaklaşım ile Yüzey Rekonstrüksiyonu 

Yağlı boya tabloların yüzey rekonstrüksiyonu için interaktif render programı 
using [Two-Shot SVBRDF Capture for Stationary Materials](https://mediatech.aalto.fi/publications/graphics/TwoShotSVBRDF/) by Aittala et al (2015).

Yağlı boya kullanılarak üretilmiş sanat eserlerinde malzemenin kendi yapısının olanak sağladığı farklı uygulama biçimlerinin, sanat eserinin orijinal görünümünde nasıl etkili rol oynadığı birçok sanat eleştirmeni ve tarihçisi tarafından üzerine çalışılan bir konu olmuştur. Bu doğrultuda sanat eserlerinin orijinaline en uygun şekilde görüntülenebilmesi için, fotoğrafın ötesinde, yağlı boya eserlerin doku ve parlaklık gibi resmin algılanışında etkili olan diğer özellikleri de yansıtılarak gerçeğe uygun bir reprodüksiyon üretilmesi amaçlanmaktadır.

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


## İşleme

1. Yeni bir Unity projesi High Definition RP 7.3.1 versiyonunun şablonu kullanılarak oluşturulur

2. Sahneye resmin illüstrasyonu için 3D Object, Plane eklenir

3. Texture Map hazırlanır
     - ImageMagick kullanılarak Specular Map ve Diffusion Map PNG formatına çevirilir
     - ImageMagick kullanılarak Normal Map TIFF formatına çevirilir
     - Orjinal resim Base Map olarak kullanılır
     - Normal Map'in bir kopyası yaratılır ve siyah beyaz formata çevirilir
     - Görüntü düzenleyici ile kopyalanan haritanın görüntü tonları ayarlanır ve renkleri düzeltilir
     - Kopyalanan harita Height Map olarak kaydedilir
     
4. Spot Light eklenir ve MovingSLight.cs script olarak kullanılır

5. Canvas, Event System ve 5 Buton sahneye eklenir. Butonların isimleri
     - Up
     - Down
     - Left
     - Right
     - Quit
     
6. Butonların C# script'leri Assets klasöründedir. Her buton için ilgili script dosyası o butonun Inspector bölümüne eklenir. Bir butonun OnClick() bölümü şu şekilde ayarlanır:

<img width="450" alt="Screenshot 2021-02-01 at 13 30 09" src="https://user-images.githubusercontent.com/48667985/106446780-b71b7e80-6491-11eb-964a-11e169cd045c.png">

7. Spot Light klavye ile kontrol edilebilir. Klavye tercihleri Project Settings->Input Manager bölümünden ayarlanır

8. Butonlara basıldığında Plane butonun üzerinde yazan yöne doğru dönmektedir. Düzlemin Inspector bölümü butonların script'lerini ve materyali içermektedir

<img width="470" alt="Screenshot 2021-02-01 at 14 03 42" src="https://user-images.githubusercontent.com/48667985/106451321-732b7800-6497-11eb-95e2-90c156f5534f.png">

9. Bir HDRP/LitTesellation materyali yaratılır ve Texture Map'ler materyale uygulanır

10. Materyal Plane'e uygulanır

11. Materyal ayarlanır 
     - Surface Options->Displacement Mode->Tesellation Displacement
     - Tesellation Options->Tesellation Mode->Phong 
     - Tesellation Options->Tesellation Factor değiştirilebilir
     - Surface Inputs->Base Map->Metallic değiştirilebilir
     - Surface Inputs->Base Map->Smoothness Remapping değiştirilebilir
     - Surface Inputs->Base Map->Ambient Occlusion Remapping değiştirilebilir
     - Surface Inputs->Height Map->Parametrization->Amplitude değiştirilebilir
     
12. Plane, Spot Light, Main Camera and Canvas pozisyonları ayarlanır

## Referanslar

Miika Aittala, Tim Weyrich, and Jaakko Lehtinen. 2015. Two-shot SVBRDF capture for stationary materials. <i>ACM Trans. Graph.</i> 34, 4, Article 110 (August 2015), 13 pages. DOI:https://doi.org/10.1145/2766967
