# django/contrib/flatpages/admin

- Subject: django/contrib/flatpages/admin (id `93068f00-a6be-48eb-a8e5-f62db8c4f92f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 167 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- @admin.register(FlatPage) class FlatPageAdmin(admin.ModelAdmin): form = FlatpageForm fieldsets = ( (None, {"fields": ("url", "title", "content", "sites")}), ( _("Advanced options"), { "classes": ("collapse",), "fields": ("registration_required", "template_name"), }, ), ) list_display = ("url", "title") list_filter = ("sites", "registration_required") search_fields = ("url", "title") [0f6c33c0]
- from django.contrib import admin from django.contrib.flatpages.forms import FlatpageForm from django.contrib.flatpages.models import FlatPage from django.utils.translation import gettext_lazy as _ [d90c1ac1]
