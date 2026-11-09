# django/contrib/gis/management/commands/ogrinspect

- Subject: django/contrib/gis/management/commands/ogrinspect (id `22569302-7192-4611-87c9-7dd759f0ece3`)
- Kind: subject
- Budget: 1200 tokens
- Used: 791 tokens
- Facts shown: 13 of 14
- Conflicts: 0
- Gaps: 0

## Facts

- # Filter options to params accepted by `_ogrinspect` ogr_options = { k: v for k, v in options.items() if k in get_func_args(_ogrinspect) and v is not None } output = [s for s in _ogrinspect(ds, model_name, **ogr_options)] [8e083c4f]
- # Getting the OGR DataSource from the string parameter. try: ds = gdal.DataSource(data_source) except gdal.GDALException as msg: raise CommandError(msg) [006babc4]
- # Returning the output of ogrinspect with the given arguments # and options. from django.contrib.gis.utils.ogrinspect import _ogrinspect, mapping [aa88400f]
- if options["mapping"]: # Constructing the keyword arguments for `mapping`, and # calling it on the data source. kwargs = { "geom_name": options["geom_name"], "layer_key": options["layer_key"], "multi_geom": options["multi_geom"], } mapping_dict = mapping(ds, **kwargs) # This extra legwork is so that the dictionary definition comes # out in the same order as the fields in the model definition. rev_mapping = {v: k for k, v in mapping_dict.items()} output.extend( [ "", "", "# Auto-generated `LayerMapping` dictionary for %s model" % model_name, "%s_mapping = {" % model_name.lower(), ] ) output.extend( " '%s': '%s'," % (rev_mapping[ogr_fld], ogr_fld) for ogr_fld in ds[options["layer_key"]].fields ) output.extend( [ " '%s': '%s'," % (options["geom_name"], mapping_dict[options["geom_name"]]), "}", ] ) return "\n".join(output) [be959e7b]
- def __call__(self, parser, namespace, value, option_string=None): if value.lower() == "true": setattr(namespace, self.dest, True) else: setattr(namespace, self.dest, value.split(",")) [9d7c5e39]
- def __call__(self, parser, namespace, value, option_string=None): try: setattr(namespace, self.dest, int(value)) except ValueError: setattr(namespace, self.dest, value) [c0f99129]
- def handle(self, *args, **options): data_source, model_name = options.pop("data_source"), options.pop("model_name") [bf326a5d]
- requires_system_checks = [] [72e6d136f77918ef]
- class Command(BaseCommand): help = ( "Inspects the given OGR-compatible data source (e.g., a shapefile) and " "outputs\na GeoDjango model with the given model name. For example:\n" " ./manage.py ogrinspect zipcode.shp Zipcode" ) [fa2c462d]
- class LayerOptionAction(argparse.Action): """ Custom argparse action for the `ogrinspect` `layer_key` keyword option which may be an integer or a string. """ [4b500834]
- class ListOptionAction(argparse.Action): """ Custom argparse action for `ogrinspect` keywords that require a string list. If the string is 'True'/'true' then the option value will be a boolean instead. """ [d141e3d0]
- from django.contrib.gis import gdal from django.core.management.base import BaseCommand, CommandError from django.utils.inspect import get_func_args [1bb38542]
- import argparse [b0b4b585]

## Beyond the budget

1 more facts did not fit in the budget: [6557343d]
