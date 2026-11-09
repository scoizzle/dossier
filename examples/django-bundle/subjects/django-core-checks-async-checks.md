# django/core/checks/async_checks

- Subject: django/core/checks/async_checks (id `19ffa416-111d-41bc-9abb-7c6b4415908a`)
- Kind: subject
- Budget: 1200 tokens
- Used: 135 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- @register(Tags.async_support, deploy=True) def check_async_unsafe(app_configs, **kwargs): if os.environ.get("DJANGO_ALLOW_ASYNC_UNSAFE"): return [E001] return [] [c73eac76]
- E001 = Error( "You should not set the DJANGO_ALLOW_ASYNC_UNSAFE environment variable in " "deployment. This disables async safety protection.", id="async.E001", ) [af270aa2]
- from . import Error, Tags, register [3d70aaa555e17950]
- import os [bbf3e0cdec1c52e4-3]
