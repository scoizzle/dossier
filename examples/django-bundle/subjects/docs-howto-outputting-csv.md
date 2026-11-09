# docs/howto/outputting-csv

- Subject: docs/howto/outputting-csv (id `2b2f08e3-ae30-4ab6-9d7c-626cc21ba95e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 20 of 41
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

20 more facts did not fit in the budget: [b622cda7] [685d15dfb6eb2285-25] [4d87b590] [1534060a] [64de33af] [bb6f7064] [7901c2c5] [7adf12eb] [13eda258] [99f75db5] [950ee090] [4c495e5e27892286] [3f48cea5] [8248378a] [cdc0c043] [c180da35] [3158f67d] [9f04ad8b] [f69586a4] [f35c0ace]
