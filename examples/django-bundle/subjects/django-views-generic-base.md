# django/views/generic/base

- Subject: django/views/generic/base (id `bd841500-3814-4f2b-9dd7-3af17a1784ee`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 16 of 45
- Conflicts: 0
- Gaps: 0

## Facts

- async def func(): return response [2862628cb49f7cae]
- return func() else: return response [b1a0bda6827dbd27]
- # Mark the callback if the view class is async. if cls.view_is_async: markcoroutinefunction(view) [8d0a0d7b]
- # __name__ and __qualname__ are intentionally left unchanged as # view_class should be used to robustly determine the name of the view # instead. view.__doc__ = cls.__doc__ view.__module__ = cls.__module__ view.__annotations__ = cls.dispatch.__annotations__ # Copy possible attributes set by decorators, e.g. @csrf_exempt, from # the dispatch method. view.__dict__.update(cls.dispatch.__dict__) [b6172a8b]
- Pass response_kwargs to the constructor of the response class. """ response_kwargs.setdefault("content_type", self.content_type) return self.response_class( request=self.request, template=self.get_template_names(), context=context, using=self.template_engine, **response_kwargs, ) [ec8421cb]
- args = self.request.META.get("QUERY_STRING", "") if args and self.query_string: if urlparse(url).query: url = f"{url}&{args}" else: url = f"{url}?{args}" return url [808da7ad]
- def view(request, *args, **kwargs): self = cls(**initkwargs) self.setup(request, *args, **kwargs) if not hasattr(self, "request"): raise AttributeError( "%s instance has no 'request' attribute. Did you override " "setup() and forget to call super()?" % cls.__name__ ) return self.dispatch(request, *args, **kwargs) [ab3caf4a]
- if self.view_is_async: [2d6f132acb0c3e3f]
- return view [3c8df977]
- view.view_class = cls view.view_initkwargs = initkwargs [642f13d8]
- @classonlymethod def as_view(cls, **initkwargs): """Main entry point for a request-response process.""" for key in initkwargs: if key in cls.http_method_names: raise TypeError( "The method name %s is not accepted as a keyword argument " "to %s()." % (key, cls.__name__) ) if not hasattr(cls, key): raise TypeError( "%s() received an invalid keyword %r. as_view " "only accepts arguments that are already " "attributes of the class." % (cls.__name__, key) ) [b82bef97]
- @classproperty def view_is_async(cls): handlers = [ getattr(cls, method) for method in cls.http_method_names if (method != "options" and hasattr(cls, method)) ] if not handlers: return False is_async = iscoroutinefunction(handlers[0]) if not all(iscoroutinefunction(h) == is_async for h in handlers[1:]): raise ImproperlyConfigured( f"{cls.__qualname__} HTTP handlers must either be all sync or all " "async." ) return is_async [aa4f126b]
- def __init__(self, **kwargs): """ Constructor. Called in the URLconf; can contain helpful extra keyword arguments, and other things. """ # Go through keyword arguments, and either save their values to our # instance, or raise an error. for key, value in kwargs.items(): setattr(self, key, value) [9b2ed746]
- def _allowed_methods(self): return [m.upper() for m in self.http_method_names if hasattr(self, m)] [ffecea1c]
- def delete(self, request, *args, **kwargs): return self.get(request, *args, **kwargs) [9fdff961]
- def get(self, request, *args, **kwargs): context = self.get_context_data(**kwargs) return self.render_to_response(context) [3d77e1b0]

## Beyond the budget

26 more facts did not fit in the budget: [ca6796b2] [2c70017e] [dc19a141] [e4cac88d] [e41d8d56] [04f75311] [352a1005] [a428a7b8] [81911099] [b5309839] [7c23142a] [b57940f9] [0efbe757] [79c59a32] [eaf62ffe] [6d2d9f93] [e7728b99] [d9f385f0] [010cf8c8] [a4c8a383] [80998189] [f67a1742] [c080a787] [5b65050b] [908e9049] [a783acd9b0048dcc-3]
