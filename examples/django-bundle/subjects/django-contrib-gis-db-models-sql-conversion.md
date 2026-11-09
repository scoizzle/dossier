# django/contrib/gis/db/models/sql/conversion

- Subject: django/contrib/gis/db/models/sql/conversion (id `93e0e09f-9727-498b-b9c6-145658650592`)
- Kind: subject
- Budget: 1200 tokens
- Used: 636 tokens
- Facts shown: 14 of 15
- Conflicts: 0
- Gaps: 0

## Facts

- def __init__(self, geo_field): super().__init__() self.geo_field = geo_field [82d0046d99ea9c75]
- def from_db_value(self, value, expression, connection): if value is None: return # If the database returns a Decimal, convert it to a float as expected # by the Python geometric objects. if isinstance(value, Decimal): value = float(value) # If the units are known, convert value into area measure. area_att = connection.ops.get_area_att_for_field(self.geo_field) return Area(**{area_att: value}) if area_att else value [d4423210]
- def from_db_value(self, value, expression, connection): if value is None: return distance_att = connection.ops.get_distance_att_for_field(self.geo_field) return Distance(**{distance_att: value}) if distance_att else value [72c57713]
- def get_db_prep_value(self, value, connection, prepared=False): if not isinstance(value, Distance): return value distance_att = connection.ops.get_distance_att_for_field(self.geo_field) if not distance_att: raise ValueError( "Distance measure is supplied, but units are unknown for result." ) return getattr(value, distance_att) [a5944f9d]
- def get_db_prep_value(self, value, connection, prepared=False): if value is None: return area_att = connection.ops.get_area_att_for_field(self.geo_field) return getattr(value, area_att) if area_att else value [934ea7d7]
- def get_internal_type(self): return "AreaField" [10ce063b]
- def get_internal_type(self): return "DistanceField" [98c78a1c]
- def get_prep_value(self, value): if isinstance(value, Distance): return value return super().get_prep_value(value) [fc59f8a0]
- def get_prep_value(self, value): if not isinstance(value, Area): raise ValueError("AreaField only accepts Area measurement objects.") return value [cc174c27]
- """ This module holds simple classes to convert geospatial values from the database. """ [882850f8]
- class AreaField(models.FloatField): "Wrapper for Area values." [8e1f0954]
- class DistanceField(models.FloatField): "Wrapper for Distance values." [d505c74a]
- from decimal import Decimal [2f76b6f177b243e2-2]
- from django.contrib.gis.measure import Area, Distance from django.db import models [37b7d6ba]
