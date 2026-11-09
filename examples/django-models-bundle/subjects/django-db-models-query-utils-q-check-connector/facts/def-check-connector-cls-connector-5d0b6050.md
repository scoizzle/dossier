# Fact 5d0b6050

Store id: 014a5aea-0caf-44f5-9df5-f46bc65031b7

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
- posted_at: `2026-11-09T23:32:05.0390460+00:00`

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
  "id": "014a5aea-0caf-44f5-9df5-f46bc65031b7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.0390460+00:00"
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
  "subject_id": "447d1f8a-2172-4e73-9894-cd3aa28346b0",
  "subject_name": "django/db/models/query_utils::Q._check_connector",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_connector(cls, connector)"
}
```
