# django/template/__init__

- Subject: django/template/__init__ (id `6a73cb16-0e19-4b7c-8742-b3c0ef0c62d2`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 687 tokens
- Facts shown: 22 facts
- Conflicts: 0
- Gaps: 0

## Facts

- """ [d346d78f8c109f45-4]
- """ Django's support for templates. [107ca90c]
- # Django Template Language [c1159d5d]
- # Import the .autoreload module to trigger the registrations of signals. from . import autoreload # NOQA isort:skip [52466594]
- # Library management from .library import Library # NOQA isort:skip [9ccd48af]
- # Multiple Template Engines [c03f80a3]
- # Public exceptions from .base import VariableDoesNotExist # NOQA isort:skip from .context import Context, ContextPopException, RequestContext # NOQA isort:skip from .exceptions import TemplateDoesNotExist, TemplateSyntaxError # NOQA isort:skip [05a83d4c]
- # Template parts from .base import ( # NOQA isort:skip Node, NodeList, Origin, PartialTemplate, Template, Variable, ) [3ae1fe96]
- - django.template.backends.* - django.template.loader - django.template.response [4a24a43b]
- - django.template.base - django.template.context - django.template.context_processors - django.template.loaders.* - django.template.debug - django.template.defaultfilters - django.template.defaulttags - django.template.engine - django.template.loader_tags - django.template.smartif [d50b687f]
- - django.template.utils [4a08e21c]
- 1. Multiple Template Engines: support for pluggable template backends, built-in backends and backend-independent APIs 2. Django Template Language: Django's own template engine, including its built-in loaders, context processors, tags and filters. [7140fbd1]
- Django Template Language: [1beee4d2]
- Here's a breakdown of which modules belong to which subsystem. [3ff27bb7]
- Ideally these subsystems would be implemented in distinct packages. However keeping them together made the implementation of Multiple Template Engines less disruptive . [cef4016f]
- Multiple Template Engines: [eecb612f]
- Shared: [b0727b0d]
- The django.template namespace contains two independent subsystems: [34d0c131]
- __all__ += ("Template", "Context", "RequestContext") [b7c67165]
- __all__ = ("Engine", "engines") [1dd3840c]
- engines = EngineHandler() [ee55cc0f]
- from .engine import Engine from .utils import EngineHandler [cd316115]
