# docs/ref/forms/renderers

- Subject: docs/ref/forms/renderers (id `c75d7aff-c2f9-4b01-b125-0e04e121bab2`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 32 of 79
- Conflicts: 0
- Gaps: 0

## Facts

- Defaults to :class:`.BoundField` class. [fbb61721]
- Defaults to ``"django/forms/div.html"`` template. [a02b3f6c]
- Defaults to ``"django/forms/field.html"`` [ab02d1d1]
- Renders the given template, or raises :exc:`~django.template.TemplateDoesNotExist`. [e8f15989]
- Subclasses must implement this method with the appropriate template finding logic. [79c7cc2f]
- The default class used to represent form fields across the project. [6620446f]
- The default name of the template to use to render a form. [ded5c582]
- The default name of the template to use to render a formset. [b23f93d3]
- The default name of the template used to render a ``BoundField``. [83b62e19]
- This can be customized further using :attr:`.Form.bound_field_class` for per-form overrides, or :attr:`.Field.bound_field_class` for per-field overrides. [6df0c01b]
- .. attribute:: bound_field_class [0a402591]
- .. attribute:: field_template_name [ed51373d]
- .. attribute:: form_template_name [018d4b74]
- .. attribute:: formset_template_name [20c11cbe]
- .. method:: get_template(template_name) [c62abaf1]
- .. method:: render(template_name, context, request=None) [66cd0087]
- The base class for the built-in form renderers. [2b78e0b6]
- django.__path__[0] + "/forms/templates" # or '/forms/jinja2' [2b5c5c0e]
- import django [79e3e2e9]
- * Adding the built-in templates directory in :setting:`DIRS <TEMPLATES-DIRS>` of one of your template engines. To generate that path:: [3f797444]
- * Widgets can specify custom template names. * Forms and widgets can specify custom renderer classes. * A widget's template can be overridden by a project. (Reusable applications typically shouldn't override built-in templates because they might conflict with a project's custom templates.) [077ba0bd]
- * ``'django.forms'`` in :setting:`INSTALLED_APPS` and at least one engine with :setting:`APP_DIRS=True <TEMPLATES-APP_DIRS>`. [0369cb41]
- * ``field``: The :class:`~django.forms.BoundField`. [1598f540]
- * ``form``: The bound form. * ``fields``: All bound fields, except the hidden fields. * ``hidden_fields``: All hidden bound fields. * ``errors``: All non field related or hidden field related form errors. [7143423fb86e9d50-2]
- * ``formset``: The formset instance. [843782cc]
- * ``name`` * ``value`` * ``attrs`` * ``is_hidden`` * ``template_name`` [a89281b1]
- .. _built-in-template-form-renderers: [9a263dbd]
- .. _low-level-widget-render-api: [a22d372d]
- .. _overriding-built-in-field-templates: [d09d8e37]
- .. _overriding-built-in-form-templates: [34215e56]
- .. _overriding-built-in-formset-templates: [57cbe67f]
- .. _overriding-built-in-widget-templates: [8de1fb04]

## Beyond the budget

38 more facts did not fit in the budget: [e10576e7] [375dd3dd] [be084dd9] [d23fb6e1] [99ab8e6a] [da31265f] [ec1c5bdc] [18e4d2ce] [b4ce8ec3] [f5ea223a] [a54bc57c] [e61424a0] [b65ab2ec] [c1d56d7a] [d59de660] [8b3118ab] [08c6675b] [26b33c52] [9f190254] [9ab73f13] [275eec45] [a08d9983] [361dc25c] [ab9bc115] [0f294627] [0a9f6ac1] [9f61cbf9] [7a1bd932] [92ce4ef8] [95313781] [8c93e56b] [8eda066c] [6f741917] [43f67373] [4671bcf7] [b25a73ef] [f18e6921] [12925910]
