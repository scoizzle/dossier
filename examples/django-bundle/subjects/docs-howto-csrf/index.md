# docs/howto/csrf

- Subject: docs/howto/csrf (id `47bfd211-be5c-4682-a2e8-20497c17ba63`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 21 of 85
- Conflicts: 0
- Gaps: 0

## Facts

- if some_condition(): return protected_path(request) else: do_something_else() [2bee19f0]
- <form method="post">{% csrf_token %} [c15c729c]
- <form method="post">{{ csrf_input }} [9fb909ce]
- >>> from django.test import Client >>> csrf_client = Client(enforce_csrf_checks=True) [aae9105c]
- @csrf_exempt def my_view(request): @csrf_protect def protected_path(request): do_something() [0c6295f0]
- If your view is not rendering a template containing the :ttag:`csrf_token` template tag, Django might not set the CSRF token cookie. This is common in cases where forms are dynamically added to the page. To address this case, Django provides a view decorator which forces setting of the cookie: :func:`~django.views.decorators.csrf.ensure_csrf_cookie`. [6701f504]
- The CSRF token is also present in the DOM in a masked form, but only if explicitly included using :ttag:`csrf_token` in a template. The cookie contains the canonical, unmasked token. The :class:`~django.middleware.csrf.CsrfViewMiddleware` will accept either. However, in order to protect against `BREACH`_ attacks, it's recommended to use a masked token. [11988adb]
- const csrftoken = Cookies.get('csrftoken'); [3c1870ea]
- const request = new Request( /* URL */, { method: 'POST', headers: {'X-CSRFToken': csrftoken}, mode: 'same-origin' // Do not send CSRF token to another domain. } ); fetch(request).then(function(response) { // ... }); [7d955fd3]
- from django.views.decorators.csrf import csrf_exempt, csrf_protect [fa2b5ef4]
- function getCookie(name) { let cookieValue = null; if (document.cookie && document.cookie !== '') { const cookies = document.cookie.split(';'); for (let i = 0; i < cookies.length; i++) { const cookie = cookies[i].trim(); // Does this cookie string begin with the name we want? if (cookie.substring(0, name.length + 1) === (name + '=')) { cookieValue = decodeURIComponent(cookie.substring(name.length + 1)); break; } } } return cookieValue; } const csrftoken = getCookie('csrftoken'); [5c63ec4e]
- {% csrf_token %} <script> const csrftoken = document.querySelector('[name=csrfmiddlewaretoken]').value; </script> [13c863b1]
- .. code-block:: html+django [685d15dfb6eb2285-4]
- If you disabled it, which is not recommended, you can use :func:`~django.views.decorators.csrf.csrf_protect` on particular views you want to protect (see below). [cefd1138]
- This should not be done for POST forms that target external URLs, since that would cause the CSRF token to be leaked, leading to a vulnerability. [5f35631d]
- @cache_page(60 * 15) @csrf_protect def my_view(request): ... [4cc483d1]
- from django.views.decorators.cache import cache_page from django.views.decorators.csrf import csrf_protect [ccccaa29]
- #. In any template that uses a POST form, use the :ttag:`csrf_token` tag inside the ``<form>`` element if the form is for an internal URL, e.g.: [293abac2]
- .. _BREACH: https://www.breachattack.com/ [4b0c3c03d427622c]
- .. _acquiring-csrf-token-from-cookie: [2a990b3a]
- .. _csrf-ajax: [9e8c9363]

## Beyond the budget

63 more facts did not fit in the budget: [f794ce90] [22b5b4cc] [8ddd5494] [ee90da95] [d1c66a4d] [2870a5f5] [74ddfaf9] [4d50152b] [3f90e06ebee94674] [3f90e06ebee94674-2] [3f90e06ebee94674-3] [eaf050be34acb41d-3] [942ae6c11625c81c-2] [c54b54cb0805732a-2] [2b90aaed] [a7e4a12d] [cee58891] [db1e5580] [d4e70dc5] [879acd8f] [0d30496b] [21c5c58e] [b9efeda3] [4676c3ef] [f16efba1] [e729c593] [217f92e2] [dcbd6a3e] [af3a2c94] [92afb58f] [bce154ed] [3b82ba20] [8fe7ea12] [56e0bb0b] [db64c7fc] [9e95fb7c] [50df41f1] [6d81f028] [17449b2e] [cfdc6b7c] [462481a1] [5806022f] [2fc9d352] [ab540e92] [e2802f63] [3a061c07] [cdcf4ecf] [1140f06f] [61ddfba1] [6022cae7] [1f8cc52c] [ed74d2e4] [1499d7ac] [e0a2defa] [ae261709] [7828cc7c] [aac9ae8b] [91539a40] [0743cb8e] [9ab37aed] [0ae05bd6] [bd060077] [1e7e3d64]
