# Fact 5d0b6050

Store id: b57ee50a-afb2-418a-a1d7-ec6ee2b000c7

## Text

```text
def _check_connector(cls, connector)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:50.0558650+00:00`

## Data

```json
{
  "end_line": 72,
  "entity_kind": "class_method",
  "parent": "Q",
  "start_line": 68,
  "symbol": "Q._check_connector"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":68,"selector":"L68-L72","symbol":"Q._check_connector"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q._check_connector](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 72,
    "entity_kind": "class_method",
    "parent": "Q",
    "start_line": 68,
    "symbol": "Q._check_connector"
  },
  "id": "b57ee50a-afb2-418a-a1d7-ec6ee2b000c7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.0558650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 68,
        "selector": "L68-L72",
        "symbol": "Q._check_connector"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "b9ece6b9-9b23-43cf-bab1-48f7b4944603",
  "subject_name": "django/db/models/query_utils::Q._check_connector",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_connector(cls, connector)"
}
```
