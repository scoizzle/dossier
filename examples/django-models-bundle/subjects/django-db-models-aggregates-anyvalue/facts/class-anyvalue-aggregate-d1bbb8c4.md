# Fact d1bbb8c4

Store id: 59227dff-75ee-4d0c-ac17-769b5c62070e

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
- posted_at: `2026-11-09T23:31:53.5354070+00:00`

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
  "id": "59227dff-75ee-4d0c-ac17-769b5c62070e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5354070+00:00"
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
  "subject_id": "d9555aaf-330b-47e4-8a78-ea7a9499b9b0",
  "subject_name": "django/db/models/aggregates::AnyValue",
  "tags": [
    "entity:class"
  ],
  "text": "class AnyValue(Aggregate)"
}
```
