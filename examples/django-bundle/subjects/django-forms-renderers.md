# django/forms/renderers

- Subject: django/forms/renderers (id `8c176054-3a87-4ea6-b5a7-4191b506db2e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 580 tokens
- Facts shown: 15 of 16
- Conflicts: 0
- Gaps: 0

## Facts

- return Jinja2 [049b4163]
- @cached_property def backend(self): from django.template.backends.jinja2 import Jinja2 [f2c708ab]
- @cached_property def engine(self): return self.backend( { "APP_DIRS": True, "DIRS": [Path(__file__).parent / self.backend.app_dirname], "NAME": "djangoforms", "OPTIONS": {}, } ) [e9fc18c7]
- backend = DjangoTemplates [76008388]
- bound_field_class = None [a1f57b51ea7de95b-2]
- def get_template(self, template_name): raise NotImplementedError("subclasses must implement get_template()") [f19df172]
- def get_template(self, template_name): return get_template(template_name) [348b359b]
- def render(self, template_name, context, request=None): template = self.get_template(template_name) return template.render(context, request=request).strip() [844865d4]
- @functools.lru_cache def get_default_renderer(): renderer_class = import_string(settings.FORM_RENDERER) return renderer_class() [b05778a4]
- class BaseRenderer: form_template_name = "django/forms/div.html" formset_template_name = "django/forms/formsets/div.html" field_template_name = "django/forms/field.html" [b00b5929]
- class DjangoTemplates(EngineMixin, BaseRenderer): """ Load Django templates from the built-in widget templates in django/forms/templates and from apps' 'templates' directory. """ [e854dde9]
- class EngineMixin: def get_template(self, template_name): return self.engine.get_template(template_name) [2189cc17]
- class TemplatesSetting(BaseRenderer): """ Load templates using template.loader.get_template() which is configured based on settings.TEMPLATES. """ [81837a7a]
- from django.conf import settings from django.template.backends.django import DjangoTemplates from django.template.loader import get_template from django.utils.functional import cached_property from django.utils.module_loading import import_string [0966e427]
- import functools from pathlib import Path [8ddb5008]
