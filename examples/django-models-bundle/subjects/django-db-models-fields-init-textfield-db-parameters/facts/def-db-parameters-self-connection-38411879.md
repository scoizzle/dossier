# Fact 38411879

Store id: a3f6eb79-81ca-4498-a8d8-1b1a4e0fcda0

## Text

```text
def db_parameters(self, connection)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.2403040+00:00`

## Data

```json
{
  "end_line": 2563,
  "entity_kind": "method",
  "parent": "TextField",
  "start_line": 2560,
  "symbol": "TextField.db_parameters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2560,"selector":"L2560-L2563","symbol":"TextField.db_parameters"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TextField.db_parameters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2563,
    "entity_kind": "method",
    "parent": "TextField",
    "start_line": 2560,
    "symbol": "TextField.db_parameters"
  },
  "id": "a3f6eb79-81ca-4498-a8d8-1b1a4e0fcda0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2403040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2560,
        "selector": "L2560-L2563",
        "symbol": "TextField.db_parameters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "7287d105-8f2f-438b-8a3c-b90f9a0d5433",
  "subject_name": "django/db/models/fields/__init__::TextField.db_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_parameters(self, connection)"
}
```
