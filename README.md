Pdf Fieldname Stamper
===================

Winforms application that takes a PDF File and outputs a new PDF file with each field name as the field's value. Very useful when you need to know the field names in PDF forms.

Use case
--------

Sometimes you need to fill out PDF forms programatically. If you don't have an Adobe license, it might be tricky to get the names of the form fields. You can use something like 
pdftk to dump the field names, but what if the names are confusing? This app provides a compromise between both. 

The process is simple. We open the PDF file, scan for form fields, and in each form field's value we put the field name. Then we save the PDF to a new file. 
That way, when you view or print the new PDF you will see the field names right where the fields are. In some cases, the names might be too long for the fields, to
assist in that, we also generate a text file containing all the field names, the page each field appears in, and a number representing the vertical coordinate of the field.

Usage
-----

This application runs as a Windows application, but also has support for running it from the command-line. The command-line options available are input path and output path 
(in that order). I included a registry file to the repository to add a context menu item for all PDF files (just remember to modify the path before applying the changes). 
The file is appropriately named _AddPdfContextMenu.reg_.

Simple usage example: `pdffieldnamestamper.exe input.pdf output.pdf`

Please note that if the output name isn't given, then the program will use the input filename and append ".stamped" to the filename. For example: `pdffieldnamestamper.exe input.pdf` 
will generate a pdf file named _input.stamped.pdf_.

You may also notice that the program generates an additional text file. This file has a list of all the form fields that were present in the input pdf, the page it was located in, and 
the vertical coordinates of the field (higher numbers means it appears higher in a page). This can be useful sometimes to tell between fields that are too short to display the entire 
field name. Your mileage may vary on that one.

License
-------

This software is licensed under the AGPL. You can read the license terms [here](http://www.gnu.org/licenses/agpl-3.0.txt). The license is also included in the repository for 
convenience under the name _license.txt_.

Contributing
------------

Pull requests are welcome! 

Releases
--------

You can download the latest binary release from [here](https://dl.dropboxusercontent.com/u/2986131/extern/PdfFieldNameStamper_latest.zip).

Thanks
------

This app wouldn't be possible without the help of the awesome iTextSharp library, available at [http://itextpdf.com/](http://itextpdf.com/)
