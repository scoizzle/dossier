# Fact 38411879

Store id: c9c06032-a214-46fa-ad39-0476a2ab54e1

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
- posted_at: `2026-11-09T22:39:42.6376760+00:00`

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
  "id": "c9c06032-a214-46fa-ad39-0476a2ab54e1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6376760+00:00"
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
  "subject_id": "9c255314-6a69-40da-8568-8e0ffbe475ce",
  "subject_name": "django/db/models/fields/__init__::TextField.db_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_parameters(self, connection)"
}
```
