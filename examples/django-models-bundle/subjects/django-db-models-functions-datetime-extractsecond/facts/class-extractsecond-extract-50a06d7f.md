# Fact 50a06d7f

Store id: dc0a2e01-81e7-42c6-80f8-13976d312fd4

## Text

```text
class ExtractSecond(Extract)
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
- posted_at: `2026-11-09T23:44:53.3647460+00:00`

## Data

```json
{
  "end_line": 180,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 179,
  "symbol": "ExtractSecond"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":179,"selector":"L179-L180","symbol":"ExtractSecond"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::ExtractSecond](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 180,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 179,
    "symbol": "ExtractSecond"
  },
  "id": "dc0a2e01-81e7-42c6-80f8-13976d312fd4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.3647460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 179,
        "selector": "L179-L180",
        "symbol": "ExtractSecond"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "e83acb46-1ef4-431c-8627-75b55de2bd69",
  "subject_name": "django/db/models/functions/datetime::ExtractSecond",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractSecond(Extract)"
}
```
