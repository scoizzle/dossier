# django/contrib/gis/geos/prototypes/io

- Subject: django/contrib/gis/geos/prototypes/io (id `e5746d66-0673-4e69-9281-fda80f53218b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 884 tokens
- Facts shown: 11 of 78
- Conflicts: 0
- Gaps: 0

## Facts

- byte_order_marker = wkb[offset] offset += 1 if byte_order_marker == 0: byte_order = "big" elif byte_order_marker == 1: byte_order = "little" else: raise GEOSException(_INVALID_WKB_MESSAGE) [6d40f760]
- frame.remaining_geometries -= 1 expected_types = frame.expected_types collection_depth = frame.collection_depth # Reject an incomplete header before reading its byte-order marker. if offset + _UINT32_SIZE + 1 > len(wkb): raise GEOSException(_INVALID_WKB_MESSAGE) [89093c41]
- if geometry_type == 1: # Point. skip(dimensions * _COORD_SIZE) elif geometry_type in (2, 8): # LineString or CircularString. num_points = read_uint32(byte_order) coordinate_size = dimensions * _COORD_SIZE skip(num_points * coordinate_size) elif geometry_type == 3: # Polygon. num_rings = read_uint32(byte_order) coordinate_size = dimensions * _COORD_SIZE for _ in range(num_rings): num_points = read_uint32(byte_order) skip(num_points * coordinate_size) elif geometry_type in _WKB_CHILD_TYPES: if num_geometries := read_uint32(byte_order): depth_stack.append( _WKBFrame( remaining_geometries=num_geometries, expected_types=_WKB_CHILD_TYPES[geometry_type], collection_depth=collection_depth, ) ) else: raise GEOSException(_INVALID_WKB_MESSAGE) [571842f5]
- if geometry_type == 7: collection_depth += 1 if collection_depth > max_geom_collections: msg = "WKB contains too many possible GeometryCollections." raise ValueError(msg) [5961e355]
- iso_type_range = (type_code & 0xFFFF) // 1000 has_z = bool(type_code & 0x80000000) or iso_type_range in (1, 3) has_m = bool(type_code & 0x40000000) or iso_type_range in (2, 3) dimensions = 2 + has_z + has_m if type_code & 0x20000000: # EWKB SRID flag. skip(_UINT32_SIZE) [c597e215]
- type_code = read_uint32(byte_order) # Match GEOS WKBReader's geometry-type normalization. geometry_type = (type_code & 0xFFFF) % 1000 if expected_types is not None and geometry_type not in expected_types: raise GEOSException(_INVALID_WKB_MESSAGE) [c6f570aa]
- # Validate the WKB structure and limit geometry collections before # handing input to recursive GEOS readers. This should become # unnecessary when GEOS 3.15.0 is the minimum supported version. See: # https://github.com/libgeos/geos/commit/8b8b3da7a3d9fb8953ff60bc49aa0320d51ae45c self.limit(wkb, max_geom_collections) return wkb_reader_read(self.ptr, wkb, len(wkb)) [16419c4e]
- def read_uint32(byte_order): nonlocal offset if offset + _UINT32_SIZE > len(wkb): raise GEOSException(_INVALID_WKB_MESSAGE) value = int.from_bytes(wkb[offset : offset + _UINT32_SIZE], byte_order) offset += _UINT32_SIZE return value [ee863016]
- def skip(length): nonlocal offset if length > len(wkb) - offset: raise GEOSException(_INVALID_WKB_MESSAGE) offset += length [037260db]
- if isinstance(geom, Point) and geom.empty: if self.srid: # PostGIS uses POINT(NaN NaN) for WKB representation of empty # points. Use it for EWKB as it's a PostGIS specific format. # https://trac.osgeo.org/postgis/ticket/3181 geom = Point(float("NaN"), float("NaN"), srid=geom.srid) else: raise ValueError("Empty point is not representable in WKB.") return geom [697632f6]
- offset = 0 depth_stack = [ _WKBFrame(remaining_geometries=1, expected_types=None, collection_depth=0) ] [9b0b58c5]

## Beyond the budget

65 more facts did not fit in the budget: [83a4e01a] [29f411b0] [ffbba5dd] [1bac21bd] [aafd6109] [6e498581] [dadb631b] [c9918f1e] [ae005998] [d1e0c087] [b1684cef] [42cb9fd2] [381b2802] [73dcaee8] [73e7e2e8] [a4b052f2] [455113f3] [84a36b64] [bf3f8971] [8732fc33] [16792c83] [a699bbb0] [3aca35a3] [2d3e7138] [aa219ddf] [be117e80] [aee67af0] [f1c96e44] [094f6fd6] [05bebcfd] [dfeca265] [fa8faadc] [4d8173dc] [d730f826] [eccea2fc] [5ea5d4bf] [7629dc40] [1d6a6fb7] [9a00a675] [f80ff645] [828fdea4] [8acda098] [1cd86a2c] [8265e6da] [1f0dac89] [f8d7f379] [64872559] [619a9548] [186a7c50] [414d4d28] [519c2252] [20191d69] [ad95cc6e] [8ed4853b] [ae3673f6] [397c03be] [57a86582] [abcdd294] [eaaa9e75] [5fe0069a] [17c4b4bf] [4fa28764] [7aee919c] [a39bf79d] [8bde2fb0]
