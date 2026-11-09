# docs/howto/outputting-csv

- Subject: docs/howto/outputting-csv (id `3ca89a04-5e14-47ec-b161-53bde70076e7`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1834 tokens
- Facts shown: 40 of 41
- Conflicts: 0
- Gaps: 0

## Highlights

- # The data is hardcoded here, but you could load it from a database or # some other source. csv_data = ( ("First row", "Foo", "Bar", "Baz"), ("Second row", "A", "B", "C", '"Testing"', "Here's a quote"), ) [42a825bf]
- def stream_batched_rows(): for batch in batched(rows, 100): yield "".join(writer.writerow(row) for row in batch) [94d2f2bb]
- def write(self, value): """Write the value by returning it, instead of storing in a buffer.""" return value [80514feb]
- return StreamingHttpResponse( stream_batched_rows(), content_type="text/csv", headers={"Content-Disposition": 'attachment; filename="somefilename.csv"'}, ) [04195ecf]
- return response [ade4d16f]
- t = loader.get_template("my_template_name.txt") c = {"data": csv_data} response.write(t.render(c)) return response [e1a89585]
- writer = csv.writer(response) writer.writerow(["First row", "Foo", "Bar", "Baz"]) writer.writerow(["Second row", "A", "B", "C", '"Testing"', "Here's a quote"]) [02817a2e]
- class Echo: """An object that implements just the write method of the file-like interface. """ [001af536]
- def some_streaming_csv_view(request): """A view that streams a large CSV file.""" # Generate a sequence of rows. The range is based on the maximum number of # rows that can be handled by a single sheet in most spreadsheet # applications. rows = (["Row {}".format(idx), str(idx)] for idx in range(65536)) pseudo_buffer = Echo() writer = csv.writer(pseudo_buffer) [6ffc90bb]
- def some_view(request): # Create the HttpResponse object with the appropriate CSV header. response = HttpResponse( content_type="text/csv", headers={"Content-Disposition": 'attachment; filename="somefilename.csv"'}, ) [1ea80e1ba45967d3]
- from django.http import HttpResponse from django.template import loader [c5bda1b341cf97d4]
- from django.http import StreamingHttpResponse [94f974eb]
- import csv from django.http import HttpResponse [f11bbfa0]
- import csv from itertools import batched [760b5fa3]
- {% for row in data %}"{{ row.0|addslashes }}", "{{ row.1|addslashes }}", "{{ row.2|addslashes }}", "{{ row.3|addslashes }}", "{{ row.4|addslashes }}" {% endfor %} [4be9bd12]
- * For each row in your CSV file, call ``writer.writerow``, passing it an :term:`iterable`. [1f846b3d]
- * The CSV module takes care of quoting for you, so you don't have to worry about escaping strings with quotes or commas in them. Pass ``writerow()`` your raw strings, and it'll do the right thing. [ba67d647]
- * The response gets a special MIME type, :mimetype:`text/csv`. This tells browsers that the document is a CSV file, rather than an HTML file. If you leave this off, browsers will probably interpret the output as HTML, which will result in ugly, scary gobbledygook in the browser window. [9c652435]
- * The response gets an additional ``Content-Disposition`` header, which contains the name of the CSV file. This filename is arbitrary; call it whatever you want. It'll be used by browsers in the "Save as..." dialog, etc. [b576e668]
- .. _streaming-csv-files: [0e730dc1]

## All facts

- [b622cda7] * You can hook into the CSV-generation API by passing ``response`` as the first argument to ``csv.writer``. The ``csv.writer`` function expects a file-like object, and :class:`~django.http.HttpResponse` objects fit the bill.
- [685d15dfb6eb2285-25] .. code-block:: html+django
- [4d87b590] ======================== How to create CSV output ========================
- [1534060a] Alternatively, you can use the :doc:`Django template system </topics/templates>` to generate CSV. This is lower-level than using the convenient Python :mod:`csv` module, but the solution is presented here for completeness.
- [64de33af] Here's an example, which generates the same CSV file as above::
- [bb6f7064] Here's an example::
- [7901c2c5] In this example, we make full use of Python generators to efficiently handle the assembly and transmission of a large CSV file. Rows are batched together to reduce HTTP overhead and improve compression efficiency when used with :class:`~django.middleware.gzip.GZipMiddleware`::
- [7adf12eb] Notice that there isn't very much specific to CSV here -- just the specific output format. You can use either of these techniques to output any text-based format you can dream of. You can also use a similar technique to generate arbitrary binary data; see :doc:`/howto/outputting-pdf` for an example.
- [13eda258] Other text-based formats ========================
- [99f75db5] Python comes with a CSV library, :mod:`csv`. The key to using it with Django is that the :mod:`csv` module's CSV-creation capability acts on file-like objects, and Django's :class:`~django.http.HttpResponse` objects are file-like objects.
- [950ee090] Streaming large CSV files -------------------------
- [4c495e5e27892286] The code and comments should be self-explanatory, but a few things deserve a mention:
- [3f48cea5] The idea here is to pass a list of items to your template, and have the template output the commas in a :ttag:`for` loop.
- [8248378a] The only difference between this example and the previous example is that this one uses template loading instead of the CSV module. The rest of the code -- such as the ``content_type='text/csv'`` -- is the same.
- [cdc0c043] Then, create the template ``my_template_name.txt``, with this template code:
- [c180da35] This document explains how to output CSV (Comma Separated Values) dynamically using Django views. To do this, you can either use the Python CSV library or the Django template system.
- [3158f67d] This short template iterates over the given data and displays a line of CSV for each row. It uses the :tfilter:`addslashes` template filter to ensure there aren't any problems with quotes.
- [9f04ad8b] Using the Python CSV library ============================
- [f69586a4] Using the template system =========================
- [f35c0ace] When dealing with views that generate very large responses, you might want to consider using Django's :class:`~django.http.StreamingHttpResponse` instead. For example, by streaming a file that takes a long time to generate you can avoid a load balancer dropping a connection that might have otherwise timed out while the server was generating the response.
