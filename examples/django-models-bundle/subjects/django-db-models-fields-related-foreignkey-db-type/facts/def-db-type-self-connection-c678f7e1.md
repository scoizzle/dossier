# Fact c678f7e1

Store id: ce38a216-7c1c-495a-9681-e3e1173b5936

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
- posted_at: `2026-11-09T22:39:44.4121120+00:00`

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
  "id": "ce38a216-7c1c-495a-9681-e3e1173b5936",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4121120+00:00"
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
  "subject_id": "839f812c-6f9d-4e68-b84d-04ed1eaae73f",
  "subject_name": "django/db/models/fields/related::ForeignKey.db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def db_type(self, connection)"
}
```
