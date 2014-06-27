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

License
-------

You're free to use this application or code as you see fit. 

Contributing
------------

Pull requests are welcome! 