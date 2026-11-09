# Fact 6bd6f06e

Store id: d1563959-83dc-4629-bba7-a0af2aaf29df

## Text

```text
def allowed_default(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.1937170+00:00`

## Data

```json
{
  "end_line": 208,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 206,
  "symbol": "Lookup.allowed_default"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":206,"selector":"L206-L208","symbol":"Lookup.allowed_default"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.allowed_default](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 208,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 206,
    "symbol": "Lookup.allowed_default"
  },
  "id": "d1563959-83dc-4629-bba7-a0af2aaf29df",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.1937170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 206,
        "selector": "L206-L208",
        "symbol": "Lookup.allowed_default"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "b43b5f19-323c-419d-860f-38fcc85a8c21",
  "subject_name": "django/db/models/lookups::Lookup.allowed_default",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def allowed_default(self)"
}
```
