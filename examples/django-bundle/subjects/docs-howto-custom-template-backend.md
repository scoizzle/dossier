# docs/howto/custom-template-backend

- Subject: docs/howto/custom-template-backend (id `f1d09296-38aa-4df3-b5a6-646d4875b04c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 22 of 45
- Conflicts: 0
- Gaps: 0

## Facts

- self.engine = foobar.Engine(**options) [d027913c]
- def __init__(self, params): params = params.copy() options = params.pop("OPTIONS").copy() super().__init__(params) [a10f52d9]
- def from_string(self, template_code): try: return Template(self.engine.from_string(template_code)) except foobar.TemplateCompilationFailed as exc: raise TemplateSyntaxError(exc.args) [3dff4884]
- def get_template(self, template_name): try: return Template(self.engine.get_template(template_name)) except foobar.TemplateNotFound as exc: raise TemplateDoesNotExist(exc.args, backend=self) except foobar.TemplateCompilationFailed as exc: raise TemplateSyntaxError(exc.args) [5f10d223]
- def render(self, context=None, request=None): if context is None: context = {} if request is not None: context["request"] = request context["csrf_input"] = csrf_input_lazy(request) context["csrf_token"] = csrf_token_lazy(request) return self.template.render(context) [7c07c377]
- class FooBar(BaseEngine): # Name of the subdirectory containing the templates for this engine # inside an installed application. app_dirname = "foobar" [e877c46c]
- class Template: def __init__(self, template): self.template = template [a367beec]
- from django.template import TemplateDoesNotExist, TemplateSyntaxError from django.template.backends.base import BaseEngine from django.template.backends.utils import csrf_input_lazy, csrf_token_lazy [44f89f2d]
- import foobar [044f851f]
- { "name": "/path/to/template.html", "message": "Invalid block tag: 'syntax'", "source_lines": [ (1, "some\n"), (2, "lines\n"), (3, "before\n"), (4, "Hello {% syntax error %} {{ world }}\n"), (5, "some\n"), (6, "lines\n"), (7, "after\n"), (8, ""), ], "line": 4, "before": "Hello ", "during": "{% syntax error %}", "after": " {{ world }}\n", "total": 9, "bottom": 9, "top": 1, } [24afe5fe]
- * ``'after'``: The content on the error line after the token that raised the error. [e2ce7560]
- * ``'before'``: The content on the error line before the token that raised the error. [83532962]
- * ``'bottom'``: The line number where ``source_lines`` ends. [2432e80d]
- * ``'during'``: The token that raised the error. [21deaf7e]
- * ``'line'``: The line number on which the exception occurred. [bfa8c4a7]
- * ``'loader_name'``: An optional string identifying the function or class used to load the template, e.g. ``django.template.loaders.filesystem.Loader``. [48177218]
- * ``'message'``: The exception message. [999d76cf]
- * ``'name'``: The full path to the template. [904bdb94]
- * ``'name'``: The name of the template in which the exception occurred. [40d9eb3a]
- * ``'source_lines'``: The lines before, after, and including the line the exception occurred on. This is for context, so it shouldn't contain more than 20 lines or so. [74728655]
- * ``'template_name'``: The relative path to the template as passed into the template loading methods. [2c665292]
- .. _template-debug-integration: [59f1fbb7]

## Beyond the budget

23 more facts did not fit in the budget: [0a30aecb] [2d383f6c] [83c200ce] [27149eb3] [a60c6519] [b8f57c26] [0b8caf27] [061f87cd] [72a6d2a2] [6bed4883] [4f80dae6] [a874da81] [1c516e10] [8bc9d748] [5757a7ec] [026729b3] [27ce9510] [e49f7d7b] [271b9c9e] [b86df535] [c45fe32b] [5c992142] [cad8ff41]
