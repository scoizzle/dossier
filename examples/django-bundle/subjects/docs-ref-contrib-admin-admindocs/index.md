# docs/ref/contrib/admin/admindocs

- Subject: docs/ref/contrib/admin/admindocs (id `de3e677b-dcb1-4254-9508-f4a29a19b263`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1684 tokens
- Facts shown: 40 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [9a45481f] Documentation helpers =====================
- [af630e54] Each URL in your site has a separate entry in the ``admindocs`` page, and clicking on a given URL will show you the corresponding view. Helpful things you can document in your view function docstrings include:
- [f80b896e] Each of these support custom link text with the format ``:role:`link text <link>```. For example, ``:tag:`block <built_in-block>```.
- [51c841ec] Included Bookmarklets =====================
- [9a3ef7e9] Model reference ===============
- [8bc02124] Once those steps are complete, you can start browsing the documentation by going to your admin interface and clicking the "Documentation" link in the upper right of the page.
- [90afb2e8] One bookmarklet is available from the ``admindocs`` page:
- [75696e16fcbb84ec-3] Overview ========
- [46ffe1a0] Template reference ==================
- [056f3804] Template tags and filters reference ===================================
- [4c442902] The **models** section of the ``admindocs`` page describes each model that the user has access to along with all the fields, properties, and methods available on it. Relationships to other models appear as hyperlinks. Descriptions are pulled from ``help_text`` attributes on fields or from docstrings on model methods.
- [213c2405] The **tags** and **filters** ``admindocs`` sections describe all the tags and filters that come with Django (in fact, the :ref:`built-in tag reference <ref-templates-builtins-tags>` and :ref:`built-in filter reference <ref-templates-builtins-filters>` documentation come directly from those pages). Any tags or filters that you create or are added by a third-party app will show up in these sections as well.
- [373ceefb] The following special markup can be used in your docstrings to easily create hyperlinks to other components:
- [ced258e6] To activate the :mod:`~django.contrib.admindocs`, you will need to do the following:
- [fa2aa9b5] Using this bookmarklet requires that ``XViewMiddleware`` is installed and that you are logged into the :mod:`Django admin <django.contrib.admin>` as a :class:`~django.contrib.auth.models.User` with :attr:`~django.contrib.auth.models.User.is_staff` set to ``True``.
- [bf576b9d] View reference ==============
- [1db8be9f] While ``admindocs`` does not include a place to document templates by themselves, if you use the ``:template:`path/to/template.html``` syntax in a docstring the resulting page will verify the path of that template with Django's :ref:`template loaders <template-loaders>`. This can be a handy way to check if the specified template exists and to show where on the filesystem that template is stored.
