# django/contrib/redirects/admin

- Subject: django/contrib/redirects/admin (id `b813c221-2076-497a-863f-7129ca1e8c61`)
- Kind: subject
- Budget: 1200 tokens
- Used: 85 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- @admin.register(Redirect) class RedirectAdmin(admin.ModelAdmin): list_display = ("old_path", "new_path") list_filter = ("site",) search_fields = ("old_path", "new_path") [203f1f9d]
- from django.contrib import admin from django.contrib.redirects.models import Redirect [49d2f0df]
