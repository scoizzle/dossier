# django/shortcuts

- Subject: django/shortcuts (id `7753b916-7323-460e-8ff5-642d6c2d7b57`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1741 tokens
- Facts shown: 26 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- * A URL, which will be returned as-is. """ # If it's a model, use get_absolute_url() if hasattr(to, "get_absolute_url"): return to.get_absolute_url() [fc3096b4]
- * A URL, which will be used as-is for the redirect location. [b47d9744]
- * A model: the model's `get_absolute_url()` function will be called. [058aa240f67e1aae]
- * A model: the model's `get_absolute_url()` function will be called. [058aa240f67e1aae-2]
- * A view name, possibly with arguments: `urls.reverse()` will be used to reverse-resolve the name. [92890034539225a6]
- * A view name, possibly with arguments: `urls.reverse()` will be used to reverse-resolve the name. [92890034539225a6-2]
- # Finally, fall back and assume it's a URL return to [ab3ede6b]
- # Handle relative URLs if isinstance(to, str) and to.startswith(("./", "../")): return to [139aba46]
- # Next try a reverse URL resolution. try: return reverse(to, args=args, kwargs=kwargs) except NoReverseMatch: # If this is a callable, re-raise. if callable(to): raise # If this doesn't "feel" like a URL, re-raise. if "/" not in to and "." not in to: raise [5f00317c]
- Issues a temporary redirect by default. Set permanent=True to issue a permanent redirect. Set preserve_request=True to instruct the user agent to preserve the original HTTP method and body when following the redirect. """ redirect_class = ( HttpResponsePermanentRedirect if permanent else HttpResponseRedirect ) return redirect_class( resolve_url(to, *args, **kwargs), preserve_request=preserve_request, max_length=max_length, ) [32a743f8]
- Like with QuerySet.get(), MultipleObjectsReturned is raised if more than one object is found. """ queryset = _get_queryset(klass) if not hasattr(queryset, "get"): klass__name = ( klass.__name__ if isinstance(klass, type) else klass.__class__.__name__ ) raise ValueError( "First argument to get_object_or_404() must be a Model, Manager, " "or QuerySet, not '%s'." % klass__name ) try: return queryset.get(*args, **kwargs) except queryset.model.DoesNotExist: raise Http404( # Translators: %s is the name of a model, e.g. "No City matches the # given query." _("No %s matches the given query.") % queryset.model._meta.object_name ) [89c021da]
- The arguments could be: [43549b676beb4430]
- The arguments could be: [43549b676beb4430-2]
- if isinstance(to, Promise): # Expand the lazy instance, as it can cause issues when it is passed # further to some Python functions like urlparse. to = str(to) [c10058f1]
- klass may be a Model, Manager, or QuerySet object. All other passed arguments and keyword arguments are used in the filter() query. """ queryset = _get_queryset(klass) if not hasattr(queryset, "filter"): klass__name = ( klass.__name__ if isinstance(klass, type) else klass.__class__.__name__ ) raise ValueError( "First argument to get_list_or_404() must be a Model, Manager, or " "QuerySet, not '%s'." % klass__name ) obj_list = list(queryset.filter(*args, **kwargs)) if not obj_list: raise Http404( _("No %s matches the given query.") % queryset.model._meta.object_name ) return obj_list [6dcd0238]
- def resolve_url(to, *args, **kwargs): """ Return a URL appropriate for the arguments passed. [7f2be102]

## All facts

- [407996f9] klass may be a Model, Manager, or QuerySet object. All other passed arguments and keyword arguments are used in the get() query.
- [9522a59d] """ This module collects helper functions and classes that "span" multiple levels of MVC. In other words, these functions/classes introduce controlled coupling for convenience's sake. """
- [1f0a5573] async def aget_list_or_404(klass, *args, **kwargs): """See get_list_or_404().""" queryset = _get_queryset(klass) if not hasattr(queryset, "filter"): klass__name = ( klass.__name__ if isinstance(klass, type) else klass.__class__.__name__ ) raise ValueError( "First argument to aget_list_or_404() must be a Model, Manager, or " f"QuerySet, not '{klass__name}'." ) obj_list = [obj async for obj in queryset.filter(*args, **kwargs)] if not obj_list: raise Http404( _("No %s matches the given query.") % queryset.model._meta.object_name ) return obj_list
- [5ec63dad] async def aget_object_or_404(klass, *args, **kwargs): """See get_object_or_404().""" queryset = _get_queryset(klass) if not hasattr(queryset, "aget"): klass__name = ( klass.__name__ if isinstance(klass, type) else klass.__class__.__name__ ) raise ValueError( "First argument to aget_object_or_404() must be a Model, Manager, or " f"QuerySet, not '{klass__name}'." ) try: return await queryset.aget(*args, **kwargs) except queryset.model.DoesNotExist: raise Http404( _("No %s matches the given query.") % queryset.model._meta.object_name )
- [ecd16a25] def _get_queryset(klass): """ Return a QuerySet or a Manager. Duck typing in action: any class with a `get()` method (for get_object_or_404) or a `filter()` method (for get_list_or_404) might do the job. """ # If it is a model class or anything else with ._default_manager if hasattr(klass, "_default_manager"): return klass._default_manager.all() return klass
- [8a6b5fc0] def get_list_or_404(klass, *args, **kwargs): """ Use filter() to return a list of objects, or raise an Http404 exception if the list is empty.
- [2be8296b] def get_object_or_404(klass, *args, **kwargs): """ Use get() to return an object, or raise an Http404 exception if the object does not exist.
- [4c568434] def redirect( to, *args, permanent=False, preserve_request=False, max_length=MAX_URL_REDIRECT_LENGTH, **kwargs, ): """ Return an HttpResponseRedirect to the appropriate URL for the arguments passed.
- [935c0786] def render( request, template_name, context=None, content_type=None, status=None, using=None ): """ Return an HttpResponse whose content is filled with the result of calling django.template.loader.render_to_string() with the passed arguments. """ content = loader.render_to_string(template_name, context, request, using=using) return HttpResponse(content, content_type, status)
- [6772d448] from django.http import ( Http404, HttpResponse, HttpResponsePermanentRedirect, HttpResponseRedirect, ) from django.template import loader from django.urls import NoReverseMatch, reverse from django.utils.functional import Promise from django.utils.http import MAX_URL_REDIRECT_LENGTH from django.utils.translation import gettext as _
