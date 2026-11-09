# django/middleware/csp

- Subject: django/middleware/csp (id `a3c8d9fb-274f-40ef-903c-8f3d9b492ca3`)
- Kind: subject
- Budget: 1200 tokens
- Used: 346 tokens
- Facts shown: 7 of 7
- Conflicts: 0
- Gaps: 0

## Facts

- for header, config in [ (CSP.HEADER_ENFORCE, csp_config), (CSP.HEADER_REPORT_ONLY, csp_ro_config), ]: # If headers are already set on the response, don't overwrite them. # This allows for views to set their own CSP headers as needed. # An empty config means CSP headers are not added to the response. if config and header not in response: response.headers[str(header)] = build_policy(config, nonce) [a901a314]
- return response [8034aacd88b9c7ae-5]
- sentinel = object() if (csp_config := getattr(response, "_csp_config", sentinel)) is sentinel: csp_config = settings.SECURE_CSP if (csp_ro_config := getattr(response, "_csp_ro_config", sentinel)) is sentinel: csp_ro_config = settings.SECURE_CSP_REPORT_ONLY [6010de27]
- def process_response(self, request, response): nonce = get_nonce(request) [8611cdcd]
- class ContentSecurityPolicyMiddleware(MiddlewareMixin): def process_request(self, request): request._csp_nonce = LazyNonce() [cbc2c6cd]
- def get_nonce(request): return getattr(request, "_csp_nonce", None) [c1944f93]
- from django.conf import settings from django.utils.csp import CSP, LazyNonce, build_policy from django.utils.deprecation import MiddlewareMixin [dd078642]
