# django/contrib/auth/checks

- Subject: django/contrib/auth/checks (id `61627256-4c10-4d05-ac96-622f3f9c6726`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 10 of 17
- Conflicts: 0
- Gaps: 0

## Facts

- # Check that REQUIRED_FIELDS is a list if not isinstance(cls.REQUIRED_FIELDS, (list, tuple)): errors.append( checks.Error( "'REQUIRED_FIELDS' must be a list or tuple.", obj=cls, id="auth.E001", ) ) [4f6f7a00]
- # Check that the USERNAME FIELD isn't included in REQUIRED_FIELDS. if cls.USERNAME_FIELD in cls.REQUIRED_FIELDS: errors.append( checks.Error( "The field named as the 'USERNAME_FIELD' " "for a custom user model must not be included in 'REQUIRED_FIELDS'.", hint=( "The 'USERNAME_FIELD' is currently set to '%s', you " "should remove '%s' from the 'REQUIRED_FIELDS'." % (cls.USERNAME_FIELD, cls.USERNAME_FIELD) ), obj=cls, id="auth.E002", ) ) [a74e8abc]
- # Check that the username field is unique if not cls._meta.get_field(cls.USERNAME_FIELD).unique and not any( constraint.fields == (cls.USERNAME_FIELD,) for constraint in cls._meta.total_unique_constraints ): if settings.AUTHENTICATION_BACKENDS == [ "django.contrib.auth.backends.ModelBackend" ]: errors.append( checks.Error( "'%s.%s' must be unique because it is named as the " "'USERNAME_FIELD'." % (cls._meta.object_name, cls.USERNAME_FIELD), obj=cls, id="auth.E003", ) ) else: errors.append( checks.Warning( "'%s.%s' is named as the 'USERNAME_FIELD', but it is not unique." % (cls._meta.object_name, cls.USERNAME_FIELD), hint=( "Ensure that your authentication backend(s) can handle " "non-unique usernames." ), obj=cls, id="auth.W004", ) ) [f52f5079]
- Permission = apps.get_model("auth", "Permission") permission_name_max_length = Permission._meta.get_field("name").max_length permission_codename_max_length = Permission._meta.get_field("codename").max_length errors = [] [921daf54]
- errors = [] [ea5291ead597635f]
- if callable(cls().is_anonymous): errors.append( checks.Critical( "%s.is_anonymous must be an attribute or property rather than " "a method. Ignoring this is a security issue as anonymous " "users will be treated as authenticated!" % cls, obj=cls, id="auth.C009", ) ) if callable(cls().is_authenticated): errors.append( checks.Critical( "%s.is_authenticated must be an attribute or property rather " "than a method. Ignoring this is a security issue as anonymous " "users will be treated as authenticated!" % cls, obj=cls, id="auth.C010", ) ) return errors [fc50131c]
- if login_required_index != -1: auth_index = _subclass_index( "django.contrib.auth.middleware.AuthenticationMiddleware", settings.MIDDLEWARE, ) if auth_index == -1 or auth_index > login_required_index: errors.append( checks.Error( "In order to use django.contrib.auth.middleware." "LoginRequiredMiddleware, django.contrib.auth.middleware." "AuthenticationMiddleware must be defined before it in MIDDLEWARE.", id="auth.E013", ) ) return errors [61873bc3]
- login_required_index = _subclass_index( "django.contrib.auth.middleware.LoginRequiredMiddleware", settings.MIDDLEWARE, ) [cc00ce7d]
- return errors [b2c21f6739c80fd1]
- def _subclass_index(class_path, candidate_paths): """ Return the index of dotted class path (or a subclass of that class) in a list of candidate paths. If it does not exist, return -1. """ cls = import_string(class_path) for index, path in enumerate(candidate_paths): try: candidate_cls = import_string(path) if issubclass(candidate_cls, cls): return index except (ImportError, TypeError): continue return -1 [cafaea2e]

## Beyond the budget

7 more facts did not fit in the budget: [e8257c80] [e21d5d3d] [8d6841f8] [d8e84ac8] [fbad6d1d] [63396db3] [a79448688635df7c]
