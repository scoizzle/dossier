# django/template/backends/django

- Subject: django/template/backends/django (id `2b5e1287-c7e7-4f69-b98a-a9f50886822b`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1485 tokens
- Facts shown: 27 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [11511e80] def copy_exception(exc, backend=None): """ Create a new TemplateDoesNotExist. Preserve its declared attributes and template debug data but discard __traceback__, __context__, and __cause__ to make this object suitable for keeping around (in a cache, for example). """ backend = backend or exc.backend new = exc.__class__(*exc.args, tried=exc.tried, backend=backend, chain=exc.chain) if hasattr(exc, "template_debug"): new.template_debug = exc.template_debug return new
- [ce5bf657] def get_installed_libraries(): """ Return the built-in template tag libraries and those from installed applications. Libraries are stored in a dictionary where keys are the individual module names, not the full module paths. Example: django.templatetags.i18n is stored as i18n. """ return { module_name: full_name for module_name, full_name in get_template_tag_modules() }
- [13844e41] def get_package_libraries(pkg): """ Recursively yield template tag libraries defined in submodules of a package. """ for entry in walk_packages(pkg.__path__, pkg.__name__ + "."): try: module = import_module(entry[1]) except ImportError as e: raise InvalidTemplateLibrary( "Invalid template library specified. ImportError raised when " "trying to load '%s': %s" % (entry[1], e) ) from e
- [c794524c] def get_template_tag_modules(): """ Yield (module_name, module_path) pairs for all installed template tag libraries. """ candidates = ["django.templatetags"] candidates.extend( f"{app_config.name}.templatetags" for app_config in apps.get_app_configs() )
- [17468425] def reraise(exc, backend): """ Reraise TemplateDoesNotExist while maintaining template debug information. """ new = copy_exception(exc, backend) raise new from exc
- [fa1210c2] from collections import defaultdict from importlib import import_module from pkgutil import walk_packages
- [50a28e34] from django.apps import apps from django.conf import settings from django.core.checks import Error, Warning from django.template import TemplateDoesNotExist from django.template.context import make_context from django.template.engine import Engine from django.template.library import InvalidTemplateLibrary
