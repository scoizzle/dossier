# Fact 5595a75a

Store id: 3b33221b-7d57-4e94-a666-75951cb2c0ee

## Text

```text
def __init__(self, expression, output_field=None)
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
- posted_at: `2026-11-09T22:39:41.6162220+00:00`

## Data

```json
{
  "end_line": 1319,
  "entity_kind": "method",
  "parent": "DatabaseDefault",
  "start_line": 1317,
  "symbol": "DatabaseDefault.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1317,"selector":"L1317-L1319","symbol":"DatabaseDefault.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::DatabaseDefault.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1319,
    "entity_kind": "method",
    "parent": "DatabaseDefault",
    "start_line": 1317,
    "symbol": "DatabaseDefault.__init__"
  },
  "id": "3b33221b-7d57-4e94-a666-75951cb2c0ee",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6162220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1317,
        "selector": "L1317-L1319",
        "symbol": "DatabaseDefault.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "d8c24bfa-0546-4042-b168-4170b815eb9e",
  "subject_name": "django/db/models/expressions::DatabaseDefault.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, output_field=None)"
}
```
