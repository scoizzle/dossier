# Fact 40f43e09

Store id: 4cb6572b-a5f9-40e5-af29-3fcb6f55944b

## Text

```text
class YearLookup(Lookup)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.4096890+00:00`

## Data

```json
{
  "end_line": 750,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 712,
  "symbol": "YearLookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":712,"selector":"L712-L750","symbol":"YearLookup"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearLookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 750,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 712,
    "symbol": "YearLookup"
  },
  "id": "4cb6572b-a5f9-40e5-af29-3fcb6f55944b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.4096890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 712,
        "selector": "L712-L750",
        "symbol": "YearLookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "b8b8b462-abca-4e11-86b2-1ea37bc3c410",
  "subject_name": "django/db/models/lookups::YearLookup",
  "tags": [
    "entity:class"
  ],
  "text": "class YearLookup(Lookup)"
}
```
