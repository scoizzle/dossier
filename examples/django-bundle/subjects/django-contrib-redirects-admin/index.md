# django/contrib/redirects/admin

- Subject: django/contrib/redirects/admin (id `d6cde4ef-ca86-4a6e-8b9d-ac1d30526cd7`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 85 tokens
- Facts shown: 2 facts
- Conflicts: 0
- Gaps: 0

## Facts

- @admin.register(Redirect) class RedirectAdmin(admin.ModelAdmin): list_display = ("old_path", "new_path") list_filter = ("site",) search_fields = ("old_path", "new_path") [203f1f9d]
- from django.contrib import admin from django.contrib.redirects.models import Redirect [49d2f0df]
