# Fact 0a198fb5

Store id: b91d5cd9-8064-4b20-a7ec-c9551a9090a0

## Text

```text
def db_check(self, connection)
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
- posted_at: `2026-11-09T23:44:51.6013690+00:00`

## Data

```json
{
  "end_line": 1314,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1313,
  "symbol": "ForeignKey.db_check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1313,"selector":"L1313-L1314","symbol":"ForeignKey.db_check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.db_check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1314,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1313,
    "symbol": "ForeignKey.db_check"
  },
  "id": "b91d5cd9-8064-4b20-a7ec-c9551a9090a0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6013690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1313,
        "selector": "L1313-L1314",
        "symbol": "ForeignKey.db_check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "20618049-693b-4b27-9f2b-0de2617d494e",
  "subject_name": "django/db/models/fields/related::ForeignKey.db_check",
  "tags": [
    "entity:method"
  ],
  "text": "def db_check(self, connection)"
}
```
