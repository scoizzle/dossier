# django/contrib/auth/handlers/modwsgi

- Subject: django/contrib/auth/handlers/modwsgi (id `290b9454-8ada-4bdd-ace2-acc4b97dd1f7`)
- Kind: subject
- Budget: 1200 tokens
- Used: 441 tokens
- Facts shown: 9 of 9
- Conflicts: 0
- Gaps: 0

## Facts

- """ # db connection state is managed similarly to the wsgi handler # as mod_wsgi may call these functions outside of a request/response cycle db.reset_queries() try: user = _get_user(username) return auth.check_password_with_timing_attack_mitigation(user, password) finally: db.close_old_connections() [f4e10b28]
- If no matching user exists, or if the user is inactive, return None. """ try: user = UserModel._default_manager.get_by_natural_key(username) except UserModel.DoesNotExist: user = None else: if not user.is_active: user = None return user [e5eaa73e]
- Return None if the user does not exist, return False if the user exists but password is not correct, and return True otherwise. [0ead1429]
- mod_wsgi docs specify None, True, False as return value depending on whether the user exists and authenticates. [40226a21]
- UserModel = auth.get_user_model() [f710fa4f]
- def _get_user(username): """ Return the UserModel instance for `username`. [4a017e26]
- def check_password(environ, username, password): """ Authenticate against Django's auth database. [9342180f]
- def groups_for_user(environ, username): """ Authorize a user based on groups """ db.reset_queries() try: try: user = UserModel._default_manager.get_by_natural_key(username) except UserModel.DoesNotExist: return [] if not user.is_active: return [] return [group.name.encode() for group in user.groups.all()] finally: db.close_old_connections() [3caeacf8]
- from django import db from django.contrib import auth [647eed0c]
