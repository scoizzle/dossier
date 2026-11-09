# django/template/backends/utils

- Subject: django/template/backends/utils (id `47fe60aa-53ff-4625-abf0-5e370088a4e9`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 130 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- csrf_input_lazy = lazy(csrf_input, SafeString, str) csrf_token_lazy = lazy(get_token, str) [54cd9023]
- def csrf_input(request): return format_html( '<input type="hidden" name="csrfmiddlewaretoken" value="{}">', get_token(request), ) [16dccc43]
- from django.middleware.csrf import get_token from django.utils.functional import lazy from django.utils.html import format_html from django.utils.safestring import SafeString [3a7946f5]
