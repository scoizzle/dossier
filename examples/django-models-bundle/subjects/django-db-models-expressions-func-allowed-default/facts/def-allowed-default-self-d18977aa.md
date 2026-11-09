# Fact d18977aa

Store id: 0af3738c-75d9-4265-9b97-b1d5d30b3fcd

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
- posted_at: `2026-11-09T23:44:49.5146750+00:00`

## Data

```json
{
  "end_line": 1144,
  "entity_kind": "method",
  "parent": "Func",
  "start_line": 1142,
  "symbol": "Func.allowed_default"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1142,"selector":"L1142-L1144","symbol":"Func.allowed_default"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Func.allowed_default](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1144,
    "entity_kind": "method",
    "parent": "Func",
    "start_line": 1142,
    "symbol": "Func.allowed_default"
  },
  "id": "0af3738c-75d9-4265-9b97-b1d5d30b3fcd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5146750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1142,
        "selector": "L1142-L1144",
        "symbol": "Func.allowed_default"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "eea8bc15-667d-4de0-a8ef-32094af146f0",
  "subject_name": "django/db/models/expressions::Func.allowed_default",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def allowed_default(self)"
}
```
