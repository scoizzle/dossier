# django/contrib/gis/admin/options

- Subject: django/contrib/gis/admin/options (id `19ae5382-1887-46f1-9532-b5fc59599603`)
- Kind: subject
- Budget: 1200 tokens
- Used: 192 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- def formfield_for_dbfield(self, db_field, request, **kwargs): if isinstance(db_field, models.GeometryField) and ( db_field.dim < 3 or self.gis_widget.supports_3d ): kwargs["widget"] = self.gis_widget(**self.gis_widget_kwargs) return db_field.formfield(**kwargs) else: return super().formfield_for_dbfield(db_field, request, **kwargs) [28ff4337]
- class GISModelAdmin(GeoModelAdminMixin, ModelAdmin): pass [ec8bd171]
- class GeoModelAdminMixin: gis_widget = OSMWidget gis_widget_kwargs = {} [fd6e298e]
- from django.contrib.admin import ModelAdmin from django.contrib.gis.db import models from django.contrib.gis.forms import OSMWidget [1e9f1383]
