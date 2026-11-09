# django/contrib/gis/db/backends/postgis/pgraster

- Subject: django/contrib/gis/db/backends/postgis/pgraster (id `08f795c3-0b86-4710-a1b5-f18d8be616ad`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 18 of 25
- Conflicts: 0
- Gaps: 0

## Facts

- # Add packed header and band data to result result += bandheader + band.data(as_memoryview=True) [dcac7578]
- # Append band data to band list bands.append(band_result) [27384396]
- # Chunk and unpack band data (pack size times nr of pixels) band, data = chunk(data, pack_size * header[10] * header[11]) band_result = {"data": bytes.fromhex(band)} [2f553394]
- # Convert datatype from PostGIS to GDAL & get pack type and size pixeltype = POSTGIS_TO_GDAL[pixeltype] pack_type = GDAL_TO_STRUCT[pixeltype] pack_size = 2 * STRUCT_SIZE[pack_type] [6cf04e8c]
- # Get band pixel type in PostGIS notation pixeltype = GDAL_TO_POSTGIS[band.datatype()] [730621d1]
- # Pack band header bandheader = pack(structure, (pixeltype, band.nodata_value or 0)) [68ff7ef9]
- # Parse band nodata value. The nodata value is part of the # PGRaster string even if the nodata flag is True, so it always # has to be chunked off the data string. nodata, data = chunk(data, pack_size) nodata = unpack(pack_type, nodata)[0] [9517c95f]
- # Set the nodata flag if band.nodata_value is not None: pixeltype |= BANDTYPE_FLAG_HASNODATA [0066f3fd]
- # Set the nodata value if the nodata flag is set. if pixeltype_with_flags & BANDTYPE_FLAG_HASNODATA: band_result["nodata_value"] = nodata [07631aa8]
- # Store pixeltype of this band in pixeltypes array pixeltypes.append(pixeltype) [0b2297f4]
- # Check that all bands have the same pixeltype. # This is required by GDAL. PostGIS rasters could have different pixeltypes # for bands of the same raster. if len(set(pixeltypes)) != 1: raise ValidationError("Band pixeltypes are not all equal.") [8693f118]
- # Pack raster header. result = pack(POSTGIS_HEADER_STRUCTURE, rasterheader) [d6d09e08]
- # Parse band data bands = [] pixeltypes = [] while data: # Get pixel type for this band pixeltype_with_flags, data = chunk(data, 2) pixeltype_with_flags = unpack("B", pixeltype_with_flags)[0] pixeltype = pixeltype_with_flags & BANDTYPE_PIXTYPE_MASK [7506997f]
- # Split raster header from data header, data = chunk(data, 122) header = unpack(POSTGIS_HEADER_STRUCTURE, header) [1767aa11]
- for band in rast.bands: # The PostGIS raster band header has exactly two elements, a 8BUI byte # and the nodata value. # # The 8BUI stores both the PostGIS pixel data type and a nodata flag. # It is composed as the datatype with BANDTYPE_FLAG_HASNODATA (1 << 6) # for existing nodata values: # 8BUI_VALUE = PG_PIXEL_TYPE (0-11) | BANDTYPE_FLAG_HASNODATA # # For example, if the byte value is 71, then the datatype is # 71 & ~BANDTYPE_FLAG_HASNODATA = 7 (32BSI) # and the nodata value is True. structure = "B" + GDAL_TO_STRUCT[band.datatype()] [54062551]
- return result [e6d2cf0b52c4ebca]
- return { "srid": int(header[9]), "width": header[10], "height": header[11], "datatype": pixeltypes[0], "origin": (header[5], header[6]), "scale": (header[3], header[4]), "skew": (header[7], header[8]), "bands": bands, } [3e02cfb8]
- def chunk(data, index): """ Split a string into two parts at the input index. """ return data[:index], data[index:] [3ac01ce5]

## Beyond the budget

7 more facts did not fit in the budget: [7f0c82cf] [e720ec5c] [ab5758fc] [45077564] [0e5503d8] [bec8a79d] [a774c3d9]
