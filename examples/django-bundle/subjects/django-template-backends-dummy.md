# django/template/backends/dummy

- Subject: django/template/backends/dummy (id `84a3eef5-07d9-4b6f-9d67-032461dc3feb`)
- Kind: subject
- Budget: 1200 tokens
- Used: 425 tokens
- Facts shown: 8 of 8
- Conflicts: 0
- Gaps: 0

## Facts

- def __init__(self, params): params = params.copy() options = params.pop("OPTIONS").copy() if options: raise ImproperlyConfigured("Unknown options: {}".format(", ".join(options))) super().__init__(params) [f17ab9ab]
- def from_string(self, template_code): return Template(template_code) [220cea0b]
- def get_template(self, template_name): tried = [] for template_file in self.iter_template_filenames(template_name): try: with open(template_file, encoding="utf-8") as fp: template_code = fp.read() except FileNotFoundError: tried.append( ( Origin(template_file, template_name, self), "Source does not exist", ) ) else: return Template(template_code) raise TemplateDoesNotExist(template_name, tried=tried, backend=self) [ea775295]
- class Template(string.Template): def render(self, context=None, request=None): if context is None: context = {} else: context = {k: conditional_escape(v) for k, v in context.items()} if request is not None: context["csrf_input"] = csrf_input_lazy(request) context["csrf_token"] = csrf_token_lazy(request) return self.safe_substitute(context) [658285f4]
- class TemplateStrings(BaseEngine): app_dirname = "template_strings" [0d6f9f56]
- from .base import BaseEngine from .utils import csrf_input_lazy, csrf_token_lazy [6dc76df570a737ae]
- from django.core.exceptions import ImproperlyConfigured from django.template import Origin, TemplateDoesNotExist from django.utils.html import conditional_escape [516ff6e4]
- import string [bd9eab00941d6afe-2]
