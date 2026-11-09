# django/template/exceptions

- Subject: django/template/exceptions (id `e241f052-036c-4610-b8ec-3286696b6e8b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 374 tokens
- Facts shown: 8 of 8
- Conflicts: 0
- Gaps: 0

## Facts

- backend The template backend class used when raising this exception. [7088c67a]
- chain A list of intermediate TemplateDoesNotExist exceptions. This is used to encapsulate multiple exceptions when loading templates from multiple engines. """ [ad36aa48]
- def __init__(self, msg, tried=None, backend=None, chain=None): self.backend = backend if tried is None: tried = [] self.tried = tried if chain is None: chain = [] self.chain = chain super().__init__(msg) [cd8b2818]
- pass [7655780f0d17b825-53]
- tried A list of sources that were tried when finding the template. This is formatted as a list of tuples containing (origin, status), where origin is an Origin object or duck type and status is a string with the reason the template wasn't found. [8b9beb77]
- """ This module contains generic exceptions used by template backends. Although, due to historical reasons, the Django template language also internally uses these exceptions, other exceptions specific to the DTL should not be added here. """ [5b4289a0]
- class TemplateDoesNotExist(Exception): """ The exception used when a template does not exist. Optional arguments: [a890774c]
- class TemplateSyntaxError(Exception): """ The exception used for syntax errors during parsing or rendering. """ [fb4651e6]
