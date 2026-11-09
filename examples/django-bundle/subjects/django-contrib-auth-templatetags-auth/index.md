# django/contrib/auth/templatetags/auth

- Subject: django/contrib/auth/templatetags/auth (id `599f1c4a-d1b0-4195-a3e7-026f84b7e3a8`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 239 tokens
- Facts shown: 3 facts
- Conflicts: 0
- Gaps: 0

## Facts

- @register.simple_tag def render_password_as_hash(value): if not value or value.startswith(UNUSABLE_PASSWORD_PREFIX): return format_html("<p><strong>{}</strong></p>", gettext("No password set.")) try: hasher = identify_hasher(value) hashed_summary = hasher.safe_summary(value) except ValueError: return format_html( "<p><strong>{}</strong></p>", gettext("Invalid password format or unknown hashing algorithm."), ) items = [(gettext(key), val) for key, val in hashed_summary.items()] return format_html( "<p>{}</p>", format_html_join(" ", "<strong>{}</strong>: <bdi>{}</bdi>", items), ) [150f41cf]
- from django.contrib.auth.hashers import UNUSABLE_PASSWORD_PREFIX, identify_hasher from django.template import Library from django.utils.html import format_html, format_html_join from django.utils.translation import gettext [19a2d0e4]
- register = Library() [c8c0ccd629deb6b1-2]
