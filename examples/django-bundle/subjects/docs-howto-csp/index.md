# docs/howto/csp

- Subject: docs/howto/csp (id `d2144747-acb4-4b8d-9b90-6745d3443d70`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1183 tokens
- Facts shown: 31 of 34
- Conflicts: 0
- Gaps: 0

## Highlights

- The :ttag:`csp_nonce_attr` template tag was added, including support for rendering :class:`~django.forms.Media` objects. [136c63f9c5a3bf62]
- <script nonce="{{ csp_nonce }}"> // This inline JavaScript will be allowed. </script> [68bdfc626470e6ff]
- <script src="/path/to/script.js" {% csp_nonce_attr %}></script> <link rel="stylesheet" href="/path/to/style.css" {% csp_nonce_attr %}> [1ada02a86f39bfa7]
- <style nonce="{{ csp_nonce }}"> /* These inline styles will be allowed. */ </style> [caefdb30]
- {% csp_nonce_attr form.media %} [9aec9a0cca6c6741]
- # Or for report-only mode: SECURE_CSP_REPORT_ONLY = { "default-src": [CSP.SELF], # Add more directives as needed. "report-uri": "/path/to/reports-endpoint/", } [3c15302e]
- # To enforce a CSP policy: SECURE_CSP = { "default-src": [CSP.SELF], # Add more directives to be enforced. } [c151e507]
- MIDDLEWARE = [ # ... "django.middleware.csp.ContentSecurityPolicyMiddleware", # ... ] [0d363c03]
- SECURE_CSP = { "default-src": [CSP.SELF], # Allow self-hosted scripts and script tags with matching `nonce` attr. "script-src": [CSP.SELF, CSP.NONCE], # Example of the less secure 'unsafe-inline' option. "style-src": [CSP.SELF, CSP.UNSAFE_INLINE], } [0aac5c13]
- TEMPLATES = [ { "BACKEND": "django.template.backends.django.DjangoTemplates", "OPTIONS": { "context_processors": [ # ... "django.template.context_processors.csp", ], }, }, ] [81f98d85]
- from django.utils.csp import CSP [ac6cbe5b3e28dda2]
- .. code-block:: html+django [685d15dfb6eb2285]
- .. versionchanged:: 6.1 [2a966a198e13032b]
- For external ``<script src="...">`` and ``<link rel="stylesheet">`` elements, use the :ttag:`csp_nonce_attr` template tag: [dfed7e8fa18bdbcb]
- For inline ``<style>`` or ``<script>`` tags, use the ``csp_nonce`` context variable directly: [6525374b]
- The :class:`~django.middleware.csp.ContentSecurityPolicyMiddleware` automatically handles generating a unique nonce and inserting the appropriate ``nonce-<value>`` source expression into the ``Content-Security-Policy`` (or ``Content-Security-Policy-Report-Only``) header when the nonce is used in a template. [4187f5d9]
- To ensure correct behavior, make sure both the HTML and the header are generated within the same request and not served from cache. See the reference documentation on :ref:`csp-nonce` for implementation details and important caching considerations. [ca014ec2]
- To render a :class:`~django.forms.Media` object's assets with the nonce applied to each element, pass the object to the :ttag:`csp_nonce_attr` tag: [c69ac975]
- .. _csp-config: [edbd8019]
- .. _csp-nonce-config: [bcf49720]
- .. admonition:: Caching and Nonce Reuse [e0ff76d1]
- 1. Add the CSP middleware to your :setting:`MIDDLEWARE` setting:: [a497719f]
- 1. Include the :attr:`~django.utils.csp.CSP.NONCE` placeholder value in the CSP settings. This only applies to ``script-src`` or ``style-src`` directives:: [ed70e461]
- Basic config ============ [7e29e909]

## All facts

- [c2d5bed3] 2. Add the :func:`~django.template.context_processors.csp` context processor to your :setting:`TEMPLATES` setting. This makes the generated nonce value available in the Django templates as the ``csp_nonce`` context variable::
- [21df5833] 2. Configure the CSP policies in your ``settings.py`` using either :setting:`SECURE_CSP` or :setting:`SECURE_CSP_REPORT_ONLY` (or both). The :ref:`CSP Settings docs <csp-settings>` provide more details about the differences between these two::
- [2bd49600] 3. In your templates, add the nonce to elements that require it:
- [6f1b719a] =========================================== How to use Django's Content Security Policy ===========================================
- [8f69ca6f] Nonce config ============
- [3217f99a] To enable Content Security Policy (CSP) in your Django project:
- [4c418750] To use nonces in your CSP policy, beside the basic config, you need to:
