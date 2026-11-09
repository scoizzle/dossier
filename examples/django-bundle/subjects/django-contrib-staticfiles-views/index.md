# django/contrib/staticfiles/views

- Subject: django/contrib/staticfiles/views (id `f493a13a-ff76-43a6-a6bf-e251473f589b`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 394 tokens
- Facts shown: 10 facts
- Conflicts: 0
- Gaps: 0

## Facts

- from django.contrib.staticfiles import views [f1cf21fb]
- path('<path:path>', views.serve) [fa796bfd]
- It uses the django.views.static.serve() view to serve the found files. """ if not settings.DEBUG and not insecure: raise Http404 normalized_path = posixpath.normpath(path).lstrip("/") absolute_path = finders.find(normalized_path) if not absolute_path: if path.endswith("/") or path == "": raise Http404("Directory indexes are not allowed here.") raise Http404("'%s' could not be found" % path) document_root, path = os.path.split(absolute_path) return static.serve(request, path, document_root=document_root, **kwargs) [6c98386e]
- To use, put a URL pattern such as:: [3933d99545244b8a]
- in your URLconf. [0dd851a3]
- """ [d346d78f8c109f45]
- """ Views and functions for serving static files. These are only to be used during development, and SHOULD NOT be used in a production setting. [ac77c407]
- def serve(request, path, insecure=False, **kwargs): """ Serve static files below a given point in the directory structure or from locations inferred from the staticfiles finders. [534f6ab0]
- from django.conf import settings from django.contrib.staticfiles import finders from django.http import Http404 from django.views import static [c2dc2c30]
- import os import posixpath [311ade86]
