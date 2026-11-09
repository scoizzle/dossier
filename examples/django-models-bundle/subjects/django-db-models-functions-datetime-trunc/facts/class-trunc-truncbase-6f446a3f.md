# Fact 6f446a3f

Store id: da743090-d921-4230-a431-01cbdd7adf12

## Text

```text
class Trunc(TruncBase)
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
- posted_at: `2026-11-09T22:39:46.1849460+00:00`

## Data

```json
{
  "end_line": 358,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 348,
  "symbol": "Trunc"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":348,"selector":"L348-L358","symbol":"Trunc"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::Trunc](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 358,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 348,
    "symbol": "Trunc"
  },
  "id": "da743090-d921-4230-a431-01cbdd7adf12",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1849460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 348,
        "selector": "L348-L358",
        "symbol": "Trunc"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "b91e21ec-55e6-4c91-ace2-d4f4023495ab",
  "subject_name": "django/db/models/functions/datetime::Trunc",
  "tags": [
    "entity:class"
  ],
  "text": "class Trunc(TruncBase)"
}
```
