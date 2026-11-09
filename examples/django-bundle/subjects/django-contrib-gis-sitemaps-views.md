# django/contrib/gis/sitemaps/views

- Subject: django/contrib/gis/sitemaps/views (id `8cdd1875-d0e8-4560-8db2-bc6201f55fed`)
- Kind: subject
- Budget: 1200 tokens
- Used: 581 tokens
- Facts shown: 8 of 8
- Conflicts: 0
- Gaps: 0

## Facts

- # Getting the render function and rendering to the correct. if compress: render = render_to_kmz else: render = render_to_kml return render("gis/kml/placemarks.kml", {"places": placemarks}) [ed507a31]
- The field name must be that of a geographic field. """ placemarks = [] try: klass = apps.get_model(label, model) except LookupError: raise Http404( 'You must supply a valid app label and module name. Got "%s.%s"' % (label, model) ) [eb1fe149]
- connection = connections[using] [9acb7691]
- if connection.features.has_AsKML_function: # Database will take care of transformation. placemarks = klass._default_manager.using(using).annotate(kml=AsKML(field_name)) else: # If the database offers no KML method, we use the `kml` # attribute of the lazy geometry instead. placemarks = [] if connection.features.has_Transform_function: qs = klass._default_manager.using(using).annotate( **{"%s_4326" % field_name: Transform(field_name, 4326)} ) field_name += "_4326" else: qs = klass._default_manager.using(using).all() for mod in qs: mod.kml = getattr(mod, field_name).kml placemarks.append(mod) [0af8143d]
- if field_name: try: field = klass._meta.get_field(field_name) if not isinstance(field, GeometryField): raise FieldDoesNotExist except FieldDoesNotExist: raise Http404("Invalid geometry field.") [154c6146]
- def kml(request, label, model, field_name=None, compress=False, using=DEFAULT_DB_ALIAS): """ This view generates KML for the given app label, model, and field name. [9048dd1c]
- def kmz(request, label, model, field_name=None, using=DEFAULT_DB_ALIAS): """ Return KMZ for the given app label, model, and field name. """ return kml(request, label, model, field_name, compress=True, using=using) [56c8af98]
- from django.apps import apps from django.contrib.gis.db.models import GeometryField from django.contrib.gis.db.models.functions import AsKML, Transform from django.contrib.gis.shortcuts import render_to_kml, render_to_kmz from django.core.exceptions import FieldDoesNotExist from django.db import DEFAULT_DB_ALIAS, connections from django.http import Http404 [40878ffd]
