# docs/ref/contrib/admin/admindocs

- Subject: docs/ref/contrib/admin/admindocs (id `5a08523f-97cb-4bc4-af96-e01b06725d7e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 23 of 40
- Conflicts: 0
- Gaps: 0

## Facts

- **Context** [ac0dd05fa9a91c22-9]
- **Template:** [5c191242]
- :template:`myapp/my_template.html` """ context = {"mymodel": MyModel.objects.get(slug=slug)} return render(request, "myapp/my_template.html", context) [8347d118]
- ``mymodel`` An instance of :model:`myapp.MyModel`. [d9f0c25a]
- def publish(self): """Makes the blog entry live on the site.""" ... [878a4f96]
- slug = models.SlugField(help_text="A short label, generally used in URLs.") author = models.ForeignKey( User, models.SET_NULL, blank=True, null=True, ) blog = models.ForeignKey(Blog, models.CASCADE) ... [f0e66afd]
- class BlogEntry(models.Model): """ Stores a single blog entry, related to :model:`blog.Blog` and :model:`auth.User`. """ [3117b2a2]
- def my_view(request, slug): """ Display an individual :model:`myapp.MyModel`. [fb1d4b05]
- from django.shortcuts import render [f3bb80f2b2fd7f5d-4]
- from myapp.models import MyModel [fd86f88a]
- * A short description of what the view does. * The **context**, or a list of variables available in the view's template. * The name of the template or templates that are used for that view. [a2b8b08f]
- * Add :mod:`django.contrib.admindocs` to your :setting:`INSTALLED_APPS`. * Add ``path('admin/doc/', include('django.contrib.admindocs.urls'))`` to your ``urlpatterns``. Make sure it's included *before* the ``'admin/'`` entry, so that requests to ``/admin/doc/`` don't get handled by the latter entry. * Install the :pypi:`docutils` 0.22+ package. * **Optional:** Using the admindocs bookmarklets requires ``django.contrib.admindocs.middleware.XViewMiddleware`` to be installed. [30c7e1ee]
- .. _admindocs-bookmarklets: [205b76e8]
- .. _admindocs-helpers: [26d4013f]
- .. _admindocs-model-reference: [4fa2bc54]
- .. currentmodule:: django.contrib.admindocs [0c4ddd0b]
- .. module:: django.contrib.admindocs :synopsis: Django's admin documentation generator. [4e291189]
- ================= ======================= Django Component reStructuredText roles ================= ======================= Models ``:model:`app_label.ModelName``` Views ``:view:`app_label.view_name``` Template tags ``:tag:`tagname``` Template filters ``:filter:`filtername``` Templates ``:template:`path/to/template.html``` ================= ======================= [98df6591]
- ======================================== The Django admin documentation generator ======================================== [10debf20]
- A model with useful documentation might look like this:: [3a37e66e]
- Django's :mod:`~django.contrib.admindocs` app pulls documentation from the docstrings of models, views, template tags, and template filters for any app in :setting:`INSTALLED_APPS` and makes that documentation available from the :mod:`Django admin <django.contrib.admin>`. [5bc2b122]
- Documentation for this page Jumps you from any page to the documentation for the view that generates that page. [f9d4f919]
- For example:: [28edef836ab93f57-6]

## Beyond the budget

17 more facts did not fit in the budget: [9a45481f] [af630e54] [f80b896e] [51c841ec] [9a3ef7e9] [8bc02124] [90afb2e8] [75696e16fcbb84ec-3] [46ffe1a0] [056f3804] [4c442902] [213c2405] [373ceefb] [ced258e6] [fa2aa9b5] [bf576b9d] [1db8be9f]
