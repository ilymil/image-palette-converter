# image-palette-converter
A Windows Forms tool to convert images to specified color palettes.
## Instructions
To use the latest version of the converter, download and extract the `build.zip` file and run the `MapConverter.exe` application.
### Image Converter
To import an image into the converter, select "Load Image". Supported image file types are PNG, JPG, GIF, BMP, and TIF.

Two options are available for image conversion. "Convert RGB" converts the colors in the image to the closest color in the palette in sRGB space. "Convert OKlab" converts colors in OKlab space. OKlab is a perceptually uniform color space, so this conversion will generally yeild better better results than RGB. However, OKlab conversion is slower, and is best used for smaller images and palettes. For more information on OKlab, see [this article](https://bottosson.github.io/posts/oklab/) by Björn Ottosson.

Specific colors in your palette can be toggled in runtime by checking and unchecking the boxes on the palette list and reselecting a conversion method. 
### Palette Editor
A more in-depth palette creator can be accessed by selecting "Edit Palette". Here, colors can be added by selecting "Add Color", and removed by selecting the minus symbol next to each color. The text field next to each color determines the name of the associated color in the image converter. Each color can be changed by selecting the colored button. 

**Custom palettes are not saved when the application closes**. To save palettes, select the "Save Palette" button. This will save the palette as a PLT file, which can be loaded using "Load Palette".

This project was originally intended to convert images to the color palette used by Minecraft map items, and as such the current build comes with a file for the 1.19.2 map color palette.
