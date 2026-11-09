# docs/ref/csp

- Subject: docs/ref/csp (id `f2e16dbe-2d51-4aa5-a8b0-b734c5195fdd`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 19 of 90
- Conflicts: 0
- Gaps: 0

## Facts

- @csp_override( { "default-src": [CSP.SELF], "img-src": [CSP.SELF, "data:"], } ) def my_view(request): return HttpResponse("Custom Content-Security-Policy header applied") [8f3ced70]
- @csp_override({}) def my_other_view(request): return HttpResponse("No Content-Security-Policy header added") [d730d350]
- @csp_report_only_override( { "default-src": [CSP.SELF], "img-src": [CSP.SELF, "data:"], "report-uri": "https://mysite.com/csp-report/", } ) def my_view(request): return HttpResponse("Custom Content-Security-Policy-Report-Only header applied") [eb60887c]
- from django.http import HttpResponse from django.utils.csp import CSP from django.views.decorators.csp import csp_override [c7237f86]
- from django.http import HttpResponse from django.utils.csp import CSP from django.views.decorators.csp import csp_report_only_override [47c2e669]
- Django-specific placeholder value (``"<CSP_NONCE_SENTINEL>"``) used in ``script-src`` or ``style-src`` directives to activate nonce-based CSP. This string is replaced at runtime by the :class:`~django.middleware.csp.ContentSecurityPolicyMiddleware` with a secure, random nonce that is generated for each request. See detailed explanation in :ref:`csp-nonce`. [adde0c18]
- Represents ``'none'``. Blocks loading resources for the given directive. [bc92030b]
- Represents ``'report-sample'``. Instructs the browser to include a sample of the violating code in reports. Note that this may expose sensitive data. [00c21ae8]
- Represents ``'self'``. Allows loading resources from the same origin (same scheme, host, and port). [5c9b597f]
- Represents ``'strict-dynamic'``. Allows execution of scripts loaded by a trusted script (e.g., one with a valid nonce or hash), without needing ``'unsafe-inline'``. [6cefdc9f]
- Represents ``'unsafe-eval'``. Allows use of ``eval()`` and similar JavaScript functions. Strongly discouraged. [4b36bf00]
- Represents ``'unsafe-hashes'``. Allows inline event handlers and some ``javascript:`` URIs when their content hashes match a policy rule. Requires CSP Level 3+. [085b5019]
- Represents ``'unsafe-inline'``. Allows execution of inline scripts, styles, and ``javascript:`` URLs. Generally discouraged, especially for scripts. [52e90274]
- Represents ``'wasm-unsafe-eval'``. Permits compilation and execution of WebAssembly code without enabling ``'unsafe-eval'`` for scripts. [dd7b4d73]
- <script nonce="{{ csp_nonce }}"> // This inline JavaScript will be allowed. </script> [68bdfc626470e6ff-2]
- <script src="/path/to/script.js" {% csp_nonce_attr %}></script> <link rel="stylesheet" href="/path/to/style.css" {% csp_nonce_attr %}> [1ada02a86f39bfa7-2]
- The :ttag:`csp_nonce_attr` template tag was added, including support for rendering :class:`~django.forms.Media` objects. [136c63f9c5a3bf62-2]
- Weakening or disabling a CSP policy on any page can compromise the security of the entire site. Because of the "same origin" policy, an attacker could exploit a vulnerability on one page to access other parts of the site. [758f9be2]
- {% csp_nonce_attr form.media %} [9aec9a0cca6c6741-2]

## Beyond the budget

67 more facts did not fit in the budget: [6db103e9] [82c989e1] [2b7d63ec] [167007a2] [4fb1c5cf] [240c9f92] [43199342] [23888795] [e0c16fa4] [6549aa16] [905c306b] [730c225c80dac295-2] [730c225c80dac295-3] [1b3ed166] [79367089] [657114a7] [4ff2d095] [a801923b] [f6b6c642] [92be1fc5] [b8d563d0] [32d59dad] [4c5be506] [b4e682c3] [52c0ed79] [acc45e8c] [685d15dfb6eb2285-71] [69c6061e] [2d50bb14] [c67bce5c] [6dae2798] [8a702239] [a1eb26d754a3d60c-21] [2a966a198e13032b-9] [c54b54cb0805732a-32] [98aab7c6] [d912e64d] [7883df0c] [d35a8e86] [e9f5abb7] [f96ba3a1] [77cb7fc4] [4913f677] [b8bbf097] [fce954d3] [ef4be070] [3b675e1a] [dfed7e8fa18bdbcb-2] [eb712e00] [4acff27b] [45874f11] [9321086e] [23a3124d] [e741dd3e] [75696e16fcbb84ec-9] [821fc9fc] [94005583b32250b8-6] [1f7e836d] [7376db9a] [79d94b2f] [b45e5682] [38786390] [ab676bff] [3676d36a] [f3317397] [59550fc7] [0614491a]
