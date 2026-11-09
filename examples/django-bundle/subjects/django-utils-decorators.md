# django/utils/decorators

- Subject: django/utils/decorators (id `b2916e7d-bf05-41b9-82c4-c58ff78ba600`)
- Kind: subject
- Budget: 1200 tokens
- Used: 886 tokens
- Facts shown: 17 of 37
- Conflicts: 0
- Gaps: 0

## Facts

- def callback(response): return middleware.process_response(request, response) [4dea0535]
- response.add_post_render_callback(callback) else: if hasattr(middleware, "process_response"): return middleware.process_response(request, response) return response [7b568799]
- return _post_process_request(request, response) [a145ae7d740fdefa]
- try: response = await view_func(request, *args, **kwargs) except Exception as e: result = _process_exception(request, e) if result is not None: return result [50e4bb6a]
- async def _view_wrapper(request, *args, **kwargs): result = _pre_process_request(request, *args, **kwargs) if result is not None: return result [ca163a16]
- def _post_process_request(request, response): if hasattr(response, "render") and callable(response.render): if hasattr(middleware, "process_template_response"): response = middleware.process_template_response( request, response ) # Defer running of process_response until after the # template has been rendered: if hasattr(middleware, "process_response"): [5520e971]
- def _pre_process_request(request, *args, **kwargs): if hasattr(middleware, "process_request"): result = middleware.process_request(request) if result is not None: return result if hasattr(middleware, "process_view"): result = middleware.process_view(request, view_func, args, kwargs) if result is not None: return result return None [4bd3653a]
- def _process_exception(request, exception): if hasattr(middleware, "process_exception"): result = middleware.process_exception(request, exception) if result is not None: return result raise [44c43048]
- else: [6ad07797f4838346-15]
- if iscoroutinefunction(view_func): [010008b1ac80cb06-2]
- return wraps(view_func)(_view_wrapper) [87be1c7b56ac3a0b-2]
- @cache_page(3600) def my_view(request): # ... """ return make_middleware_decorator(middleware_class) [94ddd518]
- cache_page = decorator_from_middleware_with_args(CacheMiddleware) # ... [10f78d1f]
- return _decorator [5a6b3e7c887d3755-2]
- # 'obj' can be a class or a function. If 'obj' is a function at the time it # is passed to _dec, it will eventually be a method of the class it is # defined on. If 'obj' is a class, the 'name' is required to be the name # of the method that will be decorated. def _dec(obj): if not isinstance(obj, type): return _multi_decorate(decorator, obj) if not (name and hasattr(obj, name)): raise ValueError( "The keyword argument `name` must be the name of a method " "of the decorated class: %s. Got '%s' instead." % (obj, name) ) method = getattr(obj, name) if not callable(method): raise TypeError( "Cannot decorate '%s' as it isn't a callable attribute of " "%s (%s)." % (name, obj, method) ) _wrapper = _multi_decorate(decorator, method) setattr(obj, name, _wrapper) return obj [e321031c]
- # Copy any attributes that a decorator adds to the function it decorates. for dec in decorators: _update_method_wrapper(_wrapper, dec) # Preserve any existing attributes of 'method', including the name. update_wrapper(_wrapper, method) [885f2427]
- if iscoroutinefunction(method): markcoroutinefunction(_wrapper) [133a244c]

## Beyond the budget

17 more facts did not fit in the budget: [04a7471c] [32547afb] [f93bc7e3] [18148b5e] [185de31c] [e43dbaf7] [fbab8376] [af9ec4ad] [5e0c43b5] [255505ee] [07980b9c] [3f0e7eae] [44867ad6] [a112d04c] [c3015287] [f4d2fb2a] [dade3b57]
