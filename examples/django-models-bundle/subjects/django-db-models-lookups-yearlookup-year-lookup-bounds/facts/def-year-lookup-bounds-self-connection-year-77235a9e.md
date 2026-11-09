# Fact 77235a9e

Store id: dc234dd0-3611-4f8f-847f-d84209b62ce5

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
- posted_at: `2026-11-09T23:32:03.4134200+00:00`

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
  "id": "dc234dd0-3611-4f8f-847f-d84209b62ce5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.4134200+00:00"
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
  "subject_id": "f9fe0861-9b28-42fb-bca7-68819d7f7e2d",
  "subject_name": "django/db/models/lookups::YearLookup.year_lookup_bounds",
  "tags": [
    "entity:method"
  ],
  "text": "def year_lookup_bounds(self, connection, year)"
}
```
