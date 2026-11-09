# django/urls/base

- Subject: django/urls/base (id `a416c2e8-3fe9-4433-be40-3e4602244b07`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 14 of 24
- Conflicts: 0
- Gaps: 0

## Facts

- if ns != current_ns: current_path = None [9088cd45]
- try: extra, resolver = resolver.namespace_dict[ns] resolved_path.append(ns) ns_pattern += extra ns_converters.update(resolver.pattern.converters) except KeyError as key: if resolved_path: raise NoReverseMatch( "%s is not a registered namespace inside '%s'" % (key, ":".join(resolved_path)) ) else: raise NoReverseMatch("%s is not a registered namespace" % key) if ns_pattern: resolver = get_ns_resolver( ns_pattern, resolver, tuple(ns_converters.items()) ) [d51fac4f]
- if current_app: current_path = current_app.split(":") current_path.reverse() else: current_path = None [180fd83e]
- resolved_path = [] ns_pattern = "" ns_converters = {} for ns in path: current_ns = current_path.pop() if current_path else None # Lookup the name to see if it could be an app identifier. try: app_list = resolver.app_dict[ns] # Yes! Path part matches an app in the current Resolver. if current_ns and current_ns in app_list: # If we are reversing for a particular app, use that # namespace. ns = current_ns elif ns not in app_list: # The name isn't shared by one of the instances (i.e., # the default) so pick the first instance as the default. ns = app_list[0] except KeyError: pass [5a3d7019]
- if not isinstance(viewname, str): view = viewname else: *path, view = viewname.split(":") [12ab0669]
- prefix = get_script_prefix() [4570883c]
- resolved_url = resolver._reverse_with_prefix(view, prefix, *args, **kwargs) if query is not None: if isinstance(query, QueryDict): query_string = query.urlencode() else: query_string = urlencode(query, doseq=True) if query_string: resolved_url += "?" + query_string if fragment is not None: resolved_url += "#" + fragment return resolved_url [96c63b16]
- # Overridden URLconfs for each thread are stored here. _urlconfs = Local() [b792b021]
- # SCRIPT_NAME prefixes for each thread are stored here. If there's no entry for # the current thread (which is the only one we ever access), it is assumed to # be empty. _prefixes = Local() [4cb4b747]
- def clear_script_prefix(): """ Unset the script prefix for the current thread. """ try: del _prefixes.value except AttributeError: pass [97f66f5a]
- def clear_url_caches(): get_callable.cache_clear() _get_cached_resolver.cache_clear() get_ns_resolver.cache_clear() [e7ef45a9]
- def get_script_prefix(): """ Return the currently active script prefix. Useful for client code that wishes to construct their own URLs manually (although accessing the request instance is normally going to be a lot cleaner). """ return getattr(_prefixes, "value", "/") [82504a4d]
- def get_urlconf(default=None): """ Return the root URLconf to use for the current thread or asyncio task if it has been changed from the default one. """ return getattr(_urlconfs, "value", default) [804fc035]
- def is_valid_path(path, urlconf=None): """ Return the ResolverMatch if the given path resolves against the default URL resolver, False otherwise. This is a convenience method to make working with "is this a match?" cases easier, avoiding try...except blocks. """ try: return resolve(path, urlconf) except Resolver404: return False [0b0d7b76]

## Beyond the budget

10 more facts did not fit in the budget: [3d0aae5a] [d05ce5eb] [20936246] [372cb55b] [fcbf94df] [14b57c6e] [6beab4e4549a99b7-3] [4f0a5fca] [86803c5e] [588f3d78]
