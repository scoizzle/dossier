# docs/ref/urls

- Subject: docs/ref/urls (id `525db944-b4f2-4979-9b22-6c7d97f8ff9d`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2640 tokens
- Facts shown: 62 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- :arg module: URLconf module (or module name) :arg namespace: Instance namespace for the URL entries being included :type namespace: str :arg pattern_list: Iterable of :func:`~django.urls.path` and/or :func:`~django.urls.re_path` instances. :arg app_namespace: Application namespace for the URL entries being included :type app_namespace: str [c80b5c07]
- A function that takes a full Python import path to another URLconf module that should be "included" in this place. Optionally, the :term:`application namespace` and :term:`instance namespace` where the entries will be included into can also be specified. [92fa5f80]
- Usually, the application namespace should be specified by the included module. If an application namespace is set, the ``namespace`` argument can be used to set a different instance namespace. [cfaea91b]
- ``include()`` also accepts as an argument either an iterable that returns URL patterns or a 2-tuple containing such iterable plus the names of the application namespaces. [c58f0f29]
- from django.conf import settings from django.conf.urls.static import static [d990b2b04dc10582-3]
- from django.urls import include, path [4b5fb9f5]
- from django.urls import include, re_path [b84a03b2]
- urlpatterns = [ # ... the rest of your URLconf goes here ... ] + static(settings.MEDIA_URL, document_root=settings.MEDIA_ROOT) [28a320b8d4af4a29-2]
- urlpatterns = [ path("index/", views.index, name="main-view"), path("bio/<username>/", views.bio, name="bio"), path("articles/<slug:title>/", views.article, name="article-detail"), path("articles/<slug:title>/<int:section>/", views.section, name="article-section"), path("blog/", include("blog.urls")), ..., ] [b4637689]
- urlpatterns = [ re_path(r"^index/$", views.index, name="index"), re_path(r"^bio/(?P<username>\w+)/$", views.bio, name="bio"), re_path(r"^blog/", include("blog.urls")), ..., ] [6cec9254]
- .. currentmodule:: django.urls [33d1731627b8b1b3-2]
- .. data:: handler400 [b30dfee0]
- .. data:: handler403 [0de7dae8]
- .. data:: handler404 [51c40e3a]
- .. data:: handler500 [000be73a]
- .. function:: include(module, namespace=None) include(pattern_list) include((pattern_list, app_namespace), namespace=None) [7c4c7961]
- .. function:: path(route, view, kwargs=None, name=None) [115aff5c]
- .. function:: re_path(route, view, kwargs=None, name=None) [1a25af5f]
- .. function:: register_converter(converter, type_name) [48639793]
- .. function:: static.static(prefix, view=django.views.static.serve, **kwargs) [c7482ce2]
- .. module:: django.conf.urls [018b74fd]
- .. module:: django.urls.conf :synopsis: Functions for use in URLconfs. [0fae2d9f]
- ============================================= ``django.urls`` functions for use in URLconfs ============================================= [14064a59]
- A callable, or a string representing the full Python import path to the view that should be called if none of the URL patterns match. [dcb27038]

## All facts

- [fd856a79] ================================================== ``django.conf.urls`` functions for use in URLconfs ==================================================
- [de400deb] A callable, or a string representing the full Python import path to the view that should be called if the HTTP client has sent a request that caused an error condition and a response with a status code of 400.
- [e0866ef7] A callable, or a string representing the full Python import path to the view that should be called if the user doesn't have the permissions required to access a resource.
- [19293a52] A callable, or a string representing the full Python import path to the view that should be called in case of server errors. Server errors happen when you have runtime errors in view code.
- [e5c2444a] By default, this is :func:`django.views.defaults.bad_request`. If you implement a custom view, be sure it accepts ``request`` and ``exception`` arguments and returns an :class:`~django.http.HttpResponseBadRequest`.
- [3df3f143] By default, this is :func:`django.views.defaults.page_not_found`. If you implement a custom view, be sure it accepts ``request`` and ``exception`` arguments and returns an :class:`~django.http.HttpResponseNotFound`.
- [b5b04482] By default, this is :func:`django.views.defaults.permission_denied`. If you implement a custom view, be sure it accepts ``request`` and ``exception`` arguments and returns an :class:`~django.http.HttpResponseForbidden`.
- [38364b66] By default, this is :func:`django.views.defaults.server_error`. If you implement a custom view, be sure it accepts a ``request`` argument and returns an :class:`~django.http.HttpResponseServerError`.
- [7a7a57d1] Helper function to return a URL pattern for serving files in debug mode::
- [4ec12dc1] Naming your URL lets you refer to it unambiguously from elsewhere in Django, especially from within templates. This powerful feature allows you to make global changes to the URL patterns of your project while only touching a single file.
- [ebac5987] Patterns don't match GET and POST parameters, or the domain name. For example, in a request to ``https://www.example.com/myapp/``, the URLconf will look for ``myapp/``. In a request to ``https://www.example.com/myapp/?page=3``, the URLconf will also look for ``myapp/``.
- [1c99b26a35481bcd] Returns an element for inclusion in ``urlpatterns``. For example::
- [1c99b26a35481bcd-2] Returns an element for inclusion in ``urlpatterns``. For example::
- [e7b9077a] See :ref:`Naming URL patterns <naming-url-patterns>` for why the ``name`` argument is useful.
- [f6252bca] See :ref:`including-other-urlconfs` and :ref:`namespaces-and-include`.
- [ccc6a326] The ``converter`` argument is a converter class, and ``type_name`` is the converter name to use in path patterns. See :ref:`registering-custom-path-converters` for an example.
- [bb3a93d4] The ``kwargs`` argument allows you to pass additional arguments to the view function or method. See :ref:`views-extra-options` for an example.
- [6a30fadb] The ``route`` argument should be a string or :func:`~django.utils.translation.gettext_lazy` (see :ref:`translating-urlpatterns`) that contains a URL pattern. The string may contain angle brackets (like ``<username>`` above) to capture part of the URL and send it as a keyword argument to the view. The angle brackets may include a converter specification (like the ``int`` part of ``<int:section>``) which limits the characters matched and may also change the type of the variable passed to the view. For example, ``<int:section>`` matches a string of decimal digits and converts the value to an ``int``.
- [772b76ad] The ``route`` argument should be a string or :func:`~django.utils.translation.gettext_lazy` (see :ref:`translating-urlpatterns`) that contains a regular expression compatible with Python's :mod:`re` module. Strings typically use raw string syntax (``r''``) so that they can contain sequences like ``\d`` without the need to escape the backslash with another backslash. When a match is made, captured groups from the regular expression are passed to the view -- as named arguments if the groups are named, and as positional arguments otherwise. The values are passed as strings, without any type conversion.
- [3361cdab] The ``view`` argument is a view function or the result of :meth:`~django.views.generic.base.View.as_view` for class-based views. It can also be a :func:`django.urls.include`.
- [67838577] The ``view``, ``kwargs`` and ``name`` arguments are the same as for :func:`~django.urls.path`.
- [6838d09e] The function for registering a converter for use in :func:`~django.urls.path` ``route``\s.
- [63f744fb] When Django finds a matching pattern, it calls the specified view function with an :class:`~django.http.HttpRequest` object as the first argument and any "captured" values from the route as keyword arguments.
- [6c208a4d] When a ``route`` ends with ``$`` the whole requested URL, matching against :attr:`~django.http.HttpRequest.path_info`, must match the regular expression pattern (:func:`re.fullmatch` is used).
- [8421bb3d] When processing a request, Django starts at the first pattern in ``urlpatterns`` and makes its way down the list, comparing the requested URL against each pattern until it finds one that matches. See :ref:`how-django-processes-a-request` for more details.
- [2e336ca5] ``handler400`` ==============
- [4f6a7dd4] ``handler403`` ==============
- [b880776e] ``handler404`` ==============
- [f6197ffe] ``handler500`` ==============
- [ab6f7080] ``include()`` =============
- [e16b38f0] ``kwargs`` ----------
- [e9982e75ca22a002-4] ``name`` --------
- [2ecf5ded] ``path()`` ==========
- [e0e77fdb] ``re_path()`` =============
- [2d9c9986] ``register_converter()`` ========================
- [58c6d91e] ``route`` ---------
- [6a995a04] ``static()`` ============
- [3a11a8f2] ``view`` --------
