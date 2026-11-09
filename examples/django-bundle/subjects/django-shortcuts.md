# django/shortcuts

- Subject: django/shortcuts (id `1e3b2c6c-5526-48dd-92d0-19d60a6707b5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 882 tokens
- Facts shown: 14 of 26
- Conflicts: 0
- Gaps: 0

## Facts

- * A URL, which will be returned as-is. """ # If it's a model, use get_absolute_url() if hasattr(to, "get_absolute_url"): return to.get_absolute_url() [fc3096b4]
- * A URL, which will be used as-is for the redirect location. [b47d9744]
- * A model: the model's `get_absolute_url()` function will be called. [058aa240f67e1aae]
- * A view name, possibly with arguments: `urls.reverse()` will be used to reverse-resolve the name. [92890034539225a6]
- # Finally, fall back and assume it's a URL return to [ab3ede6b]
- # Handle relative URLs if isinstance(to, str) and to.startswith(("./", "../")): return to [139aba46]
- # Next try a reverse URL resolution. try: return reverse(to, args=args, kwargs=kwargs) except NoReverseMatch: # If this is a callable, re-raise. if callable(to): raise # If this doesn't "feel" like a URL, re-raise. if "/" not in to and "." not in to: raise [5f00317c]
- Issues a temporary redirect by default. Set permanent=True to issue a permanent redirect. Set preserve_request=True to instruct the user agent to preserve the original HTTP method and body when following the redirect. """ redirect_class = ( HttpResponsePermanentRedirect if permanent else HttpResponseRedirect ) return redirect_class( resolve_url(to, *args, **kwargs), preserve_request=preserve_request, max_length=max_length, ) [32a743f8]
- Like with QuerySet.get(), MultipleObjectsReturned is raised if more than one object is found. """ queryset = _get_queryset(klass) if not hasattr(queryset, "get"): klass__name = ( klass.__name__ if isinstance(klass, type) else klass.__class__.__name__ ) raise ValueError( "First argument to get_object_or_404() must be a Model, Manager, " "or QuerySet, not '%s'." % klass__name ) try: return queryset.get(*args, **kwargs) except queryset.model.DoesNotExist: raise Http404( # Translators: %s is the name of a model, e.g. "No City matches the # given query." _("No %s matches the given query.") % queryset.model._meta.object_name ) [89c021da]
- The arguments could be: [43549b676beb4430]
- if isinstance(to, Promise): # Expand the lazy instance, as it can cause issues when it is passed # further to some Python functions like urlparse. to = str(to) [c10058f1]
- klass may be a Model, Manager, or QuerySet object. All other passed arguments and keyword arguments are used in the filter() query. """ queryset = _get_queryset(klass) if not hasattr(queryset, "filter"): klass__name = ( klass.__name__ if isinstance(klass, type) else klass.__class__.__name__ ) raise ValueError( "First argument to get_list_or_404() must be a Model, Manager, or " "QuerySet, not '%s'." % klass__name ) obj_list = list(queryset.filter(*args, **kwargs)) if not obj_list: raise Http404( _("No %s matches the given query.") % queryset.model._meta.object_name ) return obj_list [6dcd0238]
- klass may be a Model, Manager, or QuerySet object. All other passed arguments and keyword arguments are used in the get() query. [407996f9]
- """ This module collects helper functions and classes that "span" multiple levels of MVC. In other words, these functions/classes introduce controlled coupling for convenience's sake. """ [9522a59d]

## Beyond the budget

9 more facts did not fit in the budget: [1f0a5573] [5ec63dad] [ecd16a25] [8a6b5fc0] [2be8296b] [4c568434] [935c0786] [7f2be102] [6772d448]
