# Fact 49896c41

Store id: e7172e5e-c7ce-429b-b650-b25b947817da

## Text

```text
def referenced_fields(self)
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
- posted_at: `2026-11-09T23:44:50.8057390+00:00`

## Data

```json
{
  "end_line": 77,
  "entity_kind": "method",
  "parent": "GeneratedField",
  "start_line": 69,
  "symbol": "GeneratedField.referenced_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/generated.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":69,"selector":"L69-L77","symbol":"GeneratedField.referenced_fields"}`

## Referenced by

None.

## Subject

[django/db/models/fields/generated::GeneratedField.referenced_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 77,
    "entity_kind": "method",
    "parent": "GeneratedField",
    "start_line": 69,
    "symbol": "GeneratedField.referenced_fields"
  },
  "id": "e7172e5e-c7ce-429b-b650-b25b947817da",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.8057390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 69,
        "selector": "L69-L77",
        "symbol": "GeneratedField.referenced_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/generated.py"
    }
  ],
  "status": "live",
  "subject_id": "10400777-1d26-4f95-83f2-ccbce95f8038",
  "subject_name": "django/db/models/fields/generated::GeneratedField.referenced_fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def referenced_fields(self)"
}
```
