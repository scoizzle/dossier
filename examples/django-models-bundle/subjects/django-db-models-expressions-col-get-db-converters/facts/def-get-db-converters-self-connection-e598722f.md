# Fact e598722f

Store id: 585d6202-7c44-4a41-b42b-8d919c0bb994

## Text

```text
def get_db_converters(self, connection)
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
- posted_at: `2026-11-09T23:31:55.8967830+00:00`

## Data

```json
{
  "end_line": 1387,
  "entity_kind": "method",
  "parent": "Col",
  "start_line": 1382,
  "symbol": "Col.get_db_converters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1382,"selector":"L1382-L1387","symbol":"Col.get_db_converters"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Col.get_db_converters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1387,
    "entity_kind": "method",
    "parent": "Col",
    "start_line": 1382,
    "symbol": "Col.get_db_converters"
  },
  "id": "585d6202-7c44-4a41-b42b-8d919c0bb994",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8967830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1382,
        "selector": "L1382-L1387",
        "symbol": "Col.get_db_converters"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "82c0ca00-2bf5-4c9e-9c37-7207950f7453",
  "subject_name": "django/db/models/expressions::Col.get_db_converters",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_converters(self, connection)"
}
```
