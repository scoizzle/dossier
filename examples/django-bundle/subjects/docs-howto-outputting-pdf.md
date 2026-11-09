# docs/howto/outputting-pdf

- Subject: docs/howto/outputting-pdf (id `8999f878-f02e-4246-9bfe-20c401e1ead9`)
- Kind: subject
- Budget: 1200 tokens
- Used: 884 tokens
- Facts shown: 24 of 36
- Conflicts: 0
- Gaps: 0

## Facts

- # Close the PDF object cleanly, and we're done. p.showPage() p.save() [5ce8bcba]
- # Create the PDF object, using the buffer as its "file." p = canvas.Canvas(buffer) [a7c6fb8e]
- # Draw things on the PDF. Here's where the PDF generation happens. # See the ReportLab documentation for the full list of functionality. p.drawString(100, 100, "Hello world.") [8c1ae80c]
- # FileResponse sets the Content-Disposition header so that browsers # present the option to save the file. buffer.seek(0) return FileResponse(buffer, as_attachment=True, filename="hello.pdf") [c4ac28ac]
- $ python -m pip install reportlab [642caeb8]
- >>> import reportlab [5bc77802]
- Django Packages provides a `comparison of packages <https://djangopackages.org/grids/g/pdf/>`_ that help generate PDF files from Django. [bf382b4f]
- ReportLab is not thread-safe. Some of our users have reported odd issues with building PDF-generating Django views that are accessed by many people at the same time. [958e241f]
- def some_view(request): # Create a file-like buffer to receive PDF data. buffer = io.BytesIO() [f341f9a4]
- import io from django.http import FileResponse from reportlab.pdfgen import canvas [d2f14f51]
- * Finally, it's important to call ``showPage()`` and ``save()`` on the PDF file. [eb982e77]
- * Note that all subsequent PDF-generation methods are called on the PDF object (in this case, ``p``) -- not on ``buffer``. [5c4b6439]
- * The response will automatically set the MIME type :mimetype:`application/pdf` based on the filename extension. This tells browsers that the document is a PDF file, rather than an HTML file or a generic :mimetype:`application/octet-stream` binary content. [c48df777]
- * When ``as_attachment=True`` is passed to ``FileResponse``, it sets the appropriate ``Content-Disposition`` header and that tells web browsers to pop-up a dialog box prompting/confirming how to handle the document even if a default is set on the machine. If the ``as_attachment`` parameter is omitted, browsers will handle the PDF using whatever program/plugin they've been configured to use for PDFs. [25c1cfe2]
- * You can hook into the ReportLab API: The same buffer passed as the first argument to ``canvas.Canvas`` can be fed to the :class:`~django.http.FileResponse` class. [729c70fc]
- * You can provide an arbitrary ``filename`` parameter. It'll be used by browsers in the "Save as..." dialog. [8ceca3c6]
- .. _ReportLab: https://docs.reportlab.com/ .. _kusports.com: https://www2.kusports.com/ [666637d6]
- .. _user guide: https://www.reportlab.com/docs/reportlab-userguide.pdf [d01ca7c6]
- .. code-block:: pycon [eaf050be34acb41d-4]
- .. console:: [7714e199aac2701e-2]
- .. note:: [942ae6c11625c81c-9]
- .. seealso:: [6b4a5e54e001d097-8]
- ======================= How to create PDF files ======================= [2ec4cec2]
- Here's a "Hello World" example:: [530b18fc]

## Beyond the budget

12 more facts did not fit in the budget: [b3482119] [3728ac72] [a0187063] [d8421756] [b230f199] [741dae16] [6c52a4b3] [3e82c2e7] [4c495e5e27892286-2] [804a7590] [87a38389] [3b1d4e72]
