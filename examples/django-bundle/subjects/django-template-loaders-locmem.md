# django/template/loaders/locmem

- Subject: django/template/loaders/locmem (id `20ca9079-bb84-4a66-8b82-5ebf8e2b1680`)
- Kind: subject
- Budget: 1200 tokens
- Used: 201 tokens
- Facts shown: 6 of 6
- Conflicts: 0
- Gaps: 0

## Facts

- def get_contents(self, origin): try: return self.templates_dict[origin.name] except KeyError: raise TemplateDoesNotExist(origin) [83a572fd]
- def get_template_sources(self, template_name): yield Origin( name=template_name, template_name=template_name, loader=self, ) [0f30bc3b]
- """ Wrapper for loading templates from a plain Python dict. """ [4e57fd04]
- class Loader(BaseLoader): def __init__(self, engine, templates_dict): self.templates_dict = templates_dict super().__init__(engine) [38cb2263]
- from .base import Loader as BaseLoader [ce213ae266df5867-3]
- from django.template import Origin, TemplateDoesNotExist [3605f10c]
