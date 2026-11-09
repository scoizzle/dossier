# Fact 50a06d7f

Store id: 0a47428c-b28e-4583-8e6f-488b891a03d5

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
- posted_at: `2026-11-09T23:32:01.2241030+00:00`

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
  "id": "0a47428c-b28e-4583-8e6f-488b891a03d5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2241030+00:00"
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
  "subject_id": "7a916678-af9b-4e1a-bb6d-1d88ce29f97f",
  "subject_name": "django/db/models/functions/datetime::ExtractSecond",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractSecond(Extract)"
}
```
