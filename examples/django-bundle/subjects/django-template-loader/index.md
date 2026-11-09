# django/template/loader

- Subject: django/template/loader (id `700cff66-c186-4399-aa01-501e4a63bb8f`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 564 tokens
- Facts shown: 12 facts
- Conflicts: 0
- Gaps: 0

## Facts

- Raise TemplateDoesNotExist if no such template exists. """ chain = [] engines = _engine_list(using) for engine in engines: try: return engine.get_template(template_name) except TemplateDoesNotExist as e: chain.append(e) [c0266803]
- Raise TemplateDoesNotExist if no such template exists. """ if isinstance(template_name_list, str): raise TypeError( "select_template() takes an iterable of template names but got a " "string: %r. Use get_template() if you want to load a single " "template by name." % template_name_list ) [5f833a11]
- Try names in order and return the first template found. [aef947c3]
- chain = [] engines = _engine_list(using) for template_name in template_name_list: for engine in engines: try: return engine.get_template(template_name) except TemplateDoesNotExist as e: chain.append(e) [8742291d]
- if template_name_list: raise TemplateDoesNotExist(", ".join(template_name_list), chain=chain) else: raise TemplateDoesNotExist("No template names provided") [0da19541]
- raise TemplateDoesNotExist(template_name, chain=chain) [a9d6166e]
- template_name may be a string or a list of strings. """ if isinstance(template_name, (list, tuple)): template = select_template(template_name, using=using) else: template = get_template(template_name, using=using) return template.render(context, request) [92634d15]
- def _engine_list(using=None): return engines.all() if using is None else [engines[using]] [2d674c9c]
- def get_template(template_name, using=None): """ Load and return a template for the given name. [c11637c3]
- def render_to_string(template_name, context=None, request=None, using=None): """ Load a template and render it with a context. Return a string. [45eb2e32]
- def select_template(template_name_list, using=None): """ Load and return a template for one of the given names. [83046bc9]
- from . import engines from .exceptions import TemplateDoesNotExist [47d47b8a]
