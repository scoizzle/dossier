# Fact d1bbb8c4

Store id: c21c2eb9-49ce-4c24-84d6-6bb852ea1f32

## Text

```text
class AnyValue(Aggregate)
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
- posted_at: `2026-11-09T23:44:48.3978050+00:00`

## Data

```json
{
  "end_line": 237,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 226,
  "symbol": "AnyValue"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":226,"selector":"L226-L237","symbol":"AnyValue"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::AnyValue](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 237,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 226,
    "symbol": "AnyValue"
  },
  "id": "c21c2eb9-49ce-4c24-84d6-6bb852ea1f32",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3978050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 226,
        "selector": "L226-L237",
        "symbol": "AnyValue"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "7f0f9a31-0e9a-4dc4-98a1-170cf77a3c6d",
  "subject_name": "django/db/models/aggregates::AnyValue",
  "tags": [
    "entity:class"
  ],
  "text": "class AnyValue(Aggregate)"
}
```
