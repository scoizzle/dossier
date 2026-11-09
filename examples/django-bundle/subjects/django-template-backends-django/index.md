# django/template/backends/django

- Subject: django/template/backends/django (id `2c1e1980-1313-46fc-b5f1-daf4eb70d682`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 20 of 27
- Conflicts: 0
- Gaps: 0

## Facts

- errors = [] [ea5291ead597635f-3]
- for library_name, items in libraries.items(): if len(items) > 1: items = ", ".join(repr(item) for item in sorted(items)) errors.append( Warning( f"{library_name!r} is used for multiple template tag modules: " f"{items}", obj=self, id="templates.W003", ) ) [016bdd4c]
- for module_name, module_path in get_template_tag_modules(): libraries[module_name].add(module_path) [c11ce88a]
- for module_name, module_path in self.engine.libraries.items(): libraries[module_name].add(module_path) [6870f831]
- if hasattr(module, "register"): yield entry[1] [592fc134]
- if hasattr(pkg, "__path__"): for name in get_package_libraries(pkg): yield name.removeprefix(candidate).lstrip("."), name [32109853]
- return errors [b2c21f6739c80fd1-10]
- @property def origin(self): return self.template.origin [cb84c9fd]
- def __init__(self, params): params = params.copy() options = params.pop("OPTIONS").copy() options.setdefault("autoescape", True) options.setdefault("debug", settings.DEBUG) options.setdefault("file_charset", "utf-8") libraries = options.get("libraries", {}) options["libraries"] = self.get_templatetag_libraries(libraries) super().__init__(params) self.engine = Engine(self.dirs, self.app_dirs, **options) [a4cefe6e]
- def _check_for_template_tags_with_the_same_name(self): libraries = defaultdict(set) [f15fe9cf]
- def _check_string_if_invalid_is_string(self): value = self.engine.string_if_invalid if not isinstance(value, str): return [ Error( "'string_if_invalid' in TEMPLATES OPTIONS must be a string but " "got: %r (%s)." % (value, type(value)), obj=self, id="templates.E002", ) ] return [] [401f1a6b]
- def check(self, **kwargs): return [ *self._check_string_if_invalid_is_string(), *self._check_for_template_tags_with_the_same_name(), ] [32cd69f0]
- def from_string(self, template_code): return Template(self.engine.from_string(template_code), self) [6229d5c5]
- def get_template(self, template_name): try: return Template(self.engine.get_template(template_name), self) except TemplateDoesNotExist as exc: reraise(exc, self) [80eeef8a]
- def get_templatetag_libraries(self, custom_libraries): """ Return a collation of template tag libraries from installed applications and the supplied custom_libraries argument. """ libraries = get_installed_libraries() libraries.update(custom_libraries) return libraries [54518896]
- def render(self, context=None, request=None): context = make_context( context, request, autoescape=self.backend.engine.autoescape ) try: return self.template.render(context) except TemplateDoesNotExist as exc: reraise(exc, self.backend) [dde167a6]
- for candidate in candidates: try: pkg = import_module(candidate) except ImportError: # No templatetags package defined. This is safe to ignore. continue [e6399762]
- class DjangoTemplates(BaseEngine): app_dirname = "templates" [5c9bf367]
- class Template: def __init__(self, template, backend): self.template = template self.backend = backend [fbb42c46]
- from .base import BaseEngine [73d57bba]

## Beyond the budget

7 more facts did not fit in the budget: [11511e80] [ce5bf657] [13844e41] [c794524c] [17468425] [fa1210c2] [50a28e34]
