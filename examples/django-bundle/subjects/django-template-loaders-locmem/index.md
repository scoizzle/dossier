# django/template/loaders/locmem

- Subject: django/template/loaders/locmem (id `568b891a-a017-4a8d-a5be-11ed7b3c66d4`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 201 tokens
- Facts shown: 6 facts
- Conflicts: 0
- Gaps: 0

## Facts

- def get_contents(self, origin): try: return self.templates_dict[origin.name] except KeyError: raise TemplateDoesNotExist(origin) [83a572fd]
- def get_template_sources(self, template_name): yield Origin( name=template_name, template_name=template_name, loader=self, ) [0f30bc3b]
- """ Wrapper for loading templates from a plain Python dict. """ [4e57fd04]
- class Loader(BaseLoader): def __init__(self, engine, templates_dict): self.templates_dict = templates_dict super().__init__(engine) [38cb2263]
- from .base import Loader as BaseLoader [ce213ae266df5867-3]
- from django.template import Origin, TemplateDoesNotExist [3605f10c]
