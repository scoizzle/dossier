# docs/howto/custom-template-backend

- Subject: docs/howto/custom-template-backend (id `12282781-e2cf-44b6-9cac-23a800772841`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1816 tokens
- Facts shown: 45 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [0a30aecb] * ``'top'``: The line number where ``source_lines`` starts.
- [2d383f6c] * ``'total'``: The number of lines in ``source_lines``.
- [83c200ce] .. _DEP 182: https://github.com/django/deps/blob/main/final/0182-multiple-template-engines.rst
- [27149eb3] .. _template-origin-api:
- [a60c6519] .. _template-postmortem:
- [b8f57c26] .. image:: _images/postmortem.png
- [0b8caf27] .. image:: _images/template-lines.png
- [061f87cd] ========================================== How to implement a custom template backend ==========================================
- [72a6d2a2] Contextual line information ~~~~~~~~~~~~~~~~~~~~~~~~~~~
- [6bed4883] Custom backends ---------------
- [4f80dae6] Custom engines can populate the postmortem by passing the ``backend`` and ``tried`` arguments when raising :exc:`~django.template.TemplateDoesNotExist`. Backends that use the postmortem :ref:`should specify an origin <template-origin-api>` on the template object.
- [a874da81] Custom engines can populate this information by setting a ``template_debug`` attribute on exceptions raised during parsing and rendering. This attribute is a :class:`dict` with the following values:
- [1c516e10] Custom engines can provide their own ``template.origin`` information by creating an object that specifies the following attributes:
- [8bc9d748] Debug integration for custom engines ------------------------------------
- [5757a7ec] Django templates have an :class:`~django.template.base.Origin` object available through the ``template.origin`` attribute. This enables debug information to be displayed in the :ref:`template postmortem <template-postmortem>`, as well as in 3rd-party libraries, like the :pypi:`Django Debug Toolbar <django-debug-toolbar>`.
- [026729b3] Given the above template error, ``template_debug`` would look like::
- [27ce9510] Here's how to implement a custom template backend in order to use another template system. A template backend is a class that inherits ``django.template.backends.base.BaseEngine``. It must implement ``get_template()`` and optionally ``from_string()``. Here's an example for a fictional ``foobar`` template library::
- [e49f7d7b] If an error happens during template parsing or rendering, Django can display the line the error happened on. For example:
- [271b9c9e] Origin API and 3rd-party integration ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
- [b86df535] See `DEP 182`_ for more information.
- [c45fe32b] Template postmortem ~~~~~~~~~~~~~~~~~~~
- [5c992142] The Django debug page has hooks to provide detailed information when a template error arises. Custom template engines can use these hooks to enhance the traceback information that appears to users. The following hooks are available:
- [cad8ff41] The postmortem appears when :exc:`~django.template.TemplateDoesNotExist` is raised. It lists the template engines and loaders that were used when trying to find a given template. For example, if two Django engines are configured, the postmortem will appear like:
