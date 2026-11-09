# django/utils/csp

- Subject: django/utils/csp (id `250ea42b-a40c-4676-93cc-e7eb9719619e`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1185 tokens
- Facts shown: 32 of 32
- Conflicts: 0
- Gaps: 0

## Highlights

- # Replace the nonce sentinel with the actual nonce values, if the # sentinel is found and a nonce is provided. Otherwise, remove it. if (has_sentinel := CSP.NONCE in values) and nonce: values = [f"'nonce-{nonce}'" if v == CSP.NONCE else v for v in values] elif has_sentinel: values = [v for v in values if v != CSP.NONCE] [7c2cc3b8]
- if not values: continue [5284ddbb]
- rendered_value = " ".join(values) [5fae660a]
- <script {% csp_nonce_attr %}></script> [d058c05e]
- SECURE_CSP = { "default-src": [CSP.NONE], "script-src": [CSP.SELF, CSP.NONCE], } [df344a40]
- if values is True: rendered_value = "" else: if isinstance(values, set): # Sort values for consistency, preventing cache invalidation # between requests and ensuring reliable browser caching. values = sorted(values) elif not isinstance(values, list | tuple): values = [values] [ca87e0c2]
- policy.append(f"{directive} {rendered_value}".rstrip()) [43224eff]
- """ [d346d78f8c109f45-5]
- """ [d346d78f8c109f45-6]
- # HTTP Headers. HEADER_ENFORCE = "Content-Security-Policy" HEADER_REPORT_ONLY = "Content-Security-Policy-Report-Only" [39a394b3]
- # Special placeholder that gets replaced by the middleware. # The value itself is arbitrary and should not be mistaken for a real # nonce. NONCE = "<CSP_NONCE_SENTINEL>" [940102bd]
- # Standard CSP directive values. NONE = "'none'" REPORT_SAMPLE = "'report-sample'" SELF = "'self'" STRICT_DYNAMIC = "'strict-dynamic'" UNSAFE_EVAL = "'unsafe-eval'" UNSAFE_HASHES = "'unsafe-hashes'" UNSAFE_INLINE = "'unsafe-inline'" WASM_UNSAFE_EVAL = "'wasm-unsafe-eval'" [f8ba0409]
- - Typos (e.g., 'noone' instead of 'none') - Missing quotes (e.g., ["self"] instead of ["'self'"]) - Inconsistent quote styles (e.g., ["'self'", "\"unsafe-inline\""]) [f8d0f4b9]
- Example Django template usage with context processors enabled: [a80b9b8c]
- Example usage in Django settings: [97bb3814]
- The nonce is only generated when first accessed (e.g., via string interpolation or inside a template). [b195d289]
- The nonce will evaluate as `True` if it has been generated, and `False` if it has not. This is useful for third-party Django libraries that want to support CSP without requiring it. [af3f7f59]
- These constants represent: 1. Standard quoted string values from the CSP spec (e.g., 'self', 'unsafe-inline') 2. Special placeholder tokens (NONCE) that get replaced by the middleware [10b6a8e6]
- Using this enum instead of raw strings provides better type checking, autocompletion, and protection against common mistakes like: [2d8c0400]
- ``{% csp_nonce_attr %}`` will only render the nonce attribute if the nonce has been evaluated (i.e. accessed) elsewhere in the request/response cycle. [370800d2]
- def __bool__(self): return self._wrapped is not empty [779ba357]
- def __init__(self): super().__init__(generate_nonce) [fa66690a]
- for directive, values in config.items(): if values in (None, False): continue [de250d67]

## All facts

- [0c63eab9] return "; ".join(policy)
- [984c27d3] # Template context key for the CSP nonce. CONTEXT_KEY = "csp_nonce"
- [3696bbb7] class CSP(StrEnum): """ Content Security Policy constants for directive values and special tokens.
- [4e349e5c] class LazyNonce(SimpleLazyObject): """ Lazily generates a cryptographically secure nonce string, for use in CSP headers.
- [a91ea976] def build_policy(config, nonce=None): policy = []
- [de8d7cd8] def generate_nonce(): return secrets.token_urlsafe(16)
- [762e9f56] def nonce_attr(context, media=None): nonce = context.get(CONTEXT_KEY) if media: return media.render(attrs={"nonce": nonce} if nonce is not None else None) if nonce is None: return "" return format_html('nonce="{}"', nonce)
- [0329b4fb] from django.utils.functional import SimpleLazyObject, empty from django.utils.html import format_html
- [b5c4bca2] import secrets from enum import StrEnum
