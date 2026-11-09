# Fact 96ae5316

Store id: 91f9ca7b-5cef-4387-94eb-fe3d5875f457

## Text

```text
class TruncBase(TimezoneMixin, Transform)
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
- posted_at: `2026-11-09T23:44:53.3792500+00:00`

## Data

```json
{
  "end_line": 345,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 244,
  "symbol": "TruncBase"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":244,"selector":"L244-L345","symbol":"TruncBase"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncBase](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 345,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 244,
    "symbol": "TruncBase"
  },
  "id": "91f9ca7b-5cef-4387-94eb-fe3d5875f457",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.3792500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 244,
        "selector": "L244-L345",
        "symbol": "TruncBase"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "055b5a1d-7692-4fd6-8f81-83197c7c97f6",
  "subject_name": "django/db/models/functions/datetime::TruncBase",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncBase(TimezoneMixin, Transform)"
}
```
