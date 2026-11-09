# Fact 40f43e09

Store id: 08368ac9-8e62-4c24-9ca9-47bcba591d3a

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
- posted_at: `2026-11-09T23:44:55.0535850+00:00`

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
  "id": "08368ac9-8e62-4c24-9ca9-47bcba591d3a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0535850+00:00"
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
  "subject_id": "8f9cccf4-0b9b-477a-a97c-d5ab77106d3e",
  "subject_name": "django/db/models/lookups::YearLookup",
  "tags": [
    "entity:class"
  ],
  "text": "class YearLookup(Lookup)"
}
```
