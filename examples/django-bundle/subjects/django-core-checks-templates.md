# django/core/checks/templates

- Subject: django/core/checks/templates (id `fa56e053-84ad-4e62-982b-302384392791`)
- Kind: subject
- Budget: 1200 tokens
- Used: 98 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- errors = [] for engine in engines.all(): errors.extend(engine.check()) return errors [087b405e]
- @register(Tags.templates) def check_templates(app_configs, **kwargs): """Check all registered template engines.""" from django.template import engines [914a4f79]
- from . import Tags, register [5fbdafc2f3b1ddcb-2]
