# Fact c678f7e1

Store id: 2a8c15e8-18fe-4a0e-a83f-1cfb3cdccc6c

## Text

```text
def db_type(self, connection)
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
- posted_at: `2026-11-09T23:44:51.6034180+00:00`

## Data

```json
{
  "end_line": 1317,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1316,
  "symbol": "ForeignKey.db_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1316,"selector":"L1316-L1317","symbol":"ForeignKey.db_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.db_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1317,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1316,
    "symbol": "ForeignKey.db_type"
  },
  "id": "2a8c15e8-18fe-4a0e-a83f-1cfb3cdccc6c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.6034180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1316,
        "selector": "L1316-L1317",
        "symbol": "ForeignKey.db_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "da5d332a-8f81-46aa-b6e2-7c1cb55852c9",
  "subject_name": "django/db/models/fields/related::ForeignKey.db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def db_type(self, connection)"
}
```
