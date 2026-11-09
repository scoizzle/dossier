# django/core/checks/security/base

- Subject: django/core/checks/security/base (id `f163397e-33a8-42f0-977e-4dd7e7889e05`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 12 of 44
- Conflicts: 0
- Gaps: 0

## Facts

- Ensures both SECURE_CSP and SECURE_CSP_REPORT_ONLY are dictionaries. """ # CSP settings must be a dictionary or None. return [ Error(E026.msg % (name, value), id=E026.id) for name in ("SECURE_CSP", "SECURE_CSP_REPORT_ONLY") if (value := getattr(settings, name, None)) is not None and not isinstance(value, dict) ] [8430a3c3]
- @register(Tags.security) def check_csp_nonce_context_processor(app_configs, **kwargs): if ( _csp_middleware() and any( _csp_policy_contains_nonce(getattr(settings, name, None)) for name in ("SECURE_CSP", "SECURE_CSP_REPORT_ONLY") ) and not _csp_context_processor_configured() ): return [W027] return [] [0b8f0c9c]
- @register(Tags.security) def check_csp_settings(app_configs, **kwargs): """ Validate that CSP settings are properly configured when enabled. [82d173a7]
- @register(Tags.security, deploy=True) def check_allowed_hosts(app_configs, **kwargs): return [] if settings.ALLOWED_HOSTS else [W020] [4b7418d1]
- @register(Tags.security, deploy=True) def check_content_type_nosniff(app_configs, **kwargs): passed_check = ( not _security_middleware() or settings.SECURE_CONTENT_TYPE_NOSNIFF is True ) return [] if passed_check else [W006] [caef1e9c]
- @register(Tags.security, deploy=True) def check_cross_origin_opener_policy(app_configs, **kwargs): if ( _security_middleware() and settings.SECURE_CROSS_ORIGIN_OPENER_POLICY is not None and settings.SECURE_CROSS_ORIGIN_OPENER_POLICY not in CROSS_ORIGIN_OPENER_POLICY_VALUES ): return [E024] return [] [02313a03]
- @register(Tags.security, deploy=True) def check_debug(app_configs, **kwargs): passed_check = not settings.DEBUG return [] if passed_check else [W018] [bf2889b4]
- @register(Tags.security, deploy=True) def check_referrer_policy(app_configs, **kwargs): if _security_middleware(): if settings.SECURE_REFERRER_POLICY is None: return [W022] # Support a comma-separated string or iterable of values to allow # fallback. if isinstance(settings.SECURE_REFERRER_POLICY, str): values = {v.strip() for v in settings.SECURE_REFERRER_POLICY.split(",")} else: values = set(settings.SECURE_REFERRER_POLICY) if not values <= REFERRER_POLICY_VALUES: return [E023] return [] [fb19abf8]
- @register(Tags.security, deploy=True) def check_secret_key(app_configs, **kwargs): try: secret_key = settings.SECRET_KEY except (ImproperlyConfigured, AttributeError): passed_check = False else: passed_check = _check_secret_key(secret_key) return [] if passed_check else [W009] [012eeab7]
- @register(Tags.security, deploy=True) def check_secret_key_fallbacks(app_configs, **kwargs): warnings = [] try: fallbacks = settings.SECRET_KEY_FALLBACKS except (ImproperlyConfigured, AttributeError): warnings.append(Warning(W025.msg % "SECRET_KEY_FALLBACKS", id=W025.id)) else: for index, key in enumerate(fallbacks): if not _check_secret_key(key): warnings.append( Warning(W025.msg % f"SECRET_KEY_FALLBACKS[{index}]", id=W025.id) ) return warnings [5fa82273]
- @register(Tags.security, deploy=True) def check_security_middleware(app_configs, **kwargs): passed_check = _security_middleware() return [] if passed_check else [W001] [64fc7512]
- E026 = Error( "The Content Security Policy setting '%s' must be a dictionary (got %r instead).", id="security.E026", ) [f244d335]

## Beyond the budget

32 more facts did not fit in the budget: [d2216b76] [a752906e] [49911673] [88a0319f] [91d067f3] [f33ff024] [e3cb0c9b] [9696d86a] [d42c82f2] [ad20c699] [ccaae1dc] [fba594be] [cb0ef106] [c57540d8] [1778c850] [6fb4f828] [a5c1c609] [359ba3c3] [2065772e] [06bdd7fa] [46e316c3] [e09704ad] [814473aa] [4a127548] [fa79e0fc] [5440c450] [78839194] [4b167638] [c3bd4ea8] [f35c1517] [44225905] [21e50235]
