# django/core/mail/__init__

- Subject: django/core/mail/__init__ (id `14558fef-34f9-40dd-a0b9-0add0caf36d2`)
- Kind: subject
- Budget: 1200 tokens
- Used: 886 tokens
- Facts shown: 12 of 33
- Conflicts: 0
- Gaps: 0

## Facts

- warnings.warn(msg, category=RemovedInDjango2028Warning) return getattr(message, name) [a406b441]
- # RemovedInDjango2028Warning. if all(isinstance(a, (list, tuple)) and len(a) == 2 for a in recipients): warnings.warn( f"Using (name, address) pairs in the {setting_name} setting is deprecated." " Replace with a list of email address strings.", RemovedInDjango2028Warning, stacklevel=2, ) recipients = [a[1] for a in recipients] [21c9050a]
- Both fail_silently and other keyword arguments are used in the constructor of the backend. """ msg = ( "get_connection() is deprecated. See 'Migrating email to mailers' " "in Django's documentation for recommended replacements." ) warn_about_external_use(msg, RemovedInDjango2028Warning, skip_frames=1) warn_about_default_mailers_if_needed() [a76ed483]
- If backend is None (default), use settings.EMAIL_BACKEND. [fd977931]
- If from_email is None, use the DEFAULT_FROM_EMAIL setting. [fcf03e3367844f96]
- Note: The API for this method is frozen. New code wanting to extend the functionality should use the EmailMessage class directly. """ # RemovedInDjango2028Warning: change entire implementation to: # email = EmailMultiAlternatives( # subject, message, from_email, recipient_list # ) # if html_message: # email.attach_alternative(html_message, "text/html") # return email.send(using=using) if fail_silently: warn_about_external_use( FAIL_SILENTLY_ARG_WARNING, RemovedInDjango2028Warning, skip_frames=1 ) if auth_user is not None or auth_password is not None: warn_about_external_use( AUTH_ARGS_WARNING, RemovedInDjango2028Warning, skip_frames=1 ) if connection is not None: warn_about_external_use( CONNECTION_ARG_WARNING, RemovedInDjango2028Warning, skip_frames=1 ) [a8cb6af6]
- Note: The API for this method is frozen. New code wanting to extend the functionality should use the EmailMessage class directly. """ # RemovedInDjango2028Warning: change entire implementation to: # messages = [...] # mailer = mailers.default if using is None else mailers[using] # return mailer.send_messages(messages) if fail_silently: warn_about_external_use( FAIL_SILENTLY_ARG_WARNING, RemovedInDjango2028Warning, skip_frames=1 ) if auth_user is not None or auth_password is not None: warn_about_external_use( AUTH_ARGS_WARNING, RemovedInDjango2028Warning, skip_frames=1 ) if connection is not None: warn_about_external_use( CONNECTION_ARG_WARNING, RemovedInDjango2028Warning, skip_frames=1 ) [4475aecb]
- if fail_silently: kwds["fail_silently"] = fail_silently [d0526db3]
- if mailers._is_configured: # Support get_connection(**kwargs) from MAILERS["default"]. if backend is not None: raise RuntimeError( "get_connection(backend, ...) is not supported with MAILERS." ) return mailers.create_connection(DEFAULT_MAILER_ALIAS, _deprecated_kwargs=kwds) [e55a3594]
- if not isinstance(recipients, (list, tuple)) or not all( isinstance(address, (str, Promise)) for address in recipients ): raise ImproperlyConfigured( f"The {setting_name} setting must be a list of email address strings." ) [732b9be0]
- klass = import_string(backend or settings.EMAIL_BACKEND) return klass(**kwds) [5f318bef]
- recipients = getattr(settings, setting_name) if not recipients: return [d64ca831]

## Beyond the budget

19 more facts did not fit in the budget: [391e7552] [cbf705ab] [2d99f763] [b9e7cdde] [444be62b] [8f7f837f] [745484ae] [e702868d] [0c6ddb30] [cb25ea1f] [8dbd56ed] [792aebfd] [16b29d7b] [42c23708] [2db5062b] [abcf3be0] [97f956df] [a7aa58d143dc3945-3] [11e4fefb]
