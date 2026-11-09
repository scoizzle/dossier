# django/views/decorators/csp

- Subject: django/views/decorators/csp (id `8c0e38b9-0d07-41aa-b51a-db43e97db93e`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 369 tokens
- Facts shown: 9 facts
- Conflicts: 0
- Gaps: 0

## Facts

- @wraps(view_func) def _wrapped_sync_view(request, *args, **kwargs): response = view_func(request, *args, **kwargs) setattr(response, config_attr_name, config_attr_value) return response [c9f12aae]
- if iscoroutinefunction(view_func): return _wrapped_async_view return _wrapped_sync_view [a20155f8]
- def decorator(view_func): @wraps(view_func) async def _wrapped_async_view(request, *args, **kwargs): response = await view_func(request, *args, **kwargs) setattr(response, config_attr_name, config_attr_value) return response [bce66ac0]
- if not isinstance(config_attr_value, dict): raise TypeError("CSP config should be a mapping.") [ead1d919]
- return decorator [021b5df2d691cbd2-7]
- def _make_csp_decorator(config_attr_name, config_attr_value): """General CSP override decorator factory.""" [6ad2c6d6]
- def csp_override(config): """Override the Content-Security-Policy header for a view.""" return _make_csp_decorator("_csp_config", config) [78597fc0]
- def csp_report_only_override(config): """Override the Content-Security-Policy-Report-Only header for a view.""" return _make_csp_decorator("_csp_ro_config", config) [e2dd96e7]
- from functools import wraps from inspect import iscoroutinefunction [7391182f29420620-4]
