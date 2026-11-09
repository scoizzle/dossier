# docs/ref/urlresolvers

- Subject: docs/ref/urlresolvers (id `4349f5d9-8265-4d80-9315-8b2f41c502d4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 30 of 94
- Conflicts: 0
- Gaps: 0

## Facts

- # modify the request and response as required, e.g. change locale # and set corresponding locale cookie [f294ff94]
- >>> reverse("cities", args=["Orléans"]) '.../Orl%C3%A9ans/' [098fe4b7]
- All keyword arguments that would be passed to the view function, i.e. :attr:`~ResolverMatch.captured_kwargs` and :attr:`~ResolverMatch.extra_kwargs`. [cec7f1ef]
- For example, if ``path('users/<id>/', ...)`` is the matching pattern, ``route`` will contain ``'users/<id>/'``. [da4bef37]
- The additional keyword arguments that would be passed to the view function. [d7c54e94]
- The application namespace for the URL pattern that matches the URL. [435bfd3d]
- The arguments that would be passed to the view function, as parsed from the URL. [efca0e41]
- The instance namespace for the URL pattern that matches the URL. [a5dfe46b]
- The list of URL patterns tried before the URL either matched one or exhausted available patterns. [f48752e3]
- The list of individual namespace components in the full application namespace for the URL pattern that matches the URL. For example, if the ``app_name`` is ``'foo:bar'``, then ``app_names`` will be ``['foo', 'bar']``. [06b92461]
- The list of individual namespace components in the full instance namespace for the URL pattern that matches the URL. i.e., if the namespace is ``foo:bar``, then namespaces will be ``['foo', 'bar']``. [0a3e8c14]
- The name of the URL pattern that matches the URL. [e0a5d590]
- The name of the view that matches the URL, including the namespace if there is one. [99688f1d]
- The route of the matching URL pattern. [63cedf93]
- The view function that would be used to serve the URL [6a4d953b]
- archive = ArchiveView.as_view() [8775e2d6]
- class ArchiveView(View): ... [202bb55f]
- from django.views import View [312d6da0ca4d357f-2]
- view, args, kwargs = resolve(urlsplit(next).path) kwargs["request"] = request try: view(*args, **kwargs) except Http404: return HttpResponseRedirect("/") return response [ca94807a]
- # Resolve a URL match = resolve("/some/path/") # Print the URL pattern that matches the URL print(match.url_name) [3ca70545]
- # passing a callable object # (This is discouraged because you can't reverse namespaced views this way.) from news import views [966673a1]
- # using the named URL reverse("news-archive") [6c18ff1a]
- .. attribute:: ResolverMatch.app_name [c7879404]
- .. attribute:: ResolverMatch.app_names [eb661a1d]
- .. attribute:: ResolverMatch.args [5215c73b]
- .. attribute:: ResolverMatch.captured_kwargs [a057c0b7]
- .. attribute:: ResolverMatch.extra_kwargs [27817075]
- .. attribute:: ResolverMatch.func [ec576ad5]
- .. attribute:: ResolverMatch.kwargs [99f06f06]
- .. attribute:: ResolverMatch.namespace [d5628f15]

## Beyond the budget

62 more facts did not fit in the budget: [1eaef438] [b8483f4e] [c63c8042] [f65831d1] [62030ef3] [eaf050be34acb41d-597] [3be1659cdc78684b-2] [cc3d5294] [1e3a0440] [eedee337] [efa10a6a] [49e4ff83] [95cc5d49] [61245ef7] [54518b9d] [cab390ceec62b73f-2] [fcbd3d8f] [c023001f] [7b4c7b71] [ef7091da] [cbcb2a76] [55a79875] [f422271a] [40c26b8c] [9967711c] [3742a300] [da9a5552] [eaf050be34acb41d-598] [eaf050be34acb41d-599] [be0e1f62] [b111270c] [37edbe05] [5a1fbe48] [942ae6c11625c81c-154] [c54b54cb0805732a-87] [28916b04] [7c0cb1ac] [74458a7b] [41072a5f] [bc295f9831206ba3-61] [6d37c01a] [5aee3ee1] [e87dc01d] [06ec6bdc] [8bcd90b3] [54f05751] [6a51a4a1] [a86cdc80] [23c5dde1] [f860555d] [72e8b394] [0f69e02e] [9406b8cf] [1919b7e3] [6d7e9268] [bcb0b933] [168c7f13] [9dad9b4f] [9e8a2a35] [d7d1b091] [a18c6f23] [7e1ae46c]
