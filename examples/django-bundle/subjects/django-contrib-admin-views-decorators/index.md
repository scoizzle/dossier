# django/contrib/admin/views/decorators

- Subject: django/contrib/admin/views/decorators (id `9c9e43cf-fc14-475f-be6b-f0fb2a4d2e41`)
- Kind: subject
- Budget: 1200 tokens
- Used: 164 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- def staff_member_required( view_func=None, redirect_field_name=REDIRECT_FIELD_NAME, login_url="admin:login" ): """ Decorator for views that checks that the user is logged in and is a staff member, redirecting to the login page if necessary. """ actual_decorator = user_passes_test( lambda u: u.is_active and u.is_staff, login_url=login_url, redirect_field_name=redirect_field_name, ) if view_func: return actual_decorator(view_func) return actual_decorator [28f6aa6f]
- from django.contrib.auth import REDIRECT_FIELD_NAME from django.contrib.auth.decorators import user_passes_test [975a94dd]
