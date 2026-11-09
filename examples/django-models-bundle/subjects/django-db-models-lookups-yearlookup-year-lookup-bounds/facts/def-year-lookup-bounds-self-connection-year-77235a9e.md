# Fact 77235a9e

Store id: 24b8f45e-4b09-43c6-baf4-5123ca9c5444

## Text

```text
def year_lookup_bounds(self, connection, year)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.2202580+00:00`

## Data

```json
{
  "end_line": 728,
  "entity_kind": "method",
  "parent": "YearLookup",
  "start_line": 713,
  "symbol": "YearLookup.year_lookup_bounds"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":713,"selector":"L713-L728","symbol":"YearLookup.year_lookup_bounds"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearLookup.year_lookup_bounds](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 728,
    "entity_kind": "method",
    "parent": "YearLookup",
    "start_line": 713,
    "symbol": "YearLookup.year_lookup_bounds"
  },
  "id": "24b8f45e-4b09-43c6-baf4-5123ca9c5444",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2202580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 713,
        "selector": "L713-L728",
        "symbol": "YearLookup.year_lookup_bounds"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "d24d81c1-273d-48e0-962d-8bd9843044af",
  "subject_name": "django/db/models/lookups::YearLookup.year_lookup_bounds",
  "tags": [
    "entity:method"
  ],
  "text": "def year_lookup_bounds(self, connection, year)"
}
```
