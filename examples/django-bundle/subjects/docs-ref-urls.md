# docs/ref/urls

- Subject: docs/ref/urls (id `9c221514-9822-40b9-a5c6-7bcfe8b0ba8e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 24 of 62
- Conflicts: 0
- Gaps: 0

## Facts

- :arg module: URLconf module (or module name) :arg namespace: Instance namespace for the URL entries being included :type namespace: str :arg pattern_list: Iterable of :func:`~django.urls.path` and/or :func:`~django.urls.re_path` instances. :arg app_namespace: Application namespace for the URL entries being included :type app_namespace: str [c80b5c07]
- A function that takes a full Python import path to another URLconf module that should be "included" in this place. Optionally, the :term:`application namespace` and :term:`instance namespace` where the entries will be included into can also be specified. [92fa5f80]
- Usually, the application namespace should be specified by the included module. If an application namespace is set, the ``namespace`` argument can be used to set a different instance namespace. [cfaea91b]
- ``include()`` also accepts as an argument either an iterable that returns URL patterns or a 2-tuple containing such iterable plus the names of the application namespaces. [c58f0f29]
- from django.conf import settings from django.conf.urls.static import static [d990b2b04dc10582-3]
- from django.urls import include, path [4b5fb9f5]
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
- .. function:: register_converter(converter, type_name) [48639793]
- .. function:: static.static(prefix, view=django.views.static.serve, **kwargs) [c7482ce2]
- .. module:: django.conf.urls [018b74fd]
- .. module:: django.urls.conf :synopsis: Functions for use in URLconfs. [0fae2d9f]
- ============================================= ``django.urls`` functions for use in URLconfs ============================================= [14064a59]
- A callable, or a string representing the full Python import path to the view that should be called if none of the URL patterns match. [dcb27038]
- Helper function to return a URL pattern for serving files in debug mode:: [7a7a57d1]
- ``handler400`` ============== [2e336ca5]

## Beyond the budget

34 more facts did not fit in the budget: [de400deb] [e0866ef7] [19293a52] [e5c2444a] [3df3f143] [b5b04482] [38364b66] [4ec12dc1] [ebac5987] [1c99b26a35481bcd] [e7b9077a] [f6252bca] [ccc6a326] [bb3a93d4] [6a30fadb] [772b76ad] [3361cdab] [67838577] [6838d09e] [63f744fb] [6c208a4d] [8421bb3d] [4f6a7dd4] [b880776e] [f6197ffe] [ab6f7080] [e16b38f0] [e9982e75ca22a002-4] [2ecf5ded] [e0e77fdb] [2d9c9986] [58c6d91e] [6a995a04] [3a11a8f2]
