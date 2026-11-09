# django/template/loaders/base

- Subject: django/template/loaders/base (id `d16b50c2-bcf2-42d3-9c9b-74df5e31d85b`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 381 tokens
- Facts shown: 8 of 8
- Conflicts: 0
- Gaps: 0

## Facts

- try: contents = self.get_contents(origin) except TemplateDoesNotExist: tried.append((origin, "Source does not exist")) continue else: return Template( contents, origin, origin.template_name, self.engine, ) [29387d96]
- for origin in self.get_template_sources(template_name): if skip is not None and origin in skip: tried.append((origin, "Skipped to avoid recursion")) continue [ec69d5d1]
- raise TemplateDoesNotExist(template_name, tried=tried) [02ac1c49]
- def get_template(self, template_name, skip=None): """ Call self.get_template_sources() and return a Template object for the first template matching template_name. If skip is provided, ignore template origins in skip. This is used to avoid recursion during template extending. """ tried = [] [e1dea6c8]
- def get_template_sources(self, template_name): """ An iterator that yields possible matching template paths for a template name. """ raise NotImplementedError( "subclasses of Loader must provide a get_template_sources() method" ) [8a66a366]
- def reset(self): """ Reset any state maintained by the loader instance (e.g. cached templates or cached loader modules). """ pass [87743602]
- class Loader: def __init__(self, engine): self.engine = engine [50b422e7]
- from django.template import Template, TemplateDoesNotExist [b60c400e]
